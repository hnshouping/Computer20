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
        /// �ڰ���ת�������ߵ�˵��
        /// </summary>
        public string[] ConfigOptions
        {
            get { return configOptions; }
            set { configOptions = value; }
        }
        /// <summary>
        /// ���Ҷ���ľֲ���
        /// </summary>
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
    }
}
