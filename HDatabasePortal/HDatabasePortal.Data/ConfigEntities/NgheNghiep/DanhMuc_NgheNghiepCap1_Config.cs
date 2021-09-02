using HDatabasePortal.Data.Entities.NgheNghiep;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HDatabasePortal.Data.ConfigEntities.NgheNghiep
{
    public class DanhMuc_NgheNghiepCap1_Config : IEntityTypeConfiguration<DanhMuc_NgheNghiepCap1>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NgheNghiepCap1> builder)
        {
            builder.ToTable("DanhMuc_NgheNghiepCap1")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);

        }
    }
}
