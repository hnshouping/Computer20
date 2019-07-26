using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{
    public class Win32Share : CIMLogicalElement
    {
        private UInt32 accessMask;
        private bool allowMaximum;
        private UInt32 maximumAllowed;
        private string path;
        private UInt32 type;


        private Dictionary<uint, string> dictionType;

        private WmiCommon wmi;

        public Win32Share()
        {
            wmi = new WmiCommon();
        }

        /// <summary>
        /// 组支持给文件或者文件夹的连系列表
        /// </summary>
        public UInt32 AccessMask
        {
            get { return accessMask; }
            set { accessMask = value; }
        }
        /// <summary>
        /// 同时使用有限资源的数量
        /// </summary>
        public bool AllowMaximum
        {
            get { return allowMaximum; }
            set { allowMaximum = value; }
        }
        /// <summary>
        /// 同时使用有限资源的最大数
        /// </summary>
        public UInt32 MaximumAllowed
        {
            get { return maximumAllowed; }
            set { maximumAllowed = value; }
        }
        /// <summary>
        /// windows共享的本机路径
        /// </summary>
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        /// <summary>
        /// 共享资源的类型
        /// </summary>
        public UInt32 Type
        {
            get { return type; }
            set { type = value; }
        }
        public Dictionary<uint, string> YxDictionType
        {
            get
            {
                GetParser();
                return dictionType;
            }
        }
        /// <summary>
        /// 得到Type的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetTypebyInt(uint key)
        {
            string dic;
            bool a = YxDictionType.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }
        private void GetParser()
        {
            dictionType = new Dictionary<uint, string>();
            dictionType.Add(0, "Disk Drive");
            dictionType.Add(1, "Print Queue");
            dictionType.Add(2, "Device");
            dictionType.Add(3, "IPC");
            dictionType.Add(2147483648, "Disk Drive Admin");
            dictionType.Add(2147483649, "Print Queue Admin");
            dictionType.Add(2147483650, "Device Admin");
            dictionType.Add(2147483651, "IPC Admin");
        }

        public class SHAType
        {
            public const uint DISK_DRIVE = 0;
            public const uint PRINT_QUEUE = 1;
            public const uint DEVICE = 2;
            public const uint IPC = 3;
            public const uint DISK_DRIVE_ADMIN = 2147483648;
            public const uint PRINT_QUEUE_ADMIN = 2147483649;
            public const uint DEVICE_ADMIN = 2147483650;
            public const uint IPC_ADMIN = 2147483651;
        }
        public uint Create(string Path, string Name, uint Type, uint MaximumAllowed,
    string Description, string Password, Win32SecurityDescriptor Access)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Share  where Name='" + this.Name.ToString() + "'");
            ManagementObject mop = null;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            ManagementBaseObject inbo = mop.GetMethodParameters("Create");
            inbo["Path"] = Path;
            inbo["Name"] = Name;
            inbo["Type"] = Type;
            inbo["MaximumAllowed"] = MaximumAllowed;
            inbo["Description"] = Description;
            inbo["Password"] = Password;
            inbo["Access"] = Access;

            ManagementBaseObject outbo = mop.InvokeMethod("Create", inbo, null);
            uint a = (uint)outbo["ReturnValue"];
            return a;
        }
        public uint Delete()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Share  where Name='" + this.Name.ToString() + "'");
            ManagementObject mop = null;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            ManagementBaseObject inbo = mop.GetMethodParameters("Delete");

            ManagementBaseObject outbo = mop.InvokeMethod("Create", inbo, null);
            uint a = (uint)outbo["ReturnValue"];
            return a;
        }
        //		public uint GetAccessMask()
        //		{
        //		}
        public uint SetShareInfo(uint MaximumAllowed, string Description, Win32SecurityDescriptor Access)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Share  where Name='" + this.Name.ToString() + "'");
            ManagementObject mop = null;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            ManagementBaseObject inbo = mop.GetMethodParameters("Create");
            inbo["MaximumAllowed"] = MaximumAllowed;
            inbo["Description"] = Description;
            inbo["Access"] = Access;

            ManagementBaseObject outbo = mop.InvokeMethod("Create", inbo, null);
            uint a = (uint)outbo["ReturnValue"];
            return a;
        }
        public string GetstringFromreturnvalue(uint returnvalue)
        {
            switch (returnvalue)
            {
                case 0:
                    return "Success";
                case 2:
                    return "Access denied";
                case 8:
                    return "Unknown failure";
                case 9:
                    return "Invalid name";
                case 10:
                    return "Invalid level";
                case 21:
                    return "Invalid parameter";
                case 22:
                    return "Duplicate share";
                case 23:
                    return "Redirected path";
                case 24:
                    return "Unknown device or directory ";
                case 25:
                    return " Net name not found";
                default:
                    return "no Exec";
            }

        }
    }
}
