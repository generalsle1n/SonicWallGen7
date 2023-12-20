# SonicWallGen7.Api.ExportGroupVpnPolicyRcfApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGet**](ExportGroupVpnPolicyRcfApi.md#exportvpnrcfgroupvpngroupvpnnamenetworknetlocalget) | **GET** /export/vpn/rcf/group-vpn/{GROUPVPNNAME}/network/{NETLOCAL} |  |
| [**ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGet**](ExportGroupVpnPolicyRcfApi.md#exportvpnrcfgroupvpngroupvpnnamenetworknetlocalpasswordexppwdget) | **GET** /export/vpn/rcf/group-vpn/{GROUPVPNNAME}/network/{NETLOCAL}/password/{EXPPWD} |  |

<a id="exportvpnrcfgroupvpngroupvpnnamenetworknetlocalget"></a>
# **ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGet**
> Object ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGet (string GROUPVPNNAME, string NETLOCAL)



Export the group VPN client policy in rcf format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExportGroupVpnPolicyRcfApi(config);
            var GROUPVPNNAME = "\"WAN GroupVPN\"";  // string | Group VPN policy name. (default to "WAN GroupVPN")
            var NETLOCAL = "\"My Object\"";  // string | Atom Object name. (default to "My Object")

            try
            {
                Object result = apiInstance.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGet(GROUPVPNNAME, NETLOCAL);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportGroupVpnPolicyRcfApi.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGetWithHttpInfo(GROUPVPNNAME, NETLOCAL);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportGroupVpnPolicyRcfApi.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GROUPVPNNAME** | **string** | Group VPN policy name. | [default to &quot;WAN GroupVPN&quot;] |
| **NETLOCAL** | **string** | Atom Object name. | [default to &quot;My Object&quot;] |

### Return type

**Object**

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

<a id="exportvpnrcfgroupvpngroupvpnnamenetworknetlocalpasswordexppwdget"></a>
# **ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGet**
> Object ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGet (string GROUPVPNNAME, string NETLOCAL, string EXPPWD)



Export the group VPN client policy in rcf format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExportGroupVpnPolicyRcfApi(config);
            var GROUPVPNNAME = "\"WAN GroupVPN\"";  // string | Group VPN policy name. (default to "WAN GroupVPN")
            var NETLOCAL = "\"My Object\"";  // string | Atom Object name. (default to "My Object")
            var EXPPWD = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                Object result = apiInstance.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGet(GROUPVPNNAME, NETLOCAL, EXPPWD);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportGroupVpnPolicyRcfApi.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGetWithHttpInfo(GROUPVPNNAME, NETLOCAL, EXPPWD);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportGroupVpnPolicyRcfApi.ExportVpnRcfGroupVpnGROUPVPNNAMENetworkNETLOCALPasswordEXPPWDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GROUPVPNNAME** | **string** | Group VPN policy name. | [default to &quot;WAN GroupVPN&quot;] |
| **NETLOCAL** | **string** | Atom Object name. | [default to &quot;My Object&quot;] |
| **EXPPWD** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

**Object**

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

