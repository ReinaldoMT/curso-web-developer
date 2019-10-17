using Microsoft.Extensions.DependencyInjection;
using System;
using Domain.Interfaces;
using Infra.EFData.Repositories;
using Infra.EFData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrossCutting.IoC
{
    public static class Bootstrapper
    {
        public static void Configure(IServiceCollection services)
        {
            var sqlConnectionString = "User ID=teste;Password=ceosceos;Host=localhost;Port=5432;Database=ceos;Pooling=true;Timeout=15";
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(sqlConnectionString,
                                  x => x.MigrationsHistoryTable(
                                      HistoryRepository.DefaultTableName)));

            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
