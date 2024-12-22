# Pratik3 Survivor Web API
## Kurulum 
Dotnet version 8.0 gereklidir


Bu API, Survivor yarışmasındaki yarışmacılar ve kategorilerle ilgili verileri sağlar. Aşağıda Read işlemlerini gerçekleştiren API endpoint'leri açıklanmıştır:

Competitor Endpoints

	GET /api/competitors: Tüm yarışmacıları listeler.
	GET /api/competitors/{id}: Belirli bir yarışmacıyı getirir.
	GET /api/competitors/categories/{categoryId}: Belirli bir kategoriye ait yarışmacıları listeler.
	POST /api/competitors: Yeni bir yarışmacı oluşturur.
	PUT /api/competitors/{id}: Belirli bir yarışmacıyı günceller.
	DELETE /api/competitors/{id}: Belirli bir yarışmacıyı siler.
Category Endpoints

	GET /api/categories: Tüm kategorileri listeler.
	GET /api/categories/{id}: Belirli bir kategoriyi getirir.
	POST /api/categories: Yeni bir kategori oluşturur.
	PUT /api/categories/{id}: Belirli bir kategoriyi günceller.
	DELETE /api/categories/{id}: Belirli bir kategoriyi siler.
