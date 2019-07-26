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
        /// ɫ��ƽ��ĵ�ǰ��
        /// </summary>
        public UInt16 NumberOfColorPlanes
        {
            get { return numberOfColorPlanes; }
            set { numberOfColorPlanes = value; }
        }
        /// <summary>
        /// �Կ��ṹ
        /// </summary>
        public UInt16 VideoArchitecture
        {
            get { return videoArchitecture; }
            set { videoArchitecture = value; }
        }
        /// <summary>
        /// ��ǰ�Կ�ģʽ
        /// </summary>
        public UInt16 VideoMode
        {
            get { return videoMode; }
            set { videoMode = value; }
        }
        /// <summary>
        /// �õ�FileSystemFlagsEx����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
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
                throw new Exception("û���ҵ��������ֵ");
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
