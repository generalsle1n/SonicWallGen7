# SonicWallGen7.Api.InterfaceIpv6ExtraIpApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InterfacesIpv6ExtraIpGet**](InterfaceIpv6ExtraIpApi.md#interfacesipv6extraipget) | **GET** /interfaces/ipv6/extra-ip |  |
| [**InterfacesIpv6ExtraIpPatch**](InterfaceIpv6ExtraIpApi.md#interfacesipv6extraippatch) | **PATCH** /interfaces/ipv6/extra-ip |  |
| [**InterfacesIpv6ExtraIpPut**](InterfaceIpv6ExtraIpApi.md#interfacesipv6extraipput) | **PUT** /interfaces/ipv6/extra-ip |  |

<a id="interfacesipv6extraipget"></a>
# **InterfacesIpv6ExtraIpGet**
> InterfaceIpv6ExtraIpCollection InterfacesIpv6ExtraIpGet ()



Retrieve IPv6 interface extra IP configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6ExtraIpGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6ExtraIpApi(config);

            try
            {
                InterfaceIpv6ExtraIpCollection result = apiInstance.InterfacesIpv6ExtraIpGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6ExtraIpApi.InterfacesIpv6ExtraIpGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6ExtraIpGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfaceIpv6ExtraIpCollection> response = apiInstance.InterfacesIpv6ExtraIpGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6ExtraIpApi.InterfacesIpv6ExtraIpGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InterfaceIpv6ExtraIpCollection**](InterfaceIpv6ExtraIpCollection.md)

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

<a id="interfacesipv6extraippatch"></a>
# **InterfacesIpv6ExtraIpPatch**
> ApiStatus InterfacesIpv6ExtraIpPatch (InterfaceIpv6ExtraIpCollection? interfaceIpv6ExtraIpCollection = null)



Patch IPv6 interface extra IP configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6ExtraIpPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6ExtraIpApi(config);
            var interfaceIpv6ExtraIpCollection = new InterfaceIpv6ExtraIpCollection?(); // InterfaceIpv6ExtraIpCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesIpv6ExtraIpPatch(interfaceIpv6ExtraIpCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6ExtraIpApi.InterfacesIpv6ExtraIpPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6ExtraIpPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesIpv6ExtraIpPatchWithHttpInfo(interfaceIpv6ExtraIpCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6ExtraIpApi.InterfacesIpv6ExtraIpPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interfaceIpv6ExtraIpCollection** | [**InterfaceIpv6ExtraIpCollection?**](InterfaceIpv6ExtraIpCollection?.md) |  | [optional]  |

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

<a id="interfacesipv6extraipput"></a>
# **InterfacesIpv6ExtraIpPut**
> ApiStatus InterfacesIpv6ExtraIpPut (InterfaceIpv6ExtraIpCollection? interfaceIpv6ExtraIpCollection = null)



Edit IPv6 interface extra IP configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6ExtraIpPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6ExtraIpApi(config);
            var interfaceIpv6ExtraIpCollection = new InterfaceIpv6ExtraIpCollection?(); // InterfaceIpv6ExtraIpCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesIpv6ExtraIpPut(interfaceIpv6ExtraIpCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6ExtraIpApi.InterfacesIpv6ExtraIpPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6ExtraIpPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesIpv6ExtraIpPutWithHttpInfo(interfaceIpv6ExtraIpCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6ExtraIpApi.InterfacesIpv6ExtraIpPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interfaceIpv6ExtraIpCollection** | [**InterfaceIpv6ExtraIpCollection?**](InterfaceIpv6ExtraIpCollection?.md) |  | [optional]  |

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

