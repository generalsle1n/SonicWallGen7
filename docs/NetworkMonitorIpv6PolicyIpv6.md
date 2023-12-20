# SonicWallGen7.Model.NetworkMonitorIpv6PolicyIpv6
IPv6 network monitor policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Edit a network monitor policy name. | 
**Probe** | [**NetworkMonitorIpv6PolicyIpv6Probe**](NetworkMonitorIpv6PolicyIpv6Probe.md) |  | [optional] 
**OutboundInterface** | **string** | Set outbound interface. | [optional] 
**NextHop** | [**NetworkMonitorIpv6PolicyIpv6NextHop**](NetworkMonitorIpv6PolicyIpv6NextHop.md) |  | [optional] 
**LocalIp** | [**NetworkMonitorIpv6PolicyIpv6LocalIp**](NetworkMonitorIpv6PolicyIpv6LocalIp.md) |  | [optional] 
**ReplyTimeout** | **decimal** | Set probing reply timeout. | [optional] 
**Interval** | [**NetworkMonitorIpv4PolicyIpv4Interval**](NetworkMonitorIpv4PolicyIpv4Interval.md) |  | [optional] 
**MustRespond** | **bool** | Enable all hosts must respond. | [optional] 
**RstAsMiss** | **bool** | Enable RST response counts as miss. | [optional] 
**Uuid** | **string** | Network monitor UUID. | [optional] [readonly] 
**Comment** | **string** | Set network monitor policy comment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

