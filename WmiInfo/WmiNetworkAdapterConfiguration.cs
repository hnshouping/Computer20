using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Computer.Win32Class;

namespace WmiInfo
{
    public class WmiNetworkAdapterConfiguration : WmiBase
    {
        private List<Win32NetworkAdapterConfiguration> ps;
        private List<Win32NetworkAdapterConfiguration> pstrue;

        private string WSql = "SELECT * FROM  Win32_NetworkAdapterConfiguration";

        /// <summary>
        /// 默认的构造函数是本机的
        /// </summary>
        public WmiNetworkAdapterConfiguration()
            : base()
        {
            ps = new List<Win32NetworkAdapterConfiguration>();
            pstrue = new List<Win32NetworkAdapterConfiguration>();
            FillFloppyDriveInfo();

        }
        /// <summary>
        /// 已知IP，用户名，密码的构造函数
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        public WmiNetworkAdapterConfiguration(string ip, string username, string password)
            : base(ip, username, password)
        {
            ps = new List<Win32NetworkAdapterConfiguration>();
            pstrue = new List<Win32NetworkAdapterConfiguration>();
            FillFloppyDriveInfo();
        }
        protected override void FillFloppyDriveInfo()
        {
            ManagementObjectCollection moc = this.GetAllInfo(this.WSql);
            foreach (ManagementObject mo in moc)
            {
                Win32NetworkAdapterConfiguration csp = new Win32NetworkAdapterConfiguration();
                if (mo != null)
                {
                    csp.ArpAlwaysSourceRoute = GetManagementObject<bool>(mo, "ArpAlwaysSourceRoute");
                    csp.ArpUseEtherSNAP = GetManagementObject<bool>(mo, "ArpUseEtherSNAP");
                    csp.Caption = GetManagementObject<string>(mo, "Caption");
                    csp.DatabasePath = GetManagementObject<string>(mo, "DatabasePath");
                    csp.DeadGWDetectEnabled = GetManagementObject<bool>(mo, "DeadGWDetectEnabled");
                    csp.DefaultIPGateway = GetManagementObject<string[]>(mo, "DefaultIPGateway");
                    csp.DefaultTOS = GetManagementObject<byte>(mo, "DefaultTOS");
                    csp.DefaultTTL = GetManagementObject<byte>(mo, "DefaultTTL");
                    csp.Description = GetManagementObject<string>(mo, "Description");
                    csp.DHCPEnabled = GetManagementObject<bool>(mo, "DHCPEnabled");
                    csp.Cim_DHCPLeaseExpires = GetManagementObject<string>(mo, "DHCPLeaseExpires");
                    csp.Cim_DHCPLeaseObtained = GetManagementObject<string>(mo, "DHCPLeaseObtained");
                    csp.DHCPServer = GetManagementObject<string>(mo, "DHCPServer");
                    csp.DNSDomain = GetManagementObject<string>(mo, "DNSDomain");
                    csp.DNSDomainSuffixSearchOrder = GetManagementObject<string[]>(mo, "DNSDomainSuffixSearchOrder");
                    csp.DNSEnabledForWINSResolution = GetManagementObject<bool>(mo, "DNSEnabledForWINSResolution");
                    csp.DNSHostName = GetManagementObject<string>(mo, "DNSHostName");
                    csp.DNSServerSearchOrder = GetManagementObject<string[]>(mo, "DNSServerSearchOrder");
                    csp.DomainDNSRegistrationEnabled = GetManagementObject<bool>(mo, "DomainDNSRegistrationEnabled");
                    csp.ForwardBufferMemory = GetManagementObject<uint>(mo, "ForwardBufferMemory");
                    csp.FullDNSRegistrationEnabled = GetManagementObject<bool>(mo, "FullDNSRegistrationEnabled");
                    csp.GatewayCostMetric = GetManagementObject<ushort[]>(mo, "GatewayCostMetric");
                    csp.IGMPLevel = GetManagementObject<byte>(mo, "IGMPLevel");
                    csp.Index = GetManagementObject<uint>(mo, "Index");
                    csp.InterfaceIndex = GetManagementObject<uint>(mo, "InterfaceIndex");
                    csp.IPAddress = GetManagementObject<string[]>(mo, "IPAddress");
                    csp.IPConnectionMetric = GetManagementObject<uint>(mo, "IPConnectionMetric");
                    csp.IPEnabled = GetManagementObject<bool>(mo, "IPEnabled");
                    csp.IPFilterSecurityEnabled = GetManagementObject<bool>(mo, "IPFilterSecurityEnabled");
                    csp.IPPortSecurityEnabled = GetManagementObject<bool>(mo, "IPPortSecurityEnabled");
                    csp.IPSecPermitIPProtocols = GetManagementObject<string[]>(mo, "IPSecPermitIPProtocols");
                    csp.IPSecPermitTCPPorts = GetManagementObject<string[]>(mo, "IPSecPermitTCPPorts");
                    csp.IPSecPermitUDPPorts = GetManagementObject<string[]>(mo, "IPSecPermitUDPPorts");
                    csp.IPSubnet = GetManagementObject<string[]>(mo, "IPSubnet");
                    csp.IPUseZeroBroadcast = GetManagementObject<bool>(mo, "IPUseZeroBroadcast");
                    csp.IPXAddress = GetManagementObject<string>(mo, "IPXAddress");
                    csp.IPXEnabled = GetManagementObject<bool>(mo, "IPXEnabled");
                    csp.IPXFrameType = GetManagementObject<uint[]>(mo, "IPXFrameType");
                    csp.IPXMediaType = GetManagementObject<uint>(mo, "IPXMediaType");
                    csp.IPXNetworkNumber = GetManagementObject<string[]>(mo, "IPXNetworkNumber");
                    csp.IPXVirtualNetNumber = GetManagementObject<string>(mo, "IPXVirtualNetNumber");
                    csp.KeepAliveInterval = GetManagementObject<uint>(mo, "KeepAliveInterval");
                    csp.KeepAliveTime = GetManagementObject<uint>(mo, "KeepAliveTime");
                    csp.MACAddress = GetManagementObject<string>(mo, "MACAddress");
                    csp.MTU = GetManagementObject<uint>(mo, "MTU");
                    csp.NumForwardPackets = GetManagementObject<uint>(mo, "NumForwardPackets");
                    csp.PMTUBHDetectEnabled = GetManagementObject<bool>(mo, "PMTUBHDetectEnabled");
                    csp.PMTUDiscoveryEnabled = GetManagementObject<bool>(mo, "PMTUDiscoveryEnabled");
                    csp.ServiceName = GetManagementObject<string>(mo, "ServiceName");
                    csp.SettingID = GetManagementObject<string>(mo, "SettingID");
                    csp.TcpipNetbiosOptions = GetManagementObject<uint>(mo, "TcpipNetbiosOptions");
                    csp.TcpMaxConnectRetransmissions = GetManagementObject<uint>(mo, "TcpMaxConnectRetransmissions");
                    csp.TcpMaxDataRetransmissions = GetManagementObject<uint>(mo, "TcpMaxDataRetransmissions");
                    csp.TcpNumConnections = GetManagementObject<uint>(mo, "TcpNumConnections");
                    csp.TcpUseRFC1122UrgentPointer = GetManagementObject<bool>(mo, "TcpUseRFC1122UrgentPointer");
                    csp.TcpWindowSize = GetManagementObject<ushort>(mo, "TcpWindowSize");
                    csp.WINSEnableLMHostsLookup = GetManagementObject<bool>(mo, "WINSEnableLMHostsLookup");
                    csp.WINSHostLookupFile = GetManagementObject<string>(mo, "WINSHostLookupFile");
                    csp.WINSPrimaryServer = GetManagementObject<string>(mo, "WINSPrimaryServer");
                    csp.WINSScopeID = GetManagementObject<string>(mo, "WINSScopeID");
                    csp.WINSSecondaryServer = GetManagementObject<string>(mo, "WINSSecondaryServer");

                    if (csp.IPEnabled)
                    {
                        pstrue.Add(csp);
                    }
                    ps.Add(csp);
                }
            }
            moc.Dispose();
        }
        public List<Win32NetworkAdapterConfiguration> Win32NetworkAdapterConfigurations
        {
            get { return ps; }
        }
        public int Win32NetworkAdapterConfigurationsLength
        {
            get { return ps.Count; }
        }
        public List<Win32NetworkAdapterConfiguration> Win32NetworkAdapter
        {
            get { return pstrue; }
        }
        public int Win32NetworkAdapterLength
        {
            get { return pstrue.Count; }
        }
    }
}
