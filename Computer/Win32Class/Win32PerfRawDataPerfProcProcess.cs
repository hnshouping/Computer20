using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32PerfRawDataPerfProcProcess : Win32PerfRawData
    {
        private UInt32 creatingProcessID;
        private UInt64 elapsedTime;
        private UInt32 handleCount;
        private UInt32 iDProcess;
        private UInt64 iODataBytesPerSec;
        private UInt64 iODataOperationsPerSec;
        private UInt64 iOOtherBytesPerSec;
        private UInt64 iOOtherOperationsPerSec;
        private UInt64 iOReadBytesPerSec;
        private UInt64 iOReadOperationsPerSec;
        private UInt64 iOWriteBytesPerSec;
        private UInt64 iOWriteOperationsPerSec;
        private UInt32 pageFaultsPerSec;
        private UInt64 pageFileBytes;
        private UInt64 pageFileBytesPeak;
        private UInt64 percentPrivilegedTime;
        private UInt64 percentProcessorTime;
        private UInt64 percentUserTime;
        private UInt32 poolNonpagedBytes;
        private UInt32 poolPagedBytes;
        private UInt32 priorityBase;
        private UInt64 privateBytes;
        private UInt32 threadCount;
        private UInt64 virtualBytes;
        private UInt64 virtualBytesPeak;
        private UInt64 workingSet;
        private UInt64 workingSetPeak;

        public UInt32 CreatingProcessID
        {
            get { return creatingProcessID; }
            set { creatingProcessID = value; }
        }
        public UInt64 ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }
        public UInt32 HandleCount
        {
            get { return handleCount; }
            set { handleCount = value; }
        }
        public UInt32 IDProcess
        {
            get { return iDProcess; }
            set { iDProcess = value; }
        }
        public UInt64 IODataBytesPerSec
        {
            get { return iODataBytesPerSec; }
            set { iODataBytesPerSec = value; }
        }
        public UInt64 IODataOperationsPerSec
        {
            get { return iODataOperationsPerSec; }
            set { iODataOperationsPerSec = value; }
        }
        public UInt64 IOOtherBytesPerSec
        {
            get { return iOOtherBytesPerSec; }
            set { iOOtherBytesPerSec = value; }
        }
        public UInt64 IOOtherOperationsPerSec
        {
            get { return iOOtherOperationsPerSec; }
            set { iOOtherOperationsPerSec = value; }
        }
        public UInt64 IOReadBytesPerSec
        {
            get { return iOReadBytesPerSec; }
            set { iOReadBytesPerSec = value; }
        }
        public UInt64 IOReadOperationsPerSec
        {
            get { return iOReadOperationsPerSec; }
            set { iOReadOperationsPerSec = value; }
        }
        public UInt64 IOWriteBytesPerSec
        {
            get { return iOWriteBytesPerSec; }
            set { iOWriteBytesPerSec = value; }
        }
        public UInt64 IOWriteOperationsPerSec
        {
            get { return iOWriteOperationsPerSec; }
            set { iOWriteOperationsPerSec = value; }
        }
        public UInt32 PageFaultsPerSec
        {
            get { return pageFaultsPerSec; }
            set { pageFaultsPerSec = value; }
        }
        public UInt64 PageFileBytes
        {
            get { return pageFileBytes; }
            set { pageFileBytes = value; }
        }
        public UInt64 PageFileBytesPeak
        {
            get { return pageFileBytesPeak; }
            set { pageFileBytesPeak = value; }
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
        public UInt32 PoolNonpagedBytes
        {
            get { return poolNonpagedBytes; }
            set { poolNonpagedBytes = value; }
        }
        public UInt32 PoolPagedBytes
        {
            get { return poolPagedBytes; }
            set { poolPagedBytes = value; }
        }
        public UInt32 PriorityBase
        {
            get { return priorityBase; }
            set { priorityBase = value; }
        }
        public UInt64 PrivateBytes
        {
            get { return privateBytes; }
            set { privateBytes = value; }
        }
        public UInt32 ThreadCount
        {
            get { return threadCount; }
            set { threadCount = value; }
        }
        public UInt64 VirtualBytes
        {
            get { return virtualBytes; }
            set { virtualBytes = value; }
        }
        public UInt64 VirtualBytesPeak
        {
            get { return virtualBytesPeak; }
            set { virtualBytesPeak = value; }
        }
        public UInt64 WorkingSet
        {
            get { return workingSet; }
            set { workingSet = value; }
        }
        public UInt64 WorkingSetPeak
        {
            get { return workingSetPeak; }
            set { workingSetPeak = value; }
        }

    }
}
