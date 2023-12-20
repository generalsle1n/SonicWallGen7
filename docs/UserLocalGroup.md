# SonicWallGen7.Model.UserLocalGroup
local group configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Set the name of the user group. | 
**Domain** | **string** | Set the user group&#39;s domain. * Set to null to represent an unconfigured state. | [optional] 
**Uuid** | **string** | user group object UUID. | [optional] [readonly] 
**DisplayName** | **string** | Only used for show user group display name. | [optional] 
**Comment** | **string** | Set a comment for the user group. * Set to null to represent an unconfigured state. | [optional] 
**MembershipsByLdapLocation** | [**UserLocalGroupMembershipsByLdapLocation**](UserLocalGroupMembershipsByLdapLocation.md) |  | [optional] 
**LdapLocation** | **string** | Set local group location in LDAP directory. * Set to null to represent an unconfigured state. | [optional] 
**OneTimePassword** | [**UserLocalGroupOneTimePassword**](UserLocalGroupOneTimePassword.md) |  | [optional] 
**ToManagementOnLogin** | **bool** | Members with administrative privilege will go straight to the management UI on web login. | [optional] 
**ReadOnlyRestriction** | **bool** | The administrative rights from the other groups will be restricted to read-only. | [optional] 
**Member** | [**List&lt;AddressGroupIpv4Ipv4AddressGroupIpv4Inner&gt;**](AddressGroupIpv4Ipv4AddressGroupIpv4Inner.md) | Add a member user or user group. | [optional] 
**VpnClientAccess** | [**List&lt;UserLocalGroupVpnClientAccessInner&gt;**](UserLocalGroupVpnClientAccessInner.md) | Add VPN client access to a network for group members. | [optional] 
**Bookmark** | [**List&lt;UserLocalGroupBookmarkInner&gt;**](UserLocalGroupBookmarkInner.md) | Add/edit bookmark and enter configuration mode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

