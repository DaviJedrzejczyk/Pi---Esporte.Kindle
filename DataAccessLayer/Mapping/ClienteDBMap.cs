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
    internal class ClienteDBMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTES");
            builder.Property(c => c.Telefone).HasMaxLength(20).IsRequired().IsUnicode(false);
            builder.Property(c => c.RG).HasMaxLength(11).IsRequired().IsUnicode(false);
            builder.Property(c => c.CPF).HasMaxLength(14).IsRequired().IsUnicode(false);
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Sobrenome).HasMaxLength(50).IsRequired().IsUnicode(false);
        }
    }
}
