# SonicWallGen7.Api.DhcpOverVpnBaseCentralApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnDhcpOverVpnBaseCentralGet**](DhcpOverVpnBaseCentralApi.md#vpndhcpovervpnbasecentralget) | **GET** /vpn/dhcp-over-vpn/base/central |  |
| [**VpnDhcpOverVpnBaseCentralPut**](DhcpOverVpnBaseCentralApi.md#vpndhcpovervpnbasecentralput) | **PUT** /vpn/dhcp-over-vpn/base/central |  |

<a id="vpndhcpovervpnbasecentralget"></a>
# **VpnDhcpOverVpnBaseCentralGet**
> DhcpOverVpnBaseCentral VpnDhcpOverVpnBaseCentralGet ()



Retrieve DHCP over VPN cantral gateway base settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnBaseCentralGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnBaseCentralApi(config);

            try
            {
                DhcpOverVpnBaseCentral result = apiInstance.VpnDhcpOverVpnBaseCentralGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnBaseCentralApi.VpnDhcpOverVpnBaseCentralGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnBaseCentralGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnBaseCentral> response = apiInstance.VpnDhcpOverVpnBaseCentralGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnBaseCentralApi.VpnDhcpOverVpnBaseCentralGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpOverVpnBaseCentral**](DhcpOverVpnBaseCentral.md)

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

<a id="vpndhcpovervpnbasecentralput"></a>
# **VpnDhcpOverVpnBaseCentralPut**
> ApiStatus VpnDhcpOverVpnBaseCentralPut (DhcpOverVpnBaseCentral? dhcpOverVpnBaseCentral = null)



Edit DHCP over VPN cantral gateway base settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnBaseCentralPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnBaseCentralApi(config);
            var dhcpOverVpnBaseCentral = new DhcpOverVpnBaseCentral?(); // DhcpOverVpnBaseCentral? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnBaseCentralPut(dhcpOverVpnBaseCentral);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnBaseCentralApi.VpnDhcpOverVpnBaseCentralPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnBaseCentralPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnBaseCentralPutWithHttpInfo(dhcpOverVpnBaseCentral);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnBaseCentralApi.VpnDhcpOverVpnBaseCentralPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnBaseCentral** | [**DhcpOverVpnBaseCentral?**](DhcpOverVpnBaseCentral?.md) |  | [optional]  |

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

