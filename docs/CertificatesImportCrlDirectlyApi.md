# SonicWallGen7.Api.CertificatesImportCrlDirectlyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPut**](CertificatesImportCrlDirectlyApi.md#importcertificatescrldirectlycanamenamedisableinvalidatecertificatesput) | **PUT** /import/certificates/crl-directly/ca-name/{NAME}/disable-invalidate-certificates |  |
| [**ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPut**](CertificatesImportCrlDirectlyApi.md#importcertificatescrldirectlycanamenameinvalidatecertificatesput) | **PUT** /import/certificates/crl-directly/ca-name/{NAME}/invalidate-certificates |  |
| [**ImportCertificatesCrlDirectlyCaNameNAMEPut**](CertificatesImportCrlDirectlyApi.md#importcertificatescrldirectlycanamenameput) | **PUT** /import/certificates/crl-directly/ca-name/{NAME} |  |

<a id="importcertificatescrldirectlycanamenamedisableinvalidatecertificatesput"></a>
# **ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPut**
> ApiStatus ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPut (string NAME, Object? body = null)



Import certificate revocation list directly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlDirectlyApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPut(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlDirectlyApi.ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPutWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlDirectlyApi.ImportCertificatesCrlDirectlyCaNameNAMEDisableInvalidateCertificatesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Certificate name. | [default to &quot;my_cert&quot;] |
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

<a id="importcertificatescrldirectlycanamenameinvalidatecertificatesput"></a>
# **ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPut**
> ApiStatus ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPut (string NAME, Object? body = null)



Import certificate revocation list directly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlDirectlyApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPut(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlDirectlyApi.ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPutWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlDirectlyApi.ImportCertificatesCrlDirectlyCaNameNAMEInvalidateCertificatesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Certificate name. | [default to &quot;my_cert&quot;] |
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

<a id="importcertificatescrldirectlycanamenameput"></a>
# **ImportCertificatesCrlDirectlyCaNameNAMEPut**
> ApiStatus ImportCertificatesCrlDirectlyCaNameNAMEPut (string NAME, Object? body = null)



Import certificate revocation list directly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ImportCertificatesCrlDirectlyCaNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlDirectlyApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ImportCertificatesCrlDirectlyCaNameNAMEPut(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlDirectlyApi.ImportCertificatesCrlDirectlyCaNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCertificatesCrlDirectlyCaNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ImportCertificatesCrlDirectlyCaNameNAMEPutWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlDirectlyApi.ImportCertificatesCrlDirectlyCaNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Certificate name. | [default to &quot;my_cert&quot;] |
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

