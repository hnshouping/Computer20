using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class win32physicalmemory
    {
        static void iMain(string[] args)
        {
            StreamWriter sw = new StreamWriter("d:/f.txt");
            Win32PhysicalMemory a = new Win32PhysicalMemory();
            //a.dictionMemoryType = new Dictionary<ushort, string>();
            //a.dictionMemoryType.Add(0, "Unknown");
            //a.dictionMemoryType.Add(1, "Other");
            //a.dictionMemoryType.Add(2, "DRAM");
            //a.dictionMemoryType.Add(3, "Synchronous DRAM");
            //a.dictionMemoryType.Add(4, "Cache DRAM");
            //a.dictionMemoryType.Add(5, "EDO");
            //a.dictionMemoryType.Add(6, "EDRAM");
            //a.dictionMemoryType.Add(7, "VRAM");
            //a.dictionMemoryType.Add(8, "SRAM");
            //a.dictionMemoryType.Add(9, "RAM");
            //a.dictionMemoryType.Add(10, "ROM");
            //a.dictionMemoryType.Add(11, "Flash");
            //a.dictionMemoryType.Add(12, "EEPROM");
            //a.dictionMemoryType.Add(13, "FEPROM");
            //a.dictionMemoryType.Add(14, "EPROM");
            //a.dictionMemoryType.Add(15, "CDRAM");
            //a.dictionMemoryType.Add(16, "3DRAM");
            //a.dictionMemoryType.Add(17, "SDRAM");
            //a.dictionMemoryType.Add(18, "SGRAM");
            //a.dictionMemoryType.Add(19, "RDRAM");
            //a.dictionMemoryType.Add(20, "DDR");
            //a.dictionFormFactor = new Dictionary<ushort, string>();
            //a.dictionFormFactor.Add(0, "Unknown");
            //a.dictionFormFactor.Add(1, "Other");
            //a.dictionFormFactor.Add(2, "SIP");
            //a.dictionFormFactor.Add(3, "DIP");
            //a.dictionFormFactor.Add(4, "ZIP");
            //a.dictionFormFactor.Add(5, "SOJ");
            //a.dictionFormFactor.Add(6, "Proprietary");
            //a.dictionFormFactor.Add(7, "SIMM");
            //a.dictionFormFactor.Add(8, "DIMM");
            //a.dictionFormFactor.Add(9, "TSOP");
            //a.dictionFormFactor.Add(10, "PGA");
            //a.dictionFormFactor.Add(11, "RIMM");
            //a.dictionFormFactor.Add(12, "SODIMM");
            //a.dictionFormFactor.Add(13, "SRIMM");
            //a.dictionFormFactor.Add(14, "SMD");
            //a.dictionFormFactor.Add(15, "SSMP");
            //a.dictionFormFactor.Add(16, "QFP");
            //a.dictionFormFactor.Add(17, "TQFP");
            //a.dictionFormFactor.Add(18, "SOIC");
            //a.dictionFormFactor.Add(19, "LCC");
            //a.dictionFormFactor.Add(20, "PLCC");
            //a.dictionFormFactor.Add(21, "BGA");
            //a.dictionFormFactor.Add(22, "FPBGA");
            //a.dictionFormFactor.Add(23, "LGA");

            Emit(sw, a);
            sw.WriteLine();
            sw.Close();

        }
        public static void Emit(StreamWriter m_outFile, Win32PhysicalMemory  aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");

            //formatter1.Serialize(stream1, aaaaa.dictionFormFactor);
            //formatter1.Serialize(stream1, aaaaa.dictionMemoryType);

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
