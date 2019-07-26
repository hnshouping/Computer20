using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiPhysicalMemory : WmiBase
    {
        private List<Win32PhysicalMemory> ps;

        private string WSql = "SELECT * FROM Win32_PhysicalMemory";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiPhysicalMemory()
            : base()
        {
            ps = new List<Win32PhysicalMemory>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiPhysicalMemory(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32PhysicalMemory>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32PhysicalMemory csp = new Win32PhysicalMemory();
                if (mo != null)
                {
                    csp.BankLabel = GetManagementObject<string>(mo, "BankLabel");
                    csp.Capacity = GetManagementObject<ulong>(mo, "Capacity");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.DataWidth = GetManagementObject<ushort>(mo, "DataWidth");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DeviceLocator = GetManagementObject<string>(mo, "DeviceLocator");
                    csp.FormFactor = GetManagementObject<ushort>(mo, "FormFactor");
                    csp.HotSwappable = GetManagementObject<bool>(mo, "HotSwappable");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.InterleaveDataDepth = GetManagementObject<ushort>(mo, "InterleaveDataDepth");
                    csp.InterleavePosition = GetManagementObject<uint>(mo, "InterleavePosition");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MemoryType = GetManagementObject<ushort>(mo, "MemoryType");
                    csp.Model = GetManagementObject<string>(mo, "Model");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.OtherIdentifyingInfo = GetManagementObject<string>(mo, "OtherIdentifyingInfo");
                    csp.PartNumber = GetManagementObject<string>(mo, "PartNumber");
                    csp.PositionInRow = GetManagementObject<uint>(mo, "PositionInRow");
                    csp.PoweredOn = GetManagementObject<bool>(mo, "PoweredOn");
                    csp.Removable = GetManagementObject<bool>(mo, "Removable");
                    csp.Replaceable = GetManagementObject<bool>(mo, "Replaceable");
                    csp.SerialNumber = GetManagementObject<string>(mo, "SerialNumber");
                    csp.SKU = GetManagementObject<string>(mo, "SKU");
                    csp.Speed = GetManagementObject<uint>(mo, "Speed");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.Tag = GetManagementObject<string>(mo, "Tag");
                    csp.TotalWidth = GetManagementObject<ushort>(mo, "TotalWidth");
                    csp.Version = GetManagementObject<string>(mo, "Version");
                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32PhysicalMemory> Win32PhysicalMemorys
        {
            get { return ps; }
        }
        public int Win32PhysicalMemorysLength
        {
            get { return ps.Count; }
        }

    }
}
