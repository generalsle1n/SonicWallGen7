# SonicWallGen7.Model.TcpTcpDdos
WAN DDOS protection.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OnWanInterfaces** | **bool** | Enable DDOS protection on WAN interfaces. | [optional] 
**Threshold** | **decimal** | Set threshold for WAN DDOS protection (non-TCP packets / sec). | [optional] 
**FliterBypassRate** | **decimal** | Set WAN DDOS filter bypass rate (every n packets). | [optional] 
**AllowListTimeout** | **decimal** | Set WAN DDOS allow list timeout. | [optional] 
**AlwaysAllowManagement** | **bool** | Enable always allow SonicWall management traffic (non-tcp floods). | [optional] 
**AlwaysAllowNegotiation** | **bool** | Enable always allow VPN negotiation traffic (non-tcp floods). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

