using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer
{
    public class CIMPhysicalPackage : CIMPhysicalElement
    {
        
        private Single depth;
        private Single height;
        private bool hotSwappable;
        private bool removable;
        private bool replaceable;
        private Single weight;
        private Single width;
        /// <summary>
        /// ��Ӣ���ʾԪ�������
        /// </summary>
        public Single Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        /// <summary>
        /// ��Ӣ���ʾԪ���ĸ߶�
        /// </summary>
        public Single Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>
        /// ����棬Ԫ�����Ա���ȫ���滻
        /// </summary>
        public bool HotSwappable
        {
            get { return hotSwappable; }
            set { hotSwappable = value; }
        }
        /// <summary>
        /// �Ƿ񼴲弴����
        /// </summary>
        public bool Removable
        {
            get { return removable; }
            set { removable = value; }
        }
        /// <summary>
        /// �Ƿ���ɳ���
        /// </summary>
        public bool Replaceable
        {
            get { return replaceable; }
            set { replaceable = value; }
        }
        /// <summary>
        /// ��Ӣ���ʾԪ��������
        /// </summary>
        public Single Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>
        /// ��Ӣ���ʾԪ������ȿ��
        /// </summary>
        public Single Width
        {
            get { return width; }
            set { width = value; }
        }

        public CIMPhysicalPackage()
        {
        }
    }
}
