using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public abstract class CIMService : CIMLogicalElement
    {
        private string creationClassName;
        private bool started;
        private string startMode;
        private string systemCreationClassName;
        private string systemName;

        /// <summary>
        /// ������һ����������ʵ����
        /// </summary>
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// �����,��������ǿ�ʼ��
        /// </summary>
        public bool Started
        {
            get { return started; }
            set { started = value; }
        }
        /// <summary>
        /// ָ����������Ƿ����Զ�ʼ,������ֵ:"Automatic""Manual"
        /// </summary>
        public string StartMode
        {
            get { return startMode; }
            set { startMode = value; }
        }
        /// <summary>
        /// Scopingϵͳ�ĳ�������
        /// </summary>
        public string SystemCreationClassName
        {
            get { return systemCreationClassName; }
            set { systemCreationClassName = value; }
        }
        /// <summary>
        /// ���������ϵͳ������
        /// </summary>
        public string SystemName
        {
            get { return systemName; }
            set { systemName = value; }
        }

    }
}
