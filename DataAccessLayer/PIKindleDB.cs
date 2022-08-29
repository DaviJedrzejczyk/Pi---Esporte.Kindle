﻿using Entities;
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
        public DbSet<TipoFuncionario> TipoFuncionarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\djedr\source\repos\Pi---Esporte.Kindle\PIKindleDB.mdf;Integrated Security=True;Connect Timeout=30");
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}