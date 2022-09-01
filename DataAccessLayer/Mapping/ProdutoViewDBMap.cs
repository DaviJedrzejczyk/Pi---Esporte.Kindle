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
    internal class ProdutoViewDBMap : IEntityTypeConfiguration<ProdutoView>
    {
        public void Configure(EntityTypeBuilder<ProdutoView> builder)
        {
            builder.ToTable("PRODUTO_VIEW");
            builder.Property(p => p.Nome).HasMaxLength(20).IsRequired().IsUnicode(false);
            builder.Property(p => p.Descricao).HasMaxLength(40).IsRequired().IsUnicode(false);
        }
    }
}
