# Pratik6 - Polymorphism

## Ýçerikler

Pratik - Polymorphism
Yukarýda bahsettiðimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacýmýz var.

Kare

Dikdortgen

DikUcgen

Classlarýmýzý ortak bir çatý altýnda toplayarak BaseGeometrikSekil classýndan türetebiliriz.

BaseGeometrikSekil için Propertyler -> Geniþlik ve Yükseklik

AlanHesapla() metodu tüm geometrik þekillerde bulanacaðýndan Base Class içerisinde tanýmlayabiliriz.

 

Burada dikkat etmemiz gereken durum: Kare ve Dikdortgen için Geniþlik x Yükseklik þeklinde hesaplanan alanýn Dik Üçgen için (Geniþlik x Yükseklik ) / 2 olarak hesaplanmasý.

Polymorphism prensibini kullanarak ilgili uygulamayý kodlayýnýz. Her classtan bir örnek nesne oluþturarak Alan ölçülerini konsol ekranýna yazdýrýr.
