using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDatabasePortal.Data.Entities.NguoiDung;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HDatabasePortal.Data.ConfigEntities.NguoiDung
{
    public class AspNetUserRole_Config : IEntityTypeConfiguration<AspNetUserRole>
    {
        public void Configure(EntityTypeBuilder<AspNetUserRole> builder)
        {
            builder.ToTable(name: "VaiTro_TaiKhoan")
                .HasKey(p => new { p.UserId, p.RoleId });
            builder.Property(p => p.UserId)
                .HasMaxLength(50);
            builder.Property(p => p.RoleId)
                .HasMaxLength(50);
        }
    }
}
