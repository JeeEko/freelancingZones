using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationApi_v1._0.Migrations
{
    public partial class MakeRelationBetweenUserAndFreelancer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "Freelancers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_User_Id",
                table: "Freelancers",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Users_User_Id",
                table: "Freelancers",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Users_User_Id",
                table: "Freelancers");

            migrationBuilder.DropIndex(
                name: "IX_Freelancers_User_Id",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Freelancers");
        }
    }
}
