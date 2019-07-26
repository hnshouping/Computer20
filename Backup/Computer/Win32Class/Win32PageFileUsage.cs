using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32PageFileUsage : CIMLogicalElement
    {

        private UInt32 allocatedBaseSize;
        private UInt32 currentUsage;
        private UInt32 peakUsage;
        private bool tempPageFile;

        /// <summary>
        /// 为这页文件分配的硬盘空间
        /// </summary>
        public UInt32 AllocatedBaseSize
        {
            get { return allocatedBaseSize; }
            set { allocatedBaseSize = value; }
        }
        /// <summary>
        /// 当前被硬盘使用的总的空间,通过页文件计算
        /// </summary>
        public UInt32 CurrentUsage
        {
            get { return currentUsage; }
            set { currentUsage=value; }
        }
        /// <summary>
        /// 最高使用的页文件
        /// </summary>
        public UInt32 PeakUsage
        {
            get { return peakUsage; }
            set { peakUsage = value; }
        }
        /// <summary>
        /// 如真,一个临时页文件成立,通常因为没有永久的页文件在当前计算机上
        /// </summary>
        public bool TempPageFile
        {
            get { return tempPageFile; }
            set { tempPageFile = value; }
        }

    }
}
