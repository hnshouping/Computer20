using System.Management;
using System.Net;
using System;

namespace Computer
{
    /// <summary>
    /// WmiCommon ��ժҪ˵����
    /// </summary>
    public class WmiCommon
    {
        private string sysname;//�����û���
        private string password;//�û�����
        private string linkIP;//Ҫ���ӵ��û�IP

        private string scope;

        private ConnectionOptions co;
        private ManagementScope ms;
        private IPAddress[] ipadd;//������IP��ַ
        private IPHostEntry iphe;
        /// <summary>
        /// Ĭ�ϵĹ��캯��
        /// </summary>
        public WmiCommon()//�û���Ϊ�գ�����Ϊ�գ�IPΪ�գ���ȡ�ñ�����IP��ַ
        {
            this.sysname = "";
            this.password = "";
            this.linkIP = "";


            //iphe = Dns.GetHostByName(Dns.GetHostName());//�ѹ�ʱ
            iphe = Dns.GetHostEntry(Dns.GetHostName());
            ipadd = iphe.AddressList;

        }
        /// <summary>
        /// ���ӿͻ��˵ĺ��������û�пͻ�����Ϣ�����ӱ��ػ�
        /// </summary>
        private void Connect()
        {
            co = new ConnectionOptions();
            //���LINKIPΪ�գ�����Ϊ������ַ
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
        /// �õ����е�����
        /// </summary>
        /// <param name="wsql">WSQL���</param>
        /// <returns>����</returns>
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
        /// �õ�ManagementClass��in32classname
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
        /// �õ�Ҫ�õ���WMI������Ϣ
        /// </summary>
        /// <param name="wsql">WSql���</param>
        /// <returns>ManagementObjectCollection����</returns>
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
        /// ������
        /// </summary>
        public string SystemName
        {
            get { return this.sysname; }
            set { this.sysname = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string Password
        {
            set { this.password = value; }
        }
        /// <summary>
        /// IP��ַ
        /// </summary>
        public string LinkName
        {
            get { return this.linkIP; }
            set { this.linkIP = value; }
        }
    }
}
