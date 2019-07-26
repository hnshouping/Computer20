using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class win32processor
    {
        static void qMain(string[] args)
        {
            StreamWriter sw = new StreamWriter("d:/f.txt");
            Win32Processor a = new Win32Processor();
            //a.dictionFamily = new Dictionary<ushort, string>();
            //a.dictionFamily.Add(1, "Other");
            //a.dictionFamily.Add(2, "Unknown");
            //a.dictionFamily.Add(3, "8086");
            //a.dictionFamily.Add(4, "80286");
            //a.dictionFamily.Add(5, "80386");
            //a.dictionFamily.Add(6, "80486");
            //a.dictionFamily.Add(7, "8087");
            //a.dictionFamily.Add(8, "80287");
            //a.dictionFamily.Add(9, "80387");
            //a.dictionFamily.Add(10, "80487");
            //a.dictionFamily.Add(11, "Pentium Family");
            //a.dictionFamily.Add(12, "Pentium Pro");
            //a.dictionFamily.Add(13, "Pentium II");
            //a.dictionFamily.Add(14, "Pentium MMX");
            //a.dictionFamily.Add(15, "Celeron");
            //a.dictionFamily.Add(16, "Pentium II Xeon");
            //a.dictionFamily.Add(17, "Pentium III");
            //a.dictionFamily.Add(18, "M1 Family");
            //a.dictionFamily.Add(19, "M2 Family");
            //a.dictionFamily.Add(25, "K5 Family");
            //a.dictionFamily.Add(26, "K6 Family");
            //a.dictionFamily.Add(27, "K6-2");
            //a.dictionFamily.Add(28, "K6-III");
            //a.dictionFamily.Add(29, "Athlon");
            //a.dictionFamily.Add(32, "Power PC Family");
            //a.dictionFamily.Add(33, "Power PC 601");
            //a.dictionFamily.Add(34, "Power PC 603");
            //a.dictionFamily.Add(35, "Power PC 603+");
            //a.dictionFamily.Add(36, "Power PC 604");
            //a.dictionFamily.Add(48, "Alpha Family");
            //a.dictionFamily.Add(64, "MIPS Family");
            //a.dictionFamily.Add(80, "SPARC Family");
            //a.dictionFamily.Add(96, "68040");
            //a.dictionFamily.Add(97, "68xxx Family");
            //a.dictionFamily.Add(98, "68000");
            //a.dictionFamily.Add(99, "68010");
            //a.dictionFamily.Add(100, "68020");
            //a.dictionFamily.Add(101, "68030");
            //a.dictionFamily.Add(112, "Hobbit Family");
            //a.dictionFamily.Add(128, "Weitek");
            //a.dictionFamily.Add(144, "PA-RISC Family");
            //a.dictionFamily.Add(160, "V30 Family");
            //a.dictionFamily.Add(176, "Pentium III Xeon");
            //a.dictionFamily.Add(180, "AS400 Family");
            //a.dictionFamily.Add(200, "IBM390 Family");
            //a.dictionFamily.Add(250, "i860");
            //a.dictionFamily.Add(251, "i960");
            //a.dictionFamily.Add(260, "SH-3");
            //a.dictionFamily.Add(261, "SH-4");
            //a.dictionFamily.Add(280, "ARM");
            //a.dictionFamily.Add(281, "StrongARM");
            //a.dictionFamily.Add(300, "6x86");
            //a.dictionFamily.Add(301, "MediaGX");
            //a.dictionFamily.Add(302, "MII");
            //a.dictionFamily.Add(320, "WinChip");

            //a.dictionUpgradeMethod = new Dictionary<ushort, string>();
            //a.dictionUpgradeMethod.Add(1, "Other");
            //a.dictionUpgradeMethod.Add(2, "Unknown");
            //a.dictionUpgradeMethod.Add(3, "Daughter board");
            //a.dictionUpgradeMethod.Add(4, "ZIF socket");
            //a.dictionUpgradeMethod.Add(5, "Replacement/piggy back");
            //a.dictionUpgradeMethod.Add(6, "None");
            //a.dictionUpgradeMethod.Add(7, "LIF socket");
            //a.dictionUpgradeMethod.Add(8, "Slot 1");
            //a.dictionUpgradeMethod.Add(9, "Slot 2");
            //a.dictionUpgradeMethod.Add(10, "370 Pin socket");
            //a.dictionUpgradeMethod.Add(11, "Slot A");
            //a.dictionUpgradeMethod.Add(12, "Slot M");
            Emit(sw, a);
            sw.WriteLine();
            sw.Close();
        }
        public static void Emit(StreamWriter m_outFile, Win32Processor aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");

            //formatter1.Serialize(stream1, aaaaa.dictionFamily);
            //formatter1.Serialize(stream1, aaaaa.dictionUpgradeMethod);

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
