# SonicWallGen7.Api.MacIpAntiSpoofLookupStatisticsIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingMacIpAntiSpoofLookupStatisticsIpv6Get**](MacIpAntiSpoofLookupStatisticsIpv6Api.md#reportingmacipantispooflookupstatisticsipv6get) | **GET** /reporting/mac-ip-anti-spoof/lookup-statistics/ipv6 |  |

<a id="reportingmacipantispooflookupstatisticsipv6get"></a>
# **ReportingMacIpAntiSpoofLookupStatisticsIpv6Get**
> ShowStatusMacAntiSpoofLookupStatisticDetail ReportingMacIpAntiSpoofLookupStatisticsIpv6Get ()



Retrieve MAC IPv6 anti-spoof lookup statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingMacIpAntiSpoofLookupStatisticsIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofLookupStatisticsIpv6Api(config);

            try
            {
                ShowStatusMacAntiSpoofLookupStatisticDetail result = apiInstance.ReportingMacIpAntiSpoofLookupStatisticsIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofLookupStatisticsIpv6Api.ReportingMacIpAntiSpoofLookupStatisticsIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingMacIpAntiSpoofLookupStatisticsIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusMacAntiSpoofLookupStatisticDetail> response = apiInstance.ReportingMacIpAntiSpoofLookupStatisticsIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofLookupStatisticsIpv6Api.ReportingMacIpAntiSpoofLookupStatisticsIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusMacAntiSpoofLookupStatisticDetail**](ShowStatusMacAntiSpoofLookupStatisticDetail.md)

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

