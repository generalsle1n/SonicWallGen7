# SonicWallGen7.Api.DosActionProfileCloneApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloneDosActionProfilesPut**](DosActionProfileCloneApi.md#clonedosactionprofilesput) | **PUT** /clone/dos-action-profiles |  |

<a id="clonedosactionprofilesput"></a>
# **CloneDosActionProfilesPut**
> ApiStatus CloneDosActionProfilesPut (DosActionProfileCloneCollection? dosActionProfileCloneCollection = null)



Clone existing dos action profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CloneDosActionProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileCloneApi(config);
            var dosActionProfileCloneCollection = new DosActionProfileCloneCollection?(); // DosActionProfileCloneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CloneDosActionProfilesPut(dosActionProfileCloneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileCloneApi.CloneDosActionProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloneDosActionProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CloneDosActionProfilesPutWithHttpInfo(dosActionProfileCloneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileCloneApi.CloneDosActionProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dosActionProfileCloneCollection** | [**DosActionProfileCloneCollection?**](DosActionProfileCloneCollection?.md) |  | [optional]  |

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

