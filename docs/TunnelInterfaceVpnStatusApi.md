# SonicWallGen7.Api.TunnelInterfaceVpnStatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingTunnelInterfacesVpnStatusGet**](TunnelInterfaceVpnStatusApi.md#reportingtunnelinterfacesvpnstatusget) | **GET** /reporting/tunnel-interfaces/vpn/status |  |
| [**ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGet**](TunnelInterfaceVpnStatusApi.md#reportingtunnelinterfacesvpnstatusnamevpntunnelnameget) | **GET** /reporting/tunnel-interfaces/vpn/status/name/{VPNTUNNELNAME} |  |

<a id="reportingtunnelinterfacesvpnstatusget"></a>
# **ReportingTunnelInterfacesVpnStatusGet**
> ShowStatusTunnelInterfaceStatusDetail ReportingTunnelInterfacesVpnStatusGet ()



Retrieve tunnel-interface vpn status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingTunnelInterfacesVpnStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnStatusApi(config);

            try
            {
                ShowStatusTunnelInterfaceStatusDetail result = apiInstance.ReportingTunnelInterfacesVpnStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnStatusApi.ReportingTunnelInterfacesVpnStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingTunnelInterfacesVpnStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusTunnelInterfaceStatusDetail> response = apiInstance.ReportingTunnelInterfacesVpnStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnStatusApi.ReportingTunnelInterfacesVpnStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusTunnelInterfaceStatusDetail**](ShowStatusTunnelInterfaceStatusDetail.md)

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

<a id="reportingtunnelinterfacesvpnstatusnamevpntunnelnameget"></a>
# **ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGet**
> ShowStatusTunnelInterfaceStatusDetail ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGet (string VPNTUNNELNAME)



Retrieve tunnel-interface vpn status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceVpnStatusApi(config);
            var VPNTUNNELNAME = "\"vpnTunnelInterface\"";  // string | VPN tunnel interface name. (default to "vpnTunnelInterface")

            try
            {
                ShowStatusTunnelInterfaceStatusDetail result = apiInstance.ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGet(VPNTUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceVpnStatusApi.ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusTunnelInterfaceStatusDetail> response = apiInstance.ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGetWithHttpInfo(VPNTUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceVpnStatusApi.ReportingTunnelInterfacesVpnStatusNameVPNTUNNELNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **VPNTUNNELNAME** | **string** | VPN tunnel interface name. | [default to &quot;vpnTunnelInterface&quot;] |

### Return type

[**ShowStatusTunnelInterfaceStatusDetail**](ShowStatusTunnelInterfaceStatusDetail.md)

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

