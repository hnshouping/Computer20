using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32SoundDevice : CIMLogicalDevice
    {
        private UInt16 dMABufferSize;
        private string manufacturer;
        private UInt32 mPU401Address;
        private string productName;

        private WmiCommon wmi;

        public Win32SoundDevice()
        {
            wmi = new WmiCommon();
        }

        /// <summary>
        /// 直接使用内存的尺寸
        /// </summary>
        public UInt16 DMABufferSize
        {
            get { return dMABufferSize; }
            set { dMABufferSize = value; }
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
        /// 开始I/O地址分配给声卡驱动的MPU-401端口
        /// </summary>
        public UInt32 MPU401Address
        {
            get { return mPU401Address; }
            set { mPU401Address = value; }
        }
        /// <summary>
        /// 声卡的产品名 如:"Creative Labs SoundBlaster AWE64PNP"
        /// </summary>
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public override uint Reset()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override uint SetPowerState(ushort PowerState, DateTime Time)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
