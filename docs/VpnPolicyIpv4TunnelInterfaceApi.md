# SonicWallGen7.Api.VpnPolicyIpv4TunnelInterfaceApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnPoliciesIpv4TunnelInterfaceGet**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfaceget) | **GET** /vpn/policies/ipv4/tunnel-interface |  |
| [**VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfacenametunnelvpnnamedelete) | **DELETE** /vpn/policies/ipv4/tunnel-interface/name/{TUNNEL_VPN_NAME} |  |
| [**VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfacenametunnelvpnnameget) | **GET** /vpn/policies/ipv4/tunnel-interface/name/{TUNNEL_VPN_NAME} |  |
| [**VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfacenametunnelvpnnamepatch) | **PATCH** /vpn/policies/ipv4/tunnel-interface/name/{TUNNEL_VPN_NAME} |  |
| [**VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfacenametunnelvpnnameput) | **PUT** /vpn/policies/ipv4/tunnel-interface/name/{TUNNEL_VPN_NAME} |  |
| [**VpnPoliciesIpv4TunnelInterfacePatch**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfacepatch) | **PATCH** /vpn/policies/ipv4/tunnel-interface |  |
| [**VpnPoliciesIpv4TunnelInterfacePost**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfacepost) | **POST** /vpn/policies/ipv4/tunnel-interface |  |
| [**VpnPoliciesIpv4TunnelInterfacePut**](VpnPolicyIpv4TunnelInterfaceApi.md#vpnpoliciesipv4tunnelinterfaceput) | **PUT** /vpn/policies/ipv4/tunnel-interface |  |

<a id="vpnpoliciesipv4tunnelinterfaceget"></a>
# **VpnPoliciesIpv4TunnelInterfaceGet**
> VpnPolicyIpv4TunnelInterfaceCollection VpnPoliciesIpv4TunnelInterfaceGet ()



Retrieve IPv4 tunnel interface VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfaceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);

            try
            {
                VpnPolicyIpv4TunnelInterfaceCollection result = apiInstance.VpnPoliciesIpv4TunnelInterfaceGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfaceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4TunnelInterfaceCollection> response = apiInstance.VpnPoliciesIpv4TunnelInterfaceGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnPolicyIpv4TunnelInterfaceCollection**](VpnPolicyIpv4TunnelInterfaceCollection.md)

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

<a id="vpnpoliciesipv4tunnelinterfacenametunnelvpnnamedelete"></a>
# **VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete**
> ApiStatus VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete (string TUNNEL_VPN_NAME)



