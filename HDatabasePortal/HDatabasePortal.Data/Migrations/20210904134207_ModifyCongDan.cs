using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HDatabasePortal.Data.Migrations
{
    public partial class ModifyCongDan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CongDan_DanhMuc_NgheNghiepCap5_NgheNghiepCap5Ma",
                table: "CongDan");

            migrationBuilder.DropIndex(
                name: "IX_CongDan_NgheNghiepCap5Ma",
                table: "CongDan");

            migrationBuilder.DropColumn(
                name: "NgheNghiepCap5Ma",
                table: "CongDan");

            migrationBuilder.DropColumn(
                name: "NgheNghiepCap5_Ma",
                table: "CongDan");

            migrationBuilder.AlterColumn<string>(
                name: "TenKhac",
                table: "DanhMuc_DanToc",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ChuHo",
                table: "CongDan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DanTocMa",
                table: "CongDan",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DanToc_Ma",
                table: "CongDan",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoDinhDanh",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DanhMuc_LoaiDiaChi",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_LoaiDiaChi", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_LoaiTrangThai",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_LoaiTrangThai", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "NgheNghiep_CongDan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NgheNghiepCap5_Ma = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HienTai = table.Column<bool>(type: "bit", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgheNghiep_CongDan", x => new { x.CongDan_SoDinhDanh, x.NgheNghiepCap5_Ma });
                    table.ForeignKey(
                        name: "FK_NgheNghiep_CongDan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NgheNghiep_CongDan_DanhMuc_NgheNghiepCap5_NgheNghiepCap5_Ma",
                        column: x => x.NgheNghiepCap5_Ma,
                        principalTable: "DanhMuc_NgheNghiepCap5",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiThan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    QuanHe_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    SoChungMinhNhanDan = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ChuDem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ChungHo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiThan", x => new { x.CongDan_SoDinhDanh, x.QuanHe_Ma });
                    table.ForeignKey(
                        name: "FK_NguoiThan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NguoiThan_DanhMuc_QuanHe_QuanHe_Ma",
                        column: x => x.QuanHe_Ma,
                        principalTable: "DanhMuc_QuanHe",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuocTich_CongDan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    QuocGia_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HienTai = table.Column<bool>(type: "bit", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuocTich_CongDan", x => new { x.CongDan_SoDinhDanh, x.QuocGia_MaM49 });
                    table.ForeignKey(
                        name: "FK_QuocTich_CongDan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuocTich_CongDan_DanhMuc_QuocGia_QuocGia_MaM49",
                        column: x => x.QuocGia_MaM49,
                        principalTable: "DanhMuc_QuocGia",
                        principalColumn: "MaM49",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TinhTrangHonNhan_CongDan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TinhTrangHonNhan_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HienTai = table.Column<bool>(type: "bit", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrangHonNhan_CongDan", x => new { x.CongDan_SoDinhDanh, x.TinhTrangHonNhan_Ma });
                    table.ForeignKey(
                        name: "FK_TinhTrangHonNhan_CongDan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TinhTrangHonNhan_CongDan_DanhMuc_TinhTrangHonNhan_TinhTrangHonNhan_Ma",
                        column: x => x.TinhTrangHonNhan_Ma,
                        principalTable: "DanhMuc_TinhTrangHonNhan",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TonGiao_CongDan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CacToChucTonGiaoChinh_ID = table.Column<int>(type: "int", nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HienTai = table.Column<bool>(type: "bit", nullable: false),
                    CoChucVu = table.Column<bool>(type: "bit", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonGiao_CongDan", x => new { x.CongDan_SoDinhDanh, x.CacToChucTonGiaoChinh_ID });
                    table.ForeignKey(
                        name: "FK_TonGiao_CongDan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TonGiao_CongDan_DanhMuc_CacToChucTonGiaoChinh_CacToChucTonGiaoChinh_ID",
                        column: x => x.CacToChucTonGiaoChinh_ID,
                        principalTable: "DanhMuc_CacToChucTonGiaoChinh",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaChi_CongDan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    XaPhuong_MaHanhChinh = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    LoaiDiaChi_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HienTai = table.Column<bool>(type: "bit", nullable: false),
                    SoNhaTenDuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DayDu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChi_CongDan", x => new { x.CongDan_SoDinhDanh, x.XaPhuong_MaHanhChinh, x.LoaiDiaChi_Ma });
                    table.ForeignKey(
                        name: "FK_DiaChi_CongDan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaChi_CongDan_DanhMuc_LoaiDiaChi_LoaiDiaChi_Ma",
                        column: x => x.LoaiDiaChi_Ma,
                        principalTable: "DanhMuc_LoaiDiaChi",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaChi_CongDan_DanhMuc_XaPhuong_XaPhuong_MaHanhChinh",
                        column: x => x.XaPhuong_MaHanhChinh,
                        principalTable: "DanhMuc_XaPhuong",
                        principalColumn: "MaHanhChinh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTrangThai_CongDan",
                columns: table => new
                {
                    CongDan_SoDinhDanh = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LoaiTrangThai_Ma = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HienTai = table.Column<bool>(type: "bit", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTrangThai_CongDan", x => new { x.CongDan_SoDinhDanh, x.LoaiTrangThai_Ma });
                    table.ForeignKey(
                        name: "FK_LoaiTrangThai_CongDan_CongDan_CongDan_SoDinhDanh",
                        column: x => x.CongDan_SoDinhDanh,
                        principalTable: "CongDan",
                        principalColumn: "SoDinhDanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoaiTrangThai_CongDan_DanhMuc_LoaiTrangThai_LoaiTrangThai_Ma",
                        column: x => x.LoaiTrangThai_Ma,
                        principalTable: "DanhMuc_LoaiTrangThai",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CongDan_DanTocMa",
                table: "CongDan",
                column: "DanTocMa");

            migrationBuilder.CreateIndex(
                name: "IX_DiaChi_CongDan_LoaiDiaChi_Ma",
                table: "DiaChi_CongDan",
                column: "LoaiDiaChi_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_DiaChi_CongDan_XaPhuong_MaHanhChinh",
                table: "DiaChi_CongDan",
                column: "XaPhuong_MaHanhChinh");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiTrangThai_CongDan_LoaiTrangThai_Ma",
                table: "LoaiTrangThai_CongDan",
                column: "LoaiTrangThai_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_NgheNghiep_CongDan_NgheNghiepCap5_Ma",
                table: "NgheNghiep_CongDan",
                column: "NgheNghiepCap5_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiThan_QuanHe_Ma",
                table: "NguoiThan",
                column: "QuanHe_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_QuocTich_CongDan_QuocGia_MaM49",
                table: "QuocTich_CongDan",
                column: "QuocGia_MaM49");

            migrationBuilder.CreateIndex(
                name: "IX_TinhTrangHonNhan_CongDan_TinhTrangHonNhan_Ma",
                table: "TinhTrangHonNhan_CongDan",
                column: "TinhTrangHonNhan_Ma");

            migrationBuilder.CreateIndex(
                name: "IX_TonGiao_CongDan_CacToChucTonGiaoChinh_ID",
                table: "TonGiao_CongDan",
                column: "CacToChucTonGiaoChinh_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CongDan_DanhMuc_DanToc_DanTocMa",
                table: "CongDan",
                column: "DanTocMa",
                principalTable: "DanhMuc_DanToc",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CongDan_DanhMuc_DanToc_DanTocMa",
                table: "CongDan");

            migrationBuilder.DropTable(
                name: "DiaChi_CongDan");

            migrationBuilder.DropTable(
                name: "LoaiTrangThai_CongDan");

            migrationBuilder.DropTable(
                name: "NgheNghiep_CongDan");

            migrationBuilder.DropTable(
                name: "NguoiThan");

            migrationBuilder.DropTable(
                name: "QuocTich_CongDan");

            migrationBuilder.DropTable(
                name: "TinhTrangHonNhan_CongDan");

            migrationBuilder.DropTable(
                name: "TonGiao_CongDan");

            migrationBuilder.DropTable(
                name: "DanhMuc_LoaiDiaChi");

            migrationBuilder.DropTable(
                name: "DanhMuc_LoaiTrangThai");

            migrationBuilder.DropIndex(
                name: "IX_CongDan_DanTocMa",
                table: "CongDan");

            migrationBuilder.DropColumn(
                name: "ChuHo",
                table: "CongDan");

            migrationBuilder.DropColumn(
                name: "DanTocMa",
                table: "CongDan");

            migrationBuilder.DropColumn(
                name: "DanToc_Ma",
                table: "CongDan");

            migrationBuilder.AlterColumn<string>(
                name: "TenKhac",
                table: "DanhMuc_DanToc",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NgheNghiepCap5Ma",
                table: "CongDan",
                type: "nvarchar(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NgheNghiepCap5_Ma",
                table: "CongDan",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoDinhDanh",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CongDan_NgheNghiepCap5Ma",
                table: "CongDan",
                column: "NgheNghiepCap5Ma");

            migrationBuilder.AddForeignKey(
                name: "FK_CongDan_DanhMuc_NgheNghiepCap5_NgheNghiepCap5Ma",
                table: "CongDan",
                column: "NgheNghiepCap5Ma",
                principalTable: "DanhMuc_NgheNghiepCap5",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
