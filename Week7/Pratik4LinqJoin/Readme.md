# Pratik4LinqJoin

Bir kütüphane yönetim sistemi oluşturun. Bu sistemde iki adet tablo bulunmaktadır: Yazarlar ve Kitaplar. Aşağıda her iki tablonun yapısı verilmiştir:

Yazarlar Tablosu (Authors)
	AuthorId (int) - Yazarın benzersiz kimliği
	Name (string) - Yazarın adı
Kitaplar Tablosu (Books)

	BookId (int) - Kitabın benzersiz kimliği
	Title (string) - Kitabın başlığı
	AuthorId (int) - Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkilidir)

Görev:
	Tabloları Tanımlayın:
		Author ve Book adında iki sınıf oluşturun ve yukarıdaki tablo yapılarını bu sınıflara uygun şekilde tanımlayın.

	Verileri Ekleyin:
		Her iki tabloya da örnek veriler ekleyin. En az 3 yazar ve 4 kitap ekleyin.
	LINQ Sorgusu Yazın:
		Kitapları ve yazarları birleştiren bir LINQ sorgusu oluşturun. Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir.
	Sonuçları Yazdırın:
		Oluşturduğunuz LINQ sorgusunun sonucunu ekrana yazdırın. Her kitabın başlığı ve yazarının adını içeren bilgileri göstermelisiniz.