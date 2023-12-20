# SonicWallGen7.Api.AppflowGmsflowServer2TestConnectivityApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppflowGmsflowServerServer2IpTestConnectivityPost**](AppflowGmsflowServer2TestConnectivityApi.md#appflowgmsflowserverserver2iptestconnectivitypost) | **POST** /appflow/gmsflow-server/server-2-ip/test-connectivity |  |

<a id="appflowgmsflowserverserver2iptestconnectivitypost"></a>
# **AppflowGmsflowServerServer2IpTestConnectivityPost**
> ApiStatus AppflowGmsflowServerServer2IpTestConnectivityPost (Object? body = null)



Test connectivity of GMS flow server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppflowGmsflowServerServer2IpTestConnectivityPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppflowGmsflowServer2TestConnectivityApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppflowGmsflowServerServer2IpTestConnectivityPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppflowGmsflowServer2TestConnectivityApi.AppflowGmsflowServerServer2IpTestConnectivityPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppflowGmsflowServerServer2IpTestConnectivityPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppflowGmsflowServerServer2IpTestConnectivityPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppflowGmsflowServer2TestConnectivityApi.AppflowGmsflowServerServer2IpTestConnectivityPostWithHttpInfo: " + e.Message);
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

