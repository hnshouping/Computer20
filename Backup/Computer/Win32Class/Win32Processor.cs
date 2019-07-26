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
        /// ������������ʹ����ƽ̨
        /// </summary>
        public UInt16 Architecture
        {
            get { return architecture; }
            set { architecture = value; }
        }
        /// <summary>
        ///  CPU�ĵ�ǰ״̬
        /// </summary>
        public UInt16 CpuStatus
        {
            get { return cpuStatus; }
            set { cpuStatus = value; }
        }
        /// <summary>
        /// �������ĵ�ѹ
        /// </summary>
        public UInt16 CurrentVoltage
        {
            get { return currentVoltage; }
            set { currentVoltage = value; }
        }
        /// <summary>
        /// �׺��ȵ��ⲿʱ��Ƶ��
        /// </summary>
        public UInt32 ExtClock
        {
            get { return extClock; }
            set { extClock = value; }
        }
        /// <summary>
        ///���������漶��2�ĳߴ� 
        /// </summary>
        public UInt32 L2CacheSize
        {
            get { return l2CacheSize; }
            set { l2CacheSize = value; }
        }
        /// <summary>
        /// ���������漶��2���ٶ�
        /// </summary>
        public UInt32 L2CacheSpeed
        {
            get { return l2CacheSpeed; }
            set { l2CacheSpeed = value; }
        }
        /// <summary>
        /// ���������͵Ķ���
        /// </summary>
        public UInt16 Level
        {
            get { return level; }
            set { level = value; }
        }
        /// <summary>
        /// ��������������
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        /// <summary>
        /// ������������������Ϣ
        /// </summary>
        public string ProcessorId
        {
            get { return processorId; }
            set { processorId = value; }
        }
        /// <summary>
        /// ���Ĵ�����������
        /// </summary>
        public UInt16 ProcessorType
        {
            get { return processorType; }
            set { processorType = value; }
        }
        /// <summary>
        /// ���������ϵ�ϵͳ����
        /// </summary>
        public UInt16 Revision
        {
            get { return revision; }
            set { revision = value; }
        }
        /// <summary>
        /// �ڵ�·��ʹ�õ�оƬ����
        /// </summary>
        public string SocketDesignation
        {
            get { return socketDesignation; }
            set { socketDesignation = value; }
        }
        /// <summary>
        /// ���������ϵĴ������汾��
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        /// <summary>
        /// �������Ķ��ѹ
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
        /// �õ�VoltageCaps����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
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
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        /// <summary>
        /// �õ�CpuStatus����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
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
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        /// <summary>
        /// �õ�Architecture����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
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
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        /// <summary>
        /// �õ�ProcessorType����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
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
                throw new Exception("û���ҵ��������ֵ");
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
