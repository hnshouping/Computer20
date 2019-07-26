using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMProcess : CIMLogicalElement
    {
        private string creationClassName;
        private DateTime creationDate;
        private string cim_CreationDate;
        private string cSCreationClassName;
        private string cSName;
        private UInt16 executionState;
        private string handle;
        private UInt64 kernelModeTime;
        private string oSCreationClassName;
        private string oSName;
        private UInt32 priority;
        private DateTime terminationDate;
        private string cim_TerminationDate;
        private UInt64 userModeTime;
        private UInt64 workingSetSize;


        private Dictionary<ushort, string> dictionExecutionState;

        /// <summary>
        /// һ��ʵ���������������ʹ�õ�����
        /// </summary>
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }
        /// <summary>
        /// ���̿�ʼ��ʱ��
        /// </summary>
        public DateTime CreationDate
        {
            get 
            {
                creationDate = DmtfConverter.ToDateTime(cim_CreationDate);
                return creationDate;
            }
        }
        public string Cim_CreationDate
        {
            get { return cim_CreationDate; }
            set { cim_CreationDate = value; }
        }
        /// <summary>
        /// Scoping�����ϵͳ����������
        /// </summary>
        public string CSCreationClassName
        {
            get { return cSCreationClassName; }
            set { cSCreationClassName = value; }
        }
        /// <summary>
        ///Scoping�����ϵͳ�� 
        /// </summary>
        public string CSName
        {
            get { return cSName; }
            set { cSName = value; }
        }
        /// <summary>
        /// ��ǰ���̲���״̬
        /// </summary>
        public UInt16 ExecutionState
        {
            get { return executionState; }
            set { executionState = value; }
        }
        /// <summary>
        /// ʶ����̵�����
        /// </summary>
        public string Handle
        {
            get { return handle; }
            set { handle = value; }
        }
        /// <summary>
        /// ��һ�����ڽ����ں˵Ĵ���
        /// </summary>
        public UInt64 KernelModeTime
        {
            get { return kernelModeTime; }
            set { kernelModeTime = value; }
        }
        /// <summary>
        /// Scoping����ϵͳ������
        /// </summary>
        public string OSCreationClassName
        {
            get { return oSCreationClassName; }
            set { oSCreationClassName = value; }
        }
        /// <summary>
        /// Scoping����ϵͳ��
        /// </summary>
        public string OSName
        {
            get { return oSName; }
            set { oSName = value; }
        }
        /// <summary>
        /// ִ�н������ش�ʹ�õı�־
        /// </summary>
        public UInt32 Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        /// <summary>
        /// ����ֹͣ����ֹ�Ĵ���
        /// </summary>
        public DateTime TerminationDate
        {
            get 
            {
                terminationDate= DmtfConverter.ToDateTime(cim_TerminationDate);
                return terminationDate; 
            }
        }
        public string Cim_TerminationDate
        {
            get { return cim_TerminationDate; }
            set { cim_TerminationDate = value; }
        }
        /// <summary>
        /// �ں����ڽ���ʹ��ģʽ�Ĵ���
        /// </summary>
        public UInt64 UserModeTime
        {
            get { return userModeTime; }
            set { userModeTime = value; }
        }
        /// <summary>
        ///����ϵͳ�����ڼ�����Ľ��̵�ʹ���ڼ����ֽ���
        /// </summary>        
        public UInt64 WorkingSetSize
        {
            get { return workingSetSize; }
            set { workingSetSize = value; }
        }
        public Dictionary<ushort, string> YxDictionExecutionState
        {
            get
            {
                GetParser();
                return dictionExecutionState;
            }
        }
        /// <summary>
        /// �õ�ExecutionState����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetExecutionStatebyInt(ushort key)
        {
            string dic;
            bool a = YxDictionExecutionState.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        private void GetParser()
        {
            dictionExecutionState = new Dictionary<ushort, string>();
            dictionExecutionState.Add(0, "Unknown");
            dictionExecutionState.Add(1, "Other");
            dictionExecutionState.Add(2, "Ready");
            dictionExecutionState.Add(3, "Running");
            dictionExecutionState.Add(4, "Blocked");
            dictionExecutionState.Add(5, "Suspended��blocked");
            dictionExecutionState.Add(6, "Suspended��ready");
            dictionExecutionState.Add(7, "Terminated");
            dictionExecutionState.Add(8, "Stopped");
            dictionExecutionState.Add(9, "Growing");
        }
    }
}
