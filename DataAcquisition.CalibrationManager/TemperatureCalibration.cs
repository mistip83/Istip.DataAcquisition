﻿using System;
using System.Timers;
using DataAcquisition.Interface.CalibrationManager;

namespace DataAcquisition.CalibrationManager
{
    public class TemperatureCalibration : CalibrationDecorator
    {
        private static Timer _timer;
        public TemperatureCalibration(ICalibrationManager calibrationManager) : base(calibrationManager)
        {
        }

        public override double GetCalibrationData(int channelAddress)
        {
            SetTimer();
            return base.GetCalibrationData(channelAddress);
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            _timer = new Timer(2000);
            // Hook up the Elapsed event for the timer. 
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                e.SignalTime);
        }
    }
}