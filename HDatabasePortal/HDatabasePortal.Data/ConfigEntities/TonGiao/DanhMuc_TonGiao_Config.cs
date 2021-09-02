using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.TonGiao;
namespace HDatabasePortal.Data.ConfigEntities.TonGiao
{
    public class DanhMuc_TonGiao_Config : IEntityTypeConfiguration<DanhMuc_TonGiao>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_TonGiao> builder)
        {
            builder.ToTable("DanhMuc_TonGiao")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(50);
        }
    }
}
