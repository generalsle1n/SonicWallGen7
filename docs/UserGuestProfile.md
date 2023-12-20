# SonicWallGen7.Model.UserGuestProfile
Guest profile configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Set the name of the guest user profile. | 
**Generate** | [**UserGuestProfileGenerate**](UserGuestProfileGenerate.md) |  | [optional] 
**NamePrefix** | **string** | Set a prefix for names of created guest accounts. | [optional] 
**Comment** | **string** | Set comment for created guest accounts. * Set to null to represent an unconfigured state. | [optional] 
**Enable** | **bool** | Enable guest accounts to be created. | [optional] 
**ActivateOnLogin** | **bool** | Enable activate account upon first login. | [optional] 
**LoginUniqueness** | **bool** | Enable enforcing unique login sessions. | [optional] 
**PruneOnExpiry** | **bool** | Enable to delete the created guest accounts when they are expired. | [optional] 
**AccountLifetime** | [**UserGuestProfileAccountLifetime**](UserGuestProfileAccountLifetime.md) |  | [optional] 
**QuotaCycle** | [**UserGuestProfileQuotaCycle**](UserGuestProfileQuotaCycle.md) |  | [optional] 
**SessionLifetime** | [**UserGuestProfileSessionLifetime**](UserGuestProfileSessionLifetime.md) |  | [optional] 
**IdleTimeout** | [**UserGuestProfileIdleTimeout**](UserGuestProfileIdleTimeout.md) |  | [optional] 
**Limit** | [**UserGuestProfileLimit**](UserGuestProfileLimit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

