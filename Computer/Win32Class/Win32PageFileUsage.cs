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
        /// Ϊ��ҳ�ļ������Ӳ�̿ռ�
        /// </summary>
        public UInt32 AllocatedBaseSize
        {
            get { return allocatedBaseSize; }
            set { allocatedBaseSize = value; }
        }
        /// <summary>
        /// ��ǰ��Ӳ��ʹ�õ��ܵĿռ�,ͨ��ҳ�ļ�����
        /// </summary>
        public UInt32 CurrentUsage
        {
            get { return currentUsage; }
            set { currentUsage=value; }
        }
        /// <summary>
        /// ���ʹ�õ�ҳ�ļ�
        /// </summary>
        public UInt32 PeakUsage
        {
            get { return peakUsage; }
            set { peakUsage = value; }
        }
        /// <summary>
        /// ����,һ����ʱҳ�ļ�����,ͨ����Ϊû�����õ�ҳ�ļ��ڵ�ǰ�������
        /// </summary>
        public bool TempPageFile
        {
            get { return tempPageFile; }
            set { tempPageFile = value; }
        }

    }
}
