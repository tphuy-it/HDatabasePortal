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
    class DanhMuc_NgheNghiepCap4_Config : IEntityTypeConfiguration<DanhMuc_NgheNghiepCap4>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NgheNghiepCap4> builder)
        {
            builder.ToTable("DanhMuc_NgheNghiepCap4")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                    .HasMaxLength(5);
            builder.Property(p => p.Ten)
                    .HasMaxLength(256);
            builder.Property(p => p.MoTa)
                    .HasMaxLength(500);
            builder.Property(p => p.NgheNghiepCap3_Ma)
                .HasMaxLength(4);
            builder.HasOne(p => p.NgheNghiepCap3)
                .WithMany(p => p.DS_NgheNghiepCap4)
                .HasForeignKey(p => p.NgheNghiepCap3_Ma);

        }
    }
}
