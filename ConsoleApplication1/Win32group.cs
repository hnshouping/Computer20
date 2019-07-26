using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class Win32group
    {
        static void bMain(string[] args)
        {
            StreamWriter sw = new StreamWriter("d:/b.txt");
            Win32Group wg = new Win32Group();
            //wg.YxDictionSIDType = new Dictionary<byte, string>();
            //wg.YxDictionSIDType.Add(1, "SidTypeUser");
            //wg.YxDictionSIDType.Add(2, "SidTypeGroup");
            //wg.YxDictionSIDType.Add(3, "SidTypeDomain");
            //wg.YxDictionSIDType.Add(4, "SidTypeAlias");
            //wg.YxDictionSIDType.Add(5, "SidTypeWellKnownGroup");
            //wg.YxDictionSIDType.Add(6, "SidTypeDeletedAccount");
            //wg.YxDictionSIDType.Add(7, "SidTypeInvalid");
            //wg.YxDictionSIDType.Add(8, "SidTypeUnknown");
            //wg.YxDictionSIDType.Add(9, "SidTypeComputer");

            Emit(sw, wg);
            sw.WriteLine();
            sw.Close();
        }
        public static void Emit(StreamWriter m_outFile, Win32Group aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");
            
            formatter1.Serialize(stream1, aaaaa.YxDictionSIDType);

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
