using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32LogicalProgramGroup : Win32ProgramGroupOrItem
    {
        private string groupName;
        private string userName;

        /// <summary>
        /// windows程序组的名字
        /// </summary>
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        /// <summary>
        /// 这个程序组中的用户
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
