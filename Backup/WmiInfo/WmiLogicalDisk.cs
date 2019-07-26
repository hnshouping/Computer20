using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
    public class WmiLogicalDisk : WmiBase
    {
        private List<Win32LogicalDisk> ps;

        private string WSql = "SELECT * FROM Win32_LogicalDisk";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiLogicalDisk()
            : base()
        {
            ps = new List<Win32LogicalDisk>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiLogicalDisk(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32LogicalDisk>();
            FillFloppyDriveInfo();

        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32LogicalDisk csp = new Win32LogicalDisk();
                if (mo != null)
                {
                    csp.Access = GetManagementObject<ushort>(mo, "Access");
                    csp.Availability = GetManagementObject<ushort>(mo, "Availability");
                    csp.BlockSize = GetManagementObject<ulong>(mo, "BlockSize");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.Compressed = GetManagementObject<bool>(mo, "Compressed");
                    csp.ConfigManagerErrorCode = GetManagementObject<uint>(mo, "ConfigManagerErrorCode");
                    csp.ConfigManagerUserConfig = GetManagementObject<bool>(mo, "ConfigManagerUserConfig");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DeviceID = GetManagementObject<string>(mo, "DeviceID");
                    csp.DriveType = GetManagementObject<uint>(mo, "DriveType");
                    csp.ErrorCleared = GetManagementObject<bool>(mo, "ErrorCleared");
                    csp.ErrorDescription = GetManagementObject<string>(mo, "ErrorDescription");
                    csp.ErrorMethodology = GetManagementObject<string>(mo, "ErrorMethodology");
                    csp.FileSystem = GetManagementObject<string>(mo, "FileSystem");
                    csp.FreeSpace = GetManagementObject<ulong>(mo, "FreeSpace");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.MaximumComponentLength = GetManagementObject<uint>(mo, "MaximumComponentLength");
                    csp.MediaType = GetManagementObject<uint>(mo, "MediaType");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.NumberOfBlocks = GetManagementObject<ulong>(mo, "NumberOfBlocks");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities = GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.ProviderName = GetManagementObject<string>(mo, "ProviderName");
                    csp.Purpose = GetManagementObject<string>(mo, "Purpose");
                    csp.QuotasDisabled = GetManagementObject<bool>(mo, "QuotasDisabled");
                    csp.QuotasIncomplete = GetManagementObject<bool>(mo, "QuotasIncomplete");
                    csp.QuotasRebuilding = GetManagementObject<bool>(mo, "QuotasRebuilding");
                    csp.Size = GetManagementObject<ulong>(mo, "Size");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.SupportsDiskQuotas = GetManagementObject<bool>(mo, "SupportsDiskQuotas");
                    csp.SupportsFileBasedCompression = GetManagementObject<bool>(mo, "SupportsFileBasedCompression");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    csp.VolumeDirty = GetManagementObject<bool>(mo, "VolumeDirty");
                    csp.VolumeName = GetManagementObject<string>(mo, "VolumeName");
                    csp.VolumeSerialNumber = GetManagementObject<string>(mo, "VolumeSerialNumber");


                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32LogicalDisk> Win32LogicalDisks
        {
            get { return ps; }
        }
        public int Win32LogicalDisksLength
        {
            get { return ps.Count; }
        }
    }
}
