using Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace DataAccessLayer
{
    public class PIKindleDB : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Saida> Saidas { get; set; }
        public DbSet<SaidaView> SaidaViews { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<EntradaView> EntradaViews { get; set; }
        public DbSet<ProdutoEntrada> ProdutosEntradas { get; set; }
        public DbSet<ProdutoEntradaView> ProdutoEntradasViews { get; set; }
        public DbSet<ProdutoSaida> ProdutoSaidas { get; set; }
        public DbSet<ProdutoSaidaView> ProdutosSaidaViews { get; set; }
        public DbSet<ProdutoView> ProdutoViews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Documents\KindleDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}