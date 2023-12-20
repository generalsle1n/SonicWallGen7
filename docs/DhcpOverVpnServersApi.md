# SonicWallGen7.Api.DhcpOverVpnServersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnDhcpOverVpnDhcpServersGet**](DhcpOverVpnServersApi.md#vpndhcpovervpndhcpserversget) | **GET** /vpn/dhcp-over-vpn/dhcp-servers |  |
| [**VpnDhcpOverVpnDhcpServersIpHOSTIPDelete**](DhcpOverVpnServersApi.md#vpndhcpovervpndhcpserversiphostipdelete) | **DELETE** /vpn/dhcp-over-vpn/dhcp-servers/ip/{HOSTIP} |  |
| [**VpnDhcpOverVpnDhcpServersIpHOSTIPGet**](DhcpOverVpnServersApi.md#vpndhcpovervpndhcpserversiphostipget) | **GET** /vpn/dhcp-over-vpn/dhcp-servers/ip/{HOSTIP} |  |
| [**VpnDhcpOverVpnDhcpServersIpHOSTIPPut**](DhcpOverVpnServersApi.md#vpndhcpovervpndhcpserversiphostipput) | **PUT** /vpn/dhcp-over-vpn/dhcp-servers/ip/{HOSTIP} |  |
| [**VpnDhcpOverVpnDhcpServersPost**](DhcpOverVpnServersApi.md#vpndhcpovervpndhcpserverspost) | **POST** /vpn/dhcp-over-vpn/dhcp-servers |  |
| [**VpnDhcpOverVpnDhcpServersPut**](DhcpOverVpnServersApi.md#vpndhcpovervpndhcpserversput) | **PUT** /vpn/dhcp-over-vpn/dhcp-servers |  |

<a id="vpndhcpovervpndhcpserversget"></a>
# **VpnDhcpOverVpnDhcpServersGet**
> DhcpOverVpnServersCollection VpnDhcpOverVpnDhcpServersGet ()



Retrieve DHCP over VPN DHCP servers setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnDhcpServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnServersApi(config);

            try
            {
                DhcpOverVpnServersCollection result = apiInstance.VpnDhcpOverVpnDhcpServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnDhcpServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnServersCollection> response = apiInstance.VpnDhcpOverVpnDhcpServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpOverVpnServersCollection**](DhcpOverVpnServersCollection.md)

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

<a id="vpndhcpovervpndhcpserversiphostipdelete"></a>
# **VpnDhcpOverVpnDhcpServersIpHOSTIPDelete**
> ApiStatus VpnDhcpOverVpnDhcpServersIpHOSTIPDelete (string HOSTIP)



Delete a DHCP server from dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnDhcpServersIpHOSTIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnServersApi(config);
            var HOSTIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnDhcpServersIpHOSTIPDelete(HOSTIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersIpHOSTIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnDhcpServersIpHOSTIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnDhcpServersIpHOSTIPDeleteWithHttpInfo(HOSTIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersIpHOSTIPDeleteWithHttpInfo: " + e.Message);
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

<a id="vpndhcpovervpndhcpserversiphostipget"></a>
# **VpnDhcpOverVpnDhcpServersIpHOSTIPGet**
> DhcpOverVpnServersCollection VpnDhcpOverVpnDhcpServersIpHOSTIPGet (string HOSTIP)



Retrieve DHCP over VPN DHCP servers setting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnDhcpServersIpHOSTIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnServersApi(config);
            var HOSTIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                DhcpOverVpnServersCollection result = apiInstance.VpnDhcpOverVpnDhcpServersIpHOSTIPGet(HOSTIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersIpHOSTIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnDhcpServersIpHOSTIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpOverVpnServersCollection> response = apiInstance.VpnDhcpOverVpnDhcpServersIpHOSTIPGetWithHttpInfo(HOSTIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersIpHOSTIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **HOSTIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

### Return type

[**DhcpOverVpnServersCollection**](DhcpOverVpnServersCollection.md)

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

<a id="vpndhcpovervpndhcpserversiphostipput"></a>
# **VpnDhcpOverVpnDhcpServersIpHOSTIPPut**
> ApiStatus VpnDhcpOverVpnDhcpServersIpHOSTIPPut (string HOSTIP, DhcpOverVpnServersCollection? dhcpOverVpnServersCollection = null)



Edit a DHCP server to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnDhcpServersIpHOSTIPPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnServersApi(config);
            var HOSTIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var dhcpOverVpnServersCollection = new DhcpOverVpnServersCollection?(); // DhcpOverVpnServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnDhcpServersIpHOSTIPPut(HOSTIP, dhcpOverVpnServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersIpHOSTIPPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnDhcpServersIpHOSTIPPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnDhcpServersIpHOSTIPPutWithHttpInfo(HOSTIP, dhcpOverVpnServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersIpHOSTIPPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **HOSTIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **dhcpOverVpnServersCollection** | [**DhcpOverVpnServersCollection?**](DhcpOverVpnServersCollection?.md) |  | [optional]  |

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

<a id="vpndhcpovervpndhcpserverspost"></a>
# **VpnDhcpOverVpnDhcpServersPost**
> ApiStatus VpnDhcpOverVpnDhcpServersPost (DhcpOverVpnServersCollection? dhcpOverVpnServersCollection = null)



Add a DHCP server to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnDhcpServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnServersApi(config);
            var dhcpOverVpnServersCollection = new DhcpOverVpnServersCollection?(); // DhcpOverVpnServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnDhcpServersPost(dhcpOverVpnServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnDhcpServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnDhcpServersPostWithHttpInfo(dhcpOverVpnServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnServersCollection** | [**DhcpOverVpnServersCollection?**](DhcpOverVpnServersCollection?.md) |  | [optional]  |

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

<a id="vpndhcpovervpndhcpserversput"></a>
# **VpnDhcpOverVpnDhcpServersPut**
> ApiStatus VpnDhcpOverVpnDhcpServersPut (DhcpOverVpnServersCollection? dhcpOverVpnServersCollection = null)



Edit a DHCP server to dhcp over vpn.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnDhcpOverVpnDhcpServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnServersApi(config);
            var dhcpOverVpnServersCollection = new DhcpOverVpnServersCollection?(); // DhcpOverVpnServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnDhcpOverVpnDhcpServersPut(dhcpOverVpnServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnDhcpOverVpnDhcpServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnDhcpOverVpnDhcpServersPutWithHttpInfo(dhcpOverVpnServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnServersApi.VpnDhcpOverVpnDhcpServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpOverVpnServersCollection** | [**DhcpOverVpnServersCollection?**](DhcpOverVpnServersCollection?.md) |  | [optional]  |

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

