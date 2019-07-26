using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace Computer
{
    public class CIMOperatingSystem : CIMLogicalElement
    {
        private string creationClassName;
        private string cSCreationClassName;
        private string cSName;
        private Int16 currentTimeZone;
        private bool distributed;
        private UInt64 freePhysicalMemory;
        private UInt64 freeSpaceInPagingFiles;
        private UInt64 freeVirtualMemory;
        private DateTime lastBootUpTime;
        private string cim_LastBootUpTime;
        private DateTime localDateTime;
        private string cim_LocalDateTime;
        private UInt32 maxNumberOfProcesses;
        private UInt64 maxProcessMemorySize;
        private UInt32 numberOfLicensedUsers;
        private UInt32 numberOfProcesses;
        private UInt32 numberOfUsers;
        private UInt32 oSType;
        private string otherTypeDescription;
        private UInt64 sizeStoredInPagingFiles;
        private UInt64 totalSwapSpaceSize;
        private UInt64 totalVirtualMemorySize;
        private UInt64 totalVisibleMemorySize;
        private string version;


        private Dictionary<ushort, string> dictionOSType;

        private byte[] arr ={
            0,1,0,0,0,255,255,255,255,1,
            0,0,0,0,0,0,0,4,1,0,0,
            0,226,1,83,121,115,116,101,109,46,67,
            111,108,108,101,99,116,105,111,110,115,46,
            71,101,110,101,114,105,99,46,68,105,99,
            116,105,111,110,97,114,121,96,50,91,91,
            83,121,115,116,101,109,46,85,73,110,116,
            49,54,44,32,109,115,99,111,114,108,105,
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
            85,73,110,116,49,54,44,32,109,115,99,
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
            121,115,116,101,109,46,85,73,110,116,49,
            54,44,32,109,115,99,111,114,108,105,98,
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
            51,52,101,48,56,57,93,93,91,93,63,
            0,0,0,9,2,0,0,0,89,0,0,
            0,9,3,0,0,0,4,2,0,0,0,
            146,1,83,121,115,116,101,109,46,67,111,
            108,108,101,99,116,105,111,110,115,46,71,
            101,110,101,114,105,99,46,71,101,110,101,
            114,105,99,69,113,117,97,108,105,116,121,
            67,111,109,112,97,114,101,114,96,49,91,
            91,83,121,115,116,101,109,46,85,73,110,
            116,49,54,44,32,109,115,99,111,114,108,
            105,98,44,32,86,101,114,115,105,111,110,
            61,50,46,48,46,48,46,48,44,32,67,
            117,108,116,117,114,101,61,110,101,117,116,
            114,97,108,44,32,80,117,98,108,105,99,
            75,101,121,84,111,107,101,110,61,98,55,
            55,97,53,99,53,54,49,57,51,52,101,
            48,56,57,93,93,0,0,0,0,7,3,
            0,0,0,0,1,0,0,0,63,0,0,
            0,3,228,1,83,121,115,116,101,109,46,
            67,111,108,108,101,99,116,105,111,110,115,
            46,71,101,110,101,114,105,99,46,75,101,
            121,86,97,108,117,101,80,97,105,114,96,
            50,91,91,83,121,115,116,101,109,46,85,
            73,110,116,49,54,44,32,109,115,99,111,
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
            101,109,46,85,73,110,116,49,54,44,32,
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
            101,121,5,118,97,108,117,101,0,1,14,
            0,0,6,5,0,0,0,7,85,110,107,
            110,111,119,110,1,250,255,255,255,252,255,
            255,255,1,0,6,7,0,0,0,5,79,
            116,104,101,114,1,248,255,255,255,252,255,
            255,255,2,0,6,9,0,0,0,6,77,
            97,99,32,79,83,1,246,255,255,255,252,
            255,255,255,3,0,6,11,0,0,0,8,
            65,84,84,32,85,78,73,88,1,244,255,
            255,255,252,255,255,255,4,0,6,13,0,
            0,0,4,68,71,85,88,1,242,255,255,
            255,252,255,255,255,5,0,6,15,0,0,
            0,5,68,69,67,78,84,1,240,255,255,
            255,252,255,255,255,6,0,6,17,0,0,
            0,12,68,105,103,105,116,97,108,32,85,
            78,73,88,1,238,255,255,255,252,255,255,
            255,7,0,6,19,0,0,0,8,79,112,
            101,110,32,86,77,83,1,236,255,255,255,
            252,255,255,255,8,0,6,21,0,0,0,
            5,72,80,45,85,88,1,234,255,255,255,
            252,255,255,255,9,0,6,23,0,0,0,
            3,65,73,88,1,232,255,255,255,252,255,
            255,255,10,0,6,25,0,0,0,3,77,
            86,83,1,230,255,255,255,252,255,255,255,
            11,0,6,27,0,0,0,5,79,83,52,
            48,48,1,228,255,255,255,252,255,255,255,
            12,0,6,29,0,0,0,4,79,83,47,
            50,1,226,255,255,255,252,255,255,255,13,
            0,6,31,0,0,0,7,74,97,118,97,
            32,86,77,1,224,255,255,255,252,255,255,
            255,14,0,6,33,0,0,0,5,77,83,
            68,79,83,1,222,255,255,255,252,255,255,
            255,15,0,6,35,0,0,0,11,87,105,
            110,100,111,119,115,32,51,46,120,1,220,
            255,255,255,252,255,255,255,16,0,6,37,
            0,0,0,10,87,105,110,100,111,119,115,
            32,57,53,1,218,255,255,255,252,255,255,
            255,17,0,6,39,0,0,0,10,87,105,
            110,100,111,119,115,32,57,56,1,216,255,
            255,255,252,255,255,255,18,0,6,41,0,
            0,0,10,87,105,110,100,111,119,115,32,
            78,84,1,214,255,255,255,252,255,255,255,
            19,0,6,43,0,0,0,10,87,105,110,
            100,111,119,115,32,67,69,1,212,255,255,
            255,252,255,255,255,20,0,6,45,0,0,
            0,8,78,67,82,32,51,48,48,48,1,
            210,255,255,255,252,255,255,255,21,0,6,
            47,0,0,0,7,78,101,116,87,97,114,
            101,1,208,255,255,255,252,255,255,255,22,
            0,6,49,0,0,0,3,79,83,70,1,
            206,255,255,255,252,255,255,255,23,0,6,
            51,0,0,0,5,68,67,47,79,83,1,
            204,255,255,255,252,255,255,255,24,0,6,
            53,0,0,0,12,82,101,108,105,97,110,
            116,32,85,78,73,88,1,202,255,255,255,
            252,255,255,255,25,0,6,55,0,0,0,
            12,83,67,79,32,85,110,105,120,87,97,
            114,101,1,200,255,255,255,252,255,255,255,
            26,0,6,57,0,0,0,14,83,67,79,
            32,79,112,101,110,83,101,114,118,101,114,
            1,198,255,255,255,252,255,255,255,27,0,
            6,59,0,0,0,7,83,101,113,117,101,
            110,116,1,196,255,255,255,252,255,255,255,
            28,0,6,61,0,0,0,4,73,82,73,
            88,1,194,255,255,255,252,255,255,255,29,
            0,6,63,0,0,0,7,83,111,108,97,
            114,105,115,1,192,255,255,255,252,255,255,
            255,30,0,6,65,0,0,0,5,83,117,
            110,79,83,1,190,255,255,255,252,255,255,
            255,31,0,6,67,0,0,0,5,85,54,
            48,48,48,1,188,255,255,255,252,255,255,
            255,32,0,6,69,0,0,0,8,65,32,
            83,101,114,105,101,115,1,186,255,255,255,
            252,255,255,255,33,0,6,71,0,0,0,
            10,84,97,110,100,101,109,32,78,83,75,
            1,184,255,255,255,252,255,255,255,34,0,
            6,73,0,0,0,9,84,97,110,100,101,
            109,32,78,84,1,182,255,255,255,252,255,
            255,255,35,0,6,75,0,0,0,10,66,
            83,50,48,48,48,47,79,83,68,1,180,
            255,255,255,252,255,255,255,36,0,6,77,
            0,0,0,5,76,105,110,117,120,1,178,
            255,255,255,252,255,255,255,37,0,6,79,
            0,0,0,4,76,121,110,120,1,176,255,
            255,255,252,255,255,255,38,0,6,81,0,
            0,0,5,88,101,110,105,120,1,174,255,
            255,255,252,255,255,255,39,0,6,83,0,
            0,0,6,86,77,47,69,83,65,1,172,
            255,255,255,252,255,255,255,40,0,6,85,
            0,0,0,16,73,110,116,101,114,97,99,
            116,105,118,101,32,85,78,73,88,1,170,
            255,255,255,252,255,255,255,41,0,6,87,
            0,0,0,8,66,83,68,32,85,78,73,
            88,1,168,255,255,255,252,255,255,255,42,
            0,6,89,0,0,0,7,70,114,101,101,
            66,83,68,1,166,255,255,255,252,255,255,
            255,43,0,6,91,0,0,0,6,78,101,
            116,66,83,68,1,164,255,255,255,252,255,
            255,255,44,0,6,93,0,0,0,8,71,
            78,85,32,72,117,114,100,1,162,255,255,
            255,252,255,255,255,45,0,6,95,0,0,
            0,8,77,97,99,32,79,83,32,57,1,
            160,255,255,255,252,255,255,255,46,0,6,
            97,0,0,0,11,77,97,99,104,32,75,
            101,114,110,101,108,1,158,255,255,255,252,
            255,255,255,47,0,6,99,0,0,0,7,
            73,110,102,101,114,110,111,1,156,255,255,
            255,252,255,255,255,48,0,6,101,0,0,
            0,3,81,78,88,1,154,255,255,255,252,
            255,255,255,49,0,6,103,0,0,0,4,
            69,80,79,67,1,152,255,255,255,252,255,
            255,255,50,0,6,105,0,0,0,7,73,
            120,87,111,114,107,115,1,150,255,255,255,
            252,255,255,255,51,0,6,107,0,0,0,
            7,86,120,87,111,114,107,115,1,148,255,
            255,255,252,255,255,255,52,0,6,109,0,
            0,0,4,77,105,78,84,1,146,255,255,
            255,252,255,255,255,53,0,6,111,0,0,
            0,4,66,101,79,83,1,144,255,255,255,
            252,255,255,255,54,0,6,113,0,0,0,
            6,72,80,32,77,80,69,1,142,255,255,
            255,252,255,255,255,55,0,6,115,0,0,
            0,8,78,69,88,84,83,84,69,80,1,
            140,255,255,255,252,255,255,255,56,0,6,
            117,0,0,0,7,80,97,108,109,32,79,
            83,1,138,255,255,255,252,255,255,255,57,
            0,6,119,0,0,0,8,82,104,97,112,
            115,111,100,121,1,136,255,255,255,252,255,
            255,255,58,0,6,121,0,0,0,12,87,
            105,110,100,111,119,115,32,50,48,48,48,
            1,134,255,255,255,252,255,255,255,59,0,
            6,123,0,0,0,9,68,101,100,105,99,
            97,116,101,100,1,132,255,255,255,252,255,
            255,255,60,0,6,125,0,0,0,6,79,
            83,47,51,57,48,1,130,255,255,255,252,
            255,255,255,61,0,6,127,0,0,0,3,
            86,83,69,1,128,255,255,255,252,255,255,
            255,62,0,6,129,0,0,0,3,84,80,
            70,11,0
        };


        /// <summary>
        /// 成立一个实例使用后类或子类的名字
        /// </summary> 
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// Scoping计算机系统的成立类名  
        /// </summary>
        public string CSCreationClassName
        {
            get { return cSCreationClassName; }
            set { cSCreationClassName = value; }
        }
        /// <summary>
        /// Scoping计算机系统的名字
        /// </summary>
        public string CSName
        {
            get { return cSName; }
            set { cSName = value; }
        }
        /// <summary>
        /// 操作系统相对格林威志时间的分钟数. 
        /// </summary>
        public Int16 CurrentTimeZone
        {
            get { return currentTimeZone; }
            set { currentTimeZone = value; }
        }
        /// <summary>
        /// 对象的描写
        /// </summary>
        public bool Distributed
        {
            get { return distributed; }
            set { distributed = value; }
        }
        /// <summary>
        /// If True, the operating system is distributed across several computer system nodes, which should be grouped as a cluster
        /// </summary>
        ///如真,操作系统是分布式联接几个分布式计算机系统节点,它组合成一个群
        public UInt64 FreePhysicalMemory
        {
            get { return freePhysicalMemory; }
            set { freePhysicalMemory = value; }
        }
        /// <summary>
        /// For information on using uint64 values in scripts
        /// </summary>
        //在脚本上使用Uint64的值的报告
        public UInt64 FreeSpaceInPagingFiles
        {
            get { return freeSpaceInPagingFiles; }
            set { freeSpaceInPagingFiles = value; }
        }
        /// <summary>
        /// 当前在和已使用的虑拟内存的千字节数
        /// </summary>
        public UInt64 FreeVirtualMemory
        {
            get { return freeVirtualMemory; }
            set { freeVirtualMemory = value; }
        }
        /// <summary>
        /// 操作系统最后一次使用的时间
        /// </summary>
        public DateTime LastBootUpTime
        {
            get 
            {
                lastBootUpTime = DmtfConverter.ToDateTime(cim_LastBootUpTime);
                return lastBootUpTime; 
            }
        }
        public string Cim_LastBootUpTime
        {
            get { return cim_LastBootUpTime; }
            set { cim_LastBootUpTime = value; }
        }
        /// <summary>
        /// 操作系统的日期和时间
        /// </summary>
        public DateTime LocalDateTime
        {
            get 
            {
                localDateTime = DmtfConverter.ToDateTime(cim_LocalDateTime);
                return localDateTime;
            }
        }
        public string Cim_LocalDateTime
        {
            get { return cim_LocalDateTime; }
            set { cim_LocalDateTime = value; }
        }
        /// <summary>
        /// 操作系统能支持的最大进程数
        /// </summary>
        public UInt32 MaxNumberOfProcesses
        {
            get { return maxNumberOfProcesses; }
            set { maxNumberOfProcesses = value; }
        }
        /// <summary>
        /// 进程能被分配的最大内存数
        /// </summary>
        public UInt64 MaxProcessMemorySize
        {
            get { return maxProcessMemorySize; }
            set { maxProcessMemorySize = value; }
        }
        /// <summary>
        /// 操作系统的操作许可证号
        /// </summary>
        public UInt32 NumberOfLicensedUsers
        {
            get { return numberOfLicensedUsers; }
            set { numberOfLicensedUsers = value; }
        }
        /// <summary>
        /// 运行在系统上的所有进程的数量
        /// </summary>
        public UInt32 NumberOfProcesses
        {
            get { return numberOfProcesses; }
            set { numberOfProcesses = value; }
        }
        /// <summary>
        /// 当前在操作系统上使用的活动的使用者的数量
        /// </summary>
        public UInt32 NumberOfUsers
        {
            get { return numberOfUsers; }
            set { numberOfUsers = value; }
        }
        /// <summary>
        /// 操作系统的类型
        /// </summary>
        public UInt32 OSType
        {
            get { return oSType; }
            set { oSType = value; }
        }
        /// <summary>
        /// 当OSTyte属性设为1("Other")时对厂商和计算机系统类型的说明
        /// </summary>
        public string OtherTypeDescription
        {
            get { return otherTypeDescription; }
            set { otherTypeDescription = value; }
        }
        /// <summary>
        ///系统页文件能被存贮的千字节数
        /// </summary>
        public UInt64 SizeStoredInPagingFiles
        {
            get { return sizeStoredInPagingFiles; }
            set { sizeStoredInPagingFiles = value; }
        }
        /// <summary>
        /// 总的交换空间,用千字节
        /// </summary>
        public UInt64 TotalSwapSpaceSize
        {
            get { return totalSwapSpaceSize; }
            set { totalSwapSpaceSize = value; }
        }
        /// <summary>
        /// 总的虚拟内荐
        /// </summary>
        public UInt64 TotalVirtualMemorySize
        {
            get { return totalVirtualMemorySize; }
            set { totalVirtualMemorySize = value; }
        }
        /// <summary>
        /// 操作系统能用到的总的物理内荐的数量
        /// </summary>
        public UInt64 TotalVisibleMemorySize
        {
            get { return totalVisibleMemorySize; }
            set { totalVisibleMemorySize = value; }
        }
        /// <summary>
        /// <major>.<minor>.<revision>或<major>.<minor><letter><revision>
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        public Dictionary<ushort, string> YxDictionOSType
        {
            get {
                GetParser();
                return dictionOSType;
            }
        }
        /// <summary>
        /// 得到OSType的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetDictionOSTypeByShort(ushort key)
        {
            string dic;
            bool a = YxDictionOSType.TryGetValue(key, out dic);
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
            this.dictionOSType = (Dictionary<ushort, string>)formatter1.Deserialize(stream1);
        }

    }
}
