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
        ///保荐内存的插座和电路板的标签
        /// </summary>        
        public string DeviceLocator
        {
            get { return deviceLocator; }
            set { deviceLocator = value; }
        }
        /// <summary>
        ///物理内荐的位置进入一个交错式内荐
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
