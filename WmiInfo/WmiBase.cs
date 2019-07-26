using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using Computer;
using System.Management;

namespace WmiInfo
{
    public abstract class WmiBase
    {
        protected WmiCommon wi;
        protected string wmiIPAddress;
        public WmiBase()
        {
            wi = new WmiCommon();
            wmiIPAddress = ".";
            wi.LinkName = wmiIPAddress;
        }
        public WmiBase(string ip, string username, string password)
        {
            wi = new WmiCommon();
            wmiIPAddress = ip;
            wi.LinkName = wmiIPAddress;
            wi.SystemName = username;
            wi.Password = password;
        }
        protected ManagementObjectCollection GetAllInfo(string wsql)
        {
            return wi.GetWSqlFromWMI(wsql);
        }
        private object GetObjectFromManagementObject(ManagementObject mo, string fieldname)
        {
            try
            {
                return mo[fieldname];
            }
            catch (Exception e)
            {
                System.Console.WriteLine(fieldname + e.Message);
                return null;
            }
        }
        protected T GetManagementObject<T>(ManagementObject mo, string fieldname)
        {
            object obj = GetObjectFromManagementObject(mo, fieldname);
            if (obj != null)
            {
                return (T)obj;
            }
            else
            {
                return default(T);
            }
        }
        protected abstract void FillFloppyDriveInfo();
    }
}
