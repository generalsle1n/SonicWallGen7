# SonicWallGen7.Model.UserTacacsBaseUserTacacs
Configure TACACS settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalUsersOnly** | **bool** | Allow only TACACS users with local accounts. | [optional] 
**DefaultUserGroup** | **string** | Select a default user group for TACACS users. | [optional] 
**Timeout** | **decimal** | Set the timeout on replies from the TACACS+ servers. | [optional] 
**Retries** | **decimal** | Set the maximum number of retries to make. | [optional] 
**SingleConnect** | **bool** | Enable support for single connect. | [optional] 
**PeriodicCheck** | **bool** | Enable periodic check of TACACS servers that are down. | [optional] 
**UserGroupMechanism** | [**UserTacacsBaseUserTacacsUserGroupMechanism**](UserTacacsBaseUserTacacsUserGroupMechanism.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

