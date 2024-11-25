namespace Pratik2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.Use(async (context, next) =>
            {
                await next();

                if (context.Response.StatusCode <= 200|| context.Response.StatusCode>299)
                {
                    context.Request.Path = "/404"; // 404 sayfasýna yönlendir
                    await next();
                }
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "customer",
                pattern: "{controller=CustomerOrders}/{action=Index}");
            app.MapControllerRoute(
                name: "error",
                pattern: "/404",
                defaults: new { controller = "Home", action = "NotFound" });

            app.Run();
        }
    }
}
