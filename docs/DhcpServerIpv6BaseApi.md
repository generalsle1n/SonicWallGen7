# SonicWallGen7.Api.DhcpServerIpv6BaseApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv6BaseGet**](DhcpServerIpv6BaseApi.md#dhcpserveripv6baseget) | **GET** /dhcp-server/ipv6/base |  |
| [**DhcpServerIpv6BasePut**](DhcpServerIpv6BaseApi.md#dhcpserveripv6baseput) | **PUT** /dhcp-server/ipv6/base |  |

<a id="dhcpserveripv6baseget"></a>
# **DhcpServerIpv6BaseGet**
> DhcpServerIpv6Base DhcpServerIpv6BaseGet ()



Retrieve DHCP server IPv6 base configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6BaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6BaseApi(config);

            try
            {
                DhcpServerIpv6Base result = apiInstance.DhcpServerIpv6BaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6BaseApi.DhcpServerIpv6BaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6BaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6Base> response = apiInstance.DhcpServerIpv6BaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6BaseApi.DhcpServerIpv6BaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerIpv6Base**](DhcpServerIpv6Base.md)

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

<a id="dhcpserveripv6baseput"></a>
# **DhcpServerIpv6BasePut**
> ApiStatus DhcpServerIpv6BasePut (DhcpServerIpv6Base? dhcpServerIpv6Base = null)



Update DHCP server IPv6 base configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6BasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6BaseApi(config);
            var dhcpServerIpv6Base = new DhcpServerIpv6Base?(); // DhcpServerIpv6Base? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6BasePut(dhcpServerIpv6Base);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6BaseApi.DhcpServerIpv6BasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6BasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6BasePutWithHttpInfo(dhcpServerIpv6Base);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6BaseApi.DhcpServerIpv6BasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6Base** | [**DhcpServerIpv6Base?**](DhcpServerIpv6Base?.md) |  | [optional]  |

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

