﻿using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service.Services
{
    public class FacilityService : Service<Facility>, IFacilityService
    {
        public FacilityService(IUnitOfWork unitOfWork, IRepository<Facility> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Facility> GetFacilityWithWorkStationsAsync(Guid id)
        {
            return await UnitOfWork.Facilities.GetFacilityWithWorkStationsAsync(id);
        }
    }
}