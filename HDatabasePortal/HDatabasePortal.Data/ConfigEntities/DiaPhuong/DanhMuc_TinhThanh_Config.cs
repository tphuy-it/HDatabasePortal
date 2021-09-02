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
    public class DanhMuc_TinhThanh_Config : IEntityTypeConfiguration<DanhMuc_TinhThanh>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_TinhThanh> builder)
        {
            builder.ToTable("DanhMuc_TinhThanh")
                .HasKey(p => p.MaHanhChinh);
            builder.Property(p => p.MaHanhChinh)
                .HasMaxLength(3);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            builder.Property(p => p.MaBuuChinh)
                .HasMaxLength(20);
            builder.Property(p => p.MaVungDienThoai)
                .HasMaxLength(4);
            builder.Property(p => p.TenKhac)
                .HasMaxLength(100);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.DenNgay);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.Property(p => p.KhuVucTinhThanhCap2_Ma)
                .HasMaxLength(2);
            builder.Property(p => p.CapTinhThanh_Ma)
                .HasMaxLength(2);

            builder.HasOne(p => p.KhuVucTinhThanhCap2)
                .WithMany(p => p.DS_TinhThanh)
                .HasForeignKey(p => p.KhuVucTinhThanhCap2_Ma);
            builder.HasOne(p => p.CapTinhThanh)
                .WithMany(p => p.DS_TinhThanh)
                .HasForeignKey(p => p.CapTinhThanh_Ma);
        }
    }
}
