# SonicWallGen7.Api.IphDhcpv6RelayLeasesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingIpHelperDhcpv6RelayLeasesGet**](IphDhcpv6RelayLeasesApi.md#reportingiphelperdhcpv6relayleasesget) | **GET** /reporting/ip-helper/dhcpv6-relay-leases |  |

<a id="reportingiphelperdhcpv6relayleasesget"></a>
# **ReportingIpHelperDhcpv6RelayLeasesGet**
> List&lt;ShowStatusDhcpv6RelayLeasesListInner&gt; ReportingIpHelperDhcpv6RelayLeasesGet ()



Retrieve IP helper IPv6 DHCP relay leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingIpHelperDhcpv6RelayLeasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IphDhcpv6RelayLeasesApi(config);

            try
            {
                List<ShowStatusDhcpv6RelayLeasesListInner> result = apiInstance.ReportingIpHelperDhcpv6RelayLeasesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IphDhcpv6RelayLeasesApi.ReportingIpHelperDhcpv6RelayLeasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingIpHelperDhcpv6RelayLeasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcpv6RelayLeasesListInner>> response = apiInstance.ReportingIpHelperDhcpv6RelayLeasesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IphDhcpv6RelayLeasesApi.ReportingIpHelperDhcpv6RelayLeasesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDhcpv6RelayLeasesListInner&gt;**](ShowStatusDhcpv6RelayLeasesListInner.md)

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

