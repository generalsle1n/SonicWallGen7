# SonicWallGen7.Model.ReportingProfiles
Reporting profile settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Reporting profile name. | 
**Uuid** | **string** | Reporting profile UUID. | [optional] [readonly] 
**Frequency** | **decimal** | Set the frequency filter interval in seconds. | [optional] 
**LogMonitor** | **bool** | Enable display in Log Monitor. | [optional] 
**EmailAlert** | **bool** | Enable email alert. | [optional] 
**EmailAddress** | **string** | Set the email address to send alerts to. | [optional] 
**Syslog** | **bool** | Enable report events via Syslog. | [optional] 
**SyslogProfile** | **decimal** | Set syslog profile. | [optional] 
**Ipfix** | **bool** | Enable reporting of events via ipfix. | [optional] 
**Color** | [**ReportingProfilesColor**](ReportingProfilesColor.md) |  | [optional] 
**VarEvent** | [**ReportingProfilesEvent**](ReportingProfilesEvent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

