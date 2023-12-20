# SonicWallGen7.Api.AppflowGmsflowServer2SynchronizeLogSettingsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppflowGmsflowServerServer2IpSynchronizeLogsPost**](AppflowGmsflowServer2SynchronizeLogSettingsApi.md#appflowgmsflowserverserver2ipsynchronizelogspost) | **POST** /appflow/gmsflow-server/server-2-ip/synchronize-logs |  |

<a id="appflowgmsflowserverserver2ipsynchronizelogspost"></a>
# **AppflowGmsflowServerServer2IpSynchronizeLogsPost**
> ApiStatus AppflowGmsflowServerServer2IpSynchronizeLogsPost (Object? body = null)



Send All Log Settings GMSFlow Server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppflowGmsflowServerServer2IpSynchronizeLogsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppflowGmsflowServer2SynchronizeLogSettingsApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppflowGmsflowServerServer2IpSynchronizeLogsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppflowGmsflowServer2SynchronizeLogSettingsApi.AppflowGmsflowServerServer2IpSynchronizeLogsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppflowGmsflowServerServer2IpSynchronizeLogsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppflowGmsflowServerServer2IpSynchronizeLogsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppflowGmsflowServer2SynchronizeLogSettingsApi.AppflowGmsflowServerServer2IpSynchronizeLogsPostWithHttpInfo: " + e.Message);
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

