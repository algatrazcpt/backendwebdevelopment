var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//web sitemizi olu�turuyoruz

app.UseHttpsRedirection();
//https ile gevenli yap�ya ge�iyorruz

app.MapGet("/", () => "Hello World!");
//burda y�nlendirme yap�yoruz


app.MapGet("/About", () => "About Page!");


app.UseStaticFiles();
//burda static dosytalar� kullan�uoruz
app.Run();

//Model uygulamamaz�n i� mant�g�n� temsil ederer
//Viev kullan�c�ya kullan�c�dan istekler al�r veya istekleri g�sterir
//Controller ise programdaki i�lemleri vieve g�nderir
//wwwroot ile degi�tirmedigimiz dosyalar� tutar�z css,js,resimler tutulur genelde
//Razorview ile c# ile html sayfas� olu�turuabiliyoruz
//Action ise controller i�indeki yan�tlara cevap verir
