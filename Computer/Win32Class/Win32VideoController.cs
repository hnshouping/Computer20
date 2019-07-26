using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32VideoController : CIMPCVideoController
    {
        private string adapterCompatibility;
        private string adapterDACType;
        private UInt32 adapterRAM;
        private UInt32 colorTableEntries;
        private UInt32 deviceSpecificPens;
        private UInt32 ditherType;
        private DateTime driverDate;    
        private string cim_driverDate;
        private string driverVersion;
        private UInt32 iCMIntent;
        private UInt32 iCMMethod;
        private string infFilename;
        private string infSection;
        private string installedDisplayDrivers;
        private bool monochrome;
        private UInt32 reservedSystemPaletteEntries;
        private UInt32 specificationVersion;
        private UInt32 systemPaletteEntries;
        private string videoModeDescription;

        private Dictionary<uint, string> dictionICMIntent;
        private Dictionary<uint, string> dictionICMMethod;
        private Dictionary<uint, string> dictionDitherType;

        /// <summary>
        /// Ϊ����Ա��ϵͳоƬ�ıȽϼ�����
        /// </summary>
        public string AdapterCompatibility
        {
            get { return adapterCompatibility; }
            set { adapterCompatibility = value; }
        }
        /// <summary>
        /// DACоƬ�ļ�֤�˻�����
        /// </summary>
        public string AdapterDACType
        {
            get { return adapterDACType; }
            set { adapterDACType = value; }
        }
        /// <summary>
        /// �Դ�ĳߴ�
        /// </summary>
        public UInt32 AdapterRAM
        {
            get { return adapterRAM; }
            set { adapterRAM = value; }
        }
        /// <summary>
        /// ϵͳ��ɫ��ĳߴ�
        /// </summary>
        public UInt32 ColorTableEntries
        {
            get { return colorTableEntries; }
            set { colorTableEntries = value; }
        }
        /// <summary>
        ///device-specific pens�ĵ�ǰ���� 
        /// </summary>
        public UInt32 DeviceSpecificPens
        {
            get { return deviceSpecificPens; }
            set { deviceSpecificPens = value; }
        }
        /// <summary>
        /// �Կ��ķ�������
        /// </summary>
        public UInt32 DitherType
        {
            get { return ditherType; }
            set { ditherType = value; }
        }
        /// <summary>
        /// ���װ�Կ�������ʱ��
        /// </summary>
        public DateTime DriverDate
        {
            get 
            {
                driverDate = DmtfConverter.ToDateTime(cim_driverDate);
                return driverDate; 
            }
        }
        public string Cim_DriverDate
        {
            get { return cim_driverDate; }
            set { cim_driverDate = value; }
        }
        /// <summary>
        /// �Կ������İ汾��
        /// </summary>
        public string DriverVersion
        {
            get { return driverVersion; }
            set { driverVersion = value; }
        }
        /// <summary>
        /// ������ɫƥ�䷽���е�Ψһ��ȷֵ����ʹ��Ĭ�ϵ�
        /// </summary>
        public UInt32 ICMIntent
        {
            get { return iCMIntent; }
            set { iCMIntent = value; }
        }
        /// <summary>
        /// ICM����ķ���
        /// </summary>
        public UInt32 ICMMethod
        {
            get { return iCMMethod; }
            set { iCMMethod = value; }
        }
        /// <summary>
        /// �Կ�INF�ļ���·�� Example: "C:\WINNT\SYSTEM32\DRIVERS"
        /// </summary>
        public string InfFilename
        {
            get { return infFilename; }
            set { infFilename = value; }
        }
        /// <summary>
        /// Section of the .inf file where the Windows video information resides
        /// .inf�ļ�windows�Կ���Ϣ�Ĳ���
        /// </summary>
        public string InfSection
        {
            get { return infSection; }
            set { infSection = value; }
        }
        /// <summary>
        /// ����װ������
        /// </summary>
        public string InstalledDisplayDrivers
        {
            get { return installedDisplayDrivers; }
            set { installedDisplayDrivers = value; }
        }
        /// <summary>
        /// ����,�Ҷ�ʹ�õ�ͼ��
        /// </summary>
        public bool Monochrome
        {
            get { return monochrome; }
            set { monochrome = value; }
        }
        /// <summary>
        /// ��ϵͳ��ɫ���ϱ�����Ŀ������
        /// </summary>
        public UInt32 ReservedSystemPaletteEntries
        {
            get { return reservedSystemPaletteEntries; }
            set { reservedSystemPaletteEntries = value; }
        }
        /// <summary>
        /// ��窻�����˵����İ汾��
        /// </summary>
        public UInt32 SpecificationVersion
        {
            get { return specificationVersion; }
            set { specificationVersion = value; }
        }
        /// <summary>
        /// Current number of color index entries in the system palette
        /// ��ϵͳ��ɫ�е���ɫ��������
        /// </summary>
        public UInt32 SystemPaletteEntries
        {
            get { return systemPaletteEntries; }
            set { systemPaletteEntries = value; }
        }
        /// <summary>
        /// ���������õ�, ��ɫ, ��ɨ��ģʽ .Example: "1024 x 768 x 256 colors"
        /// </summary>
        public string VideoModeDescription
        {
            get { return videoModeDescription; }
            set { videoModeDescription = value; }
        }

        public Dictionary<uint, string> YxDictionICMIntent
        {
            get
            {
                GetParser();
                return dictionICMIntent;
            }
        }
        public Dictionary<uint, string> YxDictionICMMethod
        {
            get
            {
                GetParser();
                return dictionICMMethod;
            }
        }
        public Dictionary<uint, string> YxDictionDitherType
        {
            get
            {
                GetParser();
                return dictionDitherType;
            }
        }
        /// <summary>
        /// �õ�ICMIntent����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetICMIntentbyInt(uint key)
        {
            string dic;
            bool a = YxDictionICMIntent.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        /// <summary>
        /// �õ�ICMMethod����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetICMMethodbyInt(uint key)
        {
            string dic;
            bool a = YxDictionICMMethod.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        /// <summary>
        /// �õ�DitherType����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetDitherTypebyInt(uint key)
        {
            string dic;
            bool a = YxDictionDitherType.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }

        private void GetParser()
        {
            dictionDitherType = new Dictionary<uint, string>();
            dictionDitherType.Add(1, "No dithering");
            dictionDitherType.Add(2, "Dithering with a coarse brush");
            dictionDitherType.Add(3, "Dithering with a fine brush");
            dictionDitherType.Add(4, "Line art dithering");
            dictionDitherType.Add(5, "Device does gray scaling");

            dictionICMIntent = new Dictionary<uint, string>();
            dictionICMIntent.Add(1, "Saturation");
            dictionICMIntent.Add(2, "Contrast");
            dictionICMIntent.Add(3, "Exact Color");

            dictionICMMethod = new Dictionary<uint, string>();
            dictionICMMethod.Add(1, "Disabled");
            dictionICMMethod.Add(2, "Windows");
            dictionICMMethod.Add(3, "Device Driver");
            dictionICMMethod.Add(4, "Destination De");
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
