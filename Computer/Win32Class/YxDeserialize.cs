using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{

    class YxDeserialize
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(GetWmiDateTimeByNetDateTime(DateTime.Now));
        }
        private static string GetWmiDateTimeByNetDateTime(DateTime dt)
        {
            DateTime a = DateTime.Now;
            string b = DmtfConverter.ToDmtfDateTime(a);
            return b;
        }
    }
}
