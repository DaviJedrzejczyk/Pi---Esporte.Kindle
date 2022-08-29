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
    internal class ProdutoDBMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTOS");
            builder.Property(p => p.QtdEstoque).HasColumnName("QTD_ESTOQUE");
            builder.Property(p => p.Valor_Unitario).HasColumnName("VALOR_UNITARIO");
            builder.Property(p => p.Nome).HasMaxLength(30).HasColumnName("NOME").IsRequired().IsUnicode(false);
            builder.Property(p => p.Descricao).HasMaxLength(100).HasColumnName("DESCRICAO").IsRequired().IsUnicode(false);
            builder.Property(p => p.FornecedorId).HasColumnName("FORNECEDORES_ID");

        }
    }
}
