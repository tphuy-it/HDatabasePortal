using Microsoft.EntityFrameworkCore.Migrations;

namespace HDatabasePortal.Data.Migrations
{
    public partial class ModifyTinhThanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TinhThanh_MaVungDienThoai",
                table: "DanhMucTinhThanh",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TinhThanh_MaVungDienThoai",
                table: "DanhMucTinhThanh");
        }
    }
}
