using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Computer.Win32Class;

namespace WmiInfo.Counter
{
    public class ProcessorUnitTime
    {
        private WmiPerfRawDataPerfOSProcessor pc;

        private UInt32 dPCRate;
        private UInt64 frequency_PerfTime;

        private UInt64 newtimestamp_PerfTime;
        private UInt64 oldtimestamp_PerfTime;
        private UInt64 newtimestamp_Sys100NS;
        private UInt64 oldtimestamp_Sys100NS;

        private UInt32 newdPCsQueuedPersec;
        private UInt32 olddPCsQueuedPersec;

        private UInt32 newinterruptsPerSec;
        private UInt32 oldinterruptsPerSec;

        private UInt64 newpercentDPCTime;
        private UInt64 oldpercentDPCTime;

        private UInt64 newpercentInterruptTime;
        private UInt64 oldpercentInterruptTime;

        private UInt64 newpercentPrivilegedTime;
        private UInt64 oldpercentPrivilegedTime;

        private UInt64 newpercentProcessorTime;
        private UInt64 oldpercentProcessorTime;

        private UInt64 newpercentUserTime;
        private UInt64 oldpercentUserTime;


        public ProcessorUnitTime()
        {
            pc = new WmiPerfRawDataPerfOSProcessor();
            Win32PerfRawDataPerfOSProcessor wprdp = pc.Win32PerfRawDataPerfOSProcessors[pc.Win32PerfRawDataPerfOSProcessorsLength - 1];
            frequency_PerfTime = wprdp.Frequency_PerfTime;
            dPCRate = wprdp.DPCRate;

            oldtimestamp_PerfTime = wprdp.Timestamp_PerfTime;
            olddPCsQueuedPersec = wprdp.DPCsQueuedPerSec;
            oldinterruptsPerSec = wprdp.InterruptsPerSec;
            oldpercentDPCTime = wprdp.PercentDPCTime;
            oldtimestamp_Sys100NS = wprdp.Timestamp_Sys100NS;
            oldpercentInterruptTime = wprdp.PercentInterruptTime;
            oldpercentPrivilegedTime = wprdp.PercentPrivilegedTime;
            oldpercentProcessorTime = wprdp.PercentProcessorTime;
            oldpercentUserTime = wprdp.PercentUserTime;

            Thread.Sleep(500);
            pc = new WmiPerfRawDataPerfOSProcessor();
            Win32PerfRawDataPerfOSProcessor wprdp1 = pc.Win32PerfRawDataPerfOSProcessors[pc.Win32PerfRawDataPerfOSProcessorsLength - 1];

            newtimestamp_PerfTime = wprdp1.Timestamp_PerfTime;
            newdPCsQueuedPersec = wprdp1.DPCsQueuedPerSec;
            newinterruptsPerSec = wprdp1.InterruptsPerSec;
            newpercentDPCTime = wprdp1.PercentDPCTime;
            newtimestamp_Sys100NS = wprdp1.Timestamp_Sys100NS;
            newpercentInterruptTime = wprdp1.PercentInterruptTime;
            newpercentPrivilegedTime = wprdp1.PercentPrivilegedTime;
            newpercentProcessorTime = wprdp1.PercentProcessorTime;
            newpercentUserTime = wprdp1.PercentUserTime;

        }
        public ProcessorUnitTime(string ip, string username, string password)
        {
            pc = new WmiPerfRawDataPerfOSProcessor(ip, username, password);
            Win32PerfRawDataPerfOSProcessor wprdp = pc.Win32PerfRawDataPerfOSProcessors[pc.Win32PerfRawDataPerfOSProcessorsLength - 1];
            frequency_PerfTime = wprdp.Frequency_PerfTime;
            dPCRate = wprdp.DPCRate;

            oldtimestamp_PerfTime = wprdp.Timestamp_PerfTime;
            olddPCsQueuedPersec = wprdp.DPCsQueuedPerSec;
            oldinterruptsPerSec = wprdp.InterruptsPerSec;
            oldpercentDPCTime = wprdp.PercentDPCTime;
            oldtimestamp_Sys100NS = wprdp.Timestamp_Sys100NS;
            oldpercentInterruptTime = wprdp.PercentInterruptTime;
            oldpercentPrivilegedTime = wprdp.PercentPrivilegedTime;
            oldpercentProcessorTime = wprdp.PercentProcessorTime;
            oldpercentUserTime = wprdp.PercentUserTime;

            Thread.Sleep(500);
            pc = new WmiPerfRawDataPerfOSProcessor(ip, username, password);
            Win32PerfRawDataPerfOSProcessor wprdp1 = pc.Win32PerfRawDataPerfOSProcessors[pc.Win32PerfRawDataPerfOSProcessorsLength - 1];

            newtimestamp_PerfTime = wprdp1.Timestamp_PerfTime;
            newdPCsQueuedPersec = wprdp1.DPCsQueuedPerSec;
            newinterruptsPerSec = wprdp1.InterruptsPerSec;
            newpercentDPCTime = wprdp1.PercentDPCTime;
            newtimestamp_Sys100NS = wprdp1.Timestamp_Sys100NS;
            newpercentInterruptTime = wprdp1.PercentInterruptTime;
            newpercentPrivilegedTime = wprdp1.PercentPrivilegedTime;
            newpercentProcessorTime = wprdp1.PercentProcessorTime;
            newpercentUserTime = wprdp1.PercentUserTime;
        }
        public UInt32 DPCRate
        {
            get { return this.dPCRate; }
        }
        public Decimal DPCsQueuedPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newdPCsQueuedPersec, olddPCsQueuedPersec,
                    newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal InterruptsPerSecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newinterruptsPerSec, oldinterruptsPerSec,
                    newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PercentDPCTime100NS
        {
            get
            {
                return Common.PERF_100NSEC_TIMER(newpercentDPCTime, oldpercentDPCTime
                    , newtimestamp_Sys100NS, oldtimestamp_Sys100NS);
            }
        }
        public Decimal PercentInterruptTime100NS
        {
            get
            {
                return Common.PERF_100NSEC_TIMER(newpercentInterruptTime, oldpercentInterruptTime
                    , newtimestamp_Sys100NS, oldtimestamp_Sys100NS);
            }
        }
        public Decimal PercentPrivilegedTime100NS
        {
            get
            {
                return Common.PERF_100NSEC_TIMER(newpercentPrivilegedTime, oldpercentPrivilegedTime
                    , newtimestamp_Sys100NS, oldtimestamp_Sys100NS);
            }
        }
        /// <summary>
        /// CPU π”√¬ 
        /// </summary>
        public Decimal PercentProcessorTime100INV
        {
            get
            {
                Decimal a = Common.PERF_100NSEC_TIMER_INV(newpercentProcessorTime, oldpercentProcessorTime
                    , newtimestamp_Sys100NS, oldtimestamp_Sys100NS);
                if (a > 0)
                {
                    return a;
                }
                else
                {
                    return 0;
                }
            }
        }
        public Decimal PercentUserTime100NS
        {
            get
            {
                return Common.PERF_100NSEC_TIMER(newpercentUserTime, oldpercentUserTime
                    , newtimestamp_Sys100NS, oldtimestamp_Sys100NS);
            }
        }
    }
}
