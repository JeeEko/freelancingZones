using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationApi_v1._0.Migrations
{
    public partial class AddAdditionalAttributePlus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Zones",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Zones");
        }
    }
}
