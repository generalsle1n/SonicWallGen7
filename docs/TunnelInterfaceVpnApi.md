# SonicWallGen7.Api.TunnelInterfaceVpnApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TunnelInterfacesVpnGet**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnget) | **GET** /tunnel-interfaces/vpn |  |
| [**TunnelInterfacesVpnNameVPNTUNNELNAMEDelete**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnnamevpntunnelnamedelete) | **DELETE** /tunnel-interfaces/vpn/name/{VPNTUNNELNAME} |  |
| [**TunnelInterfacesVpnNameVPNTUNNELNAMEGet**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnnamevpntunnelnameget) | **GET** /tunnel-interfaces/vpn/name/{VPNTUNNELNAME} |  |
| [**TunnelInterfacesVpnNameVPNTUNNELNAMEPatch**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnnamevpntunnelnamepatch) | **PATCH** /tunnel-interfaces/vpn/name/{VPNTUNNELNAME} |  |
| [**TunnelInterfacesVpnNameVPNTUNNELNAMEPut**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnnamevpntunnelnameput) | **PUT** /tunnel-interfaces/vpn/name/{VPNTUNNELNAME} |  |
| [**TunnelInterfacesVpnPatch**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnpatch) | **PATCH** /tunnel-interfaces/vpn |  |
| [**TunnelInterfacesVpnPost**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnpost) | **POST** /tunnel-interfaces/vpn |  |
| [**TunnelInterfacesVpnPut**](TunnelInterfaceVpnApi.md#tunnelinterfacesvpnput) | **PUT** /tunnel-interfaces/vpn |  |

<a id="tunnelinterfacesvpnget"></a>
# **TunnelInterfacesVpnGet**
> TunnelInterfaceVpnCollection TunnelInterfacesVpnGet ()



Retrieve tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);

            try
            {
                TunnelInterfaceVpnCollection result = apiInstance.TunnelInterfacesVpnGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TunnelInterfaceVpnCollection> response = apiInstance.TunnelInterfacesVpnGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TunnelInterfaceVpnCollection**](TunnelInterfaceVpnCollection.md)

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

<a id="tunnelinterfacesvpnnamevpntunnelnamedelete"></a>
# **TunnelInterfacesVpnNameVPNTUNNELNAMEDelete**
> ApiStatus TunnelInterfacesVpnNameVPNTUNNELNAMEDelete (string VPNTUNNELNAME)



