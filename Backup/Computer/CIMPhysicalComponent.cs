using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMPhysicalComponent : CIMPhysicalElement
    {
        private bool hotSwappable;
        private bool removable;
        private bool replaceable;

        /// <summary>
        /// �����,������ܱ��Ƚ���
        /// </summary>
        public bool HotSwappable
        {
            get { return hotSwappable; }
            set { hotSwappable = value; }
        }
        /// <summary>
        ///����,��Ԫ�ؿɱ��ƻ�������������������滻,��ȫ���滻.
        /// </summary>        
        public bool Removable
        {
            get { return removable; }
            set { removable = value; }
        }
        /// <summary>
        ///����,���ǿɱ������ϲ�ͬ��һ���ִ���
        /// </summary>        
        public bool Replaceable
        {
            get { return replaceable; }
            set { replaceable = value; }
        }
    }
}
