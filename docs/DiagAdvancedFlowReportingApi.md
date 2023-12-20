# SonicWallGen7.Api.DiagAdvancedFlowReportingApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedFlowReportingBaseGet**](DiagAdvancedFlowReportingApi.md#diagadvancedflowreportingbaseget) | **GET** /diag/advanced/flow-reporting/base |  |
| [**DiagAdvancedFlowReportingBasePut**](DiagAdvancedFlowReportingApi.md#diagadvancedflowreportingbaseput) | **PUT** /diag/advanced/flow-reporting/base |  |

<a id="diagadvancedflowreportingbaseget"></a>
# **DiagAdvancedFlowReportingBaseGet**
> DiagAdvancedFlowReporting DiagAdvancedFlowReportingBaseGet ()



Retrieve advanced diag flow-reporting Configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedFlowReportingBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedFlowReportingApi(config);

            try
            {
                DiagAdvancedFlowReporting result = apiInstance.DiagAdvancedFlowReportingBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedFlowReportingApi.DiagAdvancedFlowReportingBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedFlowReportingBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedFlowReporting> response = apiInstance.DiagAdvancedFlowReportingBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedFlowReportingApi.DiagAdvancedFlowReportingBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedFlowReporting**](DiagAdvancedFlowReporting.md)

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

<a id="diagadvancedflowreportingbaseput"></a>
# **DiagAdvancedFlowReportingBasePut**
> ApiStatus DiagAdvancedFlowReportingBasePut (DiagAdvancedFlowReporting? diagAdvancedFlowReporting = null)



Update advanced diag flow-reporting Configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedFlowReportingBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedFlowReportingApi(config);
            var diagAdvancedFlowReporting = new DiagAdvancedFlowReporting?(); // DiagAdvancedFlowReporting? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedFlowReportingBasePut(diagAdvancedFlowReporting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedFlowReportingApi.DiagAdvancedFlowReportingBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedFlowReportingBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedFlowReportingBasePutWithHttpInfo(diagAdvancedFlowReporting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedFlowReportingApi.DiagAdvancedFlowReportingBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedFlowReporting** | [**DiagAdvancedFlowReporting?**](DiagAdvancedFlowReporting?.md) |  | [optional]  |

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

