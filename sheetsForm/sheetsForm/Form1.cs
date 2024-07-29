using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace sheetsForm
{
    public partial class Form1 : Form
    {
        // Google Sheets API eri�im izinleri
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        SheetsService service; // Google Sheets API servisi
        private readonly IConfiguration Configuration; // Uygulama yap�land�rmas�

        // Form olu�turucu
        public Form1()
        {
            InitializeComponent();
            // Yap�land�rma dosyas�n� y�kle
            Configuration = LoadConfiguration();
            // Kimlik do�rulamas�n� ger�ekle�tir
            UserCredential credential = AuthenticateUser();
            // Google Sheets servisini ba�lat
            InitializeGoogleSheetsService(credential);
        }

        // Yap�land�rma dosyas�n� y�kler
        private IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }

        // Veritaban� ba�lant� dizesini d�nd�r�r
        private string GetConnectionString()
        {
            return Configuration.GetConnectionString("DefaultConnection");
        }

        // Kullan�c� kimlik do�rulamas�n� ger�ekle�tirir
        private UserCredential AuthenticateUser()
        {
            UserCredential credential;
            var credPath = Configuration["GoogleSheets:CredentialsPath"];

            using (var stream = new FileStream(credPath, FileMode.Open, FileAccess.Read))
            {
                string tokenPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "tokens");
                if (Directory.Exists(tokenPath))
                {
                    Directory.Delete(tokenPath, true);
                }
                // Kimlik do�rulamas� yapar ve token'� kaydeder
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(tokenPath, false)).Result;
            }

            return credential;
        }

        // Google Sheets servisini ba�lat�r
        private void InitializeGoogleSheetsService(UserCredential credential)
        {
            var applicationName = Configuration["GoogleSheets:ApplicationName"];

            // Google Sheets API servisini olu�turur
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });
        }

        // Google Sheets'teki verileri g�nceller
        private void btnUpdateSheet_Click(object sender, EventArgs e)
        {
            try
            {
                var spreadsheetId = Configuration["GoogleSheets:SpreadsheetId"];
                var idToUpdate = txtUpdateId.Text; // G�ncellenecek ID

                // 1. Ad�m: Verileri al
                var range = $"B:E";
                var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;

                if (values != null && values.Count > 0)
                {
                    int rowNumber = -1;
                    for (int i = 0; i < values.Count; i++)
                    {
                        var row = values[i];
                        if (row.Count > 0 && row[0].ToString() == idToUpdate)
                        {
                            rowNumber = i + 1; // Sat�r numaras�n� bul
                            break;
                        }
                    }

                    if (rowNumber == -1)
                    {
                        MessageBox.Show("ID bulunamad�!");
                        return;
                    }

                    // 2. Ad�m: Sat�r� g�ncelle
                    var updateRange = $"B{rowNumber}:E{rowNumber}";
                    var valueRange = new ValueRange();
                    var oblist = new List<object>() { txtUpdateId.Text, txtUpdateName.Text, txtUpdateSurname.Text, txtUpdateDepartment.Text };
                    valueRange.Values = new List<IList<object>> { oblist };

                    var updateRequest = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, updateRange);
                    updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
                    var updateResponse = updateRequest.Execute();

                    MessageBox.Show("Data updated successfully in Google Sheets!");
                }
                else
                {
                    MessageBox.Show("Sheet is empty or not found.");
                }
            }
            catch (Google.GoogleApiException ex)
            {
                MessageBox.Show($"Google API Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Google Sheets'teki verileri siler
        private void btnDeleteSheet_Click(object sender, EventArgs e)
        {
            try
            {
                var spreadsheetId = Configuration["GoogleSheets:SpreadsheetId"];
                var range = $"B:E"; // ID'den ilgili verileri �ekece�imiz geni� aral�k

                var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;

                if (values != null && values.Count > 0)
                {
                    bool found = false;
                    int rowIndex = 0;
                    foreach (var row in values)
                    {
                        if (row.Count > 0 && row[0].ToString() == txtDelete.Text)
                        {
                            found = true;
                            break;
                        }
                        rowIndex++;
                    }

                    if (found)
                    {
                        // Sat�r numaras�n� belirledikten sonra silme i�lemi
                        var deleteRange = $"B{rowIndex + 1}:E{rowIndex + 1}"; // 1 eklememizin sebebi, sat�r indeksinin 1'den ba�lamas�d�r.
                        var clearRequest = service.Spreadsheets.Values.Clear(new ClearValuesRequest(), spreadsheetId, deleteRange);
                        var clearResponse = clearRequest.Execute();
                        MessageBox.Show("Data deleted successfully in Google Sheets!");
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given ID.");
                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Google.GoogleApiException ex)
            {
                MessageBox.Show($"Google API Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Google Sheets'ten verileri �eker ve formda g�sterir
        private void btnFetchSheet_Click_1(object sender, EventArgs e)
        {
            try
            {
                var spreadsheetId = Configuration["GoogleSheets:SpreadsheetId"];
                var range = $"B:E"; // ID'den ilgili verileri �ekece�imiz geni� aral�k

                var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;

                if (values != null && values.Count > 0)
                {
                    bool found = false;
                    foreach (var row in values)
                    {
                        if (row.Count > 0 && row[0].ToString() == txtFetchId.Text)
                        {
                            lblName.Text = row.Count > 1 && !string.IsNullOrEmpty(row[1].ToString()) ? row[1].ToString() : "null";
                            lblSurname.Text = row.Count > 2 && !string.IsNullOrEmpty(row[2].ToString()) ? row[2].ToString() : "null";
                            lblDepartment.Text = row.Count > 3 && !string.IsNullOrEmpty(row[3].ToString()) ? row[3].ToString() : "null";
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        MessageBox.Show("No data found for the given ID.");
                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Google.GoogleApiException ex)
            {
                MessageBox.Show($"Google API Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Google Sheets'e yeni veri ekler
        private void btnSheet_Click(object sender, EventArgs e)
        {
            try
            {
                var spreadsheetId = Configuration["GoogleSheets:SpreadsheetId"];
                var range = $"B2:E2"; // Ba�lang�� aral���
                var valueRange = new ValueRange();
                var oblist = new List<object>() { txtId.Text, txtName.Text, txtSurname.Text, txtDepartment.Text };
                valueRange.Values = new List<IList<object>> { oblist };

                // Veriyi ekler
                var appendRequest = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
                appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                var appendResponse = appendRequest.Execute();

                MessageBox.Show("Data added successfully!");
            }
            catch (Google.GoogleApiException ex)
            {
                MessageBox.Show($"Google API Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Veritaban� verilerini Google Sheets'e aktar�r
        private void btnImportData_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritaban� ba�lant� dizesini al
                var connectionString = GetConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL sorgusunu tan�mla
                    string query = "SELECT Id, Name, Surname, Department FROM MyTable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var spreadsheetId = Configuration["GoogleSheets:SpreadsheetId"];
                            var range = "B2"; // Veriyi ekleyece�imiz ba�lang�� h�cresi
                            var valueRange = new ValueRange();

                            var data = new List<IList<object>>();
                            while (reader.Read())
                            {
                                var row = new List<object>
                                {
                                    reader["Id"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Surname"].ToString(),
                                    reader["Department"].ToString()
                                };
                                data.Add(row);
                            }
                            valueRange.Values = data;

                            // Verileri Google Sheets'e ekler
                            var appendRequest = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
                            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                            var appendResponse = appendRequest.Execute();

                            MessageBox.Show("Data imported to Google Sheets successfully!");
                        }
                    }
                }
            }
            catch (Google.GoogleApiException ex)
            {
                MessageBox.Show($"Google API Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    

    private void btnDb_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                string query = "INSERT INTO Users (Id, Name, Surname, Deparment) VALUES (@Id, @Name, @Surname, @Department)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data added to DB successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnUpdateDb_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Deparment = @Department WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtUpdateId.Text);
                cmd.Parameters.AddWithValue("@Name", txtUpdateName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtUpdateSurname.Text);
                cmd.Parameters.AddWithValue("@Department", txtUpdateDepartment.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated in DB successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No data found with the given ID.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDeleteDb_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                string query = "DELETE FROM Users WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtDelete.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted from DB successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No data found with the given ID.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnFetchDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                string query = "SELECT Name, Surname, Deparment FROM Users WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtFetchId.Text);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblName.Text = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : "null";
                        lblSurname.Text = reader["Surname"] != DBNull.Value ? reader["Surname"].ToString() : "null";
                        lblDepartment.Text = reader["Deparment"] != DBNull.Value ? reader["Deparment"].ToString() : "null";
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given ID.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

