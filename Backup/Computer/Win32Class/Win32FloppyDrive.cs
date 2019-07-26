using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{
    public class Win32FloppyDrive : CIMDisketteDrive
    {
        private string manufacturer;


        private WmiCommon wi;

        public Win32FloppyDrive()
        {
            wi = new WmiCommon();
        }


        /// <summary>
        /// �������ҵ����� ��:"Acme"
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }


        public override uint Reset()
        {
            if (this.wi == null)
            {
                throw new Exception("û��ȡ������");
            }
            string Deviceid = this.DeviceID.ToString().Replace(@"\", @"\\");
            try
            {
                if (this.DeviceID == "" || this.DeviceID == null)
                {
                    throw new Exception("û�����ü�ֵ");
                }
                ManagementObjectCollection moc = wi.GetWSqlFromWMI("SELECT * FROM Win32_FloppyDrive where DeviceID='" + DeviceID + "'");
                uint a = 0;
                //				System.Console.WriteLine("SELECT * FROM Win32_FloppyDrive where DeviceID='"+Deviceid+"'");
                //����Win2000ʱ�д���,û�����κ������ִ���������.�����ǲ�֧��win2000�ͻ�����ԭ��.
                foreach (ManagementObject mo in moc)
                {
                    a = (uint)mo.InvokeMethod("Reset", null);
                }
                return a;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override uint SetPowerState(ushort PowerState, DateTime Time)
        {
            if (this.wi == null)
            {
                throw new Exception("û��ȡ������");
            }
            string Deviceid = this.DeviceID.ToString().Replace(@"\", @"\\");
            //				System.Console.WriteLine("SELECT * FROM Win32_FloppyDrive where DeviceID='"+Deviceid+"'");
            //����Win2000ʱ�д���,û�����κ������ִ���������.�����ǲ�֧��win2000�ͻ�����ԭ��.
            try
            {
                if (this.DeviceID == "" || this.DeviceID == null)
                {
                    throw new Exception("û�����ü�ֵ");
                }
                ManagementObjectCollection moc = wi.GetWSqlFromWMI("SELECT * FROM Win32_FloppyDrive where DeviceID='" + DeviceID + "'");
                uint a = 0;
                foreach (ManagementObject mo in moc)
                {
                    a = (uint)mo.InvokeMethod("SetPowerState", new object[] { PowerState, DmtfConverter.ToDmtfDateTime(Time) });
                }
                return a;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string HintByReturnValue(uint hint)
        {
            switch (hint)
            {
                case 0:
                    return "Success.";
                default:
                    return "error.";
            }
        }
    }
}
