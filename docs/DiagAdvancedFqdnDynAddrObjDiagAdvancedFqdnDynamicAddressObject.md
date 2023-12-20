# SonicWallGen7.Model.DiagAdvancedFqdnDynAddrObjDiagAdvancedFqdnDynamicAddressObject
Configure advanced diag FQDN dynamic address object settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CacheDnsReply** | **bool** | Enable FQDN object only cache DNS reply from sanctioned server. | [optional] 
**OffsetForFqdnObjects** | **decimal** | Offset for FQDN objects(seconds). | [optional] 
**RefreshSubDomains** | **bool** | Enable refresh sub domains of wildcard FQDN dynamic address objects. | [optional] 
**ExpiredHostDeletion** | **bool** | Enable donot delete expired hosts of an FQDN network object with active connections. | [optional] 
**RetainExpiredFqdnHosts** | **bool** | Enable retain expired FQDN hosts until a successfull DNs resolutions occurs. | [optional] 
**UnlimitedQueries** | **bool** | Enable unlimited queries to resolve custom FQDN obects. | [optional] 
**StopDnsQueries** | **bool** | Enable stop dns queries for default FQDN objects after maximumthreshold. | [optional] 
**MaxRetryThreshold** | **decimal** | FQDN maximum retry threshold before stopping query. | [optional] 
**MinAllowedTtl** | **decimal** | Minimum allowed ttl for FQDN objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

