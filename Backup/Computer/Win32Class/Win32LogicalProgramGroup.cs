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
        /// windows�����������
        /// </summary>
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        /// <summary>
        /// ����������е��û�
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
