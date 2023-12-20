# SonicWallGen7.Model.DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication
Configure advanced diag user authentication settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PostAuthenticationRedirectUrl** | **string** | Set post authentication user redirect URL. | [optional] 
**LogAllSsoAttempts** | [**DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationLogAllSsoAttempts**](DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationLogAllSsoAttempts.md) |  | [optional] 
**UserIp** | [**DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationUserIp**](DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationUserIp.md) |  | [optional] 
**IncludeSsoBypass** | **bool** | Enable inclusion of SSO bypass events in the SSO audit trail log. | [optional] 
**IncludeSsoPolling** | **bool** | Enable inclusion of polling events in the SSO audit trail log. | [optional] 
**IncludeAdditionalNonInitiation** | **bool** | Enable inclusion of additional non-initiation of SSO in the SSO audit trail log. | [optional] 
**SsoAgentVersionNegotiation** | **decimal** | Set version of SSO agent protocol to try to negotiate with. | [optional] 
**RedirectHttps** | **bool** | Enable redirecting unauthenticated HTTPS connections to the login page. | [optional] 
**HttpsRedirectPort** | **decimal** | Set the internal NAT TCP port number for HTTPS redirect. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

