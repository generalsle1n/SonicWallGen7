# SonicWallGen7.Api.MacIpAntiSpoofDetectedListIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingMacIpAntiSpoofDetectedListIpv4Get**](MacIpAntiSpoofDetectedListIpv4Api.md#reportingmacipantispoofdetectedlistipv4get) | **GET** /reporting/mac-ip-anti-spoof/detected-list/ipv4 |  |

<a id="reportingmacipantispoofdetectedlistipv4get"></a>
# **ReportingMacIpAntiSpoofDetectedListIpv4Get**
> List&lt;ShowStatusMacAntiSpoofListInner&gt; ReportingMacIpAntiSpoofDetectedListIpv4Get ()



Retrieve MAC IPv4 anti-spoof detected list statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingMacIpAntiSpoofDetectedListIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofDetectedListIpv4Api(config);

            try
            {
                List<ShowStatusMacAntiSpoofListInner> result = apiInstance.ReportingMacIpAntiSpoofDetectedListIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofDetectedListIpv4Api.ReportingMacIpAntiSpoofDetectedListIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingMacIpAntiSpoofDetectedListIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusMacAntiSpoofListInner>> response = apiInstance.ReportingMacIpAntiSpoofDetectedListIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofDetectedListIpv4Api.ReportingMacIpAntiSpoofDetectedListIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusMacAntiSpoofListInner&gt;**](ShowStatusMacAntiSpoofListInner.md)

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

