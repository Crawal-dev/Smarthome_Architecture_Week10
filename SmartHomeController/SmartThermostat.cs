using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        // Private fields
        private double currentTemperature;
        private double targetTemperature;

        // Public properties (only SmartThermostat can change them)
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            private set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            private set { targetTemperature = value; }
        }

        // The constructor and the methods go here
        
        public SmartThermostat(int deviceID, string deviceName, bool status,
                               double currentTemperature, double targetTemperature)
            : base(deviceID, deviceName, status)
        {
            SetCurrentTemperature(currentTemperature);
            SetTemperature(targetTemperature);
        }

        // Methods
        public void SetCurrentTemperature(double current)
        {
            if (current < -10 || current > 50)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(current), "The current temperature must be between -10 and 50.");
            }
            CurrentTemperature = current;
        }

        public void SetTemperature(double target)
        {
            if (target < 5 || target > 30)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(target), "The target temperature must be between 5 and 30.");
            }
            TargetTemperature = target;
        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine($" Current temperature: {CurrentTemperature}");
        }


    }
}
