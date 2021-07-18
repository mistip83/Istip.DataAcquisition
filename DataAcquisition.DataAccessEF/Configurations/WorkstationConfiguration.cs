﻿using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class WorkstationConfiguration : IEntityTypeConfiguration<Workstation>
    {
        public void Configure(EntityTypeBuilder<Workstation> builder)
        {
            builder.HasKey(x => x.WorkstationId);

            // Workstation has one facility
            builder.HasOne(p => p.Facility)
                .WithMany(p => p.WorkStations)
                .HasForeignKey(p => p.WorkstationId);
        }
    }
}