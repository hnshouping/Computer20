using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class Win32logicaldisk
    {
        static void cMain(string[] args)
        {
            StreamWriter sw = new StreamWriter("d:/b.txt");
            Win32LogicalDisk a = new Win32LogicalDisk();
            //a.YxDictionAccess = new Dictionary<ushort, string>();
            //a.YxDictionAccess.Add(1, "Unknown");
            //a.YxDictionAccess.Add(2, "Readable");
            //a.YxDictionAccess.Add(3, "Writeable");
            //a.YxDictionAccess.Add(4, "Read/write supported");
            //a.YxDictionAccess.Add(5, "Write once");

            //a.dictionDriveType = new Dictionary<uint, string>();
            //a.dictionDriveType.Add(0, "Unknown");
            //a.dictionDriveType.Add(1, "No Root Directory");
            //a.dictionDriveType.Add(2, "Removable Disk");
            //a.dictionDriveType.Add(3, "Local Disk");
            //a.dictionDriveType.Add(4, "Network Drive");
            //a.dictionDriveType.Add(5, "Compact Disc");
            //a.dictionDriveType.Add(6, "RAM Disk");

            //a.dictionMediaType = new Dictionary<uint, string>();
            //a.dictionMediaType.Add(0, "Unknown:Format is unknown");
            //a.dictionMediaType.Add(1, "F5_1Pt2_512:51/4-Inch Floppy Disk - 1.2Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(2, "F3_1Pt44_512:31/2-Inch Floppy Disk - 1.44Mb -512 bytes/sector");
            //a.dictionMediaType.Add(3, "F3_2Pt88_512:31/2-Inch Floppy Disk - 2.88Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(4, "F3_20Pt8_512:31/2-Inch Floppy Disk - 20.8Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(5, "F3_720_512:31/2-Inch Floppy Disk - 720Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(6, "F5_360_512:51/4-Inch Floppy Disk - 360Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(7, "F5_320_512:51/4-Inch Floppy Disk - 320Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(8, "F5_320_1024:51/4-Inch Floppy Disk - 320Kb - 1024 bytes/sector");
            //a.dictionMediaType.Add(9, "F5_180_512:51/4-Inch Floppy Disk - 180Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(10, "F5_160_512:51/4-Inch Floppy Disk - 160Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(11, "Removable media other than floppy");
            //a.dictionMediaType.Add(12, "Fixed hard disk media");
            //a.dictionMediaType.Add(13, "F3_120M_512:31/2-Inch Floppy Disk - 120Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(14, "F3_640_512:31/2-Inch Floppy Disk - 640Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(15, "F5_640_512:51/4-Inch Floppy Disk - 640Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(16, "F5_720_512:51/4-Inch Floppy Disk - 720Kb - 512 bytes/sector");
            //a.dictionMediaType.Add(17, "F3_1Pt2_512:31/2-Inch Floppy Disk - 1.2Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(18, "F3_1Pt23_1024:31/2-Inch Floppy Disk - 1.23Mb - 1024 bytes/sector");
            //a.dictionMediaType.Add(19, "F5_1Pt23_1024:51/4-Inch Floppy Disk - 1.23Mb - 1024 bytes/sector");
            //a.dictionMediaType.Add(20, "F3_128Mb_512:31/2-Inch Floppy Disk - 128Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(21, "F3_230Mb_512:31/2-Inch Floppy Disk - 230Mb - 512 bytes/sector");
            //a.dictionMediaType.Add(22, "F8_256_128:8-Inch Floppy Disk - 256Kb - 128 bytes/sector");



            Emit(sw, a);
            sw.WriteLine();
            sw.Close();

        }
        public static void Emit(StreamWriter m_outFile, Win32LogicalDisk aaaaa)
        {
            MemoryStream stream1 = new MemoryStream();
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            Console.WriteLine("Serialising the parser");

            //formatter1.Serialize(stream1, aaaaa.YxDictionAccess);
            //formatter1.Serialize(stream1, aaaaa.dictionDriveType);
            //formatter1.Serialize(stream1, aaaaa.dictionMediaType);

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
