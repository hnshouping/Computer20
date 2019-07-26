using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WmiInfo;

namespace ConsoleApplication1
{
    class Program
    {
        static void aMain(string[] args)
        {
            

            //StreamWriter sw = new StreamWriter("d:/b.txt");

            //Win32Directory wd = new Win32Directory();
            //wd.YxDictionAccessMask = new Dictionary<uint, string>();
            //wd.YxDictionAccessMask.Add(0, "FILE_LIST_DIRECTORY");
            //wd.YxDictionAccessMask.Add(1, "FILE_ADD_FILE");
            //wd.YxDictionAccessMask.Add(2, "FILE_ADD_SUBDIRECTORY");
            //wd.YxDictionAccessMask.Add(3, "FILE_READ_EA");
            //wd.YxDictionAccessMask.Add(4, "FILE_WRITE_EA");
            //wd.YxDictionAccessMask.Add(5, "FILE_TRAVERSE");
            //wd.YxDictionAccessMask.Add(6, "FILE_DELETE_CHILD");
            //wd.YxDictionAccessMask.Add(7, "FILE_READ_ATTRIBUTES");
            //wd.YxDictionAccessMask.Add(8, "FILE_WRITE_ATTRIBUTES");
            //wd.YxDictionAccessMask.Add(16, "DELETE");
            //wd.YxDictionAccessMask.Add(17, "READ_CONTROL");
            //wd.YxDictionAccessMask.Add(18, "WRITE_DAC");
            //wd.YxDictionAccessMask.Add(19, "WRITE_OWNER");
            //wd.YxDictionAccessMask.Add(20, "SYNCHRONIZE");
            //Win32CDROMDrive a = new Win32CDROMDrive();
            //a.YxDictionAvailability = new Dictionary<uint, string>();
            //a.YxDictionCapabilities = new Dictionary<uint, string>();
            //a.YxDictionConfigManagerErrorCode = new Dictionary<uint, string>();
            //a.YxDictionFileSystemFlagsEx = new Dictionary<uint, string>();
            //a.YxDictionPowerManagementCapabilities = new Dictionary<uint, string>();
            //a.YxDictionStatusInfo = new Dictionary<uint, string>();

            //a.YxDictionAvailability.Add(1, "Other");
            //a.YxDictionAvailability.Add(2, "Unknown");
            //a.YxDictionAvailability.Add(3, "Running/Full Power");
            //a.YxDictionAvailability.Add(4, "Warning");
            //a.YxDictionAvailability.Add(5, "In Test");
            //a.YxDictionAvailability.Add(6, "Not Applicable");
            //a.YxDictionAvailability.Add(7, "Power Off");
            //a.YxDictionAvailability.Add(8, "Off Line");
            //a.YxDictionAvailability.Add(9, "Off Duty");
            //a.YxDictionAvailability.Add(10, "Degraded");
            //a.YxDictionAvailability.Add(11, "Not Installed");
            //a.YxDictionAvailability.Add(12, "Install Error");
            //a.YxDictionAvailability.Add(13, "Power Save - Unknown");
            //a.YxDictionAvailability.Add(14, "Power Save - Low Power Mode");
            //a.YxDictionAvailability.Add(15, "Power Save - Standby");
            //a.YxDictionAvailability.Add(16, "Power Cycle");
            //a.YxDictionAvailability.Add(17, "Power Save - Warning");


            //a.YxDictionCapabilities.Add(0, "Unknown");
            //a.YxDictionCapabilities.Add(1, "Other");
            //a.YxDictionCapabilities.Add(2, "Sequential Access");
            //a.YxDictionCapabilities.Add(3, "Random Access");
            //a.YxDictionCapabilities.Add(4, "Supports Writing");
            //a.YxDictionCapabilities.Add(5, "Encryption");
            //a.YxDictionCapabilities.Add(6, "Compression");
            //a.YxDictionCapabilities.Add(7, "Supports Removable Media");
            //a.YxDictionCapabilities.Add(8, "Manual Cleaning");
            //a.YxDictionCapabilities.Add(9, "Automatic Cleaning");
            //a.YxDictionCapabilities.Add(10, "SMART Notification");
            //a.YxDictionCapabilities.Add(11, "Supports Dual-sided Media");
            //a.YxDictionCapabilities.Add(12, "Predismount Eject Not Required");


            //a.YxDictionConfigManagerErrorCode.Add(0, "Device is working properly");
            //a.YxDictionConfigManagerErrorCode.Add(1, "Device is not configured correctly");
            //a.YxDictionConfigManagerErrorCode.Add(2, "Windows cannot load the driver for this device.");
            //a.YxDictionConfigManagerErrorCode.Add(3, "Driver for this device might be corrupted, or the system may be low on memory or other resources.");
            //a.YxDictionConfigManagerErrorCode.Add(4, "Device is not working properly. One of its drivers or the registry might be corrupted.");
            //a.YxDictionConfigManagerErrorCode.Add(5, "Driver for the device requires a resource that Windows cannot manage.");
            //a.YxDictionConfigManagerErrorCode.Add(6, "Boot configuration for the device conflicts with other devices.");
            //a.YxDictionConfigManagerErrorCode.Add(7, "Cannot filter.");
            //a.YxDictionConfigManagerErrorCode.Add(8, "Driver loader for the device is missing.");
            //a.YxDictionConfigManagerErrorCode.Add(9, "Device is not working properly; the controlling firmware is incorrectly reporting the resources for the device.");
            //a.YxDictionConfigManagerErrorCode.Add(10, "Device cannot start.");
            //a.YxDictionConfigManagerErrorCode.Add(11, "Device failed.");
            //a.YxDictionConfigManagerErrorCode.Add(12, "Device cannot find enough free resources to use.");
            //a.YxDictionConfigManagerErrorCode.Add(13, "Windows cannot verify the device's resources.");
            //a.YxDictionConfigManagerErrorCode.Add(14, "Device cannot work properly until the computer is restarted.");
            //a.YxDictionConfigManagerErrorCode.Add(15, "Device is not working properly due to a possible re-enumeration problem.");
            //a.YxDictionConfigManagerErrorCode.Add(16, "Windows cannot identify all of the resources that the device uses.");
            //a.YxDictionConfigManagerErrorCode.Add(17, "Device is requesting an unknown resource type.");
            //a.YxDictionConfigManagerErrorCode.Add(18, "Device drivers need to be reinstalled.");
            //a.YxDictionConfigManagerErrorCode.Add(19, "Failure using the VxD loader.");
            //a.YxDictionConfigManagerErrorCode.Add(20, "Registry might be corrupted.");
            //a.YxDictionConfigManagerErrorCode.Add(21, "System failure. If changing the device driver is ineffective, see the hardware documentation. Windows is removing the device.");
            //a.YxDictionConfigManagerErrorCode.Add(22, "Device is disabled.");
            //a.YxDictionConfigManagerErrorCode.Add(23, "System failure. If changing the device driver is ineffective, see the hardware documentation.");
            //a.YxDictionConfigManagerErrorCode.Add(24, "Device is not present, not working properly, or does not have all of its drivers installed.");
            //a.YxDictionConfigManagerErrorCode.Add(25, "Windows is still setting up the device.");
            //a.YxDictionConfigManagerErrorCode.Add(26, "Windows is still setting up the device.");
            //a.YxDictionConfigManagerErrorCode.Add(27, "Device does not have valid log configuration.");
            //a.YxDictionConfigManagerErrorCode.Add(28, "Device drivers are not installed.");
            //a.YxDictionConfigManagerErrorCode.Add(29, "Device is disabled; the device firmware did not provide the required resources.");
            //a.YxDictionConfigManagerErrorCode.Add(30, "Device is using an IRQ resource that another device is using.");
            //a.YxDictionConfigManagerErrorCode.Add(31, "Device is not working properly; Windows cannot load the required device drivers.");

            //a.YxDictionFileSystemFlagsEx.Add(1, "CASE_SENSITIVE_SEARCH");
            //a.YxDictionFileSystemFlagsEx.Add(2, "CASE_PRESERVED_NAMES");
            //a.YxDictionFileSystemFlagsEx.Add(4, "UNICODE_ON_DISK");
            //a.YxDictionFileSystemFlagsEx.Add(8, "PERSISTENT_ACLS");
            //a.YxDictionFileSystemFlagsEx.Add(16, "FILE_COMPRESSION");
            //a.YxDictionFileSystemFlagsEx.Add(32, "VOLUME_QUOTAS");
            //a.YxDictionFileSystemFlagsEx.Add(64, "SUPPORTS_SPARSE_FILES");
            //a.YxDictionFileSystemFlagsEx.Add(128, "SUPPORTS_REPARSE_POINTS");
            //a.YxDictionFileSystemFlagsEx.Add(256, "SUPPORTS_REMOTE_STORAGE");
            //a.YxDictionFileSystemFlagsEx.Add(16384, "SUPPORTS_LONG_NAMES");
            //a.YxDictionFileSystemFlagsEx.Add(32768, "VOLUME_IS_COMPRESSED");
            //a.YxDictionFileSystemFlagsEx.Add(65536, "SUPPORTS_OBJECT_IDS");
            //a.YxDictionFileSystemFlagsEx.Add(131072, "SUPPORTS_ENCRYPTION");
            //a.YxDictionFileSystemFlagsEx.Add(262144, "SUPPORTS_NAMED_STREAMS");

            //a.YxDictionPowerManagementCapabilities.Add(0, "Unknown");
            //a.YxDictionPowerManagementCapabilities.Add(1, "Not Supported");
            //a.YxDictionPowerManagementCapabilities.Add(2, "Disabled");
            //a.YxDictionPowerManagementCapabilities.Add(3, "Enabled");
            //a.YxDictionPowerManagementCapabilities.Add(4, "Power Saving Modes Entered Automatically");
            //a.YxDictionPowerManagementCapabilities.Add(5, "Power State Settable");
            //a.YxDictionPowerManagementCapabilities.Add(6, "Power Cycling Supported");
            //a.YxDictionPowerManagementCapabilities.Add(7, "Timed Power On Supported");

            //a.YxDictionStatusInfo.Add(1, "Other");
            //a.YxDictionStatusInfo.Add(2, "Unknown");
            //a.YxDictionStatusInfo.Add(3, "Enabled");
            //a.YxDictionStatusInfo.Add(4, "Disabled");
            //a.YxDictionStatusInfo.Add(5, "Not Applicable");



            //Emit(sw, a);
            //sw.WriteLine();
            //sw.Close();
        }
        //public static void Emit(StreamWriter m_outFile, Win32Directory aaaaa)
        //{
        //    MemoryStream stream1 = new MemoryStream();
        //    BinaryFormatter formatter1 = new BinaryFormatter();
        //    //			formatter1.set_AssemblyFormat(0);
        //    formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
        //    Console.WriteLine("Serialising the parser");
        //    formatter1.Serialize(stream1, aaaaa.YxDictionAccessMask);
        //    stream1.Position = 0;
        //    int num1 = 0;
        //    for (int num2 = 0; num2 < stream1.Length; num2++)
        //    {
        //        int num3 = stream1.ReadByte();
        //        if (num1++ == 10)
        //        {
        //            m_outFile.WriteLine();
        //            num1 = 0;
        //        }
        //        m_outFile.Write("{0},", num3);
        //    }
        //    m_outFile.WriteLine("0};");
        //}
        public static void Emit(StreamWriter m_outFile, Win32CDROMDrive aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");
            //formatter1.Serialize(stream1, aaaaa.YxDictionConfigManagerErrorCode);
            formatter1.Serialize(stream1, aaaaa.YxDictionFileSystemFlagsEx);
            //formatter1.Serialize(stream1, aaaaa.YxDictionPowerManagementCapabilities);
            //formatter1.Serialize(stream1, aaaaa.YxDictionStatusInfo);
            //formatter1.Serialize(stream1, aaaaa.YxDictionAvailability);
            //formatter1.Serialize(stream1, aaaaa.YxDictionCapabilities);
            stream1.Position = 0;
            int num1 = 0;
            for (int num2 = 0; num2 < stream1.Length; num2++)
            {
                int num3 = stream1.ReadByte();
                if (num1++ == 10)
                {
                    m_outFile.WriteLine();
                    num1 = 0;
                }
                m_outFile.Write("{0},", num3);
            }
            m_outFile.WriteLine("0};");
        }
    }
}
