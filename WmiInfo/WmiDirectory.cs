using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Management;

namespace WmiInfo
{
    public class WmiDirectory : WmiBase
    {
        private string WSql = "SELECT * FROM Win32_Directory";

        public WmiDirectory()
            : base()
        {
        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="directoryname">文件夹全名如：c:\test\aaaa</param>
        public WmiDirectory(string ip, string username, string password)
            : base(ip, username, password)
        {
        }

        protected override void FillFloppyDriveInfo()
        {
            throw new Exception("文件太多,不能真接取");
        }
        public List<Win32Directory> GetDirectoryByPathAndCharacter(string anypath,CharacterDirectory cd)
        {
            Win32Directory ps;
            string aWSql = this.WSql + " where Path='" + anypath.Replace(@"\", @"\\") + "' and " + cd.ToString() + "=true";
            System.Console.WriteLine(aWSql);
            ManagementObjectCollection moc = this.GetAllInfo(aWSql);
            List<Win32Directory> dc = new List<Win32Directory>();
            foreach (ManagementObject mo in moc)
            {
                ps = new Win32Directory();                
                if (mo != null)
                {
                    ps.AccessMask = GetManagementObject<uint>(mo, "AccessMask");
                    ps.Archive = GetManagementObject<bool>(mo, "Archive");
                    ps.Caption = GetManagementObject<string>(mo, "Caption");
                    ps.Compressed = GetManagementObject<bool>(mo, "Compressed");
                    ps.CompressionMethod = GetManagementObject<string>(mo, "CompressionMethod");
                    ps.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    ps.Cim_CreationDate = GetManagementObject<string>(mo, "CreationDate");
                    ps.CSCreationClassName = GetManagementObject<string>(mo, "CSCreationClassName");
                    ps.CSName = GetManagementObject<string>(mo, "CSName");
                    ps.Description = GetManagementObject<string>(mo, "Description");
                    ps.Drive = GetManagementObject<string>(mo, "Drive");
                    ps.EightDotThreeFileName = GetManagementObject<string>(mo, "EightDotThreeFileName");
                    ps.Encrypted = GetManagementObject<bool>(mo, "Encrypted");
                    ps.EncryptionMethod = GetManagementObject<string>(mo, "EncryptionMethod");
                    ps.Extension = GetManagementObject<string>(mo, "Extension");
                    ps.FileName = GetManagementObject<string>(mo, "FileName");
                    ps.FileSize = GetManagementObject<ulong>(mo, "FileSize");
                    ps.FileType = GetManagementObject<string>(mo, "FileType");
                    ps.FSCreationClassName = GetManagementObject<string>(mo, "FSCreationClassName");
                    ps.FSName = GetManagementObject<string>(mo, "FSName");
                    ps.Hidden = GetManagementObject<bool>(mo, "Hidden");
                    ps.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    ps.InUseCount = GetManagementObject<ulong>(mo, "InUseCount");
                    ps.Cim_LastAccessed = GetManagementObject<string>(mo, "LastAccessed");
                    ps.Cim_LastModified = GetManagementObject<string>(mo, "LastModified");
                    ps.Name = GetManagementObject<string>(mo, "Name");
                    ps.Path = GetManagementObject<string>(mo, "Path");
                    ps.Readable = GetManagementObject<bool>(mo, "Readable");
                    ps.Status = GetManagementObject<string>(mo, "Status");
                    ps.System = GetManagementObject<bool>(mo, "System");
                    ps.Writeable = GetManagementObject<bool>(mo, "Writeable");
                    dc.Add(ps);
                }
            }
            moc.Dispose();
            return dc;
        }
        public List<Win32Directory> GetDirectoryByPath(string anypath)
        {
            Win32Directory ps;
            string aWSql = this.WSql + " where Path='" + anypath.Replace(@"\", @"\\") + "'";
            System.Console.WriteLine(aWSql);
            ManagementObjectCollection moc = this.GetAllInfo(aWSql);
            List<Win32Directory> dc = new List<Win32Directory>();
            foreach (ManagementObject mo in moc)
            {
                ps = new Win32Directory();
                if (mo != null)
                {
                    ps.AccessMask = GetManagementObject<uint>(mo, "AccessMask");
                    ps.Archive = GetManagementObject<bool>(mo, "Archive");
                    ps.Caption = GetManagementObject<string>(mo, "Caption");
                    ps.Compressed = GetManagementObject<bool>(mo, "Compressed");
                    ps.CompressionMethod = GetManagementObject<string>(mo, "CompressionMethod");
                    ps.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    ps.Cim_CreationDate = GetManagementObject<string>(mo, "CreationDate");
                    ps.CSCreationClassName = GetManagementObject<string>(mo, "CSCreationClassName");
                    ps.CSName = GetManagementObject<string>(mo, "CSName");
                    ps.Description = GetManagementObject<string>(mo, "Description");
                    ps.Drive = GetManagementObject<string>(mo, "Drive");
                    ps.EightDotThreeFileName = GetManagementObject<string>(mo, "EightDotThreeFileName");
                    ps.Encrypted = GetManagementObject<bool>(mo, "Encrypted");
                    ps.EncryptionMethod = GetManagementObject<string>(mo, "EncryptionMethod");
                    ps.Extension = GetManagementObject<string>(mo, "Extension");
                    ps.FileName = GetManagementObject<string>(mo, "FileName");
                    ps.FileSize = GetManagementObject<ulong>(mo, "FileSize");
                    ps.FileType = GetManagementObject<string>(mo, "FileType");
                    ps.FSCreationClassName = GetManagementObject<string>(mo, "FSCreationClassName");
                    ps.FSName = GetManagementObject<string>(mo, "FSName");
                    ps.Hidden = GetManagementObject<bool>(mo, "Hidden");
                    ps.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    ps.InUseCount = GetManagementObject<ulong>(mo, "InUseCount");
                    ps.Cim_LastAccessed = GetManagementObject<string>(mo, "LastAccessed");
                    ps.Cim_LastModified = GetManagementObject<string>(mo, "LastModified");
                    ps.Name = GetManagementObject<string>(mo, "Name");
                    ps.Path = GetManagementObject<string>(mo, "Path");
                    ps.Readable = GetManagementObject<bool>(mo, "Readable");
                    ps.Status = GetManagementObject<string>(mo, "Status");
                    ps.System = GetManagementObject<bool>(mo, "System");
                    ps.Writeable = GetManagementObject<bool>(mo, "Writeable");

                    dc.Add(ps);
                }
            }
            moc.Dispose();
            return dc;
        }
        public Win32Directory GetDriectoryUnitByName(string anyname)
        {
            Win32Directory ps = null;
            string aWSql = this.WSql + " where Name='" + anyname.Replace(@"\", @"\\") + "'";
            System.Console.WriteLine(aWSql);
            ManagementObjectCollection moc = this.GetAllInfo(aWSql);
            foreach (ManagementObject mo in moc)
            {
                ps = new Win32Directory();
                if (mo != null)
                {
                    ps.AccessMask = GetManagementObject<uint>(mo, "AccessMask");
                    ps.Archive = GetManagementObject<bool>(mo, "Archive");
                    ps.Caption = GetManagementObject<string>(mo, "Caption");
                    ps.Compressed = GetManagementObject<bool>(mo, "Compressed");
                    ps.CompressionMethod = GetManagementObject<string>(mo, "CompressionMethod");
                    ps.CreationClassName = GetManagementObject<string>(mo, "CreationClassName");
                    ps.Cim_CreationDate = GetManagementObject<string>(mo, "CreationDate");
                    ps.CSCreationClassName = GetManagementObject<string>(mo, "CSCreationClassName");
                    ps.CSName = GetManagementObject<string>(mo, "CSName");
                    ps.Description = GetManagementObject<string>(mo, "Description");
                    ps.Drive = GetManagementObject<string>(mo, "Drive");
                    ps.EightDotThreeFileName = GetManagementObject<string>(mo, "EightDotThreeFileName");
                    ps.Encrypted = GetManagementObject<bool>(mo, "Encrypted");
                    ps.EncryptionMethod = GetManagementObject<string>(mo, "EncryptionMethod");
                    ps.Extension = GetManagementObject<string>(mo, "Extension");
                    ps.FileName = GetManagementObject<string>(mo, "FileName");
                    ps.FileSize = GetManagementObject<ulong>(mo, "FileSize");
                    ps.FileType = GetManagementObject<string>(mo, "FileType");
                    ps.FSCreationClassName = GetManagementObject<string>(mo, "FSCreationClassName");
                    ps.FSName = GetManagementObject<string>(mo, "FSName");
                    ps.Hidden = GetManagementObject<bool>(mo, "Hidden");
                    ps.Cim_InstallDate = GetManagementObject<string>(mo, "InstallDate");
                    ps.InUseCount = GetManagementObject<ulong>(mo, "InUseCount");
                    ps.Cim_LastAccessed = GetManagementObject<string>(mo, "LastAccessed");
                    ps.Cim_LastModified = GetManagementObject<string>(mo, "LastModified");
                    ps.Name = GetManagementObject<string>(mo, "Name");
                    ps.Path = GetManagementObject<string>(mo, "Path");
                    ps.Readable = GetManagementObject<bool>(mo, "Readable");
                    ps.Status = GetManagementObject<string>(mo, "Status");
                    ps.System = GetManagementObject<bool>(mo, "System");
                    ps.Writeable = GetManagementObject<bool>(mo, "Writeable");
                }
            }
            moc.Dispose();
            return ps;
        }
    }
    public enum CharacterDirectory
	{
		Archive=1,
		Compressed=2,
		Encrypted=3,
		Hidden=4,
		Readable=5,
		System=6,
		Writeable=7
	}
}
