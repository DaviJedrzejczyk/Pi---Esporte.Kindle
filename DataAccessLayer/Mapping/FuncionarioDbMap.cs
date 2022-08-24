using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class FuncionarioDbMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("FUNCIONARIOS");
            builder.Property(f => f.Senha).HasMaxLength(20).IsRequired().IsUnicode(false);
            builder.Property(f => f.CPF).HasMaxLength(14).IsRequired().IsUnicode(false);
            builder.Property(f => f.Email).HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(f => f.RG).HasMaxLength(11).IsRequired().IsUnicode(false);
            builder.Property(f => f.Telefone).HasMaxLength(11).IsRequired().IsUnicode(false);
            builder.Property(c => c.Nome).HasMaxLenght(50).IsRequired(); IsUnicode(false);
            builder.Property(c => c.Sobrenome).HasMaxLenght(50).IsRequired(); IsUnicode(false);
        }
    }
}
