# SonicWallGen7.Model.AdministrationAdministrationUserLockout
Enable administrator / user lockout and set conditions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable administrator / user lockout configure. | [optional] 
**FailuresRate** | **decimal** | Set the failed login attempts in designed duration before lockout. | [optional] 
**FailuresDuration** | **decimal** | Set the failed in designed duration before lockout. | [optional] 
**LockoutDuration** | **decimal?** | Set number of minutes a user should be locked out. * Set to null to represent an unconfigured state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

