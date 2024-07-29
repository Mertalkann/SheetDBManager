
### **SyncPortal**
<p align="center">
  <img src="https://github.com/Mertalkann/SheetDBManager/blob/main/SheetDBManager.png" alt="DataSyncManager">
</p>

**SyncPortal** Bu uygulama, kullanıcıların Google Sheets ve yerel bir veritabanı üzerinde CRUD işlemlerini kolaylıkla gerçekleştirebilmelerini sağlayan, entegre bir portal çözümü sunmaktadır.

#### **Projenin Çözdüğü Problemler:** 
* Veriye Erişimin Merkezi Bir Noktadan Yönetilmesi: Kullanıcılar, tek bir arayüz üzerinden hem bulut tabanlı (Google Sheets) hem de yerel veritabanına erişerek veri yönetimi işlemlerini gerçekleştirebilmektedir.
* Dış Kullanıcıların Sistemle Etkileşimi: Proje, dış kullanıcıların da sistemin iç işleyişine müdahale etmeden, güvenli bir şekilde veri giriş, güncelleme, silme ve sorgulama işlemlerini yapabilmelerine olanak tanımaktadır.

#### **Çalışma Prensibi**

1. **Google Sheets API Entegrasyonu:**
   
   * Google Cloud Console'da proje oluşturma ve API etkinleştirme.
   * OAuth 2.0 istemci kimliği oluşturma ve JSON dosyası indirme.
   * JSON dosyasındaki kimlik bilgileri ile Google Sheets API'ye bağlanma.
   * Sheets servisi kullanarak veri okuma, yazma ve güncelleme işlemleri.

3. **SQL Veritabanı Entegrasyonu:**
   
   * `appsettings.json` dosyasında veritabanı bağlantı dizesi tanımlama.
   * SqlConnection kullanarak veritabanına bağlanma.
   * SqlCommand ile SQL sorguları oluşturma ve veri işlemleri.

#### **Kurulum Adımları**

1. **Projeyi GitHub'dan klonlayın**
 ```sh
     git clone https://github.com/Mertalkann/SheetDBManager
```
3. **Visual Studio'da klonladığınız Solutionı açın**
4. **NuGet Paketlerinin Yüklenmesi**
   * Paket Yöneticisi Konsolu'nda aşağıdaki komutları çalıştırın:
```sh
  Install-Package Google.Apis.Sheets.v4
  Install-Package Google.Apis.Auth
  Install-Package Microsoft.Extensions.Configuration
  Install-Package System.Data.SqlClient
  Install-Package Newtonsoft.Json
```
4. **Google Sheets API key oluşturma:**
  1.**Google Cloud Platform'da Proje Oluşturma**
    * Google Cloud Console adresine gidin ve Google hesabınızla giriş yapın.
    * Sağ üst köşedeki proje seçim menüsüne tıklayın ve New Project butonuna tıklayın.
    * Projenize bir ad verin ve uygun bir yer belirleyin. Ardından Create butonuna tıklayın.
  2.**Google Sheets API'yi Etkinleştirme**
    * Sol menüden APIs & Services seçeneğine tıklayın ve ardından Library seçeneğine gidin.
    * Arama çubuğuna Google Sheets API yazın ve çıkan sonuca tıklayın.
    * Enable butonuna tıklayarak API'yi etkinleştirin.
  3.**OAuth 2.0 Yetkilendirmesi İçin İstemci Kimlik Bilgilerini Oluşturma**
    * APIs & Services menüsünden Credentials seçeneğine tıklayın.
    * Create Credentials butonuna tıklayın ve OAuth client ID seçeneğini seçin.
    * Eğer OAuth onay ekranını henüz yapılandırmadıysanız, Configure consent screen butonuna tıklayın. Aşağıdaki adımları izleyin:
       * User Type olarak External seçeneğini seçin ve Create butonuna tıklayın.
       * App Information kısmında, uygulamanıza bir ad verin (örneğin "Google Sheets Integration").
       * User Support Email alanında destek e-posta adresini seçin.
       * Authorized Domains kısmına localhost ekleyin.
       * Diğer gerekli bilgileri doldurun ve Save and Continue butonuna tıklayın.
       * Scopes ve Test Users adımlarını atlayarak Summary ekranına ulaşın ve Back to Dashboard butonuna tıklayın.
    * Şimdi Create Credentials butonuna tekrar tıklayın ve OAuth client ID seçeneğini seçin.
    * Application type olarak Desktop app seçeneğini seçin ve uygulamanız için bir ad girin (örneğin "Desktop Client").
    * Create butonuna tıklayın.
    * Oluşturulan istemci kimliğini ve istemci gizli anahtarını içeren bir JSON dosyası indirilecektir. Bu dosyanın adını credentials.json olarak değiştirin ve projenizin kök dizinine yerleştirin.

5. **appsettings.json Dosyasının Düzenlenmesi**
   * Projenizin kök dizinindeki appsettings.json dosyasını bir metin editörü ile açın.
   * Google Sheets API Kimlik Bilgileri: İndirdiğiniz credentials.json dosyasındaki client_id ve client_secret değerlerini appsettings.json dosyasındaki ilgili bölümlere yapıştırın.
   * Veritabanı Bağlantı Dizesi: Kendi veritabanınız için geçerli bağlantı dizesini ConnectionStrings bölümüne ekleyin. Örneğin:
 ```sh
 {
    "ConnectionStrings": {
      "DefaultConnection": "Server=yourServerName;Database=YourDB;User Id=UserName;Password=password;"
    },
    "GoogleSheets": {
      "ApplicationName": "YourAplicationName", 
      "SpreadsheetId": "SheetTableId", //https://docs.google.com/spreadsheets/d/YourSpreadsheetId
      "Sheet": "SheetTableName",
      "CredentialsPath": "credentials.json"
    }
  }
```
6. **Projenin Çalıştırılması: F5 tuşuna basarak veya başlat düğmesine tıklayarak projeyi çalıştırın.** 




**Not:** Bu README.md dosyası, projenizin genel bir bakışını sunar. Daha detaylı bilgi için kodları inceleyebilirsiniz.

**GitHub Deposu:** [https://github.com/Mertalkann/SheetDBManager)

