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
    public class AspNetUserLogin_Config : IEntityTypeConfiguration<AspNetUserLogin>
    {
        public void Configure(EntityTypeBuilder<AspNetUserLogin> builder)
        {
            builder.ToTable(name: "TaiKhoan_DangNhap")
                .HasKey(p=>new { p.LoginProvider,p.ProviderKey });
            builder.Property(p => p.UserId)
                .HasMaxLength(50);
            builder.Property(p => p.ProviderKey)
                .HasMaxLength(50);

        }
    }
}
