using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiVideoController : WmiBase
    {
        private List<Win32VideoController> ps;

        private string WSql = "SELECT * FROM Win32_VideoController";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiVideoController()
            : base()
        {
            ps = new List<Win32VideoController>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiVideoController(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32VideoController>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32VideoController csp = new Win32VideoController();

                if (mo != null)
                {
                    csp.AcceleratorCapabilities = GetManagementObject<ushort[]>(mo, "AcceleratorCapabilities");
                    csp.AdapterCompatibility = GetManagementObject<string>(mo, "AdapterCompatibility");
                    csp.AdapterDACType = GetManagementObject<string>(mo, "AdapterDACType");
                    csp.AdapterRAM = GetManagementObject<uint>(mo, "AdapterRAM");
                    csp.Availability = GetManagementObject<ushort>(mo, "Availability");
                    csp.CapabilityDescriptions = GetManagementObject<string[]>(mo, "CapabilityDescriptions");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.ColorTableEntries = GetManagementObject<uint>(mo, "ColorTableEntries");
                    csp.ConfigManagerErrorCode = GetManagementObject<uint>(mo, "ConfigManagerErrorCode");
                    csp.ConfigManagerUserConfig = GetManagementObject<bool>(mo, "ConfigManagerUserConfig");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.CurrentBitsPerPixel = GetManagementObject<uint>(mo, "CurrentBitsPerPixel");
                    csp.CurrentHorizontalResolution = GetManagementObject<uint>(mo, "CurrentHorizontalResolution");
                    csp.CurrentNumberOfColors = GetManagementObject<ulong>(mo, "CurrentNumberOfColors");
                    csp.CurrentNumberOfColumns = GetManagementObject<uint>(mo, "CurrentNumberOfColumns");
                    csp.CurrentNumberOfRows = GetManagementObject<uint>(mo, "CurrentNumberOfRows");
                    csp.CurrentRefreshRate = GetManagementObject<uint>(mo, "CurrentRefreshRate");
                    csp.CurrentScanMode = GetManagementObject<ushort>(mo, "CurrentScanMode");
                    csp.CurrentVerticalResolution = GetManagementObject<uint>(mo, "CurrentVerticalResolution");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DeviceID = GetManagementObject<string>(mo, "DeviceID");
                    csp.DeviceSpecificPens = GetManagementObject<uint>(mo, "DeviceSpecificPens");
                    csp.DitherType = GetManagementObject<uint>(mo, "DitherType");
                    csp.Cim_DriverDate = GetManagementObject<string>(mo, "DriverDate");
                    csp.DriverVersion = GetManagementObject<string>(mo, "DriverVersion");
                    csp.ErrorCleared = GetManagementObject<bool>(mo, "ErrorCleared");
                    csp.ErrorDescription = GetManagementObject<string>(mo, "ErrorDescription");
                    csp.ICMIntent = GetManagementObject<uint>(mo, "ICMIntent");
                    csp.ICMMethod = GetManagementObject<uint>(mo, "ICMMethod");
                    csp.InfFilename = GetManagementObject<string>(mo, "InfFilename");
                    csp.InfSection = GetManagementObject<string>(mo, "InfSection");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.InstalledDisplayDrivers = GetManagementObject<string>(mo, "InstalledDisplayDrivers");
                    csp.LastErrorCode = GetManagementObject<uint>(mo, "LastErrorCode");
                    csp.MaxMemorySupported = GetManagementObject<uint>(mo, "MaxMemorySupported");
                    csp.MaxNumberControlled = GetManagementObject<uint>(mo, "MaxNumberControlled");
                    csp.MaxRefreshRate = GetManagementObject<uint>(mo, "MaxRefreshRate");
                    csp.MinRefreshRate = GetManagementObject<uint>(mo, "MinRefreshRate");
                    csp.Monochrome = GetManagementObject<bool>(mo, "Monochrome");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.NumberOfColorPlanes = GetManagementObject<ushort>(mo, "NumberOfColorPlanes");
                    csp.NumberOfVideoPages = GetManagementObject<uint>(mo, "NumberOfVideoPages");
                    csp.PNPDeviceID = GetManagementObject<string>(mo, "PNPDeviceID");
                    csp.PowerManagementCapabilities = GetManagementObject<ushort[]>(mo, "PowerManagementCapabilities");
                    csp.PowerManagementSupported = GetManagementObject<bool>(mo, "PowerManagementSupported");
                    csp.ProtocolSupported = GetManagementObject<ushort>(mo, "ProtocolSupported");
                    csp.ReservedSystemPaletteEntries = GetManagementObject<uint>(mo, "ReservedSystemPaletteEntries");
                    csp.SpecificationVersion = GetManagementObject<uint>(mo, "SpecificationVersion");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.StatusInfo = GetManagementObject<ushort>(mo, "StatusInfo");
                    csp.SystemCreationClassName = GetManagementObject<string>(mo, "SystemCreationClassName");
                    csp.SystemName = GetManagementObject<string>(mo, "SystemName");
                    csp.SystemPaletteEntries = GetManagementObject<uint>(mo, "SystemPaletteEntries");
                    csp.Cim_TimeOfLastReset = GetManagementObject<string>(mo, "TimeOfLastReset");
                    csp.VideoArchitecture = GetManagementObject<ushort>(mo, "VideoArchitecture");
                    csp.VideoMemoryType = GetManagementObject<ushort>(mo, "VideoMemoryType");
                    csp.VideoMode = GetManagementObject<ushort>(mo, "VideoMode");
                    csp.VideoModeDescription = GetManagementObject<string>(mo, "VideoModeDescription");
                    csp.VideoProcessor = GetManagementObject<string>(mo, "VideoProcessor");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32VideoController> Win32VideoControlleres
        {
            get { return ps; }
        }
        public int Win32VideoControlleresLength
        {
            get { return ps.Count; }
        }
    }
}
