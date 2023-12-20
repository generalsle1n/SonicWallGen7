# SonicWallGen7.Api.SslVpnStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingSslVpnStatisticsIPGet**](SslVpnStatisticsApi.md#reportingsslvpnstatisticsipget) | **GET** /reporting/ssl-vpn/statistics/{IP} |  |

<a id="reportingsslvpnstatisticsipget"></a>
# **ReportingSslVpnStatisticsIPGet**
> ShowStatusSslvpnTrafficDetail ReportingSslVpnStatisticsIPGet (string IP)



Retrieve SSL VPN statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSslVpnStatisticsIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnStatisticsApi(config);
            var IP = "\"192.168.168.168\"";  // string | NetExtender client virtual IP. (default to "192.168.168.168")

            try
            {
                ShowStatusSslvpnTrafficDetail result = apiInstance.ReportingSslVpnStatisticsIPGet(IP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnStatisticsApi.ReportingSslVpnStatisticsIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSslVpnStatisticsIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusSslvpnTrafficDetail> response = apiInstance.ReportingSslVpnStatisticsIPGetWithHttpInfo(IP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnStatisticsApi.ReportingSslVpnStatisticsIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | NetExtender client virtual IP. | [default to &quot;192.168.168.168&quot;] |

### Return type

[**ShowStatusSslvpnTrafficDetail**](ShowStatusSslvpnTrafficDetail.md)

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

