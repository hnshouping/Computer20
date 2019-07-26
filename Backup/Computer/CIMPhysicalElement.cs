using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMPhysicalElement : CIMManagedSystemElement
    {
        private string creationClassName;
        private string manufacturer;
        private string model;
        private string otherIdentifyingInfo;
        private string partNumber;
        private bool poweredOn;
        private string serialNumber;
        private string sku;
        private string tag;
        private string version;

        /// <summary>
        /// 在实例化后,类或子类的名字
        /// </summary>
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// 生产厂家
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        /// <summary>
        /// 某元件一般通用的名字
        /// </summary>
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        /// <summary>
        /// 能使用识别一个元件的其它信息
        /// </summary>
        public string OtherIdentifyingInfo
        {
            get { return otherIdentifyingInfo; }
            set { otherIdentifyingInfo = value; }
        }
        /// <summary>
        /// 组织分配给生产厂家局部号码
        /// </summary>
        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }
        /// <summary>
        /// 如果真，这个元件是有动力的，否则现在空闲
        /// </summary>
        public bool PoweredOn
        {
            get { return poweredOn; }
            set { poweredOn = value; }
        }
        /// <summary>
        /// 厂家分配给这个元件的号码
        /// </summary>
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        /// <summary>
        /// 最常用的单位
        /// </summary>
        public string SKU
        {
            get { return sku; }
            set { sku = value; }
        }
        /// <summary>
        /// 这个元件的标签
        /// </summary>
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        /// <summary>
        /// 指出这个元件的版本
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public CIMPhysicalElement()
        {
        }

    }
}
