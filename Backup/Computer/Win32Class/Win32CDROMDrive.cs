using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace Computer.Win32Class
{
    public class Win32CDROMDrive : CIMCDROMDrive
    {
        private string drive;
        private bool driveIntegrity;
        private UInt16 fileSystemFlags;
        private UInt32 fileSystemFlagsEx;
        private string id;
        private string manufacturer;
        private UInt32 maximumComponentLength;
        private bool mediaLoaded;
        private string mediaType;
        private string mfrAssignedRevisionLevel;
        private string revisionLevel;
        private UInt32 sCSIBus;
        private UInt16 sCSILogicalUnit;
        private UInt16 sCSIPort;
        private UInt16 sCSITargetId;
        private UInt64 size;
        private Double transferRate;
        private string volumeName;
        private string volumeSerialNumber;


        private byte[] arr={
            0,1,0,0,0,255,255,255,255,1,
            0,0,0,0,0,0,0,4,1,0,0,
            0,226,1,83,121,115,116,101,109,46,67,
            111,108,108,101,99,116,105,111,110,115,46,
            71,101,110,101,114,105,99,46,68,105,99,
            116,105,111,110,97,114,121,96,50,91,91,
            83,121,115,116,101,109,46,85,73,110,116,
            51,50,44,32,109,115,99,111,114,108,105,
            98,44,32,86,101,114,115,105,111,110,61,
            50,46,48,46,48,46,48,44,32,67,117,
            108,116,117,114,101,61,110,101,117,116,114,
            97,108,44,32,80,117,98,108,105,99,75,
            101,121,84,111,107,101,110,61,98,55,55,
            97,53,99,53,54,49,57,51,52,101,48,
            56,57,93,44,91,83,121,115,116,101,109,
            46,83,116,114,105,110,103,44,32,109,115,
            99,111,114,108,105,98,44,32,86,101,114,
            115,105,111,110,61,50,46,48,46,48,46,
            48,44,32,67,117,108,116,117,114,101,61,
            110,101,117,116,114,97,108,44,32,80,117,
            98,108,105,99,75,101,121,84,111,107,101,
            110,61,98,55,55,97,53,99,53,54,49,
            57,51,52,101,48,56,57,93,93,4,0,
            0,0,7,86,101,114,115,105,111,110,8,
            67,111,109,112,97,114,101,114,8,72,97,
            115,104,83,105,122,101,13,75,101,121,86,
            97,108,117,101,80,97,105,114,115,0,3,
            0,3,8,146,1,83,121,115,116,101,109,
            46,67,111,108,108,101,99,116,105,111,110,
            115,46,71,101,110,101,114,105,99,46,71,
            101,110,101,114,105,99,69,113,117,97,108,
            105,116,121,67,111,109,112,97,114,101,114,
            96,49,91,91,83,121,115,116,101,109,46,
            85,73,110,116,51,50,44,32,109,115,99,
            111,114,108,105,98,44,32,86,101,114,115,
            105,111,110,61,50,46,48,46,48,46,48,
            44,32,67,117,108,116,117,114,101,61,110,
            101,117,116,114,97,108,44,32,80,117,98,
            108,105,99,75,101,121,84,111,107,101,110,
            61,98,55,55,97,53,99,53,54,49,57,
            51,52,101,48,56,57,93,93,8,230,1,
            83,121,115,116,101,109,46,67,111,108,108,
            101,99,116,105,111,110,115,46,71,101,110,
            101,114,105,99,46,75,101,121,86,97,108,
            117,101,80,97,105,114,96,50,91,91,83,
            121,115,116,101,109,46,85,73,110,116,51,
            50,44,32,109,115,99,111,114,108,105,98,
            44,32,86,101,114,115,105,111,110,61,50,
            46,48,46,48,46,48,44,32,67,117,108,
            116,117,114,101,61,110,101,117,116,114,97,
            108,44,32,80,117,98,108,105,99,75,101,
            121,84,111,107,101,110,61,98,55,55,97,
            53,99,53,54,49,57,51,52,101,48,56,
            57,93,44,91,83,121,115,116,101,109,46,
            83,116,114,105,110,103,44,32,109,115,99,
            111,114,108,105,98,44,32,86,101,114,115,
            105,111,110,61,50,46,48,46,48,46,48,
            44,32,67,117,108,116,117,114,101,61,110,
            101,117,116,114,97,108,44,32,80,117,98,
            108,105,99,75,101,121,84,111,107,101,110,
            61,98,55,55,97,53,99,53,54,49,57,
            51,52,101,48,56,57,93,93,91,93,14,
            0,0,0,9,2,0,0,0,17,0,0,
            0,9,3,0,0,0,4,2,0,0,0,
            146,1,83,121,115,116,101,109,46,67,111,
            108,108,101,99,116,105,111,110,115,46,71,
            101,110,101,114,105,99,46,71,101,110,101,
            114,105,99,69,113,117,97,108,105,116,121,
            67,111,109,112,97,114,101,114,96,49,91,
            91,83,121,115,116,101,109,46,85,73,110,
            116,51,50,44,32,109,115,99,111,114,108,
            105,98,44,32,86,101,114,115,105,111,110,
            61,50,46,48,46,48,46,48,44,32,67,
            117,108,116,117,114,101,61,110,101,117,116,
            114,97,108,44,32,80,117,98,108,105,99,
            75,101,121,84,111,107,101,110,61,98,55,
            55,97,53,99,53,54,49,57,51,52,101,
            48,56,57,93,93,0,0,0,0,7,3,
            0,0,0,0,1,0,0,0,14,0,0,
            0,3,228,1,83,121,115,116,101,109,46,
            67,111,108,108,101,99,116,105,111,110,115,
            46,71,101,110,101,114,105,99,46,75,101,
            121,86,97,108,117,101,80,97,105,114,96,
            50,91,91,83,121,115,116,101,109,46,85,
            73,110,116,51,50,44,32,109,115,99,111,
            114,108,105,98,44,32,86,101,114,115,105,
            111,110,61,50,46,48,46,48,46,48,44,
            32,67,117,108,116,117,114,101,61,110,101,
            117,116,114,97,108,44,32,80,117,98,108,
            105,99,75,101,121,84,111,107,101,110,61,
            98,55,55,97,53,99,53,54,49,57,51,
            52,101,48,56,57,93,44,91,83,121,115,
            116,101,109,46,83,116,114,105,110,103,44,
            32,109,115,99,111,114,108,105,98,44,32,
            86,101,114,115,105,111,110,61,50,46,48,
            46,48,46,48,44,32,67,117,108,116,117,
            114,101,61,110,101,117,116,114,97,108,44,
            32,80,117,98,108,105,99,75,101,121,84,
            111,107,101,110,61,98,55,55,97,53,99,
            53,54,49,57,51,52,101,48,56,57,93,
            93,4,252,255,255,255,228,1,83,121,115,
            116,101,109,46,67,111,108,108,101,99,116,
            105,111,110,115,46,71,101,110,101,114,105,
            99,46,75,101,121,86,97,108,117,101,80,
            97,105,114,96,50,91,91,83,121,115,116,
            101,109,46,85,73,110,116,51,50,44,32,
            109,115,99,111,114,108,105,98,44,32,86,
            101,114,115,105,111,110,61,50,46,48,46,
            48,46,48,44,32,67,117,108,116,117,114,
            101,61,110,101,117,116,114,97,108,44,32,
            80,117,98,108,105,99,75,101,121,84,111,
            107,101,110,61,98,55,55,97,53,99,53,
            54,49,57,51,52,101,48,56,57,93,44,
            91,83,121,115,116,101,109,46,83,116,114,
            105,110,103,44,32,109,115,99,111,114,108,
            105,98,44,32,86,101,114,115,105,111,110,
            61,50,46,48,46,48,46,48,44,32,67,
            117,108,116,117,114,101,61,110,101,117,116,
            114,97,108,44,32,80,117,98,108,105,99,
            75,101,121,84,111,107,101,110,61,98,55,
            55,97,53,99,53,54,49,57,51,52,101,
            48,56,57,93,93,2,0,0,0,3,107,
            101,121,5,118,97,108,117,101,0,1,15,
            1,0,0,0,6,5,0,0,0,21,67,
            65,83,69,95,83,69,78,83,73,84,73,
            86,69,95,83,69,65,82,67,72,1,250,
            255,255,255,252,255,255,255,2,0,0,0,
            6,7,0,0,0,20,67,65,83,69,95,
            80,82,69,83,69,82,86,69,68,95,78,
            65,77,69,83,1,248,255,255,255,252,255,
            255,255,4,0,0,0,6,9,0,0,0,
            15,85,78,73,67,79,68,69,95,79,78,
            95,68,73,83,75,1,246,255,255,255,252,
            255,255,255,8,0,0,0,6,11,0,0,
            0,15,80,69,82,83,73,83,84,69,78,
            84,95,65,67,76,83,1,244,255,255,255,
            252,255,255,255,16,0,0,0,6,13,0,
            0,0,16,70,73,76,69,95,67,79,77,
            80,82,69,83,83,73,79,78,1,242,255,
            255,255,252,255,255,255,32,0,0,0,6,
            15,0,0,0,13,86,79,76,85,77,69,
            95,81,85,79,84,65,83,1,240,255,255,
            255,252,255,255,255,64,0,0,0,6,17,
            0,0,0,21,83,85,80,80,79,82,84,
            83,95,83,80,65,82,83,69,95,70,73,
            76,69,83,1,238,255,255,255,252,255,255,
            255,128,0,0,0,6,19,0,0,0,23,
            83,85,80,80,79,82,84,83,95,82,69,
            80,65,82,83,69,95,80,79,73,78,84,
            83,1,236,255,255,255,252,255,255,255,0,
            1,0,0,6,21,0,0,0,23,83,85,
            80,80,79,82,84,83,95,82,69,77,79,
            84,69,95,83,84,79,82,65,71,69,1,
            234,255,255,255,252,255,255,255,0,64,0,
            0,6,23,0,0,0,19,83,85,80,80,
            79,82,84,83,95,76,79,78,71,95,78,
            65,77,69,83,1,232,255,255,255,252,255,
            255,255,0,128,0,0,6,25,0,0,0,
            20,86,79,76,85,77,69,95,73,83,95,
            67,79,77,80,82,69,83,83,69,68,1,
            230,255,255,255,252,255,255,255,0,0,1,
            0,6,27,0,0,0,19,83,85,80,80,
            79,82,84,83,95,79,66,74,69,67,84,
            95,73,68,83,1,228,255,255,255,252,255,
            255,255,0,0,2,0,6,29,0,0,0,
            19,83,85,80,80,79,82,84,83,95,69,
            78,67,82,89,80,84,73,79,78,1,226,
            255,255,255,252,255,255,255,0,0,4,0,
            6,31,0,0,0,22,83,85,80,80,79,
            82,84,83,95,78,65,77,69,68,95,83,
            84,82,69,65,77,83,11,0
        };








        private Dictionary<UInt32, string> dictionFileSystemFlagsEx;
        /// <summary>
        /// CD-ROM drive的驱动标记 如:"d:\"
        /// </summary>
        public string Drive
        {
            get { return drive; }
            set { drive = value; }
        }
        /// <summary>
        /// 如真,文件能被正确的读从CD驱动.
        /// </summary>
        public bool DriveIntegrity
        {
            get { return DriveIntegrity; }
            set { driveIntegrity = value; }
        }
        /// <summary>
        /// 这是个旧属性,使用use FileSystemFlagsEx.
        /// </summary>
        public UInt16 FileSystemFlags
        {
            get { return fileSystemFlags; }
            set { fileSystemFlags = value; }
        }
        /// <summary>
        /// 文件系统关联标志用Windows CD-ROM drive
        /// </summary>
        public UInt32 FileSystemFlagsEx
        {
            get { return fileSystemFlagsEx; }
            set { fileSystemFlagsEx = value; }
        }
        /// <summary>
        /// CD-ROM设备的唯一标识符 如:"d:\"
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Windows CD-ROM设备的厂家 如:"PLEXTOR"
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        /// <summary>
        /// 支持文件名的最大长度
        /// </summary>
        public UInt32 MaximumComponentLength
        {
            get { return maximumComponentLength; }
            set { maximumComponentLength = value; }
        }
        /// <summary>
        /// 如果真,一个CD-ROM进入这个光驱
        /// </summary>
        public bool MediaLoaded
        {
            get { return mediaLoaded; }
            set { mediaLoaded = value; }
        }
        /// <summary>
        /// 联接驱动的媒体的类型,在这个类,值总是"CD-ROM".有如下值:"Random Access""Supports Writing""Removable Media""CD-ROM"
        /// </summary>
        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        /// <summary>
        /// Windows Server 2003 and Windows XP:  Manufacturer assigned firmware revision level of the CD-ROM drive. 
        /// </summary>
        public string MfrAssignedRevisionLevel
        {
            get { return mfrAssignedRevisionLevel; }
            set { mfrAssignedRevisionLevel = value; }
        }
        /// <summary>
        /// CD-ROM的固件修定版本
        /// </summary>
        public string RevisionLevel
        {
            get { return revisionLevel; }
            set { revisionLevel = value; }
        }
        /// <summary>
        /// 小型机系统硬盘驱动的总线序号
        /// </summary>
        public UInt32 SCSIBus
        {
            get { return sCSIBus; }
            set { sCSIBus = value; }
        }
        /// <summary>
        /// 小型机系统的硬盘驱动的逻辑单元号
        /// </summary>
        public UInt16 SCSILogicalUnit
        {
            get { return sCSILogicalUnit; }
            set { sCSILogicalUnit = value; }
        }
        /// <summary>
        /// 小型机系统的硬盘驱动的端口号
        /// </summary>
        public UInt16 SCSIPort
        {
            get { return sCSIPort; }
            set { sCSIPort = value; }
        }
        /// <summary>
        /// 小型机系统的硬盘驱动的身份编号
        /// </summary>
        public UInt16 SCSITargetId
        {
            get { return sCSITargetId; }
            set { sCSITargetId = value; }
        }
        /// <summary>
        /// 硬盘驱动的大小
        /// </summary>
        public UInt64 Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// 光驱的运转速度
        /// </summary>
        public Double TransferRate
        {
            get { return transferRate; }
            set { transferRate = value; }
        }
        /// <summary>
        /// 光驱卷的名字
        /// </summary>
        public string VolumeName
        {
            get { return volumeName; }
            set { volumeName = value; }
        }
        /// <summary>
        /// 光驱的连续号
        /// </summary>
        public string VolumeSerialNumber
        {
            get { return volumeSerialNumber; }
            set { volumeSerialNumber = value; }
        }
        /// <summary>
        /// FileSystemFlagsEx的意思
        /// </summary>
        public Dictionary<UInt32, string> YxDictionFileSystemFlagsEx
        {
            get {
                GetParser();
                return dictionFileSystemFlagsEx; 
            }
        }


        public override uint Reset()
        {
            return uint.MaxValue;//现在没用，以后再写
        }
        public override uint SetPowerState(ushort PowerState, DateTime Time)
        {
            return uint.MaxValue;//现在没用，以后再写
        }
        /// <summary>
        /// 得到FileSystemFlagsEx的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetFileSystemFlagsExbyInt(uint key)
        {
            string dic;
            bool a = YxDictionFileSystemFlagsEx.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }
        private void GetParser()
        {
            MemoryStream stream1 = new MemoryStream(this.arr);
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = FormatterAssemblyStyle.Simple;
            this.dictionFileSystemFlagsEx = (Dictionary<uint, string>)formatter1.Deserialize(stream1);
        }


        public Win32CDROMDrive()
        {
            
        }
    }
}
