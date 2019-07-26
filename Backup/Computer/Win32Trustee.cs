using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    /// <summary>
    /// 
    /// </summary>
    public class Win32Trustee
    {
        private string domain;
        private string name;
        private byte[] sid;
        private uint sidLength;
        private string sidString;
        private ulong tIMECREATED;

        /// <summary>
        /// 哪一个托管人的领域
        /// </summary>
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }
        /// <summary>
        /// 能被用户,组,网上登陆者使用的域
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 唯一识别用户,组的值
        /// </summary>
        public byte[] SID
        {
            get { return sid; }
            set { sid = value; }
        }
        /// <summary>
        /// SID字节长度
        /// </summary>
        public uint SidLength
        {
            get { return sidLength; }
            set { sidLength = value; }
        }
        /// <summary>
        /// SID的字符表示 如:"S-1-1-0"
        /// </summary>
        public string SidString
        {
            get { return sidString; }
            set { sidString = value; }
        }
        /// <summary>
        /// 创造时间
        /// </summary>
        public ulong TIMECREATED
        {
            get { return tIMECREATED; }
            set { tIMECREATED = value; }
        }
    }
}
