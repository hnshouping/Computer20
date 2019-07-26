using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMSetting
    {
        private string caption;
        private string description;
        private string settingID;

        /// <summary>
        /// 对象的简短说明
        /// </summary>
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        /// <summary>
        /// 对象的说明
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// 对象的标识符
        /// </summary>
        public string SettingID
        {
            get { return settingID; }
            set { settingID = value; }
        }
    }
}
