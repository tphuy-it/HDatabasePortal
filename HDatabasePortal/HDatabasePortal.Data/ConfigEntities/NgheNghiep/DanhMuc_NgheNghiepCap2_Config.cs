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
    class DanhMuc_NgheNghiepCap2_Config : IEntityTypeConfiguration<DanhMuc_NgheNghiepCap2>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NgheNghiepCap2> builder)
        {
            builder.ToTable("DanhMuc_NgheNghiepCap2")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                    .HasMaxLength(3);
            builder.Property(p => p.Ten)
                    .HasMaxLength(256);
            builder.Property(p => p.MoTa)
                    .HasMaxLength(500);

            builder.Property(p => p.NgheNghiepCap1_Ma)
                    .HasMaxLength(2);
            builder.HasOne(p => p.NgheNghiepCap1)
                .WithMany(p => p.DS_NgheNghiepCap2)
                .HasForeignKey(p => p.NgheNghiepCap1_Ma);
                    
        }
    }
}
