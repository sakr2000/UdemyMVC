﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyMVC.Models;

#nullable disable

namespace UdemyMVC.Migrations
{
    [DbContext(typeof(UdemyDataBase))]
    [Migration("20240811230340_v13")]
    partial class v13
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UdemyMVC.Models.ApplicationModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("UdemyMVC.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UdemyMVC.Models.CategoryCourse", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("CourseID", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("CategoryCourses");
                });

            modelBuilder.Entity("UdemyMVC.Models.Chapter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseId");

                    b.ToTable("chapters");
                });

            modelBuilder.Entity("UdemyMVC.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CourseImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UdemyMVC.Models.CourseRate", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("CourseID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("CourseRates");
                });

            modelBuilder.Entity("UdemyMVC.Models.Enrollment", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("UdemyMVC.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ChapterID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ChapterID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UdemyMVC.Models.ApplicationModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UdemyMVC.Models.ApplicationModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyMVC.Models.ApplicationModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UdemyMVC.Models.ApplicationModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UdemyMVC.Models.CategoryCourse", b =>
                {
                    b.HasOne("UdemyMVC.Models.Category", "Category")
                        .WithMany("CategoryCourses")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyMVC.Models.Course", "Course")
                        .WithMany("CategoryCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UdemyMVC.Models.Chapter", b =>
                {
                    b.HasOne("UdemyMVC.Models.Course", "Course")
                        .WithMany("Chapters")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UdemyMVC.Models.Course", b =>
                {
                    b.HasOne("UdemyMVC.Models.ApplicationModel", "Instructor")
                        .WithMany("Course")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("UdemyMVC.Models.CourseRate", b =>
                {
                    b.HasOne("UdemyMVC.Models.Course", "Course")
                        .WithMany("CourseRates")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyMVC.Models.ApplicationModel", "User")
                        .WithMany("CourseRates")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UdemyMVC.Models.Enrollment", b =>
                {
                    b.HasOne("UdemyMVC.Models.Course", "Course")
                        .WithMany("Enrollment")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyMVC.Models.ApplicationModel", "User")
                        .WithMany("Enrolement")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UdemyMVC.Models.Topic", b =>
                {
                    b.HasOne("UdemyMVC.Models.Chapter", "Chapter")
                        .WithMany("Topics")
                        .HasForeignKey("ChapterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("UdemyMVC.Models.ApplicationModel", b =>
                {
                    b.Navigation("Course");

                    b.Navigation("CourseRates");

                    b.Navigation("Enrolement");
                });

            modelBuilder.Entity("UdemyMVC.Models.Category", b =>
                {
                    b.Navigation("CategoryCourses");
                });

            modelBuilder.Entity("UdemyMVC.Models.Chapter", b =>
                {
                    b.Navigation("Topics");
                });

            modelBuilder.Entity("UdemyMVC.Models.Course", b =>
                {
                    b.Navigation("CategoryCourses");

                    b.Navigation("Chapters");

                    b.Navigation("CourseRates");

                    b.Navigation("Enrollment");
                });
#pragma warning restore 612, 618
        }
    }
}
