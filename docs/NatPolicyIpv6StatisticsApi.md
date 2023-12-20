# SonicWallGen7.Api.NatPolicyIpv6StatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingNatPoliciesIpv6Get**](NatPolicyIpv6StatisticsApi.md#reportingnatpoliciesipv6get) | **GET** /reporting/nat-policies/ipv6 |  |
| [**ReportingNatPoliciesIpv6UuidUUIDGet**](NatPolicyIpv6StatisticsApi.md#reportingnatpoliciesipv6uuiduuidget) | **GET** /reporting/nat-policies/ipv6/uuid/{UUID} |  |

<a id="reportingnatpoliciesipv6get"></a>
# **ReportingNatPoliciesIpv6Get**
> List&lt;ShowStatusNatPolicyListInner&gt; ReportingNatPoliciesIpv6Get ()



Retrieve IPv6 nat policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingNatPoliciesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv6StatisticsApi(config);

            try
            {
                List<ShowStatusNatPolicyListInner> result = apiInstance.ReportingNatPoliciesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv6StatisticsApi.ReportingNatPoliciesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingNatPoliciesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusNatPolicyListInner>> response = apiInstance.ReportingNatPoliciesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv6StatisticsApi.ReportingNatPoliciesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusNatPolicyListInner&gt;**](ShowStatusNatPolicyListInner.md)

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

<a id="reportingnatpoliciesipv6uuiduuidget"></a>
# **ReportingNatPoliciesIpv6UuidUUIDGet**
> ShowStatusNatPolicyIpv6Detail ReportingNatPoliciesIpv6UuidUUIDGet (string UUID)



Retrieve IPv6 nat policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingNatPoliciesIpv6UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv6StatisticsApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ShowStatusNatPolicyIpv6Detail result = apiInstance.ReportingNatPoliciesIpv6UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv6StatisticsApi.ReportingNatPoliciesIpv6UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingNatPoliciesIpv6UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusNatPolicyIpv6Detail> response = apiInstance.ReportingNatPoliciesIpv6UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv6StatisticsApi.ReportingNatPoliciesIpv6UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**ShowStatusNatPolicyIpv6Detail**](ShowStatusNatPolicyIpv6Detail.md)

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

