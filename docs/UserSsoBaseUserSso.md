# SonicWallGen7.Model.UserSsoBaseUserSso
Configure SSO settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | [**UserSsoBaseUserSsoMethod**](UserSsoBaseUserSsoMethod.md) |  | [optional] 
**NextAgentOnNoName** | **bool** | Enable try next agent on getting no name from NetAPI/WMI. | [optional] 
**BlockTraffic** | **bool** | Block user traffic while waiting for SSO. | [optional] 
**IncludingForAccessRules** | [**UserSsoBaseUserSsoIncludingForAccessRules**](UserSsoBaseUserSsoIncludingForAccessRules.md) |  | [optional] 
**SyncAllAgentsUserDb** | **bool** | Sync all agents when agent synchronize their user databases. | [optional] 
**LocalUsersOnly** | **bool** | Allow only SSO users with local accounts. | [optional] 
**NonDomainLimitedAccess** | **bool** | Allow limited access for non-domain users. | [optional] 
**Probe** | [**UserSsoBaseUserSsoProbe**](UserSsoBaseUserSsoProbe.md) |  | [optional] 
**ForwardLanman** | **bool** | Enable forward legacy LanMan in NTLM. | [optional] 
**TsaServicesBypass** | **bool** | Terminal server services can bypass auth in rules. | [optional] 
**UserGroupMechanism** | [**UserSsoBaseUserSsoUserGroupMechanism**](UserSsoBaseUserSsoUserGroupMechanism.md) |  | [optional] 
**Poll** | [**UserSsoBaseUserSsoPoll**](UserSsoBaseUserSsoPoll.md) |  | [optional] 
**HoldTime** | [**UserSsoBaseUserSsoHoldTime**](UserSsoBaseUserSsoHoldTime.md) |  | [optional] 
**RampUp** | [**UserSsoBaseUserSsoRampUp**](UserSsoBaseUserSsoRampUp.md) |  | [optional] 
**UserDomainName** | [**UserSsoBaseUserSsoUserDomainName**](UserSsoBaseUserSsoUserDomainName.md) |  | [optional] 
**BypassPolicy** | [**UserSsoBaseUserSsoBypassPolicy**](UserSsoBaseUserSsoBypassPolicy.md) |  | [optional] 
**LogUserName** | **string** | Log user name for SSO bypasses. | [optional] 
**DummyUser** | [**UserSsoBaseUserSsoDummyUser**](UserSsoBaseUserSsoDummyUser.md) |  | [optional] 
**RadiusAccountingPort** | **decimal** | Set the RADIUS accounting&#39;s UDP port number. | [optional] 
**RadiusAcctLookupMechanism** | **string** | Mechanism for looking up user group memberships for RADIUS Accounting users. | [optional] 
**SwitchOverTime** | **decimal** | Set maximum switch-over time. | [optional] 
**IgnoreTransitionMessage** | **bool** | Ignore transition message sequence/source(s). | [optional] 
**IgnoreAddr** | [**UserSsoBaseUserSsoIgnoreAddr**](UserSsoBaseUserSsoIgnoreAddr.md) |  | [optional] 
**IncludeAddr** | [**UserSsoBaseUserSsoIncludeAddr**](UserSsoBaseUserSsoIncludeAddr.md) |  | [optional] 
**RetriesOnFailure** | **decimal** | Set maximum retries to allow on authentication failure. | [optional] 
**AuthenticationDomain** | [**UserSsoBaseUserSsoAuthenticationDomain**](UserSsoBaseUserSsoAuthenticationDomain.md) |  | [optional] 
**RedirectBrowser** | [**UserSsoBaseUserSsoRedirectBrowser**](UserSsoBaseUserSsoRedirectBrowser.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

