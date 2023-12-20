# SonicWallGen7.Api.SecurityPoliciesMaxCountApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurityPoliciesMaxCountGet**](SecurityPoliciesMaxCountApi.md#securitypoliciesmaxcountget) | **GET** /security-policies/max-count |  |
| [**SecurityPoliciesMaxCountPut**](SecurityPoliciesMaxCountApi.md#securitypoliciesmaxcountput) | **PUT** /security-policies/max-count |  |

<a id="securitypoliciesmaxcountget"></a>
# **SecurityPoliciesMaxCountGet**
> SecurityPoliciesMaxCount SecurityPoliciesMaxCountGet ()



Retrieve security policies max count configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesMaxCountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPoliciesMaxCountApi(config);

            try
            {
                SecurityPoliciesMaxCount result = apiInstance.SecurityPoliciesMaxCountGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPoliciesMaxCountApi.SecurityPoliciesMaxCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesMaxCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityPoliciesMaxCount> response = apiInstance.SecurityPoliciesMaxCountGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPoliciesMaxCountApi.SecurityPoliciesMaxCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SecurityPoliciesMaxCount**](SecurityPoliciesMaxCount.md)

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

<a id="securitypoliciesmaxcountput"></a>
# **SecurityPoliciesMaxCountPut**
> ApiStatus SecurityPoliciesMaxCountPut (SecurityPoliciesMaxCount? securityPoliciesMaxCount = null)



Update security policies max countconfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesMaxCountPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPoliciesMaxCountApi(config);
            var securityPoliciesMaxCount = new SecurityPoliciesMaxCount?(); // SecurityPoliciesMaxCount? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesMaxCountPut(securityPoliciesMaxCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPoliciesMaxCountApi.SecurityPoliciesMaxCountPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesMaxCountPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesMaxCountPutWithHttpInfo(securityPoliciesMaxCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPoliciesMaxCountApi.SecurityPoliciesMaxCountPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityPoliciesMaxCount** | [**SecurityPoliciesMaxCount?**](SecurityPoliciesMaxCount?.md) |  | [optional]  |

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

