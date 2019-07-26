using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMLogicalElement
    {
        private string caption;
        private string description;
        private DateTime installDate;
        private string name;
        private string status;


        private string cim_InstallDate;
        /// <summary>
        /// ����ļ�˵��
        /// </summary>
        public string Caption 
        {
            get { return caption; }
            set { caption = value; }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// ����İ�װ����
        /// </summary>
        public DateTime InstallDate
        {
            get 
            {
                installDate = DmtfConverter.ToDateTime(cim_InstallDate);
                return installDate; 
            }
        }
        public string Cim_InstallDate
        {
            get { return cim_InstallDate; }
            set { cim_InstallDate = value; }
        }
        /// <summary>
        /// ��������Ʒ���
        /// </summary>
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// ����ĵ�ǰ״̬
        /// </summary>
        //"OK""Error""Degraded""Unknown""Pred Fail""Starting""Stopping""Service""Stressed""NonRecover""No Contact""Lost Comm"
        public string Status 
        {
            get { return status; }
            set { status = value; }
        }

    }
}
