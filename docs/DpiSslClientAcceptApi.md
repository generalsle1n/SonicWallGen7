# SonicWallGen7.Api.DpiSslClientAcceptApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DpiSslClientAcceptCNAMEPost**](DpiSslClientAcceptApi.md#dpisslclientacceptcnamepost) | **POST** /dpi-ssl/client/accept/{CNAME} |  |

<a id="dpisslclientacceptcnamepost"></a>
# **DpiSslClientAcceptCNAMEPost**
> ApiStatus DpiSslClientAcceptCNAMEPost (string CNAME, Object? body = null)



Accept DPI-SSL client build-in common name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslClientAcceptCNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientAcceptApi(config);
            var CNAME = "\"update.software.local\"";  // string | Client DPI-SSL common name (default to "update.software.local")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DpiSslClientAcceptCNAMEPost(CNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientAcceptApi.DpiSslClientAcceptCNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslClientAcceptCNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DpiSslClientAcceptCNAMEPostWithHttpInfo(CNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientAcceptApi.DpiSslClientAcceptCNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Client DPI-SSL common name | [default to &quot;update.software.local&quot;] |
| **body** | **Object?** |  | [optional]  |

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

