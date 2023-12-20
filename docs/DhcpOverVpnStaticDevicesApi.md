# SonicWallGen7.Api.DhcpOverVpnStaticDevicesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnDhcpOverVpnStaticDevicesGet**](DhcpOverVpnStaticDevicesApi.md#vpndhcpovervpnstaticdevicesget) | **GET** /vpn/dhcp-over-vpn/static-devices |  |
| [**VpnDhcpOverVpnStaticDevicesIpHOSTIPDelete**](DhcpOverVpnStaticDevicesApi.md#vpndhcpovervpnstaticdevicesiphostipdelete) | **DELETE** /vpn/dhcp-over-vpn/static-devices/ip/{HOSTIP} |  |
| [**VpnDhcpOverVpnStaticDevicesIpHOSTIPGet**](DhcpOverVpnStaticDevicesApi.md#vpndhcpovervpnstaticdevicesiphostipget) | **GET** /vpn/dhcp-over-vpn/static-devices/ip/{HOSTIP} |  |
| [**VpnDhcpOverVpnStaticDevicesIpHOSTIPPut**](DhcpOverVpnStaticDevicesApi.md#vpndhcpovervpnstaticdevicesiphostipput) | **PUT** /vpn/dhcp-over-vpn/static-devices/ip/{HOSTIP} |  |
| [**VpnDhcpOverVpnStaticDevicesPost**](DhcpOverVpnStaticDevicesApi.md#vpndhcpovervpnstaticdevicespost) | **POST** /vpn/dhcp-over-vpn/static-devices |  |
| [**VpnDhcpOverVpnStaticDevicesPut**](DhcpOverVpnStaticDevicesApi.md#vpndhcpovervpnstaticdevicesput) | **PUT** /vpn/dhcp-over-vpn/static-devices |  |

<a id="vpndhcpovervpnstaticdevicesget"></a>
# **VpnDhcpOverVpnStaticDevicesGet**
> DhcpOverVpnStaticDevicesCollection VpnDhcpOverVpnStaticDevicesGet ()



Retrieve DHCP over VPN static devices setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnStaticDevicesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnStaticDevicesApi(config);

            try
            {
                DhcpOverVpnStaticDevicesCollection result = apiInstance.VpnDhcpOverVpnStaticDevicesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnStaticDevicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnStaticDevicesCollection> response = apiInstance.VpnDhcpOverVpnStaticDevicesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpOverVpnStaticDevicesCollection**](DhcpOverVpnStaticDevicesCollection.md)

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

<a id="vpndhcpovervpnstaticdevicesiphostipdelete"></a>
# **VpnDhcpOverVpnStaticDevicesIpHOSTIPDelete**
> ApiStatus VpnDhcpOverVpnStaticDevicesIpHOSTIPDelete (string HOSTIP)



Delete a static device from dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnStaticDevicesIpHOSTIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnStaticDevicesApi(config);
            var HOSTIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnStaticDevicesIpHOSTIPDelete(HOSTIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesIpHOSTIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnStaticDevicesIpHOSTIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnStaticDevicesIpHOSTIPDeleteWithHttpInfo(HOSTIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesIpHOSTIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **HOSTIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

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

<a id="vpndhcpovervpnstaticdevicesiphostipget"></a>
# **VpnDhcpOverVpnStaticDevicesIpHOSTIPGet**
> DhcpOverVpnStaticDevicesCollection VpnDhcpOverVpnStaticDevicesIpHOSTIPGet (string HOSTIP)



Retrieve DHCP over VPN static devices setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnStaticDevicesIpHOSTIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnStaticDevicesApi(config);
            var HOSTIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                DhcpOverVpnStaticDevicesCollection result = apiInstance.VpnDhcpOverVpnStaticDevicesIpHOSTIPGet(HOSTIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesIpHOSTIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnStaticDevicesIpHOSTIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnStaticDevicesCollection> response = apiInstance.VpnDhcpOverVpnStaticDevicesIpHOSTIPGetWithHttpInfo(HOSTIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesIpHOSTIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **HOSTIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

### Return type

[**DhcpOverVpnStaticDevicesCollection**](DhcpOverVpnStaticDevicesCollection.md)

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

<a id="vpndhcpovervpnstaticdevicesiphostipput"></a>
# **VpnDhcpOverVpnStaticDevicesIpHOSTIPPut**
> ApiStatus VpnDhcpOverVpnStaticDevicesIpHOSTIPPut (string HOSTIP, DhcpOverVpnStaticDevicesCollection? dhcpOverVpnStaticDevicesCollection = null)



Edit a static device to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnStaticDevicesIpHOSTIPPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnStaticDevicesApi(config);
            var HOSTIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var dhcpOverVpnStaticDevicesCollection = new DhcpOverVpnStaticDevicesCollection?(); // DhcpOverVpnStaticDevicesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnStaticDevicesIpHOSTIPPut(HOSTIP, dhcpOverVpnStaticDevicesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesIpHOSTIPPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnStaticDevicesIpHOSTIPPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnStaticDevicesIpHOSTIPPutWithHttpInfo(HOSTIP, dhcpOverVpnStaticDevicesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesIpHOSTIPPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **HOSTIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **dhcpOverVpnStaticDevicesCollection** | [**DhcpOverVpnStaticDevicesCollection?**](DhcpOverVpnStaticDevicesCollection?.md) |  | [optional]  |

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

<a id="vpndhcpovervpnstaticdevicespost"></a>
# **VpnDhcpOverVpnStaticDevicesPost**
> ApiStatus VpnDhcpOverVpnStaticDevicesPost (DhcpOverVpnStaticDevicesCollection? dhcpOverVpnStaticDevicesCollection = null)



Add a static device to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnStaticDevicesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnStaticDevicesApi(config);
            var dhcpOverVpnStaticDevicesCollection = new DhcpOverVpnStaticDevicesCollection?(); // DhcpOverVpnStaticDevicesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnStaticDevicesPost(dhcpOverVpnStaticDevicesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnStaticDevicesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnStaticDevicesPostWithHttpInfo(dhcpOverVpnStaticDevicesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnStaticDevicesCollection** | [**DhcpOverVpnStaticDevicesCollection?**](DhcpOverVpnStaticDevicesCollection?.md) |  | [optional]  |

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

<a id="vpndhcpovervpnstaticdevicesput"></a>
# **VpnDhcpOverVpnStaticDevicesPut**
> ApiStatus VpnDhcpOverVpnStaticDevicesPut (DhcpOverVpnStaticDevicesCollection? dhcpOverVpnStaticDevicesCollection = null)



Edit a static device to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnStaticDevicesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnStaticDevicesApi(config);
            var dhcpOverVpnStaticDevicesCollection = new DhcpOverVpnStaticDevicesCollection?(); // DhcpOverVpnStaticDevicesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnStaticDevicesPut(dhcpOverVpnStaticDevicesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnStaticDevicesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnStaticDevicesPutWithHttpInfo(dhcpOverVpnStaticDevicesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnStaticDevicesApi.VpnDhcpOverVpnStaticDevicesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnStaticDevicesCollection** | [**DhcpOverVpnStaticDevicesCollection?**](DhcpOverVpnStaticDevicesCollection?.md) |  | [optional]  |

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

