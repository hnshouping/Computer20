using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class operationsytem
    {
        static void hMain(string[] args)
        {
            //StreamWriter sw = new StreamWriter("d:/f.txt");
            //Win32OperatingSystem a = new Win32OperatingSystem();
            //a.dictionOSLanguage = new Dictionary<uint, string>();
            //a.dictionOSLanguage.Add(0x001, "Arabic");
            //a.dictionOSLanguage.Add(0x004, "Chinese");
            //a.dictionOSLanguage.Add(0x009, "English");
            //a.dictionOSLanguage.Add(0x401, "Arabic �C Saudi Arabia");
            //a.dictionOSLanguage.Add(0x402, "Bulgarian");
            //a.dictionOSLanguage.Add(0x403, "Catalan");
            //a.dictionOSLanguage.Add(0x404, "Chinese �C Taiwan");
            //a.dictionOSLanguage.Add(0x405, "Czech");
            //a.dictionOSLanguage.Add(0x406, "Danish");
            //a.dictionOSLanguage.Add(0x407, "German �C Germany");
            //a.dictionOSLanguage.Add(0x408, "Greek");
            //a.dictionOSLanguage.Add(0x409, "English �C United States");
            //a.dictionOSLanguage.Add(0x40A, "Spanish �C Traditional Sort");
            //a.dictionOSLanguage.Add(0x40B, "Finnish");
            //a.dictionOSLanguage.Add(0x40C, "French �C France");
            //a.dictionOSLanguage.Add(0x40D, "Hebrew");
            //a.dictionOSLanguage.Add(0x40E, "Hungarian");
            //a.dictionOSLanguage.Add(0x40F, "Icelandic");
            //a.dictionOSLanguage.Add(0x410, "Italian �C Italy");
            //a.dictionOSLanguage.Add(0x411, "Japanese");
            //a.dictionOSLanguage.Add(0x412, "Korean");
            //a.dictionOSLanguage.Add(0x413, "Dutch �C Netherlands");
            //a.dictionOSLanguage.Add(0x414, "Norwegian �C Bokmal");
            //a.dictionOSLanguage.Add(0x415, "Polish");
            //a.dictionOSLanguage.Add(0x416, "Portuguese �C Brazil");
            //a.dictionOSLanguage.Add(0x417, "Rhaeto-Romanic");
            //a.dictionOSLanguage.Add(0x418, "Romanian");
            //a.dictionOSLanguage.Add(0x419, "Russian");
            //a.dictionOSLanguage.Add(0x41A, "Croatian");
            //a.dictionOSLanguage.Add(0x41B, "Slovak");
            //a.dictionOSLanguage.Add(0x41C, "Albanian");
            //a.dictionOSLanguage.Add(0x41D, "Swedish");
            //a.dictionOSLanguage.Add(0x41E, "Thai");
            //a.dictionOSLanguage.Add(0x41F, "Turkish");
            //a.dictionOSLanguage.Add(0x420, "Urdu");
            //a.dictionOSLanguage.Add(0x421, "Indonesian");
            //a.dictionOSLanguage.Add(0x422, "Ukrainian");
            //a.dictionOSLanguage.Add(0x423, "Belarusian");
            //a.dictionOSLanguage.Add(0x424, "Slovenian");
            //a.dictionOSLanguage.Add(0x425, "Estonian");
            //a.dictionOSLanguage.Add(0x426, "Latvian");
            //a.dictionOSLanguage.Add(0x427, "Lithuanian");
            //a.dictionOSLanguage.Add(0x429, "Persion");
            //a.dictionOSLanguage.Add(0x42A, "Vietnamese");
            //a.dictionOSLanguage.Add(0x42D, "Basque");
            //a.dictionOSLanguage.Add(0x42E, "Serbian");
            //a.dictionOSLanguage.Add(0x42F, "Macedonian (FYROM)");
            //a.dictionOSLanguage.Add(0x430, "Sutu");
            //a.dictionOSLanguage.Add(0x431, "Tsonga");
            //a.dictionOSLanguage.Add(0x432, "Tswana");
            //a.dictionOSLanguage.Add(0x434, "Xhosa");
            //a.dictionOSLanguage.Add(0x435, "Zulu");
            //a.dictionOSLanguage.Add(0x436, "Afrikaans");
            //a.dictionOSLanguage.Add(0x438, "Faeroese");
            //a.dictionOSLanguage.Add(0x439, "Hindi");
            //a.dictionOSLanguage.Add(0x43A, "Maltese");
            //a.dictionOSLanguage.Add(0x43C, "Gaelic");
            //a.dictionOSLanguage.Add(0x43D, "Yiddish");
            //a.dictionOSLanguage.Add(0x43E, "Malay �C Malaysia");
            //a.dictionOSLanguage.Add(0x801, "Arabic �C Iraq");
            //a.dictionOSLanguage.Add(0x804, "Chinese �C PRC");
            //a.dictionOSLanguage.Add(0x807, "German �C Switzerland");
            //a.dictionOSLanguage.Add(0x809, "English �C United Kingdom");
            //a.dictionOSLanguage.Add(0x80A, "Spanish �C Mexico");
            //a.dictionOSLanguage.Add(0x80C, "French �C Belgium");
            //a.dictionOSLanguage.Add(0x810, "Italian �C Switzerland");
            //a.dictionOSLanguage.Add(0x813, "Dutch �C Belgium");
            //a.dictionOSLanguage.Add(0x814, "Norwegian �C Nynorsk");
            //a.dictionOSLanguage.Add(0x816, "Portuguese �C Portugal");
            //a.dictionOSLanguage.Add(0x818, "Romanian �C Moldova");
            //a.dictionOSLanguage.Add(0x819, "Russian �C Moldova");
            //a.dictionOSLanguage.Add(0x81A, "Serbian �C Latin");
            //a.dictionOSLanguage.Add(0x81D, "Swedish �C Finland");
            //a.dictionOSLanguage.Add(0xC01, "Arabic �C Egypt");
            //a.dictionOSLanguage.Add(0xC04, "Chinese �C Hong Kong SAR");
            //a.dictionOSLanguage.Add(0xC07, "German �C Austria");
            //a.dictionOSLanguage.Add(0xC09, "English �C Austra");
            //a.dictionOSLanguage.Add(0xC0A, "Spanish �C International Sort");
            //a.dictionOSLanguage.Add(0xC0C, "French �C Canada");
            //a.dictionOSLanguage.Add(0xC1A, "sdfSerbian �C Cyrillicdfdsf");
            //a.dictionOSLanguage.Add(0x1001, "Arabic �C Libya");
            //a.dictionOSLanguage.Add(0x1004, "Chinese �C Singapore");
            //a.dictionOSLanguage.Add(0x1007, "German �C Luxembourg");
            //a.dictionOSLanguage.Add(0x1009, "English �C Canada");
            //a.dictionOSLanguage.Add(0x100A, "Spanish �C Guatemala");
            //a.dictionOSLanguage.Add(0x100C, "French �C Switzerland");
            //a.dictionOSLanguage.Add(0x1401, "Arabic �C Algeria");
            //a.dictionOSLanguage.Add(0x1407, "German �C Liechtenstein");
            //a.dictionOSLanguage.Add(0x1409, "English �C New Zealand");
            //a.dictionOSLanguage.Add(0x140A, "Spanish �C Costa Rica");
            //a.dictionOSLanguage.Add(0x140C, "French �C Luxembourg");
            //a.dictionOSLanguage.Add(0x1801, "Arabic �C Morocco");
            //a.dictionOSLanguage.Add(0x1809, "English �C Ireland");
            //a.dictionOSLanguage.Add(0x180A, "Spanish �C Panama");
            //a.dictionOSLanguage.Add(0x1C01, "Arabic �C Tunisia");
            //a.dictionOSLanguage.Add(0x1C09, "English �C South Africa");
            //a.dictionOSLanguage.Add(0x1C0A, "Spanish �C Dominican Republic");
            //a.dictionOSLanguage.Add(0x2001, "Arabic �C Oman");
            //a.dictionOSLanguage.Add(0x2009, "English �C Jamaica");
            //a.dictionOSLanguage.Add(0x200A, "Spanish �C Venezuela");
            //a.dictionOSLanguage.Add(0x2401, "Arabic �C Yemen");
            //a.dictionOSLanguage.Add(0x240A, "Spanish �C Colombia");
            //a.dictionOSLanguage.Add(0x2801, "Arabic �C Syria");
            //a.dictionOSLanguage.Add(0x2809, "English �C Belize");
            //a.dictionOSLanguage.Add(0x280A, "Spanish �C Peru");
            //a.dictionOSLanguage.Add(0x2C01, "Arabic �C Jordan");
            //a.dictionOSLanguage.Add(0x2C09, "English �C Trinidad");
            //a.dictionOSLanguage.Add(0x2C0A, "Spanish �C Argentina");
            //a.dictionOSLanguage.Add(0x3001, "Arabic �C Lebanon");
            //a.dictionOSLanguage.Add(0x300A, "Spanish �C Ecuador");
            //a.dictionOSLanguage.Add(0x3401, "Arabic �C Kuwait");
            //a.dictionOSLanguage.Add(0x340A, "Spanish �C Chile");
            //a.dictionOSLanguage.Add(0x3801, "Arabic �C U.A.E.");
            //a.dictionOSLanguage.Add(0x380A, "Spanish �C Uruguay");
            //a.dictionOSLanguage.Add(0x3C01, "Arabic �C Bahrain");
            //a.dictionOSLanguage.Add(0x3C0A, "Spanish �C Paraguay");
            //a.dictionOSLanguage.Add(0x4001, "Arabic �C Qatar");
            //a.dictionOSLanguage.Add(0x400A, "Spanish �C Bolivia");
            //a.dictionOSLanguage.Add(0x440A, "Spanish �C El Salvador");
            //a.dictionOSLanguage.Add(0x480A, "Spanish �C Honduras");
            //a.dictionOSLanguage.Add(0x4C0A, "Spanish �C Nicaragua");
            //a.dictionOSLanguage.Add(0x500A, "Spanish �C Puerto Rico");

            //a.dictionOSProductSuite = new Dictionary<uint, string>();
            //a.dictionOSProductSuite.Add(1, "Small Business");
            //a.dictionOSProductSuite.Add(2, "Enterprise");
            //a.dictionOSProductSuite.Add(4, "BackOffice");
            //a.dictionOSProductSuite.Add(8, "Communication Server");
            //a.dictionOSProductSuite.Add(16, "Terminal Server");
            //a.dictionOSProductSuite.Add(32, "Small Business (Restricted)");
            //a.dictionOSProductSuite.Add(64, "Embedded NT");
            //a.dictionOSProductSuite.Add(128, "Data Center");


            //a.dictionSuiteMask = new Dictionary<uint, string>();
            //a.dictionSuiteMask.Add(1, "Small Business");
            //a.dictionSuiteMask.Add(2, "Enterprise");
            //a.dictionSuiteMask.Add(4, "Back Office");
            //a.dictionSuiteMask.Add(8, "Communications");
            //a.dictionSuiteMask.Add(16, "Terminal");
            //a.dictionSuiteMask.Add(32, "Small Business Restricted");
            //a.dictionSuiteMask.Add(64, "Embedded NT");
            //a.dictionSuiteMask.Add(128, "Data Center");
            //a.dictionSuiteMask.Add(256, "Single User");
            //a.dictionSuiteMask.Add(512, "Personal");
            //a.dictionSuiteMask.Add(1024, "Blade");
            //StreamWriter sw = new StreamWriter("d:/e.txt");
            //Win32OperatingSystem a = new Win32OperatingSystem();
            //Dictionary<ushort, string> aaaa = new Dictionary<ushort, string>();
            //a.dictionOSType = new Dictionary<ushort, string>();
            //aaaa = a.dictionOSType;
            //aaaa.Add(0, "Unknown");
            //aaaa.Add(1, "Other");
            //aaaa.Add(2, "Mac OS");
            //aaaa.Add(3, "ATT UNIX");
            //aaaa.Add(4, "DGUX");
            //aaaa.Add(5, "DECNT");
            //aaaa.Add(6, "Digital UNIX");
            //aaaa.Add(7, "Open VMS");
            //aaaa.Add(8, "HP-UX");
            //aaaa.Add(9, "AIX");
            //aaaa.Add(10, "MVS");
            //aaaa.Add(11, "OS400");
            //aaaa.Add(12, "OS/2");
            //aaaa.Add(13, "Java VM");
            //aaaa.Add(14, "MSDOS");
            //aaaa.Add(15, "Windows 3.x");
            //aaaa.Add(16, "Windows 95");
            //aaaa.Add(17, "Windows 98");
            //aaaa.Add(18, "Windows NT");
            //aaaa.Add(19, "Windows CE");
            //aaaa.Add(20, "NCR 3000");
            //aaaa.Add(21, "NetWare");
            //aaaa.Add(22, "OSF");
            //aaaa.Add(23, "DC/OS");
            //aaaa.Add(24, "Reliant UNIX");
            //aaaa.Add(25, "SCO UnixWare");
            //aaaa.Add(26, "SCO OpenServer");
            //aaaa.Add(27, "Sequent");
            //aaaa.Add(28, "IRIX");
            //aaaa.Add(29, "Solaris");
            //aaaa.Add(30, "SunOS");
            //aaaa.Add(31, "U6000");
            //aaaa.Add(32, "A Series");
            //aaaa.Add(33, "Tandem NSK");
            //aaaa.Add(34, "Tandem NT");
            //aaaa.Add(35, "BS2000/OSD");
            //aaaa.Add(36, "Linux");
            //aaaa.Add(37, "Lynx");
            //aaaa.Add(38, "Xenix");
            //aaaa.Add(39, "VM/ESA");
            //aaaa.Add(40, "Interactive UNIX");
            //aaaa.Add(41, "BSD UNIX");
            //aaaa.Add(42, "FreeBSD");
            //aaaa.Add(43, "NetBSD");
            //aaaa.Add(44, "GNU Hurd");
            //aaaa.Add(45, "Mac OS 9");
            //aaaa.Add(46, "Mach Kernel");
            //aaaa.Add(47, "Inferno");
            //aaaa.Add(48, "QNX");
            //aaaa.Add(49, "EPOC");
            //aaaa.Add(50, "IxWorks");
            //aaaa.Add(51, "VxWorks");
            //aaaa.Add(52, "MiNT");
            //aaaa.Add(53, "BeOS");
            //aaaa.Add(54, "HP MPE");
            //aaaa.Add(55, "NEXTSTEP");
            //aaaa.Add(56, "Palm OS");
            //aaaa.Add(57, "Rhapsody");
            //aaaa.Add(58, "Windows 2000");
            //aaaa.Add(59, "Dedicated");
            //aaaa.Add(60, "OS/390");
            //aaaa.Add(61, "VSE");
            //aaaa.Add(62, "TPF");

            //Emit(sw, a);
            //sw.WriteLine();
            //sw.Close();
        }
        public static void Emit(StreamWriter m_outFile, Win32OperatingSystem aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");

            //formatter1.Serialize(stream1, aaaaa.dictionOSType);
            //formatter1.Serialize(stream1, aaaaa.dictionOSLanguage);
            //formatter1.Serialize(stream1, aaaaa.dictionOSProductSuite);
            //formatter1.Serialize(stream1, aaaaa.dictionSuiteMask);

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