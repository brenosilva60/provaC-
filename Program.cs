using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Text.Json;

namespace alunakamilla
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal ValorHora { get; set; }
    }

    public class FolhaPagamento
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public decimal HorasTrabalhadas { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal INSS { get; set; }
        public decimal IR { get; set; }
        public decimal FGTS { get; set; }
        public decimal SalarioLiquido { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FolhaPagamento> FolhasPagamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("alunakamilla_alunobreno.db");
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapPost("/api/funcionario/cadastrar", async context =>
                {
                });

                endpoints.MapGet("/api/funcionario/listar", async context =>
                {
                });

                endpoints.MapPost("/api/folha/cadastrar", async context =>
                {
                });

                endpoints.MapGet("/api/folha/listar", async context =>
                {
                });

                endpoints.MapGet("/api/folha/buscar/{cpf}/{mes}/{ano}", async context =>
                {
                });
            });
        }
    }
}
