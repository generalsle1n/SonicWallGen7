# SonicWallGen7.Api.SslVpnLogoutApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslVpnLogoutIPPost**](SslVpnLogoutApi.md#sslvpnlogoutippost) | **POST** /ssl-vpn/logout/{IP} |  |

<a id="sslvpnlogoutippost"></a>
# **SslVpnLogoutIPPost**
> ApiStatus SslVpnLogoutIPPost (string IP, Object? body = null)



Logout specified NetExtender virtual IP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnLogoutIPPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnLogoutApi(config);
            var IP = "\"192.168.168.168\"";  // string | NetExtender client virtual IP. (default to "192.168.168.168")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnLogoutIPPost(IP, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnLogoutApi.SslVpnLogoutIPPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnLogoutIPPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnLogoutIPPostWithHttpInfo(IP, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnLogoutApi.SslVpnLogoutIPPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | NetExtender client virtual IP. | [default to &quot;192.168.168.168&quot;] |
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

