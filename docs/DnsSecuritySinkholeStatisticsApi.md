# SonicWallGen7.Api.DnsSecuritySinkholeStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDnsSecuritySinkholeStatisticalGet**](DnsSecuritySinkholeStatisticsApi.md#reportingdnssecuritysinkholestatisticalget) | **GET** /reporting/dns-security/sinkhole-statistical |  |

<a id="reportingdnssecuritysinkholestatisticalget"></a>
# **ReportingDnsSecuritySinkholeStatisticalGet**
> List&lt;ShowStatusDnsSecuritySinkholeStatisticalListInner&gt; ReportingDnsSecuritySinkholeStatisticalGet ()



Retrieve DNS security DNS Sinkhole statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDnsSecuritySinkholeStatisticalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecuritySinkholeStatisticsApi(config);

            try
            {
                List<ShowStatusDnsSecuritySinkholeStatisticalListInner> result = apiInstance.ReportingDnsSecuritySinkholeStatisticalGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecuritySinkholeStatisticsApi.ReportingDnsSecuritySinkholeStatisticalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDnsSecuritySinkholeStatisticalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDnsSecuritySinkholeStatisticalListInner>> response = apiInstance.ReportingDnsSecuritySinkholeStatisticalGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecuritySinkholeStatisticsApi.ReportingDnsSecuritySinkholeStatisticalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDnsSecuritySinkholeStatisticalListInner&gt;**](ShowStatusDnsSecuritySinkholeStatisticalListInner.md)

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

