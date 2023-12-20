# SonicWallGen7.Api.ExportGroupVpnPolicySpdApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportVpnSpdGroupVpnGROUPVPNNAMEGet**](ExportGroupVpnPolicySpdApi.md#exportvpnspdgroupvpngroupvpnnameget) | **GET** /export/vpn/spd/group-vpn/{GROUPVPNNAME} |  |

<a id="exportvpnspdgroupvpngroupvpnnameget"></a>
# **ExportVpnSpdGroupVpnGROUPVPNNAMEGet**
> Object ExportVpnSpdGroupVpnGROUPVPNNAMEGet (string GROUPVPNNAME)



Export the group VPN client policy in spd format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportVpnSpdGroupVpnGROUPVPNNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExportGroupVpnPolicySpdApi(config);
            var GROUPVPNNAME = "\"WAN GroupVPN\"";  // string | Group VPN policy name. (default to "WAN GroupVPN")

            try
            {
                Object result = apiInstance.ExportVpnSpdGroupVpnGROUPVPNNAMEGet(GROUPVPNNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportGroupVpnPolicySpdApi.ExportVpnSpdGroupVpnGROUPVPNNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportVpnSpdGroupVpnGROUPVPNNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportVpnSpdGroupVpnGROUPVPNNAMEGetWithHttpInfo(GROUPVPNNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportGroupVpnPolicySpdApi.ExportVpnSpdGroupVpnGROUPVPNNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GROUPVPNNAME** | **string** | Group VPN policy name. | [default to &quot;WAN GroupVPN&quot;] |

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

