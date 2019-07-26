using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{
    public class Win32Service : Win32BaseService
    {
        private UInt32 checkPoint;
        private UInt32 processId;
        private UInt32 waitHint;

        private WmiCommon wmi;

        public Win32Service()
        {

            wmi=new WmiCommon();
        }

        /// <summary>
        /// 在长时间开始服务后,周期性的报告服务增加的值
        /// </summary>
        public UInt32 CheckPoint
        {
            get { return checkPoint; }
            set { checkPoint = value; }
        }
        /// <summary>
        /// 服务过程的唯一标识
        /// </summary>
        public UInt32 ProcessId
        {
            get { return processId; }
            set { processId = value; }
        }
        /// <summary>
        /// 评估必须的操作时间
        /// </summary>
        public UInt32 WaitHint
        {
            get { return waitHint; }
            set { waitHint = value; }
        }

        public class SERServiceType
        {
            public const ushort KERNEL_DRIVER=1;
            public const ushort FILE_SYSTEM_DRIVER = 2;
            public const ushort ADAPTER = 4;
            public const ushort RECOGNIZER_DRIVER = 8;
            public const ushort OWN_PROCESS = 16;
            public const ushort SHARE_PROCESS = 32;
            public const ushort INTERACTIVE_PROCESS = 256;
        }
        public class SERErrorControl 
        {
            public const byte USER_IS_NOT_NOTIFIED = 0;
            public const byte USER_IS_NOTIFIED = 1;
            /// <summary>
            /// System is restarted with last-known-good configuration
            /// </summary>
            public const byte SYSTEM_IS_RESTARTED = 2;
            /// <summary>
            /// System attempts to start with a good configuration
            /// </summary>
            public const byte SYSTEM_ATTEMPTS_TO_START = 3;
        }
        public class SERStartMode 
        {
            public const string BOOT = "Boot";
            public const string SYSTEM = "System";
            public const string AUTOMATIC = "Automatic";
            public const string MANUAL = "Manual";
            public const string DISABLED = "Disabled";
        }

        public override uint Change(string DisplayName, string PathName, ushort ServiceType, byte ErrorControl, string StartMode, bool DesktopInteract,
			string StartName, string StartPassword, string LoadOrderGroup, string[] LoadOrderGroupDependencies, string[] ServiceDependencies)
		{
            byte b = 0;
            if (ServiceType != 256)
            {
                b = byte.Parse(ServiceType.ToString());
            }
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			ManagementObject mop=null;
			foreach(ManagementObject mo in moc)
			{
				mop=mo;
			}
            ManagementBaseObject inbo = mop.GetMethodParameters("Change");
			inbo["DisplayName"]=DisplayName;
			inbo["PathName"]=PathName;
			inbo["ServiceType"]=b;
			inbo["ErrorControl"]=ErrorControl;
			inbo["StartMode"]=StartMode;
			inbo["DesktopInteract"]=DesktopInteract;
			inbo["StartName"]=StartName;
			inbo["StartPassword"]=StartPassword;
			inbo["LoadOrderGroup"]=LoadOrderGroup;
			inbo["LoadOrderGroupDependencies"]=LoadOrderGroupDependencies;
			inbo["ServiceDependencies"]=ServiceDependencies;

            ManagementBaseObject outbo = mop.InvokeMethod("Change", inbo, null);
			uint a=(uint)outbo["ReturnValue"];
			return a;
		}
		public override uint ChangeStartMode(string StartMode)
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			ManagementObject mop=null;
			foreach(ManagementObject mo in moc)
			{
				mop=mo;
			}
            ManagementBaseObject inbo = mop.GetMethodParameters("ChangeStartMode");
			inbo["StartMode"]=StartMode;

            ManagementBaseObject outbo = mop.InvokeMethod("ChangeStartMode", inbo, null);
			uint a=(uint)outbo["ReturnValue"];
			return a;
		}
		public override uint Create(string Name, string DisplayName, string PathName, ushort ServiceType, byte ErrorControl, string StartMode,
			bool DesktopInteract, string StartName, string StartPassword, string LoadOrderGroup, string[] LoadOrderGroupDependencies, 
			string[] ServiceDependencies)
		{
            byte b= 0;
            if (ServiceType!= 256)
            {
                b = byte.Parse(ServiceType.ToString());
            }

            ManagementClass processClass = wmi.GetManagementClass("Win32_Service");
            ManagementBaseObject inbo = processClass.GetMethodParameters("Create");
            inbo["Name"] = Name;
            inbo["DisplayName"] = DisplayName;
            inbo["PathName"] = PathName;
            inbo["ServiceType"] = b;
            inbo["ErrorControl"] = ErrorControl;
            inbo["StartMode"] = StartMode;
            inbo["DesktopInteract"] = DesktopInteract;
            inbo["StartName"] = StartName;
            inbo["StartPassword"] = StartPassword;
            inbo["LoadOrderGroup"] = LoadOrderGroup;
            inbo["LoadOrderGroupDependencies"] = LoadOrderGroupDependencies;
            inbo["ServiceDependencies"] = ServiceDependencies;

            ManagementBaseObject outbo = processClass.InvokeMethod("Create", inbo, null);
            uint a = (uint)outbo["ReturnValue"];
            return a;
		}
		public override uint Delete()
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			
			uint a=uint.MaxValue;	

			foreach(ManagementObject mo in moc)
			{
				a=(uint)mo.InvokeMethod("Delete",null);
			}
			
			return a;
		}
		public override bool Equals(object obj)
		{
			return base.Equals (obj);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode ();
		}

		public override uint InterrogateService()
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			
			uint a=uint.MaxValue;	

			foreach(ManagementObject mo in moc)
			{
				a=(uint)mo.InvokeMethod("InterrogateService",null);
			}
			
			return a;
		}
        /// <summary>
        /// 暂停服务
        /// </summary>
        /// <returns>结果</returns>
		public override uint PauseService()
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			
			uint a=uint.MaxValue;	

			foreach(ManagementObject mo in moc)
			{
				a=(uint)mo.InvokeMethod("PauseService",null);
			}
			
			return a;
		}
        /// <summary>
        /// 恢复服务
        /// </summary>
        /// <returns>结果</returns>
		public override uint ResumeService()
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			
			uint a=uint.MaxValue;	

			foreach(ManagementObject mo in moc)
			{
				a=(uint)mo.InvokeMethod("ResumeService",null);
			}
			
			return a;
		}
        /// <summary>
        /// 开始服务
        /// </summary>
        /// <returns>结果</returns>
		public uint StartService()
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			
			uint a=uint.MaxValue;	

			foreach(ManagementObject mo in moc)
			{
				a=(uint)mo.InvokeMethod("StartService",null);
			}
			
			return a;
		}
        /// <summary>
        /// 停止服务
        /// </summary>
        /// <returns>结果</returns>
		public uint StopService()
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			
			uint a=uint.MaxValue;	

			foreach(ManagementObject mo in moc)
			{
				a=(uint)mo.InvokeMethod("StopService",null);
			}
			
			return a;
		}
		public override string ToString()
		{
			return this.Name.ToString()+this.PathName.ToString();
		}
		public override uint UserControlService(byte ControlCode)
		{
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			ManagementObject mop=null;
			foreach(ManagementObject mo in moc)
			{
				mop=mo;
			}
            ManagementBaseObject inbo = mop.GetMethodParameters("UserControlService");
			inbo["ControlCode"]=ControlCode;

			ManagementBaseObject outbo=mop.InvokeMethod("UserControlService",inbo,null);
			uint a=(uint)outbo["ReturnValue"];
			return a;
		}
		public uint GetSecurityDescriptor(out Win32SecurityDescriptor Descriptor)
		{
			Descriptor=null;
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			ManagementObject mop=null;
			foreach(ManagementObject mo in moc)
			{
				mop=mo;
			}
            ManagementBaseObject inbo = mop.GetMethodParameters("GetSecurityDescriptor");
            ManagementBaseObject outbo = mop.InvokeMethod("GetSecurityDescriptor", inbo, null);
			Descriptor=(Win32SecurityDescriptor)outbo["Descriptor"];
			uint a=(uint)outbo["ReturnValue"];
			return a;
		}
		public uint SetSecurityDescriptor(Win32SecurityDescriptor Descriptor)
		{
			Descriptor=null;
			ManagementObjectCollection moc=wmi.GetWSqlFromWMI("select * from Win32_Service where Name='"+this.Name.ToString()+"'");
			ManagementObject mop=null;
			foreach(ManagementObject mo in moc)
			{
				mop=mo;
			}
            ManagementBaseObject inbo = mop.GetMethodParameters("SetSecurityDescriptor");
			inbo["Descriptor"]=Descriptor;
            ManagementBaseObject outbo = mop.InvokeMethod("SetSecurityDescriptor", inbo, null);
			uint a=(uint)outbo["ReturnValue"];
			return a;
		}
        public string GetstringFromreturnvalue(uint returnvalue)
        {
            switch (returnvalue)
            {
                case 0:
                    return "Success";
                case 1:
                    return "Not_Supported";
                case 2:
                    return "Access_Denied";
                case 3:
                    return "Dependent_Services_Running";
                case 4:
                    return "Invalid_Service_Control";
                case 5:
                    return "Service_Cannot_Accept_Control";
                case 6:
                    return "Service_Not_Active";
                case 7:
                    return "Service_Request_Timeout";
                case 8:
                    return "Unknown_Failure";
                case 9:
                    return "Path_Not_Found";
                case 10:
                    return "Service_Already_Running";
                case 11:
                    return "Service_Database_Locked";
                case 12:
                    return "Service_Dependency_Deleted";
                case 13:
                    return "Service_Dependency_Failure";
                case 14:
                    return "Service_Disabled";
                case 15:
                    return "Service_Logon_Failure";
                case 16:
                    return "Service_Marked_For_Deletion";
                case 17:
                    return "Service_No_Thread";
                case 18:
                    return "Status_Circular_Dependency";
                case 19:
                    return "Status_Duplicate_Name";
                case 20:
                    return "Status_Invalid_Name";
                case 21:
                    return "Status_Invalid_Parameter";
                case 22:
                    return "Status_Invalid_Service_Account";
                case 23:
                    return "Status_Service_Exists";
                case 24:
                    return "Service_Already_Paused";
                default:
                    return "State_No_Exec";
            }
        }
    }
}
