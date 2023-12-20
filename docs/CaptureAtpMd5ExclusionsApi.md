# SonicWallGen7.Api.CaptureAtpMd5ExclusionsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CaptureAtpMd5ExclusionsGet**](CaptureAtpMd5ExclusionsApi.md#captureatpmd5exclusionsget) | **GET** /capture-atp/md5-exclusions |  |
| [**CaptureAtpMd5ExclusionsPost**](CaptureAtpMd5ExclusionsApi.md#captureatpmd5exclusionspost) | **POST** /capture-atp/md5-exclusions |  |

<a id="captureatpmd5exclusionsget"></a>
# **CaptureAtpMd5ExclusionsGet**
> CaptureAtpMd5ExclusionsCollection CaptureAtpMd5ExclusionsGet ()



Retrieve capture ATP MD5 exclusions list settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CaptureAtpMd5ExclusionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CaptureAtpMd5ExclusionsApi(config);

            try
            {
                CaptureAtpMd5ExclusionsCollection result = apiInstance.CaptureAtpMd5ExclusionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureAtpMd5ExclusionsApi.CaptureAtpMd5ExclusionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureAtpMd5ExclusionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CaptureAtpMd5ExclusionsCollection> response = apiInstance.CaptureAtpMd5ExclusionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureAtpMd5ExclusionsApi.CaptureAtpMd5ExclusionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CaptureAtpMd5ExclusionsCollection**](CaptureAtpMd5ExclusionsCollection.md)

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

<a id="captureatpmd5exclusionspost"></a>
# **CaptureAtpMd5ExclusionsPost**
> ApiStatus CaptureAtpMd5ExclusionsPost (CaptureAtpMd5ExclusionsCollection? captureAtpMd5ExclusionsCollection = null)



Add an entry to the capture ATP MD5 exclusions list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CaptureAtpMd5ExclusionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CaptureAtpMd5ExclusionsApi(config);
            var captureAtpMd5ExclusionsCollection = new CaptureAtpMd5ExclusionsCollection?(); // CaptureAtpMd5ExclusionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CaptureAtpMd5ExclusionsPost(captureAtpMd5ExclusionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureAtpMd5ExclusionsApi.CaptureAtpMd5ExclusionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureAtpMd5ExclusionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CaptureAtpMd5ExclusionsPostWithHttpInfo(captureAtpMd5ExclusionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureAtpMd5ExclusionsApi.CaptureAtpMd5ExclusionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captureAtpMd5ExclusionsCollection** | [**CaptureAtpMd5ExclusionsCollection?**](CaptureAtpMd5ExclusionsCollection?.md) |  | [optional]  |

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

