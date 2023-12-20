# SonicWallGen7.Api.CustomMatchGroupCloneApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloneCustomMatchGroupsPut**](CustomMatchGroupCloneApi.md#clonecustommatchgroupsput) | **PUT** /clone/custom-match-groups |  |

<a id="clonecustommatchgroupsput"></a>
# **CloneCustomMatchGroupsPut**
> ApiStatus CloneCustomMatchGroupsPut (CustomMatchGroupCloneCollection? customMatchGroupCloneCollection = null)



Clone existing custom match groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CloneCustomMatchGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomMatchGroupCloneApi(config);
            var customMatchGroupCloneCollection = new CustomMatchGroupCloneCollection?(); // CustomMatchGroupCloneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CloneCustomMatchGroupsPut(customMatchGroupCloneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMatchGroupCloneApi.CloneCustomMatchGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloneCustomMatchGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CloneCustomMatchGroupsPutWithHttpInfo(customMatchGroupCloneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMatchGroupCloneApi.CloneCustomMatchGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customMatchGroupCloneCollection** | [**CustomMatchGroupCloneCollection?**](CustomMatchGroupCloneCollection?.md) |  | [optional]  |

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

