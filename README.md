# Code16 - Oyun Akademisi Bitirme Projesi

Bu proje, **ağaçların sulama ve gübreleme sistemini otomasyonlaştırmaya yönelik bir oyun** geliştirme fikriyle oluşturulmuştur. Oyuncular, belirli kaynakları kullanarak ağaç ve bina yerleştirebilir, kaynakları yönetebilir ve verimliliklerini artırabilirler.

## Özellikler

- **Bina Yerleştirme**:
  - Oyuncular belirli bir maliyetle bina ve ağaç yerleştirebilir.
  - İnteraktif bir yerleştirme göstergesiyle pozisyon belirleme.

- **Kaynak Yönetimi**:
  - Ağaçlardan ve binalardan düzenli aralıklarla gelir elde edilir.
  - Oyuncular para birikimi ile yeni yapılar inşa edebilir.

- **Ses Efektleri**:
  - Oyun sırasında ses efektleri ve geri bildirimler sunar.
  - Ses açma/kapama seçenekleri.

- **Kullanıcı Arayüzü**:
  - Çoklu canvas yapısı ile farklı arayüzler.
  - Şehir, ayarlar ve bilgi ekranları arasında kolay geçiş.

## Kullanılan Teknolojiler

- **Unity**: Oyun geliştirme platformu.
- **C#**: Oyun davranışlarının kodlanması için kullanılan programlama dili.
- **TextMeshPro**: Arayüzde metinlerin özelleştirilmesi.
- **ScriptableObjects**: Yerleştirme maliyetleri ve bina verimliliği gibi veri yönetimi.

## Proje Yapısı

Proje şu şekilde yapılandırılmıştır:

- **`bilgisayfası.cs`**:
  - Farklı arayüzler (canvas) arasında geçiş yapmayı sağlar.

- **`building.cs`**:
  - Yerleştirilen binalar için temel yapı sınıfıdır.

- **`buildingplacement.cs`**:
  - Bina yerleştirme işlevlerini ve pozisyonlamayı yönetir.

- **`butonlar.cs`**:
  - Oyuncu etkileşimlerini (örneğin ses açma/kapama) yönetir.

- **`city.cs`**:
  - Oyunun ana kaynak yönetimi ve gelir üretimi mantığını içerir.

- **`selector.cs`**:
  - Oyuncunun imleç pozisyonunu belirlemek için kullanılır.

- **`ses.cs`**:
  - Oyun içi ses efektlerini ve müzikleri kontrol eder.

- **`yerlestirme.cs`**:
  - ScriptableObject ile bina yerleştirme maliyet ve verimlilik ayarlarını depolar.

## Nasıl Çalıştırılır?

1. **Proje Dosyalarını Klonlayın**:
   ```bash
   git clone https://github.com/kullanici-adi/proje-adi.git
   cd proje-adi
