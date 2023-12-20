# SonicWallGen7.Api.DhcpServerIpv4LeasesStatisticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDhcpServerIpv4LeasesStatisticGet**](DhcpServerIpv4LeasesStatisticApi.md#reportingdhcpserveripv4leasesstatisticget) | **GET** /reporting/dhcp-server/ipv4/leases/statistic |  |

<a id="reportingdhcpserveripv4leasesstatisticget"></a>
# **ReportingDhcpServerIpv4LeasesStatisticGet**
> ShowStatusDhcpLeasesStatisticDetail ReportingDhcpServerIpv4LeasesStatisticGet ()



Retrieve DHCP server IPv4 leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv4LeasesStatisticGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv4LeasesStatisticApi(config);

            try
            {
                ShowStatusDhcpLeasesStatisticDetail result = apiInstance.ReportingDhcpServerIpv4LeasesStatisticGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv4LeasesStatisticApi.ReportingDhcpServerIpv4LeasesStatisticGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv4LeasesStatisticGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusDhcpLeasesStatisticDetail> response = apiInstance.ReportingDhcpServerIpv4LeasesStatisticGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv4LeasesStatisticApi.ReportingDhcpServerIpv4LeasesStatisticGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusDhcpLeasesStatisticDetail**](ShowStatusDhcpLeasesStatisticDetail.md)

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

