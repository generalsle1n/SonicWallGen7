# SonicWallGen7.Api.InterfacesDisplayTrafficApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InterfacesDisplayAllTrafficGet**](InterfacesDisplayTrafficApi.md#interfacesdisplayalltrafficget) | **GET** /interfaces/display-all-traffic |  |
| [**InterfacesDisplayAllTrafficPut**](InterfacesDisplayTrafficApi.md#interfacesdisplayalltrafficput) | **PUT** /interfaces/display-all-traffic |  |

<a id="interfacesdisplayalltrafficget"></a>
# **InterfacesDisplayAllTrafficGet**
> InterfacesDisplayTraffic InterfacesDisplayAllTrafficGet ()



Retrieve interfaces display all traffic configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesDisplayAllTrafficGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfacesDisplayTrafficApi(config);

            try
            {
                InterfacesDisplayTraffic result = apiInstance.InterfacesDisplayAllTrafficGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfacesDisplayTrafficApi.InterfacesDisplayAllTrafficGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesDisplayAllTrafficGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfacesDisplayTraffic> response = apiInstance.InterfacesDisplayAllTrafficGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfacesDisplayTrafficApi.InterfacesDisplayAllTrafficGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InterfacesDisplayTraffic**](InterfacesDisplayTraffic.md)

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

<a id="interfacesdisplayalltrafficput"></a>
# **InterfacesDisplayAllTrafficPut**
> ApiStatus InterfacesDisplayAllTrafficPut (InterfacesDisplayTraffic? interfacesDisplayTraffic = null)



Update interfaces display all traffic configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesDisplayAllTrafficPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfacesDisplayTrafficApi(config);
            var interfacesDisplayTraffic = new InterfacesDisplayTraffic?(); // InterfacesDisplayTraffic? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesDisplayAllTrafficPut(interfacesDisplayTraffic);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfacesDisplayTrafficApi.InterfacesDisplayAllTrafficPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesDisplayAllTrafficPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesDisplayAllTrafficPutWithHttpInfo(interfacesDisplayTraffic);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfacesDisplayTrafficApi.InterfacesDisplayAllTrafficPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interfacesDisplayTraffic** | [**InterfacesDisplayTraffic?**](InterfacesDisplayTraffic?.md) |  | [optional]  |

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

