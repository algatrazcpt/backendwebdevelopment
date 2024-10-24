# Hafta4- Kapanis

## Ýçerikler

Bir teknoloji maðazasýnda Telefon ve Bilgisayar kayýtlarý alýyoruz.

Telefon -> Üretim Tarihi, Seri Numarasý, Ad, Açýklama, Ýþletim Sistemi, Tr Lisanslý olup olmama durumu özelliklerine sahip.

Bilgisayar -> Üretim Tarihi, Seri Numarasý, Ad, Açýklama, Ýþletim Sistemi, Usb Giriþ Sayýsý, Bluetooth olup olmama durumu özelliklerini sahip

BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarýna miras veriniz. (Inheritance)

Bilgisayar için Usb giriþ sayýsý 2 veya 4 atanabilir, aksi durumda bir uyarý mesajý verilerek -1 deðeri atansýn. (Encapsulation)

Üretim Tarihi deðeri bir nesne oluþturulduðu anda otomatik olarak atansýn. Telefon için de Bilgisayar için de geçerli.

Base Class içerisinde (BaseMakine) Üretim Tarihi, Seri Numarasý, Ad, Açýklama, Ýþletim Sistemi gibi ortak olan bilgileri yazdýran bir BilgileriYazdir() metodu tanýmlansýn. Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek Base iþlevinin üzerine kendilerine ait olan özelliklerinde yazdýrýlma iþlevi eklensin.   (Polymorphism)

UrunAdiGetir() diye abstract bir metot tanýmlayarak Telefon ve Bilgisayar için ayrý ayrý ezerek

"Telefonunuzun adý ---> ......"

"Bilgisayarýnýzýn adý ---> ......"

þeklinde konsol mesajlarý yazdýrýlabilsin.  (Abstraction)

Program akýþý:

1- Konsol ekranýndan kullanýcýya telefon üretmek için 1 bilgisayar üretmek için 2'ye basmasý gerektiðini söyleyiniz.

2- Kullanýcýnýn seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranýndan yani kullanýcýdan alýnýz.

3- Bütün bilgiler girildiðinde ürünün baþarýyla üretildiðini bir mesaj ile bildirip baþka bir ürün üretmek isteyip istemediðini sorunuz.

4- Kullanýcý evet cevabýný verirse 1. aþamaya geri dönünüz, hayýr cevabýný verirse iyi günler dileyerek uygulamayý sonlandýrýnýz.
