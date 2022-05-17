using Microsoft.EntityFrameworkCore;
using Stone.Estabelecimentos.DOMINIO.Entities;
using Stone.Estabelecimentos.DOMINIO.Enums;

namespace Stone.Estabelecimentos.INFRA.Repository.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() {}
        public SqlServerContext(DbContextOptions<SqlServerContext> opt) : base(opt) { }

        public DbSet<Estabelecimento> Estabelecimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estabelecimento>().HasData(new Estabelecimento
            {
                Id = 1,
                NomeEstabelecimento = "Padaria Stn",
                Classificacao = ClassificacaoEstabelecimento.Alimentação
            });

            modelBuilder.Entity<Estabelecimento>().HasData(new Estabelecimento
            {
                Id = 2,
                NomeEstabelecimento = "T-Shirt Stn",
                Classificacao = ClassificacaoEstabelecimento.Vestuário
            });

            modelBuilder.Entity<Estabelecimento>().HasData(new Estabelecimento
            {
                Id = 3,
                NomeEstabelecimento = "CineStn",
                Classificacao = ClassificacaoEstabelecimento.Lazer
            });

            modelBuilder.Entity<Estabelecimento>().HasData(new Estabelecimento
            {
                Id = 4,
                NomeEstabelecimento = "EletroStn",
                Classificacao = ClassificacaoEstabelecimento.Contas
            });

            modelBuilder.Entity<Estabelecimento>().HasData(new Estabelecimento
            {
                Id = 5,
                NomeEstabelecimento = "Rosquinha Stn",
                Classificacao = ClassificacaoEstabelecimento.Alimentação
            });

           
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(OberterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        public string OberterStringConexao()
        {
            string strcon = "Data Source=SQNOT14178;Initial Catalog=DbStone;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return strcon;
        }

    }
}
