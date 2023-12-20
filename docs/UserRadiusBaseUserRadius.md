# SonicWallGen7.Model.UserRadiusBaseUserRadius
Configure RADIUS settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalUsersOnly** | **bool** | Allow only RADIUS users with local accounts. | [optional] 
**DefaultUserGroup** | **string** | Select a default user group for RADIUS users. * Set to null to represent an unconfigured state. | [optional] 
**PeriodicCheckServer** | **bool** | Enable periodiclly check RADIUS servers that are down. | [optional] 
**Mschapv2Mode** | **bool** | Enfore MSCHAPv2 mode. | [optional] 
**Timeout** | **decimal** | Set the timeout for the RADIUS servers. | [optional] 
**Retries** | **decimal** | Set the number of retries for the RADIUS servers. | [optional] 
**UserGroupMechanism** | [**UserRadiusBaseUserRadiusUserGroupMechanism**](UserRadiusBaseUserRadiusUserGroupMechanism.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

