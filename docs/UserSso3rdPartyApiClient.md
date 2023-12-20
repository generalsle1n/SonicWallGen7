# SonicWallGen7.Model.UserSso3rdPartyApiClient
User SSO third party api client settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Set the 3rd party api client&#39;s host name or IP address. | 
**Enable** | **bool** | Enable the SSO third party API client. | [optional] 
**AuthenticationType** | **string** | Set authentication type for API client. | [optional] 
**Partition** | **string** | Set the API client&#39;s user partition. | [optional] 
**SharedSecret** | **string** | Set the shared secret for switch administration. | [optional] 
**SecurityLevel** | [**UserSso3rdPartyApiClientSecurityLevel**](UserSso3rdPartyApiClientSecurityLevel.md) |  | [optional] 
**ReplayPrevention** | **bool** | Enable CSRF/replay prevention. | [optional] 
**OriginRestriction** | [**UserSso3rdPartyApiClientOriginRestriction**](UserSso3rdPartyApiClientOriginRestriction.md) |  | [optional] 
**PersistentConnections** | **bool** | Enable allow persistent connections. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

