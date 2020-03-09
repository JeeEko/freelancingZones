using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationApi_v1._0.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Intake",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intake", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ITIProgram",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITIProgram", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionBody = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Role_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_Role_id",
                        column: x => x.Role_id,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UniversityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Faculty_University_UniversityID",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    GraduationYear = table.Column<int>(nullable: false),
                    ITI_Trainee = table.Column<bool>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    Faculty_Id = table.Column<int>(nullable: false),
                    University_Id = table.Column<int>(nullable: false),
                    Zone_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    ITIProgram_Id = table.Column<int>(nullable: false),
                    Intake_Id = table.Column<int>(nullable: false),
                    Track_Id = table.Column<int>(nullable: false),
                    Branch_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Interns_Branch_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Branch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_Faculty_Faculty_Id",
                        column: x => x.Faculty_Id,
                        principalTable: "Faculty",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_ITIProgram_ITIProgram_Id",
                        column: x => x.ITIProgram_Id,
                        principalTable: "ITIProgram",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_Intake_Intake_Id",
                        column: x => x.Intake_Id,
                        principalTable: "Intake",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_Track_Track_Id",
                        column: x => x.Track_Id,
                        principalTable: "Track",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_University_University_Id",
                        column: x => x.University_Id,
                        principalTable: "University",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interns_Zone_Zone_Id",
                        column: x => x.Zone_Id,
                        principalTable: "Zone",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerBody = table.Column<string>(nullable: true),
                    Question_Id = table.Column<int>(nullable: false),
                    Intern_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Answer_Interns_Intern_Id",
                        column: x => x.Intern_Id,
                        principalTable: "Interns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answer_Question_Question_Id",
                        column: x => x.Question_Id,
                        principalTable: "Question",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Intern_Id",
                table: "Answer",
                column: "Intern_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Question_Id",
                table: "Answer",
                column: "Question_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_UniversityID",
                table: "Faculty",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_Branch_Id",
                table: "Interns",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_Faculty_Id",
                table: "Interns",
                column: "Faculty_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_ITIProgram_Id",
                table: "Interns",
                column: "ITIProgram_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_Intake_Id",
                table: "Interns",
                column: "Intake_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_Track_Id",
                table: "Interns",
                column: "Track_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_University_Id",
                table: "Interns",
                column: "University_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_User_Id",
                table: "Interns",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_Zone_Id",
                table: "Interns",
                column: "Zone_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_id",
                table: "Users",
                column: "Role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Interns");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "ITIProgram");

            migrationBuilder.DropTable(
                name: "Intake");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
