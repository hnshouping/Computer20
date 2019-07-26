using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public abstract class CIMVideoController : CIMController
    {
        private UInt16[] acceleratorCapabilities;
        private string[] capabilityDescriptions;
        private UInt32 currentBitsPerPixel;
        private UInt32 currentHorizontalResolution;
        private UInt64 currentNumberOfColors;
        private UInt32 currentNumberOfColumns;
        private UInt32 currentNumberOfRows;
        private UInt32 currentRefreshRate;
        private UInt16 currentScanMode;
        private UInt32 currentVerticalResolution;
        private UInt32 maxMemorySupported;
        private UInt32 maxRefreshRate;
        private UInt32 minRefreshRate;
        private UInt32 numberOfVideoPages;
        private UInt16 videoMemoryType;
        private string videoProcessor;


        private Dictionary<ushort, string> dictionVideoMemoryType;
        private Dictionary<ushort, string> dictionCurrentScanMode;

        private void GetParser()
        {
            dictionCurrentScanMode = new Dictionary<ushort, string>();
            dictionCurrentScanMode.Add(1, "Other");
            dictionCurrentScanMode.Add(2, "Unknown");
            dictionCurrentScanMode.Add(3, "Interlaced");
            dictionCurrentScanMode.Add(4, "Noninterlaced");

            dictionVideoMemoryType = new Dictionary<ushort, string>();
            dictionVideoMemoryType.Add(1, "Other");
            dictionVideoMemoryType.Add(2, "Unknown");
            dictionVideoMemoryType.Add(3, "VRAM");
            dictionVideoMemoryType.Add(4, "DRAM");
            dictionVideoMemoryType.Add(5, "SRAM");
            dictionVideoMemoryType.Add(6, "WRAM");
            dictionVideoMemoryType.Add(7, "EDO RAM");
            dictionVideoMemoryType.Add(8, "Burst Synchronous DRAM");
            dictionVideoMemoryType.Add(9, "Pipelined Burst SRAM");
            dictionVideoMemoryType.Add(10, "CDRAM");
            dictionVideoMemoryType.Add(11, "3DRAM");
            dictionVideoMemoryType.Add(12, "SDRAM");
            dictionVideoMemoryType.Add(13, "SGRAM");
        }


        /// <summary>
        /// �Կ���Graphics��3-D����
        /// </summary>
        public UInt16[] AcceleratorCapabilities
        {
            get { return acceleratorCapabilities; }
            set { acceleratorCapabilities = value; }
        }
        /// <summary>
        /// �������������ֵ���Կ�������ò������
        /// </summary>
        public string[] CapabilityDescriptions
        {
            get { return capabilityDescriptions; }
            set { capabilityDescriptions = value; }
        }
        /// <summary>
        /// ����ʾ��������λ������
        /// </summary>
        public UInt32 CurrentBitsPerPixel
        {
            get { return currentBitsPerPixel; }
            set { currentBitsPerPixel = value; }
        }
        /// <summary>
        /// ��ǰˮƽ���ص�����
        /// </summary>
        public UInt32 CurrentHorizontalResolution
        {
            get { return currentHorizontalResolution; }
            set { currentHorizontalResolution = value; }
        }
        /// <summary>
        /// ��ǰ����֧�ֵ���ɫ��
        /// </summary>
        public UInt64 CurrentNumberOfColors
        {
            get { return currentNumberOfColors; }
            set { currentNumberOfColors = value; }
        }
        /// <summary>
        /// �����������ģʽ,�Կ��е�����,����,����0
        /// </summary>
        public UInt32 CurrentNumberOfColumns
        {
            get { return currentNumberOfColumns; }
            set { currentNumberOfColumns = value; }
        }
        /// <summary>
        /// �����������ģʽ,�Կ��е�����,����,����0
        /// </summary>
        public UInt32 CurrentNumberOfRows
        {
            get { return currentNumberOfRows; }
            set { currentNumberOfRows = value; }
        }
        /// <summary>
        /// ��ǰ�ĸ����ٶ�,��HZ(����)
        /// </summary>
        public UInt32 CurrentRefreshRate
        {
            get { return currentRefreshRate; }
            set { currentRefreshRate = value; }
        }
        /// <summary>
        /// ��ǰ��ɨ��ģʽ
        /// </summary>
        public UInt16 CurrentScanMode
        {
            get { return currentScanMode; }
            set { currentScanMode = value; }
        }
        /// <summary>
        /// ��ֱ���ص�����
        /// </summary>
        public UInt32 CurrentVerticalResolution
        {
            get { return currentVerticalResolution; }
            set { currentVerticalResolution = value; }
        }
        /// <summary>
        /// �ܵ��ڴ�֧��,���ֽ�
        /// </summary>
        public UInt32 MaxMemorySupported
        {
            get { return maxMemorySupported; }
            set { maxMemorySupported = value; }
        }
        /// <summary>
        /// �Կ����ˢ����,��Hz(����)
        /// </summary>
        public UInt32 MaxRefreshRate
        {
            get { return maxRefreshRate; }
            set { maxRefreshRate = value; }
        }
        /// <summary>
        /// �Կ���Сˢ����,��Hz(����)
        /// </summary>
        public UInt32 MinRefreshRate
        {
            get { return minRefreshRate; }
            set { minRefreshRate = value; }
        }
        /// <summary>
        /// ���⵱ǰ����Ϳ����ڴ�֧����ʾҳ������
        /// </summary>
        public UInt32 NumberOfVideoPages
        {
            get { return numberOfVideoPages; }
            set { numberOfVideoPages = value; }
        }
        /// <summary>
        /// �Դ������
        /// </summary>
        public UInt16 VideoMemoryType
        {
            get { return videoMemoryType; }
            set { videoMemoryType = value; }
        }
        /// <summary>
        /// ���Կ�������������
        /// </summary>
        public string VideoProcessor
        {
            get { return videoProcessor; }
            set { videoProcessor = value; }
        }
        /// <summary>
        /// �õ�VideoMemoryType����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetVideoMemoryTypebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionVideoMemoryType.TryGetValue(key, out dic);
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
        /// �õ�CurrentScanMode����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetCurrentScanModebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionCurrentScanMode.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        public Dictionary<ushort, string> YxDictionVideoMemoryType
        {
            get
            {
                GetParser();
                return dictionVideoMemoryType;
            }
        }
        public Dictionary<ushort, string> YxDictionCurrentScanMode
        {
            get
            {
                GetParser();
                return dictionCurrentScanMode;
            }
        }
    }
}
