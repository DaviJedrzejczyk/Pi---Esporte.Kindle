using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class EstadoDBMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("ESTADOS");
            builder.Property(e => e.NomeCompleto).HasMaxLength(20).IsRequired().IsUnicode(false);
            builder.Property(e => e.Unidade_Federal).HasMaxLength(2).IsRequired().IsUnicode(false);
        }
    }
}
