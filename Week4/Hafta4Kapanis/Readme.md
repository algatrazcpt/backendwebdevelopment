# Hafta4- Kapanis

## ��erikler

Bir teknoloji ma�azas�nda Telefon ve Bilgisayar kay�tlar� al�yoruz.

Telefon -> �retim Tarihi, Seri Numaras�, Ad, A��klama, ��letim Sistemi, Tr Lisansl� olup olmama durumu �zelliklerine sahip.

Bilgisayar -> �retim Tarihi, Seri Numaras�, Ad, A��klama, ��letim Sistemi, Usb Giri� Say�s�, Bluetooth olup olmama durumu �zelliklerini sahip

BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlar�na miras veriniz. (Inheritance)

Bilgisayar i�in Usb giri� say�s� 2 veya 4 atanabilir, aksi durumda bir uyar� mesaj� verilerek -1 de�eri atans�n. (Encapsulation)

�retim Tarihi de�eri bir nesne olu�turuldu�u anda otomatik olarak atans�n. Telefon i�in de Bilgisayar i�in de ge�erli.

Base Class i�erisinde (BaseMakine) �retim Tarihi, Seri Numaras�, Ad, A��klama, ��letim Sistemi gibi ortak olan bilgileri yazd�ran bir BilgileriYazdir() metodu tan�mlans�n. Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek Base i�levinin �zerine kendilerine ait olan �zelliklerinde yazd�r�lma i�levi eklensin.   (Polymorphism)

UrunAdiGetir() diye abstract bir metot tan�mlayarak Telefon ve Bilgisayar i�in ayr� ayr� ezerek

"Telefonunuzun ad� ---> ......"

"Bilgisayar�n�z�n ad� ---> ......"

�eklinde konsol mesajlar� yazd�r�labilsin.  (Abstraction)

Program ak���:

1- Konsol ekran�ndan kullan�c�ya telefon �retmek i�in 1 bilgisayar �retmek i�in 2'ye basmas� gerekti�ini s�yleyiniz.

2- Kullan�c�n�n se�imine g�re ilgili classtan nesne �reterek �zelliklerini konsol ekran�ndan yani kullan�c�dan al�n�z.

3- B�t�n bilgiler girildi�inde �r�n�n ba�ar�yla �retildi�ini bir mesaj ile bildirip ba�ka bir �r�n �retmek isteyip istemedi�ini sorunuz.

4- Kullan�c� evet cevab�n� verirse 1. a�amaya geri d�n�n�z, hay�r cevab�n� verirse iyi g�nler dileyerek uygulamay� sonland�r�n�z.
