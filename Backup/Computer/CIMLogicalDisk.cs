using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public abstract class CIMLogicalDisk : CIMStorageExtent
    {
        private UInt64 freeSpace;
        private UInt64 size;
        /// <summary>
        /// 在逻辑盘上可用到的自由空间,用字节
        /// </summary>
        public UInt64 FreeSpace
        {
            get { return freeSpace; }
            set { freeSpace = value; }
        }
        /// <summary>
        /// 逻辑盘的大小,用字节
        /// </summary>
        public UInt64 Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
