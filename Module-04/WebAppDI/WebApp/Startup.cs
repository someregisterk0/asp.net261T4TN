using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            //DI 
            //Chỉ chạy cái sau cùng nếu giống nhau
            //services.AddScoped<IAbc, Abc>();  // với constructer không có tham số
            services.AddScoped<IAbc>(p => new Abc("Danhnh"));
            //services.AddSingleton<IAbc>(p => new Abc("Danhnh"));
            //services.AddScoped<IDbConnection>(p => new SqlConnection(configuration.GetConnectionString("BikeStore")));
            //services.AddScoped<SiteProvider>(p => new SiteProvider(new SqlConnection(configuration.GetConnectionString("BikeStore"))));
            services.AddScoped<SiteProvider>(p => new SiteProvider(configuration));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
