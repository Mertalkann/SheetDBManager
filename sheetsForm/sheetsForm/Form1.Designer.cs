namespace sheetsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnDb = new Button();
            btnSheet = new Button();
            label4 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtSurname = new TextBox();
            label1 = new Label();
            txtDepartment = new TextBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            btnUpdateDB = new Button();
            txtUpdateId = new TextBox();
            btnUpdateSheet = new Button();
            label10 = new Label();
            txtUpdateSurname = new TextBox();
            txtUpdateName = new TextBox();
            txtUpdateDepartment = new TextBox();
            label11 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            btnDeleteDB = new Button();
            btnDeleteSheet = new Button();
            txtDelete = new TextBox();
            label22 = new Label();
            groupBox2 = new GroupBox();
            lblDepartment = new Label();
            lblSurname = new Label();
            lblName = new Label();
            btnFetchDB = new Button();
            btnFetchSheet = new Button();
            label5 = new Label();
            txtFetchId = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDb);
            groupBox1.Controls.Add(btnSheet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDepartment);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 232);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Data";
            // 
            // btnDb
            // 
            btnDb.Font = new Font("Segoe UI", 12F);
            btnDb.Location = new Point(150, 175);
            btnDb.Name = "btnDb";
            btnDb.Size = new Size(114, 39);
            btnDb.TabIndex = 19;
            btnDb.Text = "Add DB";
            btnDb.UseVisualStyleBackColor = true;
            btnDb.Click += btnDb_Click;
            // 
            // btnSheet
            // 
            btnSheet.Font = new Font("Segoe UI", 12F);
            btnSheet.Location = new Point(13, 175);
            btnSheet.Name = "btnSheet";
            btnSheet.Size = new Size(114, 39);
            btnSheet.TabIndex = 10;
            btnSheet.Text = "Add Sheet";
            btnSheet.UseVisualStyleBackColor = true;
            btnSheet.Click += btnSheet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 132);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 18;
            label4.Text = "Department:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(115, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(149, 29);
            txtId.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 97);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 17;
            label3.Text = "Surname:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(115, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 29);
            txtName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(54, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F);
            txtSurname.Location = new Point(115, 94);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(149, 29);
            txtSurname.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(83, 27);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 15;
            label1.Text = "Id:";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 12F);
            txtDepartment.Location = new Point(115, 129);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(149, 29);
            txtDepartment.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnUpdateDB);
            groupBox3.Controls.Add(txtUpdateId);
            groupBox3.Controls.Add(btnUpdateSheet);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtUpdateSurname);
            groupBox3.Controls.Add(txtUpdateName);
            groupBox3.Controls.Add(txtUpdateDepartment);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(320, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 232);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update Data";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(13, 135);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 32;
            label9.Text = "Department:";
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Font = new Font("Segoe UI", 12F);
            btnUpdateDB.Location = new Point(150, 175);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(114, 39);
            btnUpdateDB.TabIndex = 19;
            btnUpdateDB.Text = "Update DB";
            btnUpdateDB.UseVisualStyleBackColor = true;
            btnUpdateDB.Click += btnUpdateDb_Click;
            // 
            // txtUpdateId
            // 
            txtUpdateId.Font = new Font("Segoe UI", 12F);
            txtUpdateId.Location = new Point(115, 27);
            txtUpdateId.Name = "txtUpdateId";
            txtUpdateId.Size = new Size(149, 29);
            txtUpdateId.TabIndex = 25;
            // 
            // btnUpdateSheet
            // 
            btnUpdateSheet.Font = new Font("Segoe UI", 12F);
            btnUpdateSheet.Location = new Point(13, 175);
            btnUpdateSheet.Name = "btnUpdateSheet";
            btnUpdateSheet.Size = new Size(114, 39);
            btnUpdateSheet.TabIndex = 10;
            btnUpdateSheet.Text = "Update Sheet";
            btnUpdateSheet.UseVisualStyleBackColor = true;
            btnUpdateSheet.Click += btnUpdateSheet_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(33, 100);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 31;
            label10.Text = "Surname:";
            // 
            // txtUpdateSurname
            // 
            txtUpdateSurname.Font = new Font("Segoe UI", 12F);
            txtUpdateSurname.Location = new Point(115, 97);
            txtUpdateSurname.Name = "txtUpdateSurname";
            txtUpdateSurname.Size = new Size(149, 29);
            txtUpdateSurname.TabIndex = 27;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Font = new Font("Segoe UI", 12F);
            txtUpdateName.Location = new Point(115, 62);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(149, 29);
            txtUpdateName.TabIndex = 26;
            // 
            // txtUpdateDepartment
            // 
            txtUpdateDepartment.Font = new Font("Segoe UI", 12F);
            txtUpdateDepartment.Location = new Point(115, 132);
            txtUpdateDepartment.Name = "txtUpdateDepartment";
            txtUpdateDepartment.Size = new Size(149, 29);
            txtUpdateDepartment.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(54, 65);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 30;
            label11.Text = "Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(83, 30);
            label12.Name = "label12";
            label12.Size = new Size(26, 21);
            label12.TabIndex = 29;
            label12.Text = "Id:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDeleteDB);
            groupBox4.Controls.Add(btnDeleteSheet);
            groupBox4.Controls.Add(txtDelete);
            groupBox4.Controls.Add(label22);
            groupBox4.Location = new Point(626, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(276, 232);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Delete Data";
            // 
            // btnDeleteDB
            // 
            btnDeleteDB.Font = new Font("Segoe UI", 12F);
            btnDeleteDB.Location = new Point(150, 175);
            btnDeleteDB.Name = "btnDeleteDB";
            btnDeleteDB.Size = new Size(114, 39);
            btnDeleteDB.TabIndex = 19;
            btnDeleteDB.Text = "Delete DB";
            btnDeleteDB.UseVisualStyleBackColor = true;
            btnDeleteDB.Click += btnDeleteDb_Click;
            // 
            // btnDeleteSheet
            // 
            btnDeleteSheet.Font = new Font("Segoe UI", 12F);
            btnDeleteSheet.Location = new Point(13, 175);
            btnDeleteSheet.Name = "btnDeleteSheet";
            btnDeleteSheet.Size = new Size(114, 39);
            btnDeleteSheet.TabIndex = 10;
            btnDeleteSheet.Text = "Delete Sheet";
            btnDeleteSheet.UseVisualStyleBackColor = true;
            btnDeleteSheet.Click += btnDeleteSheet_Click;
            // 
            // txtDelete
            // 
            txtDelete.Font = new Font("Segoe UI", 12F);
            txtDelete.Location = new Point(71, 79);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(149, 29);
            txtDelete.TabIndex = 11;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(44, 82);
            label22.Name = "label22";
            label22.Size = new Size(26, 21);
            label22.TabIndex = 15;
            label22.Text = "Id:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblDepartment);
            groupBox2.Controls.Add(lblSurname);
            groupBox2.Controls.Add(lblName);
            groupBox2.Controls.Add(btnFetchDB);
            groupBox2.Controls.Add(btnFetchSheet);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtFetchId);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(936, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 232);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fetch Data";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 12F);
            lblDepartment.Location = new Point(162, 138);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(28, 21);
            lblDepartment.TabIndex = 22;
            lblDepartment.Text = "00";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 12F);
            lblSurname.Location = new Point(162, 102);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(28, 21);
            lblSurname.TabIndex = 21;
            lblSurname.Text = "00";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(162, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(28, 21);
            lblName.TabIndex = 20;
            lblName.Text = "00";
            // 
            // btnFetchDB
            // 
            btnFetchDB.Font = new Font("Segoe UI", 12F);
            btnFetchDB.Location = new Point(150, 175);
            btnFetchDB.Name = "btnFetchDB";
            btnFetchDB.Size = new Size(114, 39);
            btnFetchDB.TabIndex = 19;
            btnFetchDB.Text = "Fetch DB";
            btnFetchDB.UseVisualStyleBackColor = true;
            btnFetchDB.Click += btnFetchDB_Click;
            // 
            // btnFetchSheet
            // 
            btnFetchSheet.Font = new Font("Segoe UI", 12F);
            btnFetchSheet.Location = new Point(13, 175);
            btnFetchSheet.Name = "btnFetchSheet";
            btnFetchSheet.Size = new Size(114, 39);
            btnFetchSheet.TabIndex = 10;
            btnFetchSheet.Text = "Fetch Sheet";
            btnFetchSheet.UseVisualStyleBackColor = true;
            btnFetchSheet.Click += btnFetchSheet_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(69, 137);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 18;
            label5.Text = "Department:";
            // 
            // txtFetchId
            // 
            txtFetchId.Font = new Font("Segoe UI", 12F);
            txtFetchId.Location = new Point(69, 27);
            txtFetchId.Name = "txtFetchId";
            txtFetchId.Size = new Size(149, 29);
            txtFetchId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(89, 102);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 17;
            label6.Text = "Surname:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(110, 67);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 16;
            label7.Text = "Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(42, 30);
            label8.Name = "label8";
            label8.Size = new Size(26, 21);
            label8.TabIndex = 15;
            label8.Text = "Id:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 338);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDb;
        private Button btnSheet;
        private Label label4;
        private TextBox txtId;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSurname;
        private Label label1;
        private TextBox txtDepartment;
        private GroupBox groupBox3;
        private Button btnUpdateDB;
        private Button btnUpdateSheet;
        private GroupBox groupBox4;
        private Button btnDeleteDB;
        private Button btnDeleteSheet;
        private TextBox txtDelete;
        private Label label22;
        private GroupBox groupBox2;
        private Label lblDepartment;
        private Label lblSurname;
        private Label lblName;
        private Button btnFetchDB;
        private Button btnFetchSheet;
        private Label label5;
        private TextBox txtFetchId;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtUpdateId;
        private Label label10;
        private TextBox txtUpdateSurname;
        private TextBox txtUpdateName;
        private TextBox txtUpdateDepartment;
        private Label label11;
        private Label label12;
    }
}
