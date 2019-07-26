using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class win32videocontroller
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("d:/f.txt");
            Win32VideoController a = new Win32VideoController();
            //a.dictionProtocolSupported = new Dictionary<ushort, string>();
            //a.dictionProtocolSupported.Add(0, "");
            //a.dictionProtocolSupported.Add(1, "Other");
            //a.dictionProtocolSupported.Add(2, "Unknown");
            //a.dictionProtocolSupported.Add(3, "EISA");
            //a.dictionProtocolSupported.Add(4, "ISA");
            //a.dictionProtocolSupported.Add(5, "PCI");
            //a.dictionProtocolSupported.Add(6, "ATA/ATAPI");
            //a.dictionProtocolSupported.Add(7, "Flexible Diskette");
            //a.dictionProtocolSupported.Add(8, "1496");
            //a.dictionProtocolSupported.Add(9, "SCSI Parallel Interface");
            //a.dictionProtocolSupported.Add(10, "SCSI Fibre Channel Protocol");
            //a.dictionProtocolSupported.Add(11, "SCSI Serial Bus Protocol");
            //a.dictionProtocolSupported.Add(12, "SCSI Serial Bus Protocol-2 (1394)");
            //a.dictionProtocolSupported.Add(13, "SCSI Serial Storage Architecture");
            //a.dictionProtocolSupported.Add(14, "VESA");
            //a.dictionProtocolSupported.Add(15, "PCMCIA");
            //a.dictionProtocolSupported.Add(16, "Universal Serial Bus");
            //a.dictionProtocolSupported.Add(17, "Parallel Protocol");
            //a.dictionProtocolSupported.Add(18, "ESCON");
            //a.dictionProtocolSupported.Add(19, "Diagnostic");
            //a.dictionProtocolSupported.Add(20, "I2C");
            //a.dictionProtocolSupported.Add(21, "Power");
            //a.dictionProtocolSupported.Add(22, "HIPPI");
            //a.dictionProtocolSupported.Add(23, "MultiBus");
            //a.dictionProtocolSupported.Add(24, "VME");
            //a.dictionProtocolSupported.Add(25, "IPI");
            //a.dictionProtocolSupported.Add(26, "IEEE-488");
            //a.dictionProtocolSupported.Add(27, "RS232");
            //a.dictionProtocolSupported.Add(28, "IEEE 802.3 10BASE5");
            //a.dictionProtocolSupported.Add(29, "IEEE 802.3 10BASE2");
            //a.dictionProtocolSupported.Add(30, "IEEE 802.3 1BASE5");
            //a.dictionProtocolSupported.Add(31, "IEEE 802.3 10BROAD36");
            //a.dictionProtocolSupported.Add(32, "IEEE 802.3 100BASEVG");
            //a.dictionProtocolSupported.Add(33, "IEEE 802.5 Token-Ring");
            //a.dictionProtocolSupported.Add(34, "ANSI X3T9.5 FDDI");
            //a.dictionProtocolSupported.Add(35, "MCA");
            //a.dictionProtocolSupported.Add(36, "ESDI");
            //a.dictionProtocolSupported.Add(37, "IDE");
            //a.dictionProtocolSupported.Add(38, "CMD");
            //a.dictionProtocolSupported.Add(39, "ST506");
            //a.dictionProtocolSupported.Add(40, "DSSI");
            //a.dictionProtocolSupported.Add(41, "QIC2");
            //a.dictionProtocolSupported.Add(42, "Enhanced ATA/IDE");
            //a.dictionProtocolSupported.Add(43, "AGP");
            //a.dictionProtocolSupported.Add(44, "TWIRP (two-way infrared)");
            //a.dictionProtocolSupported.Add(45, "FIR (fast infrared)");
            //a.dictionProtocolSupported.Add(46, "SIR (serial infrared)");
            //a.dictionProtocolSupported.Add(47, "IrBus");


            Emit(sw, a);
            sw.WriteLine();
            sw.Close();
        }
        public static void Emit(StreamWriter m_outFile, Win32VideoController aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");

            //formatter1.Serialize(stream1, aaaaa.dictionProtocolSupported);

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
