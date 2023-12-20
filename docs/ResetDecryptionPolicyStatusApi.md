# SonicWallGen7.Api.ResetDecryptionPolicyStatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResetDecryptionPoliciesStatisticsPost**](ResetDecryptionPolicyStatusApi.md#resetdecryptionpoliciesstatisticspost) | **POST** /reset/decryption-policies/statistics |  |
| [**ResetDecryptionPoliciesStatisticsUuidUUIDPost**](ResetDecryptionPolicyStatusApi.md#resetdecryptionpoliciesstatisticsuuiduuidpost) | **POST** /reset/decryption-policies/statistics/uuid/{UUID} |  |

<a id="resetdecryptionpoliciesstatisticspost"></a>
# **ResetDecryptionPoliciesStatisticsPost**
> ApiStatus ResetDecryptionPoliciesStatisticsPost (Object? body = null)



Reset decryption policy statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ResetDecryptionPoliciesStatisticsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ResetDecryptionPolicyStatusApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ResetDecryptionPoliciesStatisticsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResetDecryptionPolicyStatusApi.ResetDecryptionPoliciesStatisticsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetDecryptionPoliciesStatisticsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ResetDecryptionPoliciesStatisticsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResetDecryptionPolicyStatusApi.ResetDecryptionPoliciesStatisticsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resetdecryptionpoliciesstatisticsuuiduuidpost"></a>
# **ResetDecryptionPoliciesStatisticsUuidUUIDPost**
> ApiStatus ResetDecryptionPoliciesStatisticsUuidUUIDPost (string UUID, Object? body = null)



Reset decryption policy statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ResetDecryptionPoliciesStatisticsUuidUUIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ResetDecryptionPolicyStatusApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ResetDecryptionPoliciesStatisticsUuidUUIDPost(UUID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResetDecryptionPolicyStatusApi.ResetDecryptionPoliciesStatisticsUuidUUIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetDecryptionPoliciesStatisticsUuidUUIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ResetDecryptionPoliciesStatisticsUuidUUIDPostWithHttpInfo(UUID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResetDecryptionPolicyStatusApi.ResetDecryptionPoliciesStatisticsUuidUUIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |
| **body** | **Object?** |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

