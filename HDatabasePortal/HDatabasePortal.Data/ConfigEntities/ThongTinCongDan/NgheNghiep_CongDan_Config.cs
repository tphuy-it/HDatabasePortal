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
    public class NgheNghiep_CongDan_Config : IEntityTypeConfiguration<NgheNghiep_CongDan>
    {
        public void Configure(EntityTypeBuilder<NgheNghiep_CongDan> builder)
        {
            builder.ToTable("NgheNghiep_CongDan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.NgheNghiepCap5_Ma });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.NgheNghiepCap5_Ma)
                .HasMaxLength(6);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.HienTai);
            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_NgheNghiep)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.NgheNghiepCap5)
                .WithMany(p => p.DS_NgheNghiep_CongDan)
                .HasForeignKey(p => p.NgheNghiepCap5_Ma);
        }
    }
}
