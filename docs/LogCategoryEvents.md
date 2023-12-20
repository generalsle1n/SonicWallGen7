# SonicWallGen7.Model.LogCategoryEvents
Log events congifuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal** | ID. | 
**Name** | **string** | Name. | [optional] 
**Category** | **string** | Name. | [optional] 
**Group** | **string** | Name. | [optional] 
**PriorityLevel** | **string** | Set priority level. | [optional] 
**LogMonitor** | [**LogCategoryEventsLogMonitor**](LogCategoryEventsLogMonitor.md) |  | [optional] 
**EmailAlert** | [**LogCategoryEventsEmailAlert**](LogCategoryEventsEmailAlert.md) |  | [optional] 
**Syslog** | [**LogCategoryEventsSyslog**](LogCategoryEventsSyslog.md) |  | [optional] 
**EventProfile** | [**LogCategoryEventsEventProfile**](LogCategoryEventsEventProfile.md) |  | [optional] 
**Trap** | [**LogCategoryEventsTrap**](LogCategoryEventsTrap.md) |  | [optional] 
**OidName** | **string** | oid-name. | [optional] 
**TrapType** | **decimal** | trap-type. | [optional] 
**Ipfix** | [**LogCategoryEventsIpfix**](LogCategoryEventsIpfix.md) |  | [optional] 
**LogDigest** | **bool** | Include events in Log Digest. | [optional] 
**Color** | [**LogCategoryEventsColor**](LogCategoryEventsColor.md) |  | [optional] 
**AlertEmail** | [**LogCategoryEventsAlertEmail**](LogCategoryEventsAlertEmail.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

