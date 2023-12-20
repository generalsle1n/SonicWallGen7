# SonicWallGen7.Api.ContentFilterCfsCustomCategoryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContentFilterCfsCustomCategoryBaseGet**](ContentFilterCfsCustomCategoryApi.md#contentfiltercfscustomcategorybaseget) | **GET** /content-filter/cfs/custom-category/base |  |
| [**ContentFilterCfsCustomCategoryBasePut**](ContentFilterCfsCustomCategoryApi.md#contentfiltercfscustomcategorybaseput) | **PUT** /content-filter/cfs/custom-category/base |  |

<a id="contentfiltercfscustomcategorybaseget"></a>
# **ContentFilterCfsCustomCategoryBaseGet**
> ContentFilterCfsCustomCategory ContentFilterCfsCustomCategoryBaseGet ()



Retrieve content filter cfs custom-category configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryApi(config);

            try
            {
                ContentFilterCfsCustomCategory result = apiInstance.ContentFilterCfsCustomCategoryBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryApi.ContentFilterCfsCustomCategoryBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterCfsCustomCategory> response = apiInstance.ContentFilterCfsCustomCategoryBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryApi.ContentFilterCfsCustomCategoryBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ContentFilterCfsCustomCategory**](ContentFilterCfsCustomCategory.md)

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

<a id="contentfiltercfscustomcategorybaseput"></a>
# **ContentFilterCfsCustomCategoryBasePut**
> ApiStatus ContentFilterCfsCustomCategoryBasePut (ContentFilterCfsCustomCategory? contentFilterCfsCustomCategory = null)



Update content filter cfs custom-category configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryApi(config);
            var contentFilterCfsCustomCategory = new ContentFilterCfsCustomCategory?(); // ContentFilterCfsCustomCategory? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryBasePut(contentFilterCfsCustomCategory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryApi.ContentFilterCfsCustomCategoryBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryBasePutWithHttpInfo(contentFilterCfsCustomCategory);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryApi.ContentFilterCfsCustomCategoryBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsCustomCategory** | [**ContentFilterCfsCustomCategory?**](ContentFilterCfsCustomCategory?.md) |  | [optional]  |

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

