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
        // 为事件的亚类.这个亚类是源细节
        public UInt16 Category
        {
            get { return category; }
            set { category = value; }
        }
        /// <summary>
        /// Translation of the subcategory. The translation is source-specific
        /// </summary>
        //  亚类的翻译,这个翻译是源细节
        public string CategoryString
        {
            get { return categoryString; }
            set { categoryString = value; }
        }
        /// <summary>
        /// Name of the computer that generated this event.
        /// </summary>
        //这事件产生的计算机的名字
        public  string ComputerName
        {
            get { return computerName; }
            set { computerName = value; }
        }
        /// <summary>
        /// List of the binary data that accompanied the report of the Windows NT event.
        /// </summary>
        //二进制的列表WINDOWS NT事件的伴奏报告
        public  byte[] Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        /// Value of the lower 16-bits of the EventIdentifier property.
        /// </summary>
        //验证属性的低16位的值
        public  UInt16 EventCode
        {
            get { return eventCode; }
            set { eventCode = value; }
        }
        /// <summary>
        /// 事件的标识符
        /// </summary>
        public UInt32 EventIdentifier
        {
            get { return eventIdentifier; }
            set { eventIdentifier = value; }
        }
        /// <summary>
        /// 事件类型
        /// </summary>
        public byte EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }
        /// <summary>
        /// List of the insertion strings that accompanied the report of the Windows NT event.
        /// </summary>
        //伴随WINDOWS NT 事件报告的插入字符串的列表
        public  string[] InsertionStrings
        {
            get { return insertionStrings; }
            set { insertionStrings = value; }
        }
        /// <summary>
        /// Name of Windows NT event log file
        /// </summary>
        //Windows NT事件逻辑文件名
        public  string Logfile
        {
            get { return logfile; }
            set { logfile = value; }
        }
        /// <summary>
        /// Event message as it appears in the Windows NT event log
        /// </summary>
        //发表在Windews NT 事件日志中的事件消息
        public  string Message
        {
            get { return message; }
            set { message = value; }
        }
        /// <summary>
        /// Identifies the event within the Windows NT event log file
        /// </summary>
        //Windows NT事件日志文件内部识别事件的号码
        public  UInt32 RecordNumber
        {
            get { return recordNumber; }
            set { recordNumber = value; }
        }
        /// <summary>
        /// Name of the source (application, service, driver, subsystem) that generated the entry.
        /// </summary>
        //(application, service, driver, subsystem)产生的入口的源的名字
        public  string SourceName
        {
            get { return sourceName; }
            set { sourceName = value; }
        }
        /// <summary>
        /// Source generated the event
        /// </summary>
        //事件产生来源
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
        /// 写到事件日志的时间
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
        /// 事件的类型
        /// </summary>
        public  string Type
        {
            get { return type; }
            set { type = value; }
        }
        /// <summary>
        /// User name of the logged-on user when the event occurred
        /// </summary>
        //事件出现的登陆者的登陆名
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
                    return "没有这个值";
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
                    return "没有这个值";
            }
        }

    }
}
