# SonicWallGen7.Model.DiagAdvancedDnsProxyDiagAdvancedDnsProxy
Configure advanced diag DNS proxy settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestSizePercentage** | **decimal** | Configure the Percentage of proxy process ability. | [optional] 
**SupportFragmentation** | **bool** | Enable Support fragmentation process on DNS packet. | [optional] 
**ServerFailoverTimes** | **decimal?** | Resolution failure times that trigger DNS server failover. * Set to null to represent an unconfigured state. | [optional] 
**CacheLifetime** | **decimal?** | Lifetime of connection cache for DNS proxy packets. * Set to null to represent an unconfigured state. | [optional] 
**DnsOverTransport** | **string** | Configure the DNS over transport protocol. | [optional] 
**ExcludeVpnTraffic** | **bool** | Exclude incoming VPN traffic from DNS Proxy processing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

