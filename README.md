
### **DataSyncManager**
<p align="center">
  <img src="https://github.com/Mertalkann/SheetDBManager/blob/main/SheetDBManager.png" alt="DataSyncManager">
</p>

**DataSyncManager** uygulaması, Google Sheets ve SQL veritabanı arasında veri senkronizasyonu sağlayan, kullanıcı dostu bir web uygulamasıdır. Kullanıcılar, Google hesapları ile giriş yaparak veri ekleme, güncelleme, silme ve sorgulama işlemlerini kolayca gerçekleştirebilirler.

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
   * SQL Server veya desteklenen başka bir veritabanı
* **Adımlar:**
   * Projeyi GitHub'dan klonlayın.
   * Visual Studio'da çözümü açın.
   * NuGet paketlerini yükleyin: `Google.Apis.Auth`, `Google.Apis.Sheets.v4`, `Microsoft.Extensions.Configuration`, `System.Data.SqlClient`.
   * `appsettings.json` dosyasında Google Sheets API kimlik bilgilerinizi ve veritabanı bağlantı dizesini güncelleyin.
   * Projeyi çalıştırın.

#### **Kullanım**

* **Giriş:** Google hesabınızla oturum açın.
* **Veri İşlemleri:**
   * **Ekleme:** Formu doldurarak yeni bir kayıt ekleyin.
   * **Güncelleme:** Kayıt ID'sini girerek mevcut bir kaydı güncelleyin.
   * **Silme:** Kayıt ID'sini girerek bir kaydı silin.
   * **Sorgulama:** Kayıt ID'sine göre bir kayıt alın.

#### **Ek Bilgiler**

* **Google Sheets API:** Google Sheets API'nin sunduğu tüm özelliklerden yararlanılabilir.
* **SQL Veritabanı:** SQL sorguları kullanarak karmaşık veri işlemleri yapılabilir.
* **Güvenlik:** Kullanıcıların Google hesapları ile giriş yapması sayesinde güvenlik sağlanır.

**Not:** Bu README.md dosyası, projenizin genel bir bakışını sunar. Daha detaylı bilgi için kodları inceleyebilirsiniz.

**GitHub Deposu:** [https://github.com/Mertalkann/SheetDBManager)

