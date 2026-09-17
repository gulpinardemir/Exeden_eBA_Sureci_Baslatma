# eBA Süreç Başlatma Entegrasyonu (EbaSurecBaslatma)

Bu proje, kurum dışı veya harici sistemlerden Bimser eBA (Elektronik Belge Akışı) platformuna bağlanarak otomatik iş akışı süreçleri başlatan bir C# entegrasyon uygulamasıdır. Kurumsal süreç otomasyonunu sağlamak amacıyla geliştirilmiştir.

## 🚀 Özellikler

- **eBA API Entegrasyonu:** Bimser eBA sistemine güvenli bir şekilde (Authentication) bağlanır.
- **Otomatik Süreç Tetikleme:** Belirlenen parametrelere göre sistemde yeni bir süreç başlatır.
- **Parametrik Veri Gönderimi:** Süreç başlatılırken gerekli olan başlangıç verilerini eBA formundaki ilgili alanlara aktarır.
- **Hata Yönetimi:** Bağlantı veya süreç başlatma sırasında oluşabilecek hataları yakalayarak loglar.

## 🛠️ Kullanılan Teknolojiler

- C# (.NET Framework)
- Bimser eBA API / Web Services
- Kurumsal İş Akışı (Enterprise Workflow) Yönetimi

## ⚙️ Kurulum ve Kullanım

1. Projeyi indirin ve Visual Studio ile açın.
2. `App.config` veya ilgili ayar dosyasında eBA sunucu adresini, entegrasyon kullanıcı adını ve şifresini güncelleyin.
3. Başlatılacak sürecin (Process) adını ve form parametrelerini kod içerisindeki ilgili alanlara tanımlayın.
4. Projeyi derleyip çalıştırın. Başarılı işlem sonucunda oluşan yeni sürecin "Flow ID" bilgisi konsola/loglara yazdırılacaktır.
