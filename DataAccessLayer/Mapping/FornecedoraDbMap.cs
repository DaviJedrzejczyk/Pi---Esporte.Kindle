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
    internal class FornecedoraDbMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.Property(f => f.Telefone).HasMaxLength(14).IsRequired().IsUnicode(false);
            builder.Property(f => f.Email).HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(f => f.Nome_Contato).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(f => f.Cnpj).HasMaxLength(14).IsRequired().IsUnicode(false);
        }
    }
}
