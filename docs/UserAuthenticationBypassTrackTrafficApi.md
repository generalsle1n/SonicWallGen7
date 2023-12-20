# SonicWallGen7.Api.UserAuthenticationBypassTrackTrafficApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserAuthenticationBypassTrackTrafficSOURCEIPPost**](UserAuthenticationBypassTrackTrafficApi.md#userauthenticationbypasstracktrafficsourceippost) | **POST** /user/authentication/bypass/track-traffic/{SOURCEIP} |  |

<a id="userauthenticationbypasstracktrafficsourceippost"></a>
# **UserAuthenticationBypassTrackTrafficSOURCEIPPost**
> ApiStatus UserAuthenticationBypassTrackTrafficSOURCEIPPost (string SOURCEIP, Object? body = null)



User authentication bypass track traffic.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserAuthenticationBypassTrackTrafficSOURCEIPPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserAuthenticationBypassTrackTrafficApi(config);
            var SOURCEIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserAuthenticationBypassTrackTrafficSOURCEIPPost(SOURCEIP, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAuthenticationBypassTrackTrafficApi.UserAuthenticationBypassTrackTrafficSOURCEIPPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAuthenticationBypassTrackTrafficSOURCEIPPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserAuthenticationBypassTrackTrafficSOURCEIPPostWithHttpInfo(SOURCEIP, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAuthenticationBypassTrackTrafficApi.UserAuthenticationBypassTrackTrafficSOURCEIPPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SOURCEIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **body** | **Object?** |  | [optional]  |

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

