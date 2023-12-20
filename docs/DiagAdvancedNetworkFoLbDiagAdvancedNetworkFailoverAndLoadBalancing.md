# SonicWallGen7.Model.DiagAdvancedNetworkFoLbDiagAdvancedNetworkFailoverAndLoadBalancing
Configure advanced diag Network failover and load balance settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdleExpireTime** | **decimal** | Set minutes to wait before removing idle entries from the Persistent LB Table. | [optional] 
**ActivityInterval** | **decimal** | Set seconds interval between inspections of the Persistent LB Table, for marking entries as idle. | [optional] 
**ReuseMax** | **decimal** | Set maximum reuse threshold for each entry in the Persistent LB Table, zero means unlimited. | [optional] 
**SourceIp** | **string** | Set source IP Address to monitor (Source-Destination IP Binding to include in TSR). | [optional] 
**DestinationIp** | **string** | Set destination IP Address to monitor (Source-Destination IP Binding to include in TSR). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

