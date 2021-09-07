using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestauranteEtec.Models;

namespace RestauranteEtec.Data
{
    // A DbContext (herança) é uma classe própria do EntityFrameworkCore que permite o acesso ao banco de dados.
    // Cria uma instância que representa o acesso ao banco.
    // Eu consigo usá-la após instalar o Framework Pomelo no Nuget
    public class Contexto : IdentityDbContext<ApplicationUser> 
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Relato> Relatos { get; set; }
        public DbSet<Reserva> Reservas { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Identity
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            #endregion

            #region Cargo Seed
            modelBuilder.Entity<Cargo>().HasData(
                new Cargo()
                {
                    Id = 1,
                    Nome = "Proprietária"
                },
                new Cargo()
                {
                    Id = 2,
                    Nome = "Chefe de Cozinha"
                },
                new Cargo()
                {
                    Id = 3,
                    Nome = "Cozinheiro Chefe"
                },
                new Cargo()
                {
                    Id = 4,
                    Nome = "Nutricionista"
                }
            );
            #endregion

            #region Funcionario Seed
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario()
                {
                    Id = 1,
                    Nome = "Lívia Stewart",
                    Texto = "Chef proprietária, apaixonada por boa comida. Minha meta é proporcionar aos nossos clientes a melhor experiência de suas vidas.",
                    CargoId = 1,
                    ExibirHome = true,
                    OrdemExibicao = 1,
                    Foto = "images/funcionarios/chef-1.jpg"
                },
                new Funcionario()
                {
                    Id = 2,
                    Nome = "Alex Baumer",
                    Texto = "Formado em Nova York, é chef a mais de 10 anos com experiência em cozinha internacional.",
                    CargoId = 2,
                    ExibirHome = true,
                    OrdemExibicao = 2,
                    Foto = "images/funcionarios/chef-2.jpg"
                },
                new Funcionario()
                {
                    Id = 3,
                    Nome = "Augusto Smith Lee",
                    Texto = "Mestre em Ciências Gastronômicas, bacharelado em nutrição, especializou-se em ingredientes, cores e sabores brasileiros.",
                    CargoId = 3,
                    ExibirHome = true,
                    OrdemExibicao = 3,
                    Foto = "images/funcionarios/chef-3.jpg"
                },
                 new Funcionario()
                 {
                     Id = 4,
                     Nome = "Gabriella Loyola",
                     Texto = "Nutricionista formada pela USP e chef de cozinha pela Escola de Gastronomia. Atua no mercado de gastronomia saudável desde 2014.",
                     CargoId = 4,
                     ExibirHome = true,
                     OrdemExibicao = 4,
                     Foto = "images/funcionarios/chef-4.jpg"
                 }
            );
            #endregion

            #region Categoria Seed
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria()
                {
                    Id = 1,
                    Nome = "Entradas"
                },
                new Categoria()
                {
                    Id = 2,
                    Nome = "Prato Principal"
                },
                new Categoria()
                {
                    Id = 3,
                    Nome = "Sobremesas"
                },
                new Categoria()
                {
                    Id = 4,
                    Nome = "Bebidas"
                }
            );
            #endregion
        }
    }
}