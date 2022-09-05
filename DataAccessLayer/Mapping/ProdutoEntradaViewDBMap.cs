﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class ProdutoEntradaViewDBMap : IEntityTypeConfiguration<ProdutoEntradaView>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntradaView> builder)
        {
            builder.ToTable("PRODUTOS_ENTRADAS_VIEWS");
        }
    }
}