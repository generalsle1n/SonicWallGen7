# SonicWallGen7.Api.DpiSslClientDefaultExclusionsStatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDpiSslClientDefaultExclusionsStatusGet**](DpiSslClientDefaultExclusionsStatusApi.md#reportingdpisslclientdefaultexclusionsstatusget) | **GET** /reporting/dpi-ssl/client/default-exclusions-status |  |

<a id="reportingdpisslclientdefaultexclusionsstatusget"></a>
# **ReportingDpiSslClientDefaultExclusionsStatusGet**
> ShowStatusDpiSslClientDefaultExclusionsDetail ReportingDpiSslClientDefaultExclusionsStatusGet ()



Retrieve DPI-SSL client default exclusions status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDpiSslClientDefaultExclusionsStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientDefaultExclusionsStatusApi(config);

            try
            {
                ShowStatusDpiSslClientDefaultExclusionsDetail result = apiInstance.ReportingDpiSslClientDefaultExclusionsStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientDefaultExclusionsStatusApi.ReportingDpiSslClientDefaultExclusionsStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDpiSslClientDefaultExclusionsStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusDpiSslClientDefaultExclusionsDetail> response = apiInstance.ReportingDpiSslClientDefaultExclusionsStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientDefaultExclusionsStatusApi.ReportingDpiSslClientDefaultExclusionsStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusDpiSslClientDefaultExclusionsDetail**](ShowStatusDpiSslClientDefaultExclusionsDetail.md)

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

