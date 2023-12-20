# SonicWallGen7.Api.DiagAdvancedDiagnosticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedDiagnosticsBaseGet**](DiagAdvancedDiagnosticsApi.md#diagadvanceddiagnosticsbaseget) | **GET** /diag/advanced/diagnostics/base |  |
| [**DiagAdvancedDiagnosticsBasePut**](DiagAdvancedDiagnosticsApi.md#diagadvanceddiagnosticsbaseput) | **PUT** /diag/advanced/diagnostics/base |  |

<a id="diagadvanceddiagnosticsbaseget"></a>
# **DiagAdvancedDiagnosticsBaseGet**
> DiagAdvancedDiagnostics DiagAdvancedDiagnosticsBaseGet ()



Retrieve advanced Diagnostics Config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedDiagnosticsBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedDiagnosticsApi(config);

            try
            {
                DiagAdvancedDiagnostics result = apiInstance.DiagAdvancedDiagnosticsBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedDiagnosticsApi.DiagAdvancedDiagnosticsBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedDiagnosticsBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedDiagnostics> response = apiInstance.DiagAdvancedDiagnosticsBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedDiagnosticsApi.DiagAdvancedDiagnosticsBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedDiagnostics**](DiagAdvancedDiagnostics.md)

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

<a id="diagadvanceddiagnosticsbaseput"></a>
# **DiagAdvancedDiagnosticsBasePut**
> ApiStatus DiagAdvancedDiagnosticsBasePut (DiagAdvancedDiagnostics? diagAdvancedDiagnostics = null)



Update advanced Diagnostics Config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedDiagnosticsBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedDiagnosticsApi(config);
            var diagAdvancedDiagnostics = new DiagAdvancedDiagnostics?(); // DiagAdvancedDiagnostics? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedDiagnosticsBasePut(diagAdvancedDiagnostics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedDiagnosticsApi.DiagAdvancedDiagnosticsBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedDiagnosticsBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedDiagnosticsBasePutWithHttpInfo(diagAdvancedDiagnostics);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedDiagnosticsApi.DiagAdvancedDiagnosticsBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedDiagnostics** | [**DiagAdvancedDiagnostics?**](DiagAdvancedDiagnostics?.md) |  | [optional]  |

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

