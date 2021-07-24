﻿// <auto-generated />
using System;
using DataAcquisition.DataAccessEF.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcquisition.DataAccessEF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            FirstInstallDate = new DateTime(2021, 7, 24, 13, 11, 20, 760, DateTimeKind.Local).AddTicks(1644),
                            LastUpdateDate = new DateTime(2021, 6, 24, 13, 11, 20, 761, DateTimeKind.Local).AddTicks(2115),
                            Version = "1.0.0"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Company", b =>
                {
                    b.Property<string>("CompanyName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyName");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            CompanyName = "AcmeCompany"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConnectionType")
                        .HasColumnType("int");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("WorkstationId")
                        .HasColumnType("int");

                    b.HasKey("DeviceId");

                    b.HasIndex("WorkstationId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Experiment", b =>
                {
                    b.Property<int>("ExperimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperimentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperimentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkstationId")
                        .HasColumnType("int");

                    b.HasKey("ExperimentId");

                    b.HasIndex("Email");

                    b.HasIndex("WorkstationId");

                    b.ToTable("Experiment");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employees")
                        .HasColumnType("int");

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FacilityId");

                    b.HasIndex("CompanyName");

                    b.ToTable("Facility");

                    b.HasData(
                        new
                        {
                            FacilityId = 1,
                            Address = "V94 H9FF - Limerick",
                            CompanyName = "AcmeCompany",
                            Employees = 65,
                            FacilityName = "FacilityA"
                        },
                        new
                        {
                            FacilityId = 2,
                            Address = "V35 S7BN - Cork",
                            CompanyName = "AcmeCompany",
                            Employees = 140,
                            FacilityName = "FacilityB"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.User", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DisplayName")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[Name] + ', ' + [Surname]");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Email");

                    b.HasIndex("CompanyName");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Email = "muratistipliler@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Murat",
                            Password = "25d55ad283aa400af464c76d713c07ad",
                            Surname = "Istip"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Workstation", b =>
                {
                    b.Property<int>("WorkstationId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("WorkstationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkstationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkstationId");

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
                        .HasForeignKey("Email");

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
                        .HasForeignKey("CompanyName");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.User", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyName");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.Workstation", b =>
                {
                    b.HasOne("DataAcquisition.Model.Entities.Facility", "Facility")
                        .WithMany("WorkStations")
                        .HasForeignKey("WorkstationId")
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
