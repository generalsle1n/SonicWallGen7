# SonicWallGen7.Api.SslVpnServerAccessApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslVpnServerAccessesGet**](SslVpnServerAccessApi.md#sslvpnserveraccessesget) | **GET** /ssl-vpn/server/accesses |  |
| [**SslVpnServerAccessesPut**](SslVpnServerAccessApi.md#sslvpnserveraccessesput) | **PUT** /ssl-vpn/server/accesses |  |

<a id="sslvpnserveraccessesget"></a>
# **SslVpnServerAccessesGet**
> SslVpnServerAccessCollection SslVpnServerAccessesGet ()



Retrieve SSL VPN server accesses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnServerAccessesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnServerAccessApi(config);

            try
            {
                SslVpnServerAccessCollection result = apiInstance.SslVpnServerAccessesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnServerAccessApi.SslVpnServerAccessesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnServerAccessesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslVpnServerAccessCollection> response = apiInstance.SslVpnServerAccessesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnServerAccessApi.SslVpnServerAccessesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SslVpnServerAccessCollection**](SslVpnServerAccessCollection.md)

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

<a id="sslvpnserveraccessesput"></a>
# **SslVpnServerAccessesPut**
> ApiStatus SslVpnServerAccessesPut (SslVpnServerAccessCollection? sslVpnServerAccessCollection = null)



Update SSL VPN server accesses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnServerAccessesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnServerAccessApi(config);
            var sslVpnServerAccessCollection = new SslVpnServerAccessCollection?(); // SslVpnServerAccessCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnServerAccessesPut(sslVpnServerAccessCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnServerAccessApi.SslVpnServerAccessesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnServerAccessesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnServerAccessesPutWithHttpInfo(sslVpnServerAccessCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnServerAccessApi.SslVpnServerAccessesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslVpnServerAccessCollection** | [**SslVpnServerAccessCollection?**](SslVpnServerAccessCollection?.md) |  | [optional]  |

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

