# SonicWallGen7.Api.DecryptionPolicyServerCloneApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloneDecryptionPoliciesServerPut**](DecryptionPolicyServerCloneApi.md#clonedecryptionpoliciesserverput) | **PUT** /clone/decryption-policies/server |  |

<a id="clonedecryptionpoliciesserverput"></a>
# **CloneDecryptionPoliciesServerPut**
> ApiStatus CloneDecryptionPoliciesServerPut (DecryptionPolicyServerCloneCollection? decryptionPolicyServerCloneCollection = null)



Clone existing server decryption policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CloneDecryptionPoliciesServerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerCloneApi(config);
            var decryptionPolicyServerCloneCollection = new DecryptionPolicyServerCloneCollection?(); // DecryptionPolicyServerCloneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CloneDecryptionPoliciesServerPut(decryptionPolicyServerCloneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerCloneApi.CloneDecryptionPoliciesServerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloneDecryptionPoliciesServerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CloneDecryptionPoliciesServerPutWithHttpInfo(decryptionPolicyServerCloneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerCloneApi.CloneDecryptionPoliciesServerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicyServerCloneCollection** | [**DecryptionPolicyServerCloneCollection?**](DecryptionPolicyServerCloneCollection?.md) |  | [optional]  |

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

