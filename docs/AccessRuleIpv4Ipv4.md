# SonicWallGen7.Model.AccessRuleIpv4Ipv4
IPv4 access rule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | Source zone. | 
**To** | **string** | Destination zone. | 
**Action** | **string** | Set the action for this access rule. | 
**Source** | [**AccessRuleIpv4Ipv4Source**](AccessRuleIpv4Ipv4Source.md) |  | 
**Service** | [**AccessRuleIpv4Ipv4Service**](AccessRuleIpv4Ipv4Service.md) |  | 
**Destination** | [**AccessRuleIpv4Ipv4Destination**](AccessRuleIpv4Ipv4Destination.md) |  | 
**Schedule** | [**AccessRuleIpv4Ipv4Schedule**](AccessRuleIpv4Ipv4Schedule.md) |  | 
**Users** | [**AccessRuleIpv4Ipv4Users**](AccessRuleIpv4Ipv4Users.md) |  | [optional] 
**Uuid** | **string** | Access rule UUID. | [optional] 
**Name** | **string** | Name of access rule. | [optional] 
**Comment** | **string** | Set comment to help identify this access rule. | [optional] 
**Enable** | **bool** | Enable this access rule. | [optional] 
**AutoRule** | **bool** | Indicate it is an auto rule. | [optional] 
**Reflexive** | **bool** | Configure a reflexive rule. | [optional] 
**MaxConnections** | **decimal** | Set the number of connections allowed (% maximum connections). | [optional] 
**Logging** | **bool** | Enable logging when this access rule is used. | [optional] 
**Sip** | **bool** | Enable SIP transformation. | [optional] 
**H323** | **bool** | Enable H.323 transformation. | [optional] 
**Management** | **bool** | Allow management traffic. | [optional] 
**PacketMonitoring** | **bool** | Enable packet monitoring. | [optional] 
**PacketDissectionFilter** | [**AccessRuleIpv4Ipv4PacketDissectionFilter**](AccessRuleIpv4Ipv4PacketDissectionFilter.md) |  | [optional] 
**Priority** | [**AccessRuleIpv4Ipv4Priority**](AccessRuleIpv4Ipv4Priority.md) |  | [optional] 
**Tcp** | [**AccessRuleIpv4Ipv4Tcp**](AccessRuleIpv4Ipv4Tcp.md) |  | [optional] 
**Udp** | [**SecurityActionProfilesUdp**](SecurityActionProfilesUdp.md) |  | [optional] 
**Fragments** | **bool** | Allow fragmented packets on this access rule. | [optional] 
**BotnetFilter** | **bool** | Enable Botnet filter. | [optional] 
**ConnectionLimit** | [**AccessRuleIpv4Ipv4ConnectionLimit**](AccessRuleIpv4Ipv4ConnectionLimit.md) |  | [optional] 
**Dpi** | **bool** | Enable DPI. | [optional] 
**DpiSsl** | [**AccessRuleIpv4Ipv4DpiSsl**](AccessRuleIpv4Ipv4DpiSsl.md) |  | [optional] 
**FlowReporting** | **bool** | Enable flow reporting. | [optional] 
**GeoIpFilter** | [**AccessRuleIpv4Ipv4GeoIpFilter**](AccessRuleIpv4Ipv4GeoIpFilter.md) |  | [optional] 
**Block** | [**AccessRuleIpv4Ipv4Block**](AccessRuleIpv4Ipv4Block.md) |  | [optional] 
**QualityOfService** | [**AccessRuleIpv4Ipv4QualityOfService**](AccessRuleIpv4Ipv4QualityOfService.md) |  | [optional] 
**CosOverride** | **bool** | Allow 802.1p marking to override DSCP values. | [optional] 
**BandwidthManagement** | [**AccessRuleIpv4Ipv4BandwidthManagement**](AccessRuleIpv4Ipv4BandwidthManagement.md) |  | [optional] 
**Ticket** | [**AccessRuleIpv4Ipv4Ticket**](AccessRuleIpv4Ipv4Ticket.md) |  | [optional] 
**SingleSignOn** | **bool** | Invoke single sign on to authenticate users. | [optional] 
**RedirectUnauthenticatedUsersToLogIn** | **bool** | Enable redirect unauthenticated users to log in. | [optional] 
**BlockTrafficForSingleSignOn** | **bool** | Block traffic while waiting for Single Sign On to authenticate users. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

