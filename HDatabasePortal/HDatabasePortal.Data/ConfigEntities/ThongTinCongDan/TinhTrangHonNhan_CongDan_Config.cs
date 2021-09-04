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
    public class TinhTrangHonNhan_CongDan_Config : IEntityTypeConfiguration<TinhTrangHonNhan_CongDan>
    {
        public void Configure(EntityTypeBuilder<TinhTrangHonNhan_CongDan> builder)
        {
            builder.ToTable("TinhTrangHonNhan_CongDan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.TinhTrangHonNhan_Ma });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.TinhTrangHonNhan_Ma)
                .HasMaxLength(2);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.HienTai);
            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_TinhTrangHonNhan)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.TinhTrangHonNhan)
                .WithMany(p => p.DS_TinhTrangHonNhan_CongDan)
                .HasForeignKey(p => p.TinhTrangHonNhan_Ma);
        }
    }
}
