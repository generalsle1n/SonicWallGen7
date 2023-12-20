# SonicWallGen7.Model.UserLdapServer
user LDAP server configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Set the LDAP server&#39;s host name or IP address. | 
**Enable** | **bool** | Enable the LDAP server. | [optional] 
**Role** | [**UserLdapServerRole**](UserLdapServerRole.md) |  | [optional] 
**Partition** | **string** | Set the LDAP server&#39;s user partition. | [optional] 
**Timeout** | [**UserLdapServerTimeout**](UserLdapServerTimeout.md) |  | [optional] 
**UseTls** | **bool** | Enable use transport layer security (TLS) when log in to the                LDAP server. | [optional] 
**SendStartTlsRequest** | **bool** | Enable send LDAP &#39;Start TLS&#39; request. | [optional] 
**BackupFor** | **string** | Set the LDAP server for which this is the backup for. | [optional] 
**SameBindCredentials** | **bool** | Enable using same bind credentials as the server that this is the backup for. | [optional] 
**Port** | **decimal** | Set the LDAP server&#39;s UDP port number. | [optional] 
**Schema** | **string** | Configure the LDAP schema. | [optional] 
**UserClass** | **string** | Set the class name of user objects. | [optional] 
**UserAttribute** | [**UserLdapServerUserAttribute**](UserLdapServerUserAttribute.md) |  | [optional] 
**UserGroupClass** | **string** | Set the class name of user group objects. | [optional] 
**UserGroupAttribute** | [**UserLdapServerUserGroupAttribute**](UserLdapServerUserGroupAttribute.md) |  | [optional] 
**Directory** | [**UserLdapServerDirectory**](UserLdapServerDirectory.md) |  | [optional] 
**Bind** | [**UserLdapServerBind**](UserLdapServerBind.md) |  | [optional] 
**BindPassword** | **string** | Set the password for binding to the LDAP server. * Set to null to represent an unconfigured state. | [optional] 
**ReferredBindWithAccount** | **string** | Set the bind method when referred to other servers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

