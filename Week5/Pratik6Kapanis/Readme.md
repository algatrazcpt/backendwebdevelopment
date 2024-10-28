# Pratik6Kapanis

## Araba Üretim Konsol Uygulamasý
Bu proje, bir araba üretim sürecini simüle eden bir konsol uygulamasýdýr. Kullanýcý, araba özelliklerini girerek yeni arabalar üretebilir, her araba için veriler doðrulanýr ve üretilen arabalar bir listeye kaydedilir. Kullanýcý, çok sayýda araba oluþturabilir ve sonrasýnda bu arabalarýn listesini görebilir.

## Özellikler ve Ýþleyiþ

### Sýnýf Yapýsý
Uygulamada `Car` sýnýfý aþaðýdaki özelliklere sahiptir:

- **Üretim Tarihi** (`DateTime productTime`): Araba oluþturulurken otomatik olarak güncel tarih ve saat atanýr.
- **Model Ýsmi** (`string modelName`): Arabanýn modeli, kullanýcý tarafýndan girilir.
- **Kapý Sayýsý** (`int doorCount`): Kapý sayýsý 2 veya 4 olabilir.
- **Motor Gücü** (`double motorPower`): Arabanýn motor gücünü ifade eder.
- **Sunroof Var Mý** (`bool haveSunRoof`): Sunroof olup olmadýðýný belirtir.
- **Yakýt Tipi** (`CarFuelType fuelType`): Yakýt tipini belirten enum (Benzin ya da Dizel).
- **Fiyat** (`decimal price`): Bazý özelliklere göre hesaplanýr.

### Program Akýþý

1. **Kullanýcýdan Girdi Alýnmasý**:
   - Program baþlangýcýnda kullanýcýya bir araba üretmek isteyip istemediði sorulur. Kullanýcý `"e"` (evet) ya da `"h"` (hayýr) olarak cevap verir. Hatalý giriþlerde hata mesajý gösterilip soru tekrar yöneltilir.

2. **Araba Özelliklerinin Giriþi ve Doðrulama**:
   - **Model Ýsmi**: Model ismi boþ býrakýlamaz.
   - **Kapý Sayýsý**: 2 veya 4 olabilir, baþka bir deðer girildiðinde hata mesajý verilir.
   - **Sunroof**: `"e"` (evet) veya `"h"` (hayýr) olarak girilmelidir. Diðer giriþlerde hata mesajý gösterilir.
   - **Yakýt Tipi**: `1` Benzin, `2` Dizel için kullanýlýr. Diðer deðerler hata mesajýna sebep olur.
   - **Motor Gücü**: Sayýsal bir deðer olmalý; hatalý giriþlerde hata mesajlarý verilir.

3. **Fiyat Hesaplamasý**:
   - Bütün özellikler alýndýktan sonra `PriceCalculate` metodu, arabanýn fiyatýný hesaplar. Fiyat formülü motor gücü, sunroof varlýðý, kapý sayýsý ve yakýt tipini dikkate alýr.

4. **Birden Fazla Araba Giriþi**:
   - Her giriþten sonra program, kullanýcýya baþka bir araba eklemek isteyip istemediðini sorar. `"e"` (evet) cevabý ile program tekrar özellik giriþine döner. `"h"` (hayýr) seçilirse döngü sona erer.

5. **Araba Listesinin Gösterilmesi**:
   - Tüm arabalar listelendikten sonra üretim tarihleri, modelleri, motor güçleri, sunroof durumu, yakýt tipi ve fiyatlarý gösterilir.

### Kod Yapýsý
Program, belirli bölümleri yönetmek için metotlar içerir:
- **`ChangeForeGroundColorTextShow`**: Kullanýcýya gösterilecek mesajlarýn renklerini deðiþtirir.
- **`ShowListItems`**: Tüm arabalarýn listesini gösterir.

### Örnek Kullaným
Kullanýcý aþaðýdaki þekilde veri girerek araba oluþturur:

```plaintext
Modeli Giriniz: Toyota
Kapý Sayýsýný Giriniz 2-4: 4
Sunroof var mý E(vet)/H(ayýr): e
Benzin için 1 Dizel için 2 
(1/2) Yakýt Tipiniz: 1
Motor gücünü Giriniz: 2.0
