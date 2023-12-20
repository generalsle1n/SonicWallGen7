# SonicWallGen7.Api.RoutePolicyDynamicApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingRoutePoliciesIpv4DynamicGet**](RoutePolicyDynamicApi.md#reportingroutepoliciesipv4dynamicget) | **GET** /reporting/route-policies/ipv4/dynamic |  |

<a id="reportingroutepoliciesipv4dynamicget"></a>
# **ReportingRoutePoliciesIpv4DynamicGet**
> List&lt;ShowStatusRoutingV4DynamicListInner&gt; ReportingRoutePoliciesIpv4DynamicGet ()



Retrieve IPv4 route policies dynamic statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingRoutePoliciesIpv4DynamicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RoutePolicyDynamicApi(config);

            try
            {
                List<ShowStatusRoutingV4DynamicListInner> result = apiInstance.ReportingRoutePoliciesIpv4DynamicGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutePolicyDynamicApi.ReportingRoutePoliciesIpv4DynamicGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingRoutePoliciesIpv4DynamicGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusRoutingV4DynamicListInner>> response = apiInstance.ReportingRoutePoliciesIpv4DynamicGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutePolicyDynamicApi.ReportingRoutePoliciesIpv4DynamicGetWithHttpInfo: " + e.Message);
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

