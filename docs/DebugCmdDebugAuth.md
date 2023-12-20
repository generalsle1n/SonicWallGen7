# SonicWallGen7.Model.DebugCmdDebugAuth
authentication debug settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tsa** | **decimal?** | Set the TSA debug level(0 ~ 10). * Set to null to represent an unconfigured state. | [optional] 
**Cia** | **decimal?** | Set the CIA debug level(0 ~ 10). * Set to null to represent an unconfigured state. | [optional] 
**RadiusAccount** | **decimal?** | Set radius account debug level(0 ~ 10). * Set to null to represent an unconfigured state. | [optional] 
**SsoApi** | **decimal?** | Set sso-api debug level(0 ~ 10). * Set to null to represent an unconfigured state. | [optional] 
**Radius** | **bool** | Enable radius authentication debugging. | [optional] 
**Ldap** | [**DebugCmdDebugAuthLdap**](DebugCmdDebugAuthLdap.md) |  | [optional] 
**Tacas** | **bool** | Enable debug tacas. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

