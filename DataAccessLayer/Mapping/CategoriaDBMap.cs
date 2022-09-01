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
    internal class CategoriaDBMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIAS");
            builder.Property(c => c.Descricao).HasColumnName("DESCRICAO").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(20).IsRequired().IsUnicode(false);   
        }
    }
}
