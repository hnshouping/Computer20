using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public abstract class Win32BaseService : CIMService
    {
        private bool acceptPause;
        private bool acceptStop;
        private bool desktopInteract;
        private string displayName;
        private string errorControl;
        private UInt32 exitCode;
        private string pathName;
        private UInt32 serviceSpecificExitCode;
        private byte serviceType;
        private string startName;
        private string state;
        private UInt32 tagId;

        private Dictionary<string, string> dictionErrorControl;
        private Dictionary<ushort, string> dictionServiceType;

        /// <summary>
        /// 能中止服务
        /// </summary>
        public bool AcceptPause
        {
            get { return acceptPause; }
            set { acceptPause = value; }
        }
        /// <summary>
        /// 能停止服务
        /// </summary>
        public bool AcceptStop
        {
            get { return acceptStop; }
            set { acceptStop = value; }
        }
        /// <summary>
        /// 服务能成立或沟通window在桌面上
        /// </summary>
        public bool DesktopInteract
        {
            get { return desktopInteract; }
            set { desktopInteract = value; }
        }
        /// <summary>
        /// 服务的显示名
        /// </summary>
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        /// <summary>
        /// 严重错误
        /// </summary>
        public string ErrorControl
        {
            get { return errorControl; }
            set { errorControl = value; }
        }
        /// <summary>
        /// 定义一些相遇问题,开如或停止这服务
        /// </summary>
        public UInt32 ExitCode
        {
            get { return exitCode; }
            set { exitCode = value; }
        }
        /// <summary>
        /// 服务工具的二进文件的完全路径 如:"\SystemRoot\System32\drivers\afd.sys"
        /// </summary>
        public string PathName
        {
            get { return pathName; }
            set { pathName = value; }
        }
        /// <summary>
        /// 当服务启动或停止时发生的服务细节错误的错误号
        /// </summary>
        public UInt32 ServiceSpecificExitCode
        {
            get { return serviceSpecificExitCode; }
            set { serviceSpecificExitCode = value; }
        }
        /// <summary>
        /// Service provided to calling processes.
        /// </summary>
        public byte ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
        }
        /// <summary>
        /// Account name under which the service runs
        /// </summary>
        public string StartName
        {
            get { return startName; }
            set { startName = value; }
        }
        /// <summary>
        /// 基本服务当前状态"Stopped""Start Pending""Stop Pending""Running""Continue Pending""Pause Pending""Paused""Unknown"
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>
        /// 在组中服务的唯一值
        /// </summary>
        public UInt32 TagId
        {
            get { return tagId; }
            set { tagId = value; }
        }
        public Dictionary<string, string> YxDictionErrorControl
        {
            get
            {
                GetParser();
                return dictionErrorControl;
            }
        }
        public Dictionary<ushort, string> YxDictionServiceType
        {
            get
            {
                GetParser();
                return dictionServiceType;
            }
        }
        /// <summary>
        /// 得到ErrorControl的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetErrorControlbyInt(string key)
        {
            string dic;
            bool a = YxDictionErrorControl.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }
        /// <summary>
        /// 得到ServiceType的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetServiceTypebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionServiceType.TryGetValue(key, out dic);
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
            dictionErrorControl = new Dictionary<string, string>();
            dictionErrorControl.Add("Ignore", "User is not notified");
            dictionErrorControl.Add("Normal", "User is notified");
            dictionErrorControl.Add("Severe", "System restarted with last-known-good configuration");
            dictionErrorControl.Add("Critical", "System attempts to restart with good configuration");
            dictionErrorControl.Add("Unknown", "Action taken is unspecified");
            dictionServiceType = new Dictionary<ushort, string>();
            dictionServiceType.Add(1, "Kernel Driver");
            dictionServiceType.Add(2, "File System Driver");
            dictionServiceType.Add(4, "Adapter");
            dictionServiceType.Add(8, "Recognizer Driver");
            dictionServiceType.Add(16, "Own Process");
            dictionServiceType.Add(32, "Share Process");
            dictionServiceType.Add(256, "Interactive Process");
        }

        public abstract uint Change(string DisplayName, string PathName, ushort ServiceType, byte ErrorControl,
    string StartMode, bool DesktopInteract, string StartName, string StartPassword,
    string LoadOrderGroup, string[] LoadOrderGroupDependencies, string[] ServiceDependencies);
        public abstract uint ChangeStartMode(string StartMode);
        public abstract uint Create(string Name, string DisplayName, string PathName, ushort ServiceType, byte ErrorControl,
            string StartMode, bool DesktopInteract, string StartName, string StartPassword, string LoadOrderGroup,
            string[] LoadOrderGroupDependencies, string[] ServiceDependencies);
        public abstract uint Delete();
        public abstract uint InterrogateService();
        public abstract uint PauseService();
        public abstract uint ResumeService();
        public abstract uint UserControlService(byte ControlCode);

    }
}
