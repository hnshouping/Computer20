using System;
using System.Collections.Generic;
using System.Text;
using System.Management;


namespace Computer.Win32Class
{
    public class Win32Directory : CIMDirectory
    {
        private WmiCommon wmi;


        public class DirFieldOption
        {
            /// <summary>
            /// Change the owner of the logical file
            /// </summary>
            public const uint CHANGE_OWNER_SECURITY_INFORMATION = 1;
            /// <summary>
            /// Change the group of the logical file.
            /// </summary>
            public const uint CHANGE_GROUP_SECURITY_INFORMATION = 2;
            /// <summary>
            /// Change the discretionary access control list (DACL) of the logical file. 
            /// </summary>
            public const uint CHANGE_DACL_SECURITY_INFORMATION = 4;
            /// <summary>
            /// Change the system access control list (SACL) of the logical file. 
            /// </summary>
            public const uint CHANGE_SACL_SECURITY_INFORMATION = 8;
        }

        public class DirFiledPermissions
        {
            /// <summary>
            /// file
            /// </summary>
            public const uint FILE_READ_DATA = 1;
            /// <summary>
            /// directory
            /// </summary>
            public const uint FILE_LIST_DIRECTORY = 1;
            /// <summary>
            /// file
            /// </summary>
            public const uint FILE_WRITE_DATA = 2;
            /// <summary>
            /// directory
            /// </summary>
            public const uint FILE_ADD_FILE = 2;
            /// <summary>
            /// file
            /// </summary>
            public const uint FILE_APPEND_DATA = 4;
            /// <summary>
            /// directory
            /// </summary>
            public const uint FILE_ADD_SUBDIRECTORY = 4;
            public const uint FILE_READ_EA = 8;
            public const uint FILE_WRITE_EA = 16;
            /// <summary>
            /// file
            /// </summary>
            public const uint FILE_EXECUTE = 32;
            /// <summary>
            /// directory
            /// </summary>
            public const uint FILE_TRAVERSE = 32;
            public const uint FILE_DELETE_CHILD = 64;
            public const uint FILE_READ_ATTRIBUTES = 128;
            public const uint FILE_WRITE_ATTRIBUTES = 256;
            public const uint DELETE = 65536;
            public const uint READ_CONTROL = 131072;
            public const uint WRITE_DAC = 262144;
            public const uint WRITE_OWNER = 524288;
            public const uint SYNCHRONIZE = 1048576;
        }

        public Win32Directory()
        {
            wmi = new WmiCommon();
        }
        public override uint ChangeSecurityPermissions(Win32SecurityDescriptor SecurityDescriptor, uint Option)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("ChangeSecurityPermissions", new object[] { SecurityDescriptor, Option });
            return a;
        }
        public override uint Compress()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("Compress", null);
            return a;
        }
        public override uint Copy(string FileName)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("Copy", new string[] { FileName });
            return a;
        }
        public override uint CopyEx(string FileName, string StopFileName, string StartFileName, bool Recursive)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }

            a = (uint)mop.InvokeMethod("CopyEx", new object[] { FileName, StopFileName, StartFileName, Recursive });
            return a;
        }
        public override uint ChangeSecurityPermissionsEx(Win32SecurityDescriptor SecurityDescriptor, uint Option, string StopFileName, string StartFileName, bool Recursive)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("ChangeSecurityPermissionsEx", new object[] { SecurityDescriptor, Option, StopFileName, StartFileName, Recursive });
            return a;
        }
        public override uint CompressEx(ref string StopFileName, string StartFileName, bool Recursive)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("CompressEx", new object[] { StopFileName, StartFileName, Recursive });
            return a;
        }
        public override uint Delete()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("Delete", null);
            return a;
        }
        public override uint DeleteEx(ref string StopFileName, string StartFileName)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("Delete", new object[] { StopFileName, StartFileName });
            return a;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override bool GetEffectivePermission(uint Permissions)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            bool a;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (bool)mop.InvokeMethod("GetEffectivePermission", new object[] { Permissions });
            return a;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override uint Rename(string FileName)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("Rename", new string[] { FileName });
            return a;
        }
        public override uint TakeOwnerShip()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("TakeOwnerShip", null);
            return a;
        }
        public override uint TakeOwnerShipEx(ref string StopFileName, string StartFileName, bool Recursive)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("TakeOwnerShipEx", new object[] { StopFileName, StartFileName, Recursive });
            return a;
        }
        public override uint Uncompress()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("Uncompress", null);
            return a;
        }
        public override uint UncompressEx(ref string StopFileName, string StartFileName, bool Recursive)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Directory  where Name='" + this.Name.ToString().Replace(@"\", @"\\") + "'");
            ManagementObject mop = null;
            uint a = 0;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            a = (uint)mop.InvokeMethod("UncompressEx", new object[] { StopFileName, StartFileName, Recursive });
            return a;
        }
        public override string ToString()
        {
            return this.Name.ToString();
        }


    }
}
