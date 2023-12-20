# SonicWallGen7.Api.DiagAdvancedZeroTouchApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedZeroTouchBaseGet**](DiagAdvancedZeroTouchApi.md#diagadvancedzerotouchbaseget) | **GET** /diag/advanced/zero-touch/base |  |
| [**DiagAdvancedZeroTouchBasePut**](DiagAdvancedZeroTouchApi.md#diagadvancedzerotouchbaseput) | **PUT** /diag/advanced/zero-touch/base |  |

<a id="diagadvancedzerotouchbaseget"></a>
# **DiagAdvancedZeroTouchBaseGet**
> DiagAdvancedZeroTouch DiagAdvancedZeroTouchBaseGet ()



Retrieve advanced diag Zero Touch configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedZeroTouchBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedZeroTouchApi(config);

            try
            {
                DiagAdvancedZeroTouch result = apiInstance.DiagAdvancedZeroTouchBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedZeroTouchApi.DiagAdvancedZeroTouchBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedZeroTouchBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedZeroTouch> response = apiInstance.DiagAdvancedZeroTouchBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedZeroTouchApi.DiagAdvancedZeroTouchBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedZeroTouch**](DiagAdvancedZeroTouch.md)

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

<a id="diagadvancedzerotouchbaseput"></a>
# **DiagAdvancedZeroTouchBasePut**
> ApiStatus DiagAdvancedZeroTouchBasePut (DiagAdvancedZeroTouch? diagAdvancedZeroTouch = null)



Update advanced diag Zero Touch configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedZeroTouchBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedZeroTouchApi(config);
            var diagAdvancedZeroTouch = new DiagAdvancedZeroTouch?(); // DiagAdvancedZeroTouch? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedZeroTouchBasePut(diagAdvancedZeroTouch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedZeroTouchApi.DiagAdvancedZeroTouchBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedZeroTouchBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedZeroTouchBasePutWithHttpInfo(diagAdvancedZeroTouch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedZeroTouchApi.DiagAdvancedZeroTouchBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedZeroTouch** | [**DiagAdvancedZeroTouch?**](DiagAdvancedZeroTouch?.md) |  | [optional]  |

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

