using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Delivery.Data.EFContext;
using Food_Delivery.Data.Interfaces;
using Food_Delivery.Data.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Food_Delivery
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<EFDbContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<DbUser, DbRole>(options => options.Stores
            .MaxLengthForKeys = 128)
            .AddEntityFrameworkStores<EFDbContext>()
            .AddDefaultTokenProviders();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {
                   options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                   options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
               });

            services.AddTransient<IProduct, ProductRepository>();
            services.AddTransient<ICategory, CategoryRepository>();

            services.AddMemoryCache();
            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseSession();


            //Seeder.SeedRoles(app.ApplicationServices, env, this.Configuration);
            //Seeder.SeedUsers(app.ApplicationServices, env, this.Configuration);
            //Seeder.SeedCategories(app.ApplicationServices, env, this.Configuration);
            //Seeder.SeedProducts(app.ApplicationServices, env, this.Configuration);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                 name: "filter",
                 template: "Products/{action}/{category?}",
                 defaults: new { controller = "Products", action = "ListProducts" });
            });
        }
    }
}
