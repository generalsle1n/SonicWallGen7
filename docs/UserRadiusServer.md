# SonicWallGen7.Model.UserRadiusServer
user radius configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Set the RADIUS server&#39;s IP address or host name. | 
**Enable** | **bool** | Enable the RADIUS server. | [optional] 
**Port** | **decimal** | Set the RADIUS server&#39;s UDP port number. | [optional] 
**Partition** | **string** | Set the RADIUS server&#39;s user partition. | [optional] 
**SharedSecret** | **string** | Set the RADIUS server&#39;s shared secret. * Set to null to represent an unconfigured state. | [optional] 
**SendThroughVpnTunnel** | **bool** | Enable enforce send packet through vpn tunnel. | [optional] 
**UserNameFormat** | [**UserRadiusServerUserNameFormat**](UserRadiusServerUserNameFormat.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

