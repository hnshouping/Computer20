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
        /// 显卡的Graphics和3-D能力
        /// </summary>
        public UInt16[] AcceleratorCapabilities
        {
            get { return acceleratorCapabilities; }
            set { acceleratorCapabilities = value; }
        }
        /// <summary>
        /// 进入加速器对列值的显卡加速面貌的描述
        /// </summary>
        public string[] CapabilityDescriptions
        {
            get { return capabilityDescriptions; }
            set { capabilityDescriptions = value; }
        }
        /// <summary>
        /// 在显示器上像素位的数量
        /// </summary>
        public UInt32 CurrentBitsPerPixel
        {
            get { return currentBitsPerPixel; }
            set { currentBitsPerPixel = value; }
        }
        /// <summary>
        /// 当前水平像素的数量
        /// </summary>
        public UInt32 CurrentHorizontalResolution
        {
            get { return currentHorizontalResolution; }
            set { currentHorizontalResolution = value; }
        }
        /// <summary>
        /// 当前决定支持的颜色号
        /// </summary>
        public UInt64 CurrentNumberOfColors
        {
            get { return currentNumberOfColors; }
            set { currentNumberOfColors = value; }
        }
        /// <summary>
        /// 如果进入文字模式,显卡列的数量,否则,进入0
        /// </summary>
        public UInt32 CurrentNumberOfColumns
        {
            get { return currentNumberOfColumns; }
            set { currentNumberOfColumns = value; }
        }
        /// <summary>
        /// 如果进入文字模式,显卡行的数量,否则,进入0
        /// </summary>
        public UInt32 CurrentNumberOfRows
        {
            get { return currentNumberOfRows; }
            set { currentNumberOfRows = value; }
        }
        /// <summary>
        /// 当前的更新速度,用HZ(赫兹)
        /// </summary>
        public UInt32 CurrentRefreshRate
        {
            get { return currentRefreshRate; }
            set { currentRefreshRate = value; }
        }
        /// <summary>
        /// 当前的扫描模式
        /// </summary>
        public UInt16 CurrentScanMode
        {
            get { return currentScanMode; }
            set { currentScanMode = value; }
        }
        /// <summary>
        /// 垂直像素的数量
        /// </summary>
        public UInt32 CurrentVerticalResolution
        {
            get { return currentVerticalResolution; }
            set { currentVerticalResolution = value; }
        }
        /// <summary>
        /// 总的内存支持,用字节
        /// </summary>
        public UInt32 MaxMemorySupported
        {
            get { return maxMemorySupported; }
            set { maxMemorySupported = value; }
        }
        /// <summary>
        /// 显卡最大刷新率,用Hz(赫兹)
        /// </summary>
        public UInt32 MaxRefreshRate
        {
            get { return maxRefreshRate; }
            set { maxRefreshRate = value; }
        }
        /// <summary>
        /// 显卡最小刷新率,用Hz(赫兹)
        /// </summary>
        public UInt32 MinRefreshRate
        {
            get { return minRefreshRate; }
            set { minRefreshRate = value; }
        }
        /// <summary>
        /// 给这当前决议和可用内存支持显示页的数量
        /// </summary>
        public UInt32 NumberOfVideoPages
        {
            get { return numberOfVideoPages; }
            set { numberOfVideoPages = value; }
        }
        /// <summary>
        /// 显存的类型
        /// </summary>
        public UInt16 VideoMemoryType
        {
            get { return videoMemoryType; }
            set { videoMemoryType = value; }
        }
        /// <summary>
        /// 对显卡处理器的描述
        /// </summary>
        public string VideoProcessor
        {
            get { return videoProcessor; }
            set { videoProcessor = value; }
        }
        /// <summary>
        /// 得到VideoMemoryType的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
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
                throw new Exception("没有找到这个键的值");
            }
        }
        /// <summary>
        /// 得到CurrentScanMode的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
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
                throw new Exception("没有找到这个键的值");
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
