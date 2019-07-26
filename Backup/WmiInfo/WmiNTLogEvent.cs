using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiNTLogEvent : WmiBase
    {
        private List<Win32NTLogEvent> ps;

        private string WSql = "SELECT * FROM Win32_NTLogEvent";
        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiNTLogEvent()
            : base()
        {
            ps = new List<Win32NTLogEvent>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiNTLogEvent(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32NTLogEvent>();
            FillFloppyDriveInfo();

        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32NTLogEvent csp = new Win32NTLogEvent();
                if (mo != null)
                {
                    csp.Category = GetManagementObject<ushort>(mo, "Category");
                    csp.CategoryString = GetManagementObject<string>(mo, "CategoryString");
                    csp.ComputerName = GetManagementObject<string>(mo, "ComputerName");
                    csp.Data = GetManagementObject<byte[]>(mo, "Data");
                    csp.EventCode = GetManagementObject<ushort>(mo, "EventCode");
                    csp.EventIdentifier = GetManagementObject<uint>(mo, "EventIdentifier");
                    csp.EventType = GetManagementObject<byte>(mo, "EventType");
                    csp.InsertionStrings = GetManagementObject<string[]>(mo, "InsertionStrings");
                    csp.Logfile = GetManagementObject<string>(mo, "Logfile");
                    csp.Message = GetManagementObject<string>(mo, "Message");
                    csp.RecordNumber = GetManagementObject<uint>(mo, "RecordNumber");
                    csp.SourceName = GetManagementObject<string>(mo, "SourceName");
                    csp.Cim_TimeGenerated = GetManagementObject<string>(mo, "TimeGenerated");
                    csp.Cim_TimeWritten = GetManagementObject<string>(mo, "TimeWritten");
                    csp.Type = GetManagementObject<string>(mo, "Type");
                    csp.User = GetManagementObject<string>(mo, "User");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32NTLogEvent> Win32NTLogEvents
        {
            get { return ps; }
        }
        public int Win32NTLogEventsLength
        {
            get { return ps.Count; }
        }
    }
}
