﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolutionPortalBeta.Server.AppDbContext;

#nullable disable

namespace SolutionPortalBeta.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230914155321_UpdateComplaints")]
    partial class UpdateComplaints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ComplaintId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AttachmentId");

                    b.HasIndex("ComplaintId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.Company", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.UserComplaint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Response")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserComplaint");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.Attachment", b =>
                {
                    b.HasOne("SolutionPortalBeta.Server.Models.UserComplaint", "Complaint")
                        .WithMany("Attachments")
                        .HasForeignKey("ComplaintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Complaint");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.Department", b =>
                {
                    b.HasOne("SolutionPortalBeta.Server.Models.Company", null)
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.Company", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("SolutionPortalBeta.Server.Models.UserComplaint", b =>
                {
                    b.Navigation("Attachments");
                });
#pragma warning restore 612, 618
        }
    }
}
