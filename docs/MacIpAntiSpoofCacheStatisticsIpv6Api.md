# SonicWallGen7.Api.MacIpAntiSpoofCacheStatisticsIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingMacIpAntiSpoofCacheIpv6Get**](MacIpAntiSpoofCacheStatisticsIpv6Api.md#reportingmacipantispoofcacheipv6get) | **GET** /reporting/mac-ip-anti-spoof/cache/ipv6 |  |

<a id="reportingmacipantispoofcacheipv6get"></a>
# **ReportingMacIpAntiSpoofCacheIpv6Get**
> List&lt;ShowStatusMacAntiSpoofCacheListInner&gt; ReportingMacIpAntiSpoofCacheIpv6Get ()



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
    public class ReportingMacIpAntiSpoofCacheIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheStatisticsIpv6Api(config);

            try
            {
                List<ShowStatusMacAntiSpoofCacheListInner> result = apiInstance.ReportingMacIpAntiSpoofCacheIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheStatisticsIpv6Api.ReportingMacIpAntiSpoofCacheIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingMacIpAntiSpoofCacheIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusMacAntiSpoofCacheListInner>> response = apiInstance.ReportingMacIpAntiSpoofCacheIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheStatisticsIpv6Api.ReportingMacIpAntiSpoofCacheIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusMacAntiSpoofCacheListInner&gt;**](ShowStatusMacAntiSpoofCacheListInner.md)

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

