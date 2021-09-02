using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.DiaPhuong;
namespace HDatabasePortal.Data.ConfigEntities.DiaPhuong
{
    public class DanhMuc_CapTinhThanh_Config : IEntityTypeConfiguration<DanhMuc_CapTinhThanh>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_CapTinhThanh> builder)
        {
            builder.ToTable("DanhMuc_CapTinhThanh")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            
        }
    }
}
