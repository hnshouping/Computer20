using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32NTLogEvent
    {
        private UInt16 category;
        private string categoryString;
        private string computerName;
        private byte[] data;
        private UInt16 eventCode;
        private UInt32 eventIdentifier;
        private byte eventType;
        private string[] insertionStrings;
        private string logfile;
        private string message;
        private UInt32 recordNumber;
        private string sourceName;
        private DateTime timeGenerated;
        private string cim_TimeGenerated;
        private DateTime timeWritten;
        private string cim_TimeWritten;
        private string type;
        private string user;

        /// <summary>
        /// Subcategory for this event. This subcategory is source-specific
        /// </summary>
        // Ϊ�¼�������.���������Դϸ��
        public UInt16 Category
        {
            get { return category; }
            set { category = value; }
        }
        /// <summary>
        /// Translation of the subcategory. The translation is source-specific
        /// </summary>
        //  ����ķ���,���������Դϸ��
        public string CategoryString
        {
            get { return categoryString; }
            set { categoryString = value; }
        }
        /// <summary>
        /// Name of the computer that generated this event.
        /// </summary>
        //���¼������ļ����������
        public  string ComputerName
        {
            get { return computerName; }
            set { computerName = value; }
        }
        /// <summary>
        /// List of the binary data that accompanied the report of the Windows NT event.
        /// </summary>
        //�����Ƶ��б�WINDOWS NT�¼��İ��౨��
        public  byte[] Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        /// Value of the lower 16-bits of the EventIdentifier property.
        /// </summary>
        //��֤���Եĵ�16λ��ֵ
        public  UInt16 EventCode
        {
            get { return eventCode; }
            set { eventCode = value; }
        }
        /// <summary>
        /// �¼��ı�ʶ��
        /// </summary>
        public UInt32 EventIdentifier
        {
            get { return eventIdentifier; }
            set { eventIdentifier = value; }
        }
        /// <summary>
        /// �¼�����
        /// </summary>
        public byte EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }
        /// <summary>
        /// List of the insertion strings that accompanied the report of the Windows NT event.
        /// </summary>
        //����WINDOWS NT �¼�����Ĳ����ַ������б�
        public  string[] InsertionStrings
        {
            get { return insertionStrings; }
            set { insertionStrings = value; }
        }
        /// <summary>
        /// Name of Windows NT event log file
        /// </summary>
        //Windows NT�¼��߼��ļ���
        public  string Logfile
        {
            get { return logfile; }
            set { logfile = value; }
        }
        /// <summary>
        /// Event message as it appears in the Windows NT event log
        /// </summary>
        //������Windews NT �¼���־�е��¼���Ϣ
        public  string Message
        {
            get { return message; }
            set { message = value; }
        }
        /// <summary>
        /// Identifies the event within the Windows NT event log file
        /// </summary>
        //Windows NT�¼���־�ļ��ڲ�ʶ���¼��ĺ���
        public  UInt32 RecordNumber
        {
            get { return recordNumber; }
            set { recordNumber = value; }
        }
        /// <summary>
        /// Name of the source (application, service, driver, subsystem) that generated the entry.
        /// </summary>
        //(application, service, driver, subsystem)��������ڵ�Դ������
        public  string SourceName
        {
            get { return sourceName; }
            set { sourceName = value; }
        }
        /// <summary>
        /// Source generated the event
        /// </summary>
        //�¼�������Դ
        public  DateTime TimeGenerated
        {
            get 
            {
                timeGenerated = DmtfConverter.ToDateTime(cim_TimeGenerated);
                return timeGenerated; 
            }
        }
        public string Cim_TimeGenerated
        {
            get { return cim_TimeGenerated; }
            set { cim_TimeGenerated = value; }
        }
        /// <summary>
        /// д���¼���־��ʱ��
        /// </summary>
        public  DateTime TimeWritten
        {
            get 
            {
                timeWritten = DmtfConverter.ToDateTime(cim_TimeWritten);
                return timeWritten; 
            }
        }
        public string Cim_TimeWritten
        {
            get { return cim_TimeWritten; }
            set { cim_TimeGenerated = value; }
        }
        /// <summary>
        /// �¼�������
        /// </summary>
        public  string Type
        {
            get { return type; }
            set { type = value; }
        }
        /// <summary>
        /// User name of the logged-on user when the event occurred
        /// </summary>
        //�¼����ֵĵ�½�ߵĵ�½��
        public  string User
        {
            get { return user; }
            set { user = value; }
        }

        public string GetDictionEventTypebyInt(byte value)
        {
            switch (value)
            {
                case 1:
                    return "Error";
                case 2:
                    return "Warning";
                case 3:
                    return "Information";
                case 4:
                    return "Security_audit_success";
                case 5:
                    return "Security_audit_failure";
                default:
                    return "û�����ֵ";
            }
        }
        public string GetDictionTypebyInt(byte value)
        {
            switch (value)
            {
                case 1:
                    return "Error";
                case 2:
                    return "Warning";
                case 3:
                    return "Information";
                case 4:
                    return "Security_audit_success";
                case 5:
                    return "Security_audit_failure";
                default:
                    return "û�����ֵ";
            }
        }

    }
}
