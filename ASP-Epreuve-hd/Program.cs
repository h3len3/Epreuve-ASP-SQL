using Shared_Epreuve_hd.Repositories;
using BLL = BLL_Epreuve_hd;
using DAL = DAL_Epreuve_hd;

namespace ASP_Epreuve_hd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Localization
            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                string[] supportedCultures = new string[]
                {
                    "en-US",    //Si en-US, alors le pattern des input de prix sera :  pattern="^\d*\.{0,1}\d*$"
                    "fr-BE"     //Si fr-BE, alors le pattern des input de prix sera :  pattern="^\d*,{0,1}\d*$"
                };
                string defaultCulture = supportedCultures[1];   //Choisir la culture (c'est la définision du format selon la région)
                options.SetDefaultCulture(defaultCulture);      //Définir la culture par défaut
                //options.AddSupportedCultures(supportedCultures);      //Si multilingue, définir les cultures supportées par le site
                //options.AddSupportedUICultures(supportedCultures);
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IProductRepository<BLL.Entities.Product>, BLL.Services.ProductService>();
            builder.Services.AddScoped<IProductRepository<DAL.Entities.Product>, DAL.Services.ProductService>();

            builder.Services.AddScoped<DAL_Epreuve_hd.Services.CategoryService>();
            builder.Services.AddScoped<BLL_Epreuve_hd.Services.CategoryService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            //Localization
            app.UseRequestLocalization();

            app.UseAuthorization();

            // Au cas où utilisation des attributs pour routing 
            app.MapControllers();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

