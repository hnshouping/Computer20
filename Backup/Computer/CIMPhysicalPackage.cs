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
        /// 用英寸表示元件的深度
        /// </summary>
        public Single Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        /// <summary>
        /// 用英寸表示元件的高度
        /// </summary>
        public Single Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>
        /// 如果真，元件可以被完全的替换
        /// </summary>
        public bool HotSwappable
        {
            get { return hotSwappable; }
            set { hotSwappable = value; }
        }
        /// <summary>
        /// 是否即插即用型
        /// </summary>
        public bool Removable
        {
            get { return removable; }
            set { removable = value; }
        }
        /// <summary>
        /// 是否许可超载
        /// </summary>
        public bool Replaceable
        {
            get { return replaceable; }
            set { replaceable = value; }
        }
        /// <summary>
        /// 用英寸表示元件的重量
        /// </summary>
        public Single Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>
        /// 用英寸表示元件的深度宽度
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
