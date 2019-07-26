using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
    public class WmiGroup : WmiBase
    {
        private List<Win32Group> ps;

        private string WSql = "SELECT * FROM Win32_Group";
        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiGroup()
            : base()
        {
            ps = new List<Win32Group>();
            FillFloppyDriveInfo();
        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiGroup(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32Group>();
            FillFloppyDriveInfo();
        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc=this.GetAllInfo(this.WSql);
			foreach ( ManagementObject mo in moc)
			{
				Win32Group csp=new Win32Group(wi);
				
				if(mo!=null)
				{	
					csp.Caption=GetManagementObject<string>(mo,"Caption");
					csp.Description=GetManagementObject<string>(mo,"Description");
					csp.Domain=GetManagementObject<string>(mo,"Domain");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
					csp.LocalAccount=GetManagementObject<bool>(mo,"LocalAccount");
					csp.Name=GetManagementObject<string>(mo,"Name");
					csp.SID=GetManagementObject<string>(mo,"SID");
                    csp.SIDType = GetManagementObject<byte>(mo, "SIDType");
					csp.Status=GetManagementObject<string>(mo,"Status");

					ps.Add(csp);
				}
			}
			moc.Dispose();
        }
        public List<Win32Group> Win32Groups
        {
            get { return ps; }
        }
        public int Win32GroupsLength
        {
            get { return ps.Count; }
        }
    }
}

