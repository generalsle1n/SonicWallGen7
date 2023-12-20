# SonicWallGen7.Api.DiagAdvancedNetworkFoLbApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedNetworkFoLbGet**](DiagAdvancedNetworkFoLbApi.md#diagadvancednetworkfolbget) | **GET** /diag/advanced/network-fo-lb |  |
| [**DiagAdvancedNetworkFoLbPut**](DiagAdvancedNetworkFoLbApi.md#diagadvancednetworkfolbput) | **PUT** /diag/advanced/network-fo-lb |  |

<a id="diagadvancednetworkfolbget"></a>
# **DiagAdvancedNetworkFoLbGet**
> DiagAdvancedNetworkFoLb DiagAdvancedNetworkFoLbGet ()



Retrieve advanced diag network failover and load balancing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedNetworkFoLbGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedNetworkFoLbApi(config);

            try
            {
                DiagAdvancedNetworkFoLb result = apiInstance.DiagAdvancedNetworkFoLbGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedNetworkFoLbApi.DiagAdvancedNetworkFoLbGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedNetworkFoLbGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedNetworkFoLb> response = apiInstance.DiagAdvancedNetworkFoLbGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedNetworkFoLbApi.DiagAdvancedNetworkFoLbGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedNetworkFoLb**](DiagAdvancedNetworkFoLb.md)

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

<a id="diagadvancednetworkfolbput"></a>
# **DiagAdvancedNetworkFoLbPut**
> ApiStatus DiagAdvancedNetworkFoLbPut (DiagAdvancedNetworkFoLb? diagAdvancedNetworkFoLb = null)



Update advanced diag network failover and load balancing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedNetworkFoLbPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedNetworkFoLbApi(config);
            var diagAdvancedNetworkFoLb = new DiagAdvancedNetworkFoLb?(); // DiagAdvancedNetworkFoLb? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedNetworkFoLbPut(diagAdvancedNetworkFoLb);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedNetworkFoLbApi.DiagAdvancedNetworkFoLbPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedNetworkFoLbPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedNetworkFoLbPutWithHttpInfo(diagAdvancedNetworkFoLb);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedNetworkFoLbApi.DiagAdvancedNetworkFoLbPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedNetworkFoLb** | [**DiagAdvancedNetworkFoLb?**](DiagAdvancedNetworkFoLb?.md) |  | [optional]  |

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

