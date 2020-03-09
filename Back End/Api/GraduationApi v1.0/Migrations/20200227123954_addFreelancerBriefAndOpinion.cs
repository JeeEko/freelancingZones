using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationApi_v1._0.Migrations
{
    public partial class addFreelancerBriefAndOpinion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brief",
                table: "Freelancers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Freelancers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opinion",
                table: "Freelancers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brief",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Opinion",
                table: "Freelancers");
        }
    }
}
