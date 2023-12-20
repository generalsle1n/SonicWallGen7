# SonicWallGen7.Model.AdministrationAdministrationWebManagement
Configure web management.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowHttp** | **bool** | Allow HTTP management (it is less secure than using HTTPS). | [optional] 
**Certificate** | [**AdministrationAdministrationWebManagementCertificate**](AdministrationAdministrationWebManagementCertificate.md) |  | [optional] 
**CertCommonName** | **string** | Set the self signed certificate common name. | [optional] 
**ClientCertificateCheck** | **bool** | Enable client certificate check. | [optional] 
**ClientCertificateCache** | **bool** | Enable client certificate cache. | [optional] 
**UserNameField** | **string** | Set user-name-field. | [optional] 
**ClientCertificateIssuer** | **string** | Set client certificate issuer. | [optional] 
**CacUserGroupRetrieve** | **string** | Set user-name-field. | [optional] 
**OcspCheck** | [**AdministrationAdministrationWebManagementOcspCheck**](AdministrationAdministrationWebManagementOcspCheck.md) |  | [optional] 
**OcspPeriodicCheck** | [**AdministrationAdministrationWebManagementOcspPeriodicCheck**](AdministrationAdministrationWebManagementOcspPeriodicCheck.md) |  | [optional] 
**OcspCheckInterval** | **decimal** | OCSP-check_interval in web management  configure. | [optional] 
**DefaultTableSize** | **decimal** | Set default size of tables within the web management user interface. | [optional] 
**RefreshInterval** | **decimal** | Set auto-update refresh interval of tables within the web management user interface. | [optional] 
**Tooltip** | [**AdministrationAdministrationWebManagementTooltip**](AdministrationAdministrationWebManagementTooltip.md) |  | [optional] 
**CertificationPeriodicExpirationCheck** | **bool** | Enable certificate Expiration Periodic check. | [optional] 
**CertificationExpirationInterval** | **decimal** | Set default certification expiration interval. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

