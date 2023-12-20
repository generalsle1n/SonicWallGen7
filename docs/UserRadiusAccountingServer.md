# SonicWallGen7.Model.UserRadiusAccountingServer
user radius accounting server configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Set the RADIUS accounting server&#39;s IP address or host name. | 
**Enable** | **bool** | Enable the RADIUS accounting server. | [optional] 
**Port** | **decimal** | Set the RADIUS accounting server&#39;s UDP port number. | [optional] 
**SharedSecret** | **string** | Set the RADIUS accounting server&#39;s shared secret. * Set to null to represent an unconfigured state. | [optional] 
**Partition** | **string** | Set the RADIUS accounting server&#39;s user partition. * Set to null to represent an unconfigured state. | [optional] 
**UserNameFormat** | [**UserRadiusAccountingServerUserNameFormat**](UserRadiusAccountingServerUserNameFormat.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

