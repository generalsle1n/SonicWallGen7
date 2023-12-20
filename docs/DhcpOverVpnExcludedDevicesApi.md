# SonicWallGen7.Api.DhcpOverVpnExcludedDevicesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnDhcpOverVpnExcludedDevicesGet**](DhcpOverVpnExcludedDevicesApi.md#vpndhcpovervpnexcludeddevicesget) | **GET** /vpn/dhcp-over-vpn/excluded-devices |  |
| [**VpnDhcpOverVpnExcludedDevicesMacMACADDRDelete**](DhcpOverVpnExcludedDevicesApi.md#vpndhcpovervpnexcludeddevicesmacmacaddrdelete) | **DELETE** /vpn/dhcp-over-vpn/excluded-devices/mac/{MACADDR} |  |
| [**VpnDhcpOverVpnExcludedDevicesMacMACADDRGet**](DhcpOverVpnExcludedDevicesApi.md#vpndhcpovervpnexcludeddevicesmacmacaddrget) | **GET** /vpn/dhcp-over-vpn/excluded-devices/mac/{MACADDR} |  |
| [**VpnDhcpOverVpnExcludedDevicesMacMACADDRPut**](DhcpOverVpnExcludedDevicesApi.md#vpndhcpovervpnexcludeddevicesmacmacaddrput) | **PUT** /vpn/dhcp-over-vpn/excluded-devices/mac/{MACADDR} |  |
| [**VpnDhcpOverVpnExcludedDevicesPost**](DhcpOverVpnExcludedDevicesApi.md#vpndhcpovervpnexcludeddevicespost) | **POST** /vpn/dhcp-over-vpn/excluded-devices |  |
| [**VpnDhcpOverVpnExcludedDevicesPut**](DhcpOverVpnExcludedDevicesApi.md#vpndhcpovervpnexcludeddevicesput) | **PUT** /vpn/dhcp-over-vpn/excluded-devices |  |

<a id="vpndhcpovervpnexcludeddevicesget"></a>
# **VpnDhcpOverVpnExcludedDevicesGet**
> DhcpOverVpnExcludedDevicesCollection VpnDhcpOverVpnExcludedDevicesGet ()



Retrieve DHCP over VPN excluded devices setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnExcludedDevicesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnExcludedDevicesApi(config);

            try
            {
                DhcpOverVpnExcludedDevicesCollection result = apiInstance.VpnDhcpOverVpnExcludedDevicesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnExcludedDevicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnExcludedDevicesCollection> response = apiInstance.VpnDhcpOverVpnExcludedDevicesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpOverVpnExcludedDevicesCollection**](DhcpOverVpnExcludedDevicesCollection.md)

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

<a id="vpndhcpovervpnexcludeddevicesmacmacaddrdelete"></a>
# **VpnDhcpOverVpnExcludedDevicesMacMACADDRDelete**
> ApiStatus VpnDhcpOverVpnExcludedDevicesMacMACADDRDelete (string MACADDR)



Delete a excluded device from dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnExcludedDevicesMacMACADDRDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnExcludedDevicesApi(config);
            var MACADDR = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnExcludedDevicesMacMACADDRDelete(MACADDR);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesMacMACADDRDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnExcludedDevicesMacMACADDRDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnExcludedDevicesMacMACADDRDeleteWithHttpInfo(MACADDR);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesMacMACADDRDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **MACADDR** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vpndhcpovervpnexcludeddevicesmacmacaddrget"></a>
# **VpnDhcpOverVpnExcludedDevicesMacMACADDRGet**
> DhcpOverVpnExcludedDevicesCollection VpnDhcpOverVpnExcludedDevicesMacMACADDRGet (string MACADDR)



Retrieve DHCP over VPN excluded devices setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnExcludedDevicesMacMACADDRGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnExcludedDevicesApi(config);
            var MACADDR = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")

            try
            {
                DhcpOverVpnExcludedDevicesCollection result = apiInstance.VpnDhcpOverVpnExcludedDevicesMacMACADDRGet(MACADDR);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesMacMACADDRGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnExcludedDevicesMacMACADDRGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnExcludedDevicesCollection> response = apiInstance.VpnDhcpOverVpnExcludedDevicesMacMACADDRGetWithHttpInfo(MACADDR);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesMacMACADDRGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **MACADDR** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |

### Return type

[**DhcpOverVpnExcludedDevicesCollection**](DhcpOverVpnExcludedDevicesCollection.md)

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

<a id="vpndhcpovervpnexcludeddevicesmacmacaddrput"></a>
# **VpnDhcpOverVpnExcludedDevicesMacMACADDRPut**
> ApiStatus VpnDhcpOverVpnExcludedDevicesMacMACADDRPut (string MACADDR, DhcpOverVpnExcludedDevicesCollection? dhcpOverVpnExcludedDevicesCollection = null)



Edit a excluded device to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnExcludedDevicesMacMACADDRPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnExcludedDevicesApi(config);
            var MACADDR = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var dhcpOverVpnExcludedDevicesCollection = new DhcpOverVpnExcludedDevicesCollection?(); // DhcpOverVpnExcludedDevicesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnExcludedDevicesMacMACADDRPut(MACADDR, dhcpOverVpnExcludedDevicesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesMacMACADDRPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnExcludedDevicesMacMACADDRPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnExcludedDevicesMacMACADDRPutWithHttpInfo(MACADDR, dhcpOverVpnExcludedDevicesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesMacMACADDRPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **MACADDR** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **dhcpOverVpnExcludedDevicesCollection** | [**DhcpOverVpnExcludedDevicesCollection?**](DhcpOverVpnExcludedDevicesCollection?.md) |  | [optional]  |

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

<a id="vpndhcpovervpnexcludeddevicespost"></a>
# **VpnDhcpOverVpnExcludedDevicesPost**
> ApiStatus VpnDhcpOverVpnExcludedDevicesPost (DhcpOverVpnExcludedDevicesCollection? dhcpOverVpnExcludedDevicesCollection = null)



Add a excluded device to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnExcludedDevicesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnExcludedDevicesApi(config);
            var dhcpOverVpnExcludedDevicesCollection = new DhcpOverVpnExcludedDevicesCollection?(); // DhcpOverVpnExcludedDevicesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnExcludedDevicesPost(dhcpOverVpnExcludedDevicesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnExcludedDevicesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnExcludedDevicesPostWithHttpInfo(dhcpOverVpnExcludedDevicesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnExcludedDevicesCollection** | [**DhcpOverVpnExcludedDevicesCollection?**](DhcpOverVpnExcludedDevicesCollection?.md) |  | [optional]  |

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

<a id="vpndhcpovervpnexcludeddevicesput"></a>
# **VpnDhcpOverVpnExcludedDevicesPut**
> ApiStatus VpnDhcpOverVpnExcludedDevicesPut (DhcpOverVpnExcludedDevicesCollection? dhcpOverVpnExcludedDevicesCollection = null)



Edit a excluded device to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnExcludedDevicesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnExcludedDevicesApi(config);
            var dhcpOverVpnExcludedDevicesCollection = new DhcpOverVpnExcludedDevicesCollection?(); // DhcpOverVpnExcludedDevicesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnExcludedDevicesPut(dhcpOverVpnExcludedDevicesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnExcludedDevicesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnExcludedDevicesPutWithHttpInfo(dhcpOverVpnExcludedDevicesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnExcludedDevicesApi.VpnDhcpOverVpnExcludedDevicesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnExcludedDevicesCollection** | [**DhcpOverVpnExcludedDevicesCollection?**](DhcpOverVpnExcludedDevicesCollection?.md) |  | [optional]  |

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

