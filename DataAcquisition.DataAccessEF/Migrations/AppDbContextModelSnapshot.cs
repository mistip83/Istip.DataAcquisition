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
                            FirstInstallDate = new DateTime(2021, 8, 2, 7, 40, 10, 72, DateTimeKind.Local).AddTicks(8015),
                            LastUpdateDate = new DateTime(2021, 7, 2, 7, 40, 10, 73, DateTimeKind.Local).AddTicks(7475),
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

                    b.Property<int>("WorkstationId")
                        .HasColumnType("int");

                    b.HasKey("DeviceId");

                    b.HasIndex("WorkstationId");

                    b.ToTable("Device");

                    b.HasData(
                        new
                        {
                            DeviceId = 1,
                            ConnectionType = 1,
                            DeviceName = "DAQ1",
                            DeviceType = 1,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 2,
                            ConnectionType = 1,
                            DeviceName = "NetworkAnalyzer1",
                            DeviceType = 4,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 3,
                            ConnectionType = 2,
                            DeviceName = "EnergyAnalyzer1",
                            DeviceType = 2,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 4,
                            ConnectionType = 2,
                            DeviceName = "EnergyAnalyzer2",
                            DeviceType = 2,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 5,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter1",
                            DeviceType = 3,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 6,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter2",
                            DeviceType = 3,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 7,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter3",
                            DeviceType = 3,
                            WorkstationId = 1
                        },
                        new
                        {
                            DeviceId = 8,
                            ConnectionType = 1,
                            DeviceName = "DAQ1",
                            DeviceType = 1,
                            WorkstationId = 2
                        },
                        new
                        {
                            DeviceId = 9,
                            ConnectionType = 1,
                            DeviceName = "DAQ2",
                            DeviceType = 1,
                            WorkstationId = 2
                        },
                        new
                        {
                            DeviceId = 10,
                            ConnectionType = 2,
                            DeviceName = "EnergyAnalyzer1",
                            DeviceType = 2,
                            WorkstationId = 3
                        },
                        new
                        {
                            DeviceId = 11,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter1",
                            DeviceType = 3,
                            WorkstationId = 4
                        },
                        new
                        {
                            DeviceId = 12,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter2",
                            DeviceType = 3,
                            WorkstationId = 4
                        },
                        new
                        {
                            DeviceId = 13,
                            ConnectionType = 2,
                            DeviceName = "EnergyAnalyzer1",
                            DeviceType = 2,
                            WorkstationId = 5
                        },
                        new
                        {
                            DeviceId = 14,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter1",
                            DeviceType = 3,
                            WorkstationId = 4
                        },
                        new
                        {
                            DeviceId = 15,
                            ConnectionType = 3,
                            DeviceName = "DigitalMultimeter2",
                            DeviceType = 3,
                            WorkstationId = 4
                        });
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

                    b.Property<string>("ExperimentDataId")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ExperimentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperimentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkstationId")
                        .HasColumnType("int");

                    b.HasKey("ExperimentId");

                    b.HasIndex("Email");

                    b.HasIndex("WorkstationId");

                    b.ToTable("Experiment");
                });

            modelBuilder.Entity("DataAcquisition.Model.Entities.ExperimentData", b =>
                {
                    b.Property<int>("ExperimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChannelNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChannelUnits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExperimentId");

                    b.ToTable("ExperimentData");
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("WorkstationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkstationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkstationId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Workstation");

                    b.HasData(
                        new
                        {
                            WorkstationId = 1,
                            FacilityId = 1,
                            IsDeleted = false,
                            WorkstationDescription = "Lab4",
                            WorkstationName = "Workstation1"
                        },
                        new
                        {
                            WorkstationId = 2,
                            FacilityId = 1,
                            IsDeleted = false,
                            WorkstationDescription = "Lab4",
                            WorkstationName = "Workstation2"
                        },
                        new
                        {
                            WorkstationId = 3,
                            FacilityId = 1,
                            IsDeleted = false,
                            WorkstationDescription = "Lab7",
                            WorkstationName = "Workstation3"
                        },
                        new
                        {
                            WorkstationId = 4,
                            FacilityId = 2,
                            IsDeleted = false,
                            WorkstationDescription = "ProductionLine",
                            WorkstationName = "Workstation4"
                        },
                        new
                        {
                            WorkstationId = 5,
                            FacilityId = 2,
                            IsDeleted = false,
                            WorkstationDescription = "ProductionLine",
                            WorkstationName = "Workstation5"
                        });
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
