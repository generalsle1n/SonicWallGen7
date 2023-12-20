# SonicWallGen7.Api.AppflowServerDiscoverApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppflowAppflowServerDiscoverInterfaceIFIDPost**](AppflowServerDiscoverApi.md#appflowappflowserverdiscoverinterfaceifidpost) | **POST** /appflow/appflow-server/discover/interface/{IFID} |  |

<a id="appflowappflowserverdiscoverinterfaceifidpost"></a>
# **AppflowAppflowServerDiscoverInterfaceIFIDPost**
> ApiStatus AppflowAppflowServerDiscoverInterfaceIFIDPost (string IFID, Object? body = null)



Discover appflow servers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppflowAppflowServerDiscoverInterfaceIFIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppflowServerDiscoverApi(config);
            var IFID = "\"X0\"";  // string | Interface name. (default to "X0")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppflowAppflowServerDiscoverInterfaceIFIDPost(IFID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppflowServerDiscoverApi.AppflowAppflowServerDiscoverInterfaceIFIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppflowAppflowServerDiscoverInterfaceIFIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppflowAppflowServerDiscoverInterfaceIFIDPostWithHttpInfo(IFID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppflowServerDiscoverApi.AppflowAppflowServerDiscoverInterfaceIFIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IFID** | **string** | Interface name. | [default to &quot;X0&quot;] |
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

