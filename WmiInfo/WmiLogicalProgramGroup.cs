using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiLogicalProgramGroup : WmiBase
    {
        private List<Win32LogicalProgramGroup> ps;

        private string WSql = "SELECT * FROM Win32_LogicalProgramGroup";
        public WmiLogicalProgramGroup()
            : base()
        {
            ps = new List<Win32LogicalProgramGroup>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// ��֪IP���û���������Ĺ��캯��
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">�û���</param>
        /// <param name="password">����</param>
        public WmiLogicalProgramGroup(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32LogicalProgramGroup>();
            FillFloppyDriveInfo();

        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32LogicalProgramGroup csp = new Win32LogicalProgramGroup();
                if (mo != null)
                {
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.GroupName = GetManagementObject<string>(mo, "GroupName");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.UserName = GetManagementObject<string>(mo, "UserName");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32LogicalProgramGroup> Win32LogicalProgramGroups
        {
            get { return ps; }
        }
        public int Win32LogicalProgramGroupsLength
        {
            get { return ps.Count; }
        }
    }
}
