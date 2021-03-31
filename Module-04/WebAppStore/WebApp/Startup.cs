using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp
{
    public class Startup
    {
        IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            // authorize
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt =>
                {
                    opt.LoginPath = "/auth/signin";
                    opt.AccessDeniedPath = "/auth/denied";
                    opt.ExpireTimeSpan = TimeSpan.FromDays(30);
                    opt.Cookie.Name = "cse.net.vn";
                });
            services.AddScoped<SiteProvider>(p => new SiteProvider(configuration));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // để thêm file css, js
            app.UseStaticFiles();

            app.UseRouting();

            // để tạo chức năng đăng nhập
            app.UseAuthentication(); // trước
            app.UseAuthorization(); // sau

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "dashboard", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
