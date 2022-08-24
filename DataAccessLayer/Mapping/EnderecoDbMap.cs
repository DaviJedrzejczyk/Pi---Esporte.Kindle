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
    internal class EnderecoDbMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("ENDERECO");
            builder.Property(e => e.Numero).HasMaxLength(30).IsRequired().IsUnicode(false);
            builder.Property(e => e.Bairro).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(e => e.Rua).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(e => e.PontoReferencia).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.CEP).HasMaxLength(8).IsFixedLength(true).IsRequired().IsUnicode(false);
            builder.Property(e => e.Complemento).HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(e => e.Cidade).HasMaxLength(50).IsRequired().IsUnicode(false);
        }
    }
}
