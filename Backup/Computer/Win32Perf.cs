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
        /// Frequency_Object��������ÿ���ʱ��Ƶ��
        /// </summary>
        public UInt64 Frequency_Object
        {
            get { return frequency_Object; }
            set { frequency_Object = value; }
        }
        /// <summary>
        /// Frequency_PerfTime��������ÿ���ʱ��Ƶ��
        /// </summary>
        public UInt64 Frequency_PerfTime
        {
            get { return frequency_PerfTime; }
            set { frequency_PerfTime = value; }
        }
        /// <summary>
        /// Frequency_Sys100NS��������ÿ���ʱ��Ƶ��
        /// </summary>
        public UInt64 Frequency_Sys100NS
        {
            get { return frequency_Sys100NS; }
            set { frequency_Sys100NS = value; }
        }
        /// <summary>
        /// �������ʱ���
        /// </summary>
        public UInt64 Timestamp_Object
        {
            get { return timestamp_Object; }
            set { timestamp_Object = value; }
        }
        /// <summary>
        /// ʱ��������ܼ�����
        /// </summary>
        public UInt64 Timestamp_PerfTime
        {
            get { return timestamp_PerfTime; }
            set { timestamp_PerfTime = value; }
        }
        /// <summary>
        /// ��һ�ٸ�ʮ�ڷ�֮һ�뵥λ��ʱ���ֵ
        /// </summary>
        public UInt64 Timestamp_Sys100NS
        {
            get { return timestamp_Sys100NS; }
            set { timestamp_Sys100NS = value; }
        }
    }
}
