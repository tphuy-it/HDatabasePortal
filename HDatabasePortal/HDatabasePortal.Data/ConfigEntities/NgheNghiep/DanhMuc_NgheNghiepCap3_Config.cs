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
    public class DanhMuc_NgheNghiepCap3_Config : IEntityTypeConfiguration<DanhMuc_NgheNghiepCap3>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NgheNghiepCap3> builder)
        {
            builder.ToTable("DanhMuc_NgheNghiepCap3")
                          .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                    .HasMaxLength(4);
            builder.Property(p => p.Ten)
                    .HasMaxLength(256);
            builder.Property(p => p.MoTa)
                    .HasMaxLength(500);
            builder.Property(p => p.NgheNghiepCap2_Ma)
                .HasMaxLength(3);
            builder.HasOne(p => p.NgheNghiepCap2)
                .WithMany(p => p.DS_NgheNghiepCap3)
                .HasForeignKey(p => p.NgheNghiepCap2_Ma);
        }
    }
}
