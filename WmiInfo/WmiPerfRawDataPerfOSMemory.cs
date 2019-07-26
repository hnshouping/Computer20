using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiPerfRawDataPerfOSMemory : WmiBase
    {
        private List<Win32PerfRawDataPerfOSMemory> ps;

        private string WSql = "SELECT * FROM Win32_PerfRawData_PerfOS_Memory";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiPerfRawDataPerfOSMemory()
            : base()
        {
            ps = new List<Win32PerfRawDataPerfOSMemory>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiPerfRawDataPerfOSMemory(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32PerfRawDataPerfOSMemory>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32PerfRawDataPerfOSMemory csp = new Win32PerfRawDataPerfOSMemory();
                if (mo != null)
                {
                    csp.AvailableBytes = GetManagementObject<ulong>(mo, "AvailableBytes");
                    csp.AvailableKBytes = GetManagementObject<ulong>(mo, "AvailableKBytes");
                    csp.AvailableMBytes = GetManagementObject<ulong>(mo, "AvailableMBytes");
                    csp.CacheBytes = GetManagementObject<ulong>(mo, "CacheBytes");
                    csp.CacheBytesPeak = GetManagementObject<ulong>(mo, "CacheBytesPeak");
                    csp.CacheFaultsPerSec = GetManagementObject<uint>(mo, "CacheFaultsPerSec");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CommitLimit = GetManagementObject<ulong>(mo, "CommitLimit");
                    csp.CommittedBytes = GetManagementObject<ulong>(mo, "CommittedBytes");
                    csp.DemandZeroFaultsPerSec = GetManagementObject<uint>(mo, "DemandZeroFaultsPerSec");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.FreeSystemPageTableEntries = GetManagementObject<uint>(mo, "FreeSystemPageTableEntries");
                    csp.Frequency_Object = GetManagementObject<ulong>(mo, "Frequency_Object");
                    csp.Frequency_PerfTime = GetManagementObject<ulong>(mo, "Frequency_PerfTime");
                    csp.Frequency_Sys100NS = GetManagementObject<ulong>(mo, "Frequency_Sys100NS");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.PageFaultsPerSec = GetManagementObject<uint>(mo, "PageFaultsPerSec");
                    csp.PageReadsPerSec = GetManagementObject<uint>(mo, "PageReadsPerSec");
                    csp.PagesInputPerSec = GetManagementObject<uint>(mo, "PagesInputPerSec");
                    csp.PagesOutputPerSec = GetManagementObject<uint>(mo, "PagesOutputPerSec");
                    csp.PagesPerSec = GetManagementObject<uint>(mo, "PagesPerSec");
                    csp.PageWritesPerSec = GetManagementObject<uint>(mo, "PageWritesPerSec");
                    csp.PercentCommittedBytesInUse = GetManagementObject<uint>(mo, "PercentCommittedBytesInUse");
                    csp.PercentCommittedBytesInUse_Base = GetManagementObject<uint>(mo, "PercentCommittedBytesInUse_Base");
                    csp.PoolNonpagedAllocs = GetManagementObject<uint>(mo, "PoolNonpagedAllocs");
                    csp.PoolNonpagedBytes = GetManagementObject<ulong>(mo, "PoolNonpagedBytes");
                    csp.PoolPagedAllocs = GetManagementObject<uint>(mo, "PoolPagedAllocs");
                    csp.PoolPagedBytes = GetManagementObject<ulong>(mo, "PoolPagedBytes");
                    csp.PoolPagedResidentBytes = GetManagementObject<ulong>(mo, "PoolPagedResidentBytes");
                    csp.SystemCacheResidentBytes = GetManagementObject<ulong>(mo, "SystemCacheResidentBytes");
                    csp.SystemCodeResidentBytes = GetManagementObject<ulong>(mo, "SystemCodeResidentBytes");
                    csp.SystemCodeTotalBytes = GetManagementObject<ulong>(mo, "SystemCodeTotalBytes");
                    csp.SystemDriverResidentBytes = GetManagementObject<ulong>(mo, "SystemDriverResidentBytes");
                    csp.SystemDriverTotalBytes = GetManagementObject<ulong>(mo, "SystemDriverTotalBytes");
                    csp.Timestamp_Object = GetManagementObject<ulong>(mo, "Timestamp_Object");
                    csp.Timestamp_PerfTime = GetManagementObject<ulong>(mo, "Timestamp_PerfTime");
                    csp.Timestamp_Sys100NS = GetManagementObject<ulong>(mo, "Timestamp_Sys100NS");
                    csp.TransitionFaultsPerSec = GetManagementObject<uint>(mo, "TransitionFaultsPerSec");
                    csp.WriteCopiesPerSec = GetManagementObject<uint>(mo, "WriteCopiesPerSec");


                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32PerfRawDataPerfOSMemory> Win32PerfRawDataPerfOSMemorys
        {
            get { return ps; }
        }
        public int Win32PerfRawDataPerfOSMemorysLength
        {
            get { return ps.Count ; }
        }
    }
}
