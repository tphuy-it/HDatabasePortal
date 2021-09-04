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
    public class DanhMuc_LoaiDiaChi_Config : IEntityTypeConfiguration<DanhMuc_LoaiDiaChi>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_LoaiDiaChi> builder)
        {
            builder.ToTable("DanhMuc_LoaiDiaChi")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(50);
        }
    }
}
