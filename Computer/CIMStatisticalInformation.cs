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
        /// 统计数据和指标的简单说明
        /// </summary>
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        /// <summary>
        /// 统计数据和指标的说明
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// 统计数据和指标已知的标签
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
