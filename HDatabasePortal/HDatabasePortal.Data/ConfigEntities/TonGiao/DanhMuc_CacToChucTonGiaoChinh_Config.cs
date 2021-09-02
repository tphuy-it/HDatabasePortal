using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.TonGiao;
namespace HDatabasePortal.Data.ConfigEntities.TonGiao
{
    public class DanhMuc_CacToChucTonGiaoChinh_Config : IEntityTypeConfiguration<DanhMuc_CacToChucTonGiaoChinh>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_CacToChucTonGiaoChinh> builder)
        {
            builder.ToTable("DanhMuc_CacToChucTonGiaoChinh")
                .HasKey(p => p.ID);
            builder.Property(p => p.ID);
                builder.Property(p => p.Ten)
                .HasMaxLength(100);
            builder.Property(p => p.TonGiao_Ma)
                .HasMaxLength(2);

            builder.HasOne(p => p.TonGiao)
                .WithMany(p => p.DS_CacToChucTonGiaoChinh)
                .HasForeignKey(p => p.TonGiao_Ma);
        }
    }
}
