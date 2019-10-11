using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using PromoCodeAPI.Infra.Context;
using PromoCodeAPI.Domain.Interfaces;
using PromoCodeAPI.Infra.Data.Repositories;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Services.Communication;
using FluentValidation;
using PromoCodeAPI.ViewModelsValidators;
using PromoCodeAPI.ViewModels;
using AutoMapper;

namespace PromoCodeAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c=> {
                    c.SwaggerDoc("v1", new Info { Title = "Code Promo API", Version = "V1" });
                    c.DescribeAllEnumsAsStrings();
            });

            var connection = Configuration["SqliteConnection:SqliteConnectionString"];
            services.AddDbContext<ContextSqlLite>(options => options.UseSqlite(connection));

            services.AddSingleton<IValidator<ShoppingCartViewModel>, ShoppingCartViewModelValidator>();

            services.AddScoped<IPromoCodeRepository<PromoCode>, PromoCodeRepository<PromoCode>>();
            services.AddScoped<IShoppingCartRepository,ShoppingCartRepository>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();

            services.AddAutoMapper(typeof(Startup));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();  
            app.UseSwaggerUI(c=> {  
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Promo API V1");
                c.RoutePrefix = string.Empty;
                c.DefaultModelsExpandDepth(-1);
            }); 

            app.UseMvc();
        }
    }
}
