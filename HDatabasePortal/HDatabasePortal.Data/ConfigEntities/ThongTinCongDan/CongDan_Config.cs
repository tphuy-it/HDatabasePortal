using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.ThongTinCongDan;
using HDatabasePortal.Data.Entities.NguoiDung;

namespace HDatabasePortal.Data.ConfigEntities.ThongTinCongDan
{
    public class CongDan_Config : IEntityTypeConfiguration<CongDan>
    {
        public void Configure(EntityTypeBuilder<CongDan> builder)
        {
            builder.ToTable("CongDan")
                .HasKey(p => p.SoDinhDanh);
            builder.Property(p => p.SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.SoChungMinhNhanDan)
                .HasMaxLength(12);
            builder.Property(p => p.Ho)
                .HasMaxLength(20);
            builder.Property(p => p.ChuDem)
                .HasMaxLength(100);
            builder.Property(p => p.Ten)
                .HasMaxLength(20);
            builder.Property(p => p.NgayThangNamSinh);
            builder.Property(p => p.NamSinh);
            builder.Property(p => p.GioiTinh_Ma);
            builder.Property(p => p.AspNetUser_ID)
                .HasMaxLength(50);
            builder.Property(p => p.NgheNghiepCap5_Ma)
                .HasMaxLength(6);
            builder.HasOne<AspNetUser>(p => p.TaiKhoan)
                .WithOne(p => p.CongDan)
                .HasForeignKey<CongDan>(p => p.AspNetUser_ID);
        }
    }
}
