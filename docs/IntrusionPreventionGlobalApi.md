# SonicWallGen7.Api.IntrusionPreventionGlobalApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IntrusionPreventionBaseGet**](IntrusionPreventionGlobalApi.md#intrusionpreventionbaseget) | **GET** /intrusion-prevention/base |  |
| [**IntrusionPreventionBasePut**](IntrusionPreventionGlobalApi.md#intrusionpreventionbaseput) | **PUT** /intrusion-prevention/base |  |

<a id="intrusionpreventionbaseget"></a>
# **IntrusionPreventionBaseGet**
> IntrusionPreventionGlobal IntrusionPreventionBaseGet ()



Retrieve intrusion prevention global configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionGlobalApi(config);

            try
            {
                IntrusionPreventionGlobal result = apiInstance.IntrusionPreventionBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionGlobalApi.IntrusionPreventionBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionGlobal> response = apiInstance.IntrusionPreventionBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionGlobalApi.IntrusionPreventionBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IntrusionPreventionGlobal**](IntrusionPreventionGlobal.md)

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

<a id="intrusionpreventionbaseput"></a>
# **IntrusionPreventionBasePut**
> ApiStatus IntrusionPreventionBasePut (IntrusionPreventionGlobal? intrusionPreventionGlobal = null)



Update intrusion prevention global configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionGlobalApi(config);
            var intrusionPreventionGlobal = new IntrusionPreventionGlobal?(); // IntrusionPreventionGlobal? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionBasePut(intrusionPreventionGlobal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionGlobalApi.IntrusionPreventionBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionBasePutWithHttpInfo(intrusionPreventionGlobal);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionGlobalApi.IntrusionPreventionBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intrusionPreventionGlobal** | [**IntrusionPreventionGlobal?**](IntrusionPreventionGlobal?.md) |  | [optional]  |

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

