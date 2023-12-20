# SonicWallGen7.Api.CertificatesImportCrlApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPost**](CertificatesImportCrlApi.md#certificatesimportcrlcanamenamedisableinvalidatecertificatespost) | **POST** /certificates/import/crl/ca-name/{NAME}/disable-invalidate-certificates |  |
| [**CertificatesImportCrlCaNameNAMEInvalidateCertificatesPost**](CertificatesImportCrlApi.md#certificatesimportcrlcanamenameinvalidatecertificatespost) | **POST** /certificates/import/crl/ca-name/{NAME}/invalidate-certificates |  |
| [**CertificatesImportCrlCaNameNAMEPost**](CertificatesImportCrlApi.md#certificatesimportcrlcanamenamepost) | **POST** /certificates/import/crl/ca-name/{NAME} |  |

<a id="certificatesimportcrlcanamenamedisableinvalidatecertificatespost"></a>
# **CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPost**
> ApiStatus CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPost (string NAME, Object? body = null)



Import certificate revocation list or set the location to periodically download via HTTP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPost(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlApi.CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPostWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlApi.CertificatesImportCrlCaNameNAMEDisableInvalidateCertificatesPostWithHttpInfo: " + e.Message);
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

<a id="certificatesimportcrlcanamenameinvalidatecertificatespost"></a>
# **CertificatesImportCrlCaNameNAMEInvalidateCertificatesPost**
> ApiStatus CertificatesImportCrlCaNameNAMEInvalidateCertificatesPost (string NAME, Object? body = null)



Import certificate revocation list or set the location to periodically download via HTTP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesImportCrlCaNameNAMEInvalidateCertificatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesImportCrlCaNameNAMEInvalidateCertificatesPost(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlApi.CertificatesImportCrlCaNameNAMEInvalidateCertificatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesImportCrlCaNameNAMEInvalidateCertificatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesImportCrlCaNameNAMEInvalidateCertificatesPostWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlApi.CertificatesImportCrlCaNameNAMEInvalidateCertificatesPostWithHttpInfo: " + e.Message);
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

<a id="certificatesimportcrlcanamenamepost"></a>
# **CertificatesImportCrlCaNameNAMEPost**
> ApiStatus CertificatesImportCrlCaNameNAMEPost (string NAME, Object? body = null)



Import certificate revocation list or set the location to periodically download via HTTP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesImportCrlCaNameNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesImportCrlCaNameNAMEPost(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlApi.CertificatesImportCrlCaNameNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesImportCrlCaNameNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesImportCrlCaNameNAMEPostWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlApi.CertificatesImportCrlCaNameNAMEPostWithHttpInfo: " + e.Message);
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

