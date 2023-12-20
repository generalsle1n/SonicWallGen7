# SonicWallGen7.Api.DiagAdvancedDialUpApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedDialUpBaseGet**](DiagAdvancedDialUpApi.md#diagadvanceddialupbaseget) | **GET** /diag/advanced/dial-up/base |  |
| [**DiagAdvancedDialUpBasePut**](DiagAdvancedDialUpApi.md#diagadvanceddialupbaseput) | **PUT** /diag/advanced/dial-up/base |  |

<a id="diagadvanceddialupbaseget"></a>
# **DiagAdvancedDialUpBaseGet**
> DiagAdvancedDialUp DiagAdvancedDialUpBaseGet ()



Retrieve advanced diag dial-up configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedDialUpBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedDialUpApi(config);

            try
            {
                DiagAdvancedDialUp result = apiInstance.DiagAdvancedDialUpBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedDialUpApi.DiagAdvancedDialUpBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedDialUpBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedDialUp> response = apiInstance.DiagAdvancedDialUpBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedDialUpApi.DiagAdvancedDialUpBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedDialUp**](DiagAdvancedDialUp.md)

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

<a id="diagadvanceddialupbaseput"></a>
# **DiagAdvancedDialUpBasePut**
> ApiStatus DiagAdvancedDialUpBasePut (DiagAdvancedDialUp? diagAdvancedDialUp = null)



Update advanced diag dial-up configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedDialUpBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedDialUpApi(config);
            var diagAdvancedDialUp = new DiagAdvancedDialUp?(); // DiagAdvancedDialUp? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedDialUpBasePut(diagAdvancedDialUp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedDialUpApi.DiagAdvancedDialUpBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedDialUpBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedDialUpBasePutWithHttpInfo(diagAdvancedDialUp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedDialUpApi.DiagAdvancedDialUpBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedDialUp** | [**DiagAdvancedDialUp?**](DiagAdvancedDialUp?.md) |  | [optional]  |

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

