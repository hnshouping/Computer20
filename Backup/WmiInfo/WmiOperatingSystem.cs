using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiOperatingSystem : WmiBase
    {
        private List<Win32OperatingSystem> ps;

        private string WSql = "SELECT * FROM Win32_OperatingSystem";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiOperatingSystem()
            : base()
        {
            ps = new List<Win32OperatingSystem>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiOperatingSystem(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32OperatingSystem>();
            FillFloppyDriveInfo();
        }

        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32OperatingSystem csp = new Win32OperatingSystem();
                if (mo != null)
                {
                    csp.BootDevice = GetManagementObject<string>(mo, "BootDevice");
                    csp.BuildNumber = GetManagementObject<string>(mo, "BuildNumber");
                    csp.BuildType = GetManagementObject<string>(mo, "BuildType");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.CodeSet = GetManagementObject<string>(mo, "CodeSet");
                    csp.CountryCode = GetManagementObject<string>(mo, "CountryCode");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.CSCreationClassName = GetManagementObject<string>(mo, "CSCreationClassName");
                    csp.CSDVersion = GetManagementObject<string>(mo, "CSDVersion");
                    csp.CSName = GetManagementObject<string>(mo, "CSName");
                    csp.CurrentTimeZone = GetManagementObject<short>(mo, "CurrentTimeZone");
                    csp.DataExecutionPrevention_32BitApplications = GetManagementObject<bool>(mo, "DataExecutionPrevention_32BitApplications");
                    csp.DataExecutionPrevention_Available = GetManagementObject<bool>(mo, "DataExecutionPrevention_Available");
                    csp.DataExecutionPrevention_Drivers = GetManagementObject<bool>(mo, "DataExecutionPrevention_Drivers");
                    csp.DataExecutionPrevention_SupportPolicy = GetManagementObject<byte>(mo, "DataExecutionPrevention_SupportPolicy");
                    csp.Debug = GetManagementObject<bool>(mo, "Debug");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.Distributed = GetManagementObject<bool>(mo, "Distributed");
                    csp.EncryptionLevel = GetManagementObject<uint>(mo, "EncryptionLevel");
                    csp.ForegroundApplicationBoost = GetManagementObject<byte>(mo, "ForegroundApplicationBoost");
                    csp.FreePhysicalMemory = GetManagementObject<ulong>(mo, "FreePhysicalMemory");
                    csp.FreeSpaceInPagingFiles = GetManagementObject<ulong>(mo, "FreeSpaceInPagingFiles");
                    csp.FreeVirtualMemory = GetManagementObject<ulong>(mo, "FreeVirtualMemory");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.LargeSystemCache = GetManagementObject<uint>(mo, "LargeSystemCache");
                    csp.Cim_LastBootUpTime = GetManagementObject<string>(mo, "LastBootUpTime");
                    csp.Cim_LocalDateTime = GetManagementObject<string>(mo, "LocalDateTime");
                    csp.Locale = GetManagementObject<string>(mo, "Locale");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.MaxNumberOfProcesses = GetManagementObject<uint>(mo, "MaxNumberOfProcesses");
                    csp.MaxProcessMemorySize = GetManagementObject<ulong>(mo, "MaxProcessMemorySize");
                    csp.MUILanguages = GetManagementObject<string[]>(mo, "MUILanguages");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.NumberOfLicensedUsers = GetManagementObject<uint>(mo, "NumberOfLicensedUsers");
                    csp.NumberOfProcesses = GetManagementObject<uint>(mo, "NumberOfProcesses");
                    csp.NumberOfUsers = GetManagementObject<uint>(mo, "NumberOfUsers");
                    csp.Organization = GetManagementObject<string>(mo, "Organization");
                    csp.OSArchitecture = GetManagementObject<string>(mo, "OSArchitecture");
                    csp.OSLanguage = GetManagementObject<uint>(mo, "OSLanguage");
                    csp.OSProductSuite = GetManagementObject<uint>(mo, "OSProductSuite");
                    csp.OSType = GetManagementObject<uint>(mo, "OSType");
                    csp.OtherTypeDescription = GetManagementObject<string>(mo, "OtherTypeDescription");
                    csp.PAEEnabled = GetManagementObject<bool>(mo, "PAEEnabled");
                    csp.PlusProductID = GetManagementObject<string>(mo, "PlusProductID");
                    csp.PlusVersionNumber = GetManagementObject<string>(mo, "PlusVersionNumber");
                    csp.Primary = GetManagementObject<bool>(mo, "Primary");
                    csp.ProductType = GetManagementObject<uint>(mo, "ProductType");
                    csp.QuantumLength = GetManagementObject<byte>(mo, "QuantumLength");
                    csp.QuantumType = GetManagementObject<byte>(mo, "QuantumType");
                    csp.RegisteredUser = GetManagementObject<string>(mo, "RegisteredUser");
                    csp.SerialNumber = GetManagementObject<string>(mo, "SerialNumber");
                    csp.ServicePackMajorVersion = GetManagementObject<ushort>(mo, "ServicePackMajorVersion");
                    csp.ServicePackMinorVersion = GetManagementObject<ushort>(mo, "ServicePackMinorVersion");
                    csp.SizeStoredInPagingFiles = GetManagementObject<ulong>(mo, "SizeStoredInPagingFiles");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.SuiteMask = GetManagementObject<uint>(mo, "SuiteMask");
                    csp.SystemDevice = GetManagementObject<string>(mo, "SystemDevice");
                    csp.SystemDirectory = GetManagementObject<string>(mo, "SystemDirectory");
                    csp.SystemDrive = GetManagementObject<string>(mo, "SystemDrive");
                    csp.TotalSwapSpaceSize = GetManagementObject<ulong>(mo, "TotalSwapSpaceSize");
                    csp.TotalVirtualMemorySize = GetManagementObject<ulong>(mo, "TotalVirtualMemorySize");
                    csp.TotalVisibleMemorySize = GetManagementObject<ulong>(mo, "TotalVisibleMemorySize");
                    csp.Version = GetManagementObject<string>(mo, "Version");
                    csp.WindowsDirectory = GetManagementObject<string>(mo, "WindowsDirectory");
                    csp.WOWEnvironment = GetManagementObject<bool>(mo, "WOWEnvironment");

                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32OperatingSystem> Win32OperatingSystems
        {
            get { return ps; }
        }
        public int Win32OperatingSystemsLength
        {
            get { return ps.Count; }
        }
    }
}
