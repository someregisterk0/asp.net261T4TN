﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
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

            services.AddScoped<SiteProvider>(p => new SiteProvider(configuration));

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            services.AddAuthentication("Cookies").AddCookie(opt =>
            {
                opt.LoginPath = "/auth/signin";
                opt.ExpireTimeSpan = TimeSpan.FromDays(30);
                opt.AccessDeniedPath = "/auth/denied";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();  // để dùng thêm js, jquery

            // để thêm phần xác thực
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(name: "dashboard", pattern:"{area:exists}/{controller=home}/{action=index}/{id?}");
                //});
            });
        }
    }
}
