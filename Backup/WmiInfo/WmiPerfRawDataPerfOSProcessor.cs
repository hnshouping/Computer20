using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiPerfRawDataPerfOSProcessor : WmiBase
    {
        private List<Win32PerfRawDataPerfOSProcessor> ps;

        private string WSql = "SELECT * FROM Win32_PerfRawData_PerfOS_Processor";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiPerfRawDataPerfOSProcessor()
            : base()
        {
            ps = new List<Win32PerfRawDataPerfOSProcessor>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiPerfRawDataPerfOSProcessor(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32PerfRawDataPerfOSProcessor>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32PerfRawDataPerfOSProcessor csp = new Win32PerfRawDataPerfOSProcessor();
                if (mo != null)
                {
                    csp.C1TransitionsPerSec = GetManagementObject<ulong>(mo, "C1TransitionsPerSec");
                    csp.C2TransitionsPerSec = GetManagementObject<ulong>(mo, "C2TransitionsPerSec");
                    csp.C3TransitionsPerSec = GetManagementObject<ulong>(mo, "C3TransitionsPerSec");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DPCRate = GetManagementObject<uint>(mo, "DPCRate");
                    csp.DPCsQueuedPerSec = GetManagementObject<uint>(mo, "DPCsQueuedPerSec");
                    csp.Frequency_Object = GetManagementObject<ulong>(mo, "Frequency_Object");
                    csp.Frequency_PerfTime = GetManagementObject<ulong>(mo, "Frequency_PerfTime");
                    csp.Frequency_Sys100NS = GetManagementObject<ulong>(mo, "Frequency_Sys100NS");
                    csp.InterruptsPerSec = GetManagementObject<uint>(mo, "InterruptsPerSec");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.PercentC1Time = GetManagementObject<ulong>(mo, "PercentC1Time");
                    csp.PercentC2Time = GetManagementObject<ulong>(mo, "PercentC2Time");
                    csp.PercentC3Time = GetManagementObject<ulong>(mo, "PercentC3Time");
                    csp.PercentDPCTime = GetManagementObject<ulong>(mo, "PercentDPCTime");
                    csp.PercentIdleTime = GetManagementObject<ulong>(mo, "PercentIdleTime");
                    csp.PercentInterruptTime = GetManagementObject<ulong>(mo, "PercentInterruptTime");
                    csp.PercentPrivilegedTime = GetManagementObject<ulong>(mo, "PercentPrivilegedTime");
                    csp.PercentProcessorTime = GetManagementObject<ulong>(mo, "PercentProcessorTime");
                    csp.PercentUserTime = GetManagementObject<ulong>(mo, "PercentUserTime");
                    csp.Timestamp_Object = GetManagementObject<ulong>(mo, "Timestamp_Object");
                    csp.Timestamp_PerfTime = GetManagementObject<ulong>(mo, "Timestamp_PerfTime");
                    csp.Timestamp_Sys100NS = GetManagementObject<ulong>(mo, "Timestamp_Sys100NS");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32PerfRawDataPerfOSProcessor> Win32PerfRawDataPerfOSProcessors
        {
            get { return ps; }
        }
        public int Win32PerfRawDataPerfOSProcessorsLength
        {
            get { return ps.Count; }
        }
    }
}
