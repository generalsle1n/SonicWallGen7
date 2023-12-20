# SonicWallGen7.Api.DpiSslClientCfsCategoriesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DpiSslClientCfsCategoriesGet**](DpiSslClientCfsCategoriesApi.md#dpisslclientcfscategoriesget) | **GET** /dpi-ssl/client/cfs-categories |  |
| [**DpiSslClientCfsCategoriesPost**](DpiSslClientCfsCategoriesApi.md#dpisslclientcfscategoriespost) | **POST** /dpi-ssl/client/cfs-categories |  |

<a id="dpisslclientcfscategoriesget"></a>
# **DpiSslClientCfsCategoriesGet**
> DpiSslClientCfsCategoriesCollection DpiSslClientCfsCategoriesGet ()



Retrieve DPI-SSL client content filter categories settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientCfsCategoriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientCfsCategoriesApi(config);

            try
            {
                DpiSslClientCfsCategoriesCollection result = apiInstance.DpiSslClientCfsCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientCfsCategoriesApi.DpiSslClientCfsCategoriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientCfsCategoriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DpiSslClientCfsCategoriesCollection> response = apiInstance.DpiSslClientCfsCategoriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientCfsCategoriesApi.DpiSslClientCfsCategoriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DpiSslClientCfsCategoriesCollection**](DpiSslClientCfsCategoriesCollection.md)

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

<a id="dpisslclientcfscategoriespost"></a>
# **DpiSslClientCfsCategoriesPost**
> ApiStatus DpiSslClientCfsCategoriesPost (DpiSslClientCfsCategoriesCollection? dpiSslClientCfsCategoriesCollection = null)



Add a content filter category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientCfsCategoriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientCfsCategoriesApi(config);
            var dpiSslClientCfsCategoriesCollection = new DpiSslClientCfsCategoriesCollection?(); // DpiSslClientCfsCategoriesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DpiSslClientCfsCategoriesPost(dpiSslClientCfsCategoriesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientCfsCategoriesApi.DpiSslClientCfsCategoriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientCfsCategoriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DpiSslClientCfsCategoriesPostWithHttpInfo(dpiSslClientCfsCategoriesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientCfsCategoriesApi.DpiSslClientCfsCategoriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dpiSslClientCfsCategoriesCollection** | [**DpiSslClientCfsCategoriesCollection?**](DpiSslClientCfsCategoriesCollection?.md) |  | [optional]  |

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

