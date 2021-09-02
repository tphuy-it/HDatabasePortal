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
    public class AspNetUserClaim_Config : IEntityTypeConfiguration<AspNetUserClaim>
    {
        public void Configure(EntityTypeBuilder<AspNetUserClaim> builder)
        {
            builder.ToTable(name:"QuyenHan_TaiKhoan")
                .HasKey(p=>p.UserId);
            builder.Property(p => p.UserId)
                .HasMaxLength(50);
        }
    }
}
