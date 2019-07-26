using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class Win32SecurityDescriptor
    {
        private uint controlFlags;
        private Win32ACE[] dACL;
        private Win32Trustee group;
        private Win32Trustee owner;
        private Win32ACE[] sACL;

        public const uint CONTROLFLAGS_SE_OWNER_DEFAULTED = 1;
        public const uint CONTROLFLAGS_SE_GROUP_DEFAULTED = 2;
        public const uint CONTROLFLAGS_SE_DACL_PRESENT = 4;
        public const uint CONTROLFLAGS_SE_DACL_DEFAULTED = 8;
        public const uint CONTROLFLAGS_SE_SACL_PRESENT = 16;
        public const uint CONTROLFLAGS_SE_SACL_DEFAULTED = 32;
        public const uint CONTROLFLAGS_SE_DACL_AUTO_INHERIT_REQ = 256;
        public const uint CONTROLFLAGS_SE_SACL_AUTO_INHERIT_REQ = 512;
        public const uint CONTROLFLAGS_SE_DACL_AUTO_INHERITED = 1024;
        public const uint CONTROLFLAGS_SE_SACL_AUTO_INHERITED = 2048;
        public const uint CONTROLFLAGS_SE_DACL_PROTECTED = 4096;
        public const uint CONTROLFLAGS_SE_SACL_PROTECTED = 8192;
        public const uint CONTROLFLAGS_SE_SELF_RELATIVE = 32768;
 
        /// <summary>
        /// Control bits that qualify the meaning of a security descriptor (SD) or its individual members.
        /// </summary>
        public uint ControlFlags
        {
            get { return controlFlags; }
            set { controlFlags = value; }
        }
        /// <summary>
        /// Each array entry defines the type of object access that the system grants to a specific user or group. 
        /// </summary>
        public Win32ACE[] DACL
        {
            get { return dACL; }
            set { dACL = value; }
        }
        /// <summary>
        /// Group that owns this object.
        /// </summary>
        public Win32Trustee Group
        {
            get { return group; }
            set { group = value; }
        }
        /// <summary>
        /// Owner of an object.
        /// </summary>
        public Win32Trustee Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        /// <summary>
        /// Each array entry defines the type of access attempts that generate audit records for a specific user or group.
        /// </summary>
        public Win32ACE[] SACL
        {
            get { return sACL; }
            set { sACL = value; }
        }
    }
}
