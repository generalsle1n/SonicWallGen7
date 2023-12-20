# SonicWallGen7.Model.UserLdapBaseUserLdap
Configure LDAP settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProtocolVersion** | **decimal** | Set protocol version of LDAP server. | [optional] 
**RequireValidCertificate** | **bool** | Enable validate the certificate presented by the server during                the TLS exchange. | [optional] 
**LocalTlsCertificate** | **string** | Select a local certificate for TLS. * Set to null to represent an unconfigured state. | [optional] 
**AllowReferrals** | **bool** | Allow following referrals to other LDAP servers. | [optional] 
**AllowReferences** | [**UserLdapBaseUserLdapAllowReferences**](UserLdapBaseUserLdapAllowReferences.md) |  | [optional] 
**LocalUsersOnly** | **bool** | Allow only LDAP users with local accounts. | [optional] 
**DefaultUserGroup** | **string** | Select a default user group for LDAP users. * Set to null to represent an unconfigured state. | [optional] 
**CheckDeletedGroupsMethod** | [**UserLdapBaseUserLdapCheckDeletedGroupsMethod**](UserLdapBaseUserLdapCheckDeletedGroupsMethod.md) |  | [optional] 
**MirrorUserGroups** | [**UserLdapBaseUserLdapMirrorUserGroups**](UserLdapBaseUserLdapMirrorUserGroups.md) |  | [optional] 
**DelMirroredUserGroups** | **bool** | Delete the mirrored user groups. | [optional] 
**Relay** | [**UserLdapBaseUserLdapRelay**](UserLdapBaseUserLdapRelay.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

