using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMManagedSystemElement
    {
        private string caption;
        private string description;
        private DateTime installDate;
        private string cim_InstallDate;
        private string name;
        private string status;
        /// <summary>
        /// ����ļ�˵��
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
        /// ���󱻰�װ������ʱ��
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
        /// ����ǰ��״̬
        /// </summary>
        //"OK""Error""Degraded""Unknown""Pred Fail""Starting""Stopping""Service""Stressed""NonRecover""No Contact""Lost Comm"
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public CIMManagedSystemElement() { }
        

    }
}
