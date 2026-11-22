using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartSecurityCamera : SmartDevice
    {
        // Private fields
        private string resolution = "";
        private bool recordingStatus;

        // Public properties (only SmartSecurityCamera can change these)
        public string Resolution
        {
            get { return resolution; }
            private set { resolution = value; }
        }

        public bool RecordingStatus
        {
            get { return recordingStatus; }
            private set { recordingStatus = value; }
        }

        // The constructor and the methods go here
        public SmartSecurityCamera(int deviceID, string deviceName, bool status,
                                   string resolution, bool recordingStatus)
            : base(deviceID, deviceName, status)
        {
            if (resolution != "720p" && resolution != "1080p" && resolution != "4K")
            {
                throw new ArgumentException("The resolution must be 720p, 1080p or 4K.");
            }
            Resolution = resolution;
            RecordingStatus = recordingStatus;
        }

        public void StartRecording()
        {
            RecordingStatus = true;
        }

        public void StopRecording()
        {
            RecordingStatus = false;
        }

        public string GetRecordingStatus()
        {
            if (RecordingStatus)
            {
                return "RECORDING";
            }
            return "NOT RECORDING";
        }

        // override: replaces SmartDevice.GetStatus() for a SmartSecurityCamera
        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine($" Resolution: {Resolution}, {GetRecordingStatus()}");
        }

    }

}