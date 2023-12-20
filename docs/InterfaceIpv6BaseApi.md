# SonicWallGen7.Api.InterfaceIpv6BaseApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InterfacesIpv6BaseGet**](InterfaceIpv6BaseApi.md#interfacesipv6baseget) | **GET** /interfaces/ipv6/base |  |
| [**InterfacesIpv6BaseNameNAMEVlanVLANIDGet**](InterfaceIpv6BaseApi.md#interfacesipv6basenamenamevlanvlanidget) | **GET** /interfaces/ipv6/base/name/{NAME}/vlan/{VLANID} |  |
| [**InterfacesIpv6BaseNameNAMEVlanVLANIDPut**](InterfaceIpv6BaseApi.md#interfacesipv6basenamenamevlanvlanidput) | **PUT** /interfaces/ipv6/base/name/{NAME}/vlan/{VLANID} |  |
| [**InterfacesIpv6BasePut**](InterfaceIpv6BaseApi.md#interfacesipv6baseput) | **PUT** /interfaces/ipv6/base |  |

<a id="interfacesipv6baseget"></a>
# **InterfacesIpv6BaseGet**
> InterfaceIpv6BaseCollection InterfacesIpv6BaseGet ()



Retrieve IPv6 interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6BaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6BaseApi(config);

            try
            {
                InterfaceIpv6BaseCollection result = apiInstance.InterfacesIpv6BaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6BaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfaceIpv6BaseCollection> response = apiInstance.InterfacesIpv6BaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InterfaceIpv6BaseCollection**](InterfaceIpv6BaseCollection.md)

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

<a id="interfacesipv6basenamenamevlanvlanidget"></a>
# **InterfacesIpv6BaseNameNAMEVlanVLANIDGet**
> InterfaceIpv6BaseCollection InterfacesIpv6BaseNameNAMEVlanVLANIDGet (string NAME, decimal VLANID)



Retrieve IPv6 interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6BaseNameNAMEVlanVLANIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6BaseApi(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                InterfaceIpv6BaseCollection result = apiInstance.InterfacesIpv6BaseNameNAMEVlanVLANIDGet(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BaseNameNAMEVlanVLANIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6BaseNameNAMEVlanVLANIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfaceIpv6BaseCollection> response = apiInstance.InterfacesIpv6BaseNameNAMEVlanVLANIDGetWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BaseNameNAMEVlanVLANIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **VLANID** | **decimal** | VLAN tag. |  |

### Return type

[**InterfaceIpv6BaseCollection**](InterfaceIpv6BaseCollection.md)

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

<a id="interfacesipv6basenamenamevlanvlanidput"></a>
# **InterfacesIpv6BaseNameNAMEVlanVLANIDPut**
> ApiStatus InterfacesIpv6BaseNameNAMEVlanVLANIDPut (string NAME, decimal VLANID, InterfaceIpv6BaseCollection? interfaceIpv6BaseCollection = null)



Edit IPv6 interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6BaseNameNAMEVlanVLANIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6BaseApi(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.
            var interfaceIpv6BaseCollection = new InterfaceIpv6BaseCollection?(); // InterfaceIpv6BaseCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesIpv6BaseNameNAMEVlanVLANIDPut(NAME, VLANID, interfaceIpv6BaseCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BaseNameNAMEVlanVLANIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6BaseNameNAMEVlanVLANIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesIpv6BaseNameNAMEVlanVLANIDPutWithHttpInfo(NAME, VLANID, interfaceIpv6BaseCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BaseNameNAMEVlanVLANIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **VLANID** | **decimal** | VLAN tag. |  |
| **interfaceIpv6BaseCollection** | [**InterfaceIpv6BaseCollection?**](InterfaceIpv6BaseCollection?.md) |  | [optional]  |

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

<a id="interfacesipv6baseput"></a>
# **InterfacesIpv6BasePut**
> ApiStatus InterfacesIpv6BasePut (InterfaceIpv6BaseCollection? interfaceIpv6BaseCollection = null)



Edit IPv6 interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesIpv6BasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6BaseApi(config);
            var interfaceIpv6BaseCollection = new InterfaceIpv6BaseCollection?(); // InterfaceIpv6BaseCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.InterfacesIpv6BasePut(interfaceIpv6BaseCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesIpv6BasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.InterfacesIpv6BasePutWithHttpInfo(interfaceIpv6BaseCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6BaseApi.InterfacesIpv6BasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **interfaceIpv6BaseCollection** | [**InterfaceIpv6BaseCollection?**](InterfaceIpv6BaseCollection?.md) |  | [optional]  |

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

