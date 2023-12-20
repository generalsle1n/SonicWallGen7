# SonicWallGen7.Api.TunnelInterface4to6MtuApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingTunnelInterfaces4to6StatusGet**](TunnelInterface4to6MtuApi.md#reportingtunnelinterfaces4to6statusget) | **GET** /reporting/tunnel-interfaces/4to6/status |  |
| [**ReportingTunnelInterfaces4to6StatusNameNAMEGet**](TunnelInterface4to6MtuApi.md#reportingtunnelinterfaces4to6statusnamenameget) | **GET** /reporting/tunnel-interfaces/4to6/status/name/{NAME} |  |

<a id="reportingtunnelinterfaces4to6statusget"></a>
# **ReportingTunnelInterfaces4to6StatusGet**
> List&lt;ShowStatusTunnel6InterfaceMtuListInner&gt; ReportingTunnelInterfaces4to6StatusGet ()



Get mtu status for 4to6 tunnel interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingTunnelInterfaces4to6StatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6MtuApi(config);

            try
            {
                List<ShowStatusTunnel6InterfaceMtuListInner> result = apiInstance.ReportingTunnelInterfaces4to6StatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6MtuApi.ReportingTunnelInterfaces4to6StatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingTunnelInterfaces4to6StatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusTunnel6InterfaceMtuListInner>> response = apiInstance.ReportingTunnelInterfaces4to6StatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6MtuApi.ReportingTunnelInterfaces4to6StatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusTunnel6InterfaceMtuListInner&gt;**](ShowStatusTunnel6InterfaceMtuListInner.md)

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

<a id="reportingtunnelinterfaces4to6statusnamenameget"></a>
# **ReportingTunnelInterfaces4to6StatusNameNAMEGet**
> ShowStatusTunnel6InterfaceMtuDetail ReportingTunnelInterfaces4to6StatusNameNAMEGet (string NAME)



Get mtu status for 4to6 tunnel interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingTunnelInterfaces4to6StatusNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6MtuApi(config);
            var NAME = "\"tunnel6TunnelInterface\"";  // string | Tunnel6 tunnel interface name. (default to "tunnel6TunnelInterface")

            try
            {
                ShowStatusTunnel6InterfaceMtuDetail result = apiInstance.ReportingTunnelInterfaces4to6StatusNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6MtuApi.ReportingTunnelInterfaces4to6StatusNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingTunnelInterfaces4to6StatusNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusTunnel6InterfaceMtuDetail> response = apiInstance.ReportingTunnelInterfaces4to6StatusNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6MtuApi.ReportingTunnelInterfaces4to6StatusNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Tunnel6 tunnel interface name. | [default to &quot;tunnel6TunnelInterface&quot;] |

### Return type

[**ShowStatusTunnel6InterfaceMtuDetail**](ShowStatusTunnel6InterfaceMtuDetail.md)

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

