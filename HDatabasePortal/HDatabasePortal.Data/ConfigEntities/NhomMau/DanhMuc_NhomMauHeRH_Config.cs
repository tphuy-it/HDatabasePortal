﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HDatabasePortal.Data.Entities.NhomMau;
namespace HDatabasePortal.Data.ConfigEntities.NhomMau
{
    class DanhMuc_NhomMauHeRH_Config : IEntityTypeConfiguration<DanhMuc_NhomMauHeRH>
    {
        public void Configure(EntityTypeBuilder<DanhMuc_NhomMauHeRH> builder)
        {
            builder.ToTable("DanhMuc_NhomMauHeRH")
                .HasKey(p => p.Ma);
            builder.Property(p => p.Ma)
                .HasMaxLength(2);
            builder.Property(p => p.Ten)
                .HasMaxLength(50);
        }
    }
}
