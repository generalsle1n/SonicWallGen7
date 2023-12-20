# SonicWallGen7.Api.RoutePolicyIpv6DynamicApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingRoutePoliciesIpv6DynamicGet**](RoutePolicyIpv6DynamicApi.md#reportingroutepoliciesipv6dynamicget) | **GET** /reporting/route-policies/ipv6/dynamic |  |

<a id="reportingroutepoliciesipv6dynamicget"></a>
# **ReportingRoutePoliciesIpv6DynamicGet**
> List&lt;ShowStatusRoutingV4DynamicListInner&gt; ReportingRoutePoliciesIpv6DynamicGet ()



Retrieve IPv6 route policies dynamic statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingRoutePoliciesIpv6DynamicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RoutePolicyIpv6DynamicApi(config);

            try
            {
                List<ShowStatusRoutingV4DynamicListInner> result = apiInstance.ReportingRoutePoliciesIpv6DynamicGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutePolicyIpv6DynamicApi.ReportingRoutePoliciesIpv6DynamicGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingRoutePoliciesIpv6DynamicGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusRoutingV4DynamicListInner>> response = apiInstance.ReportingRoutePoliciesIpv6DynamicGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutePolicyIpv6DynamicApi.ReportingRoutePoliciesIpv6DynamicGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusRoutingV4DynamicListInner&gt;**](ShowStatusRoutingV4DynamicListInner.md)

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

