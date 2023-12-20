# SonicWallGen7.Model.LogSyslogLogSyslog
Syslog configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Set syslog ID for all the servers. | [optional] 
**Facility** | **string** | Set syslog facility for all the servers. | [optional] 
**Format** | **string** | Set syslog format for all the servers. | [optional] 
**EventRateLimiting** | [**LogSyslogLogSyslogEventRateLimiting**](LogSyslogLogSyslogEventRateLimiting.md) |  | [optional] 
**DisplayTimestampUtc** | **bool** | Enable display time stamp in UTC. | [optional] 
**DataRateLimiting** | [**LogSyslogLogSyslogDataRateLimiting**](LogSyslogLogSyslogDataRateLimiting.md) |  | [optional] 
**Enhanced** | [**LogSyslogLogSyslogEnhanced**](LogSyslogLogSyslogEnhanced.md) |  | [optional] 
**Arcsight** | [**LogSyslogLogSyslogArcsight**](LogSyslogLogSyslogArcsight.md) |  | [optional] 
**Ndpp** | **bool** | Enable NDPP enforcement for syslog server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

