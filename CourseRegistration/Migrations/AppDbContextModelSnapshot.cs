﻿// <auto-generated />
using System;
using CourseRegistration.Data.SqlRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseRegistration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("CourseRegistration.Models.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("C_Name")
                        .HasColumnType("longtext");

                    b.Property<int>("C_Number")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1001,
                            C_Name = "Math",
                            C_Number = 1,
                            Description = "Geometry"
                        },
                        new
                        {
                            CourseId = 1002,
                            C_Name = "Science",
                            C_Number = 2,
                            Description = "Biology"
                        },
                        new
                        {
                            CourseId = 1003,
                            C_Name = "Computer Science",
                            C_Number = 3,
                            Description = "Web Development"
                        });
                });

            modelBuilder.Entity("CourseRegistration.Models.Instructors", b =>
                {
                    b.Property<int>("I_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.HasKey("I_Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            I_Id = 101,
                            CourseId = 1001,
                            EmailAddress = "markjohnson@gmail.com",
                            FirstName = "Mark",
                            LastName = "Johnson"
                        },
                        new
                        {
                            I_Id = 102,
                            CourseId = 1002,
                            EmailAddress = "lucysmith@gmail.com",
                            FirstName = "Lucy",
                            LastName = "Smith"
                        },
                        new
                        {
                            I_Id = 103,
                            CourseId = 1003,
                            EmailAddress = "trecybrown@gmail.com",
                            FirstName = "Trecy",
                            LastName = "Brown"
                        });
                });

            modelBuilder.Entity("CourseRegistration.Models.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1001,
                            EmailAddress = "danialpara@gmail.com",
                            FirstName = "Danial",
                            LastName = "Para",
                            PhoneNumber = "5879207077"
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1002,
                            EmailAddress = "parkerjames@gmail.com",
                            FirstName = "Parker",
                            LastName = "James",
                            PhoneNumber = "7809304545"
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 1003,
                            EmailAddress = "robinsmith@gmail.com",
                            FirstName = "Robin",
                            LastName = "Smith",
                            PhoneNumber = "6785674564"
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 1003,
                            EmailAddress = "suratandan@gmail.com",
                            FirstName = "Sura",
                            LastName = "Tandan",
                            PhoneNumber = "2785674504"
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 1001,
                            EmailAddress = "samueljohnson@gmail.com",
                            FirstName = "Samuel",
                            LastName = "Johnson",
                            PhoneNumber = "6785644560"
                        },
                        new
                        {
                            StudentId = 6,
                            CourseId = 1002,
                            EmailAddress = "tommylee@gmail.com",
                            FirstName = "Tommy",
                            LastName = "Lee",
                            PhoneNumber = "4785684564"
                        });
                });

            modelBuilder.Entity("CourseRegistration.Models.Instructors", b =>
                {
                    b.HasOne("CourseRegistration.Models.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CourseRegistration.Models.Students", b =>
                {
                    b.HasOne("CourseRegistration.Models.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}