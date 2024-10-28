# Pratik6Kapanis

## Araba �retim Konsol Uygulamas�
Bu proje, bir araba �retim s�recini sim�le eden bir konsol uygulamas�d�r. Kullan�c�, araba �zelliklerini girerek yeni arabalar �retebilir, her araba i�in veriler do�rulan�r ve �retilen arabalar bir listeye kaydedilir. Kullan�c�, �ok say�da araba olu�turabilir ve sonras�nda bu arabalar�n listesini g�rebilir.

## �zellikler ve ��leyi�

### S�n�f Yap�s�
Uygulamada `Car` s�n�f� a�a��daki �zelliklere sahiptir:

- **�retim Tarihi** (`DateTime productTime`): Araba olu�turulurken otomatik olarak g�ncel tarih ve saat atan�r.
- **Model �smi** (`string modelName`): Araban�n modeli, kullan�c� taraf�ndan girilir.
- **Kap� Say�s�** (`int doorCount`): Kap� say�s� 2 veya 4 olabilir.
- **Motor G�c�** (`double motorPower`): Araban�n motor g�c�n� ifade eder.
- **Sunroof Var M�** (`bool haveSunRoof`): Sunroof olup olmad���n� belirtir.
- **Yak�t Tipi** (`CarFuelType fuelType`): Yak�t tipini belirten enum (Benzin ya da Dizel).
- **Fiyat** (`decimal price`): Baz� �zelliklere g�re hesaplan�r.

### Program Ak���

1. **Kullan�c�dan Girdi Al�nmas�**:
   - Program ba�lang�c�nda kullan�c�ya bir araba �retmek isteyip istemedi�i sorulur. Kullan�c� `"e"` (evet) ya da `"h"` (hay�r) olarak cevap verir. Hatal� giri�lerde hata mesaj� g�sterilip soru tekrar y�neltilir.

2. **Araba �zelliklerinin Giri�i ve Do�rulama**:
   - **Model �smi**: Model ismi bo� b�rak�lamaz.
   - **Kap� Say�s�**: 2 veya 4 olabilir, ba�ka bir de�er girildi�inde hata mesaj� verilir.
   - **Sunroof**: `"e"` (evet) veya `"h"` (hay�r) olarak girilmelidir. Di�er giri�lerde hata mesaj� g�sterilir.
   - **Yak�t Tipi**: `1` Benzin, `2` Dizel i�in kullan�l�r. Di�er de�erler hata mesaj�na sebep olur.
   - **Motor G�c�**: Say�sal bir de�er olmal�; hatal� giri�lerde hata mesajlar� verilir.

3. **Fiyat Hesaplamas�**:
   - B�t�n �zellikler al�nd�ktan sonra `PriceCalculate` metodu, araban�n fiyat�n� hesaplar. Fiyat form�l� motor g�c�, sunroof varl���, kap� say�s� ve yak�t tipini dikkate al�r.

4. **Birden Fazla Araba Giri�i**:
   - Her giri�ten sonra program, kullan�c�ya ba�ka bir araba eklemek isteyip istemedi�ini sorar. `"e"` (evet) cevab� ile program tekrar �zellik giri�ine d�ner. `"h"` (hay�r) se�ilirse d�ng� sona erer.

5. **Araba Listesinin G�sterilmesi**:
   - T�m arabalar listelendikten sonra �retim tarihleri, modelleri, motor g��leri, sunroof durumu, yak�t tipi ve fiyatlar� g�sterilir.

### Kod Yap�s�
Program, belirli b�l�mleri y�netmek i�in metotlar i�erir:
- **`ChangeForeGroundColorTextShow`**: Kullan�c�ya g�sterilecek mesajlar�n renklerini de�i�tirir.
- **`ShowListItems`**: T�m arabalar�n listesini g�sterir.

### �rnek Kullan�m
Kullan�c� a�a��daki �ekilde veri girerek araba olu�turur:

```plaintext
Modeli Giriniz: Toyota
Kap� Say�s�n� Giriniz 2-4: 4
Sunroof var m� E(vet)/H(ay�r): e
Benzin i�in 1 Dizel i�in 2 
(1/2) Yak�t Tipiniz: 1
Motor g�c�n� Giriniz: 2.0
