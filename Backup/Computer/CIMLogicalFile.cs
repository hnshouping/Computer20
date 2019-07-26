using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;

namespace Computer
{
    public abstract class CIMLogicalFile : CIMLogicalElement
    {
        private UInt32 accessMask;
        private bool archive;
        private bool compressed;
        private string compressionMethod;
        private string creationClassName;
        private DateTime creationDate;
        private string cim_CreationDate;
        private string cSCreationClassName;
        private string cSName;
        private string drive;
        private string eightDotThreeFileName;
        private bool encrypted;
        private string encryptionMethod;
        private string extension;
        private string fileName;
        private UInt64 fileSize;
        private string fileType;
        private string fSCreationClassName;
        private string fSName;
        private bool hidden;
        private UInt64 inUseCount;
        private DateTime lastAccessed;
        private string cim_LastAccessed;
        private DateTime lastModified;
        private string cim_LastModified;
        private string path;
        private bool readable;
        private bool system;
        private bool writeable;


        private Dictionary<uint, string> dictionAccessMask;

        private byte[] arr ={
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
            0,0,0,0,6,5,0,0,0,19,70,
            73,76,69,95,76,73,83,84,95,68,73,
            82,69,67,84,79,82,89,1,250,255,255,
            255,252,255,255,255,1,0,0,0,6,7,
            0,0,0,13,70,73,76,69,95,65,68,
            68,95,70,73,76,69,1,248,255,255,255,
            252,255,255,255,2,0,0,0,6,9,0,
            0,0,21,70,73,76,69,95,65,68,68,
            95,83,85,66,68,73,82,69,67,84,79,
            82,89,1,246,255,255,255,252,255,255,255,
            3,0,0,0,6,11,0,0,0,12,70,
            73,76,69,95,82,69,65,68,95,69,65,
            1,244,255,255,255,252,255,255,255,4,0,
            0,0,6,13,0,0,0,13,70,73,76,
            69,95,87,82,73,84,69,95,69,65,1,
            242,255,255,255,252,255,255,255,5,0,0,
            0,6,15,0,0,0,13,70,73,76,69,
            95,84,82,65,86,69,82,83,69,1,240,
            255,255,255,252,255,255,255,6,0,0,0,
            6,17,0,0,0,17,70,73,76,69,95,
            68,69,76,69,84,69,95,67,72,73,76,
            68,1,238,255,255,255,252,255,255,255,7,
            0,0,0,6,19,0,0,0,20,70,73,
            76,69,95,82,69,65,68,95,65,84,84,
            82,73,66,85,84,69,83,1,236,255,255,
            255,252,255,255,255,8,0,0,0,6,21,
            0,0,0,21,70,73,76,69,95,87,82,
            73,84,69,95,65,84,84,82,73,66,85,
            84,69,83,1,234,255,255,255,252,255,255,
            255,16,0,0,0,6,23,0,0,0,6,
            68,69,76,69,84,69,1,232,255,255,255,
            252,255,255,255,17,0,0,0,6,25,0,
            0,0,12,82,69,65,68,95,67,79,78,
            84,82,79,76,1,230,255,255,255,252,255,
            255,255,18,0,0,0,6,27,0,0,0,
            9,87,82,73,84,69,95,68,65,67,1,
            228,255,255,255,252,255,255,255,19,0,0,
            0,6,29,0,0,0,11,87,82,73,84,
            69,95,79,87,78,69,82,1,226,255,255,
            255,252,255,255,255,20,0,0,0,6,31,
            0,0,0,11,83,89,78,67,72,82,79,
            78,73,90,69,11,0
        };

