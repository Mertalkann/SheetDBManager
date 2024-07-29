
### **SyncPortal**
<p align="center">
  <img src="https://github.com/Mertalkann/SheetDBManager/blob/main/SheetDBManager.png" alt="DataSyncManager">
</p>

**SyncPortal** uygulaması, Google Sheets ve SQL veritabanı arasında veri senkronizasyonu sağlayan, kullanıcı dostu bir web uygulamasıdır. Kullanıcılar, Google hesapları ile giriş yaparak veri ekleme, güncelleme, silme ve sorgulama işlemlerini kolayca gerçekleştirebilirler.

#### **Özellikler**

* **Google Hesabı ile Giriş:** Güvenli ve kolay erişim için Google kimlik doğrulaması.
* **CRUD İşlemleri:** Google Sheets ve SQL veritabanında veri ekleme, güncelleme, silme ve okuma işlemleri.
* **Google Sheets Entegrasyonu:** Google Sheets API kullanılarak verilerle etkileşim.
* **SQL Veritabanı Entegrasyonu:** SQL sorguları ile veritabanı işlemleri.

#### **Çalışma Prensibi**

1. **Google Sheets API Entegrasyonu:**
   * Google Cloud Console'da proje oluşturma ve API etkinleştirme.
   * OAuth 2.0 istemci kimliği oluşturma ve JSON dosyası indirme.
   * JSON dosyasındaki kimlik bilgileri ile Google Sheets API'ye bağlanma.
   * Sheets servisi kullanarak veri okuma, yazma ve güncelleme işlemleri.

2. **SQL Veritabanı Entegrasyonu:**
   * `appsettings.json` dosyasında veritabanı bağlantı dizesi tanımlama.
   * SqlConnection kullanarak veritabanına bağlanma.
   * SqlCommand ile SQL sorguları oluşturma ve veri işlemleri.

#### **Kurulum**

* **Gereksinimler:**
   * Visual Studio 2019 veya üzeri
   * .NET Framework 4.7.2 veya üzeri
   * Google Sheets API kimlik bilgileri JSON dosyası
   * SQL Server veya desteklenen başka bir veritabanı,
     
* **Adımlar:**
   * Projeyi GitHub'dan klonlayın.
   * Visual Studio'da çözümü açın.
   * NuGet paketlerini yükleyin: `Google.Apis.Auth`, `Google.Apis.Sheets.v4`, `Microsoft.Extensions.Configuration`, `System.Data.SqlClient`.
   * `appsettings.json` dosyasında Google Sheets API kimlik bilgilerinizi ve veritabanı bağlantı dizesini güncelleyin.
   * Projeyi çalıştırın.
 
#### **Google Sheets API key oluşturma:**

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

4.**Gerekli NuGet Paketlerini Yükleme**
Google Sheets API'yi kullanabilmek için gerekli NuGet paketlerini yükleyin:
Tools > NuGet Package Manager > Package Manager Console yolunu izleyin.
Aşağıdaki komutları kullanarak gerekli paketleri yükleyin:

* Install-Package Google.Apis.Sheets.v4
* Install-Package Google.Apis.Auth
* Install-Package Newtonsoft.Json

#### **Kullanım**

* **Giriş:** Google hesabınızla oturum açın.
* **Veri İşlemleri:**
   * **Ekleme:** Formu doldurarak yeni bir kayıt ekleyin.
   * **Güncelleme:** Kayıt ID'sini girerek mevcut bir kaydı güncelleyin.
   * **Silme:** Kayıt ID'sini girerek bir kaydı silin.
   * **Sorgulama:** Kayıt ID'sine göre bir kayıt alın.
  
**Not:** Bu README.md dosyası, projenizin genel bir bakışını sunar. Daha detaylı bilgi için kodları inceleyebilirsiniz.

**GitHub Deposu:** [https://github.com/Mertalkann/SheetDBManager)

