# SonicWallGen7.Api.VirtualAssistDenyRequestsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VirtualAssistDenyRequestsGet**](VirtualAssistDenyRequestsApi.md#virtualassistdenyrequestsget) | **GET** /virtual-assist/deny-requests |  |
| [**VirtualAssistDenyRequestsPost**](VirtualAssistDenyRequestsApi.md#virtualassistdenyrequestspost) | **POST** /virtual-assist/deny-requests |  |

<a id="virtualassistdenyrequestsget"></a>
# **VirtualAssistDenyRequestsGet**
> VirtualAssistDenyRequestsCollection VirtualAssistDenyRequestsGet ()



Retrieve virtual assist deny requests configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VirtualAssistDenyRequestsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VirtualAssistDenyRequestsApi(config);

            try
            {
                VirtualAssistDenyRequestsCollection result = apiInstance.VirtualAssistDenyRequestsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualAssistDenyRequestsApi.VirtualAssistDenyRequestsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualAssistDenyRequestsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VirtualAssistDenyRequestsCollection> response = apiInstance.VirtualAssistDenyRequestsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualAssistDenyRequestsApi.VirtualAssistDenyRequestsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VirtualAssistDenyRequestsCollection**](VirtualAssistDenyRequestsCollection.md)

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

<a id="virtualassistdenyrequestspost"></a>
# **VirtualAssistDenyRequestsPost**
> ApiStatus VirtualAssistDenyRequestsPost (VirtualAssistDenyRequestsCollection? virtualAssistDenyRequestsCollection = null)



Create a new virtual assist deny-request object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VirtualAssistDenyRequestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VirtualAssistDenyRequestsApi(config);
            var virtualAssistDenyRequestsCollection = new VirtualAssistDenyRequestsCollection?(); // VirtualAssistDenyRequestsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VirtualAssistDenyRequestsPost(virtualAssistDenyRequestsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VirtualAssistDenyRequestsApi.VirtualAssistDenyRequestsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VirtualAssistDenyRequestsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VirtualAssistDenyRequestsPostWithHttpInfo(virtualAssistDenyRequestsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VirtualAssistDenyRequestsApi.VirtualAssistDenyRequestsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **virtualAssistDenyRequestsCollection** | [**VirtualAssistDenyRequestsCollection?**](VirtualAssistDenyRequestsCollection?.md) |  | [optional]  |

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
