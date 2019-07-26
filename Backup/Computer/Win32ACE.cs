using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class Win32ACE
    {
        private uint accessMask;
        private uint aceFlags;
        private uint aceType;
        private string guidInheritedObjectType;
        private string guidObjectType;
        private Win32Trustee trustee;

        public const uint ACCESSMASK_FILE_LIST_DIRECTORY = 1;
        public const uint ACCESSMASK_FILE_ADD_FILE = 2;
        public const uint ACCESSMASK_FILE_ADD_SUBDIRECTORY = 4;
        public const uint ACCESSMASK_FILE_READ_EA = 8;
        public const uint ACCESSMASK_FILE_WRITE_EA = 16;
        public const uint ACCESSMASK_FILE_TRAVERSE = 32;
        public const uint ACCESSMASK_FILE_DELETE_CHILD = 64;
        public const uint ACCESSMASK_FILE_READ_ATTRIBUTES = 128;
        public const uint ACCESSMASK_FILE_WRITE_ATTRIBUTES = 256;
        public const uint ACCESSMASK_DELETE = 65536;
        public const uint ACCESSMASK_WRITE_DAC = 262144;
        public const uint ACCESSMASK_READ_CONTROL = 524288;
        public const uint ACCESSMASK_SYNCHRONIZE = 1048576;


        public const uint ACEFLAGS_OBJECT_INHERIT_ACE = 1;
        public const uint ACEFLAGS_CONTAINER_INHERIT_ACE = 2;
        public const uint ACEFLAGS_NO_PROPAGATE_INHERIT_ACE = 4;
        public const uint ACEFLAGS_INHERIT_ONLY_ACE = 8;
        public const uint ACEFLAGS_INHERITED_ACE = 16;
        public const uint ACEFLAGS_SUCCESSFUL_ACCESS_ACE_FLAG = 64;
        public const uint ACEFLAGS_FAILED_ACCESS_ACE_FLAG = 128;

        public enum enumAceType
        {
            Access_Allowed, Access_Denied, Audit
        }


        /// <summary>
        /// �ֽڱ�־ָ��ͬ���ܾ��й���.
        /// </summary>
        public uint AccessMask
        {
            get { return accessMask; }
            set { accessMask = value; }
        }
        /// <summary>
        ///ACE����ϸ˵��
        /// </summary>
        public uint AceFlags
        {
            get { return aceFlags; }
            set { aceFlags = value; }
        }
        /// <summary>
        /// ACE������
        /// </summary>
        public uint AceType
        {
            get { return aceType; }
            set { aceType = value; }
        }
        /// <summary>
        /// GUIDֵ˫���ǵõ���
        /// </summary>
        public string GuidInheritedObjectType
        {
            get { return guidInheritedObjectType; }
            set { guidInheritedObjectType = value; }
        }
        /// <summary>
        /// GUIDֵ
        /// </summary>
        public string GuidObjectType
        {
            get { return guidObjectType; }
            set { guidObjectType = value; }
        }
        /// <summary>
        /// ���������û�,��,���ϵ�½��ACE��־
        /// </summary>
        public Win32Trustee Trustee
        {
            get { return trustee; }
            set { trustee = value; }
        }
    }
}
