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
    public class AspNetRoleClaim_Config : IEntityTypeConfiguration<AspNetRoleClaim>
    {
        public void Configure(EntityTypeBuilder<AspNetRoleClaim> builder)
        {
            builder.ToTable(name:"QuyenHan_VaiTro")
                .HasKey(p => p.RoleId);
            builder.Property(p => p.RoleId)
                .HasMaxLength(50);
        }
    }
}
