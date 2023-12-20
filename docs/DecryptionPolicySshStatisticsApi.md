# SonicWallGen7.Api.DecryptionPolicySshStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDecryptionPoliciesSshGet**](DecryptionPolicySshStatisticsApi.md#reportingdecryptionpoliciessshget) | **GET** /reporting/decryption-policies/ssh |  |
| [**ReportingDecryptionPoliciesSshUuidUUIDGet**](DecryptionPolicySshStatisticsApi.md#reportingdecryptionpoliciessshuuiduuidget) | **GET** /reporting/decryption-policies/ssh/uuid/{UUID} |  |

<a id="reportingdecryptionpoliciessshget"></a>
# **ReportingDecryptionPoliciesSshGet**
> List&lt;ShowStatusDecryptionPolicySshStatisticsListInner&gt; ReportingDecryptionPoliciesSshGet ()



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
    public class ReportingDecryptionPoliciesSshGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshStatisticsApi(config);

            try
            {
                List<ShowStatusDecryptionPolicySshStatisticsListInner> result = apiInstance.ReportingDecryptionPoliciesSshGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshStatisticsApi.ReportingDecryptionPoliciesSshGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDecryptionPoliciesSshGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDecryptionPolicySshStatisticsListInner>> response = apiInstance.ReportingDecryptionPoliciesSshGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshStatisticsApi.ReportingDecryptionPoliciesSshGetWithHttpInfo: " + e.Message);
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

<a id="reportingdecryptionpoliciessshuuiduuidget"></a>
# **ReportingDecryptionPoliciesSshUuidUUIDGet**
> List&lt;ShowStatusDecryptionPolicySshStatisticsListInner&gt; ReportingDecryptionPoliciesSshUuidUUIDGet (string UUID)



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
    public class ReportingDecryptionPoliciesSshUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshStatisticsApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                List<ShowStatusDecryptionPolicySshStatisticsListInner> result = apiInstance.ReportingDecryptionPoliciesSshUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshStatisticsApi.ReportingDecryptionPoliciesSshUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDecryptionPoliciesSshUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDecryptionPolicySshStatisticsListInner>> response = apiInstance.ReportingDecryptionPoliciesSshUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshStatisticsApi.ReportingDecryptionPoliciesSshUuidUUIDGetWithHttpInfo: " + e.Message);
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

