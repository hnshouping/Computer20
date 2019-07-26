using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiProcessor : WmiBase
    {
        private List<Win32Processor> ps;

        private string WSql = "SELECT * FROM Win32_Processor";
        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiProcessor()
            : base()
        {
            ps = new List<Win32Processor>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiProcessor(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32Processor>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32Processor csp = new Win32Processor();
                if (mo != null)
                {
                    csp.AddressWidth = GetManagementObject<ushort>(mo, "AddressWidth");
                    csp.Architecture = GetManagementObject<ushort>(mo, "Architecture");
                    csp.Availability = GetManagementObject<ushort>(mo, "Availability");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.ConfigManagerErrorCode = GetManagementObject<uint>(mo, "ConfigManagerErrorCode");
                    csp.ConfigManagerUserConfig = GetManagementObject<bool>(mo, "ConfigManagerUserConfig");
                    csp.CpuStatus = GetManagementObject<ushort>(mo, "CpuStatus");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.CurrentClockSpeed = GetManagementObject<uint>(mo, "CurrentClockSpeed");
                    csp.CurrentVoltage = GetManagementObject<ushort>(mo, "CurrentVoltage");
                    csp.DataWidth = GetManagementObject<ushort>(mo, "DataWidth");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DeviceID = GetManagementObject<string>(mo, "DeviceID");
                    csp.ErrorCleared = GetManagementObject<bool>(mo, "ErrorCleared");
                    csp.ErrorDescription = GetManagementObject<string>(mo, "ErrorDescription");
                    csp.ExtClock = GetManagementObject<uint>(mo, "ExtClock");
                    csp.Family = GetManagementObject<ushort>(mo, "Family");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.L2CacheSize = GetManagementObject<uint>(mo, "L2CacheSize");
                    csp.L2CacheSpeed = GetManagementObject<uint>(mo, "L2CacheSpeed");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.Level = GetManagementObject<ushort>(mo, "Level");
                    csp.LoadPercentage = GetManagementObject<ushort>(mo, "LoadPercentage");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MaxClockSpeed = GetManagementObject<uint>(mo, "MaxClockSpeed");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.OtherFamilyDescription = GetManagementObject<string>(mo, "OtherFamilyDescription");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities = GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.ProcessorId = GetManagementObject<string>(mo, "ProcessorId");
                    csp.ProcessorType = GetManagementObject<ushort>(mo, "ProcessorType");
                    csp.Revision = GetManagementObject<ushort>(mo, "Revision");
                    csp.Role = GetManagementObject<string>(mo, "Role");
                    csp.SocketDesignation = GetManagementObject<string>(mo, "SocketDesignation");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.Stepping = GetManagementObject<string>(mo, "Stepping");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    csp.UniqueId = GetManagementObject<string>(mo, "UniqueId");
                    csp.UpgradeMethod = GetManagementObject<ushort>(mo, "UpgradeMethod");
                    csp.Version = GetManagementObject<string>(mo, "Version");
                    csp.VoltageCaps = GetManagementObject<uint>(mo, "VoltageCaps");


                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32Processor> Win32Processores
        {
            get { return ps; }
        }
        public int Win32ProcessoresLength
        {
            get { return ps.Count; }
        }

    }
}
