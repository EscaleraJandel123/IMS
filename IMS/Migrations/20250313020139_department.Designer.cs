﻿// <auto-generated />
using System;
using IMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250313020139_department")]
    partial class department
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IMS.Models.AttachmentsModel", b =>
                {
                    b.Property<int>("attachments_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("attachments_id"));

                    b.Property<string>("file_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("incident_id")
                        .HasColumnType("int");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("uploaded_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("attachments_id");

                    b.HasIndex("incident_id");

                    b.HasIndex("user_id");

                    b.ToTable("attachments");
                });

            modelBuilder.Entity("IMS.Models.CategoriesModel", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_id"));

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("IMS.Models.CommentsModel", b =>
                {
                    b.Property<int>("comment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("comment_id"));

                    b.Property<string>("comment_text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("commented_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("incident_id")
                        .HasColumnType("int");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("comment_id");

                    b.HasIndex("incident_id");

                    b.HasIndex("user_id");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("IMS.Models.DepartmentsModel", b =>
                {
                    b.Property<int>("department_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("department_id"));

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("IMS.Models.IncidentsModel", b =>
                {
                    b.Property<int>("incident_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("incident_id"));

                    b.Property<int?>("assigned_too")
                        .HasColumnType("int");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("reported_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("incident_id");

                    b.HasIndex("user_id");

                    b.ToTable("incidents");
                });

            modelBuilder.Entity("IMS.Models.LogsModel", b =>
                {
                    b.Property<int>("log_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("log_id"));

                    b.Property<string>("action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("log_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("log_id");

                    b.HasIndex("user_id");

                    b.ToTable("logs");
                });

            modelBuilder.Entity("IMS.Models.UpdatesModel", b =>
                {
                    b.Property<int>("update_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("update_id"));

                    b.Property<string>("attachments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("incident_id")
                        .HasColumnType("int");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("update_text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("update_id");

                    b.HasIndex("incident_id");

                    b.HasIndex("user_id");

                    b.ToTable("updates");
                });

            modelBuilder.Entity("IMS.Models.UsersModel", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isRistrict")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token_forgot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("IMS.Models.AttachmentsModel", b =>
                {
                    b.HasOne("IMS.Models.IncidentsModel", "Incident")
                        .WithMany()
                        .HasForeignKey("incident_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.UsersModel", "User")
                        .WithMany("Attachments")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Incident");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Models.CommentsModel", b =>
                {
                    b.HasOne("IMS.Models.IncidentsModel", "Incident")
                        .WithMany()
                        .HasForeignKey("incident_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.UsersModel", "User")
                        .WithMany("Comments")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Incident");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Models.IncidentsModel", b =>
                {
                    b.HasOne("IMS.Models.UsersModel", "User")
                        .WithMany("Incidents")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Models.LogsModel", b =>
                {
                    b.HasOne("IMS.Models.UsersModel", "User")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Models.UpdatesModel", b =>
                {
                    b.HasOne("IMS.Models.IncidentsModel", "Incident")
                        .WithMany("Updates")
                        .HasForeignKey("incident_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.UsersModel", "User")
                        .WithMany("Updates")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Incident");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IMS.Models.IncidentsModel", b =>
                {
                    b.Navigation("Updates");
                });

            modelBuilder.Entity("IMS.Models.UsersModel", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Comments");

                    b.Navigation("Incidents");

                    b.Navigation("Updates");
                });
#pragma warning restore 612, 618
        }
    }
}
