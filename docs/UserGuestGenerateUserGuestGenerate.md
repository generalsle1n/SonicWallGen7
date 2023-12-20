# SonicWallGen7.Model.UserGuestGenerateUserGuestGenerate
Auto generate some guest users.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Num** | **decimal** | Auto generate some guest users. | [optional] 
**NamePrefix** | **string** | Set a prefix for names of created guest accounts. | [optional] 
**Comment** | **string** | Set comment for created guest accounts. | [optional] 
**Enable** | **bool** | Enable guest accounts to be created. | [optional] 
**ActivateOnLogin** | **bool** | Enable activate account upon first login. | [optional] 
**LoginUniqueness** | **bool** | Enable enforcing unique login sessions. | [optional] 
**PruneOnExpiry** | **bool** | Enable to delete the created guest accounts when they are expired. | [optional] 
**AccountLifetime** | [**UserGuestGenerateUserGuestGenerateAccountLifetime**](UserGuestGenerateUserGuestGenerateAccountLifetime.md) |  | [optional] 
**QuotaCycle** | [**UserGuestGenerateUserGuestGenerateQuotaCycle**](UserGuestGenerateUserGuestGenerateQuotaCycle.md) |  | [optional] 
**SessionLifetime** | [**UserGuestGenerateUserGuestGenerateSessionLifetime**](UserGuestGenerateUserGuestGenerateSessionLifetime.md) |  | [optional] 
**IdleTimeout** | [**UserGuestGenerateUserGuestGenerateIdleTimeout**](UserGuestGenerateUserGuestGenerateIdleTimeout.md) |  | [optional] 
**Limit** | [**UserGuestGenerateUserGuestGenerateLimit**](UserGuestGenerateUserGuestGenerateLimit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

