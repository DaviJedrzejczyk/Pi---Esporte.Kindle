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
    internal class ProdutoSaidaViewDbMap : IEntityTypeConfiguration<ProdutosSaidaView>
    {
        public void Configure(EntityTypeBuilder<ProdutosSaidaView> builder)
        {
            builder.ToTable("PRODUTO_SAIDA_VIEWS");
        }
    }
}
