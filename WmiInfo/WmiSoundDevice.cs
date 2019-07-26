using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiSoundDevice : WmiBase
    {
        private List<Win32SoundDevice> ps;

        private string WSql = "SELECT * FROM Win32_SoundDevice";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiSoundDevice()
            : base()
        {
            ps = new List<Win32SoundDevice>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiSoundDevice(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32SoundDevice>();
            FillFloppyDriveInfo();

        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32SoundDevice csp = new Win32SoundDevice();

                if (mo != null)
                {
                    csp.Availability = GetManagementObject<ushort>(mo, "Availability");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.ConfigManagerErrorCode = GetManagementObject<uint>(mo, "ConfigManagerErrorCode");
                    csp.ConfigManagerUserConfig = GetManagementObject<bool>(mo, "ConfigManagerUserConfig");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DeviceID = GetManagementObject<string>(mo, "DeviceID");
                    csp.DMABufferSize = GetManagementObject<ushort>(mo, "DMABufferSize");
                    csp.ErrorCleared = GetManagementObject<bool>(mo, "ErrorCleared");
                    csp.ErrorDescription = GetManagementObject<string>(mo, "ErrorDescription");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MPU401Address = GetManagementObject<uint>(mo, "MPU401Address");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities = GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.ProductName = GetManagementObject<string>(mo, "ProductName");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32SoundDevice> Win32SoundDevices
        {
            get { return ps; }
        }
        public int Win32SoundDevicesLength
        {
            get { return ps.Count; }
        }

    }
}
