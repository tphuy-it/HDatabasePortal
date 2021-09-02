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
    public class DanhMuc_QuocGia_Config : IEntityTypeConfiguration<DanhMuc_QuocGia>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_QuocGia> builder)
        {
            builder.ToTable("DanhMuc_QuocGia")
                .HasKey(p => p.MaM49);
            builder.Property(p => p.MaM49)
                .HasMaxLength(4);
            builder.Property(p => p.TenTA)
                .HasMaxLength(100);
            builder.Property(p => p.TenTV)
                .HasMaxLength(100);
            builder.Property(p => p.QuocTich)
                .HasMaxLength(100);
            builder.Property(p => p.MaAlpha2)
                .HasMaxLength(2);
            builder.Property(p => p.MaAlpha3)
                .HasMaxLength(3);
            builder.Property(p => p.MaBuuChinh)
                .HasMaxLength(20);
            builder.Property(p => p.QuocKy)
                .HasMaxLength(50);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.Property(p => p.MuiGio)
                .HasMaxLength(20);
            builder.HasOne(p => p.KhuVucQuocGia)
                .WithMany(p => p.DS_QuocGia)
                .HasForeignKey(p => p.KhuVucQuocGia_MaM49);
        }
    }
}
