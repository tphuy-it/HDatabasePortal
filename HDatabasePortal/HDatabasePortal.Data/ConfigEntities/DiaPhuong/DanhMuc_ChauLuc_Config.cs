using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDatabasePortal.Data.Entities.DiaPhuong;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HDatabasePortal.Data.ConfigEntities.DiaPhuong
{
    public class DanhMuc_ChauLuc_Config : IEntityTypeConfiguration<DanhMuc_ChauLuc>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_ChauLuc> builder)
        {
            builder.ToTable("DanhMuc_ChauLuc")
                .HasKey(p => p.MaM49);
            builder.Property(p => p.MaM49)
                .HasMaxLength(4);
            builder.Property(p => p.TenTA)
                .HasMaxLength(100);
            builder.Property(p => p.TenTV)
                .HasMaxLength(100);
            builder.Property(p => p.MoTa)
                .HasMaxLength(500);
        }
    }
}
