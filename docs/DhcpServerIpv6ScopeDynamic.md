# SonicWallGen7.Model.DhcpServerIpv6ScopeDynamic
DHCP server IPv6 dynamic scopes configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Set IPv6 DHCP server dynamic scope name. | 
**Range** | [**DhcpServerIpv6ScopeDynamicRange**](DhcpServerIpv6ScopeDynamicRange.md) |  | [optional] 
**Enable** | **bool** | Enable IPv6 DHCP server dynamic scope. | [optional] 
**Prefix** | **string** | Set IPv6 DHCP server dynamic scope prefix. | [optional] 
**Lifetime** | [**DhcpServerIpv6ScopeDynamicLifetime**](DhcpServerIpv6ScopeDynamicLifetime.md) |  | [optional] 
**Comment** | **string** | Set IPv6 DHCP server dynamic scope comment. * Set to null to represent an unconfigured state. | [optional] 
**DomainName** | **string** | Set IPv6 DHCP server dynamic scope domain name. * Set to null to represent an unconfigured state. | [optional] 
**Dns** | [**DhcpServerIpv6ScopeDynamicDns**](DhcpServerIpv6ScopeDynamicDns.md) |  | [optional] 
**GenericOption** | [**DhcpServerIpv6ScopeDynamicGenericOption**](DhcpServerIpv6ScopeDynamicGenericOption.md) |  | [optional] 
**AlwaysSendOption** | **bool** | Enable IPv6 DHCP server dynamic scope always send IPv6 options. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

