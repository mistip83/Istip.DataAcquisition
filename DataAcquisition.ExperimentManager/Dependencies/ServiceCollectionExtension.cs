﻿using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.ExperimentManager;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.DeviceLibrary;
using DataAcquisition.ExperimentManager.Publishers;
using DataAcquisition.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcquisition.ExperimentManager.Dependencies
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterExperimentManagerDependencies(this IServiceCollection container)
        {
            container.AddScoped<IAcquisitionRepository, AcquisitionRepository>();
            container.AddScoped<IConnectionManager, ConnectionManager.ConnectionManager>();
            container.AddScoped<IDeviceLibraryManager, DeviceLibraryManager>();
            container.AddScoped<IPublisher, ExperimentStatePublisher>();

            return container;
        }
    }
}
