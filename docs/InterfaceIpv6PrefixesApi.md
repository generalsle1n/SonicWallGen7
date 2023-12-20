# SonicWallGen7.Api.InterfaceIpv6PrefixesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InterfacesIpv6PrefixesGet**](InterfaceIpv6PrefixesApi.md#interfacesipv6prefixesget) | **GET** /interfaces/ipv6/prefixes |  |
| [**InterfacesIpv6PrefixesPatch**](InterfaceIpv6PrefixesApi.md#interfacesipv6prefixespatch) | **PATCH** /interfaces/ipv6/prefixes |  |
| [**InterfacesIpv6PrefixesPut**](InterfaceIpv6PrefixesApi.md#interfacesipv6prefixesput) | **PUT** /interfaces/ipv6/prefixes |  |

<a id="interfacesipv6prefixesget"></a>
# **InterfacesIpv6PrefixesGet**
> InterfaceIpv6PrefixesCollection InterfacesIpv6PrefixesGet ()



Retrieve IPv6 interface prefixes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6PrefixesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6PrefixesApi(config);

            try
            {
                InterfaceIpv6PrefixesCollection result = apiInstance.InterfacesIpv6PrefixesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6PrefixesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfaceIpv6PrefixesCollection> response = apiInstance.InterfacesIpv6PrefixesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InterfaceIpv6PrefixesCollection**](InterfaceIpv6PrefixesCollection.md)

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

<a id="interfacesipv6prefixespatch"></a>
# **InterfacesIpv6PrefixesPatch**
> ApiStatus InterfacesIpv6PrefixesPatch (InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = null)



Patch IPv6 interface prefixes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6PrefixesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6PrefixesApi(config);
            var interfaceIpv6PrefixesCollection = new InterfaceIpv6PrefixesCollection?(); // InterfaceIpv6PrefixesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesIpv6PrefixesPatch(interfaceIpv6PrefixesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6PrefixesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesIpv6PrefixesPatchWithHttpInfo(interfaceIpv6PrefixesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interfaceIpv6PrefixesCollection** | [**InterfaceIpv6PrefixesCollection?**](InterfaceIpv6PrefixesCollection?.md) |  | [optional]  |

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

<a id="interfacesipv6prefixesput"></a>
# **InterfacesIpv6PrefixesPut**
> ApiStatus InterfacesIpv6PrefixesPut (InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = null)



Edit IPv6 interface prefixes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6PrefixesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6PrefixesApi(config);
            var interfaceIpv6PrefixesCollection = new InterfaceIpv6PrefixesCollection?(); // InterfaceIpv6PrefixesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesIpv6PrefixesPut(interfaceIpv6PrefixesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6PrefixesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesIpv6PrefixesPutWithHttpInfo(interfaceIpv6PrefixesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interfaceIpv6PrefixesCollection** | [**InterfaceIpv6PrefixesCollection?**](InterfaceIpv6PrefixesCollection?.md) |  | [optional]  |

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

