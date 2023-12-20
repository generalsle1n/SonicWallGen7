# SonicWallGen7.Api.SecurityActionProfileCloneApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloneSecurityActionProfilesPut**](SecurityActionProfileCloneApi.md#clonesecurityactionprofilesput) | **PUT** /clone/security-action-profiles |  |

<a id="clonesecurityactionprofilesput"></a>
# **CloneSecurityActionProfilesPut**
> ApiStatus CloneSecurityActionProfilesPut (SecurityActionProfileCloneCollection? securityActionProfileCloneCollection = null)



Clone existing security action profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CloneSecurityActionProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityActionProfileCloneApi(config);
            var securityActionProfileCloneCollection = new SecurityActionProfileCloneCollection?(); // SecurityActionProfileCloneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CloneSecurityActionProfilesPut(securityActionProfileCloneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityActionProfileCloneApi.CloneSecurityActionProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloneSecurityActionProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CloneSecurityActionProfilesPutWithHttpInfo(securityActionProfileCloneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityActionProfileCloneApi.CloneSecurityActionProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityActionProfileCloneCollection** | [**SecurityActionProfileCloneCollection?**](SecurityActionProfileCloneCollection?.md) |  | [optional]  |

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

