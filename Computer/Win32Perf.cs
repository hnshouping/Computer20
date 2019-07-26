using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class Win32Perf : CIMStatisticalInformation
    {
        private UInt64 frequency_Object;
        private UInt64 frequency_PerfTime;
        private UInt64 frequency_Sys100NS;
        private UInt64 timestamp_Object;
        private UInt64 timestamp_PerfTime;
        private UInt64 timestamp_Sys100NS;

        /// <summary>
        /// Frequency_Object的属性是每秒的时钟频率
        /// </summary>
        public UInt64 Frequency_Object
        {
            get { return frequency_Object; }
            set { frequency_Object = value; }
        }
        /// <summary>
        /// Frequency_PerfTime的属性是每秒的时钟频率
        /// </summary>
        public UInt64 Frequency_PerfTime
        {
            get { return frequency_PerfTime; }
            set { frequency_PerfTime = value; }
        }
        /// <summary>
        /// Frequency_Sys100NS的属性是每秒的时钟频率
        /// </summary>
        public UInt64 Frequency_Sys100NS
        {
            get { return frequency_Sys100NS; }
            set { frequency_Sys100NS = value; }
        }
        /// <summary>
        /// 对象定义的时间戳
        /// </summary>
        public UInt64 Timestamp_Object
        {
            get { return timestamp_Object; }
            set { timestamp_Object = value; }
        }
        /// <summary>
        /// 时间戳高性能计数器
        /// </summary>
        public UInt64 Timestamp_PerfTime
        {
            get { return timestamp_PerfTime; }
            set { timestamp_PerfTime = value; }
        }
        /// <summary>
        /// 在一百个十亿分之一秒单位的时间戳值
        /// </summary>
        public UInt64 Timestamp_Sys100NS
        {
            get { return timestamp_Sys100NS; }
            set { timestamp_Sys100NS = value; }
        }
    }
}
