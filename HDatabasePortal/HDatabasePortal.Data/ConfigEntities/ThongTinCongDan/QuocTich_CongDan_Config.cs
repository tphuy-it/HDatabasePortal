using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.ThongTinCongDan;
namespace HDatabasePortal.Data.ConfigEntities.ThongTinCongDan
{
    public class QuocTich_CongDan_Config : IEntityTypeConfiguration<QuocTich_CongDan>
    {
        public void Configure(EntityTypeBuilder<QuocTich_CongDan> builder)
        {
            builder.ToTable("QuocTich_CongDan")
                .HasKey(p => new { p.CongDan_SoDinhDanh, p.QuocGia_MaM49 });
            builder.Property(p => p.CongDan_SoDinhDanh)
                .HasMaxLength(12);
            builder.Property(p => p.QuocGia_MaM49)
                .HasMaxLength(4);
            builder.Property(p => p.TuNgay);
            builder.Property(p => p.HienTai);
            builder.HasOne(p => p.CongDan)
                .WithMany(p => p.DS_QuocTich)
                .HasForeignKey(p => p.CongDan_SoDinhDanh);
            builder.HasOne(p => p.QuocGia)
                .WithMany(p => p.DS_QuocTich_CongDan)
                .HasForeignKey(p => p.QuocGia_MaM49);
        }
    }
}
