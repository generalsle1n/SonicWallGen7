# SonicWallGen7.Model.DpiSslClientDpiSslClient
Enter client DPI-SSL configuration mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable SSL client inspection. | [optional] 
**IntrusionPrevention** | **bool** | Enable intrusion prevention for client DPI-SSL. | [optional] 
**Gateway** | [**DpiSslClientDpiSslClientGateway**](DpiSslClientDpiSslClientGateway.md) |  | [optional] 
**ApplicationFirewall** | **bool** | Enable application firewall for client DPI-SSL. | [optional] 
**ContentFilter** | **bool** | Enable content filter for client DPI-SSL. | [optional] 
**AuthenticateServerForDecryptedConnections** | **bool** | Enable always authenticate server for decrypted connections for client DPI-SSL. | [optional] 
**ExpiredCa** | **bool** | Enable allow expired CA. | [optional] 
**DeploymentServerDomains** | **bool** | Enable deployment wherein the firewall sees a single server IP for different server domains, ex: proxy setup. | [optional] 
**BypassDecryption** | **bool** | Enable allow SSL without decryption (bypass) when connection limit exceeded. | [optional] 
**AuditBuiltInExclusion** | **bool** | Enable audit new built-in exclusion domain names prior to being added for exclusion. | [optional] 
**AuthenticateServer** | **bool** | Enable always authenticate server before applying exclusion policy. | [optional] 
**OpenFailedConnections** | **bool** | Open failed connections (that are not deemed a security threat). | [optional] 
**ResigningAuthority** | [**DpiSslClientDpiSslClientResigningAuthority**](DpiSslClientDpiSslClientResigningAuthority.md) |  | [optional] 
**Include** | [**DpiSslClientDpiSslClientInclude**](DpiSslClientDpiSslClientInclude.md) |  | [optional] 
**Exclude** | [**DpiSslClientDpiSslClientExclude**](DpiSslClientDpiSslClientExclude.md) |  | [optional] 
**CfsCategories** | [**DpiSslClientDpiSslClientCfsCategories**](DpiSslClientDpiSslClientCfsCategories.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

