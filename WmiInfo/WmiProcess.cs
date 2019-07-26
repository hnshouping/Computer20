using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiProcess : WmiBase
    {
        private List<Win32Process> ps;

        private string WSql = "SELECT * FROM Win32_Process";


        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiProcess()
            : base()
        {
            ps = new List<Win32Process>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiProcess(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32Process>();
            FillFloppyDriveInfo();

        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32Process csp = new Win32Process();

                if (mo != null)
                {
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CommandLine = GetManagementObject<string>(mo, "CommandLine");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.Cim_CreationDate = GetManagementObject<string>(mo, "CreationDate");
                    csp.CSCreationClassName = GetManagementObject<string>(mo, "CSCreationClassName");
                    csp.CSName = GetManagementObject<string>(mo, "CSName");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.ExecutablePath = GetManagementObject<string>(mo, "ExecutablePath");
                    csp.ExecutionState = GetManagementObject<ushort>(mo, "ExecutionState");
                    csp.Handle = GetManagementObject<string>(mo, "Handle");
                    csp.HandleCount = GetManagementObject<uint>(mo, "HandleCount");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.KernelModeTime = GetManagementObject<ulong>(mo, "KernelModeTime");
                    csp.MaximumWorkingSetSize = GetManagementObject<uint>(mo, "MaximumWorkingSetSize");
                    csp.MinimumWorkingSetSize = GetManagementObject<uint>(mo, "MinimumWorkingSetSize");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.OSCreationClassName = GetManagementObject<string>(mo, "OSCreationClassName");
                    csp.OSName = GetManagementObject<string>(mo, "OSName");
                    csp.OtherOperationCount = GetManagementObject<ulong>(mo, "OtherOperationCount");
                    csp.OtherTransferCount = GetManagementObject<ulong>(mo, "OtherTransferCount");
                    csp.PageFaults = GetManagementObject<uint>(mo, "PageFaults");
                    csp.PageFileUsage = GetManagementObject<uint>(mo, "PageFileUsage");
                    csp.ParentProcessId = GetManagementObject<uint>(mo, "ParentProcessId");
                    csp.PeakPageFileUsage = GetManagementObject<uint>(mo, "PeakPageFileUsage");
                    csp.PeakVirtualSize = GetManagementObject<ulong>(mo, "PeakVirtualSize");
                    csp.PeakWorkingSetSize = GetManagementObject<uint>(mo, "PeakWorkingSetSize");
                    csp.Priority = GetManagementObject<uint>(mo, "Priority");
                    csp.PrivatePageCount = GetManagementObject<ulong>(mo, "PrivatePageCount");
                    csp.ProcessId = GetManagementObject<uint>(mo, "ProcessId");
                    csp.QuotaNonPagedPoolUsage = GetManagementObject<uint>(mo, "QuotaNonPagedPoolUsage");
                    csp.QuotaPagedPoolUsage = GetManagementObject<uint>(mo, "QuotaPagedPoolUsage");
                    csp.QuotaPeakPagedPoolUsage = GetManagementObject<uint>(mo, "QuotaPeakPagedPoolUsage");
                    csp.QuotaPeakNonPagedPoolUsage = GetManagementObject<uint>(mo, "QuotaPeakNonPagedPoolUsage");
                    csp.ReadOperationCount = GetManagementObject<ulong>(mo, "ReadOperationCount");
                    csp.ReadTransferCount = GetManagementObject<ulong>(mo, "ReadTransferCount");
                    csp.SessionId = GetManagementObject<uint>(mo, "SessionId");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.Cim_TerminationDate = GetManagementObject<string>(mo, "TerminationDate");
                    csp.ThreadCount = GetManagementObject<uint>(mo, "ThreadCount");
                    csp.UserModeTime = GetManagementObject<ulong>(mo, "UserModeTime");
                    csp.VirtualSize = GetManagementObject<ulong>(mo, "VirtualSize");
                    csp.WindowsVersion = GetManagementObject<string>(mo, "WindowsVersion");
                    csp.WorkingSetSize = GetManagementObject<ulong>(mo, "WorkingSetSize");
                    csp.WriteOperationCount = GetManagementObject<ulong>(mo, "WriteOperationCount");
                    csp.WriteTransferCount = GetManagementObject<ulong>(mo, "WriteTransferCount");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32Process> Win32Processes
        {
            get { return ps; }
        }
        public int Win32ProcessesLength
        {
            get { return ps.Count; }
        }

    }
}
