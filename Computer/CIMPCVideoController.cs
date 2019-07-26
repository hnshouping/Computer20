using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public abstract class CIMPCVideoController : CIMVideoController
    {
        private UInt16 numberOfColorPlanes;
        private UInt16 videoArchitecture;
        private UInt16 videoMode;

        private Dictionary<ushort, string> dictionVideoArchitecture;


        /// <summary>
        /// 色彩平面的当前号
        /// </summary>
        public UInt16 NumberOfColorPlanes
        {
            get { return numberOfColorPlanes; }
            set { numberOfColorPlanes = value; }
        }
        /// <summary>
        /// 显卡结构
        /// </summary>
        public UInt16 VideoArchitecture
        {
            get { return videoArchitecture; }
            set { videoArchitecture = value; }
        }
        /// <summary>
        /// 当前显卡模式
        /// </summary>
        public UInt16 VideoMode
        {
            get { return videoMode; }
            set { videoMode = value; }
        }
        /// <summary>
        /// 得到FileSystemFlagsEx的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetVideoArchitecturebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionVideoArchitecture.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }
        public Dictionary<ushort, string> YxDictionVideoArchitecture
        {
            get
            {
                GetParser();
                return dictionVideoArchitecture;
            }
        }
        private void GetParser()
        {
            dictionVideoArchitecture = new Dictionary<ushort, string>();
            dictionVideoArchitecture.Add(1, "Other");
            dictionVideoArchitecture.Add(2, "Unknown");
            dictionVideoArchitecture.Add(3, "CGA");
            dictionVideoArchitecture.Add(4, "EGA");
            dictionVideoArchitecture.Add(5, "VGA");
            dictionVideoArchitecture.Add(6, "SVGA");
            dictionVideoArchitecture.Add(7, "MDA");
            dictionVideoArchitecture.Add(8, "HGC");
            dictionVideoArchitecture.Add(9, "MCGA");
            dictionVideoArchitecture.Add(10, "8514A");
            dictionVideoArchitecture.Add(11, "XGA");
            dictionVideoArchitecture.Add(12, "Linear frame buffer");
            dictionVideoArchitecture.Add(160, "PC-98");
        }
    }
}
