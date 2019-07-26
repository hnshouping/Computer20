using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
    public class WmiCDROMDrive : WmiBase
    {
        private List<Win32CDROMDrive> ps;
        private string WSql = "SELECT * FROM Win32_CDROMDrive";
        public WmiCDROMDrive()
            : base()
        {
            ps = new List<Win32CDROMDrive>();
            FillFloppyDriveInfo();
        }
        public WmiCDROMDrive(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32CDROMDrive>();
            FillFloppyDriveInfo();
        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32CDROMDrive csp = new Win32CDROMDrive();
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
                    csp.Drive = GetManagementObject<string>(mo, "Drive");
                    csp.DriveIntegrity = GetManagementObject<bool>(mo, "DriveIntegrity");
                    csp.ErrorCleared = GetManagementObject<bool>(mo, "ErrorCleared");
                    csp.ErrorDescription = GetManagementObject<string>(mo, "ErrorDescription");
                    csp.ErrorMethodology = GetManagementObject<string>(mo, "ErrorMethodology");
                    csp.FileSystemFlags = GetManagementObject<ushort>(mo, "FileSystemFlags");
                    csp.FileSystemFlagsEx = GetManagementObject<uint>(mo, "FileSystemFlagsEx");
                    csp.Id = GetManagementObject<string>(mo, "Id");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MaxBlockSize = GetManagementObject<ulong>(mo, "MaxBlockSize");
                    csp.MaximumComponentLength = GetManagementObject<uint>(mo, "MaximumComponentLength");
                    csp.MaxMediaSize = GetManagementObject<ulong>(mo, "MaxMediaSize");
                    csp.MediaLoaded = GetManagementObject<bool>(mo, "MediaLoaded");
                    csp.MediaType = GetManagementObject<string>(mo, "MediaType");
                    csp.MfrAssignedRevisionLevel = GetManagementObject<string>(mo, "MfrAssignedRevisionLevel");
                    csp.MinBlockSize = GetManagementObject<ulong>(mo, "MinBlockSize");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.NeedsCleaning = GetManagementObject<bool>(mo, "NeedsCleaning");
                    csp.NumberOfMediaSupported = GetManagementObject<bool>(mo, "NumberOfMediaSupported");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities =GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.RevisionLevel = GetManagementObject<string>(mo, "RevisionLevel");
                    csp.SCSIBus = GetManagementObject<uint>(mo, "SCSIBus");
                    csp.SCSILogicalUnit = GetManagementObject<ushort>(mo, "SCSILogicalUnit");
                    csp.SCSIPort = GetManagementObject<ushort>(mo, "SCSIPort");
                    csp.SCSITargetId = GetManagementObject<ushort>(mo, "SCSITargetId");
                    csp.Size = GetManagementObject<ulong>(mo, "Size");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    csp.TransferRate = GetManagementObject<double>(mo, "TransferRate");
                    csp.VolumeName = GetManagementObject<string>(mo, "VolumeName");
                    csp.VolumeSerialNumber = GetManagementObject<string>(mo, "VolumeSerialNumber");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32CDROMDrive> WmiCDROMDrives
        {
            get { return ps; }
        }
        public int WmiCDROMDrivesLength
        {
            get { return ps.Count; }
        }

    }
}
