using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationApi_v1._0.Migrations
{
    public partial class AddMentor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MentorID",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Salary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MentorID",
                table: "Users",
                column: "MentorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Mentors_MentorID",
                table: "Users",
                column: "MentorID",
                principalTable: "Mentors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Mentors_MentorID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropIndex(
                name: "IX_Users_MentorID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MentorID",
                table: "Users");
        }
    }
}
