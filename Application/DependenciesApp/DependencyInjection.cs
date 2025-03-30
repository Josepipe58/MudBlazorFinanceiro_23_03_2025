using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain.Interfaces;
using Domain.Interfaces.ConsultasInterface;
using Domain.Interfaces.RelatorioInterface;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Infrastructure.Repositories.ConsultasRepository;
using Infrastructure.Repositories.RelatorioRepository;
using Application.Abstractions;
using Application.Abstractions.ConsultasAbstractions;
using Application.Abstractions.RelatoriosAbstractions;
using Application.Services;
using Application.Services.ConsultasService;
using Application.Services.RelatoriosService;

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
            services.AddScoped<IRelatorioDespesaService, RelatorioDespesaService>();

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<IFinancaRepository, FinancaRepository>();
            services.AddScoped<ISaldoFinanceiroCPIRepository, SaldoFinanceiroCPIRepository>();
            services.AddScoped<IRelatorioDespesaRepository, RelatorioDespesaRepository>();

            return services;
        }
    }
}
