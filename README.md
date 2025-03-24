# Cafe Yönetim Sistemi

Bu proje, cafe ve restoranlar için geliştirilmiş kapsamlı bir yönetim sistemidir. C# ve SQL Server kullanılarak geliştirilmiştir.

## Özellikler

### Admin Paneli
- Kullanıcı yönetimi (garson, admin ekleme/düzenleme)
- Ürün yönetimi
- Tedarikçi yönetimi
- Kategori yönetimi
- Masa yönetimi
- Detaylı raporlama sistemi

### Garson Paneli
- Sipariş alma ve yönetme
- Masa durumu takibi
- Sipariş birleştirme
- Hesap alma ve ödeme işlemleri

### Raporlama
- Günlük satış raporları
- Aylık satış raporları
- Ürün bazlı satış analizi
- Garson performans takibi
- Word formatında rapor çıktısı

## Teknolojiler
- C# Windows Forms
- Microsoft SQL Server
- DocumentFormat.OpenXml (Raporlama için)

## Veritabanı Yapısı

### Tablolar
- `kullanici`: Personel ve admin bilgileri
- `urun`: Ürün kataloğu
- `kategori`: Ürün kategorileri
- `siparis`: Sipariş kayıtları
- `masa`: Masa durumları
- `tedarikci`: Tedarikçi bilgileri

## Kurulum

1. SQL Server'ı yükleyin
2. Veritabanını oluşturun:
   ```sql
   CREATE DATABASE Cafe
   ```
3. Projeyi Visual Studio'da açın
4. NuGet paketlerini yükleyin:
   - DocumentFormat.OpenXml
5. Connection string'i kendi SQL Server ayarlarınıza göre düzenleyin
6. Projeyi derleyin ve çalıştırın
7. Ek olarak  "Server=PROTESQ;Database=Cafe;Integrated Security=True" kısmında server ismi sizde farklı olabilir, kontrol ediniz !

## Kullanım

### Admin Girişi
- Kullanıcı adı ve şifre ile giriş yapın
- Admin panelinden sistem ayarlarını yönetin

### Garson Girişi
- Garson hesabıyla giriş yapın
- Siparişleri yönetin ve hesap işlemlerini gerçekleştirin

## Katkıda Bulunma
1. Bu depoyu fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/YeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/YeniOzellik`)
5. Pull Request oluşturun
