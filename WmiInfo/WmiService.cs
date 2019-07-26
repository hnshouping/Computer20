using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiService : WmiBase
    {
        private List<Win32Service> ps;

        private string WSql = "SELECT * FROM Win32_Service";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiService()
            : base()
        {
            ps = new List<Win32Service>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiService(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32Service>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32Service csp = new Win32Service();

                if (mo != null)
                {
                    csp.AcceptPause = GetManagementObject<bool>(mo, "AcceptPause");
                    csp.AcceptStop = GetManagementObject<bool>(mo, "AcceptStop");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CheckPoint = GetManagementObject<uint>(mo, "CheckPoint");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DesktopInteract = GetManagementObject<bool>(mo, "DesktopInteract");
                    csp.DisplayName = GetManagementObject<string>(mo, "DisplayName");
                    csp.ErrorControl = GetManagementObject<string>(mo, "ErrorControl");
                    csp.ExitCode = GetManagementObject<uint>(mo, "ExitCode");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.PathName = GetManagementObject<string>(mo, "PathName");
                    csp.ProcessId = GetManagementObject<uint>(mo, "ProcessId");
                    csp.ServiceSpecificExitCode = GetManagementObject<uint>(mo, "ServiceSpecificExitCode");
                    csp.ServiceType = GetManagementObject<string>(mo, "ServiceType");
                    csp.Started = GetManagementObject<bool>(mo, "Started");
                    csp.StartMode = GetManagementObject<string>(mo, "StartMode");
                    csp.StartName = GetManagementObject<string>(mo, "StartName");
                    csp.State = GetManagementObject<string>(mo, "State");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    csp.TagId = GetManagementObject<uint>(mo, "TagId");
                    csp.WaitHint = GetManagementObject<uint>(mo, "WaitHint");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32Service> Win32Services
        {
            get { return ps; }
        }
        public int Win32ServicesLength
        {
            get { return ps.Count; }
        }

    }
}
