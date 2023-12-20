# SonicWallGen7.Api.DiagAdvancedCtaReportApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedCtaReportGet**](DiagAdvancedCtaReportApi.md#diagadvancedctareportget) | **GET** /diag/advanced/cta-report |  |
| [**DiagAdvancedCtaReportPut**](DiagAdvancedCtaReportApi.md#diagadvancedctareportput) | **PUT** /diag/advanced/cta-report |  |

<a id="diagadvancedctareportget"></a>
# **DiagAdvancedCtaReportGet**
> DiagAdvancedCtaReport DiagAdvancedCtaReportGet ()



Get advanced diag capture threat assessment report configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedCtaReportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedCtaReportApi(config);

            try
            {
                DiagAdvancedCtaReport result = apiInstance.DiagAdvancedCtaReportGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedCtaReportApi.DiagAdvancedCtaReportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedCtaReportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedCtaReport> response = apiInstance.DiagAdvancedCtaReportGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedCtaReportApi.DiagAdvancedCtaReportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedCtaReport**](DiagAdvancedCtaReport.md)

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

<a id="diagadvancedctareportput"></a>
# **DiagAdvancedCtaReportPut**
> ApiStatus DiagAdvancedCtaReportPut (DiagAdvancedCtaReport? diagAdvancedCtaReport = null)



Update advanced diag capture threat assessment report configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedCtaReportPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedCtaReportApi(config);
            var diagAdvancedCtaReport = new DiagAdvancedCtaReport?(); // DiagAdvancedCtaReport? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedCtaReportPut(diagAdvancedCtaReport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedCtaReportApi.DiagAdvancedCtaReportPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedCtaReportPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedCtaReportPutWithHttpInfo(diagAdvancedCtaReport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedCtaReportApi.DiagAdvancedCtaReportPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedCtaReport** | [**DiagAdvancedCtaReport?**](DiagAdvancedCtaReport?.md) |  | [optional]  |

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

