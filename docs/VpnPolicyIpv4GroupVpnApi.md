# SonicWallGen7.Api.VpnPolicyIpv4GroupVpnApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnPoliciesIpv4GroupVpnGet**](VpnPolicyIpv4GroupVpnApi.md#vpnpoliciesipv4groupvpnget) | **GET** /vpn/policies/ipv4/group-vpn |  |
| [**VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGet**](VpnPolicyIpv4GroupVpnApi.md#vpnpoliciesipv4groupvpnnamegroupvpnnameget) | **GET** /vpn/policies/ipv4/group-vpn/name/{GROUP_VPN_NAME} |  |
| [**VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPut**](VpnPolicyIpv4GroupVpnApi.md#vpnpoliciesipv4groupvpnnamegroupvpnnameput) | **PUT** /vpn/policies/ipv4/group-vpn/name/{GROUP_VPN_NAME} |  |
| [**VpnPoliciesIpv4GroupVpnPut**](VpnPolicyIpv4GroupVpnApi.md#vpnpoliciesipv4groupvpnput) | **PUT** /vpn/policies/ipv4/group-vpn |  |

<a id="vpnpoliciesipv4groupvpnget"></a>
# **VpnPoliciesIpv4GroupVpnGet**
> VpnPolicyIpv4GroupVpnCollection VpnPoliciesIpv4GroupVpnGet ()



Retrieve  IPv4 group VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4GroupVpnGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4GroupVpnApi(config);

            try
            {
                VpnPolicyIpv4GroupVpnCollection result = apiInstance.VpnPoliciesIpv4GroupVpnGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4GroupVpnGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4GroupVpnCollection> response = apiInstance.VpnPoliciesIpv4GroupVpnGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VpnPolicyIpv4GroupVpnCollection**](VpnPolicyIpv4GroupVpnCollection.md)

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

<a id="vpnpoliciesipv4groupvpnnamegroupvpnnameget"></a>
# **VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGet**
> VpnPolicyIpv4GroupVpnCollection VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGet (string GROUP_VPN_NAME)



Retrieve  IPv4 group VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4GroupVpnApi(config);
            var GROUP_VPN_NAME = "\"WAN GroupVPN\"";  // string | Group VPN policy name. (default to "WAN GroupVPN")

            try
            {
                VpnPolicyIpv4GroupVpnCollection result = apiInstance.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGet(GROUP_VPN_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VpnPolicyIpv4GroupVpnCollection> response = apiInstance.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGetWithHttpInfo(GROUP_VPN_NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GROUP_VPN_NAME** | **string** | Group VPN policy name. | [default to &quot;WAN GroupVPN&quot;] |

### Return type

[**VpnPolicyIpv4GroupVpnCollection**](VpnPolicyIpv4GroupVpnCollection.md)

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

<a id="vpnpoliciesipv4groupvpnnamegroupvpnnameput"></a>
# **VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPut**
> ApiStatus VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPut (string GROUP_VPN_NAME, VpnPolicyIpv4GroupVpnCollection? vpnPolicyIpv4GroupVpnCollection = null)



Edit IPv4 group VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4GroupVpnApi(config);
            var GROUP_VPN_NAME = "\"WAN GroupVPN\"";  // string | Group VPN policy name. (default to "WAN GroupVPN")
            var vpnPolicyIpv4GroupVpnCollection = new VpnPolicyIpv4GroupVpnCollection?(); // VpnPolicyIpv4GroupVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPut(GROUP_VPN_NAME, vpnPolicyIpv4GroupVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPutWithHttpInfo(GROUP_VPN_NAME, vpnPolicyIpv4GroupVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnNameGROUPVPNNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GROUP_VPN_NAME** | **string** | Group VPN policy name. | [default to &quot;WAN GroupVPN&quot;] |
| **vpnPolicyIpv4GroupVpnCollection** | [**VpnPolicyIpv4GroupVpnCollection?**](VpnPolicyIpv4GroupVpnCollection?.md) |  | [optional]  |

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

<a id="vpnpoliciesipv4groupvpnput"></a>
# **VpnPoliciesIpv4GroupVpnPut**
> ApiStatus VpnPoliciesIpv4GroupVpnPut (VpnPolicyIpv4GroupVpnCollection? vpnPolicyIpv4GroupVpnCollection = null)



Edit IPv4 group VPN policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnPoliciesIpv4GroupVpnPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnPolicyIpv4GroupVpnApi(config);
            var vpnPolicyIpv4GroupVpnCollection = new VpnPolicyIpv4GroupVpnCollection?(); // VpnPolicyIpv4GroupVpnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.VpnPoliciesIpv4GroupVpnPut(vpnPolicyIpv4GroupVpnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnPoliciesIpv4GroupVpnPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnPoliciesIpv4GroupVpnPutWithHttpInfo(vpnPolicyIpv4GroupVpnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnPolicyIpv4GroupVpnApi.VpnPoliciesIpv4GroupVpnPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vpnPolicyIpv4GroupVpnCollection** | [**VpnPolicyIpv4GroupVpnCollection?**](VpnPolicyIpv4GroupVpnCollection?.md) |  | [optional]  |

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

