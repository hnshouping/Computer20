using System.Management;
using System.Net;
using System;

namespace Computer
{
    /// <summary>
    /// WmiCommon 的摘要说明。
    /// </summary>
    public class WmiCommon
    {
        private string sysname;//超级用户名
        private string password;//用户密码
        private string linkIP;//要联接的用户IP

        private string scope;

        private ConnectionOptions co;
        private ManagementScope ms;
        private IPAddress[] ipadd;//本机的IP地址
        private IPHostEntry iphe;
        /// <summary>
        /// 默认的构造函数
        /// </summary>
        public WmiCommon()//用户名为空，秘密为空，IP为空，并取得本机的IP地址
        {
            this.sysname = "";
            this.password = "";
            this.linkIP = "";


            //iphe = Dns.GetHostByName(Dns.GetHostName());//已过时
            iphe = Dns.GetHostEntry(Dns.GetHostName());
            ipadd = iphe.AddressList;

        }
        /// <summary>
        /// 联接客户端的函数，如果没有客户端信息就联接本地机
        /// </summary>
        private void Connect()
        {
            co = new ConnectionOptions();
            //如果LINKIP为空，或者为本机地址
            if (linkIP == "." || linkIP == "" || linkIP == "127.0.0.1" || linkIP == ipadd[0].ToString() || linkIP == null)
            {
                this.linkIP = ".";
            }
            else
            {
                if (sysname == "" || sysname == null)
                {
                    co.Username = "Administrator";
                }
                else
                {
                    co.Username = this.sysname;
                }
                co.Password = this.password;
                co.Authentication = AuthenticationLevel.PacketPrivacy;
                co.Impersonation = ImpersonationLevel.Impersonate;
                co.EnablePrivileges = true;
            }
            try
            {
                ms = new ManagementScope("\\\\" + this.linkIP + "\\root\\cimv2", co);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 得到表中的行数
        /// </summary>
        /// <param name="wsql">WSQL语句</param>
        /// <returns>行数</returns>
        public int GetInfoRowCount(string wsql)
        {
            try
            {
                return GetWSqlFromWMI(wsql).Count;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 得到ManagementClass从in32classname
        /// </summary>
        /// <param name="win32classname">win32classname</param>
        /// <returns>ManagementClass</returns>
        public ManagementClass GetManagementClass(string win32classname)
        {
            if (linkIP == "." || linkIP == "" || linkIP == "127.0.0.1" || linkIP == ipadd[0].ToString() || linkIP == null)
            {
                this.linkIP = ".";
            }
            scope = "\\\\" + this.linkIP + "\\root\\cimv2";
            ManagementScope s = new ManagementScope(scope);

            s.Options.Authentication = AuthenticationLevel.PacketPrivacy;
            s.Options.Impersonation = ImpersonationLevel.Impersonate;
            s.Options.EnablePrivileges = true;

            ManagementPath p = new ManagementPath(scope + ":" + win32classname);

            ObjectGetOptions o = new ObjectGetOptions(null, ManagementOptions.InfiniteTimeout, true);
            using (ManagementClass c = new ManagementClass(s, p, o))
            {
                return c;
            }

        }
        /// <summary>
        /// 得到要得到的WMI所有信息
        /// </summary>
        /// <param name="wsql">WSql语句</param>
        /// <returns>ManagementObjectCollection集合</returns>
        public ManagementObjectCollection GetWSqlFromWMI(string wsql)
        {
            Connect();
            if (ms.IsConnected)
            {

                ObjectQuery oq = new ObjectQuery(wsql);
                ManagementObjectSearcher mos = new ManagementObjectSearcher(ms, oq);
                ManagementObjectCollection queryCollection = mos.Get();

                return queryCollection;

            }
            else
            {
                try
                {
                    //					ms.Connect();
                    Connect();

                }
                catch (System.UnauthorizedAccessException error)
                {
                    throw error;
                }
                catch (Exception err)
                {
                    throw err;
                }

                ObjectQuery oq = new ObjectQuery(wsql);
                ManagementObjectSearcher mos = new ManagementObjectSearcher(ms, oq);

                ManagementObjectCollection queryCollection = mos.Get();
                //				System.Console.WriteLine("sdfdsfdsfaaaaaaaaaaa");
                return queryCollection;
            }
        }
        /// <summary>
        /// 机器名
        /// </summary>
        public string SystemName
        {
            get { return this.sysname; }
            set { this.sysname = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            set { this.password = value; }
        }
        /// <summary>
        /// IP地址
        /// </summary>
        public string LinkName
        {
            get { return this.linkIP; }
            set { this.linkIP = value; }
        }
    }
}
