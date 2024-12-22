# Pratik3 Survivor Web API
Bu API, Survivor yarýþmasýndaki yarýþmacýlar ve kategorilerle ilgili verileri saðlar. Aþaðýda Read iþlemlerini gerçekleþtiren API endpoint'leri açýklanmýþtýr:

Competitor Endpoints

	GET /api/competitors: Tüm yarýþmacýlarý listeler.
	GET /api/competitors/{id}: Belirli bir yarýþmacýyý getirir.
	GET /api/competitors/categories/{categoryId}: Belirli bir kategoriye ait yarýþmacýlarý listeler.
	POST /api/competitors: Yeni bir yarýþmacý oluþturur.
	PUT /api/competitors/{id}: Belirli bir yarýþmacýyý günceller.
	DELETE /api/competitors/{id}: Belirli bir yarýþmacýyý siler.
Category Endpoints

	GET /api/categories: Tüm kategorileri listeler.
	GET /api/categories/{id}: Belirli bir kategoriyi getirir.
	POST /api/categories: Yeni bir kategori oluþturur.
	PUT /api/categories/{id}: Belirli bir kategoriyi günceller.
	DELETE /api/categories/{id}: Belirli bir kategoriyi siler.