# SonicWallGen7.Model.FirewallFirewall
Configure firewall settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StealthMode** | **bool** | Enable stealth mode. | [optional] 
**RandomizeId** | **bool** | Enable randomize IP ID. | [optional] 
**Decrement** | [**FirewallFirewallDecrement**](FirewallFirewallDecrement.md) |  | [optional] 
**Icmp** | [**FirewallFirewallIcmp**](FirewallFirewallIcmp.md) |  | [optional] 
**FtpTransformsInServiceObject** | [**FirewallFirewallFtpTransformsInServiceObject**](FirewallFirewallFtpTransformsInServiceObject.md) |  | [optional] 
**Sqlnet** | **bool** | Enable support for oracle (SQLNet). | [optional] 
**RtspTransformations** | **bool** | Enable RTSP transformations. | [optional] 
**Drop** | [**FirewallFirewallDrop**](FirewallFirewallDrop.md) |  | [optional] 
**Connections** | **string** | Set the type of connections. | [optional] 
**ForceFtpData** | **bool** | Force inbound and outbound FTP data connections to use the default port: 20. | [optional] 
**ApplyRulesForIntraLan** | **bool** | Enable apply firewall rules for intra-LAN traffic to/from the same interface. | [optional] 
**IssueRstForOutgoingDiscards** | **bool** | Enable always issue RST for discarded outgoing TCP connections. | [optional] 
**Ip** | [**FirewallFirewallIp**](FirewallFirewallIp.md) |  | [optional] 
**Udp** | [**FirewallFirewallUdp**](FirewallFirewallUdp.md) |  | [optional] 
**JumboFrame** | **bool** | Enable support jumbo frame. | [optional] 
**Ipv6** | [**FirewallFirewallIpv6**](FirewallFirewallIpv6.md) |  | [optional] 
**ControlPlaneFloodProtection** | **bool** | Enable control plane flood protection. | [optional] 
**ControlPlaneFloodProtectionThreshold** | **decimal** | Set the threshold (CPU %). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

