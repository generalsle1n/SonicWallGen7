# SonicWallGen7.Model.InterfaceVlanIpv4Ipv4
IP version IPv4.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Interface name. | 
**Vlan** | **decimal** | Interface VLAN ID. | 
**IpAssignment** | [**InterfaceVlanIpv4Ipv4IpAssignment**](InterfaceVlanIpv4Ipv4IpAssignment.md) |  | [optional] 
**Comment** | **string** | Set interface comment. | [optional] 
**Mtu** | **decimal** | Set interface MTU. | [optional] 
**Mac** | [**InterfaceVlanIpv4Ipv4Mac**](InterfaceVlanIpv4Ipv4Mac.md) |  | [optional] 
**LinkSpeed** | [**InterfaceVlanIpv4Ipv4LinkSpeed**](InterfaceVlanIpv4Ipv4LinkSpeed.md) |  | [optional] 
**Management** | [**InterfaceIpv4Ipv4Management**](InterfaceIpv4Ipv4Management.md) |  | [optional] 
**UserLogin** | [**InterfaceIpv4Ipv4UserLogin**](InterfaceIpv4Ipv4UserLogin.md) |  | [optional] 
**HttpsRedirect** | **bool** | Enable redirection from HTTP to HTTPS. | [optional] 
**SendIcmpFragmentation** | **bool** | Enable ICMP fragmentation needed message generation. | [optional] 
**FragmentPackets** | **bool** | Enable fragment non-VPN outbound packets larger than this interface&#39;s MTU. | [optional] 
**IgnoreDfBit** | **bool** | Enable ignore don&#39;t fragment (DF) bit. | [optional] 
**FlowReporting** | **bool** | Enable flow reporting on the interface. | [optional] 
**Multicast** | **bool** | Enable multicast support. | [optional] 
**Cos8021p** | **bool** | Enable 802.1p support. | [optional] 
**ExcludeRoute** | **bool** | Enable exclude from route advertisement (NSM, OSPF, BGP, RIP). | [optional] 
**AsymmetricRoute** | **bool** | Enable asymmetric route. | [optional] 
**ManagementTrafficOnly** | **bool** | Enable management traffic only. | [optional] 
**DnsProxy** | **bool** | Enable DNS proxy on the interface. | [optional] 
**ShutdownPort** | **bool** | Enable shutdown port. | [optional] 
**Secondary** | [**InterfaceIpv4Ipv4Secondary**](InterfaceIpv4Ipv4Secondary.md) |  | [optional] 
**Default8021pCos** | [**InterfaceIpv4Ipv4Default8021pCos**](InterfaceIpv4Ipv4Default8021pCos.md) |  | [optional] 
**BandwidthManagement** | [**InterfaceIpv4Ipv4BandwidthManagement**](InterfaceIpv4Ipv4BandwidthManagement.md) |  | [optional] 
**RoutedMode** | [**InterfaceVlanIpv4Ipv4RoutedMode**](InterfaceVlanIpv4Ipv4RoutedMode.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

