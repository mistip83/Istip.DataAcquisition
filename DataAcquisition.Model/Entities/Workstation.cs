﻿using System;
using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class Workstation
    {
        public Guid WorkstationId { get; set; }
        public string WorkstationName { get; set; }
        public Guid FacilityId { get; set; }
        public virtual ICollection<Experiment> Experiments { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
