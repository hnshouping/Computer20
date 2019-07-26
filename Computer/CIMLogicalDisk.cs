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
        /// ���߼����Ͽ��õ������ɿռ�,���ֽ�
        /// </summary>
        public UInt64 FreeSpace
        {
            get { return freeSpace; }
            set { freeSpace = value; }
        }
        /// <summary>
        /// �߼��̵Ĵ�С,���ֽ�
        /// </summary>
        public UInt64 Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
