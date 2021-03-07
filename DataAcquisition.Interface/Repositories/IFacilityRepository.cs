﻿using System;
using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Repositories
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        /// <summary>
        /// Returns facility entity with its workstations
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Facility> GetFacilityWithWorkStationsAsync(Guid id);
    }
}
