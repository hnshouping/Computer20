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
        /// ����ļ��˵��
        /// </summary>
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        /// <summary>
        /// �����˵��
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// ����ı�ʶ��
        /// </summary>
        public string SettingID
        {
            get { return settingID; }
            set { settingID = value; }
        }
    }
}
