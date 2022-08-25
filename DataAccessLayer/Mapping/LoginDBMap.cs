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
    internal class LoginDBMap : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("LOGINS");
            builder.Property(l => l.Email).HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(l => l.Senha).HasMaxLength(20).IsRequired().IsUnicode(false);
        }
    }
}
