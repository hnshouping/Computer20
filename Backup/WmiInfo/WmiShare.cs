using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiShare : WmiBase
    {
        private List<Win32Share> ps;

        private string WSql = "SELECT * FROM Win32_Share";

        /// <summary>
        /// Ĭ�ϵĹ��캯���Ǳ�����
        /// </summary>
        public WmiShare()
            : base()
        {
            ps = new List<Win32Share>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// ��֪IP���û���������Ĺ��캯��
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">�û���</param>
        /// <param name="password">����</param>
        public WmiShare(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32Share>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32Share csp = new Win32Share();

                if (mo != null)
                {
                    csp.AccessMask = GetManagementObject<uint>(mo, "AccessMask");
                    csp.AllowMaximum = GetManagementObject<bool>(mo, "AllowMaximum");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.MaximumAllowed = GetManagementObject<uint>(mo, "MaximumAllowed");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.Path = GetManagementObject<string>(mo, "Path");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.Type = GetManagementObject<uint>(mo, "Type");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32Share> Win32Shares
        {
            get { return ps; }
        }
        public int Win32SharesLength
        {
            get { return ps.Count; }
        }
    }
}
