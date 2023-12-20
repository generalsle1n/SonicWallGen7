# SonicWallGen7.Api.UserSso3rdPartyApiBaseApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoThirdPartyApiBaseGet**](UserSso3rdPartyApiBaseApi.md#userssothirdpartyapibaseget) | **GET** /user/sso/third-party-api/base |  |
| [**UserSsoThirdPartyApiBasePut**](UserSso3rdPartyApiBaseApi.md#userssothirdpartyapibaseput) | **PUT** /user/sso/third-party-api/base |  |

<a id="userssothirdpartyapibaseget"></a>
# **UserSsoThirdPartyApiBaseGet**
> UserSso3rdPartyApiBase UserSsoThirdPartyApiBaseGet ()



User SSO third-party-api base settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiBaseApi(config);

            try
            {
                UserSso3rdPartyApiBase result = apiInstance.UserSsoThirdPartyApiBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiBaseApi.UserSsoThirdPartyApiBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSso3rdPartyApiBase> response = apiInstance.UserSsoThirdPartyApiBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiBaseApi.UserSsoThirdPartyApiBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSso3rdPartyApiBase**](UserSso3rdPartyApiBase.md)

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

<a id="userssothirdpartyapibaseput"></a>
# **UserSsoThirdPartyApiBasePut**
> ApiStatus UserSsoThirdPartyApiBasePut (UserSso3rdPartyApiBase? userSso3rdPartyApiBase = null)



Update User SSO third-party-api base settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiBaseApi(config);
            var userSso3rdPartyApiBase = new UserSso3rdPartyApiBase?(); // UserSso3rdPartyApiBase? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiBasePut(userSso3rdPartyApiBase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiBaseApi.UserSsoThirdPartyApiBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiBasePutWithHttpInfo(userSso3rdPartyApiBase);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiBaseApi.UserSsoThirdPartyApiBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSso3rdPartyApiBase** | [**UserSso3rdPartyApiBase?**](UserSso3rdPartyApiBase?.md) |  | [optional]  |

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

