using Microsoft.EntityFrameworkCore;
using Stone.Lancamentos.DOMINIO.Entities;
using Stone.Lancamentos.DOMINIO.Enums;
using System;

namespace Stone.Lancamentos.INFRA.Repository.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() { }
        public SqlServerContext(DbContextOptions<SqlServerContext> opt) : base (opt) { }

        public DbSet<Lancamento> Lancamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lancamento>().HasData(new Lancamento
            {
                Id = 1,
                Estabelecimento = "Padaria Stn",
                DataReferencia = new DateTime(2022, 03, 10),
                FormaPagamento = FormaPagamento.Credito,
                Valor = 70
            });

            modelBuilder.Entity<Lancamento>().HasData(new Lancamento
            {
                Id = 2,
                Estabelecimento = "Roupas Stn",
                DataReferencia = new DateTime(2022, 04, 10),
                FormaPagamento = FormaPagamento.Debito,
                Valor = 1000
            });

            modelBuilder.Entity<Lancamento>().HasData(new Lancamento
            {
                Id = 3,
                Estabelecimento = "Roupas Stn",
                DataReferencia = new DateTime(2022, 04, 10),
                FormaPagamento = FormaPagamento.Debito,
                Valor = 1000
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
            string strcon = "Data Source=SQNOT14178;Initial Catalog=DbStoneLancamentos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return strcon;
        }
    }
}
