# SonicWallGen7.Api.DecryptionPolicyClientStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDecryptionPoliciesClientGet**](DecryptionPolicyClientStatisticsApi.md#reportingdecryptionpoliciesclientget) | **GET** /reporting/decryption-policies/client |  |
| [**ReportingDecryptionPoliciesClientUuidUUIDGet**](DecryptionPolicyClientStatisticsApi.md#reportingdecryptionpoliciesclientuuiduuidget) | **GET** /reporting/decryption-policies/client/uuid/{UUID} |  |

<a id="reportingdecryptionpoliciesclientget"></a>
# **ReportingDecryptionPoliciesClientGet**
> List&lt;ShowStatusDecryptionPolicySshStatisticsListInner&gt; ReportingDecryptionPoliciesClientGet ()



Retrieve decryption policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDecryptionPoliciesClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientStatisticsApi(config);

            try
            {
                List<ShowStatusDecryptionPolicySshStatisticsListInner> result = apiInstance.ReportingDecryptionPoliciesClientGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientStatisticsApi.ReportingDecryptionPoliciesClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDecryptionPoliciesClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDecryptionPolicySshStatisticsListInner>> response = apiInstance.ReportingDecryptionPoliciesClientGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientStatisticsApi.ReportingDecryptionPoliciesClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDecryptionPolicySshStatisticsListInner&gt;**](ShowStatusDecryptionPolicySshStatisticsListInner.md)

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

<a id="reportingdecryptionpoliciesclientuuiduuidget"></a>
# **ReportingDecryptionPoliciesClientUuidUUIDGet**
> List&lt;ShowStatusDecryptionPolicySshStatisticsListInner&gt; ReportingDecryptionPoliciesClientUuidUUIDGet (string UUID)



Retrieve decryption policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDecryptionPoliciesClientUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientStatisticsApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                List<ShowStatusDecryptionPolicySshStatisticsListInner> result = apiInstance.ReportingDecryptionPoliciesClientUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientStatisticsApi.ReportingDecryptionPoliciesClientUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDecryptionPoliciesClientUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDecryptionPolicySshStatisticsListInner>> response = apiInstance.ReportingDecryptionPoliciesClientUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientStatisticsApi.ReportingDecryptionPoliciesClientUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |

### Return type

[**List&lt;ShowStatusDecryptionPolicySshStatisticsListInner&gt;**](ShowStatusDecryptionPolicySshStatisticsListInner.md)

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

