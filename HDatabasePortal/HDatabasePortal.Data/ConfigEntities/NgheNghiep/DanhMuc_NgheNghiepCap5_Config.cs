using HDatabasePortal.Data.Entities.NgheNghiep;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.ConfigEntities.NgheNghiep
{
    class DanhMuc_NgheNghiepCap5_Config : IEntityTypeConfiguration<DanhMuc_NgheNghiepCap5>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NgheNghiepCap5> builder)
        {
            builder.ToTable("DanhMuc_NgheNghiepCap5")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                    .HasMaxLength(6);
            builder.Property(p => p.Ten)
                    .HasMaxLength(256);
            builder.Property(p => p.MoTa)
                    .HasMaxLength(500);
            builder.Property(p => p.NgheNghiepCap4_Ma)
                .HasMaxLength(5);
            builder.HasOne(p => p.NgheNghiepCap4)
                .WithMany(p => p.DS_NgheNghiepCap5)
                .HasForeignKey(p => p.NgheNghiepCap4_Ma);

        }
    }
}
