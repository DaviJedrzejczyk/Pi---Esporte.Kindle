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
    internal class SaidaViewDBMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<SaidaView>
    {
        public void Configure(EntityTypeBuilder<SaidaView> builder)
        {
            builder.ToTable("SAIDA_VEIW");
        }
    }
}
