# SonicWallGen7.Api.InterfaceVlanIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InterfacesVlanIpv4Get**](InterfaceVlanIpv4Api.md#interfacesvlanipv4get) | **GET** /interfaces/vlan/ipv4 |  |
| [**InterfacesVlanIpv4ParentIFNAMEGet**](InterfaceVlanIpv4Api.md#interfacesvlanipv4parentifnameget) | **GET** /interfaces/vlan/ipv4/parent/{IFNAME} |  |

<a id="interfacesvlanipv4get"></a>
# **InterfacesVlanIpv4Get**
> InterfaceVlanIpv4Collection InterfacesVlanIpv4Get ()



Retrieve IPv4 vlan interfaces configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesVlanIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceVlanIpv4Api(config);

            try
            {
                InterfaceVlanIpv4Collection result = apiInstance.InterfacesVlanIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceVlanIpv4Api.InterfacesVlanIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesVlanIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfaceVlanIpv4Collection> response = apiInstance.InterfacesVlanIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceVlanIpv4Api.InterfacesVlanIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InterfaceVlanIpv4Collection**](InterfaceVlanIpv4Collection.md)

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

<a id="interfacesvlanipv4parentifnameget"></a>
# **InterfacesVlanIpv4ParentIFNAMEGet**
> InterfaceVlanIpv4Collection InterfacesVlanIpv4ParentIFNAMEGet (string IFNAME)



Retrieve IPv4 vlan interfaces configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class InterfacesVlanIpv4ParentIFNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceVlanIpv4Api(config);
            var IFNAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                InterfaceVlanIpv4Collection result = apiInstance.InterfacesVlanIpv4ParentIFNAMEGet(IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceVlanIpv4Api.InterfacesVlanIpv4ParentIFNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InterfacesVlanIpv4ParentIFNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InterfaceVlanIpv4Collection> response = apiInstance.InterfacesVlanIpv4ParentIFNAMEGetWithHttpInfo(IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceVlanIpv4Api.InterfacesVlanIpv4ParentIFNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IFNAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

### Return type

[**InterfaceVlanIpv4Collection**](InterfaceVlanIpv4Collection.md)

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

