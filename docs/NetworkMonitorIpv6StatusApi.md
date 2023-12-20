# SonicWallGen7.Api.NetworkMonitorIpv6StatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingNetworkMonitorPoliciesIpv6Get**](NetworkMonitorIpv6StatusApi.md#reportingnetworkmonitorpoliciesipv6get) | **GET** /reporting/network-monitor/policies/ipv6 |  |
| [**ReportingNetworkMonitorPoliciesIpv6NameNAMEGet**](NetworkMonitorIpv6StatusApi.md#reportingnetworkmonitorpoliciesipv6namenameget) | **GET** /reporting/network-monitor/policies/ipv6/name/{NAME} |  |

<a id="reportingnetworkmonitorpoliciesipv6get"></a>
# **ReportingNetworkMonitorPoliciesIpv6Get**
> List&lt;ShowStatusNetmonPolicyListInner&gt; ReportingNetworkMonitorPoliciesIpv6Get ()



Retrieve network monitor IPv6 policies status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingNetworkMonitorPoliciesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6StatusApi(config);

            try
            {
                List<ShowStatusNetmonPolicyListInner> result = apiInstance.ReportingNetworkMonitorPoliciesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6StatusApi.ReportingNetworkMonitorPoliciesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingNetworkMonitorPoliciesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusNetmonPolicyListInner>> response = apiInstance.ReportingNetworkMonitorPoliciesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6StatusApi.ReportingNetworkMonitorPoliciesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusNetmonPolicyListInner&gt;**](ShowStatusNetmonPolicyListInner.md)

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

<a id="reportingnetworkmonitorpoliciesipv6namenameget"></a>
# **ReportingNetworkMonitorPoliciesIpv6NameNAMEGet**
> ShowStatusNetmonPolicyDetail ReportingNetworkMonitorPoliciesIpv6NameNAMEGet (string NAME)



Retrieve network monitor IPv6 policies status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingNetworkMonitorPoliciesIpv6NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6StatusApi(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                ShowStatusNetmonPolicyDetail result = apiInstance.ReportingNetworkMonitorPoliciesIpv6NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6StatusApi.ReportingNetworkMonitorPoliciesIpv6NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingNetworkMonitorPoliciesIpv6NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusNetmonPolicyDetail> response = apiInstance.ReportingNetworkMonitorPoliciesIpv6NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6StatusApi.ReportingNetworkMonitorPoliciesIpv6NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |

### Return type

[**ShowStatusNetmonPolicyDetail**](ShowStatusNetmonPolicyDetail.md)

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

