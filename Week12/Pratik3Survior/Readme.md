# Pratik3 Survivor Web API
Bu API, Survivor yar��mas�ndaki yar��mac�lar ve kategorilerle ilgili verileri sa�lar. A�a��da Read i�lemlerini ger�ekle�tiren API endpoint'leri a��klanm��t�r:

Competitor Endpoints

	GET /api/competitors: T�m yar��mac�lar� listeler.
	GET /api/competitors/{id}: Belirli bir yar��mac�y� getirir.
	GET /api/competitors/categories/{categoryId}: Belirli bir kategoriye ait yar��mac�lar� listeler.
	POST /api/competitors: Yeni bir yar��mac� olu�turur.
	PUT /api/competitors/{id}: Belirli bir yar��mac�y� g�nceller.
	DELETE /api/competitors/{id}: Belirli bir yar��mac�y� siler.
Category Endpoints

	GET /api/categories: T�m kategorileri listeler.
	GET /api/categories/{id}: Belirli bir kategoriyi getirir.
	POST /api/categories: Yeni bir kategori olu�turur.
	PUT /api/categories/{id}: Belirli bir kategoriyi g�nceller.
	DELETE /api/categories/{id}: Belirli bir kategoriyi siler.