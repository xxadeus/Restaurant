using Entities.Context;
using Entities.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Root
{
    public class CompositionRoot
    {
        public CompositionRoot() { }
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped<ProductContext>();
            services.AddScoped(typeof(IProductCategoryService), typeof(ProductCategory));
            services.AddScoped(typeof(IProductService), typeof(Product));
            services.AddScoped(typeof(ITableService), typeof(Table));
            services.AddDbContext<ProductContext>(options => options.UseSqlServer("server= DESKTOP-8QQD2EQ;database= RestaurantCodeFirst; Trusted_Connection = true", x => x.MigrationsAssembly("UI")));
        }
    }
}
