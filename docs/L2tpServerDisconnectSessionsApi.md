# SonicWallGen7.Api.L2tpServerDisconnectSessionsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VpnL2tpServerDisconnectUSERIPDelete**](L2tpServerDisconnectSessionsApi.md#vpnl2tpserverdisconnectuseripdelete) | **DELETE** /vpn/l2tp-server/disconnect/{USERIP} |  |

<a id="vpnl2tpserverdisconnectuseripdelete"></a>
# **VpnL2tpServerDisconnectUSERIPDelete**
> ApiStatus VpnL2tpServerDisconnectUSERIPDelete (string USERIP)



Disconnect L2TP server active sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class VpnL2tpServerDisconnectUSERIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new L2tpServerDisconnectSessionsApi(config);
            var USERIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.VpnL2tpServerDisconnectUSERIPDelete(USERIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling L2tpServerDisconnectSessionsApi.VpnL2tpServerDisconnectUSERIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VpnL2tpServerDisconnectUSERIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.VpnL2tpServerDisconnectUSERIPDeleteWithHttpInfo(USERIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling L2tpServerDisconnectSessionsApi.VpnL2tpServerDisconnectUSERIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

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

