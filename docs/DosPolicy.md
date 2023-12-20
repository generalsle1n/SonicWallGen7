# SonicWallGen7.Model.DosPolicy
Dos policy configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Name of DoS policy. | 
**Name** | **string** | Name of DoS policy. | [optional] 
**Priority** | [**DosPolicyPriority**](DosPolicyPriority.md) |  | [optional] 
**Enable** | **bool** | Enable this DoS policy. | [optional] 
**Comment** | **string** | Set comment to help identify this DoS policy. | [optional] 
**IpVersion** | **string** | IP version. | [optional] 
**Destination** | [**DosPolicyDestination**](DosPolicyDestination.md) |  | [optional] 
**Source** | [**DosPolicySource**](DosPolicySource.md) |  | [optional] 
**Service** | [**DosPolicyService**](DosPolicyService.md) |  | [optional] 
**Schedule** | [**DosPolicySchedule**](DosPolicySchedule.md) |  | [optional] 
**Action** | **string** | Set the action for this DoS policy. | [optional] 
**ActionProfile** | **string** | Assign DoS profile. | [optional] 
**Ticket** | [**DosPolicyTicket**](DosPolicyTicket.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

