# SonicWallGen7.Api.NatPolicyIpv4StatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingNatPoliciesIpv4Get**](NatPolicyIpv4StatisticsApi.md#reportingnatpoliciesipv4get) | **GET** /reporting/nat-policies/ipv4 |  |
| [**ReportingNatPoliciesIpv4UuidUUIDGet**](NatPolicyIpv4StatisticsApi.md#reportingnatpoliciesipv4uuiduuidget) | **GET** /reporting/nat-policies/ipv4/uuid/{UUID} |  |

<a id="reportingnatpoliciesipv4get"></a>
# **ReportingNatPoliciesIpv4Get**
> List&lt;ShowStatusNatPolicyListInner&gt; ReportingNatPoliciesIpv4Get ()



Retrieve IPv4 nat policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingNatPoliciesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4StatisticsApi(config);

            try
            {
                List<ShowStatusNatPolicyListInner> result = apiInstance.ReportingNatPoliciesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4StatisticsApi.ReportingNatPoliciesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingNatPoliciesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusNatPolicyListInner>> response = apiInstance.ReportingNatPoliciesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4StatisticsApi.ReportingNatPoliciesIpv4GetWithHttpInfo: " + e.Message);
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

<a id="reportingnatpoliciesipv4uuiduuidget"></a>
# **ReportingNatPoliciesIpv4UuidUUIDGet**
> ShowStatusNatPolicyDetail ReportingNatPoliciesIpv4UuidUUIDGet (string UUID)



Retrieve IPv4 nat policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingNatPoliciesIpv4UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4StatisticsApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ShowStatusNatPolicyDetail result = apiInstance.ReportingNatPoliciesIpv4UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4StatisticsApi.ReportingNatPoliciesIpv4UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingNatPoliciesIpv4UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusNatPolicyDetail> response = apiInstance.ReportingNatPoliciesIpv4UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4StatisticsApi.ReportingNatPoliciesIpv4UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**ShowStatusNatPolicyDetail**](ShowStatusNatPolicyDetail.md)

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

