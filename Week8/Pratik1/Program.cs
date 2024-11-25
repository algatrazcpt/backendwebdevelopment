var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//web sitemizi oluþturuyoruz

app.UseHttpsRedirection();
//https ile gevenli yapýya geçiyorruz

app.MapGet("/", () => "Hello World!");
//burda yönlendirme yapýyoruz


app.MapGet("/About", () => "About Page!");


app.UseStaticFiles();
//burda static dosytalarý kullanýuoruz
app.Run();

//Model uygulamamazýn iþ mantýgýný temsil ederer
//Viev kullanýcýya kullanýcýdan istekler alýr veya istekleri gösterir
//Controller ise programdaki iþlemleri vieve gönderir
//wwwroot ile degiþtirmedigimiz dosyalarý tutarýz css,js,resimler tutulur genelde
//Razorview ile c# ile html sayfasý oluþturuabiliyoruz
//Action ise controller içindeki yanýtlara cevap verir
