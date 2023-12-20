# SonicWallGen7.Api.InterfaceReleaseIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReleaseIpv4NameIPV4NAMEPost**](InterfaceReleaseIpv4Api.md#releaseipv4nameipv4namepost) | **POST** /release/ipv4/name/{IPV4NAME} |  |

<a id="releaseipv4nameipv4namepost"></a>
# **ReleaseIpv4NameIPV4NAMEPost**
> ApiStatus ReleaseIpv4NameIPV4NAMEPost (string iPV4NAME, Object? body = null)



Release specified interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReleaseIpv4NameIPV4NAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceReleaseIpv4Api(config);
            var iPV4NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ReleaseIpv4NameIPV4NAMEPost(iPV4NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceReleaseIpv4Api.ReleaseIpv4NameIPV4NAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReleaseIpv4NameIPV4NAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReleaseIpv4NameIPV4NAMEPostWithHttpInfo(iPV4NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceReleaseIpv4Api.ReleaseIpv4NameIPV4NAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iPV4NAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
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

