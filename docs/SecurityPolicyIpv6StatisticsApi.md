# SonicWallGen7.Api.SecurityPolicyIpv6StatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingSecurityPoliciesIpv6Get**](SecurityPolicyIpv6StatisticsApi.md#reportingsecuritypoliciesipv6get) | **GET** /reporting/security-policies/ipv6 |  |
| [**ReportingSecurityPoliciesIpv6UuidUUIDDelete**](SecurityPolicyIpv6StatisticsApi.md#reportingsecuritypoliciesipv6uuiduuiddelete) | **DELETE** /reporting/security-policies/ipv6/uuid/{UUID} |  |
| [**ReportingSecurityPoliciesIpv6UuidUUIDGet**](SecurityPolicyIpv6StatisticsApi.md#reportingsecuritypoliciesipv6uuiduuidget) | **GET** /reporting/security-policies/ipv6/uuid/{UUID} |  |

<a id="reportingsecuritypoliciesipv6get"></a>
# **ReportingSecurityPoliciesIpv6Get**
> List&lt;ShowStatusSecurityPoliciesStatusListInner&gt; ReportingSecurityPoliciesIpv6Get ()



Retrieve IPv6 security policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSecurityPoliciesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6StatisticsApi(config);

            try
            {
                List<ShowStatusSecurityPoliciesStatusListInner> result = apiInstance.ReportingSecurityPoliciesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6StatisticsApi.ReportingSecurityPoliciesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSecurityPoliciesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusSecurityPoliciesStatusListInner>> response = apiInstance.ReportingSecurityPoliciesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6StatisticsApi.ReportingSecurityPoliciesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusSecurityPoliciesStatusListInner&gt;**](ShowStatusSecurityPoliciesStatusListInner.md)

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

<a id="reportingsecuritypoliciesipv6uuiduuiddelete"></a>
# **ReportingSecurityPoliciesIpv6UuidUUIDDelete**
> ApiStatus ReportingSecurityPoliciesIpv6UuidUUIDDelete (string UUID)



Clear IPv6 security policy statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSecurityPoliciesIpv6UuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6StatisticsApi(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")

            try
            {
                ApiStatus result = apiInstance.ReportingSecurityPoliciesIpv6UuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6StatisticsApi.ReportingSecurityPoliciesIpv6UuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSecurityPoliciesIpv6UuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingSecurityPoliciesIpv6UuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6StatisticsApi.ReportingSecurityPoliciesIpv6UuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportingsecuritypoliciesipv6uuiduuidget"></a>
# **ReportingSecurityPoliciesIpv6UuidUUIDGet**
> ShowStatusSecurityPoliciesStatusDetail ReportingSecurityPoliciesIpv6UuidUUIDGet (string UUID)



Retrieve IPv6 security policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSecurityPoliciesIpv6UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6StatisticsApi(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")

            try
            {
                ShowStatusSecurityPoliciesStatusDetail result = apiInstance.ReportingSecurityPoliciesIpv6UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6StatisticsApi.ReportingSecurityPoliciesIpv6UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSecurityPoliciesIpv6UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusSecurityPoliciesStatusDetail> response = apiInstance.ReportingSecurityPoliciesIpv6UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6StatisticsApi.ReportingSecurityPoliciesIpv6UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |

### Return type

[**ShowStatusSecurityPoliciesStatusDetail**](ShowStatusSecurityPoliciesStatusDetail.md)

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

