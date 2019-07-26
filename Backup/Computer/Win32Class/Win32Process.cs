using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{
    public class Win32Process : CIMProcess
    {
        private string commandLine;
        private string executablePath;
        private UInt32 handleCount;
        private UInt32 maximumWorkingSetSize;
        private UInt32 minimumWorkingSetSize;
        private UInt64 otherOperationCount;
        private UInt64 otherTransferCount;
        private UInt32 pageFaults;
        private UInt32 pageFileUsage;
        private UInt32 parentProcessId;
        private UInt32 peakPageFileUsage;
        private UInt64 peakVirtualSize;
        private UInt32 peakWorkingSetSize;
        private UInt64 privatePageCount;
        private UInt32 processId;
        private UInt32 quotaNonPagedPoolUsage;
        private UInt32 quotaPagedPoolUsage;
        private UInt32 quotaPeakNonPagedPoolUsage;
        private UInt32 quotaPeakPagedPoolUsage;
        private UInt64 readOperationCount;
        private UInt64 readTransferCount;
        private UInt32 sessionId;
        private UInt32 threadCount;
        private UInt64 virtualSize;
        private string windowsVersion;
        private UInt64 writeOperationCount;
        private UInt64 writeTransferCount;

        private WmiCommon wmi;

        public Win32Process()
        {
            wmi = new WmiCommon();
        }

        /// <summary>
        /// ʹ��һ��������̵�������,�������
        /// </summary>
        public string CommandLine
        {
            get { return commandLine; }
            set { commandLine = value; }
        }
        /// <summary>
        /// ִ�н����ļ���·��:��:C:\WINDOWS\EXPLORER.EXE
        /// </summary>
        public string ExecutablePath
        {
            get { return executablePath; }
            set { executablePath = value; }
        }
        /// <summary>
        /// �ý��̴����о���ľ����
        /// </summary>
        public UInt32 HandleCount
        {
            get { return handleCount; }
            set { handleCount = value; }
        }
        /// <summary>
        /// Ϊ�������õ�������ߴ�
        /// </summary>
        public UInt32 MaximumWorkingSetSize
        {
            get { return maximumWorkingSetSize; }
            set { maximumWorkingSetSize = value; }
        }
        /// <summary>
        /// Ϊ�������õ���С�����ߴ�
        /// </summary>
        public UInt32 MinimumWorkingSetSize
        {
            get { return minimumWorkingSetSize; }
            set { minimumWorkingSetSize = value; }
        }
        /// <summary>
        ///��д����I/O����ִ�к�
        /// </summary>        
        public UInt64 OtherOperationCount
        {
            get { return otherOperationCount; }
            set { otherOperationCount = value; }
        }
        /// <summary>
        ///û�ж�д��������µ�����ת�Ƶ�������
        /// </summary>        
        public UInt64 OtherTransferCount
        {
            get { return otherTransferCount; }
            set { otherTransferCount = value; }
        }
        /// <summary>
        /// һ�����̲�������ҳ������
        /// </summary>
        public UInt32 PageFaults
        {
            get { return pageFaults; }
            set { pageFaults = value; }
        }
        /// <summary>
        /// ����ʹ��ҳ�ļ���������
        /// </summary>
        public UInt32 PageFileUsage
        {
            get { return pageFileUsage; }
            set { pageFileUsage = value; }
        }
        /// <summary>
        /// ����һ�����̵Ľ��̵�Ψһ��ʶ
        /// </summary>
        public UInt32 ParentProcessId
        {
            get { return parentProcessId; }
            set { parentProcessId = value; }
        }
        /// <summary>
        ///�ڽ��̻ʱ�����ܵ�ʹ��ҳ�ļ��ռ�������
        /// </summary>
        public UInt32 PeakPageFileUsage
        {
            get { return peakPageFileUsage; }
            set { peakPageFileUsage = value; }
        }
        /// <summary>
        /// ������һ��ʱ�����ʹ�����������ַ�ռ�
        /// </summary>
        public UInt64 PeakVirtualSize
        {
            get { return peakVirtualSize; }
            set { peakVirtualSize = value; }
        }
        /// <summary>
        /// ���̵���ߵ�ʹ�óߴ�
        /// </summary>
        public UInt32 PeakWorkingSetSize
        {
            get { return peakWorkingSetSize; }
            set { peakWorkingSetSize = value; }
        }
        /// <summary>
        ///����ĵ�ǰҳ��ʹ������
        /// </summary>        
        public UInt64 PrivatePageCount
        {
            get { return privatePageCount; }
            set { privatePageCount = value; }
        }
        /// <summary>
        ///����ʹ�õ�ȫ��Ψһ��
        /// </summary>        
        public UInt32 ProcessId
        {
            get { return processId; }
            set { processId = value; }
        }
        /// <summary>
        ///�����̵Ĳ���ҳ�ص������
        /// </summary>        
        public UInt32 QuotaNonPagedPoolUsage
        {
            get { return quotaNonPagedPoolUsage; }
            set { quotaNonPagedPoolUsage = value; }
        }
        /// <summary>
        ///�����̵ķ�ҳ�ص������ 
        /// </summary>
        public UInt32 QuotaPagedPoolUsage
        {
            get { return quotaPagedPoolUsage; }
            set { quotaPagedPoolUsage = value; }
        }
        /// <summary>
        /// ����ҳ�ص����ʹ�������
        /// </summary>
        public UInt32 QuotaPeakNonPagedPoolUsage
        {
            get { return quotaPeakNonPagedPoolUsage; }
            set { quotaPeakNonPagedPoolUsage = value; }
        }
        /// <summary>
        /// ҳ�ص����ʹ�������
        /// </summary>
        public UInt32 QuotaPeakPagedPoolUsage
        {
            get { return quotaPeakPagedPoolUsage; }
            set { quotaPeakPagedPoolUsage = value; }
        }
        /// <summary>
        /// ִ�ж�����������
        /// </summary>
        public UInt64 ReadOperationCount
        {
            get { return readOperationCount; }
            set { readOperationCount = value; }
        }
        /// <summary>
        /// ִ��Ǩ�Ƶ�����
        /// </summary>
        public UInt64 ReadTransferCount
        {
            get { return readTransferCount; }
            set { readTransferCount = value; }
        }
        /// <summary>
        /// ����ϵͳ���ɵ�һ��SessionΨһֵ
        /// </summary>
        public UInt32 SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }
        /// <summary>
        /// ���̻���߳���
        /// </summary>
        public UInt32 ThreadCount
        {
            get { return threadCount; }
            set { threadCount = value; }
        }
        /// <summary>
        /// ������ʹ�õĵ�ǰ�����ַ�ռ�,û��ʹ������������ڴ�
        /// </summary>        
        public UInt64 VirtualSize
        {
            get { return virtualSize; }
            set { virtualSize = value; }
        }
        /// <summary>
        /// �������е�windows�汾
        /// </summary>
        public string WindowsVersion
        {
            get { return windowsVersion; }
            set { windowsVersion = value; }
        }
        /// <summary>
        /// ִ��д����������
        /// </summary>
        public UInt64 WriteOperationCount
        {
            get { return writeOperationCount; }
            set { writeOperationCount = value; }
        }
        /// <summary>
        /// д��������
        /// </summary>
        public UInt64 WriteTransferCount
        {
            get { return writeTransferCount; }
            set { writeTransferCount = value; }
        }

        public class PROPriority
        {
            public const int IDLE = 64;
            public const int BELOW_NORMAL = 16384;
            public const int NORMAL = 32;
            public const int ABOVE_NORMAL = 32768;
            public const int HIGH_PRIORITY = 128;
            public const int REALTIME = 256;
        }

        public uint AttachDebugger()
        {
            return uint.MaxValue;
        }
        public uint Create(string CommandLine, string CurrentDirectory, Win32ProcessStartup ProcessStartupInformation, out uint ProcessId)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Process where Handle='" + this.Handle.ToString() + "'");
            ManagementObject mop = null;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            ManagementBaseObject inbo = mop.GetMethodParameters("GetOwner");
            inbo["CommandLine"] = CommandLine;
            inbo["CurrentDirectory"] = CurrentDirectory;
            inbo["ProcessStartupInformation"] = ProcessStartupInformation;
            ManagementBaseObject outbo = mop.InvokeMethod("GetOwner", inbo, null);
            object c = outbo["ProcessId"];
            if (c != null)
            {
                ProcessId = (uint)c;
            }
            else
            {
                ProcessId = uint.MaxValue;
            }
            uint a = (uint)outbo["ReturnValue"];
            return a;
        }
        public uint GetOwner(out string User, out string Domain)
        {
            User = ""; Domain = "";
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Process where Handle='" + this.Handle.ToString() + "'");
            ManagementObject mop = null;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            ManagementBaseObject inbo = mop.GetMethodParameters("GetOwner");
            ManagementBaseObject outbo = mop.InvokeMethod("GetOwner", inbo, null);
            object a = outbo["User"], b = outbo["Domain"];
            if (a != null)
            {
                User = a.ToString();
            }
            if (b != null)
            {
                Domain = b.ToString();
            }
            uint c = (uint)outbo["ReturnValue"];
            return c;

        }
        public uint GetOwnerSid(out string Sid)
        {
            Sid = "";
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Process where Handle='" + this.Handle.ToString() + "'");
            ManagementObject mop = null;
            foreach (ManagementObject mo in moc)
            {
                mop = mo;
            }
            ManagementBaseObject inbo = mop.GetMethodParameters("GetOwnerSid");
            ManagementBaseObject outbo = mop.InvokeMethod("GetOwnerSid", inbo, null);
            object a = outbo["Sid"];
            if (a != null)
            {
                Sid = a.ToString();
            }

            uint c = (uint)outbo["ReturnValue"];
            return c;
        }
        public uint SetPriority(int Priority)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Process where Handle='" + this.Handle.ToString() + "'");

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetPriority", new object[] { Priority });
            }

            return a;
        }
        public uint Terminate(uint Reason)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Process where Handle='" + this.Handle.ToString() + "'");

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("Terminate", new object[] { Reason });
            }

            return a;
        }
        public string Getstringfromuint(uint returnvalue)
        {
            switch (returnvalue)
            {
                case 0:
                    return "Successful completion";
                case 2:
                    return "Access denied";
                case 3:
                    return "Insufficient privilege";
                case 8:
                    return "Unknown failure";
                case 9:
                    return "Path not found";
                case 21:
                    return "Invalid parameter";
                default:
                    return "No Name Error";
            }
        }

    }
}
