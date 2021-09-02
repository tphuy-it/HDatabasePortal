using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HDatabasePortal.Data.Migrations
{
    public partial class DataInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc_CapQuanHuyen",
                columns: table => new
                {
                    CapQuanHuyen_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CapQuanHuyen_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_CapQuanHuyen", x => x.CapQuanHuyen_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_CapTinhThanh",
                columns: table => new
                {
                    CapTinhThanh_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CapTinhThanh_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_CapTinhThanh", x => x.CapTinhThanh_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_CapXaPhuong",
                columns: table => new
                {
                    CapXaPhuong_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CapXaPhuong_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_CapXaPhuong", x => x.CapXaPhuong_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_ChauLuc",
                columns: table => new
                {
                    ChauLuc_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ChauLuc_TenTA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChauLuc_TenTV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChauLuc_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_ChauLuc", x => x.ChauLuc_MaM49);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_DanToc",
                columns: table => new
                {
                    DanToc_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    DanToc_Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DanToc_TenKhac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DanToc_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_DanToc", x => x.DanToc_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NgheNghiepCap1",
                columns: table => new
                {
                    NgheNghiepCap1_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NgheNghiepCap1_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgheNghiepCap1_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NgheNghiepCap1", x => x.NgheNghiepCap1_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NhomMauHeABO",
                columns: table => new
                {
                    NhomMauHeABO_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NhomMauHeABO_Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NhomMauHeABO", x => x.NhomMauHeABO_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NhomMauHeRH",
                columns: table => new
                {
                    NhomMauHeRH_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NhomMauHeRH_Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NhomMauHeRH", x => x.NhomMauHeRH_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_TinhTrangHonNhan",
                columns: table => new
                {
                    TinhTrangHonNhan_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TinhTrangHonNhan_Ten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_TinhTrangHonNhan", x => x.TinhTrangHonNhan_ID);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_TonGiao",
                columns: table => new
                {
                    TonGiao_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TonGiao_Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_TonGiao", x => x.TonGiao_Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_KhuVucQuocGia",
                columns: table => new
                {
                    KhuVucQuocGia_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    KhuVucQuocGia_TenTA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KhuVucQuocGia_TenTV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KhuVucQuocGia_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ChauLuc_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_KhuVucQuocGia", x => x.KhuVucQuocGia_MaM49);
                    table.ForeignKey(
                        name: "FK_DanhMuc_KhuVucQuocGia_DanhMuc_ChauLuc_ChauLuc_MaM49",
                        column: x => x.ChauLuc_MaM49,
                        principalTable: "DanhMuc_ChauLuc",
                        principalColumn: "ChauLuc_MaM49",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NgheNghiepCap2",
                columns: table => new
                {
                    NgheNghiepCap2_Ma = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NgheNghiepCap2_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgheNghiepCap2_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgheNghiepCap1_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NgheNghiepCap2", x => x.NgheNghiepCap2_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_NgheNghiepCap2_DanhMuc_NgheNghiepCap1_NgheNghiepCap1_Ma",
                        column: x => x.NgheNghiepCap1_Ma,
                        principalTable: "DanhMuc_NgheNghiepCap1",
                        principalColumn: "NgheNghiepCap1_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_CacToChucTonGiaoChinh",
                columns: table => new
                {
                    CacToChucTonGiaoChinh_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CacToChucTonGiaoChinh_Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TonGiao_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_CacToChucTonGiaoChinh", x => x.CacToChucTonGiaoChinh_ID);
                    table.ForeignKey(
                        name: "FK_DanhMuc_CacToChucTonGiaoChinh_DanhMuc_TonGiao_TonGiao_Ma",
                        column: x => x.TonGiao_Ma,
                        principalTable: "DanhMuc_TonGiao",
                        principalColumn: "TonGiao_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_QuocGia",
                columns: table => new
                {
                    QuocGia_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    QuocGia_MaAlpha2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    QuocGia_MaAlpha3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    QuocGia_TenTA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuocGia_TenTV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuocGia_QuocTich = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuocGia_MaBuuChinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuocGia_QuocKy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuocGia_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    QuocGia_MuiGio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    KhuVucQuocGia_MaM49 = table.Column<string>(type: "nvarchar(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_QuocGia", x => x.QuocGia_MaM49);
                    table.ForeignKey(
                        name: "FK_DanhMuc_QuocGia_DanhMuc_KhuVucQuocGia_KhuVucQuocGia_MaM49",
                        column: x => x.KhuVucQuocGia_MaM49,
                        principalTable: "DanhMuc_KhuVucQuocGia",
                        principalColumn: "KhuVucQuocGia_MaM49",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NgheNghiepCap3",
                columns: table => new
                {
                    NgheNghiepCap3_Ma = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    NgheNghiepCap3_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgheNghiepCap3_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgheNghiepCap2_Ma = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NgheNghiepCap3", x => x.NgheNghiepCap3_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_NgheNghiepCap3_DanhMuc_NgheNghiepCap2_NgheNghiepCap2_Ma",
                        column: x => x.NgheNghiepCap2_Ma,
                        principalTable: "DanhMuc_NgheNghiepCap2",
                        principalColumn: "NgheNghiepCap2_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_KhuVucTinhThanh",
                columns: table => new
                {
                    KhuVucTinhThanh_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    KhuVucTinhThanh_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KhuVucTinhThanh_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    QuocGia_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_KhuVucTinhThanh", x => x.KhuVucTinhThanh_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_KhuVucTinhThanh_DanhMuc_QuocGia_QuocGia_MaM49",
                        column: x => x.QuocGia_MaM49,
                        principalTable: "DanhMuc_QuocGia",
                        principalColumn: "QuocGia_MaM49",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NgheNghiepCap4",
                columns: table => new
                {
                    NgheNghiepCap4_Ma = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NgheNghiepCap4_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgheNghiepCap4_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgheNghiepCap3_Ma = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NgheNghiepCap4", x => x.NgheNghiepCap4_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_NgheNghiepCap4_DanhMuc_NgheNghiepCap3_NgheNghiepCap3_Ma",
                        column: x => x.NgheNghiepCap3_Ma,
                        principalTable: "DanhMuc_NgheNghiepCap3",
                        principalColumn: "NgheNghiepCap3_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucTinhThanh",
                columns: table => new
                {
                    TinhThanh_MaHanhChinh = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    TinhThanh_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TinhThanh_MaBuuChinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TinhThanh_TenKhac = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TinhThanh_TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhThanh_DenNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhThanh_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    KhuVucTinhThanh_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CapTinhThanh_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucTinhThanh", x => x.TinhThanh_MaHanhChinh);
                    table.ForeignKey(
                        name: "FK_DanhMucTinhThanh_DanhMuc_CapTinhThanh_CapTinhThanh_Ma",
                        column: x => x.CapTinhThanh_Ma,
                        principalTable: "DanhMuc_CapTinhThanh",
                        principalColumn: "CapTinhThanh_Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhMucTinhThanh_DanhMuc_KhuVucTinhThanh_KhuVucTinhThanh_Ma",
                        column: x => x.KhuVucTinhThanh_Ma,
                        principalTable: "DanhMuc_KhuVucTinhThanh",
                        principalColumn: "KhuVucTinhThanh_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_NgheNghiepCap5",
                columns: table => new
                {
                    NgheNghiepCap5_Ma = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    NgheNghiepCap5_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgheNghiepCap5_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgheNghiepCap4_Ma = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_NgheNghiepCap5", x => x.NgheNghiepCap5_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_NgheNghiepCap5_DanhMuc_NgheNghiepCap4_NgheNghiepCap4_Ma",
                        column: x => x.NgheNghiepCap4_Ma,
                        principalTable: "DanhMuc_NgheNghiepCap4",
                        principalColumn: "NgheNghiepCap4_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_QuanHuyen",
                columns: table => new
                {
                    QuanHuyen_MaHanhChinh = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    QuanHuyen_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuanHuyen_TenKhac = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuanHuyen_MaBuuChinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TinhThanh_MaHanhChinh = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CapQuanHuyen_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_QuanHuyen", x => x.QuanHuyen_MaHanhChinh);
                    table.ForeignKey(
                        name: "FK_DanhMuc_QuanHuyen_DanhMuc_CapQuanHuyen_CapQuanHuyen_Ma",
                        column: x => x.CapQuanHuyen_Ma,
                        principalTable: "DanhMuc_CapQuanHuyen",
                        principalColumn: "CapQuanHuyen_Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhMuc_QuanHuyen_DanhMucTinhThanh_TinhThanh_MaHanhChinh",
                        column: x => x.TinhThanh_MaHanhChinh,
                        principalTable: "DanhMucTinhThanh",
                        principalColumn: "TinhThanh_MaHanhChinh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_XaPhuong",
                columns: table => new
                {
                    XaPhuong_MaHanhChinh = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    XaPhuong_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    XaPhuong_MaBuuChinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    XaPhuong_TenKhac = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CapXaPhuong_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    QuanHuyen_MaHanhChinh = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_XaPhuong", x => x.XaPhuong_MaHanhChinh);
                    table.ForeignKey(
                        name: "FK_DanhMuc_XaPhuong_DanhMuc_CapXaPhuong_CapXaPhuong_Ma",
                        column: x => x.CapXaPhuong_Ma,
                        principalTable: "DanhMuc_CapXaPhuong",
                        principalColumn: "CapXaPhuong_Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhMuc_XaPhuong_DanhMuc_QuanHuyen_QuanHuyen_MaHanhChinh",
                        column: x => x.QuanHuyen_MaHanhChinh,
                        principalTable: "DanhMuc_QuanHuyen",
                        principalColumn: "QuanHuyen_MaHanhChinh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_CacToChucTonGiaoChinh_TonGiao_Ma",
                table: "DanhMuc_CacToChucTonGiaoChinh",
                column: "TonGiao_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_KhuVucQuocGia_ChauLuc_MaM49",
                table: "DanhMuc_KhuVucQuocGia",
                column: "ChauLuc_MaM49");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_KhuVucTinhThanh_QuocGia_MaM49",
                table: "DanhMuc_KhuVucTinhThanh",
                column: "QuocGia_MaM49");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_NgheNghiepCap2_NgheNghiepCap1_Ma",
                table: "DanhMuc_NgheNghiepCap2",
                column: "NgheNghiepCap1_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_NgheNghiepCap3_NgheNghiepCap2_Ma",
                table: "DanhMuc_NgheNghiepCap3",
                column: "NgheNghiepCap2_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_NgheNghiepCap4_NgheNghiepCap3_Ma",
                table: "DanhMuc_NgheNghiepCap4",
                column: "NgheNghiepCap3_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_NgheNghiepCap5_NgheNghiepCap4_Ma",
                table: "DanhMuc_NgheNghiepCap5",
                column: "NgheNghiepCap4_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_QuanHuyen_CapQuanHuyen_Ma",
                table: "DanhMuc_QuanHuyen",
                column: "CapQuanHuyen_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_QuanHuyen_TinhThanh_MaHanhChinh",
                table: "DanhMuc_QuanHuyen",
                column: "TinhThanh_MaHanhChinh");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_QuocGia_KhuVucQuocGia_MaM49",
                table: "DanhMuc_QuocGia",
                column: "KhuVucQuocGia_MaM49");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_XaPhuong_CapXaPhuong_Ma",
                table: "DanhMuc_XaPhuong",
                column: "CapXaPhuong_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_XaPhuong_QuanHuyen_MaHanhChinh",
                table: "DanhMuc_XaPhuong",
                column: "QuanHuyen_MaHanhChinh");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucTinhThanh_CapTinhThanh_Ma",
                table: "DanhMucTinhThanh",
                column: "CapTinhThanh_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucTinhThanh_KhuVucTinhThanh_Ma",
                table: "DanhMucTinhThanh",
                column: "KhuVucTinhThanh_Ma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhMuc_CacToChucTonGiaoChinh");

            migrationBuilder.DropTable(
                name: "DanhMuc_DanToc");

            migrationBuilder.DropTable(
                name: "DanhMuc_NgheNghiepCap5");

            migrationBuilder.DropTable(
                name: "DanhMuc_NhomMauHeABO");

            migrationBuilder.DropTable(
                name: "DanhMuc_NhomMauHeRH");

            migrationBuilder.DropTable(
                name: "DanhMuc_TinhTrangHonNhan");

            migrationBuilder.DropTable(
                name: "DanhMuc_XaPhuong");

            migrationBuilder.DropTable(
                name: "DanhMuc_TonGiao");

            migrationBuilder.DropTable(
                name: "DanhMuc_NgheNghiepCap4");

            migrationBuilder.DropTable(
                name: "DanhMuc_CapXaPhuong");

            migrationBuilder.DropTable(
                name: "DanhMuc_QuanHuyen");

            migrationBuilder.DropTable(
                name: "DanhMuc_NgheNghiepCap3");

            migrationBuilder.DropTable(
                name: "DanhMuc_CapQuanHuyen");

            migrationBuilder.DropTable(
                name: "DanhMucTinhThanh");

            migrationBuilder.DropTable(
                name: "DanhMuc_NgheNghiepCap2");

            migrationBuilder.DropTable(
                name: "DanhMuc_CapTinhThanh");

            migrationBuilder.DropTable(
                name: "DanhMuc_KhuVucTinhThanh");

            migrationBuilder.DropTable(
                name: "DanhMuc_NgheNghiepCap1");

            migrationBuilder.DropTable(
                name: "DanhMuc_QuocGia");

            migrationBuilder.DropTable(
                name: "DanhMuc_KhuVucQuocGia");

            migrationBuilder.DropTable(
                name: "DanhMuc_ChauLuc");
        }
    }
}
