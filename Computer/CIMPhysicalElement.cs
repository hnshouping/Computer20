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
        /// ��ʵ������,������������
        /// </summary>
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        /// <summary>
        /// ĳԪ��һ��ͨ�õ�����
        /// </summary>
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        /// <summary>
        /// ��ʹ��ʶ��һ��Ԫ����������Ϣ
        /// </summary>
        public string OtherIdentifyingInfo
        {
            get { return otherIdentifyingInfo; }
            set { otherIdentifyingInfo = value; }
        }
        /// <summary>
        /// ��֯������������Ҿֲ�����
        /// </summary>
        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }
        /// <summary>
        /// ����棬���Ԫ�����ж����ģ��������ڿ���
        /// </summary>
        public bool PoweredOn
        {
            get { return poweredOn; }
            set { poweredOn = value; }
        }
        /// <summary>
        /// ���ҷ�������Ԫ���ĺ���
        /// </summary>
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        /// <summary>
        /// ��õĵ�λ
        /// </summary>
        public string SKU
        {
            get { return sku; }
            set { sku = value; }
        }
        /// <summary>
        /// ���Ԫ���ı�ǩ
        /// </summary>
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        /// <summary>
        /// ָ�����Ԫ���İ汾
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
