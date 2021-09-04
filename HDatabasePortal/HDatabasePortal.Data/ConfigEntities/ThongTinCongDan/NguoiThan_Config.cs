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
    public class NguoiThan_Config : IEntityTypeConfiguration<NguoiThan>
    {
        public void Configure(EntityTypeBuilder<NguoiThan> builder)
        {
            builder.ToTable("NguoiThan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.QuanHe_Ma });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.SoChungMinhNhanDan)
                .HasMaxLength(12);
            builder.Property(p => p.QuanHe_Ma)
                .HasMaxLength(2);
            builder.Property(p => p.ChungHo);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.Property(p => p.Ho)
                .HasMaxLength(20);
            builder.Property(p => p.ChuDem)
                .HasMaxLength(100);
            builder.Property(p => p.Ten)
                .HasMaxLength(20);

            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_NguoiThan)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.QuanHe)
                .WithMany(p => p.DS_NguoiThan)
                .HasForeignKey(p => p.QuanHe_Ma);
        }
    }
}
