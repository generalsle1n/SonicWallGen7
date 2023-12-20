# SonicWallGen7.Api.UserAuthBypassApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserAuthenticationRuleAuthBypassHttpUrlsGet**](UserAuthBypassApi.md#userauthenticationruleauthbypasshttpurlsget) | **GET** /user/authentication/rule-auth-bypass-http-urls |  |
| [**UserAuthenticationRuleAuthBypassHttpUrlsPost**](UserAuthBypassApi.md#userauthenticationruleauthbypasshttpurlspost) | **POST** /user/authentication/rule-auth-bypass-http-urls |  |

<a id="userauthenticationruleauthbypasshttpurlsget"></a>
# **UserAuthenticationRuleAuthBypassHttpUrlsGet**
> UserAuthBypassCollection UserAuthenticationRuleAuthBypassHttpUrlsGet ()



Retrieve user authentication bypass rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserAuthenticationRuleAuthBypassHttpUrlsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthBypassApi(config);

            try
            {
                UserAuthBypassCollection result = apiInstance.UserAuthenticationRuleAuthBypassHttpUrlsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthBypassApi.UserAuthenticationRuleAuthBypassHttpUrlsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthenticationRuleAuthBypassHttpUrlsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserAuthBypassCollection> response = apiInstance.UserAuthenticationRuleAuthBypassHttpUrlsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthBypassApi.UserAuthenticationRuleAuthBypassHttpUrlsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserAuthBypassCollection**](UserAuthBypassCollection.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userauthenticationruleauthbypasshttpurlspost"></a>
# **UserAuthenticationRuleAuthBypassHttpUrlsPost**
> ApiStatus UserAuthenticationRuleAuthBypassHttpUrlsPost (UserAuthBypassCollection? userAuthBypassCollection = null)



Create user authentication bypass rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserAuthenticationRuleAuthBypassHttpUrlsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthBypassApi(config);
            var userAuthBypassCollection = new UserAuthBypassCollection?(); // UserAuthBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserAuthenticationRuleAuthBypassHttpUrlsPost(userAuthBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthBypassApi.UserAuthenticationRuleAuthBypassHttpUrlsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthenticationRuleAuthBypassHttpUrlsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserAuthenticationRuleAuthBypassHttpUrlsPostWithHttpInfo(userAuthBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthBypassApi.UserAuthenticationRuleAuthBypassHttpUrlsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userAuthBypassCollection** | [**UserAuthBypassCollection?**](UserAuthBypassCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

