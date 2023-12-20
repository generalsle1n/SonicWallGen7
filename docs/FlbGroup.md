# SonicWallGen7.Model.FlbGroup
Failover load balancing group objects configuration schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Edit load balancing group name. | 
**Type** | **string** | Configure failover and load balancing type. | [optional] 
**Preempt** | **bool** | Enable Preempt and failback to preferred member when possible. | [optional] 
**SpilloverBandwidth** | [**FlbGroupSpilloverBandwidth**](FlbGroupSpilloverBandwidth.md) |  | [optional] 
**AddressBinding** | **bool** | Enable use source and destination IP address binding. | [optional] 
**FinalBackup** | **string** | Add/Replace final backup interface in load balancing group. | [optional] 
**VarInterface** | [**List&lt;FlbGroupInterfaceInner&gt;**](FlbGroupInterfaceInner.md) | Add/edit interface load balancing group member. | [optional] 
**Percent** | [**List&lt;FlbGroupPercentInner&gt;**](FlbGroupPercentInner.md) | Set the member usage percent. | [optional] 
**Probing** | [**FlbGroupProbing**](FlbGroupProbing.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

