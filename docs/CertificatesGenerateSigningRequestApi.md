# SonicWallGen7.Api.CertificatesGenerateSigningRequestApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CertificatesGenerateSigningRequestPost**](CertificatesGenerateSigningRequestApi.md#certificatesgeneratesigningrequestpost) | **POST** /certificates/generate-signing-request |  |

<a id="certificatesgeneratesigningrequestpost"></a>
# **CertificatesGenerateSigningRequestPost**
> ApiStatus CertificatesGenerateSigningRequestPost (CertificatesGenerateSigningRequestCollection? certificatesGenerateSigningRequestCollection = null)



Create a new certificate signing request configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesGenerateSigningRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesGenerateSigningRequestApi(config);
            var certificatesGenerateSigningRequestCollection = new CertificatesGenerateSigningRequestCollection?(); // CertificatesGenerateSigningRequestCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesGenerateSigningRequestPost(certificatesGenerateSigningRequestCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesGenerateSigningRequestApi.CertificatesGenerateSigningRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesGenerateSigningRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesGenerateSigningRequestPostWithHttpInfo(certificatesGenerateSigningRequestCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesGenerateSigningRequestApi.CertificatesGenerateSigningRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **certificatesGenerateSigningRequestCollection** | [**CertificatesGenerateSigningRequestCollection?**](CertificatesGenerateSigningRequestCollection?.md) |  | [optional]  |

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

