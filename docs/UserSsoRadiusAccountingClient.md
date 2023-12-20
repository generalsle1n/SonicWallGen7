# SonicWallGen7.Model.UserSsoRadiusAccountingClient
user sso configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Set the RADIUS accounting client&#39;s host name or IP address. | 
**SharedSecret** | **string** | Set the hexadecimal shared encryption key. | [optional] 
**UserNameFormat** | [**UserSsoRadiusAccountingClientUserNameFormat**](UserSsoRadiusAccountingClientUserNameFormat.md) |  | [optional] 
**CustomFormatComponents** | [**UserSsoRadiusAccountingClientCustomFormatComponents**](UserSsoRadiusAccountingClientCustomFormatComponents.md) |  | [optional] 
**MissingDomain** | [**UserSsoRadiusAccountingClientMissingDomain**](UserSsoRadiusAccountingClientMissingDomain.md) |  | [optional] 
**LogUserOutIfNoInterim** | [**UserSsoRadiusAccountingClientLogUserOutIfNoInterim**](UserSsoRadiusAccountingClientLogUserOutIfNoInterim.md) |  | [optional] 
**LogUserOutTimeout** | **decimal** | Log user out if no accounting interim updates are received                for the specified minutes. | [optional] 
**Server** | [**List&lt;UserSsoRadiusAccountingClientServerInner&gt;**](UserSsoRadiusAccountingClientServerInner.md) | Configure the server for receiving RADIUS accounting messages                forwarded from this client. | [optional] 
**ProxyForward** | [**UserSsoRadiusAccountingClientProxyForward**](UserSsoRadiusAccountingClientProxyForward.md) |  | [optional] 
**Partition** | **string** | Set the Radius Accounting client&#39;s user partition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

