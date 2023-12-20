# SonicWallGen7.Model.DiagAdvancedFirewallDiagAdvancedFirewall
Configure advanced diag firewall settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KillCacheNoDelay** | **bool** | Enable do not go to TIME_WAIT state when TCP 4-ways FIN completed. | [optional] 
**FtpBounceAttackProtection** | **bool** | Enable FTP bounce attack protection. | [optional] 
**FtpProtocolAnomalyAttackProtection** | **bool** | Enable FTP protocol anomaly attack protection. | [optional] 
**OrphanDataConnection** | **bool** | Enable allow orphan data connections. | [optional] 
**AllowZeroPort** | **bool** | Enable allow tcp/udp packet with source port being zero to pass through firewall. | [optional] 
**IpSpoofChecking** | **bool** | Enable IP spoof checking. | [optional] 
**PortScanDetection** | **bool** | Enable port scan detection. | [optional] 
**UcaplCompliance** | **bool** | Enable UCAPL compliance. | [optional] 
**AnticipatedConnectionTimeout** | **decimal** | Set timeout for anticipated TCP/UDP connections (seconds). | [optional] 
**AnticipatedConnectionParentTermination** | **bool** | Enable termination of parent on timeout of anticipated TCP/UDP connections. | [optional] 
**CacheIgnoreIcmpReject** | **bool** | Enable don&#39;t allow ICMP TTL exceed or destination Unreachable to kill cache entries. | [optional] 
**AnticipatedMediaTimeout** | **decimal** | Set timeout for anticipated media connections(seconds). | [optional] 
**AnticipatedMediaParentTermination** | **bool** | Enable termination of parent on timeout of anticipated media connections. | [optional] 
**TraceConnectionsPort** | **decimal** | Set TCP port to trace connections to. | [optional] 
**IncludeTcpDataConnection** | **bool** | Enable include TCP data connections in traces. | [optional] 
**TrackBandwidthUsage** | **bool** | Enable tracking bandwidth usage for default traffic. | [optional] 
**DecreaseConnectionCountAfterClose** | **bool** | Enable decreasing connection count immediately after TCP connection close. | [optional] 
**CsrfTokenValidation** | **bool** | Enable use CSRF Token Validation. | [optional] 
**SecureSessionIdCookie** | **bool** | Enable use secure session id cookie. | [optional] 
**TcpStateManipulationDosProtection** | **bool** | Enable protection against TCP state manipulation DoS. | [optional] 
**SequentialAddresses** | **bool** | Enable allocation of sequential addresses when performing many-to-few NAT. | [optional] 
**DefaultPolicyEditable** | **bool** | Enable the ability to remove and fully edit auto-added access rules and NATs. | [optional] 
**AutoAddedNatPolicyDisabling** | **bool** | Enable the ability to disable auto-added NAT policies. | [optional] 
**UdpIcmpFloodDetecting** | **bool** | Enable aggressive UDP/ICMP flood detecting. | [optional] 
**ControlPanelFloodProtection** | **decimal** | Set control panel flood protection hold time. | [optional] 
**UdpIcmpFloodProtection** | **bool** | Enable enforce UDP/ICMP flood protection with 100-millisecond resolution. | [optional] 
**SystemOverloadProtection** | **bool** | Enable system overload protection. | [optional] 
**SystemOverloadThreshold** | **decimal** | Set control panel flood protection hold time. | [optional] 
**BypassVpnTraffic** | **bool** | Enable bypass VPN traffic from flood protection. | [optional] 
**LogObjectName** | **bool** | Enable log packet content, schedule and address object name. | [optional] 
**PoliciesConnectionLimitation** | **bool** | Enable set connection limitation of management policies. | [optional] 
**ResetLoginCounter** | **decimal** | Reset user succesful login counter (hours). | [optional] 
**SendRstOnTimeout** | **bool** | Enable send RST on timeout TCP connection. | [optional] 
**AsyncSaveFlashPeriod** | **decimal** | Set the async save flash period in seconds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

