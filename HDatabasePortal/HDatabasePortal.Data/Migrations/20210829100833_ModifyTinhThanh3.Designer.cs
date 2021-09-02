﻿// <auto-generated />
using System;
using HDatabasePortal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HDatabasePortal.Data.Migrations
{
    [DbContext(typeof(HDatabasePortalContext))]
    [Migration("20210829100833_ModifyTinhThanh3")]
    partial class ModifyTinhThanh3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DanToc.DanhMuc_DanToc", b =>
                {
                    b.Property<string>("DanToc_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("DanToc_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DanToc_Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DanToc_TenKhac")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("DanToc_Ma");

                    b.ToTable("DanhMuc_DanToc");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapQuanHuyen", b =>
                {
                    b.Property<string>("CapQuanHuyen_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CapQuanHuyen_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CapQuanHuyen_Ma");

                    b.ToTable("DanhMuc_CapQuanHuyen");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapTinhThanh", b =>
                {
                    b.Property<string>("CapTinhThanh_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CapTinhThanh_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CapTinhThanh_Ma");

                    b.ToTable("DanhMuc_CapTinhThanh");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapXaPhuong", b =>
                {
                    b.Property<string>("CapXaPhuong_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CapXaPhuong_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CapXaPhuong_Ma");

                    b.ToTable("DanhMuc_CapXaPhuong");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_ChauLuc", b =>
                {
                    b.Property<string>("ChauLuc_MaM49")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("ChauLuc_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ChauLuc_TenTA")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ChauLuc_TenTV")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ChauLuc_MaM49");

                    b.ToTable("DanhMuc_ChauLuc");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucQuocGia", b =>
                {
                    b.Property<string>("KhuVucQuocGia_MaM49")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("ChauLuc_MaM49")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("KhuVucQuocGia_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("KhuVucQuocGia_TenTA")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KhuVucQuocGia_TenTV")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KhuVucQuocGia_MaM49");

                    b.HasIndex("ChauLuc_MaM49");

                    b.ToTable("DanhMuc_KhuVucQuocGia");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap1", b =>
                {
                    b.Property<string>("KhuVucTinhThanhCap1_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("KhuVucTinhThanhCap1_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuocGia_MaM49")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("KhuVucTinhThanhCap1_Ma");

                    b.HasIndex("QuocGia_MaM49");

                    b.ToTable("DanhMuc_KhuVucTinhThanhCap1");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap2", b =>
                {
                    b.Property<string>("KhuVucTinhThanhCap2_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("KhuVucTinhThanhCap1_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("KhuVucTinhThanhCap2_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("KhuVucTinhThanhCap2_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KhuVucTinhThanhCap2_Ma");

                    b.HasIndex("KhuVucTinhThanhCap1_Ma");

                    b.ToTable("DanhMuc_KhuVucTinhThanhCap2");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuanHuyen", b =>
                {
                    b.Property<string>("QuanHuyen_MaHanhChinh")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("CapQuanHuyen_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("QuanHuyen_MaBuuChinh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("QuanHuyen_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuanHuyen_TenKhac")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TinhThanh_MaHanhChinh")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("QuanHuyen_MaHanhChinh");

                    b.HasIndex("CapQuanHuyen_Ma");

                    b.HasIndex("TinhThanh_MaHanhChinh");

                    b.ToTable("DanhMuc_QuanHuyen");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuocGia", b =>
                {
                    b.Property<string>("QuocGia_MaM49")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("KhuVucQuocGia_MaM49")
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("QuocGia_MaAlpha2")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("QuocGia_MaAlpha3")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("QuocGia_MaBuuChinh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("QuocGia_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("QuocGia_MuiGio")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("QuocGia_QuocKy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QuocGia_QuocTich")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuocGia_TenTA")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuocGia_TenTV")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("QuocGia_MaM49");

                    b.HasIndex("KhuVucQuocGia_MaM49");

                    b.ToTable("DanhMuc_QuocGia");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_TinhThanh", b =>
                {
                    b.Property<string>("TinhThanh_MaHanhChinh")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CapTinhThanh_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("KhuVucTinhThanhCap2_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime?>("TinhThanh_DenNgay")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinhThanh_MaBuuChinh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TinhThanh_MaVungDienThoai")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("TinhThanh_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TinhThanh_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TinhThanh_TenKhac")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("TinhThanh_TuNgay")
                        .HasColumnType("datetime2");

                    b.HasKey("TinhThanh_MaHanhChinh");

                    b.HasIndex("CapTinhThanh_Ma");

                    b.HasIndex("KhuVucTinhThanhCap2_Ma");

                    b.ToTable("DanhMuc_TinhThanh");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_XaPhuong", b =>
                {
                    b.Property<string>("XaPhuong_MaHanhChinh")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("CapXaPhuong_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("QuanHuyen_MaHanhChinh")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("XaPhuong_MaBuuChinh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("XaPhuong_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("XaPhuong_TenKhac")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("XaPhuong_MaHanhChinh");

                    b.HasIndex("CapXaPhuong_Ma");

                    b.HasIndex("QuanHuyen_MaHanhChinh");

                    b.ToTable("DanhMuc_XaPhuong");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.Khac.DanhMuc_TinhTrangHonNhan", b =>
                {
                    b.Property<int>("TinhTrangHonNhan_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TinhTrangHonNhan_Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TinhTrangHonNhan_ID");

                    b.ToTable("DanhMuc_TinhTrangHonNhan");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap1", b =>
                {
                    b.Property<string>("NgheNghiepCap1_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NgheNghiepCap1_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NgheNghiepCap1_Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("NgheNghiepCap1_Ma");

                    b.ToTable("DanhMuc_NgheNghiepCap1");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap2", b =>
                {
                    b.Property<string>("NgheNghiepCap2_Ma")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("NgheNghiepCap1_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NgheNghiepCap2_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NgheNghiepCap2_Ten")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("NgheNghiepCap2_Ma");

                    b.HasIndex("NgheNghiepCap1_Ma");

                    b.ToTable("DanhMuc_NgheNghiepCap2");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap3", b =>
                {
                    b.Property<string>("NgheNghiepCap3_Ma")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("NgheNghiepCap2_Ma")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("NgheNghiepCap3_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NgheNghiepCap3_Ten")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("NgheNghiepCap3_Ma");

                    b.HasIndex("NgheNghiepCap2_Ma");

                    b.ToTable("DanhMuc_NgheNghiepCap3");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap4", b =>
                {
                    b.Property<string>("NgheNghiepCap4_Ma")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("NgheNghiepCap3_Ma")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("NgheNghiepCap4_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NgheNghiepCap4_Ten")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("NgheNghiepCap4_Ma");

                    b.HasIndex("NgheNghiepCap3_Ma");

                    b.ToTable("DanhMuc_NgheNghiepCap4");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap5", b =>
                {
                    b.Property<string>("NgheNghiepCap5_Ma")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("NgheNghiepCap4_Ma")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("NgheNghiepCap5_MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NgheNghiepCap5_Ten")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("NgheNghiepCap5_Ma");

                    b.HasIndex("NgheNghiepCap4_Ma");

                    b.ToTable("DanhMuc_NgheNghiepCap5");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NhomMau.DanhMuc_NhomMauHeABO", b =>
                {
                    b.Property<string>("NhomMauHeABO_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NhomMauHeABO_Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NhomMauHeABO_Ma");

                    b.ToTable("DanhMuc_NhomMauHeABO");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NhomMau.DanhMuc_NhomMauHeRH", b =>
                {
                    b.Property<string>("NhomMauHeRH_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NhomMauHeRH_Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NhomMauHeRH_Ma");

                    b.ToTable("DanhMuc_NhomMauHeRH");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.TonGiao.DanhMuc_CacToChucTonGiaoChinh", b =>
                {
                    b.Property<int>("CacToChucTonGiaoChinh_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CacToChucTonGiaoChinh_Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TonGiao_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("CacToChucTonGiaoChinh_ID");

                    b.HasIndex("TonGiao_Ma");

                    b.ToTable("DanhMuc_CacToChucTonGiaoChinh");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.TonGiao.DanhMuc_TonGiao", b =>
                {
                    b.Property<string>("TonGiao_Ma")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("TonGiao_Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TonGiao_Ma");

                    b.ToTable("DanhMuc_TonGiao");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucQuocGia", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_ChauLuc", "ChauLuc")
                        .WithMany("DS_KhuVucQuocGia")
                        .HasForeignKey("ChauLuc_MaM49");

                    b.Navigation("ChauLuc");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap1", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuocGia", "QuocGia")
                        .WithMany("DS_KhuVucTinhThanhCap1")
                        .HasForeignKey("QuocGia_MaM49");

                    b.Navigation("QuocGia");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap2", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap1", "KhuVucTinhThanhCap1")
                        .WithMany("DS_KhuVucTinhThanhCap2")
                        .HasForeignKey("KhuVucTinhThanhCap1_Ma");

                    b.Navigation("KhuVucTinhThanhCap1");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuanHuyen", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapQuanHuyen", "CapQuanHuyen")
                        .WithMany("DS_QuanHuyen")
                        .HasForeignKey("CapQuanHuyen_Ma");

                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_TinhThanh", "TinhThanh")
                        .WithMany("DS_QuanHuyen")
                        .HasForeignKey("TinhThanh_MaHanhChinh");

                    b.Navigation("CapQuanHuyen");

                    b.Navigation("TinhThanh");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuocGia", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucQuocGia", "KhuVucQuocGia")
                        .WithMany("DS_QuocGia")
                        .HasForeignKey("KhuVucQuocGia_MaM49");

                    b.Navigation("KhuVucQuocGia");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_TinhThanh", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapTinhThanh", "CapTinhThanh")
                        .WithMany("DS_TinhThanh")
                        .HasForeignKey("CapTinhThanh_Ma");

                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap2", "KhuVucTinhThanhCap2")
                        .WithMany("DS_TinhThanh")
                        .HasForeignKey("KhuVucTinhThanhCap2_Ma");

                    b.Navigation("CapTinhThanh");

                    b.Navigation("KhuVucTinhThanhCap2");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_XaPhuong", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapXaPhuong", "CapXaPhuong")
                        .WithMany("DS_XaPhuong")
                        .HasForeignKey("CapXaPhuong_Ma");

                    b.HasOne("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuanHuyen", "QuanHuyen")
                        .WithMany("DS_XaPhuong")
                        .HasForeignKey("QuanHuyen_MaHanhChinh");

                    b.Navigation("CapXaPhuong");

                    b.Navigation("QuanHuyen");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap2", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap1", "NgheNghiepCap1")
                        .WithMany("DS_NgheNghiepCap2")
                        .HasForeignKey("NgheNghiepCap1_Ma");

                    b.Navigation("NgheNghiepCap1");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap3", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap2", "NgheNghiepCap2")
                        .WithMany("DS_NgheNghiepCap3")
                        .HasForeignKey("NgheNghiepCap2_Ma");

                    b.Navigation("NgheNghiepCap2");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap4", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap3", "NgheNghiepCap3")
                        .WithMany("DS_NgheNghiepCap4")
                        .HasForeignKey("NgheNghiepCap3_Ma");

                    b.Navigation("NgheNghiepCap3");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap5", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap4", "NgheNghiepCap4")
                        .WithMany("DS_NgheNghiepCap5")
                        .HasForeignKey("NgheNghiepCap4_Ma");

                    b.Navigation("NgheNghiepCap4");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.TonGiao.DanhMuc_CacToChucTonGiaoChinh", b =>
                {
                    b.HasOne("HDatabasePortal.Data.Entities.TonGiao.DanhMuc_TonGiao", "TonGiao")
                        .WithMany("DS_CacToChucTonGiaoChinh")
                        .HasForeignKey("TonGiao_Ma");

                    b.Navigation("TonGiao");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapQuanHuyen", b =>
                {
                    b.Navigation("DS_QuanHuyen");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapTinhThanh", b =>
                {
                    b.Navigation("DS_TinhThanh");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_CapXaPhuong", b =>
                {
                    b.Navigation("DS_XaPhuong");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_ChauLuc", b =>
                {
                    b.Navigation("DS_KhuVucQuocGia");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucQuocGia", b =>
                {
                    b.Navigation("DS_QuocGia");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap1", b =>
                {
                    b.Navigation("DS_KhuVucTinhThanhCap2");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_KhuVucTinhThanhCap2", b =>
                {
                    b.Navigation("DS_TinhThanh");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuanHuyen", b =>
                {
                    b.Navigation("DS_XaPhuong");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_QuocGia", b =>
                {
                    b.Navigation("DS_KhuVucTinhThanhCap1");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.DiaPhuong.DanhMuc_TinhThanh", b =>
                {
                    b.Navigation("DS_QuanHuyen");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap1", b =>
                {
                    b.Navigation("DS_NgheNghiepCap2");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap2", b =>
                {
                    b.Navigation("DS_NgheNghiepCap3");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap3", b =>
                {
                    b.Navigation("DS_NgheNghiepCap4");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.NgheNghiep.DanhMuc_NgheNghiepCap4", b =>
                {
                    b.Navigation("DS_NgheNghiepCap5");
                });

            modelBuilder.Entity("HDatabasePortal.Data.Entities.TonGiao.DanhMuc_TonGiao", b =>
                {
                    b.Navigation("DS_CacToChucTonGiaoChinh");
                });
#pragma warning restore 612, 618
        }
    }
}
