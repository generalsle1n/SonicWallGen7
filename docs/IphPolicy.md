# SonicWallGen7.Model.IphPolicy
IP helper policies configuration schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Protocol** | **string** | Specify IP helper relay protocol to associate with this policy. | 
**Source** | [**IphPolicySource**](IphPolicySource.md) |  | 
**Destination** | [**IphPolicyDestination**](IphPolicyDestination.md) |  | [optional] 
**Enable** | **bool** | Enable IP helper policy. | [optional] 
**Comment** | **string** | Specify comment for IP helper policy. | [optional] 
**Egressif** | **string** | Set Egress Interface. * Set to null to represent an unconfigured state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

