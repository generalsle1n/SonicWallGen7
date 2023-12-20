# SonicWallGen7.Api.InterfaceRenewIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RenewIpv6NameIPV6NAMEPost**](InterfaceRenewIpv6Api.md#renewipv6nameipv6namepost) | **POST** /renew/ipv6/name/{IPV6NAME} |  |

<a id="renewipv6nameipv6namepost"></a>
# **RenewIpv6NameIPV6NAMEPost**
> ApiStatus RenewIpv6NameIPV6NAMEPost (string iPV6NAME, Object? body = null)



Renew specified IPv6 interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class RenewIpv6NameIPV6NAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceRenewIpv6Api(config);
            var iPV6NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.RenewIpv6NameIPV6NAMEPost(iPV6NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceRenewIpv6Api.RenewIpv6NameIPV6NAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenewIpv6NameIPV6NAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.RenewIpv6NameIPV6NAMEPostWithHttpInfo(iPV6NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceRenewIpv6Api.RenewIpv6NameIPV6NAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iPV6NAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
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

