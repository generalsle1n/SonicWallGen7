# SonicWallGen7.Model.NetworkMonitorIpv4PolicyIpv4
IPv4 network monitor policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Edit a network monitor policy name. | 
**Probe** | [**NetworkMonitorIpv4PolicyIpv4Probe**](NetworkMonitorIpv4PolicyIpv4Probe.md) |  | [optional] 
**OutboundInterface** | **string** | Set outbound interface. | [optional] 
**NextHop** | [**NetworkMonitorIpv4PolicyIpv4NextHop**](NetworkMonitorIpv4PolicyIpv4NextHop.md) |  | [optional] 
**LocalIp** | [**NetworkMonitorIpv4PolicyIpv4LocalIp**](NetworkMonitorIpv4PolicyIpv4LocalIp.md) |  | [optional] 
**ReplyTimeout** | **decimal** | Set probing reply timeout. | [optional] 
**Interval** | [**NetworkMonitorIpv4PolicyIpv4Interval**](NetworkMonitorIpv4PolicyIpv4Interval.md) |  | [optional] 
**MustRespond** | **bool** | Enable all hosts must respond. | [optional] 
**RstAsMiss** | **bool** | Enable RST response counts as miss. | [optional] 
**Uuid** | **string** | Network monitor UUID. | [optional] [readonly] 
**Comment** | **string** | Set network monitor policy comment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

