# SonicWallGen7.Model.InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6
PPPoE IPv6 configuration assignment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModeAssignment** | **string** | Set PPPoE6 mode. | [optional] 
**Schedule** | [**InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Schedule**](InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Schedule.md) |  | [optional] 
**Inactivity** | [**InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Inactivity**](InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Inactivity.md) |  | [optional] 
**LcpEchoPackets** | **bool** | Enable strictly use LCP echo packets for server keep-alive. | [optional] 
**Reconnect** | [**InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Reconnect**](InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Reconnect.md) |  | [optional] 
**NcpNegRetrans** | **decimal** | Set the retransmission time during NCP negotiation | [optional] 
**Ip** | **string** | Set interface IPv6 address. | [optional] 
**PrefixLength** | **decimal** | Set interface IPv6 prefix length. | [optional] 
**Dns** | [**InterfaceIpv4IpAssignmentModeStaticStaticDns**](InterfaceIpv4IpAssignmentModeStaticStaticDns.md) |  | [optional] 
**Gateway** | **string** | Set interface gateway. | [optional] 
**AdvertiseSubnetPrefix** | **bool** | subnet prefix of IPv6 primary static address. | [optional] 
**RouterAdvertisement** | [**InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement**](InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement.md) |  | [optional] 
**PrefixDelegation** | **bool** | Enable DHCPv6 prefix delegation. | [optional] 
**RapidCommit** | **bool** | Enable use rapid commit option. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

