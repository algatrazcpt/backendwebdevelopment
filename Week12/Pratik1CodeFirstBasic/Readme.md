# Pratik1 Code First Basic
Bu proje, Entity Framework Core kullanarak Code First yaklaþýmýyla bir veri tabaný oluþturmayý amaçlar. Aþaðýda, proje hakkýnda bilgiler, veri tabaný yapýsý ve kullaným adýmlarý açýklanmýþtýr.

# Proje Hedefi
Bu proje, iki baðýmsýz tablo içeren bir veri tabaný tasarlamaktadýr:

Movie Tablosu:

	Id: Birincil anahtar ve otomatik artan.
	Title: Filmin baþlýðý (string).
	Genre: Filmin türü (örneðin: "Action", "Comedy", "Drama") (string).
	ReleaseYear: Filmin çýkýþ yýlý (int).

Game Tablosu:

	Id: Birincil anahtar ve otomatik artan.
	Name: Oyunun adý (string).
	Platform: Oyunun oynandýðý platform (örneðin: "PC", "PlayStation", "Xbox") (string).
	Rating: Oyunun puaný (0 ile 10 arasýnda) (decimal).