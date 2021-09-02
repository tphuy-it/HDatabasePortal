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
    public class AspNetUserToken_Config : IEntityTypeConfiguration<AspNetUserToken>
    {
        public void Configure(EntityTypeBuilder<AspNetUserToken> builder)
        {
            builder.ToTable(name: "TheKhoa_TaiKhoan")
                .HasKey(p => new { p.UserId, p.LoginProvider, p.Name });
            builder.Property(p => p.UserId)
                .HasMaxLength(50);
            builder.Property(p => p.LoginProvider)
                .HasMaxLength(50);
            builder.Property(p => p.Name)
                .HasMaxLength(50);
        }
    }
}
