# SonicWallGen7.Api.DhcpOverVpnGlobalApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnDhcpOverVpnBaseGlobalGet**](DhcpOverVpnGlobalApi.md#vpndhcpovervpnbaseglobalget) | **GET** /vpn/dhcp-over-vpn/base/global |  |
| [**VpnDhcpOverVpnBaseGlobalPut**](DhcpOverVpnGlobalApi.md#vpndhcpovervpnbaseglobalput) | **PUT** /vpn/dhcp-over-vpn/base/global |  |

<a id="vpndhcpovervpnbaseglobalget"></a>
# **VpnDhcpOverVpnBaseGlobalGet**
> DhcpOverVpnGlobal VpnDhcpOverVpnBaseGlobalGet ()



Retrieve DHCP over VPN global base settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnBaseGlobalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnGlobalApi(config);

            try
            {
                DhcpOverVpnGlobal result = apiInstance.VpnDhcpOverVpnBaseGlobalGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnGlobalApi.VpnDhcpOverVpnBaseGlobalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnBaseGlobalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnGlobal> response = apiInstance.VpnDhcpOverVpnBaseGlobalGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnGlobalApi.VpnDhcpOverVpnBaseGlobalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpOverVpnGlobal**](DhcpOverVpnGlobal.md)

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

<a id="vpndhcpovervpnbaseglobalput"></a>
# **VpnDhcpOverVpnBaseGlobalPut**
> ApiStatus VpnDhcpOverVpnBaseGlobalPut (DhcpOverVpnGlobal? dhcpOverVpnGlobal = null)



Edit DHCP over VPN global base settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnBaseGlobalPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnGlobalApi(config);
            var dhcpOverVpnGlobal = new DhcpOverVpnGlobal?(); // DhcpOverVpnGlobal? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnBaseGlobalPut(dhcpOverVpnGlobal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnGlobalApi.VpnDhcpOverVpnBaseGlobalPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnBaseGlobalPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnBaseGlobalPutWithHttpInfo(dhcpOverVpnGlobal);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnGlobalApi.VpnDhcpOverVpnBaseGlobalPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnGlobal** | [**DhcpOverVpnGlobal?**](DhcpOverVpnGlobal?.md) |  | [optional]  |

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

