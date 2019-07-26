using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32PerfRawDataPerfOSProcessor : Win32PerfRawData
    {
        private UInt64 c1TransitionsPerSec;
        private UInt64 c2TransitionsPerSec;
        private UInt64 c3TransitionsPerSec;
        private UInt32 dPCRate;
        private UInt32 dPCsQueuedPerSec;
        private UInt32 interruptsPerSec;
        private UInt64 percentC1Time;
        private UInt64 percentC2Time;
        private UInt64 percentC3Time;
        private UInt64 percentDPCTime;
        private UInt64 percentIdleTime;
        private UInt64 percentInterruptTime;
        private UInt64 percentPrivilegedTime;
        private UInt64 percentProcessorTime;
        private UInt64 percentUserTime;

        public UInt64 C1TransitionsPerSec
        {
            get { return c1TransitionsPerSec; }
            set { c1TransitionsPerSec = value; }
        }
        public UInt64 C2TransitionsPerSec
        {
            get { return c2TransitionsPerSec; }
            set { c2TransitionsPerSec = value; }
        }
        public UInt64 C3TransitionsPerSec
        {
            get { return c3TransitionsPerSec; }
            set { c3TransitionsPerSec = value; }
        }
        public UInt32 DPCRate
        {
            get { return dPCRate; }
            set { dPCRate = value; }
        }
        public UInt32 DPCsQueuedPerSec
        {
            get { return dPCsQueuedPerSec; }
            set { dPCsQueuedPerSec = value; }
        }
        public UInt32 InterruptsPerSec
        {
            get { return interruptsPerSec; }
            set { interruptsPerSec = value; }
        }
        public UInt64 PercentC1Time
        {
            get { return percentC1Time; }
            set { percentC1Time = value; }
        }
        public UInt64 PercentC2Time
        {
            get { return percentC2Time; }
            set { percentC2Time = value; }
        }
        public UInt64 PercentC3Time
        {
            get { return percentC3Time; }
            set { percentC3Time = value; }
        }
        public UInt64 PercentDPCTime
        {
            get { return percentDPCTime; }
            set { percentDPCTime = value; }
        }
        public UInt64 PercentIdleTime
        {
            get { return percentIdleTime; }
            set { percentIdleTime = value; }
        }
        public UInt64 PercentInterruptTime
        {
            get { return percentInterruptTime; }
            set { percentInterruptTime = value; }
        }
        public UInt64 PercentPrivilegedTime
        {
            get { return percentPrivilegedTime; }
            set { percentPrivilegedTime = value; }
        }
        public UInt64 PercentProcessorTime
        {
            get { return percentProcessorTime; }
            set { percentProcessorTime = value; }
        }
        public UInt64 PercentUserTime
        {
            get { return percentUserTime; }
            set { percentUserTime = value; }
        }

    }
}
