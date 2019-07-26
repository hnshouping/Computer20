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
        /// 如果真,这个包能被热交换
        /// </summary>
        public bool HotSwappable
        {
            get { return hotSwappable; }
            set { hotSwappable = value; }
        }
        /// <summary>
        ///如真,这元素可被计划内外的物理容器正常替换,完全的替换.
        /// </summary>        
        public bool Removable
        {
            get { return removable; }
            set { removable = value; }
        }
        /// <summary>
        ///如真,它是可被身体上不同的一部分代替
        /// </summary>        
        public bool Replaceable
        {
            get { return replaceable; }
            set { replaceable = value; }
        }
    }
}
