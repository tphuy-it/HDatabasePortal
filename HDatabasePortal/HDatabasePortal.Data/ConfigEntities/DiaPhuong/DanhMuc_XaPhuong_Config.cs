using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.DiaPhuong;
namespace HDatabasePortal.Data.ConfigEntities.DiaPhuong
{
    public class DanhMuc_XaPhuong_Config : IEntityTypeConfiguration<DanhMuc_XaPhuong>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_XaPhuong> builder)
        {
            builder.ToTable("DanhMuc_XaPhuong")
                .HasKey(p => p.MaHanhChinh);
            builder.Property(p => p.MaHanhChinh)
                .HasMaxLength(6);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            builder.Property(p => p.MaBuuChinh)
                .HasMaxLength(20);
            builder.Property(p => p.TenKhac)
                .HasMaxLength(100);
            builder.Property(p => p.QuanHuyen_MaHanhChinh)
                .HasMaxLength(4);
            builder.Property(p => p.CapXaPhuong_Ma)
                .HasMaxLength(2);

            builder.HasOne(p => p.QuanHuyen)
                .WithMany(p => p.DS_XaPhuong)
                .HasForeignKey(p => p.QuanHuyen_MaHanhChinh);
            builder.HasOne(p => p.CapXaPhuong)
                .WithMany(p => p.DS_XaPhuong)
                .HasForeignKey(p => p.CapXaPhuong_Ma);
        }
    }
}
