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
    public class DanhMuc_QuanHuyen_Config : IEntityTypeConfiguration<DanhMuc_QuanHuyen>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_QuanHuyen> builder)
        {
            builder.ToTable("DanhMuc_QuanHuyen")
                .HasKey(p => p.MaHanhChinh);
            builder.Property(p => p.MaHanhChinh)
                .HasMaxLength(4);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            builder.Property(p => p.MaBuuChinh)
                .HasMaxLength(20);
            builder.Property(p => p.TenKhac)
                .HasMaxLength(100);
            builder.Property(p => p.CapQuanHuyen_Ma)
                .HasMaxLength(2);
            builder.Property(p => p.TinhThanh_MaHanhChinh)
                .HasMaxLength(3);

            builder.HasOne(p => p.CapQuanHuyen)
                .WithMany(p => p.DS_QuanHuyen)
                .HasForeignKey(p => p.CapQuanHuyen_Ma);
            builder.HasOne(p => p.TinhThanh)
                .WithMany(p => p.DS_QuanHuyen)
                .HasForeignKey(p => p.TinhThanh_MaHanhChinh);
        }
    }
}
