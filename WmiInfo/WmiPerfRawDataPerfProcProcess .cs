using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    class WmiPerfRawDataPerfProcProcess: WmiBase
    {
        private List<Win32PerfRawDataPerfProcProcess> ps;

        private string WSql = "select * from Win32_PerfRawData_PerfProc_Process";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiPerfRawDataPerfProcProcess()
            : base()
        {
            
        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiPerfRawDataPerfProcProcess(string ip, string username, string password)
            : base(ip, username, password)
        {
        }
        private List<Win32PerfRawDataPerfProcProcess> GetAllPerfRawDataPerfProcProcess()
        {
            ps = new List<Win32PerfRawDataPerfProcProcess>();
            FillFloppyDriveInfo();
            return ps;
        }
        public Win32PerfRawDataPerfProcProcess GetPerfRawDataPerfProcProcessByName(string processname)
        {
            ps = new List<Win32PerfRawDataPerfProcProcess>();
            WSql = this.WSql + " where Name='" + processname + "'";
            FillFloppyDriveInfo();
            if (ps.Count == 1)
            {
                return ps[0];
            }
            else
            {
                return null;
            }
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32PerfRawDataPerfProcProcess csp = new Win32PerfRawDataPerfProcProcess();
                if (mo != null)
                {
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CreatingProcessID = GetManagementObject<uint>(mo, "CreatingProcessID");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.ElapsedTime = GetManagementObject<ulong>(mo, "ElapsedTime");
                    csp.Frequency_Object = GetManagementObject<ulong>(mo, "Frequency_Object");
                    csp.Frequency_PerfTime = GetManagementObject<ulong>(mo, "Frequency_PerfTime");
                    csp.Frequency_Sys100NS = GetManagementObject<ulong>(mo, "Frequency_Sys100NS");
                    csp.HandleCount = GetManagementObject<uint>(mo, "HandleCount");
                    csp.IDProcess = GetManagementObject<uint>(mo, "IDProcess");
                    csp.IODataBytesPerSec = GetManagementObject<ulong>(mo, "IODataBytesPerSec");
                    csp.IODataOperationsPerSec = GetManagementObject<ulong>(mo, "IODataOperationsPerSec");
                    csp.IOOtherBytesPerSec = GetManagementObject<ulong>(mo, "IOOtherBytesPerSec");
                    csp.IOOtherOperationsPerSec = GetManagementObject<ulong>(mo, "IOOtherOperationsPerSec");
                    csp.IOReadBytesPerSec = GetManagementObject<ulong>(mo, "IOReadBytesPerSec");
                    csp.IOReadOperationsPerSec = GetManagementObject<ulong>(mo, "IOReadOperationsPerSec");
                    csp.IOWriteBytesPerSec = GetManagementObject<ulong>(mo, "IOWriteBytesPerSec");
                    csp.IOWriteOperationsPerSec = GetManagementObject<ulong>(mo, "IOWriteOperationsPerSec");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.PageFaultsPerSec = GetManagementObject<uint>(mo, "PageFaultsPerSec");
                    csp.PageFileBytes = GetManagementObject<ulong>(mo, "PageFileBytes");
                    csp.PageFileBytesPeak = GetManagementObject<ulong>(mo, "PageFileBytesPeak");
                    csp.PercentPrivilegedTime = GetManagementObject<ulong>(mo, "PercentPrivilegedTime");
                    csp.PercentProcessorTime = GetManagementObject<ulong>(mo, "PercentProcessorTime");
                    csp.PercentUserTime = GetManagementObject<ulong>(mo, "PercentUserTime");
                    csp.PoolNonpagedBytes = GetManagementObject<uint>(mo, "PoolNonpagedBytes");
                    csp.PoolPagedBytes = GetManagementObject<uint>(mo, "PoolPagedBytes");
                    csp.PriorityBase = GetManagementObject<uint>(mo, "PriorityBase");
                    csp.PrivateBytes = GetManagementObject<uint>(mo, "PrivateBytes");
                    csp.ThreadCount = GetManagementObject<uint>(mo, "ThreadCount");
                    csp.Timestamp_Object = GetManagementObject<ulong>(mo, "Timestamp_Object");
                    csp.Timestamp_PerfTime = GetManagementObject<ulong>(mo, "Timestamp_PerfTime");
                    csp.Timestamp_Sys100NS = GetManagementObject<ulong>(mo, "Timestamp_Sys100NS");
                    csp.VirtualBytes = GetManagementObject<ulong>(mo, "VirtualBytes");
                    csp.VirtualBytesPeak = GetManagementObject<ulong>(mo, "VirtualBytesPeak");
                    csp.WorkingSet = GetManagementObject<ulong>(mo, "WorkingSet");
                    csp.WorkingSetPeak = GetManagementObject<ulong>(mo, "WorkingSetPeak");
                    
                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32PerfRawDataPerfProcProcess> Win32PerfRawDataPerfProcProcesses
        {
            get 
            {
                return GetAllPerfRawDataPerfProcProcess();
            }
        }
        public int Win32PerfRawDataPerfProcProcessesLength
        {
            get 
            {
                
                return GetAllPerfRawDataPerfProcProcess().Count; 
            }
        }
    }
}
