using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo.Counter
{
    public class ProcessCounterUnitTime
    {
        private UInt32 creatingProcessID;
        private UInt64 elapsedTime;
        private UInt64 frequency_Object;
        private UInt64 frequency_PerfTime;
        private UInt64 frequency_Sys100NS;
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
        private string name;
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
        private UInt64 timestamp_Object;
        private UInt64 timestamp_PerfTime;
        private UInt64 timestamp_Sys100NS;
        private UInt64 virtualBytes;
        private UInt64 virtualBytesPeak;
        private UInt64 workingSet;
        private UInt64 workingSetPeak;

        private WmiPerfRawDataPerfProcProcess wpr;
        private Win32PerfRawDataPerfProcProcess wa;

        public ProcessCounterUnitTime(string processname)
        {
            wpr = new WmiPerfRawDataPerfProcProcess();
            wa=wpr.GetPerfRawDataPerfProcProcessByName(processname);
            FillDiskDriveInfo(processname);
        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public ProcessCounterUnitTime(string ip, string username, string password, string processname)
        {
            wpr = new WmiPerfRawDataPerfProcProcess(ip, username, password);
            wa=wpr.GetPerfRawDataPerfProcProcessByName(processname);
            FillDiskDriveInfo(processname);
        }

        private void FillDiskDriveInfo(string processname)
        {
            if (wa != null)
            {
                creatingProcessID = wa.CreatingProcessID;
                elapsedTime = wa.ElapsedTime;
                frequency_Object = wa.Frequency_Object;
                frequency_PerfTime = wa.Frequency_PerfTime;
                frequency_Sys100NS = wa.Frequency_Sys100NS;
                handleCount = wa.HandleCount;
                iDProcess = wa.IDProcess;
                iODataBytesPerSec = wa.IODataBytesPerSec;
                iODataOperationsPerSec = wa.IODataOperationsPerSec;
                iOOtherBytesPerSec = wa.IOOtherBytesPerSec;
                iOOtherOperationsPerSec = wa.IOOtherOperationsPerSec;
                iOReadBytesPerSec = wa.IOReadBytesPerSec;
                iOReadOperationsPerSec = wa.IOReadOperationsPerSec;
                iOWriteBytesPerSec = wa.IOWriteBytesPerSec;
                iOWriteOperationsPerSec = wa.IOWriteOperationsPerSec;
                name = wa.Name;
                pageFaultsPerSec = wa.PageFaultsPerSec;
                pageFileBytes = wa.PageFileBytes;
                pageFileBytesPeak = wa.PageFileBytesPeak;
                percentPrivilegedTime = wa.PercentPrivilegedTime;
                percentProcessorTime = wa.PercentProcessorTime;
                percentUserTime = wa.PercentUserTime;
                poolNonpagedBytes = wa.PoolNonpagedBytes;
                poolPagedBytes = wa.PoolPagedBytes;
                priorityBase = wa.PriorityBase;
                privateBytes = wa.PrivateBytes;
                threadCount = wa.ThreadCount;
                timestamp_Object = wa.Timestamp_Object;
                timestamp_PerfTime = wa.Timestamp_PerfTime;
                timestamp_Sys100NS = wa.Timestamp_Sys100NS;
                virtualBytes = wa.VirtualBytes;
                virtualBytesPeak = wa.VirtualBytesPeak;
                workingSet = wa.WorkingSet;
                workingSetPeak = wa.WorkingSetPeak;
            }
            else
            {
                throw new Exception("没有找到数据");
            }
            
        }
        public UInt32 CreatingProcessID
        {
            get { return this.creatingProcessID; }
        }
        public UInt64 ElapsedTime
        {
            get { return this.elapsedTime; }
        }
        public UInt64 Frequency_Object
        {
            get { return this.frequency_Object; }
        }
        public UInt64 Frequency_PerfTime
        {
            get { return this.frequency_PerfTime; }
        }
        public UInt64 Frequency_Sys100NS
        {
            get { return this.frequency_Sys100NS; }
        }
        public UInt32 HandleCount
        {
            get { return this.handleCount; }
        }
        public UInt32 IDProcess
        {
            get { return this.iDProcess; }
        }
        public UInt64 IODataBytesPerSec
        {
            get { return this.iODataBytesPerSec; }
        }
        public UInt64 IODataOperationsPerSec
        {
            get { return this.iODataOperationsPerSec; }
        }
        public UInt64 IOOtherBytesPerSec
        {
            get { return this.iOOtherBytesPerSec; }
        }
        public UInt64 IOOtherOperationsPerSec
        {
            get { return this.iOOtherOperationsPerSec; }
        }
        public UInt64 IOReadBytesPerSec
        {
            get { return this.iOReadBytesPerSec; }
        }
        public UInt64 IOReadOperationsPerSec
        {
            get { return this.iOReadOperationsPerSec; }
        }
        public UInt64 IOWriteBytesPerSec
        {
            get { return this.iOWriteBytesPerSec; }
        }
        public UInt64 IOWriteOperationsPerSec
        {
            get { return this.iOWriteOperationsPerSec; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public UInt32 PageFaultsPerSec
        {
            get { return this.pageFaultsPerSec; }
        }
        public UInt64 PageFileBytes
        {
            get { return this.pageFileBytes; }
        }
        public UInt64 PageFileBytesPeak
        {
            get { return this.pageFileBytesPeak; }
        }
        public UInt64 PercentPrivilegedTime
        {
            get { return this.percentPrivilegedTime; }
        }
        public UInt64 PercentProcessorTime
        {
            get { return this.percentProcessorTime; }
        }
        public UInt64 PercentUserTime
        {
            get { return this.percentUserTime; }
        }
        public UInt32 PoolNonpagedBytes
        {
            get { return this.poolNonpagedBytes; }
        }
        public UInt32 PoolPagedBytes
        {
            get { return this.poolPagedBytes; }
        }
        public UInt32 PriorityBase
        {
            get { return this.priorityBase; }
        }
        public UInt64 PrivateBytes
        {
            get { return this.privateBytes; }
        }
        public UInt32 ThreadCount
        {
            get { return this.threadCount; }
        }
        public UInt64 Timestamp_Object
        {
            get { return this.timestamp_Object; }
        }
        public UInt64 Timestamp_PerfTime
        {
            get { return this.timestamp_PerfTime; }
        }
        public UInt64 Timestamp_Sys100NS
        {
            get { return this.timestamp_Sys100NS; }
        }
        public UInt64 VirtualBytes
        {
            get { return this.virtualBytes; }
        }
        public UInt64 VirtualBytesPeak
        {
            get { return this.virtualBytesPeak; }
        }
        public UInt64 WorkingSet
        {
            get { return this.workingSet; }
        }
        public UInt64 WorkingSetPeak
        {
            get { return this.workingSetPeak; }
        }
    }
}
