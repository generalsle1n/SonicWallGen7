# SonicWallGen7.Model.LogSyslogServers
Log syslog servers settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**LogSyslogServersAddress**](LogSyslogServersAddress.md) |  | 
**Port** | **decimal?** | Syslog server port. * Set to null to represent an unconfigured state. | 
**Profile** | **decimal?** | Syslog server profile. * Set to null to represent an unconfigured state. | 
**Type** | **string** | Syslog server type. | [optional] 
**Facility** | **string** | Syslog server facility. | [optional] 
**Format** | **string** | Syslog server format. | [optional] 
**Id** | **string** | Syslog server ID. | [optional] 
**Enabled** | **bool** | Enable syslog server. | [optional] 
**EventRateLimiting** | [**LogSyslogServersEventRateLimiting**](LogSyslogServersEventRateLimiting.md) |  | [optional] 
**DataRateLimiting** | [**LogSyslogServersDataRateLimiting**](LogSyslogServersDataRateLimiting.md) |  | [optional] 
**OutboundInterface** | **string** | Outbound interface. | [optional] 
**LocalInterface** | **string** | local interface. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

