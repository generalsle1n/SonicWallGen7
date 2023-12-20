# SonicWallGen7.Api.DhcpServerIpv6LeasesStatisticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDhcpServerIpv6LeasesStatisticGet**](DhcpServerIpv6LeasesStatisticApi.md#reportingdhcpserveripv6leasesstatisticget) | **GET** /reporting/dhcp-server/ipv6/leases/statistic |  |

<a id="reportingdhcpserveripv6leasesstatisticget"></a>
# **ReportingDhcpServerIpv6LeasesStatisticGet**
> ShowStatusDhcps6LeasesStatisticDetail ReportingDhcpServerIpv6LeasesStatisticGet ()



Retrieve DHCP server IPv6 leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv6LeasesStatisticGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6LeasesStatisticApi(config);

            try
            {
                ShowStatusDhcps6LeasesStatisticDetail result = apiInstance.ReportingDhcpServerIpv6LeasesStatisticGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6LeasesStatisticApi.ReportingDhcpServerIpv6LeasesStatisticGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv6LeasesStatisticGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusDhcps6LeasesStatisticDetail> response = apiInstance.ReportingDhcpServerIpv6LeasesStatisticGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6LeasesStatisticApi.ReportingDhcpServerIpv6LeasesStatisticGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusDhcps6LeasesStatisticDetail**](ShowStatusDhcps6LeasesStatisticDetail.md)

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

