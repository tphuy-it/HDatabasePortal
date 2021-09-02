using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.DanToc;
namespace HDatabasePortal.Data.ConfigEntities.DanToc
{
    public class DanhMuc_DanToc_Config : IEntityTypeConfiguration<DanhMuc_DanToc>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_DanToc> builder)
        {
            builder.ToTable("DanhMuc_DanToc")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(50);
            builder.Property(p => p.TenKhac)
                .HasMaxLength(300);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
        }
    }
}
