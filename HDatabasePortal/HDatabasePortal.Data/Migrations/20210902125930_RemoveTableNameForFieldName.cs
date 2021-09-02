using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HDatabasePortal.Data.Migrations
{
    public partial class RemoveTableNameForFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMuc_TinhTrangHonNhan",
                table: "DanhMuc_TinhTrangHonNhan");

            migrationBuilder.DropColumn(
                name: "TinhTrangHonNhan_ID",
                table: "DanhMuc_TinhTrangHonNhan");

            migrationBuilder.DropColumn(
                name: "CacToChucTonGiaoChinh_Ten",
                table: "DanhMuc_CacToChucTonGiaoChinh");

            migrationBuilder.RenameColumn(
                name: "XaPhuong_TenKhac",
                table: "DanhMuc_XaPhuong",
                newName: "TenKhac");

            migrationBuilder.RenameColumn(
                name: "XaPhuong_Ten",
                table: "DanhMuc_XaPhuong",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "XaPhuong_MaBuuChinh",
                table: "DanhMuc_XaPhuong",
                newName: "MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "XaPhuong_MaHanhChinh",
                table: "DanhMuc_XaPhuong",
                newName: "MaHanhChinh");

            migrationBuilder.RenameColumn(
                name: "TonGiao_Ten",
                table: "DanhMuc_TonGiao",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "TonGiao_Ma",
                table: "DanhMuc_TonGiao",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "TinhTrangHonNhan_Ten",
                table: "DanhMuc_TinhTrangHonNhan",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_TuNgay",
                table: "DanhMuc_TinhThanh",
                newName: "TuNgay");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_TenKhac",
                table: "DanhMuc_TinhThanh",
                newName: "TenKhac");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_Ten",
                table: "DanhMuc_TinhThanh",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_MoTa",
                table: "DanhMuc_TinhThanh",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_MaVungDienThoai",
                table: "DanhMuc_TinhThanh",
                newName: "MaVungDienThoai");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_MaBuuChinh",
                table: "DanhMuc_TinhThanh",
                newName: "MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_DenNgay",
                table: "DanhMuc_TinhThanh",
                newName: "DenNgay");

            migrationBuilder.RenameColumn(
                name: "TinhThanh_MaHanhChinh",
                table: "DanhMuc_TinhThanh",
                newName: "MaHanhChinh");

            migrationBuilder.RenameColumn(
                name: "QuocGia_TenTV",
                table: "DanhMuc_QuocGia",
                newName: "TenTV");

            migrationBuilder.RenameColumn(
                name: "QuocGia_TenTA",
                table: "DanhMuc_QuocGia",
                newName: "TenTA");

            migrationBuilder.RenameColumn(
                name: "QuocGia_QuocTich",
                table: "DanhMuc_QuocGia",
                newName: "QuocTich");

            migrationBuilder.RenameColumn(
                name: "QuocGia_QuocKy",
                table: "DanhMuc_QuocGia",
                newName: "QuocKy");

            migrationBuilder.RenameColumn(
                name: "QuocGia_MuiGio",
                table: "DanhMuc_QuocGia",
                newName: "MuiGio");

            migrationBuilder.RenameColumn(
                name: "QuocGia_MoTa",
                table: "DanhMuc_QuocGia",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "QuocGia_MaBuuChinh",
                table: "DanhMuc_QuocGia",
                newName: "MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "QuocGia_MaAlpha3",
                table: "DanhMuc_QuocGia",
                newName: "MaAlpha3");

            migrationBuilder.RenameColumn(
                name: "QuocGia_MaAlpha2",
                table: "DanhMuc_QuocGia",
                newName: "MaAlpha2");

            migrationBuilder.RenameColumn(
                name: "QuocGia_MaM49",
                table: "DanhMuc_QuocGia",
                newName: "MaM49");

            migrationBuilder.RenameColumn(
                name: "QuanHuyen_TenKhac",
                table: "DanhMuc_QuanHuyen",
                newName: "TenKhac");

            migrationBuilder.RenameColumn(
                name: "QuanHuyen_Ten",
                table: "DanhMuc_QuanHuyen",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "QuanHuyen_MaBuuChinh",
                table: "DanhMuc_QuanHuyen",
                newName: "MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "QuanHuyen_MaHanhChinh",
                table: "DanhMuc_QuanHuyen",
                newName: "MaHanhChinh");

            migrationBuilder.RenameColumn(
                name: "NhomMauHeRH_Ten",
                table: "DanhMuc_NhomMauHeRH",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NhomMauHeRH_Ma",
                table: "DanhMuc_NhomMauHeRH",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "NhomMauHeABO_Ten",
                table: "DanhMuc_NhomMauHeABO",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NhomMauHeABO_Ma",
                table: "DanhMuc_NhomMauHeABO",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap5_Ten",
                table: "DanhMuc_NgheNghiepCap5",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap5_MoTa",
                table: "DanhMuc_NgheNghiepCap5",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap5_Ma",
                table: "DanhMuc_NgheNghiepCap5",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap4_Ten",
                table: "DanhMuc_NgheNghiepCap4",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap4_MoTa",
                table: "DanhMuc_NgheNghiepCap4",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap4_Ma",
                table: "DanhMuc_NgheNghiepCap4",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap3_Ten",
                table: "DanhMuc_NgheNghiepCap3",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap3_MoTa",
                table: "DanhMuc_NgheNghiepCap3",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap3_Ma",
                table: "DanhMuc_NgheNghiepCap3",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap2_Ten",
                table: "DanhMuc_NgheNghiepCap2",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap2_MoTa",
                table: "DanhMuc_NgheNghiepCap2",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap2_Ma",
                table: "DanhMuc_NgheNghiepCap2",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap1_Ten",
                table: "DanhMuc_NgheNghiepCap1",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap1_MoTa",
                table: "DanhMuc_NgheNghiepCap1",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "NgheNghiepCap1_Ma",
                table: "DanhMuc_NgheNghiepCap1",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanhCap2_Ten",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanhCap2_MoTa",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanhCap2_Ma",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanhCap1_Ten",
                table: "DanhMuc_KhuVucTinhThanhCap1",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanhCap1_Ma",
                table: "DanhMuc_KhuVucTinhThanhCap1",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "KhuVucQuocGia_TenTV",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "TenTV");

            migrationBuilder.RenameColumn(
                name: "KhuVucQuocGia_TenTA",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "TenTA");

            migrationBuilder.RenameColumn(
                name: "KhuVucQuocGia_MoTa",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "KhuVucQuocGia_MaM49",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "MaM49");

            migrationBuilder.RenameColumn(
                name: "DanToc_TenKhac",
                table: "DanhMuc_DanToc",
                newName: "TenKhac");

            migrationBuilder.RenameColumn(
                name: "DanToc_Ten",
                table: "DanhMuc_DanToc",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "DanToc_MoTa",
                table: "DanhMuc_DanToc",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "DanToc_Ma",
                table: "DanhMuc_DanToc",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "ChauLuc_TenTV",
                table: "DanhMuc_ChauLuc",
                newName: "TenTV");

            migrationBuilder.RenameColumn(
                name: "ChauLuc_TenTA",
                table: "DanhMuc_ChauLuc",
                newName: "TenTA");

            migrationBuilder.RenameColumn(
                name: "ChauLuc_MoTa",
                table: "DanhMuc_ChauLuc",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "ChauLuc_MaM49",
                table: "DanhMuc_ChauLuc",
                newName: "MaM49");

            migrationBuilder.RenameColumn(
                name: "CapXaPhuong_Ten",
                table: "DanhMuc_CapXaPhuong",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "CapXaPhuong_Ma",
                table: "DanhMuc_CapXaPhuong",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "CapTinhThanh_Ten",
                table: "DanhMuc_CapTinhThanh",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "CapTinhThanh_Ma",
                table: "DanhMuc_CapTinhThanh",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "CapQuanHuyen_Ten",
                table: "DanhMuc_CapQuanHuyen",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "CapQuanHuyen_Ma",
                table: "DanhMuc_CapQuanHuyen",
                newName: "Ma");

            migrationBuilder.RenameColumn(
                name: "CacToChucTonGiaoChinh_ID",
                table: "DanhMuc_CacToChucTonGiaoChinh",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "DanhMuc_TinhTrangHonNhan",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ten",
                table: "DanhMuc_CacToChucTonGiaoChinh",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMuc_TinhTrangHonNhan",
                table: "DanhMuc_TinhTrangHonNhan",
                column: "Ma");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    SoDinhDanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_GioiTinh",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_GioiTinh", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_QuanHe",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_QuanHe", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongDan",
                columns: table => new
                {
                    SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    SoChungMinhNhanDan = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ChuDem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NgayThangNamSinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NamSinh = table.Column<int>(type: "int", nullable: false),
                    GioiTinh_Ma = table.Column<int>(type: "int", nullable: false),
                    AspNetUser_ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    NgheNghiepCap5_Ma = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    GioiTinhMa = table.Column<int>(type: "int", nullable: true),
                    NgheNghiepCap5Ma = table.Column<string>(type: "nvarchar(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongDan", x => x.SoDinhDanh);
                    table.ForeignKey(
                        name: "FK_CongDan_AspNetUsers_AspNetUser_ID",
                        column: x => x.AspNetUser_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongDan_DanhMuc_GioiTinh_GioiTinhMa",
                        column: x => x.GioiTinhMa,
                        principalTable: "DanhMuc_GioiTinh",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongDan_DanhMuc_NgheNghiepCap5_NgheNghiepCap5Ma",
                        column: x => x.NgheNghiepCap5Ma,
                        principalTable: "DanhMuc_NgheNghiepCap5",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CongDan_AspNetUser_ID",
                table: "CongDan",
                column: "AspNetUser_ID",
                unique: true,
                filter: "[AspNetUser_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CongDan_GioiTinhMa",
                table: "CongDan",
                column: "GioiTinhMa");

            migrationBuilder.CreateIndex(
                name: "IX_CongDan_NgheNghiepCap5Ma",
                table: "CongDan",
                column: "NgheNghiepCap5Ma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CongDan");

            migrationBuilder.DropTable(
                name: "DanhMuc_QuanHe");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DanhMuc_GioiTinh");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMuc_TinhTrangHonNhan",
                table: "DanhMuc_TinhTrangHonNhan");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "DanhMuc_TinhTrangHonNhan");

            migrationBuilder.DropColumn(
                name: "Ten",
                table: "DanhMuc_CacToChucTonGiaoChinh");

            migrationBuilder.RenameColumn(
                name: "TenKhac",
                table: "DanhMuc_XaPhuong",
                newName: "XaPhuong_TenKhac");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_XaPhuong",
                newName: "XaPhuong_Ten");

            migrationBuilder.RenameColumn(
                name: "MaBuuChinh",
                table: "DanhMuc_XaPhuong",
                newName: "XaPhuong_MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "MaHanhChinh",
                table: "DanhMuc_XaPhuong",
                newName: "XaPhuong_MaHanhChinh");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_TonGiao",
                newName: "TonGiao_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_TonGiao",
                newName: "TonGiao_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_TinhTrangHonNhan",
                newName: "TinhTrangHonNhan_Ten");

            migrationBuilder.RenameColumn(
                name: "TuNgay",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_TuNgay");

            migrationBuilder.RenameColumn(
                name: "TenKhac",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_TenKhac");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_MoTa");

            migrationBuilder.RenameColumn(
                name: "MaVungDienThoai",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_MaVungDienThoai");

            migrationBuilder.RenameColumn(
                name: "MaBuuChinh",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "DenNgay",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_DenNgay");

            migrationBuilder.RenameColumn(
                name: "MaHanhChinh",
                table: "DanhMuc_TinhThanh",
                newName: "TinhThanh_MaHanhChinh");

            migrationBuilder.RenameColumn(
                name: "TenTV",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_TenTV");

            migrationBuilder.RenameColumn(
                name: "TenTA",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_TenTA");

            migrationBuilder.RenameColumn(
                name: "QuocTich",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_QuocTich");

            migrationBuilder.RenameColumn(
                name: "QuocKy",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_QuocKy");

            migrationBuilder.RenameColumn(
                name: "MuiGio",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_MuiGio");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_MoTa");

            migrationBuilder.RenameColumn(
                name: "MaBuuChinh",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "MaAlpha3",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_MaAlpha3");

            migrationBuilder.RenameColumn(
                name: "MaAlpha2",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_MaAlpha2");

            migrationBuilder.RenameColumn(
                name: "MaM49",
                table: "DanhMuc_QuocGia",
                newName: "QuocGia_MaM49");

            migrationBuilder.RenameColumn(
                name: "TenKhac",
                table: "DanhMuc_QuanHuyen",
                newName: "QuanHuyen_TenKhac");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_QuanHuyen",
                newName: "QuanHuyen_Ten");

            migrationBuilder.RenameColumn(
                name: "MaBuuChinh",
                table: "DanhMuc_QuanHuyen",
                newName: "QuanHuyen_MaBuuChinh");

            migrationBuilder.RenameColumn(
                name: "MaHanhChinh",
                table: "DanhMuc_QuanHuyen",
                newName: "QuanHuyen_MaHanhChinh");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NhomMauHeRH",
                newName: "NhomMauHeRH_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NhomMauHeRH",
                newName: "NhomMauHeRH_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NhomMauHeABO",
                newName: "NhomMauHeABO_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NhomMauHeABO",
                newName: "NhomMauHeABO_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NgheNghiepCap5",
                newName: "NgheNghiepCap5_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_NgheNghiepCap5",
                newName: "NgheNghiepCap5_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NgheNghiepCap5",
                newName: "NgheNghiepCap5_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NgheNghiepCap4",
                newName: "NgheNghiepCap4_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_NgheNghiepCap4",
                newName: "NgheNghiepCap4_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NgheNghiepCap4",
                newName: "NgheNghiepCap4_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NgheNghiepCap3",
                newName: "NgheNghiepCap3_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_NgheNghiepCap3",
                newName: "NgheNghiepCap3_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NgheNghiepCap3",
                newName: "NgheNghiepCap3_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NgheNghiepCap2",
                newName: "NgheNghiepCap2_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_NgheNghiepCap2",
                newName: "NgheNghiepCap2_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NgheNghiepCap2",
                newName: "NgheNghiepCap2_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_NgheNghiepCap1",
                newName: "NgheNghiepCap1_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_NgheNghiepCap1",
                newName: "NgheNghiepCap1_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_NgheNghiepCap1",
                newName: "NgheNghiepCap1_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                newName: "KhuVucTinhThanhCap2_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                newName: "KhuVucTinhThanhCap2_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                newName: "KhuVucTinhThanhCap2_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_KhuVucTinhThanhCap1",
                newName: "KhuVucTinhThanhCap1_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_KhuVucTinhThanhCap1",
                newName: "KhuVucTinhThanhCap1_Ma");

            migrationBuilder.RenameColumn(
                name: "TenTV",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "KhuVucQuocGia_TenTV");

            migrationBuilder.RenameColumn(
                name: "TenTA",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "KhuVucQuocGia_TenTA");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "KhuVucQuocGia_MoTa");

            migrationBuilder.RenameColumn(
                name: "MaM49",
                table: "DanhMuc_KhuVucQuocGia",
                newName: "KhuVucQuocGia_MaM49");

            migrationBuilder.RenameColumn(
                name: "TenKhac",
                table: "DanhMuc_DanToc",
                newName: "DanToc_TenKhac");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_DanToc",
                newName: "DanToc_Ten");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_DanToc",
                newName: "DanToc_MoTa");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_DanToc",
                newName: "DanToc_Ma");

            migrationBuilder.RenameColumn(
                name: "TenTV",
                table: "DanhMuc_ChauLuc",
                newName: "ChauLuc_TenTV");

            migrationBuilder.RenameColumn(
                name: "TenTA",
                table: "DanhMuc_ChauLuc",
                newName: "ChauLuc_TenTA");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "DanhMuc_ChauLuc",
                newName: "ChauLuc_MoTa");

            migrationBuilder.RenameColumn(
                name: "MaM49",
                table: "DanhMuc_ChauLuc",
                newName: "ChauLuc_MaM49");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_CapXaPhuong",
                newName: "CapXaPhuong_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_CapXaPhuong",
                newName: "CapXaPhuong_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_CapTinhThanh",
                newName: "CapTinhThanh_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_CapTinhThanh",
                newName: "CapTinhThanh_Ma");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc_CapQuanHuyen",
                newName: "CapQuanHuyen_Ten");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "DanhMuc_CapQuanHuyen",
                newName: "CapQuanHuyen_Ma");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "DanhMuc_CacToChucTonGiaoChinh",
                newName: "CacToChucTonGiaoChinh_ID");

            migrationBuilder.AddColumn<int>(
                name: "TinhTrangHonNhan_ID",
                table: "DanhMuc_TinhTrangHonNhan",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CacToChucTonGiaoChinh_Ten",
                table: "DanhMuc_CacToChucTonGiaoChinh",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMuc_TinhTrangHonNhan",
                table: "DanhMuc_TinhTrangHonNhan",
                column: "TinhTrangHonNhan_ID");
        }
    }
}
