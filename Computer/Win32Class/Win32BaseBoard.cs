using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32BaseBoard : CIMCard
    {
        private string[] configOptions;
        private string product;
        /// <summary>
        /// 在版上转换和跳线的说明
        /// </summary>
        public string[] ConfigOptions
        {
            get { return configOptions; }
            set { configOptions = value; }
        }
        /// <summary>
        /// 厂家定义的局部号
        /// </summary>
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
    }
}
