# SonicWallGen7.Model.SecurityActionProfiles
Security action profiles settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of security action profile. | 
**Uuid** | **string** | Security action profile UUID. | [optional] [readonly] 
**BandwidthManagement** | [**SecurityActionProfilesBandwidthManagement**](SecurityActionProfilesBandwidthManagement.md) |  | [optional] 
**QualityOfService** | [**SecurityActionProfilesQualityOfService**](SecurityActionProfilesQualityOfService.md) |  | [optional] 
**CosOverride** | **bool** | Allow 802.1p marking to override DSCP values. | [optional] 
**GatewayAntivirus** | [**SecurityActionProfilesGatewayAntivirus**](SecurityActionProfilesGatewayAntivirus.md) |  | [optional] 
**Threat** | [**SecurityActionProfilesThreat**](SecurityActionProfilesThreat.md) |  | [optional] 
**AntiSpyware** | [**SecurityActionProfilesAntiSpyware**](SecurityActionProfilesAntiSpyware.md) |  | [optional] 
**Botnet** | [**SecurityActionProfilesBotnet**](SecurityActionProfilesBotnet.md) |  | [optional] 
**ContentFilter** | [**SecurityActionProfilesContentFilter**](SecurityActionProfilesContentFilter.md) |  | [optional] 
**Reporting** | [**SecurityActionProfilesReporting**](SecurityActionProfilesReporting.md) |  | [optional] 
**UserActions** | [**SecurityActionProfilesUserActions**](SecurityActionProfilesUserActions.md) |  | [optional] 
**Tcp** | [**SecurityActionProfilesTcp**](SecurityActionProfilesTcp.md) |  | [optional] 
**Udp** | [**SecurityActionProfilesUdp**](SecurityActionProfilesUdp.md) |  | [optional] 
**Fragments** | **bool** | Allow fragmented packets on this access rule. | [optional] 
**BypassServerToClientInspection** | **bool** | Enable bypass inspection of server to client packets. | [optional] 
**Sip** | **bool** | Enable SIP transformations. | [optional] 
**H323** | **bool** | Enable H.323 transformations. | [optional] 
**UnauthenticatedRedirect** | **bool** | Disable don&#39;t redirect unauthenticated users to log in. | [optional] 
**PacketDissectionFilter** | [**SecurityActionProfilesPacketDissectionFilter**](SecurityActionProfilesPacketDissectionFilter.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

