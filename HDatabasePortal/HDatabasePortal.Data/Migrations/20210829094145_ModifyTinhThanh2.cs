using Microsoft.EntityFrameworkCore.Migrations;

namespace HDatabasePortal.Data.Migrations
{
    public partial class ModifyTinhThanh2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhMuc_QuanHuyen_DanhMucTinhThanh_TinhThanh_MaHanhChinh",
                table: "DanhMuc_QuanHuyen");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucTinhThanh_DanhMuc_CapTinhThanh_CapTinhThanh_Ma",
                table: "DanhMucTinhThanh");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucTinhThanh_DanhMuc_KhuVucTinhThanh_KhuVucTinhThanh_Ma",
                table: "DanhMucTinhThanh");

            migrationBuilder.DropTable(
                name: "DanhMuc_KhuVucTinhThanh");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucTinhThanh",
                table: "DanhMucTinhThanh");

            migrationBuilder.RenameTable(
                name: "DanhMucTinhThanh",
                newName: "DanhMuc_TinhThanh");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanh_Ma",
                table: "DanhMuc_TinhThanh",
                newName: "KhuVucTinhThanhCap2_Ma");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMucTinhThanh_KhuVucTinhThanh_Ma",
                table: "DanhMuc_TinhThanh",
                newName: "IX_DanhMuc_TinhThanh_KhuVucTinhThanhCap2_Ma");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMucTinhThanh_CapTinhThanh_Ma",
                table: "DanhMuc_TinhThanh",
                newName: "IX_DanhMuc_TinhThanh_CapTinhThanh_Ma");

            migrationBuilder.AlterColumn<string>(
                name: "QuocGia_MuiGio",
                table: "DanhMuc_QuocGia",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMuc_TinhThanh",
                table: "DanhMuc_TinhThanh",
                column: "TinhThanh_MaHanhChinh");

            migrationBuilder.CreateTable(
                name: "DanhMuc_KhuVucTinhThanhCap1",
                columns: table => new
                {
                    KhuVucTinhThanhCap1_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    KhuVucTinhThanhCap1_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuocGia_MaM49 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_KhuVucTinhThanhCap1", x => x.KhuVucTinhThanhCap1_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_KhuVucTinhThanhCap1_DanhMuc_QuocGia_QuocGia_MaM49",
                        column: x => x.QuocGia_MaM49,
                        principalTable: "DanhMuc_QuocGia",
                        principalColumn: "QuocGia_MaM49",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc_KhuVucTinhThanhCap2",
                columns: table => new
                {
                    KhuVucTinhThanhCap2_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    KhuVucTinhThanhCap2_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KhuVucTinhThanhCap2_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    KhuVucTinhThanhCap1_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc_KhuVucTinhThanhCap2", x => x.KhuVucTinhThanhCap2_Ma);
                    table.ForeignKey(
                        name: "FK_DanhMuc_KhuVucTinhThanhCap2_DanhMuc_KhuVucTinhThanhCap1_KhuVucTinhThanhCap1_Ma",
                        column: x => x.KhuVucTinhThanhCap1_Ma,
                        principalTable: "DanhMuc_KhuVucTinhThanhCap1",
                        principalColumn: "KhuVucTinhThanhCap1_Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_KhuVucTinhThanhCap1_QuocGia_MaM49",
                table: "DanhMuc_KhuVucTinhThanhCap1",
                column: "QuocGia_MaM49");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_KhuVucTinhThanhCap2_KhuVucTinhThanhCap1_Ma",
                table: "DanhMuc_KhuVucTinhThanhCap2",
                column: "KhuVucTinhThanhCap1_Ma");

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMuc_QuanHuyen_DanhMuc_TinhThanh_TinhThanh_MaHanhChinh",
                table: "DanhMuc_QuanHuyen",
                column: "TinhThanh_MaHanhChinh",
                principalTable: "DanhMuc_TinhThanh",
                principalColumn: "TinhThanh_MaHanhChinh",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMuc_TinhThanh_DanhMuc_CapTinhThanh_CapTinhThanh_Ma",
                table: "DanhMuc_TinhThanh",
                column: "CapTinhThanh_Ma",
                principalTable: "DanhMuc_CapTinhThanh",
                principalColumn: "CapTinhThanh_Ma",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMuc_TinhThanh_DanhMuc_KhuVucTinhThanhCap2_KhuVucTinhThanhCap2_Ma",
                table: "DanhMuc_TinhThanh",
                column: "KhuVucTinhThanhCap2_Ma",
                principalTable: "DanhMuc_KhuVucTinhThanhCap2",
                principalColumn: "KhuVucTinhThanhCap2_Ma",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhMuc_QuanHuyen_DanhMuc_TinhThanh_TinhThanh_MaHanhChinh",
                table: "DanhMuc_QuanHuyen");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMuc_TinhThanh_DanhMuc_CapTinhThanh_CapTinhThanh_Ma",
                table: "DanhMuc_TinhThanh");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMuc_TinhThanh_DanhMuc_KhuVucTinhThanhCap2_KhuVucTinhThanhCap2_Ma",
                table: "DanhMuc_TinhThanh");

            migrationBuilder.DropTable(
                name: "DanhMuc_KhuVucTinhThanhCap2");

            migrationBuilder.DropTable(
                name: "DanhMuc_KhuVucTinhThanhCap1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMuc_TinhThanh",
                table: "DanhMuc_TinhThanh");

            migrationBuilder.RenameTable(
                name: "DanhMuc_TinhThanh",
                newName: "DanhMucTinhThanh");

            migrationBuilder.RenameColumn(
                name: "KhuVucTinhThanhCap2_Ma",
                table: "DanhMucTinhThanh",
                newName: "KhuVucTinhThanh_Ma");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMuc_TinhThanh_KhuVucTinhThanhCap2_Ma",
                table: "DanhMucTinhThanh",
                newName: "IX_DanhMucTinhThanh_KhuVucTinhThanh_Ma");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMuc_TinhThanh_CapTinhThanh_Ma",
                table: "DanhMucTinhThanh",
                newName: "IX_DanhMucTinhThanh_CapTinhThanh_Ma");

            migrationBuilder.AlterColumn<string>(
                name: "QuocGia_MuiGio",
                table: "DanhMuc_QuocGia",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucTinhThanh",
                table: "DanhMucTinhThanh",
                column: "TinhThanh_MaHanhChinh");

            migrationBuilder.CreateTable(
                name: "DanhMuc_KhuVucTinhThanh",
                columns: table => new
                {
                    KhuVucTinhThanh_Ma = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    KhuVucTinhThanh_MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    KhuVucTinhThanh_Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_KhuVucTinhThanh_QuocGia_MaM49",
                table: "DanhMuc_KhuVucTinhThanh",
                column: "QuocGia_MaM49");

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMuc_QuanHuyen_DanhMucTinhThanh_TinhThanh_MaHanhChinh",
                table: "DanhMuc_QuanHuyen",
                column: "TinhThanh_MaHanhChinh",
                principalTable: "DanhMucTinhThanh",
                principalColumn: "TinhThanh_MaHanhChinh",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucTinhThanh_DanhMuc_CapTinhThanh_CapTinhThanh_Ma",
                table: "DanhMucTinhThanh",
                column: "CapTinhThanh_Ma",
                principalTable: "DanhMuc_CapTinhThanh",
                principalColumn: "CapTinhThanh_Ma",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucTinhThanh_DanhMuc_KhuVucTinhThanh_KhuVucTinhThanh_Ma",
                table: "DanhMucTinhThanh",
                column: "KhuVucTinhThanh_Ma",
                principalTable: "DanhMuc_KhuVucTinhThanh",
                principalColumn: "KhuVucTinhThanh_Ma",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
