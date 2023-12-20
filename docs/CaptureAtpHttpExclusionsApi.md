# SonicWallGen7.Api.CaptureAtpHttpExclusionsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CaptureAtpHttpExclusionsGet**](CaptureAtpHttpExclusionsApi.md#captureatphttpexclusionsget) | **GET** /capture-atp/http-exclusions |  |
| [**CaptureAtpHttpExclusionsPost**](CaptureAtpHttpExclusionsApi.md#captureatphttpexclusionspost) | **POST** /capture-atp/http-exclusions |  |

<a id="captureatphttpexclusionsget"></a>
# **CaptureAtpHttpExclusionsGet**
> CaptureAtpHttpExclusionsCollection CaptureAtpHttpExclusionsGet ()



Retrieve capture ATP HTTP exclusions list settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CaptureAtpHttpExclusionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CaptureAtpHttpExclusionsApi(config);

            try
            {
                CaptureAtpHttpExclusionsCollection result = apiInstance.CaptureAtpHttpExclusionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureAtpHttpExclusionsApi.CaptureAtpHttpExclusionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureAtpHttpExclusionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CaptureAtpHttpExclusionsCollection> response = apiInstance.CaptureAtpHttpExclusionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureAtpHttpExclusionsApi.CaptureAtpHttpExclusionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CaptureAtpHttpExclusionsCollection**](CaptureAtpHttpExclusionsCollection.md)

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

<a id="captureatphttpexclusionspost"></a>
# **CaptureAtpHttpExclusionsPost**
> ApiStatus CaptureAtpHttpExclusionsPost (CaptureAtpHttpExclusionsCollection? captureAtpHttpExclusionsCollection = null)



Add an entry to the capture ATP HTTP exclusions list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CaptureAtpHttpExclusionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CaptureAtpHttpExclusionsApi(config);
            var captureAtpHttpExclusionsCollection = new CaptureAtpHttpExclusionsCollection?(); // CaptureAtpHttpExclusionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CaptureAtpHttpExclusionsPost(captureAtpHttpExclusionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureAtpHttpExclusionsApi.CaptureAtpHttpExclusionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureAtpHttpExclusionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CaptureAtpHttpExclusionsPostWithHttpInfo(captureAtpHttpExclusionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureAtpHttpExclusionsApi.CaptureAtpHttpExclusionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captureAtpHttpExclusionsCollection** | [**CaptureAtpHttpExclusionsCollection?**](CaptureAtpHttpExclusionsCollection?.md) |  | [optional]  |

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

