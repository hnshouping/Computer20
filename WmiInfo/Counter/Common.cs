using System;
using System.Collections.Generic;
using System.Text;

namespace WmiInfo.Counter
{

    public class Common
    {
        public static Decimal PERF_COUNTER_COUNTER(UInt32 newvalue, UInt32 oldvalue, UInt64 newtime, UInt64 oldtime, UInt64 basevalue)
        {
            UInt64 valuetemp = newvalue - oldvalue;
            UInt64 timetemp = newtime - oldtime;
            Decimal aa = (Decimal)valuetemp;
            Decimal temp = aa / timetemp / basevalue;

            return temp;
        }
        public static Decimal PERF_COUNTER_COUNTER(UInt64 newvalue, UInt64 oldvalue, UInt64 newtime, UInt64 oldtime, UInt64 basevalue)
        {
            UInt64 valuetemp = newvalue - oldvalue;
            UInt64 timetemp = newtime - oldtime;
            Decimal aa = (Decimal)valuetemp;
            Decimal temp = aa / timetemp / basevalue;

            return temp;
        }
        public static Decimal PERF_100NSEC_TIMER(ulong newvalue, ulong oldvalue, ulong newtime, ulong oldtime)
        {
            Decimal temp = (Decimal)(newvalue - oldvalue);
            return temp / (newtime - oldtime) * 100;
        }
        public static Decimal PERF_100NSEC_TIMER_INV(ulong newvalue, ulong oldvalue, ulong newtime, ulong oldtime)
        {
            UInt64 a = newvalue - oldvalue;
            Decimal temp = (Decimal)a;
            return (1 - (temp / (newtime - oldtime))) * 100;
        }
        public static Decimal PERF_RAW_FRACTION(uint value1, ulong basevalue)
        {
            Decimal temp = (Decimal)value1;
            return temp / basevalue * 100;
        }
    }
}
