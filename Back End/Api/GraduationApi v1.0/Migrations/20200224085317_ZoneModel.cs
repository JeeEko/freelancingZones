using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationApi_v1._0.Migrations
{
    public partial class ZoneModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interns_Zone_Zone_Id",
                table: "Interns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zone",
                table: "Zone");

            migrationBuilder.RenameTable(
                name: "Zone",
                newName: "Zones");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Zones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Zones",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zones",
                table: "Zones",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Interns_Zones_Zone_Id",
                table: "Interns",
                column: "Zone_Id",
                principalTable: "Zones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interns_Zones_Zone_Id",
                table: "Interns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zones",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Zones");

            migrationBuilder.RenameTable(
                name: "Zones",
                newName: "Zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zone",
                table: "Zone",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Interns_Zone_Zone_Id",
                table: "Interns",
                column: "Zone_Id",
                principalTable: "Zone",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
