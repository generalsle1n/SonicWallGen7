# SonicWallGen7.Api.SecurityPolicyIpv6CloneApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloneSecurityPoliciesIpv6Put**](SecurityPolicyIpv6CloneApi.md#clonesecuritypoliciesipv6put) | **PUT** /clone/security-policies/ipv6 |  |

<a id="clonesecuritypoliciesipv6put"></a>
# **CloneSecurityPoliciesIpv6Put**
> ApiStatus CloneSecurityPoliciesIpv6Put (SecurityPolicyIpv6CloneCollection? securityPolicyIpv6CloneCollection = null)



Clone existing Ipv6 security policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CloneSecurityPoliciesIpv6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6CloneApi(config);
            var securityPolicyIpv6CloneCollection = new SecurityPolicyIpv6CloneCollection?(); // SecurityPolicyIpv6CloneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CloneSecurityPoliciesIpv6Put(securityPolicyIpv6CloneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6CloneApi.CloneSecurityPoliciesIpv6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloneSecurityPoliciesIpv6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CloneSecurityPoliciesIpv6PutWithHttpInfo(securityPolicyIpv6CloneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6CloneApi.CloneSecurityPoliciesIpv6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityPolicyIpv6CloneCollection** | [**SecurityPolicyIpv6CloneCollection?**](SecurityPolicyIpv6CloneCollection?.md) |  | [optional]  |

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