        /// <summary>
        /// 二进制队列,表示正确连接到特定的文件或文件夹把握通过用户或组控制返回的实例
        /// </summary>
        public UInt32 AccessMask
        {
            get { return accessMask; }
            set { accessMask = value; }
        }
        /// <summary>
        /// 如果真,这个文件将被存档
        /// </summary>
        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        /// <summary>
        /// 如果真,这个文件将被压缩
        /// </summary>
        public bool Compressed
        {
            get { return compressed; }
            set { compressed = value; }
        }
        /// <summary>
        /// 指出使用什么算法或工具压缩逻辑文件
        /// </summary>
        public string CompressionMethod
        {
            get { return compressionMethod; }
            set { compressionMethod = value; }
        }
        /// <summary>
        /// 类的名字
        /// </summary>
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// 文件成立的日期
        /// </summary>
        public DateTime CreationDate
        {
            get 
            {
                creationDate = DmtfConverter.ToDateTime(cim_CreationDate);
                return creationDate; 
            }
        }
        public string Cim_CreationDate
        {
            get { return cim_CreationDate; }
            set { cim_CreationDate = value; }
        }
        /// <summary>
        /// 计算机系统的类名
        /// </summary>
        public string CSCreationClassName
        {
            get { return cSCreationClassName; }
            set { cSCreationClassName = value; }
        }
        /// <summary>
        /// 计算机系统的名字
        /// </summary>
        public string CSName
        {
            get { return cSName; }
            set { cSName = value; }
        }
        /// <summary>
        /// 这个文件的驱动标志 如:"C;"
        /// </summary>
        public string Drive
        {
            get { return drive; }
            set { drive = value; }
        }
        /// <summary>
        /// dos一到的文件名 如:"c:\progra~1"
        /// </summary>
        public string EightDotThreeFileName
        {
            get { return eightDotThreeFileName; }
            set { eightDotThreeFileName = value; }
        }
        /// <summary>
        /// 如真,这个文件被加密
        /// </summary>
        public bool Encrypted
        {
            get { return encrypted; }
            set { encrypted = value; }
        }
        /// <summary>
        /// 指出使用什么算法或工具加密逻辑文件
        /// </summary>
        public string EncryptionMethod
        {
            get { return encryptionMethod; }
            set { encryptionMethod = value; }
        }
        /// <summary>
        /// 文件的后缀 如:"txt", "mof", "mdb"
        /// </summary>
        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        /// <summary>
        /// 没有后缀的文件名 如:"MyDataFile"
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        /// <summary>
        /// 文件的尺寸
        /// </summary>
        public UInt64 FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }
        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }
        /// <summary>
        /// 文件系统的类
        /// </summary>
        public string FSCreationClassName
        {
            get { return fSCreationClassName; }
            set { fSCreationClassName = value; }
        }
        /// <summary>
        /// 文件系统的名字
        /// </summary>
        public string FSName
        {
            get { return fSName; }
            set { fSName = value; }
        }
        /// <summary>
        /// 如真,这个文件被隐藏
        /// </summary>
        public bool Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }
        /// <summary>
        /// 那是现在流行的文件倚靠的"打开文件"的数量
        /// </summary>
        public UInt64 InUseCount
        {
            get { return inUseCount; }
            set { inUseCount = value; }
        }
        /// <summary>
        /// 最后一次访问的时间
        /// </summary>
        public DateTime LastAccessed
        {
            get 
            {
                lastAccessed = DmtfConverter.ToDateTime(cim_LastAccessed);
                return lastAccessed; 
            }
        }
        public string Cim_LastAccessed
        {
            get { return cim_LastAccessed; }
            set { cim_LastAccessed = value; }
        }
        /// <summary>
        /// 最后一次修改的时间
        /// </summary>
        public DateTime LastModified
        {
            get 
            {
                lastModified = DmtfConverter.ToDateTime(cim_LastModified);
                return lastModified; 
            }
        }
        public string Cim_LastModified
        {
            get { return cim_LastModified; }
            set { cim_LastModified = value; }
        }
        /// <summary>
        /// 包括反斜线的文件路径 如:"\windows\system\"
        /// </summary>
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        /// <summary>
        /// 如真文件能读
        /// </summary>
        public bool Readable
        {
            get { return readable; }
            set { readable = value; }
        }
        /// <summary>
        /// 如真,这文件是系统文件
        /// </summary>
        public bool System
        {
            get { return system; }
            set { system = value; }
        }
        /// <summary>
        /// 如真,这文件能写
        /// </summary>
        public bool Writeable
        {
            get { return writeable; }
            set { writeable = value; }
        }
        /// <summary>
        /// 得到AccessMask的意思
        /// </summary>
        public Dictionary<uint, string> YxDictionAccessMask
        {
            get { 
                GetParser();
                return dictionAccessMask; 
            }
        }

        public abstract uint ChangeSecurityPermissions(Win32SecurityDescriptor SecurityDescriptor, uint Option);

        public abstract uint ChangeSecurityPermissionsEx(
            Win32SecurityDescriptor SecurityDescriptor,
            uint Option,
            string StopFileName,
            string StartFileName,
            bool Recursive
            );
        public abstract uint Compress();
        public abstract uint CompressEx(ref string StopFileName, string StartFileName, bool Recursive);
        public abstract uint Copy(string FileName);
        public abstract uint CopyEx(string FileName, string StopFileName, string StartFileName, bool Recursive);
        public abstract uint Delete();
        public abstract uint DeleteEx(ref string StopFileName, string StartFileName);
        public abstract bool GetEffectivePermission(uint Permissions);
        public abstract uint Rename(string FileName);
        public abstract uint TakeOwnerShip();
        public abstract uint TakeOwnerShipEx(ref string StopFileName, string StartFileName, bool Recursive);
        public abstract uint Uncompress();
        public abstract uint UncompressEx(ref string StopFileName, string StartFileName, bool Recursive);

        /// <summary>
        /// 得到AccessMask的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>意思</returns>
        public string GetFieldAccessMaskbyInt(uint key)
        {
            string dic;
            bool a = this.YxDictionAccessMask.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }


        /// <summary>
        /// 通过函数的返回值,得到执行情况
        /// </summary>
        /// <param name="hint">函数返回值</param>
        /// <returns>执行情况</returns>
        public string GetHintByReturnValue(uint hint)
        {
            switch (hint)
            {
                case 0:
                    return "The request was successful.";
                case 2:
                    return "Access was denied.";
                case 8:
                    return "An unspecified failure occurred.";
                case 9:
                    return "The name specified was invalid.";
                case 10:
                    return "The object specified already exists.";
                case 11:
                    return "The file system is not NTFS.";
                case 12:
                    return "The platform is not Windows NT or Windows 2000.";
                case 13:
                    return "The drive is not the same.";
                case 14:
                    return "The directory is not empty.";
                case 15:
                    return "There has been a sharing violation.";
                case 16:
                    return "The start file specified was invalid.";
                case 17:
                    return "A privilege required for the operation is not held.";
                case 21:
                    return "A parameter specified is invalid.";
                default:
                    return "State_No_Exec";
            }
        }

        #region IParser 成员

        private void GetParser()
        {
            MemoryStream stream1 = new MemoryStream(this.arr);
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = FormatterAssemblyStyle.Simple;
            this.dictionAccessMask = (Dictionary<uint, string>)formatter1.Deserialize(stream1);

        }

        #endregion
    }
}
