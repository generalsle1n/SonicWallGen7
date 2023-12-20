# SonicWallGen7.Model.InterfaceIpv4Ipv4
IP version IPv4.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Interface name. | 
**Vlan** | **decimal** | Interface VLAN ID. | [optional] 
**IpAssignment** | [**InterfaceIpv4Ipv4IpAssignment**](InterfaceIpv4Ipv4IpAssignment.md) |  | [optional] 
**Comment** | **string** | Set interface comment. | [optional] 
**Mtu** | **decimal** | Set interface MTU. | [optional] 
**Mac** | [**InterfaceIpv4Ipv4Mac**](InterfaceIpv4Ipv4Mac.md) |  | [optional] 
**LinkSpeed** | [**InterfaceIpv4Ipv4LinkSpeed**](InterfaceIpv4Ipv4LinkSpeed.md) |  | [optional] 
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
**RoutedMode** | [**InterfaceIpv4Ipv4RoutedMode**](InterfaceIpv4Ipv4RoutedMode.md) |  | [optional] 
**OneArmMode** | **bool** | Enable one-arm mode on the interface | [optional] 
**OneArmPeer** | **string** | Set interface one-arm-peer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

