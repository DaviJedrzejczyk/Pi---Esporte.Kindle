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
    internal class TipoFuncionarioDBMap : IEntityTypeConfiguration<TipoFuncionario>
    {
        public void Configure(EntityTypeBuilder<TipoFuncionario> builder)
        {
            builder.ToTable("TIPO_FUNCIONARIOS");
            builder.Property(f => f.NivelAcesso).HasMaxLength(20).IsRequired().IsUnicode(false);
        }
    }
}
