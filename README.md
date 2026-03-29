Proje Konusu: Teknik Servis ve Arıza Takip Otomasyonu

Bizim ekleyeceğimiz farklı özellikler:

Kronik Arıza Alarmı: Diyelim ki servise bir "iPhone 13" geldi ve sorunu "Ekran Titremesi". Sistem veri tabanına bakacak; eğer son 1 ayda gelen 10 tane iPhone 13'ün 8'i aynı sorundan geldiyse, teknisyenin önüne büyük bir uyarı çıkaracak: "DİKKAT: Bu modelde kronik ekran arızası tespit edildi! Yedek parça stoklarını kontrol edin."
2.Cihazın Geçmişi: Cihazı seri numarasından (IMEI veya Serial No) tanıdığı için, cihaz 2 yıl sonra tekrar gelirse; "Bu cihaz daha önce 3 kez batarya değişimine gelmiş, artık batarya değil anakartı kontrol etmelisiniz" diyecek. Yani cihazın bir "Sağlık Karnesi" olacak.

Veri Tabanında Bu İş Nasıl Dönecek?

Table_Devices: Sadece cihaz adı değil, her cihazın Unique Serial Number kaydı.

Table_FaultAnalysis: Hangi markanın hangi modelinin hangi arızadan kaç kere geldiğinin istatistiğini tutan bir "View" veya "Stored Procedure".

Table_ActionLog: Teknisyenin cihaz üzerinde yaptığı her işlemin saniye saniye kaydı.

3 Kişi Arasında Kod Dağılımı: 1.kişi (Backend & SQL Expert): Visual Studio, MS SQL Server 2.kişi (Frontend & Modern UI): Visual Studio, Guna UI Framework, Figma 3.kişi (Raporlama & Admin): Visual Studio, Draw.io, Github: kod entegrasyon
