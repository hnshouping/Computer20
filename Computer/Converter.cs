using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer
{
    public class DmtfConverter
    {
        public static string ToDmtfDateTime(DateTime dt)
        {
            return ManagementDateTimeConverter.ToDmtfDateTime(dt);
        }
        public static DateTime ToDateTime(string dmtfdt)
        {
            return ManagementDateTimeConverter.ToDateTime(dmtfdt);
        }
    }
}
