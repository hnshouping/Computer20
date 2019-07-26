using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32PhysicalMemory : CIMPhysicalMemory
    {
        private string deviceLocator;
        private UInt16 interleaveDataDepth;

        /// <summary>
        ///�����ڴ�Ĳ����͵�·��ı�ǩ
        /// </summary>        
        public string DeviceLocator
        {
            get { return deviceLocator; }
            set { deviceLocator = value; }
        }
        /// <summary>
        ///�����ڼ���λ�ý���һ������ʽ�ڼ�
        /// </summary>        
        public UInt16 InterleaveDataDepth
        {
            get { return interleaveDataDepth; }
            set { interleaveDataDepth = value; }
        }
        public override string ToString()
        {
            int a = int.Parse(Capacity.ToString()) / 1024 / 1024;
            return a.ToString() + "MB" + Caption.ToString();
        }
    }
}
