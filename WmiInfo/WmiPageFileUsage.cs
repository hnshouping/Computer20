using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
     class WmiPageFileUsage : WmiBase
    {
        private List<Win32PageFileUsage> ps;

        private string WSql = "select * from Win32_PageFileUsage";

        public WmiPageFileUsage()
            : base()
        {
            ps = new List<Win32PageFileUsage>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiPageFileUsage(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32PageFileUsage>();
            FillFloppyDriveInfo();
        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32PageFileUsage csp= new Win32PageFileUsage();
                if (mo != null)
                {
                    csp.AllocatedBaseSize = GetManagementObject<uint>(mo, "AllocatedBaseSize");
                    csp.Caption = GetManagementObject<string>(mo, "Caption").ToString();
                    csp.CurrentUsage = GetManagementObject<uint>(mo, "CurrentUsage");
                    csp.Description = GetManagementObject<string>(mo, "Description").ToString();
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate").ToString();
                    csp.Name = GetManagementObject<string>(mo, "Name").ToString();
                    csp.PeakUsage = GetManagementObject<uint>(mo, "PeakUsage");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    ps.Add(csp);
                }                
            }
            moc.Dispose();
        }
        public List<Win32PageFileUsage> Win32PageFileUsages
        {
            get { return ps; }
        }
        public int Win32PageFileUsagesLength
        {
            get { return ps.Count; }
        }
        
    }
}
