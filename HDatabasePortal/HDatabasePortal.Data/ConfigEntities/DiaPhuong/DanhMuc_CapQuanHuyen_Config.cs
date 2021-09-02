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
    public class DanhMuc_CapQuanHuyen_Config : IEntityTypeConfiguration<DanhMuc_CapQuanHuyen>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_CapQuanHuyen> builder)
        {
            builder.ToTable("DanhMuc_CapQuanHuyen")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(100);
            
        }
    }
}
