# SonicWallGen7.Api.RoutePolicyIpv6SystemApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingRoutePoliciesIpv6SystemGet**](RoutePolicyIpv6SystemApi.md#reportingroutepoliciesipv6systemget) | **GET** /reporting/route-policies/ipv6/system |  |

<a id="reportingroutepoliciesipv6systemget"></a>
# **ReportingRoutePoliciesIpv6SystemGet**
> List&lt;ShowStatusRoutingV4SystemListInner&gt; ReportingRoutePoliciesIpv6SystemGet ()



Retrieve IPv6 route policies system statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingRoutePoliciesIpv6SystemGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RoutePolicyIpv6SystemApi(config);

            try
            {
                List<ShowStatusRoutingV4SystemListInner> result = apiInstance.ReportingRoutePoliciesIpv6SystemGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutePolicyIpv6SystemApi.ReportingRoutePoliciesIpv6SystemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingRoutePoliciesIpv6SystemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusRoutingV4SystemListInner>> response = apiInstance.ReportingRoutePoliciesIpv6SystemGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutePolicyIpv6SystemApi.ReportingRoutePoliciesIpv6SystemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusRoutingV4SystemListInner&gt;**](ShowStatusRoutingV4SystemListInner.md)

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

