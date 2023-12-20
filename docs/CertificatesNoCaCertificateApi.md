# SonicWallGen7.Api.CertificatesNoCaCertificateApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CertificatesCaCAHASHDelete**](CertificatesNoCaCertificateApi.md#certificatescacahashdelete) | **DELETE** /certificates/ca/{CAHASH} |  |

<a id="certificatescacahashdelete"></a>
# **CertificatesCaCAHASHDelete**
> ApiStatus CertificatesCaCAHASHDelete (string CAHASH)



Delete CA certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesCaCAHASHDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesNoCaCertificateApi(config);
            var CAHASH = "\"rBMtDf8pTii9doixKqNtcw==\"";  // string | CA Certificate hash. (default to "rBMtDf8pTii9doixKqNtcw==")

            try
            {
                ApiStatus result = apiInstance.CertificatesCaCAHASHDelete(CAHASH);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesNoCaCertificateApi.CertificatesCaCAHASHDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesCaCAHASHDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesCaCAHASHDeleteWithHttpInfo(CAHASH);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesNoCaCertificateApi.CertificatesCaCAHASHDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CAHASH** | **string** | CA Certificate hash. | [default to &quot;rBMtDf8pTii9doixKqNtcw&#x3D;&#x3D;&quot;] |

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

