using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{
    public class Win32Group : Win32Account
    {
        private WmiCommon wmi;
        public Win32Group(WmiCommon wami)
        {
            wmi = wami;
        }
        public Win32Group()
        {
        }

        public WmiCommon Wmi
        {
            get { return wmi; }
            set { wmi = value; }
        }
        public uint Rename(string Name)
        {
            if (wmi != null)
            {
                ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_Group where Name='" + Name + "'" + " and Domain='" + Domain + "'");

                uint a = 0;
                System.Console.WriteLine();
                foreach (ManagementObject mo in moc)
                {
                    a = (uint)mo.InvokeMethod("Rename", new object[] { Name });
                }

                return a;
            }
            else
            {
                throw new Exception("Wmi没有联接,为null");
            }
        }
        public override string ToString()
        {
            return Domain + "-" + Name;
        }
        public string HintByReturnValue(uint hint)
        {
            switch (hint)
            {
                case 0:
                    return "Success.";
                case 1:
                    return "Instance not found.";
                case 2:
                    return "Instance required.";
                case 3:
                    return "Invalid parameter.";
                case 4:
                    return "Group not found.";
                case 5:
                    return "Domain no found.";
                case 6:
                    return "Operation is allowed only on the primary domain controller.";
                case 7:
                    return "Operation not allowed on special groups: user, admin, local or guest.";
                case 8:
                    return "Other API error.";
                default:
                    return "Internal error.";
            }
        }
    }
}
