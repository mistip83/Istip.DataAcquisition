﻿namespace DataAcquisition.Core.Models.DTOs
{
    public class WorkstationDto
    {
        public int WorkstationId { get; set; }
        public string WorkstationName { get; set; }
        public string WorkstationDescription { get; set; }
        public int FacilityId { get; set; }
    }
}