using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDatabasePortal.Data.Entities.ThongTinCongDan;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HDatabasePortal.Data.ConfigEntities.ThongTinCongDan
{
    public class DanhMuc_LoaiTrangThai_Config : IEntityTypeConfiguration<DanhMuc_LoaiTrangThai>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_LoaiTrangThai> builder)
        {
            builder.ToTable("DanhMuc_LoaiTrangThai")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(1);
            builder.Property(p => p.Ten)
                .HasMaxLength(50);
        }
    }
}
