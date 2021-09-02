using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDatabasePortal.Data.Entities.NguoiDung;
using HDatabasePortal.Data.Entities.ThongTinCongDan;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HDatabasePortal.Data.ConfigEntities.NguoiDung
{
    public class AspNetUser_Config : IEntityTypeConfiguration<AspNetUser>
    {
        public void Configure(EntityTypeBuilder<AspNetUser> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .HasMaxLength(50);
            builder.Property(p => p.Email)
                .HasMaxLength(100);
            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(20);
            builder.Property(p => p.UserName)
                .HasMaxLength(20);
            builder.Property(p => p.SoDinhDanh)
                .HasMaxLength(12);
            builder.HasOne<CongDan>(p => p.CongDan)
                .WithOne(p=>p.TaiKhoan)
                .HasForeignKey<AspNetUser>(p => p.SoDinhDanh);

        }
    }
}
