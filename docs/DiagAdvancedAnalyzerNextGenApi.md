# SonicWallGen7.Api.DiagAdvancedAnalyzerNextGenApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedAnalyzerNextGenGet**](DiagAdvancedAnalyzerNextGenApi.md#diagadvancedanalyzernextgenget) | **GET** /diag/advanced/analyzer-next-gen |  |
| [**DiagAdvancedAnalyzerNextGenPut**](DiagAdvancedAnalyzerNextGenApi.md#diagadvancedanalyzernextgenput) | **PUT** /diag/advanced/analyzer-next-gen |  |

<a id="diagadvancedanalyzernextgenget"></a>
# **DiagAdvancedAnalyzerNextGenGet**
> DiagAdvancedAnalyzerNextGen DiagAdvancedAnalyzerNextGenGet ()



Retrieve advanced diag Analyzer Next Gen configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedAnalyzerNextGenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedAnalyzerNextGenApi(config);

            try
            {
                DiagAdvancedAnalyzerNextGen result = apiInstance.DiagAdvancedAnalyzerNextGenGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedAnalyzerNextGenApi.DiagAdvancedAnalyzerNextGenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedAnalyzerNextGenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedAnalyzerNextGen> response = apiInstance.DiagAdvancedAnalyzerNextGenGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedAnalyzerNextGenApi.DiagAdvancedAnalyzerNextGenGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedAnalyzerNextGen**](DiagAdvancedAnalyzerNextGen.md)

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

<a id="diagadvancedanalyzernextgenput"></a>
# **DiagAdvancedAnalyzerNextGenPut**
> ApiStatus DiagAdvancedAnalyzerNextGenPut (DiagAdvancedAnalyzerNextGen? diagAdvancedAnalyzerNextGen = null)



Update advanced diag Analyzer Next Gen configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedAnalyzerNextGenPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedAnalyzerNextGenApi(config);
            var diagAdvancedAnalyzerNextGen = new DiagAdvancedAnalyzerNextGen?(); // DiagAdvancedAnalyzerNextGen? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedAnalyzerNextGenPut(diagAdvancedAnalyzerNextGen);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedAnalyzerNextGenApi.DiagAdvancedAnalyzerNextGenPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedAnalyzerNextGenPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedAnalyzerNextGenPutWithHttpInfo(diagAdvancedAnalyzerNextGen);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedAnalyzerNextGenApi.DiagAdvancedAnalyzerNextGenPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedAnalyzerNextGen** | [**DiagAdvancedAnalyzerNextGen?**](DiagAdvancedAnalyzerNextGen?.md) |  | [optional]  |

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

