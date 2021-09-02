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
    public class DanhMuc_GioiTinh_Config : IEntityTypeConfiguration<DanhMuc_GioiTinh>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_GioiTinh> builder)
        {
            builder.ToTable("DanhMuc_GioiTinh")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .ValueGeneratedNever();
            builder.Property(p => p.Ten)
                .HasMaxLength(20);
            
        }
    }
}
