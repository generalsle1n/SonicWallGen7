# SonicWallGen7.Api.DnsSecurityTunnelApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsSecurityDnsTunnelBaseGet**](DnsSecurityTunnelApi.md#dnssecuritydnstunnelbaseget) | **GET** /dns-security/dns-tunnel/base |  |
| [**DnsSecurityDnsTunnelBasePut**](DnsSecurityTunnelApi.md#dnssecuritydnstunnelbaseput) | **PUT** /dns-security/dns-tunnel/base |  |

<a id="dnssecuritydnstunnelbaseget"></a>
# **DnsSecurityDnsTunnelBaseGet**
> DnsSecurityTunnel DnsSecurityDnsTunnelBaseGet ()



Retrieve DNS security tunnel configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsTunnelBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecurityTunnelApi(config);

            try
            {
                DnsSecurityTunnel result = apiInstance.DnsSecurityDnsTunnelBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecurityTunnelApi.DnsSecurityDnsTunnelBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsTunnelBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsSecurityTunnel> response = apiInstance.DnsSecurityDnsTunnelBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecurityTunnelApi.DnsSecurityDnsTunnelBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DnsSecurityTunnel**](DnsSecurityTunnel.md)

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

<a id="dnssecuritydnstunnelbaseput"></a>
# **DnsSecurityDnsTunnelBasePut**
> ApiStatus DnsSecurityDnsTunnelBasePut (DnsSecurityTunnel? dnsSecurityTunnel = null)



Update DNS security tunnel configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsTunnelBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecurityTunnelApi(config);
            var dnsSecurityTunnel = new DnsSecurityTunnel?(); // DnsSecurityTunnel? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSecurityDnsTunnelBasePut(dnsSecurityTunnel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecurityTunnelApi.DnsSecurityDnsTunnelBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsTunnelBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSecurityDnsTunnelBasePutWithHttpInfo(dnsSecurityTunnel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecurityTunnelApi.DnsSecurityDnsTunnelBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSecurityTunnel** | [**DnsSecurityTunnel?**](DnsSecurityTunnel?.md) |  | [optional]  |

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

