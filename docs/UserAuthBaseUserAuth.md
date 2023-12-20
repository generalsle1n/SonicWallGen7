# SonicWallGen7.Model.UserAuthBaseUserAuth
Configure user authentication related settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaseSensitiveNames** | **bool** | Enable treating user names as case-sensitive. | [optional] 
**LoginUniqueness** | **bool** | Enable enforcing a single login per user name. | [optional] 
**ReloginAfterPasswordChange** | **bool** | Enable enforcing relogin after password change. | [optional] 
**DisplayLoginInfo** | **bool** | Display user login info since last login. | [optional] 
**OneTimePasswordConstraints** | **bool** | Enable One Time Password constraints. | [optional] 
**OneTimePassword** | [**UserAuthBaseUserAuthOneTimePassword**](UserAuthBaseUserAuthOneTimePassword.md) |  | [optional] 
**AuthPageTimeout** | **decimal?** | Set the timeout for showing the web login page. * Set to null to represent an unconfigured state. | [optional] 
**BrowserRedirectVia** | [**UserAuthBaseUserAuthBrowserRedirectVia**](UserAuthBaseUserAuthBrowserRedirectVia.md) |  | [optional] 
**RedirectToLoginPage** | [**UserAuthBaseUserAuthRedirectToLoginPage**](UserAuthBaseUserAuthRedirectToLoginPage.md) |  | [optional] 
**HttpRedirectAfterLogin** | **bool** | Enable redirect from HTTPS to HTTP after login. | [optional] 
**RedirectExternalPage** | **string** | Set the redirect to external login page on redirecting unauthenticated users. | [optional] 
**CombinedLogin** | [**UserAuthBaseUserAuthCombinedLogin**](UserAuthBaseUserAuthCombinedLogin.md) |  | [optional] 
**PolicyBannerBeforeLogin** | **bool** | Enable start with policy banner before login page. | [optional] 
**PolicyBanner** | [**UserAuthBaseUserAuthPolicyBanner**](UserAuthBaseUserAuthPolicyBanner.md) |  | [optional] 
**InactivityTimeout** | **decimal** | Set the user inactivity timeout(minutes). | [optional] 
**PreventInactivityLogout** | [**UserAuthBaseUserAuthPreventInactivityLogout**](UserAuthBaseUserAuthPreventInactivityLogout.md) |  | [optional] 
**LogUserName** | [**UserAuthBaseUserAuthLogUserName**](UserAuthBaseUserAuthLogUserName.md) |  | [optional] 
**UserConnectionsLogout** | [**UserAuthBaseUserAuthUserConnectionsLogout**](UserAuthBaseUserAuthUserConnectionsLogout.md) |  | [optional] 
**InactiveUser** | [**UserAuthBaseUserAuthInactiveUser**](UserAuthBaseUserAuthInactiveUser.md) |  | [optional] 
**AgeOut** | **decimal** | Set age out inactive users time (minutes). | [optional] 
**WebLoginSessionLimit** | **decimal?** | Set the maximum login session time for web users. * Set to null to represent an unconfigured state. | [optional] 
**ShowUserStatusWindow** | **bool** | Enable showing the status window after web login. | [optional] 
**StatusWindowHeartbeat** | [**UserAuthBaseUserAuthStatusWindowHeartbeat**](UserAuthBaseUserAuthStatusWindowHeartbeat.md) |  | [optional] 
**DisconnectedUserDetect** | **bool** | Enable detecting disconnected web users. | [optional] 
**OpenInSameWindow** | **bool** | Enable open user&#39;s login status window in the same window rather than in a popup. | [optional] 
**RadiusChapHttpLogin** | **bool** | Enable HTTP login with RADIUS CHAP mode when avail. | [optional] 
**AcceptableUsePolicy** | [**UserAuthBaseUserAuthAcceptableUsePolicy**](UserAuthBaseUserAuthAcceptableUsePolicy.md) |  | [optional] 
**CustomizeLoginPage** | [**UserAuthBaseUserAuthCustomizeLoginPage**](UserAuthBaseUserAuthCustomizeLoginPage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

