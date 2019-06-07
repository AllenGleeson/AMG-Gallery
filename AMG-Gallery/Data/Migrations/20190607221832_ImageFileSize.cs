using Microsoft.EntityFrameworkCore.Migrations;

namespace AMG_Gallery.Data.Migrations
{
    public partial class ImageFileSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Size",
                table: "Image",
                nullable: false,
                oldClrType: typeof(byte));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Size",
                table: "Image",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
