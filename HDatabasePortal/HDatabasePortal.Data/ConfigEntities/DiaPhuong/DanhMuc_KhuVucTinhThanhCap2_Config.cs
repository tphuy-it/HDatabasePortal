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
    public class DanhMuc_KhuVucTinhThanhCap2_Config : IEntityTypeConfiguration<DanhMuc_KhuVucTinhThanhCap2>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_KhuVucTinhThanhCap2> builder)
        {
            builder.ToTable("DanhMuc_KhuVucTinhThanhCap2")
                 .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
            builder.Property(p => p.KhuVucTinhThanhCap1_Ma)
                .HasMaxLength(2);

            builder.HasOne(p => p.KhuVucTinhThanhCap1)
                .WithMany(p => p.DS_KhuVucTinhThanhCap2)
                .HasForeignKey(p => p.KhuVucTinhThanhCap1_Ma);
        }
    }
}
