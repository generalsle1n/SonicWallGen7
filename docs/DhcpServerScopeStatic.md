# SonicWallGen7.Model.DhcpServerScopeStatic
DHCP server static scopes configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ip** | **string** | Set DHCP static scope IP address. | 
**Mac** | **string** | Set DHCP static scope ethernet address. | 
**Enable** | **bool** | Enable DHCP server scope. | [optional] 
**Name** | **string** | Set DHCP static scope name. | [optional] 
**LeaseTime** | **decimal** | Set DHCP static scope lease time. | [optional] 
**DefaultGateway** | **string** | Set DHCP static scope default gateway. * Set to null to represent an unconfigured state. | [optional] 
**Netmask** | **string** | Set DHCP static scope subnet mask. | [optional] 
**Comment** | **string** | Set DHCP static scope comment. * Set to null to represent an unconfigured state. | [optional] 
**DomainName** | **string** | Set DHCP domain name. * Set to null to represent an unconfigured state. | [optional] 
**Dns** | [**DhcpServerScopeStaticDns**](DhcpServerScopeStaticDns.md) |  | [optional] 
**Wins** | [**DhcpServerScopeDynamicWins**](DhcpServerScopeDynamicWins.md) |  | [optional] 
**CallManager** | [**DhcpServerScopeDynamicCallManager**](DhcpServerScopeDynamicCallManager.md) |  | [optional] 
**NetworkBoot** | [**DhcpServerScopeDynamicNetworkBoot**](DhcpServerScopeDynamicNetworkBoot.md) |  | [optional] 
**GenericOption** | [**DhcpServerScopeStaticGenericOption**](DhcpServerScopeStaticGenericOption.md) |  | [optional] 
**AlwaysSendOption** | **bool** | Enable send generic options always. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