Delete a IPv4 tunnel interface VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var TUNNEL_VPN_NAME = "\"Remote Office\"";  // string | Tunnel interface VPN policy name. (default to "Remote Office")

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete(TUNNEL_VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDeleteWithHttpInfo(TUNNEL_VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNEL_VPN_NAME** | **string** | Tunnel interface VPN policy name. | [default to &quot;Remote Office&quot;] |

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

<a id="vpnpoliciesipv4tunnelinterfacenametunnelvpnnameget"></a>
# **VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet**
> VpnPolicyIpv4TunnelInterfaceCollection VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet (string TUNNEL_VPN_NAME)



Retrieve IPv4 tunnel interface VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var TUNNEL_VPN_NAME = "\"Remote Office\"";  // string | Tunnel interface VPN policy name. (default to "Remote Office")

            try
            {
                VpnPolicyIpv4TunnelInterfaceCollection result = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet(TUNNEL_VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4TunnelInterfaceCollection> response = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGetWithHttpInfo(TUNNEL_VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNEL_VPN_NAME** | **string** | Tunnel interface VPN policy name. | [default to &quot;Remote Office&quot;] |

### Return type

[**VpnPolicyIpv4TunnelInterfaceCollection**](VpnPolicyIpv4TunnelInterfaceCollection.md)

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

<a id="vpnpoliciesipv4tunnelinterfacenametunnelvpnnamepatch"></a>
# **VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch**
> ApiStatus VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch (string TUNNEL_VPN_NAME, VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null)



Patch IPv4 tunnel interface VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var TUNNEL_VPN_NAME = "\"Remote Office\"";  // string | Tunnel interface VPN policy name. (default to "Remote Office")
            var vpnPolicyIpv4TunnelInterfaceCollection = new VpnPolicyIpv4TunnelInterfaceCollection?(); // VpnPolicyIpv4TunnelInterfaceCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch(TUNNEL_VPN_NAME, vpnPolicyIpv4TunnelInterfaceCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatchWithHttpInfo(TUNNEL_VPN_NAME, vpnPolicyIpv4TunnelInterfaceCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNEL_VPN_NAME** | **string** | Tunnel interface VPN policy name. | [default to &quot;Remote Office&quot;] |
| **vpnPolicyIpv4TunnelInterfaceCollection** | [**VpnPolicyIpv4TunnelInterfaceCollection?**](VpnPolicyIpv4TunnelInterfaceCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4tunnelinterfacenametunnelvpnnameput"></a>
# **VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut**
> ApiStatus VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut (string TUNNEL_VPN_NAME, VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null)



Edit IPv4 tunnel interface VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var TUNNEL_VPN_NAME = "\"Remote Office\"";  // string | Tunnel interface VPN policy name. (default to "Remote Office")
            var vpnPolicyIpv4TunnelInterfaceCollection = new VpnPolicyIpv4TunnelInterfaceCollection?(); // VpnPolicyIpv4TunnelInterfaceCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut(TUNNEL_VPN_NAME, vpnPolicyIpv4TunnelInterfaceCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPutWithHttpInfo(TUNNEL_VPN_NAME, vpnPolicyIpv4TunnelInterfaceCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNEL_VPN_NAME** | **string** | Tunnel interface VPN policy name. | [default to &quot;Remote Office&quot;] |
| **vpnPolicyIpv4TunnelInterfaceCollection** | [**VpnPolicyIpv4TunnelInterfaceCollection?**](VpnPolicyIpv4TunnelInterfaceCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4tunnelinterfacepatch"></a>
# **VpnPoliciesIpv4TunnelInterfacePatch**
> ApiStatus VpnPoliciesIpv4TunnelInterfacePatch (VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null)



Patch IPv4 tunnel interface VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfacePatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var vpnPolicyIpv4TunnelInterfaceCollection = new VpnPolicyIpv4TunnelInterfaceCollection?(); // VpnPolicyIpv4TunnelInterfaceCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4TunnelInterfacePatch(vpnPolicyIpv4TunnelInterfaceCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfacePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfacePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4TunnelInterfacePatchWithHttpInfo(vpnPolicyIpv4TunnelInterfaceCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfacePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4TunnelInterfaceCollection** | [**VpnPolicyIpv4TunnelInterfaceCollection?**](VpnPolicyIpv4TunnelInterfaceCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4tunnelinterfacepost"></a>
# **VpnPoliciesIpv4TunnelInterfacePost**
> ApiStatus VpnPoliciesIpv4TunnelInterfacePost (VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null)



Create a new IPv4 tunnel interface VPN policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfacePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var vpnPolicyIpv4TunnelInterfaceCollection = new VpnPolicyIpv4TunnelInterfaceCollection?(); // VpnPolicyIpv4TunnelInterfaceCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4TunnelInterfacePost(vpnPolicyIpv4TunnelInterfaceCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfacePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfacePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4TunnelInterfacePostWithHttpInfo(vpnPolicyIpv4TunnelInterfaceCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfacePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4TunnelInterfaceCollection** | [**VpnPolicyIpv4TunnelInterfaceCollection?**](VpnPolicyIpv4TunnelInterfaceCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4tunnelinterfaceput"></a>
# **VpnPoliciesIpv4TunnelInterfacePut**
> ApiStatus VpnPoliciesIpv4TunnelInterfacePut (VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null)



Edit IPv4 tunnel interface VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4TunnelInterfacePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4TunnelInterfaceApi(config);
            var vpnPolicyIpv4TunnelInterfaceCollection = new VpnPolicyIpv4TunnelInterfaceCollection?(); // VpnPolicyIpv4TunnelInterfaceCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4TunnelInterfacePut(vpnPolicyIpv4TunnelInterfaceCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfacePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4TunnelInterfacePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4TunnelInterfacePutWithHttpInfo(vpnPolicyIpv4TunnelInterfaceCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4TunnelInterfaceApi.VpnPoliciesIpv4TunnelInterfacePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4TunnelInterfaceCollection** | [**VpnPolicyIpv4TunnelInterfaceCollection?**](VpnPolicyIpv4TunnelInterfaceCollection?.md) |  | [optional]  |

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

