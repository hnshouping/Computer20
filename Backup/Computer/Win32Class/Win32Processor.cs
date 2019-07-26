using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32Processor : CIMProcessor
    {        
        private UInt16 architecture;
        private UInt16 cpuStatus;
        private UInt16 currentVoltage;
        private UInt32 extClock;
        private UInt32 l2CacheSize;
        private UInt32 l2CacheSpeed;
        private UInt16 level;
        private string manufacturer;
        private string processorId;
        private UInt16 processorType;
        private UInt16 revision;
        private string socketDesignation;
        private string version;
        private UInt32 voltageCaps;

        private Dictionary<uint, string> dictionVoltageCaps;
        private Dictionary<ushort, string> dictionProcessorType;
        private Dictionary<ushort, string> dictionCpuStatus;
        private Dictionary<ushort, string> dictionArchitecture;

        /// <summary>
        /// 处理器建构的使用者平台
        /// </summary>
        public UInt16 Architecture
        {
            get { return architecture; }
            set { architecture = value; }
        }
        /// <summary>
        ///  CPU的当前状态
        /// </summary>
        public UInt16 CpuStatus
        {
            get { return cpuStatus; }
            set { cpuStatus = value; }
        }
        /// <summary>
        /// 处理器的电压
        /// </summary>
        public UInt16 CurrentVoltage
        {
            get { return currentVoltage; }
            set { currentVoltage = value; }
        }
        /// <summary>
        /// 兆赫兹的外部时钟频率
        /// </summary>
        public UInt32 ExtClock
        {
            get { return extClock; }
            set { extClock = value; }
        }
        /// <summary>
        ///处理器缓存级别2的尺寸 
        /// </summary>
        public UInt32 L2CacheSize
        {
            get { return l2CacheSize; }
            set { l2CacheSize = value; }
        }
        /// <summary>
        /// 处理器缓存级别2的速度
        /// </summary>
        public UInt32 L2CacheSpeed
        {
            get { return l2CacheSpeed; }
            set { l2CacheSpeed = value; }
        }
        /// <summary>
        /// 处理器类型的定义
        /// </summary>
        public UInt16 Level
        {
            get { return level; }
            set { level = value; }
        }
        /// <summary>
        /// 处理器生产厂家
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        /// <summary>
        /// 处理器特征的描述信息
        /// </summary>
        public string ProcessorId
        {
            get { return processorId; }
            set { processorId = value; }
        }
        /// <summary>
        /// 中心处理器的类型
        /// </summary>
        public UInt16 ProcessorType
        {
            get { return processorType; }
            set { processorType = value; }
        }
        /// <summary>
        /// 依靠体制上的系统级别
        /// </summary>
        public UInt16 Revision
        {
            get { return revision; }
            set { revision = value; }
        }
        /// <summary>
        /// 在电路上使用的芯片类型
        /// </summary>
        public string SocketDesignation
        {
            get { return socketDesignation; }
            set { socketDesignation = value; }
        }
        /// <summary>
        /// 依靠体制上的处理器版本号
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        /// <summary>
        /// 处理器的额定电压
        /// </summary>
        public UInt32 VoltageCaps
        {
            get { return voltageCaps; }
            set { voltageCaps = value; }
        }
        private void GetParser()
        {
            dictionArchitecture = new Dictionary<ushort, string>();
            dictionArchitecture.Add(0, "x86");
            dictionArchitecture.Add(1, "MIPS");
            dictionArchitecture.Add(2, "Alpha");
            dictionArchitecture.Add(3, "PowerPC");
            dictionArchitecture.Add(6, "Intel Itanium Processor Family (IPF)");

            dictionCpuStatus = new Dictionary<ushort, string>();
            dictionCpuStatus.Add(0, "Unknown");
            dictionCpuStatus.Add(1, "CPU Enabled");
            dictionCpuStatus.Add(2, "CPU Disabled by User via BIOS Setup");
            dictionCpuStatus.Add(3, "CPU Disabled By BIOS (POST Error)");
            dictionCpuStatus.Add(4, "CPU is Idle");
            dictionCpuStatus.Add(5, "Reserved");
            dictionCpuStatus.Add(6, "Reserved");
            dictionCpuStatus.Add(7, "Other");

            dictionProcessorType = new Dictionary<ushort, string>();
            dictionProcessorType.Add(1, "Other");
            dictionProcessorType.Add(2, "Unknown");
            dictionProcessorType.Add(3, "Central Processor");
            dictionProcessorType.Add(4, "Math Processor");
            dictionProcessorType.Add(5, "DSP Processor");
            dictionProcessorType.Add(6, "Video Processor");

            dictionVoltageCaps = new Dictionary<uint, string>();
            dictionVoltageCaps.Add(1, "5V");
            dictionVoltageCaps.Add(2, "3.3V");
            dictionVoltageCaps.Add(4, "2.9V");
        }
        public Dictionary<uint, string> YxDictionVoltageCaps
        {
            get
            {
                GetParser();
                return dictionVoltageCaps;
            }
        }
        public Dictionary<ushort, string> YxDictionProcessorType
        {
            get
            {
                GetParser();
                return dictionProcessorType;
            }
        }

        public Dictionary<ushort, string> YxDictionCpuStatus
        {
            get
            {
                GetParser();
                return dictionCpuStatus;
            }
        }
        public Dictionary<ushort, string> YxDictionArchitecture
        {
            get
            {
                GetParser();
                return dictionArchitecture;
            }
        }
        /// <summary>
        /// 得到VoltageCaps的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetVoltageCapsbyInt(uint key)
        {
            string dic;
            bool a = YxDictionVoltageCaps.TryGetValue(key, out dic);
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
        /// 得到CpuStatus的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetCpuStatusbyInt(ushort key)
        {
            string dic;
            bool a = YxDictionCpuStatus.TryGetValue(key, out dic);
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
        /// 得到Architecture的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetArchitecturebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionArchitecture.TryGetValue(key, out dic);
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
        /// 得到ProcessorType的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetProcessorTypebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionProcessorType.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }



        public override uint Reset()
        {
            return uint.MaxValue;
        }

        public override uint SetPowerState(ushort PowerState, DateTime Time)
        {
            return uint.MaxValue;
        }
    }
}
