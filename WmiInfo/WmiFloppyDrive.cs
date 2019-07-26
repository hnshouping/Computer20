using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
    public class WmiFloppyDrive : WmiBase
    {
        private List<Win32FloppyDrive> ps;

        private string WSql = "SELECT * FROM Win32_FloppyDrive";

        /// <summary>
        /// Ĭ�ϵĹ��캯���Ǳ�����
        /// </summary>
        public WmiFloppyDrive()
            : base()
        {
            ps = new List<Win32FloppyDrive>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// ��֪IP���û���������Ĺ��캯��
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">�û���</param>
        /// <param name="password">����</param>
        public WmiFloppyDrive(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32FloppyDrive>();
            FillFloppyDriveInfo();

        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32FloppyDrive csp = new Win32FloppyDrive();
                if (mo != null)
                {
                    csp.Availability =GetManagementObject<ushort>(mo, "Availability");
                    csp.Capabilities = GetManagementObject<ushort[]>(mo, "Capabilities");
                    csp.CapabilityDescriptions = GetManagementObject<string[]>(mo, "CapabilityDescriptions");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CompressionMethod = GetManagementObject<string>(mo, "CompressionMethod");
                    csp.ConfigManagerErrorCode = GetManagementObject<uint>(mo, "ConfigManagerErrorCode");
                    csp.ConfigManagerUserConfig = GetManagementObject<bool>(mo, "ConfigManagerUserConfig");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.DefaultBlockSize = GetManagementObject<ulong>(mo, "DefaultBlockSize");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DeviceID = GetManagementObject<string>(mo, "DeviceID");
                    csp.ErrorCleared = GetManagementObject<bool>(mo, "ErrorCleared");
                    csp.ErrorDescription = GetManagementObject<string>(mo, "ErrorDescription");
                    csp.ErrorMethodology = GetManagementObject<string>(mo, "ErrorMethodology");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MaxBlockSize = GetManagementObject<ulong>(mo, "MaxBlockSize");
                    csp.MaxMediaSize = GetManagementObject<ulong>(mo, "MaxMediaSize");
                    csp.MinBlockSize = GetManagementObject<ulong>(mo, "MinBlockSize");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.NeedsCleaning = GetManagementObject<bool>(mo, "NeedsCleaning");
                    csp.NumberOfMediaSupported = GetManagementObject<bool>(mo, "NumberOfMediaSupported");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities = GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32FloppyDrive> Win32FloppyDrives
        {
            get { return ps; }
        }
        public int Win32FloppyDrivesLength
        {
            get { return ps.Count; }
        }
    }
}
