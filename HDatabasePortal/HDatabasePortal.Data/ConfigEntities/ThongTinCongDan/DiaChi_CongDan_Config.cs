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
    public class DiaChi_CongDan_Config : IEntityTypeConfiguration<DiaChi_CongDan>
    {
        public void Configure(EntityTypeBuilder<DiaChi_CongDan> builder)
        {
            builder.ToTable("DiaChi_CongDan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.XaPhuong_MaHanhChinh, p.LoaiDiaChi_Ma });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.XaPhuong_MaHanhChinh)
                .HasMaxLength(6);
            builder.Property(p => p.LoaiDiaChi_Ma)
                .HasMaxLength(2);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.HienTai);
            builder.Property(p => p.SoNhaTenDuong)
                .HasMaxLength(50);
            builder.Property(p => p.DayDu)
                .HasMaxLength(200);
            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_DiaChi)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.XaPhuong)
                .WithMany(p => p.DS_DiaChi_CongDan)
                .HasForeignKey(p => p.XaPhuong_MaHanhChinh);
            builder.HasOne(p => p.LoaiDiaChi)
                .WithMany(p => p.DS_DiaChi_CongDan)
                .HasForeignKey(p => p.LoaiDiaChi_Ma);
        }
    }
}
