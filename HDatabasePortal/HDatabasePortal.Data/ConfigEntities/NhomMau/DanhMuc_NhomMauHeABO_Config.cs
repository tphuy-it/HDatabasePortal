using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.NhomMau;
namespace HDatabasePortal.Data.ConfigEntities.NhomMau
{
    public class DanhMuc_NhomMauHeABO_Config : IEntityTypeConfiguration<DanhMuc_NhomMauHeABO>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NhomMauHeABO> builder)
        {
            builder.ToTable("DanhMuc_NhomMauHeABO")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(50);
        }
    }
}
