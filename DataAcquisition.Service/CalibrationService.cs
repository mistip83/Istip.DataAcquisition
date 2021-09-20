﻿using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Entities;
using System;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class CalibrationService : ICalibrationService
    {
        private readonly ICalibrationManager _calibrationManager;
        private readonly IDeviceService _deviceService;

        public CalibrationService(ICalibrationManager calibrationManager,
            IDeviceService deviceService)
        {
            _calibrationManager = calibrationManager;
            _deviceService = deviceService;
        }

        /// <summary>
        /// Calibrates device and updates last calibration date 
        /// </summary>
        /// <param name="device"></param>
        public Device CalibrateDevice(Device device)
        {
            var updatedDevice = _calibrationManager.DoCalibration(device);
            _deviceService.Update(updatedDevice);

            return updatedDevice;
        }
    }
}
