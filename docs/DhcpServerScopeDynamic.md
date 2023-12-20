# SonicWallGen7.Model.DhcpServerScopeDynamic
DHCP server IPv4 option dynamic scopes configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | Set DHCP dynamic scope range start. | 
**To** | **string** | Set DHCP dynamic scope range end. | 
**Enable** | **bool** | Enable dynamic DHCP scope. | [optional] 
**LeaseTime** | **decimal** | Set dynamic DHCP scope lease time. | [optional] 
**DefaultGateway** | **string** | Set dynamic DHCP scope default gateway. * Set to null to represent an unconfigured state. | [optional] 
**Netmask** | **string** | Set dynamic DHCP scope subnet mask. | [optional] 
**Comment** | **string** | Set dynamic DHCP scope comment. * Set to null to represent an unconfigured state. | [optional] 
**AllowBootp** | **bool** | Enable allow BOOTP clients to use range. | [optional] 
**DomainName** | **string** | Set DHCP domain name. * Set to null to represent an unconfigured state. | [optional] 
**Dns** | [**DhcpServerScopeDynamicDns**](DhcpServerScopeDynamicDns.md) |  | [optional] 
**Wins** | [**DhcpServerScopeDynamicWins**](DhcpServerScopeDynamicWins.md) |  | [optional] 
**CallManager** | [**DhcpServerScopeDynamicCallManager**](DhcpServerScopeDynamicCallManager.md) |  | [optional] 
**NetworkBoot** | [**DhcpServerScopeDynamicNetworkBoot**](DhcpServerScopeDynamicNetworkBoot.md) |  | [optional] 
**GenericOption** | [**DhcpServerScopeDynamicGenericOption**](DhcpServerScopeDynamicGenericOption.md) |  | [optional] 
**AlwaysSendOption** | **bool** | Enable send generic options always. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

