using Application.Abstractions;
using Application.Consultas;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IDespesaService, DespesaService>();
            services.AddScoped<IFinancaService, FinancaService>();

            services.AddScoped<ISaldoFinanceiroCPIService, SaldoFinanceiroCPIService>();

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<IFinancaRepository, FinancaRepository>();

            return services;
        }
    }
}
