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
        /// 建立的一个类和子类的实例名
        /// </summary>
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// 如果真,这个服务是开始的
        /// </summary>
        public bool Started
        {
            get { return started; }
            set { started = value; }
        }
        /// <summary>
        /// 指出这个服务是否是自动始,有如下值:"Automatic""Manual"
        /// </summary>
        public string StartMode
        {
            get { return startMode; }
            set { startMode = value; }
        }
        /// <summary>
        /// Scoping系统的成立类名
        /// </summary>
        public string SystemCreationClassName
        {
            get { return systemCreationClassName; }
            set { systemCreationClassName = value; }
        }
        /// <summary>
        /// 主机服务的系统的名字
        /// </summary>
        public string SystemName
        {
            get { return systemName; }
            set { systemName = value; }
        }

    }
}
