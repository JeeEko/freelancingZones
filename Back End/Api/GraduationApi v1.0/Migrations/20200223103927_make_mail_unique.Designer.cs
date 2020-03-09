﻿// <auto-generated />
using System;
using GraduationApi_v1._0.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraduationApi_v1._0.Migrations
{
    [DbContext(typeof(FreeLanceZoneDbContext))]
    [Migration("20200223103927_make_mail_unique")]
    partial class make_mail_unique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraduationApi_v1._0.Model.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerBody");

                    b.Property<int>("Intern_Id");

                    b.Property<int>("Question_Id");

                    b.HasKey("ID");

                    b.HasIndex("Intern_Id");

                    b.HasIndex("Question_Id");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Branch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Faculty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("UniversityID");

                    b.HasKey("ID");

                    b.HasIndex("UniversityID");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.ITIProgram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("ITIProgram");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Intake", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Intake");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Intern", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Branch_Id");

                    b.Property<int>("Faculty_Id");

                    b.Property<string>("Fname");

                    b.Property<int>("GraduationYear");

                    b.Property<int>("ITIProgram_Id");

                    b.Property<bool>("ITI_Trainee");

                    b.Property<int>("Intake_Id");

                    b.Property<string>("Lname");

                    b.Property<double>("Rate");

                    b.Property<int>("Track_Id");

                    b.Property<int>("University_Id");

                    b.Property<int>("User_Id");

                    b.Property<int>("Zone_Id");

                    b.HasKey("ID");

                    b.HasIndex("Branch_Id");

                    b.HasIndex("Faculty_Id");

                    b.HasIndex("ITIProgram_Id");

                    b.HasIndex("Intake_Id");

                    b.HasIndex("Track_Id");

                    b.HasIndex("University_Id");

                    b.HasIndex("User_Id");

                    b.HasIndex("Zone_Id");

                    b.ToTable("Interns");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionBody");

                    b.HasKey("ID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.University", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("University");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Role_id");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Role_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Zone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ID");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Answer", b =>
                {
                    b.HasOne("GraduationApi_v1._0.Model.Intern", "Intern")
                        .WithMany("Answers")
                        .HasForeignKey("Intern_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.Question", "Question")
                        .WithMany()
                        .HasForeignKey("Question_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Faculty", b =>
                {
                    b.HasOne("GraduationApi_v1._0.Model.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityID");
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.Intern", b =>
                {
                    b.HasOne("GraduationApi_v1._0.Model.Branch", "Branch")
                        .WithMany("Interns")
                        .HasForeignKey("Branch_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.Faculty", "Faculty")
                        .WithMany("Interns")
                        .HasForeignKey("Faculty_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.ITIProgram", "ITIProgram")
                        .WithMany("Interns")
                        .HasForeignKey("ITIProgram_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.Intake", "Intake")
                        .WithMany("Interns")
                        .HasForeignKey("Intake_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.Track", "Track")
                        .WithMany("Interns")
                        .HasForeignKey("Track_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.University", "University")
                        .WithMany()
                        .HasForeignKey("University_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GraduationApi_v1._0.Model.Zone", "Zone")
                        .WithMany()
                        .HasForeignKey("Zone_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GraduationApi_v1._0.Model.User", b =>
                {
                    b.HasOne("GraduationApi_v1._0.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
