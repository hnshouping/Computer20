using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using Computer;
using System.Management;

namespace WmiInfo
{
    public class WmiBaseBoard : WmiBase
    {
        private List<Win32BaseBoard> ps;
        private string WSql = "SELECT * FROM Win32_BaseBoard";


        public WmiBaseBoard()
            : base()
        {
            ps = new List<Win32BaseBoard>();
            FillFloppyDriveInfo();
        }
        public WmiBaseBoard(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32BaseBoard>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            Win32BaseBoard csp = new Win32BaseBoard();
            ManagementObjectCollection moc = GetAllInfo(WSql);
            foreach (ManagementObject mo in moc)
            {
                if (mo != null)
                {
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.ConfigOptions =GetManagementObject<string[]>(mo, "ConfigOptions");
                    csp.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    csp.Depth = GetManagementObject<float>(mo, "Depth");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.Height = GetManagementObject<float>(mo, "Height");
                    csp.HostingBoard = GetManagementObject<bool>(mo, "HostingBoard");
                    csp.HotSwappable = GetManagementObject<bool>(mo, "HotSwappable");
                    csp.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    csp.Manufacturer = GetManagementObject<string>(mo, "Manufacturer");
                    csp.Model = GetManagementObject<string>(mo, "Model");
                    csp.Name = GetManagementObject<string>(mo, "Name");
                    csp.OtherIdentifyingInfo = GetManagementObject<string>(mo, "OtherIdentifyingInfo");
                    csp.PartNumber = GetManagementObject<string>(mo, "PartNumber");
                    csp.PoweredOn = GetManagementObject<bool>(mo, "PoweredOn");
                    csp.Product = GetManagementObject<string>(mo, "Product");
                    csp.Removable = GetManagementObject<bool>(mo, "Removable");
                    csp.Replaceable = GetManagementObject<bool>(mo, "Replaceable");
                    csp.RequirementsDescription = GetManagementObject<string>(mo, "RequirementsDescription");
                    csp.RequiresDaughterBoard = GetManagementObject<bool>(mo, "RequiresDaughterBoard");
                    csp.SerialNumber = GetManagementObject<string>(mo, "SerialNumber");
                    csp.SKU = GetManagementObject<string>(mo, "SKU");
                    csp.SlotLayout = GetManagementObject<string>(mo, "SlotLayout");
                    csp.SpecialRequirements = GetManagementObject<bool>(mo, "SpecialRequirements");
                    csp.Status = GetManagementObject<string>(mo, "Status");
                    csp.Tag = GetManagementObject<string>(mo, "Tag");
                    csp.Version = GetManagementObject<string>(mo, "Version");
                    csp.Weight = GetManagementObject<float>(mo, "Weight");
                    csp.Width = GetManagementObject<float>(mo, "Width");
                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32BaseBoard> Win32BaseBoards
        {
            get { return ps; }
        }
        public int Win32BaseBoardsLength
        {
            get { return ps.Count; }
        }
    }
}
