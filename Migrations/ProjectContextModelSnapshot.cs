﻿// <auto-generated />
using AngularAppApi.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularAppApi.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AngularAppApi.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            DateOfBirth = "12-2-3",
                            Position = "PS",
                            firstName = "Tauqeer",
                            lastName = "Ahmad",
                            phoneNo = "99268661"
                        });
                });

            modelBuilder.Entity("AngularAppApi.Models.Project_Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("project_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.HasIndex("project_Id");

                    b.ToTable("Projects_Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Employee_id = 4,
                            project_Id = 2
                        },
                        new
                        {
                            Id = 2,
                            Employee_id = 4,
                            project_Id = 3
                        });
                });

            modelBuilder.Entity("AngularAppApi.Models.Projects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClintName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitiationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClintName = "Test Clint",
                            InitiationDate = "12-02-03",
                            ProjectName = "My Assignment",
                            duration = " 01-01-2022"
                        },
                        new
                        {
                            Id = 2,
                            ClintName = "Test Clint2",
                            InitiationDate = "12-02-03",
                            ProjectName = "My Assignment2",
                            duration = " 02-01-2022"
                        },
                        new
                        {
                            Id = 3,
                            ClintName = "Test Clint3",
                            InitiationDate = "12-02-03",
                            ProjectName = "My Assignment3",
                            duration = " 03-01-2022"
                        });
                });

            modelBuilder.Entity("AngularAppApi.Models.Project_Employee", b =>
                {
                    b.HasOne("AngularAppApi.Models.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularAppApi.Models.Projects", "Projects")
                        .WithMany()
                        .HasForeignKey("project_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
