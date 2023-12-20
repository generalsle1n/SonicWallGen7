# SonicWallGen7.Model.SecurityServicesSecurityServices
Enter security services configuration mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Security** | **string** | Set global security services setting. | [optional] 
**ReduceIsdnAntivirusTraffic** | **bool** | Enable reduce Anti-Virus  traffic for ISDN connections. | [optional] 
**DropPacketsAtReload** | **bool** | Enable drop all packets while IPS, GAV and Anti-Spyware database is reloading. | [optional] 
**HttpClientlessNotificationTimeout** | **decimal** | Set HTTP clientless notification timeout for gateway AntiVirus and AntiSpyware in seconds. | [optional] 
**ProxyServer** | [**SecurityServicesSecurityServicesProxyServer**](SecurityServicesSecurityServicesProxyServer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

