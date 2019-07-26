using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;

namespace WmiInfo.Counter
{
    public class PageFileUsageCounter
    {
        WmiPageFileUsage wp;
        Win32PageFileUsage pf;
        public PageFileUsageCounter()
        {
            wp = new WmiPageFileUsage();
            pf = wp.Win32PageFileUsages[0];
        }
        public PageFileUsageCounter(string ip, string username, string password)
        {
            wp = new WmiPageFileUsage(ip, username, password);
            pf = wp.Win32PageFileUsages[0];
        }
        private bool IsOne()
        {
            if (wp.Win32PageFileUsagesLength == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UInt32 AllocatedBaseSize
        {
            get 
            {
                if (IsOne())
                {
                    return pf.AllocatedBaseSize;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string Caption
        {
            get
            {
                if (IsOne())
                {
                    return pf.Caption;
                }
                else
                {
                    return "";
                }
            }
        }
        public UInt32 CurrentUsage
        {
            get 
            {
                if (IsOne())
                {
                    return pf.CurrentUsage;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string Description
        {
            get
            {
                if (IsOne())
                {
                    return pf.Description;
                }
                else
                {
                    return "";
                }
            }
        }
        public DateTime InstallDate
        {
            get
            {
                if (IsOne())
                {
                    return pf.InstallDate;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }
        public string Name
        {
            get
            {
                if (IsOne())
                {
                    return pf.Name;
                }
                else
                {
                    return "";
                }
            }
        }
        public UInt32 PeakUsage
        {
            get
            {
                if (IsOne())
                {
                    return pf.PeakUsage;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string Status
        {
            get
            {
                if (IsOne())
                {
                    return pf.Status;
                }
                else
                {
                    return "";
                }
            }
        }
        public bool TempPageFile
        {
            get
            {
                if (IsOne())
                {
                    return pf.TempPageFile;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
