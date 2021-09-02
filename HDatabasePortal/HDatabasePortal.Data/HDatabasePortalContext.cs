using HDatabasePortal.Data.ConfigEntities.DanToc;
using HDatabasePortal.Data.ConfigEntities.DiaPhuong;
using HDatabasePortal.Data.ConfigEntities.ThongTinCongDan;
using HDatabasePortal.Data.ConfigEntities.NgheNghiep;
using HDatabasePortal.Data.ConfigEntities.NguoiDung;
using HDatabasePortal.Data.ConfigEntities.NhomMau;
using HDatabasePortal.Data.ConfigEntities.TonGiao;
using HDatabasePortal.Data.Entities.ThongTinCongDan;
using HDatabasePortal.Data.Entities.DanToc;
using HDatabasePortal.Data.Entities.DiaPhuong;
using HDatabasePortal.Data.Entities.NgheNghiep;
using HDatabasePortal.Data.Entities.NguoiDung;
using HDatabasePortal.Data.Entities.NhomMau;
using HDatabasePortal.Data.Entities.TonGiao;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HDatabasePortal.Data
{
    public class HDatabasePortalContext : IdentityDbContext<AspNetUser,AspNetRole,Guid,AspNetUserClaim,AspNetUserRole,AspNetUserLogin,AspNetRoleClaim,AspNetUserToken>
    {
        public HDatabasePortalContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Nghe nghiep
            modelBuilder.ApplyConfiguration(new DanhMuc_NgheNghiepCap1_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_NgheNghiepCap2_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_NgheNghiepCap3_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_NgheNghiepCap4_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_NgheNghiepCap5_Config());
            //Dia phuong
            modelBuilder.ApplyConfiguration(new DanhMuc_ChauLuc_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_KhuVucQuocGia_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_QuocGia_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_CapQuanHuyen_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_CapTinhThanh_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_CapXaPhuong_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_KhuVucTinhThanhCap1_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_KhuVucTinhThanhCap2_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_TinhThanh_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_QuanHuyen_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_XaPhuong_Config());
            //Dan toc
            modelBuilder.ApplyConfiguration(new DanhMuc_DanToc_Config());
            //Ton giao
            modelBuilder.ApplyConfiguration(new DanhMuc_TonGiao_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_CacToChucTonGiaoChinh_Config());
            //Nhom mau
            modelBuilder.ApplyConfiguration(new DanhMuc_NhomMauHeABO_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_NhomMauHeRH_Config());
            //Tai khoan nguoi dung
            modelBuilder.ApplyConfiguration(new AspNetRole_Config());
            modelBuilder.ApplyConfiguration(new AspNetUserLogin_Config());
            modelBuilder.ApplyConfiguration(new AspNetUserClaim_Config());
            modelBuilder.ApplyConfiguration(new AspNetRoleClaim_Config());
            modelBuilder.ApplyConfiguration(new AspNetUser_Config());
            modelBuilder.ApplyConfiguration(new AspNetUserToken_Config());
            modelBuilder.ApplyConfiguration(new AspNetUserRole_Config());
            //Thong tin cong dan
            modelBuilder.ApplyConfiguration(new DanhMuc_TinhTrangHonNhan_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_GioiTinh_Config());
            modelBuilder.ApplyConfiguration(new DanhMuc_QuanHe_Config());
            modelBuilder.ApplyConfiguration(new CongDan_Config());
            //
            base.OnModelCreating(modelBuilder);
        }
        //Nghe nghiep
        public virtual DbSet<DanhMuc_NgheNghiepCap1> DanhMuc_NgheNghiepCap1 { get; set; }
        public virtual DbSet<DanhMuc_NgheNghiepCap2> DanhMuc_NgheNghiepCap2 { get; set; }
        public virtual DbSet<DanhMuc_NgheNghiepCap3> DanhMuc_NgheNghiepCap3 { get; set; }
        public virtual DbSet<DanhMuc_NgheNghiepCap4> DanhMuc_NgheNghiepCap4 { get; set; }
        public virtual DbSet<DanhMuc_NgheNghiepCap5> DanhMuc_NgheNghiepCap5 { get; set; }
        //Dia phuong
        public virtual DbSet<DanhMuc_ChauLuc> DanhMuc_ChauLuc { get; set; }
        public virtual DbSet<DanhMuc_KhuVucQuocGia> DanhMuc_KhuVucQuocGia { get; set; }
        public virtual DbSet<DanhMuc_QuocGia> DanhMuc_QuocGia { get; set; }
        public virtual DbSet<DanhMuc_CapTinhThanh> DanhMuc_CapTinhThanh { get; set; }
        public virtual DbSet<DanhMuc_CapQuanHuyen> DanhMuc_CapQuanHuyen { get; set; }
        public virtual DbSet<DanhMuc_CapXaPhuong> DanhMuc_CapXaPhuong { get; set; }
        public virtual DbSet<DanhMuc_KhuVucTinhThanhCap1> DanhMuc_KhuVucTinhThanh1 { get; set; }
        public virtual DbSet<DanhMuc_KhuVucTinhThanhCap2> DanhMuc_KhuVucTinhThanh2 { get; set; }
        public virtual DbSet<DanhMuc_TinhThanh> DanhMuc_TinhThanh { get; set; }
        public virtual DbSet<DanhMuc_QuanHuyen> DanhMuc_QuanHuyen { get; set; }
        public virtual DbSet<DanhMuc_XaPhuong> DanhMuc_XaPhuong { get; set; }
        //Dan toc
        public virtual DbSet<DanhMuc_DanToc> DanhMuc_DanToc { get; set; }
        //Ton giao
        public virtual DbSet<DanhMuc_TonGiao> DanhMuc_TonGiao { get; set; }
        public virtual DbSet<DanhMuc_CacToChucTonGiaoChinh> DanhMuc_CacToChucTonGiaoChinh { get; set; }
        //Nhom mau
        public virtual DbSet<DanhMuc_NhomMauHeABO> DanhMuc_NhomMauHeABO { get; set; }
        public virtual DbSet<DanhMuc_NhomMauHeRH> DanhMuc_NhomMauHeRH { get; set; }
        //Tai khoan nguoi dung
        //public virtual DbSet<DanhMuc_VaiTro> DanhMuc_VaiTro { get; set; }
        //public virtual DbSet<TaiKhoan_DangNhap> TaiKhoan_DangNhap { get; set; }
        //public virtual DbSet<QuyenHan_TaiKhoan> QuyenHan_TaiKhoan { get; set; }
        //public virtual DbSet<QuyenHan_VaiTro> QuyenHan_VaiTro { get; set; }
        //public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        //public virtual DbSet<TheKhoa_TaiKhoan> TheKhoa_TaiKhoan { get; set; }
        //public virtual DbSet<VaiTro_TaiKhoan> VaiTro_TaiKhoan { get; set; }
        //Cong dan
        public virtual DbSet<DanhMuc_TinhTrangHonNhan> DanhMuc_TinhTrangHonNhan { get; set; }
        public virtual DbSet<DanhMuc_GioiTinh> DanhMuc_GioiTinh { get; set; }
        public virtual DbSet<DanhMuc_QuanHe> DanhMuc_QuanHe { get; set; }
        public virtual DbSet<CongDan> CongDan { get; set; }

    }
}
