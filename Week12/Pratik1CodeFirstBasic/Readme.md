# Pratik1 Code First Basic
Bu proje, Entity Framework Core kullanarak Code First yakla��m�yla bir veri taban� olu�turmay� ama�lar. A�a��da, proje hakk�nda bilgiler, veri taban� yap�s� ve kullan�m ad�mlar� a��klanm��t�r.

# Proje Hedefi
Bu proje, iki ba��ms�z tablo i�eren bir veri taban� tasarlamaktad�r:

Movie Tablosu:

	Id: Birincil anahtar ve otomatik artan.
	Title: Filmin ba�l��� (string).
	Genre: Filmin t�r� (�rne�in: "Action", "Comedy", "Drama") (string).
	ReleaseYear: Filmin ��k�� y�l� (int).

Game Tablosu:

	Id: Birincil anahtar ve otomatik artan.
	Name: Oyunun ad� (string).
	Platform: Oyunun oynand��� platform (�rne�in: "PC", "PlayStation", "Xbox") (string).
	Rating: Oyunun puan� (0 ile 10 aras�nda) (decimal).