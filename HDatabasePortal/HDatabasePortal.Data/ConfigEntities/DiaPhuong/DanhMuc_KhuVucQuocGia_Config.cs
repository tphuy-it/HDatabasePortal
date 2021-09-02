using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HDatabasePortal.Data.Entities.DiaPhuong;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HDatabasePortal.Data.ConfigEntities.DiaPhuong
{
    public class DanhMuc_KhuVucQuocGia_Config : IEntityTypeConfiguration<DanhMuc_KhuVucQuocGia>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_KhuVucQuocGia> builder)
        {
            builder.ToTable("DanhMuc_KhuVucQuocGia")
                .HasKey(p => p.MaM49);
            builder.Property(p => p.MaM49)
                .HasMaxLength(4);
            builder.Property(p => p.TenTA)
                .HasMaxLength(100);
            builder.Property(p => p.TenTV)
                .HasMaxLength(100);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.Property(p => p.ChauLuc_MaM49)
                .HasMaxLength(4);
            builder.HasOne(p => p.ChauLuc)
                .WithMany(p => p.DS_KhuVucQuocGia)
                .HasForeignKey(p => p.ChauLuc_MaM49);
        }
    }
}
