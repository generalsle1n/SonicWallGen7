# SonicWallGen7.Model.AdministrationAdministration
Administration settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirewallName** | **string** | Set the name for the firewall. | [optional] 
**AutoAppendSuffix** | **bool** | Config the administrator settings. | [optional] 
**EnforceHttpHostCheck** | **bool** | Config the administrator settings. | [optional] 
**FirewallDomainName** | **string** | Set the domain name for the firewall. * Set to null to represent an unconfigured state. | [optional] 
**Admin** | [**AdministrationAdministrationAdmin**](AdministrationAdministrationAdmin.md) |  | [optional] 
**Password** | [**AdministrationAdministrationPassword**](AdministrationAdministrationPassword.md) |  | [optional] 
**IdleLogoutTime** | **decimal** | Set the allowed number of minutes of inactivity before administrators are logged out of the management interface. | [optional] 
**UserLockout** | [**AdministrationAdministrationUserLockout**](AdministrationAdministrationUserLockout.md) |  | [optional] 
**LocalUserLockout** | **bool** | Enable local administrator/user account lockout (uncheck for login IP address lockout). | [optional] 
**LogWithoutLockout** | **bool** | Enable Log event only without lockout. | [optional] 
**MaxLoginAttemptsCli** | **decimal** | Configure max login attempts through CLI. | [optional] 
**Ipv6** | **bool** | Enable IPv6. | [optional] 
**CloudBackupEnable** | **bool** | Config the administrator settings. | [optional] 
**InterAdminMessaging** | [**AdministrationAdministrationInterAdminMessaging**](AdministrationAdministrationInterAdminMessaging.md) |  | [optional] 
**MultipleAdmin** | **bool** | Enable multiple administrative roles. | [optional] 
**EnhancedAuditLogging** | **bool** | Enable enhanced audit logging. | [optional] 
**WebManagement** | [**AdministrationAdministrationWebManagement**](AdministrationAdministrationWebManagement.md) |  | [optional] 
**Uuid** | [**AdministrationAdministrationUuid**](AdministrationAdministrationUuid.md) |  | [optional] 
**DashboardAsStartingPage** | **bool** | Set to use dashboard as starting page. | [optional] 
**TlsAndAbove** | **bool** | Enforce TLS 1.1 and above. | [optional] 
**OutOfBandManagement** | **bool** | Enable out of band management on management port. | [optional] 
**LanguageOverride** | [**AdministrationAdministrationLanguageOverride**](AdministrationAdministrationLanguageOverride.md) |  | [optional] 
**GmsManagement** | [**AdministrationAdministrationGmsManagement**](AdministrationAdministrationGmsManagement.md) |  | [optional] 
**SonicosApi** | [**AdministrationAdministrationSonicosApi**](AdministrationAdministrationSonicosApi.md) |  | [optional] 
**Ssh** | [**AdministrationAdministrationSsh**](AdministrationAdministrationSsh.md) |  | [optional] 
**HttpPort** | **decimal** | Set the HTTP management port. | [optional] 
**HttpsPort** | **decimal** | Set the HTTPS management port. | [optional] 
**ForceThrough** | [**AdministrationAdministrationForceThrough**](AdministrationAdministrationForceThrough.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

