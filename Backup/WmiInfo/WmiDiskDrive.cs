using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
    public class WmiDiskDrive : WmiBase
    {
        private List<Win32DiskDrive> ps;

        private string WSql = "SELECT * FROM Win32_DiskDrive";

        public WmiDiskDrive()
            : base()
        {
            ps = new List<Win32DiskDrive>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiDiskDrive(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32DiskDrive>();
            FillFloppyDriveInfo();

        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32DiskDrive csp = new Win32DiskDrive();
                if (mo != null)
                {
                    csp.Availability = GetManagementObject<ushort>(mo, "Availability");
                    csp.BytesPerSector = GetManagementObject<uint>(mo, "BytesPerSector");
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
                    csp.Index = GetManagementObject<uint>(mo, "Index");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.InterfaceType = GetManagementObject<string>(mo, "InterfaceType");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MaxBlockSize = GetManagementObject<ulong>(mo, "MaxBlockSize");
                    csp.MaxMediaSize = GetManagementObject<ulong>(mo, "MaxMediaSize");
                    csp.MediaLoaded = GetManagementObject<bool>(mo, "MediaLoaded");
                    csp.MediaType = GetManagementObject<string>(mo, "MediaType");
                    csp.MinBlockSize = GetManagementObject<ulong>(mo, "MinBlockSize");
                    csp.Model = GetManagementObject<string>(mo, "Model");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.NeedsCleaning = GetManagementObject<bool>(mo, "NeedsCleaning");
                    csp.NumberOfMediaSupported = GetManagementObject<bool>(mo, "NumberOfMediaSupported");
                    csp.Partitions = GetManagementObject<uint>(mo, "Partitions");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities = GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.SCSIBus = GetManagementObject<uint>(mo, "SCSIBus");
                    csp.SCSILogicalUnit = GetManagementObject<ushort>(mo, "SCSILogicalUnit");
                    csp.SCSIPort = GetManagementObject<ushort>(mo, "SCSIPort");
                    csp.SCSITargetId = GetManagementObject<ushort>(mo, "SCSITargetId");
                    csp.SectorsPerTrack = GetManagementObject<uint>(mo, "SectorsPerTrack");
                    csp.Signature = GetManagementObject<uint>(mo, "Signature");
                    csp.Size = GetManagementObject<ulong>(mo, "Size");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    csp.TotalCylinders = GetManagementObject<ulong>(mo, "TotalCylinders");
                    csp.TotalHeads = GetManagementObject<uint>(mo, "TotalHeads");
                    csp.TotalSectors = GetManagementObject<ulong>(mo, "TotalSectors");
                    csp.TotalTracks = GetManagementObject<ulong>(mo, "TotalTracks");
                    csp.TracksPerCylinder = GetManagementObject<uint>(mo, "TracksPerCylinder");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32DiskDrive> Win32DiskDrives
        {
            get { return ps; }
        }
        public int Win32DiskDrivesLength
        {
            get { return ps.Count; }
        }
    }
}
