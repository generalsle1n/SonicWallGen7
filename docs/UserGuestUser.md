# SonicWallGen7.Model.UserGuestUser
Guest user configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Set the login name of the guest account. | 
**Uuid** | **string** | user object UUID. | [optional] [readonly] 
**Generate** | [**UserGuestUserGenerate**](UserGuestUserGenerate.md) |  | [optional] 
**Profile** | **string** | Enable the settings from a guest profile. | [optional] 
**Password** | **string** | Set the guest account password. * Set to null to represent an unconfigured state. | [optional] 
**Comment** | **string** | Set comment for the guest account. * Set to null to represent an unconfigured state. | [optional] 
**Enable** | **bool** | Enable the guest account. | [optional] 
**ActivateOnLogin** | **bool** | Enable activate account upon first login. | [optional] 
**LoginUniqueness** | **bool** | Enable enforcing a unique login session with the guest account. | [optional] 
**PruneOnExpiry** | **bool** | Enable delete the guest account when it is expired                if a limited lifetime is set. | [optional] 
**AccountLifetime** | [**UserGuestUserAccountLifetime**](UserGuestUserAccountLifetime.md) |  | [optional] 
**QuotaCycle** | [**UserGuestUserQuotaCycle**](UserGuestUserQuotaCycle.md) |  | [optional] 
**SessionLifetime** | [**UserGuestUserSessionLifetime**](UserGuestUserSessionLifetime.md) |  | [optional] 
**IdleTimeout** | [**UserGuestUserIdleTimeout**](UserGuestUserIdleTimeout.md) |  | [optional] 
**Limit** | [**UserGuestUserLimit**](UserGuestUserLimit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

