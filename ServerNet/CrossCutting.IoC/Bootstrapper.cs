using Microsoft.Extensions.DependencyInjection;
using System;
using Domain.Interfaces;
using Infra.EFData.Repositories;
using Infra.EFData;
using Microsoft.EntityFrameworkCore;
using Domain.CommandHandlers;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrossCutting.IoC
{
    public static class Bootstrapper
    {
        public static void Configure(IServiceCollection services)
        {
            var sqlConnectionString = "User ID=ceos;Password=ceosceos;Host=localhost;Port=5432;Database=teste;Pooling=true;Timeout=15";
            // Add framework services.
            // services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("MemTable"));
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(sqlConnectionString,
                                  x => x.MigrationsHistoryTable(
                                      HistoryRepository.DefaultTableName,
                                      ApplicationDbContext.DatabaseSchema)));

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped(typeof(CommandHandler));
        }
    }
}
