using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.ThongTinCongDan;
namespace HDatabasePortal.Data.ConfigEntities.ThongTinCongDan
{
    public class LoaiTrangThai_CongDan_Config : IEntityTypeConfiguration<LoaiTrangThai_CongDan>
    {
        public void Configure(EntityTypeBuilder<LoaiTrangThai_CongDan> builder)
        {
            builder.ToTable("LoaiTrangThai_CongDan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.LoaiTrangThai_Ma });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.LoaiTrangThai_Ma)
                .HasMaxLength(1);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.HienTai);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_LoaiTrangThai)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.LoaiTrangThai)
                .WithMany(p => p.DS_LoaiTrangThaiCongDan)
                .HasForeignKey(p => p.LoaiTrangThai_Ma);
        }
    }
}
