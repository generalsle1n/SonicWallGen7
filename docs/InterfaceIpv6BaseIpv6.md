# SonicWallGen7.Model.InterfaceIpv6BaseIpv6
IP version IPV6.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Interface name. | 
**Vlan** | **decimal** | Interface VLAN ID. | [optional] 
**IpAssignment** | [**InterfaceIpv6BaseIpv6IpAssignment**](InterfaceIpv6BaseIpv6IpAssignment.md) |  | [optional] 
**Management** | [**InterfaceIpv6BaseIpv6Management**](InterfaceIpv6BaseIpv6Management.md) |  | [optional] 
**UserLogin** | [**InterfaceIpv4Ipv4UserLogin**](InterfaceIpv4Ipv4UserLogin.md) |  | [optional] 
**HttpsRedirect** | **bool** | Enable redirection from HTTP to HTTPS. | [optional] 
**Ipv6Traffic** | **bool** | Enable IPv6 traffic on this interface. | [optional] 
**ListenRouterAdvertisement** | **bool** | Enable listening to route advertisement. | [optional] 
**StatelessAddressAutoconfig** | **bool** | Enable stateless address autoconfiguration. | [optional] 
**DuplicateAddressDetectionTransmits** | **decimal** | Set duplicate address detection transmits. | [optional] 
**ReachableTime** | **decimal** | Set neighbor discovery base reachable time in seconds. | [optional] 
**Multicast** | **bool** | Enable IPv6 multicast support. | [optional] 
**OneArmMode** | **bool** | Enable one-arm ipv6 mode on the interface | [optional] 
**OneArmPeer** | **string** | Set interface one-arm-peer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

