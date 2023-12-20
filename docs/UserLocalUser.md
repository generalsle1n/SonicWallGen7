# SonicWallGen7.Model.UserLocalUser
local user configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Set the login name of the user account. | 
**Domain** | **string** | Set the user&#39;s domain. * Set to null to represent an unconfigured state. | [optional] 
**Uuid** | **string** | user object UUID. | [optional] [readonly] 
**DisplayName** | **string** | Only used for show user display name. | [optional] 
**Password** | **string** | Set the user password. * Set to null to represent an unconfigured state. | [optional] 
**Comment** | **string** | Set a comment for the user account. * Set to null to represent an unconfigured state. | [optional] 
**ForcePasswordChange** | **bool** | Force the user to change their password at next login. | [optional] 
**OneTimePassword** | [**UserLocalUserOneTimePassword**](UserLocalUserOneTimePassword.md) |  | [optional] 
**AccountLifetime** | [**UserLocalUserAccountLifetime**](UserLocalUserAccountLifetime.md) |  | [optional] 
**Expiration** | [**UserLocalUserExpiration**](UserLocalUserExpiration.md) |  | [optional] 
**PruneOnExpiry** | **bool** | Delete the user account when it expires if a limited lifetime is set. | [optional] 
**QuotaCycle** | [**UserLocalUserQuotaCycle**](UserLocalUserQuotaCycle.md) |  | [optional] 
**SessionLifetime** | [**UserLocalUserSessionLifetime**](UserLocalUserSessionLifetime.md) |  | [optional] 
**Limit** | [**UserLocalUserLimit**](UserLocalUserLimit.md) |  | [optional] 
**EmailAddress** | **string** | Set the user&#39;s e-mail address. * Set to null to represent an unconfigured state. | [optional] 
**GuestLoginUniqueness** | **bool** | Enable enforcing a unique login session with the account for guest services. | [optional] 
**GuestIdleTimeout** | [**UserLocalUserGuestIdleTimeout**](UserLocalUserGuestIdleTimeout.md) |  | [optional] 
**MemberOf** | [**List&lt;AddressGroupIpv4Ipv4AddressGroupIpv4Inner&gt;**](AddressGroupIpv4Ipv4AddressGroupIpv4Inner.md) | Add membership to a user group for this user. | [optional] 
**VpnClientAccess** | [**List&lt;UserLocalUserVpnClientAccessInner&gt;**](UserLocalUserVpnClientAccessInner.md) | Add access to a network for the user with VPN client. | [optional] 
**Bookmark** | [**List&lt;UserLocalUserBookmarkInner&gt;**](UserLocalUserBookmarkInner.md) | Add/edit bookmark and enter configuration mode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

