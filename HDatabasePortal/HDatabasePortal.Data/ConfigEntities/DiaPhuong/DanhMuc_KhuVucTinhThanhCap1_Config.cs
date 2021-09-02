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
    public class DanhMuc_KhuVucTinhThanhCap1_Config : IEntityTypeConfiguration<DanhMuc_KhuVucTinhThanhCap1>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_KhuVucTinhThanhCap1> builder)
        {
            builder.ToTable("DanhMuc_KhuVucTinhThanhCap1")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);

            builder.Property(p => p.QuocGia_MaM49)
                .HasMaxLength(4);
            builder.HasOne(p => p.QuocGia)
                .WithMany(p => p.DS_KhuVucTinhThanhCap1)
                .HasForeignKey(p => p.QuocGia_MaM49);
        }
    }
}
