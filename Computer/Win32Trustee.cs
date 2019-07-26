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
        /// ��һ���й��˵�����
        /// </summary>
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }
        /// <summary>
        /// �ܱ��û�,��,���ϵ�½��ʹ�õ���
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Ψһʶ���û�,���ֵ
        /// </summary>
        public byte[] SID
        {
            get { return sid; }
            set { sid = value; }
        }
        /// <summary>
        /// SID�ֽڳ���
        /// </summary>
        public uint SidLength
        {
            get { return sidLength; }
            set { sidLength = value; }
        }
        /// <summary>
        /// SID���ַ���ʾ ��:"S-1-1-0"
        /// </summary>
        public string SidString
        {
            get { return sidString; }
            set { sidString = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public ulong TIMECREATED
        {
            get { return tIMECREATED; }
            set { tIMECREATED = value; }
        }
    }
}
