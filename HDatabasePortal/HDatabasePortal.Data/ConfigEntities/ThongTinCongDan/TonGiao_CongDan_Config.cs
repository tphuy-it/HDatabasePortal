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
    public class TonGiao_CongDan_Config : IEntityTypeConfiguration<TonGiao_CongDan>
    {
        public void Configure(EntityTypeBuilder<TonGiao_CongDan> builder)
        {
            builder.ToTable("TonGiao_CongDan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.CacToChucTonGiaoChinh_ID });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.CacToChucTonGiaoChinh_ID);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.HienTai);
            builder.Property(p => p.CoChucVu);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_TonGiao)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.CacToChucTonGiaoChinh)
                .WithMany(p => p.DS_TonGiao_CongDan)
                .HasForeignKey(p => p.CacToChucTonGiaoChinh_ID);
        }
    }
}