Delete VPN tunnel interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnNameVPNTUNNELNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var VPNTUNNELNAME = "\"vpnTunnelInterface\"";  // string | VPN tunnel interface name. (default to "vpnTunnelInterface")

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEDelete(VPNTUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnNameVPNTUNNELNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEDeleteWithHttpInfo(VPNTUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPNTUNNELNAME** | **string** | VPN tunnel interface name. | [default to &quot;vpnTunnelInterface&quot;] |

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

<a id="tunnelinterfacesvpnnamevpntunnelnameget"></a>
# **TunnelInterfacesVpnNameVPNTUNNELNAMEGet**
> TunnelInterfaceVpnCollection TunnelInterfacesVpnNameVPNTUNNELNAMEGet (string VPNTUNNELNAME)



Retrieve tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnNameVPNTUNNELNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var VPNTUNNELNAME = "\"vpnTunnelInterface\"";  // string | VPN tunnel interface name. (default to "vpnTunnelInterface")

            try
            {
                TunnelInterfaceVpnCollection result = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEGet(VPNTUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnNameVPNTUNNELNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TunnelInterfaceVpnCollection> response = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEGetWithHttpInfo(VPNTUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPNTUNNELNAME** | **string** | VPN tunnel interface name. | [default to &quot;vpnTunnelInterface&quot;] |

### Return type

[**TunnelInterfaceVpnCollection**](TunnelInterfaceVpnCollection.md)

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

<a id="tunnelinterfacesvpnnamevpntunnelnamepatch"></a>
# **TunnelInterfacesVpnNameVPNTUNNELNAMEPatch**
> ApiStatus TunnelInterfacesVpnNameVPNTUNNELNAMEPatch (string VPNTUNNELNAME, TunnelInterfaceVpnCollection? tunnelInterfaceVpnCollection = null)



Patch VPN tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnNameVPNTUNNELNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var VPNTUNNELNAME = "\"vpnTunnelInterface\"";  // string | VPN tunnel interface name. (default to "vpnTunnelInterface")
            var tunnelInterfaceVpnCollection = new TunnelInterfaceVpnCollection?(); // TunnelInterfaceVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEPatch(VPNTUNNELNAME, tunnelInterfaceVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnNameVPNTUNNELNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEPatchWithHttpInfo(VPNTUNNELNAME, tunnelInterfaceVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPNTUNNELNAME** | **string** | VPN tunnel interface name. | [default to &quot;vpnTunnelInterface&quot;] |
| **tunnelInterfaceVpnCollection** | [**TunnelInterfaceVpnCollection?**](TunnelInterfaceVpnCollection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesvpnnamevpntunnelnameput"></a>
# **TunnelInterfacesVpnNameVPNTUNNELNAMEPut**
> ApiStatus TunnelInterfacesVpnNameVPNTUNNELNAMEPut (string VPNTUNNELNAME, TunnelInterfaceVpnCollection? tunnelInterfaceVpnCollection = null)



Edit VPN tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnNameVPNTUNNELNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var VPNTUNNELNAME = "\"vpnTunnelInterface\"";  // string | VPN tunnel interface name. (default to "vpnTunnelInterface")
            var tunnelInterfaceVpnCollection = new TunnelInterfaceVpnCollection?(); // TunnelInterfaceVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEPut(VPNTUNNELNAME, tunnelInterfaceVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnNameVPNTUNNELNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesVpnNameVPNTUNNELNAMEPutWithHttpInfo(VPNTUNNELNAME, tunnelInterfaceVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnNameVPNTUNNELNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPNTUNNELNAME** | **string** | VPN tunnel interface name. | [default to &quot;vpnTunnelInterface&quot;] |
| **tunnelInterfaceVpnCollection** | [**TunnelInterfaceVpnCollection?**](TunnelInterfaceVpnCollection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesvpnpatch"></a>
# **TunnelInterfacesVpnPatch**
> ApiStatus TunnelInterfacesVpnPatch (TunnelInterfaceVpnCollection? tunnelInterfaceVpnCollection = null)



Patch VPN tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var tunnelInterfaceVpnCollection = new TunnelInterfaceVpnCollection?(); // TunnelInterfaceVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesVpnPatch(tunnelInterfaceVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesVpnPatchWithHttpInfo(tunnelInterfaceVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterfaceVpnCollection** | [**TunnelInterfaceVpnCollection?**](TunnelInterfaceVpnCollection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesvpnpost"></a>
# **TunnelInterfacesVpnPost**
> ApiStatus TunnelInterfacesVpnPost (TunnelInterfaceVpnCollection? tunnelInterfaceVpnCollection = null)



Add VPN tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var tunnelInterfaceVpnCollection = new TunnelInterfaceVpnCollection?(); // TunnelInterfaceVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesVpnPost(tunnelInterfaceVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesVpnPostWithHttpInfo(tunnelInterfaceVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterfaceVpnCollection** | [**TunnelInterfaceVpnCollection?**](TunnelInterfaceVpnCollection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesvpnput"></a>
# **TunnelInterfacesVpnPut**
> ApiStatus TunnelInterfacesVpnPut (TunnelInterfaceVpnCollection? tunnelInterfaceVpnCollection = null)



Edit VPN tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesVpnPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnApi(config);
            var tunnelInterfaceVpnCollection = new TunnelInterfaceVpnCollection?(); // TunnelInterfaceVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesVpnPut(tunnelInterfaceVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesVpnPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesVpnPutWithHttpInfo(tunnelInterfaceVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnApi.TunnelInterfacesVpnPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterfaceVpnCollection** | [**TunnelInterfaceVpnCollection?**](TunnelInterfaceVpnCollection?.md) |  | [optional]  |

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

