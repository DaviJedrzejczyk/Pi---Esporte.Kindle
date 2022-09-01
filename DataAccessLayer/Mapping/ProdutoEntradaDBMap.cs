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
    internal class ProdutoEntradaDBMap : IEntityTypeConfiguration<ProdutosEntrada>
    {
        public void Configure(EntityTypeBuilder<ProdutosEntrada> builder)
        {
            builder.ToTable("PRODUTOS_ENTRADAS");
        }
    }
}
