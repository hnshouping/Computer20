using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMStatisticalInformation
    {
        private string caption;
        private string description;
        private string name;

        /// <summary>
        /// ͳ�����ݺ�ָ��ļ�˵��
        /// </summary>
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        /// <summary>
        /// ͳ�����ݺ�ָ���˵��
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// ͳ�����ݺ�ָ����֪�ı�ǩ
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
