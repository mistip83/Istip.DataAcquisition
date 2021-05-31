﻿// <auto-generated />
using System;
using DataAcquisition.DataAccessEF.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcquisition.DataAccessEF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210523021447_InitialDbCreation")]
    partial class InitialDbCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAcquisition.Model.Entities.ApplicationInfo", b =>
                {
                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FirstInstallDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationName");

                    b.ToTable("ApplicationInfo");

                    b.HasData(
                        new
                        {
                            ApplicationName = "DataAcquisition",
                            FirstInstallDate = new DateTime(2021, 5, 23, 3, 14, 47, 282, DateTimeKind.Local).AddTicks(3267),
                            LastUpdateDate = new DateTime(2021, 5, 23, 3, 14, 47, 284, DateTimeKind.Local).AddTicks(5739),
                            Version = "1.0.0"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            CompanyId = new Guid("c32da8dc-7fa4-4030-860e-17476af61820"),
                            CompanyName = "AcmeCompany"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Device", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConnectionProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WorkstationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DeviceId");

                    b.HasIndex("WorkstationId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Experiment", b =>
                {
                    b.Property<Guid>("ExperimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperimentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperimentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("WorkstationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExperimentId");

                    b.HasIndex("UserEmail");

                    b.HasIndex("WorkstationId");

                    b.ToTable("Experiment");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Facility", b =>
                {
                    b.Property<Guid>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FacilityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Facility");

                    b.HasData(
                        new
                        {
                            FacilityId = new Guid("6d529ae9-8574-4099-a428-a31b8b61114f"),
                            CompanyId = new Guid("c32da8dc-7fa4-4030-860e-17476af61820"),
                            FacilityName = "FacilityA"
                        },
                        new
                        {
                            FacilityId = new Guid("626a363d-f786-4012-8357-c3d27d436264"),
                            CompanyId = new Guid("c32da8dc-7fa4-4030-860e-17476af61820"),
                            FacilityName = "FacilityB"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.HasIndex("CompanyId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Email = "muratistipliler@gmail.com",
                            CompanyId = new Guid("c32da8dc-7fa4-4030-860e-17476af61820"),
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Murat",
                            Password = "25d55ad283aa400af464c76d713c07ad",
                            Surname = "Istipliler"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Workstation", b =>
                {
                    b.Property<Guid>("WorkstationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FacilityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkstationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkstationId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Workstation");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Device", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.Workstation", "Workstation")
                        .WithMany("Devices")
                        .HasForeignKey("WorkstationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workstation");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Experiment", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.User", "User")
                        .WithMany("Experiments")
                        .HasForeignKey("UserEmail");

                    b.HasOne("DataAcquisition.Model.Entities.Workstation", "WorkStation")
                        .WithMany("Experiments")
                        .HasForeignKey("WorkstationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("WorkStation");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Facility", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.Company", "Company")
                        .WithMany("Facilities")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.User", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Workstation", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.Facility", "Facility")
                        .WithMany("WorkStations")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Company", b =>
                {
                    b.Navigation("Facilities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Facility", b =>
                {
                    b.Navigation("WorkStations");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.User", b =>
                {
                    b.Navigation("Experiments");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Workstation", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("Experiments");
                });
#pragma warning restore 612, 618
        }
    }
}