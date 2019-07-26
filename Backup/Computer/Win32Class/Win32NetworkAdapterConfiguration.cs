using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace Computer.Win32Class
{
    public class Win32NetworkAdapterConfiguration : CIMSetting
    {
        private bool arpAlwaysSourceRoute;
        private bool arpUseEtherSNAP;
        private string databasePath;
        private bool deadGWDetectEnabled;
        private string[] defaultIPGateway;
        private byte defaultTOS;
        private byte defaultTTL;
        private bool dHCPEnabled;
        private DateTime dHCPLeaseExpires;
        private string cim_DHCPLeaseExpires;
        private DateTime dHCPLeaseObtained;
        private string cim_DHCPLeaseObtained;
        private string dHCPServer;
        private string dNSDomain;
        private string[] dNSDomainSuffixSearchOrder;
        private bool dNSEnabledForWINSResolution;
        private string dNSHostName;
        private string[] dNSServerSearchOrder;
        private bool domainDNSRegistrationEnabled;
        private UInt32 forwardBufferMemory;
        private bool fullDNSRegistrationEnabled;
        private UInt16[] gatewayCostMetric;
        private byte iGMPLevel;
        private UInt32 index;
        private UInt32 interfaceIndex;
        private string[] iPAddress;
        private UInt32 iPConnectionMetric;
        private bool iPEnabled;
        private bool iPFilterSecurityEnabled;
        private bool iPPortSecurityEnabled;
        private string[] iPSecPermitIPProtocols;
        private string[] iPSecPermitTCPPorts;
        private string[] iPSecPermitUDPPorts;
        private string[] iPSubnet;
        private bool iPUseZeroBroadcast;
        private string iPXAddress;
        private bool iPXEnabled;
        private UInt32[] iPXFrameType;
        private UInt32 iPXMediaType;
        private string[] iPXNetworkNumber;
        private string iPXVirtualNetNumber;
        private UInt32 keepAliveInterval;
        private UInt32 keepAliveTime;
        private string mACAddress;
        private UInt32 mTU;
        private UInt32 numForwardPackets;
        private bool pMTUBHDetectEnabled;
        private bool pMTUDiscoveryEnabled;
        private string serviceName;
        private UInt32 tcpipNetbiosOptions;
        private UInt32 tcpMaxConnectRetransmissions;
        private UInt32 tcpMaxDataRetransmissions;
        private UInt32 tcpNumConnections;
        private bool tcpUseRFC1122UrgentPointer;
        private UInt16 tcpWindowSize;
        private bool wINSEnableLMHostsLookup;
        private string wINSHostLookupFile;
        private string wINSPrimaryServer;
        private string wINSScopeID;
        private string wINSSecondaryServer;


        private Dictionary<byte, string> dictionIGMPLevel;
        private Dictionary<uint, string> dictionIPXFrameType;
        private Dictionary<uint, string> dictionIPXMediaType;


        private WmiCommon wmi;


        public Win32NetworkAdapterConfiguration()
        {
            wmi = new WmiCommon();
        }

        /// <summary>
        /// If TRUE, TCP/IP transmits Address Resolution Protocol (ARP) queries with source routing enabled on Token Ring networks
        /// </summary>
        //  ����,ICP/IP����ARPѯ�����ڽ��ƻ�·�ϵ�Դ·��.Ĭ��,��
        public  bool ArpAlwaysSourceRoute
        {
            get { return arpAlwaysSourceRoute; }
            set { arpAlwaysSourceRoute = value; }
        }
        /// <summary>
        ///If TRUE, Ethernet packets follow the IEEE 802.3 Sub-Network Access Protocol (SNAP) encoding 
        /// </summary>
        // �����,��̫��������IEEE 802.3 SNMP����
        public  bool ArpUseEtherSNAP
        {
            get { return arpUseEtherSNAP; }
            set { arpUseEtherSNAP = value; }
        }
        /// <summary>
        /// Valid Windows file path to standard Internet database files (HOSTS, LMHOSTS, NETWORKS, PROTOCOLS). 
        /// </summary>
        //  ��Ч��Windows�ļ�·��(HOSTS, LMHOSTS, NETWORKS, PROTOCOLS)
        public  string DatabasePath        
        {
            get { return databasePath; }
            set { databasePath = value; }
        }
        /// <summary>
        /// If TRUE, dead gateway detection occurs. 
        /// </summary>
        //  �����,̽�ⷢ�־�������
        public  bool DeadGWDetectEnabled
        {
            get { return deadGWDetectEnabled; }
            set { deadGWDetectEnabled = value; }
        }
        /// <summary>
        /// Array of IP addresses of default gateways that the computer system uses.
        /// </summary>
        //  �����ϵͳ��Ĭ�����ص�IP��ַ����
        public  string[] DefaultIPGateway
        {
            get { return defaultIPGateway; }
            set { defaultIPGateway = value; }
        }
        /// <summary>
        /// Default Type Of Service (TOS) value set in the header of outgoing IP packets.
        /// </summary>
        //  ����Ĭ�ϵķ���������(TOS)ֵ��IP������ı�����
        public  byte DefaultTOS
        {
            get { return defaultTOS; }
            set { defaultTOS = value; }
        }
        /// <summary>
        /// Default Time To Live (TTL) value set in the header of outgoing IP packets
        /// </summary>
        //  ����Ĭ�ϵ��������(TTL)ֵ��IP������ı�����
        public  byte DefaultTTL
        {
            get { return defaultTTL; }
            set { defaultTTL = value; }
        }
        /// <summary>
        /// If TRUE, the dynamic host configuration protocol (DHCP) server automatically assigns an IP address to the computer system when establishing a network connection.
        /// </summary>
        //����,������һ����������ʱ(DHCP)�����Զ�����IP��ַ
        public  bool DHCPEnabled
        {
            get { return dHCPEnabled; }
            set { dHCPEnabled = value; }
        }
        /// <summary>
        /// Expiration date and time for a leased IP address that was assigned to the computer by the dynamic host configuration protocol (DHCP) server.
        /// </summary>
        // ͨ��(DHCP)����������,���IP��ַ���ڵ�����ʱ�� 
        public  DateTime DHCPLeaseExpires
        {
            get 
            {
                dHCPLeaseExpires = DmtfConverter.ToDateTime(cim_DHCPLeaseExpires); 
                return dHCPLeaseExpires; 
            }
        }
        public string Cim_DHCPLeaseExpires
        {
            get { return cim_DHCPLeaseExpires; }
            set { cim_DHCPLeaseExpires = value; }
        }
        /// <summary>
        /// Date and time the lease was obtained for the IP address assigned to the computer by the dynamic host configuration protocol (DHCP) server
        /// </summary>
        //  ͨ��(DHCP)����������,���IP��ַ���ڵ�����ʱ�� 
        public  DateTime DHCPLeaseObtained
        {
            get 
            {
                dHCPLeaseObtained = DmtfConverter.ToDateTime(cim_DHCPLeaseObtained);
                return dHCPLeaseObtained; 
            }
        }
        public string Cim_DHCPLeaseObtained
        {
            get { return cim_DHCPLeaseObtained; }
            set { cim_DHCPLeaseObtained = value; }
        }
        /// <summary>
        /// IP address of the dynamic host configuration protocol (DHCP) server
        /// </summary>
        //  DHCP�����IP��ַ
        public  string DHCPServer
        {
            get { return dHCPServer; }
            set { dHCPServer = value; }
        }
        /// <summary>
        /// Organization name followed by a period and an extension that indicates the type of organization, such as microsoft.com. Example: "microsoft.com"
        /// </summary>
        //  DNS����չ�� ��:microsoft.com
        public  string DNSDomain
        {
            get { return dNSDomain; }
            set { dNSDomain = value; }
        }
        /// <summary>
        ///  Array of DNS domain suffixes to be appended to the end of host names during name resolution
        /// </summary>
        //  ���ӵ���������DNS��׺����
        public  string[] DNSDomainSuffixSearchOrder
        {
            get { return dNSDomainSuffixSearchOrder; }
            set { dNSDomainSuffixSearchOrder = value; }
        }
        /// <summary>
        /// If TRUE, the Domain Name System (DNS) is enabled for name resolution over Windows Internet Naming Service (WINS) resolution.
        /// </summary>
        //  ����,��DNS��Խ��WINS����Ϊһ��������
        public  bool DNSEnabledForWINSResolution
        {
            get { return dNSEnabledForWINSResolution; }
            set { dNSEnabledForWINSResolution = value; }
        }
        /// <summary>
        /// Host name used to identify the local computer for authentication by some utilities
        /// </summary>
        //  ʹ��Ϊʶ�𱾻���������Ϊ��ͨ��һЩ��Ч��֤�� Example: "corpdns"
        public  string DNSHostName
        {
            get { return dNSHostName; }
            set { dNSHostName = value; }
        }
        /// <summary>
        /// Array of server IP addresses to be used in querying for DNS servers
        /// </summary>
        //  ѯ��DNS������ʹ�õ�IP��ַ����
        public  string[] DNSServerSearchOrder
        {
            get { return dNSServerSearchOrder; }
            set { dNSServerSearchOrder = value; }
        }
        /// <summary>
        /// If TRUE, the IP addresses for this connection are registered in DNS under the domain name of this connection in addition to being registered under the computer's full DNS name
        /// </summary>
        //  ����,��IP��ַΪ����һ��ע���DNS
        public  bool DomainDNSRegistrationEnabled
        {
            get { return domainDNSRegistrationEnabled; }
            set { domainDNSRegistrationEnabled = value; }
        }
        /// <summary>
        /// �ڴ�������·�ɰ������ϵ�IP�����ݵ��ڼ�
        /// </summary>
        public  UInt32 ForwardBufferMemory
        {
            get { return forwardBufferMemory; }
            set { forwardBufferMemory = value; }
        }
        /// <summary>
        /// If TRUE, the IP addresses for this connection are registered in DNS under the computer's full DNS name
        /// </summary>
        //  ����,Ϊ������һ����ע��ļ������ȫDNS���µ�IP��ַ
        public  bool FullDNSRegistrationEnabled
        {
            get { return fullDNSRegistrationEnabled; }
            set { fullDNSRegistrationEnabled = value; }
        }
        /// <summary>
        /// Array of integer cost metric values (ranging from 1 to 9999) to be used in calculating the fastest, most reliable, or least expensive routes.
        /// </summary>
        //  ��(1-9999������)���,����С���ѵ�·������������
        public  UInt16[] GatewayCostMetric
        {
            get { return gatewayCostMetric; }
            set { gatewayCostMetric = value; }
        }
        /// <summary>
        /// Extent to which the system supports IP multicast and participates in the Internet Group Management Protocol
        /// </summary>
        //��Internet������Э����ϵͳ֧��IP��㴫�ͺͲ�д������
        public  byte IGMPLevel
        {
            get { return iGMPLevel; }
            set { iGMPLevel = value; }
        }
        /// <summary>
        /// Index number of the Windows network adapter configuration
        /// </summary>
        //  �������õ�������
        public  UInt32 Index
        {
            get { return index; }
            set { index = value; }
        }
        /// <summary>
        /// Index value that uniquely identifies a local network interface
        /// </summary>
        //  ��������ӿ�Ψһʶ�������ֵ
        public  UInt32 InterfaceIndex
        {
            get { return interfaceIndex; }
            set { interfaceIndex = value; }
        }
        /// <summary>
        /// Array of all of the IP addresses associated with the current network adapter
        /// </summary>
        //  ���е�ǰ��������IP��ַ����
        public  string[] IPAddress
        {
            get { return iPAddress; }
            set { iPAddress = value; }
        }
        /// <summary>
        /// Cost of using the configured routes for the IP bound adapter and is the weighted value for those routes in the IP routing table
        /// </summary>
        //  ��IP������·��·�ߵ�IP�����������������ĳɱ���.
        public  UInt32 IPConnectionMetric
        {
            get { return iPConnectionMetric; }
            set { iPConnectionMetric = value; }
        }
        /// <summary>
        /// If TRUE, TCP/IP is bound and enabled on this network adapter
        /// </summary>
        //  ����,TCP/IP�ǿ����ͻ��
        public  bool IPEnabled
        {
            get { return iPEnabled; }
            set { iPEnabled = value; }
        }
        /// <summary>
        /// If TRUE, IP port security is enabled globally across all IP-bound network adapters and the security values associated with individual network adapters are in effect
        /// </summary>
        //  ����,IP�˿ڰ�ȫ�ǻ��ȫ���������л���������ܵ���ĸ���ȫ����ϵ����ֵ
        public  bool IPFilterSecurityEnabled
        {
            get { return iPFilterSecurityEnabled; }
            set { iPFilterSecurityEnabled = value; }
        }
        /// <summary>
        /// If TRUE, IP port security is enabled globally across all IP-bound network adapters
        /// </summary>
        //  ��ֱ,IP�˿ڰ�ȫ�����õ���������
        public  bool IPPortSecurityEnabled
        {
            get { return iPPortSecurityEnabled; }
            set { iPPortSecurityEnabled = value; }
        }
        /// <summary>
        /// Array of the protocols permitted to run over the IP.
        /// </summary>
        //  IP�������֤Э��Ķ���
        public  string[] IPSecPermitIPProtocols
        {
            get { return iPSecPermitIPProtocols; }
            set { iPSecPermitIPProtocols = value; }
        }
        /// <summary>
        /// Array of the ports that will be granted access permission for TCP
        /// </summary>
        //  ����ΪTCPͬ��������ɵĶ˿ڶ���
        public  string[] IPSecPermitTCPPorts
        {
            get { return iPSecPermitTCPPorts; }
            set { iPSecPermitTCPPorts = value; }
        }
        /// <summary>
        /// Array of the ports that will be granted User Datagram Protocol (UDP) access permission
        /// </summary>
        //   ����ΪUDPͬ��������ɵĶ˿ڶ���
        public  string[] IPSecPermitUDPPorts
        {
            get { return iPSecPermitUDPPorts; }
            set { iPSecPermitUDPPorts = value; }
        }
        /// <summary>
        /// Array of all the subnet masks associated with the current network adapter
        /// </summary>
        //�������������������
        public  string[] IPSubnet
        {
            get { return iPSubnet; }
            set { iPSubnet = value; }
        }
        /// <summary>
        /// If TRUE, IP zeros-broadcasts are used (0.0.0.0), and the system uses ones-broadcasts (255.255.255.255). 
        /// </summary>
        //  ����,IP��㲥ʹ��(0.0.0.0),����ϵͳʹ�ø��㲥(255.255.255.255)
        public  bool IPUseZeroBroadcast
        {
            get { return iPUseZeroBroadcast; }
            set { iPUseZeroBroadcast = value; }
        }
        /// <summary>
        /// Internetworking Packet Exchange (IPX) address of the network adapter
        /// </summary>
        //  ������(IPX)��ַ
        public  string IPXAddress
        {
            get { return iPXAddress; }
            set { iPXAddress = value; }
        }
        /// <summary>
        /// If TRUE, the or Internetwork Packet Exchange (IPX) protocol is bound and enabled for this adapter
        /// </summary>
        //  ����,��������ͻ(IPX)Э��
        public  bool IPXEnabled
        {
            get { return iPXEnabled; }
            set { iPXEnabled = value; }
        }
        /// <summary>
        /// Array of frame type identifiers
        /// </summary>
        //  ��ʶ���Ľṹ����
        public  UInt32[] IPXFrameType
        {
            get { return iPXFrameType; }
            set { iPXFrameType = value; }
        }
        /// <summary>
        /// Internetworking Packet Exchange (IPX) media type identifier
        /// </summary>
        //IPXý�����͵ı�ʶ��
        public  UInt32 IPXMediaType
        {
            get { return iPXMediaType; }
            set { iPXMediaType = value; }
        }
        /// <summary>
        /// Array of characters that uniquely identifies a frame/network adapter combination on the computer system
        /// </summary>
        //  Ψһ��ʶһ�������frame/network�������Ķ���
        public  string[] IPXNetworkNumber
        {
            get { return iPXNetworkNumber; }
            set { iPXNetworkNumber = value; }
        }
        /// <summary>
        /// Unique identifier of the computer system on the network
        /// </summary>
        //  �������ϼ������Ψһ��ʶ��
        public  string IPXVirtualNetNumber
        {
            get { return iPXVirtualNetNumber; }
            set { iPXVirtualNetNumber = value; }
        }
        /// <summary>
        /// Interval separating Keep Alive Retransmissions until a response is received
        /// </summary>
       //   ���ּ�϶�ط�ֱ��һ����׼����Ӧ����
        public  UInt32 KeepAliveInterval
        {
            get { return keepAliveInterval; }
            set { keepAliveInterval = value; }
        }
        /// <summary>
        /// how often the TCP attempts to verify that an idle connection is still intact by sending a Keep Alive Packet.
        /// </summary>
        // ����Ŭ��Ч��һ�����е�����ֱ�������ķ���һ����İ�.Ĭ����:��Сʱ(7,200,000 )
        public  UInt32 KeepAliveTime
        {
            get { return keepAliveTime; }
            set { keepAliveTime = value; }
        }
        /// <summary>
        /// ������MAC��ַ
        /// </summary>
        public  string MACAddress
        {
            get { return mACAddress; }
            set { mACAddress = value; }
        }
        /// <summary>
        /// Overrides the default Maximum Transmission Unit (MTU) for a network interface
        /// </summary>
        //Ϊһ�������ӿ�����һ�����Ĵ��͵�λ(MTU)
        public  UInt32 MTU
        {
            get { return mTU; }
            set { mTU = value; }
        }
        /// <summary>
        /// Number of IP packet headers allocated for the router packet queue
        /// </summary>
        //  Ϊ·�ɰ����з���IP��ͷ��
        public  UInt32 NumForwardPackets
        {
            get { return numForwardPackets; }
            set { numForwardPackets = value; }
        }
        /// <summary>
        /// If TRUE, detection of black hole routers occurs while TCP discovers the path of the Maximum Transmission Unit
        /// </summary>
        //  ����,����ڶ�·�ɷ���,��TCP����MTU·��
        public  bool PMTUBHDetectEnabled
        {
            get { return pMTUBHDetectEnabled; }
            set { pMTUBHDetectEnabled = value; }
        }
        /// <summary>
        /// If TRUE, the Maximum Transmission Unit (MTU) path is discovered over the path to a remote host.
        /// </summary>
        //  ����,��MTU·���Ƿ������ӵ�Զ��������·��
        public bool PMTUDiscoveryEnabled
        {
            get { return pMTUDiscoveryEnabled; }
            set { pMTUDiscoveryEnabled = value; }
        }
        /// <summary>
        /// �����ķ�����
        /// </summary>
        public  string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }
        /// <summary>
        /// Bitmap of the possible settings related to NetBIOSover TCP/IP.
        /// </summary>
        // ��TCP/IP��NETBIOS���ʻ��� ���ܵ�λͼ��������
        public  UInt32 TcpipNetbiosOptions
        {
            get { return tcpipNetbiosOptions; }
            set { tcpipNetbiosOptions = value; }
        }
        /// <summary>
        /// Number of times TCP attempts to retransmit a Connect Request before terminating the connection
        /// </summary>
        //  TCPŬ��ת��һ�������������ս�ǰ�Ĵ���
        public  UInt32 TcpMaxConnectRetransmissions
        {
            get { return tcpMaxConnectRetransmissions; }
            set { tcpMaxConnectRetransmissions = value; }
        }
        /// <summary>
        /// Number of times TCP re-transmits an individual data segment (non-connect segment) before terminating the connection
        /// </summary>
        //TCP����ת��һ���������ݶ�(û�б߽Ӷ�)����ֹ����ǰ
        public  UInt32 TcpMaxDataRetransmissions
        {
            get { return tcpMaxDataRetransmissions; }
            set { tcpMaxDataRetransmissions = value; }
        }
        /// <summary>
        /// Maximum number of connections that TCP can have open simultaneously
        /// </summary>
       //��ͬʱ��TCP�����������
        public  UInt32 TcpNumConnections
        {
            get { return tcpNumConnections; }
            set { tcpNumConnections = value; }
        }
        /// <summary>
        /// If TRUE, TCP uses the RFC 1122 specification for urgent data
        /// </summary>
        //����,TCPʹ��RFC 1122�淶Ϊ�˽�Ҫ����
        public  bool TcpUseRFC1122UrgentPointer
        {
            get { return tcpUseRFC1122UrgentPointer; }
            set { tcpUseRFC1122UrgentPointer = value; }
        }
        /// <summary>
        /// Maximum TCP Receive Window size offered by the system
        /// </summary>
        //ϵͳ�ṩ��С���ֵ
        public  UInt16 TcpWindowSize
        {
            get { return tcpWindowSize; }
            set { tcpWindowSize = value; }
        }
        /// <summary>
        /// If TRUE, local lookup files are used. Lookup files will contain a map of IP addresses to host names
        /// </summary>
        //����,�ڱ��ز����ļ�.�����ļ�������������IP��ַ��ͼ
        public  bool WINSEnableLMHostsLookup
        {
            get { return wINSEnableLMHostsLookup; }
            set { wINSEnableLMHostsLookup = value; }
        }
        /// <summary>
        /// Path to a WINS lookup file on the local system
        /// </summary>
        //�ڱ����ϵ�WINS·��
        public  string WINSHostLookupFile
        {
            get { return wINSHostLookupFile; }
            set { wINSHostLookupFile = value; }
        }
        /// <summary>
        /// IP address for the primary WINS server
        /// </summary>
        //��WINSϵͳ��IP��ַ
        public  string WINSPrimaryServer
        {
            get { return wINSPrimaryServer; }
            set { wINSPrimaryServer = value; }
        }
        /// <summary>
        /// Value appended to the end of the NetBIOS name that isolates a group of computer systems communicating with only each other.
        /// </summary>
        //  ��������������ĺ������ӵ�ֵ,��ʹһ��ļ����ϵͳͨ�Ÿ���
        public  string WINSScopeID
        {
            get { return wINSScopeID; }
            set { wINSScopeID = value; }
        }
        /// <summary>
        /// IP address for the secondary WINS server
        /// </summary>
        //IP��ַΪ�ڶ���WINSϵͳ
        public  string WINSSecondaryServer
        {
            get { return wINSSecondaryServer; }
            set { wINSSecondaryServer = value; }
        }

        public Dictionary<byte, string> YxDictionIGMPLevel
        {
            get
            {
                GetParser();
                return this.dictionIGMPLevel;
            }
        }
        public Dictionary<uint, string> YxDictionIPXFrameType
        {
            get 
            {
                GetParser();
                return this.dictionIPXFrameType;
            }
        }
        public Dictionary<uint, string> YxDictionIPXMediaType
        {
            get
            {
                GetParser();
                return this.dictionIPXMediaType;
            }
        }
        private void GetParser()
        {
            this.dictionIGMPLevel = new Dictionary<byte, string>();
            this.dictionIGMPLevel.Add(0, "No Multicast");
            this.dictionIGMPLevel.Add(1, "IP Multicast");
            this.dictionIGMPLevel.Add(2, "IP & IGMP multicast (default)");

            this.dictionIPXFrameType = new Dictionary<uint, string>();
            this.dictionIPXFrameType.Add(0, "Ethernet II");
            this.dictionIPXFrameType.Add(1, "Ethernet 802.3");
            this.dictionIPXFrameType.Add(2, "Ethernet 802.2");
            this.dictionIPXFrameType.Add(3, "Ethernet SNAP");
            this.dictionIPXFrameType.Add(255, "Ethernet SNAP");

            this.dictionIPXMediaType = new Dictionary<uint, string>();
            this.dictionIPXMediaType.Add(1, "Ethernet");
            this.dictionIPXMediaType.Add(2, "Token ring");
            this.dictionIPXMediaType.Add(3, "FDDI");
            this.dictionIPXMediaType.Add(8, "ARCNET");

        }
        public string GetdictionIGMPLevelByInt(byte value)
        {
            switch (value)
            {
                case 0:
                    return "No Multicast";
                case 1:
                    return "IP Multicast";
                case 2:
                    return "IP & IGMP multicast (default)";
                default :
                    return "�������ֵ";
            }
        }
        public string GetDictionIPXFrameTypeByInt(uint value)
        {
            switch (value)
            {
                case 0:
                    return "Ethernet II";
                case 1:
                    return "Ethernet 802.3";
                case 2:
                    return "Ethernet 802.2";
                case 3:
                    return "Ethernet SNAP";
                case 255:
                    return "AUTO";
                default:
                    return "�������ֵ";
            }
        }
        public string GetDictionIPXMediaTypeByInt(uint value)
        {
            switch (value)
            {
                case 1:
                    return "Ethernet";
                case 2:
                    return "Token ring";
                case 3:
                    return "FDDI";
                case 8:
                    return "ARCNET";
                default:
                    return "�������ֵ";
            }
        }
        public class NACIGMPLevel
        {
            public const byte NO_MULTICAST = 0;
            public const byte IP_MULTICAST = 1;
            public const byte IP_AND_IGMP_MULTICAST = 2;
        }
        public class NACIPXFrameType
        {
            public const uint ETHERNET_II = 0;
            public const uint ETHERNET_802_DO_3 = 1;
            public const uint ETHERNET_802_DO_2 = 2;
            public const uint ETHERNET_SNAP = 3;
            public const uint AUTO = 255;
        }
        public class NACTcpipNetbiosOptions
        {
            public const byte ENABLE_NETBIOS_VIA_DHCP = 0;
            public const byte ENABLE_NETBIOS = 1;
            public const byte DISABLE_NETBIOS = 2;
        }

        public string GetDictionTcpipNetbiosOptionsByInt(uint value)
        {
            switch (value)
            {
                case 0:
                    return "EnableNetbiosViaDhcp";
                case 1:
                    return "EnableNetbios";
                case 2:
                    return "DisableNetbios";
                default:
                    return "�������ֵ";
            }
        }
        public uint DisableIPSec()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("DisableIPSec", null);
            }

            return a;
        }
        public uint EnableDHCP()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("EnableDHCP", null);
            }

            return a;
        }
        public uint EnableDNS(string DNSHostName, string DNSDomain, string[] DNSServerSearchOrder, string[] DNSDomainSuffixSearchOrder)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("EnableDNS");
            inParams["DNSHostName"] = DNSHostName;
            inParams["DNSDomain"] = DNSDomain;
            inParams["DNSServerSearchOrder"] = DNSServerSearchOrder;
            inParams["DNSDomainSuffixSearchOrder"] = DNSDomainSuffixSearchOrder;
            ManagementBaseObject outParams = processClass.InvokeMethod("EnableDNS", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint EnableIPFilterSec(bool IPFilterSecurityEnabled)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("EnableIPFilterSec");
            inParams["IPFilterSecurityEnabled"] = IPFilterSecurityEnabled;
            ManagementBaseObject outParams = processClass.InvokeMethod("EnableIPFilterSec", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        //û�в���
        public uint EnableIPSec(string[] IPSecPermitTCPPorts, string[] IPSecPermitUDPPorts, string[] IPSecPermitIPProtocols)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("EnableIPSec", new object[] { IPSecPermitTCPPorts, IPSecPermitUDPPorts, IPSecPermitIPProtocols });
            }

            return a;
        }
        public uint EnableStatic(string[] IPAddress, string[] SubnetMask)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("EnableIPSec", new object[] { IPAddress, SubnetMask });
            }

            return a;
        }
        public uint EnableWINS(bool DNSEnabledForWINSResolution, bool WINSEnableLMHostsLookup, string WINSHostLookupFile, string WINSScopeID)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("EnableWINS");
            inParams["DNSEnabledForWINSResolution"] = DNSEnabledForWINSResolution;
            inParams["WINSEnableLMHostsLookup"] = WINSEnableLMHostsLookup;
            inParams["WINSHostLookupFile"] = WINSHostLookupFile;
            inParams["WINSScopeID"] = WINSScopeID;
            ManagementBaseObject outParams = processClass.InvokeMethod("EnableWINS", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint ReleaseDHCPLease()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("ReleaseDHCPLease", null);
            }

            return a;
        }
        public uint ReleaseDHCPLeaseAll()
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementBaseObject outParams = processClass.InvokeMethod("ReleaseDHCPLeaseAll", null, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint RenewDHCPLease()
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);

            uint a = uint.MaxValue;

            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("RenewDHCPLease", null);
            }

            return a;
        }
        public uint RenewDHCPLeaseAll()
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementBaseObject outParams = processClass.InvokeMethod("RenewDHCPLeaseAll", null, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetArpAlwaysSourceRoute(bool ArpAlwaysSourceRoute)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetArpAlwaysSourceRoute");
            inParams["ArpAlwaysSourceRoute"] = ArpAlwaysSourceRoute;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetArpAlwaysSourceRoute", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetArpUseEtherSNAP(bool ArpUseEtherSNAP)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetArpUseEtherSNAP");
            inParams["ArpUseEtherSNAP"] = ArpUseEtherSNAP;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetArpUseEtherSNAP", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetDatabasePath(string DatabasePath)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetDatabasePath");
            inParams["DatabasePath"] = DatabasePath;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetDatabasePath", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetDeadGWDetect(bool DeadGWDetectEnabled)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetDeadGWDetect");
            inParams["DeadGWDetectEnabled"] = DeadGWDetectEnabled;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetDeadGWDetect", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetDefaultTOS(byte DefaultTOS)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetDefaultTOS");
            inParams["DefaultTOS"] = DefaultTOS;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetDefaultTOS", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetDefaultTTL(byte DefaultTTL)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetDefaultTTL");
            inParams["DefaultTTL"] = DefaultTTL;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetDefaultTTL", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetDNSDomain(string DNSDomain)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetDNSDomain", new object[] { DNSDomain });
            }
            return a;
        }
        public uint SetDNSServerSearchOrder(string[] DNSServerSearchOrder)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetDNSServerSearchOrder", new object[] { DNSServerSearchOrder });
            }
            return a;
        }
        public uint SetDNSSuffixSearchOrder(string[] DNSDomainSuffixSearchOrder)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetDNSSuffixSearchOrder");
            inParams["DNSDomainSuffixSearchOrder"] = DNSDomainSuffixSearchOrder;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetDNSSuffixSearchOrder", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetDynamicDNSRegistration(bool FullDNSRegistrationEnabled, bool DomainDNSRegistrationEnabled)
        {
            return uint.MaxValue;
        }
        public uint SetForwardBufferMemory(uint ForwardBufferMemory)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetForwardBufferMemory");
            inParams["ForwardBufferMemory"] = ForwardBufferMemory;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetForwardBufferMemory", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetGateways(string[] DefaultIPGateway, ushort[] GatewayCostMetric)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetGateways", new object[] { DefaultIPGateway, GatewayCostMetric });
            }
            return a;
        }
        public  uint SetIGMPLevel(byte IGMPLevel)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetIGMPLevel");
            inParams["IGMPLevel"] = IGMPLevel;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetIGMPLevel", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetIPConnectionMetric(uint IPConnectionMetric)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetIPConnectionMetric", new object[] { IPConnectionMetric });
            }
            return a;
        }
        public uint SetIPUseZeroBroadcast(bool IPUseZeroBroadcast)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetIPUseZeroBroadcast");
            inParams["IPUseZeroBroadcast"] = IPUseZeroBroadcast;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetIPUseZeroBroadcast", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetIPXFrameTypeNetworkPairs(string[] IPXNetworkNumber, uint[] IPXFrameType)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetIPXFrameTypeNetworkPairs", new object[] { IPXNetworkNumber, IPXFrameType });
            }
            return a;
        }
        public uint SetIPXVirtualNetworkNumber(string IPXVirtualNetNumber)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetIPXVirtualNetworkNumber");
            inParams["IPXVirtualNetNumber"] = IPXVirtualNetNumber;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetIPXVirtualNetworkNumber", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public  uint SetKeepAliveInterval(uint KeepAliveInterval)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetKeepAliveInterval");
            inParams["KeepAliveInterval"] = KeepAliveInterval;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetKeepAliveInterval", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetKeepAliveTime(uint KeepAliveTime)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetKeepAliveTime");
            inParams["KeepAliveTime"] = KeepAliveTime;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetKeepAliveTime", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetMTU(uint MTU)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetMTU");
            inParams["MTU"] = MTU;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetMTU", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetNumForwardPackets(uint NumForwardPackets)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetNumForwardPackets");
            inParams["NumForwardPackets"] = NumForwardPackets;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetNumForwardPackets", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public  uint SetPMTUBHDetect(bool PMTUBHDetectEnabled)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetPMTUBHDetect");
            inParams["PMTUBHDetectEnabled"] = PMTUBHDetectEnabled;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetPMTUBHDetect", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetPMTUDiscovery(bool PMTUDiscoveryEnabled)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetPMTUDiscovery");
            inParams["PMTUDiscoveryEnabled"] = PMTUDiscoveryEnabled;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetPMTUDiscovery", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetTcpipNetbios(uint TcpipNetbiosOptions)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetTcpipNetbios", new object[] { TcpipNetbiosOptions });
            }
            return a; ;
        }
        public uint SetTcpMaxConnectRetransmissions(uint TcpMaxConnectRetransmissions)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetTcpMaxConnectRetransmissions");
            inParams["TcpMaxConnectRetransmissions"] = TcpMaxConnectRetransmissions;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetTcpMaxConnectRetransmissions", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetTcpMaxDataRetransmissions(uint TcpMaxDataRetransmissions)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetTcpMaxDataRetransmissions");
            inParams["TcpMaxDataRetransmissions"] = TcpMaxDataRetransmissions;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetTcpMaxDataRetransmissions", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetTcpNumConnections(uint TcpNumConnections)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetTcpNumConnections");
            inParams["TcpNumConnections"] = TcpNumConnections;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetTcpNumConnections", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetTcpUseRFC1122UrgentPointer(bool TcpUseRFC1122UrgentPointer)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetTcpUseRFC1122UrgentPointer");
            inParams["TcpUseRFC1122UrgentPointer"] = TcpUseRFC1122UrgentPointer;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetTcpUseRFC1122UrgentPointer", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetTcpWindowSize(ushort TcpWindowSize)
        {
            ManagementClass processClass = wmi.GetManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject inParams = processClass.GetMethodParameters("SetTcpWindowSize");
            inParams["TcpWindowSize"] = TcpWindowSize;

            ManagementBaseObject outParams = processClass.InvokeMethod("SetTcpWindowSize", inParams, null);
            uint a = (uint)outParams["ReturnValue"];
            return a;
        }
        public uint SetWINSServer(string WINSPrimaryServer, string WINSSecondaryServer)
        {
            ManagementObjectCollection moc = wmi.GetWSqlFromWMI("select * from Win32_NetworkAdapterConfiguration where Index=" + (uint)this.Index);
            uint a = uint.MaxValue;
            foreach (ManagementObject mo in moc)
            {
                a = (uint)mo.InvokeMethod("SetWINSServer", new object[] { WINSPrimaryServer, WINSSecondaryServer });
            }
            return a;
        }
        public string HintByReturnValue(uint hint)
        {
            switch (hint)
            {
                case 0:
                    return "Successful completion, no reboot required.";
                case 1:
                    return "Successful completion, reboot required.";
                case 64:
                    return "Method not supported on this platform.";
                case 65:
                    return "Unknown failure.";
                case 66:
                    return "Invalid subnet mask.";
                case 67:
                    return "An error occurred while processing an instance that was returned.";
                case 68:
                    return "Invalid input parameter.";
                case 69:
                    return "More than five gateways specified.";
                case 70:
                    return "Invalid IP address.";
                case 71:
                    return "Invalid gateway IP address.";
                case 72:
                    return "An error occurred while accessing the registry for the requested information.";
                case 73:
                    return "Invalid domain name.";
                case 74:
                    return "Invalid host name.";
                case 75:
                    return "No primary or secondary WINS server defined.";
                case 76:
                    return "Invalid file.";
                case 77:
                    return "Invalid system path.";
                case 78:
                    return "File copy failed.";
                case 79:
                    return "Invalid security parameter.";
                case 80:
                    return "Unable to configure TCP/IP service.";
                case 81:
                    return "Unable to configure DHCP service.";
                case 82:
                    return "Unable to renew DHCP lease.";
                case 83:
                    return "Unable to release DHCP lease.";
                case 84:
                    return "IP not enabled on adapter.";
                case 85:
                    return "IPX not enabled on adapter.";
                case 86:
                    return "Frame or network number bounds error.";
                case 87:
                    return "Invalid frame type.";
                case 88:
                    return "Invalid network number.";
                case 89:
                    return "Duplicate network number.";
                case 90:
                    return "Parameter out of bounds.";
                case 91:
                    return "Access denied.";
                case 92:
                    return "Out of memory.";
                case 93:
                    return "Already exists.";
                case 94:
                    return "Path, file, or object not found.";
                case 95:
                    return "Unable to notify service.";
                case 96:
                    return "Unable to notify DNS service.";
                case 97:
                    return "Interface not configurable.";
                case 98:
                    return "Not all DHCP leases could be released or renewed.";
                default:
                    return "DHCP not enabled on the adapter.";
            }
        }

    }
}
