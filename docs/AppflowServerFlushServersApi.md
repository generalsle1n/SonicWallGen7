# SonicWallGen7.Api.AppflowServerFlushServersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppflowAppflowServerFlushServersIpIPPost**](AppflowServerFlushServersApi.md#appflowappflowserverflushserversipippost) | **POST** /appflow/appflow-server/flush/servers/ip/{IP} |  |
| [**AppflowAppflowServerFlushServersPost**](AppflowServerFlushServersApi.md#appflowappflowserverflushserverspost) | **POST** /appflow/appflow-server/flush/servers |  |

<a id="appflowappflowserverflushserversipippost"></a>
# **AppflowAppflowServerFlushServersIpIPPost**
> ApiStatus AppflowAppflowServerFlushServersIpIPPost (string IP, Object? body = null)



Flush a specified or all discovered appflow servers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppflowAppflowServerFlushServersIpIPPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppflowServerFlushServersApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppflowAppflowServerFlushServersIpIPPost(IP, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppflowServerFlushServersApi.AppflowAppflowServerFlushServersIpIPPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppflowAppflowServerFlushServersIpIPPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppflowAppflowServerFlushServersIpIPPostWithHttpInfo(IP, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppflowServerFlushServersApi.AppflowAppflowServerFlushServersIpIPPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
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

<a id="appflowappflowserverflushserverspost"></a>
# **AppflowAppflowServerFlushServersPost**
> ApiStatus AppflowAppflowServerFlushServersPost (Object? body = null)



Flush a specified or all discovered appflow servers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppflowAppflowServerFlushServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppflowServerFlushServersApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppflowAppflowServerFlushServersPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppflowServerFlushServersApi.AppflowAppflowServerFlushServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppflowAppflowServerFlushServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppflowAppflowServerFlushServersPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppflowServerFlushServersApi.AppflowAppflowServerFlushServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

