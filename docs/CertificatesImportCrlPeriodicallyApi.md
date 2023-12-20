# SonicWallGen7.Api.CertificatesImportCrlPeriodicallyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPost**](CertificatesImportCrlPeriodicallyApi.md#certificatesimportcrlperiodicallycanamenameurlcrlurldisableinvalidatecertificatespost) | **POST** /certificates/import/crl-periodically/ca-name/{NAME}/url/{CRLURL}/disable-invalidate-certificates |  |
| [**CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPost**](CertificatesImportCrlPeriodicallyApi.md#certificatesimportcrlperiodicallycanamenameurlcrlurlinvalidatecertificatespost) | **POST** /certificates/import/crl-periodically/ca-name/{NAME}/url/{CRLURL}/invalidate-certificates |  |
| [**CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPost**](CertificatesImportCrlPeriodicallyApi.md#certificatesimportcrlperiodicallycanamenameurlcrlurlpost) | **POST** /certificates/import/crl-periodically/ca-name/{NAME}/url/{CRLURL} |  |

<a id="certificatesimportcrlperiodicallycanamenameurlcrlurldisableinvalidatecertificatespost"></a>
# **CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPost**
> ApiStatus CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPost (string NAME, string CRLURL, Object? body = null)



Periodically auto-import certificate revocation list via HTTP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlPeriodicallyApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var CRLURL = "\"http://www.example.com/products/\"";  // string | URL in the form: http://host/file (default to "http://www.example.com/products/")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPost(NAME, CRLURL, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlPeriodicallyApi.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPostWithHttpInfo(NAME, CRLURL, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlPeriodicallyApi.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLDisableInvalidateCertificatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Certificate name. | [default to &quot;my_cert&quot;] |
| **CRLURL** | **string** | URL in the form: http://host/file | [default to &quot;http://www.example.com/products/&quot;] |
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

<a id="certificatesimportcrlperiodicallycanamenameurlcrlurlinvalidatecertificatespost"></a>
# **CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPost**
> ApiStatus CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPost (string NAME, string CRLURL, Object? body = null)



Periodically auto-import certificate revocation list via HTTP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlPeriodicallyApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var CRLURL = "\"http://www.example.com/products/\"";  // string | URL in the form: http://host/file (default to "http://www.example.com/products/")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPost(NAME, CRLURL, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlPeriodicallyApi.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPostWithHttpInfo(NAME, CRLURL, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlPeriodicallyApi.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLInvalidateCertificatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Certificate name. | [default to &quot;my_cert&quot;] |
| **CRLURL** | **string** | URL in the form: http://host/file | [default to &quot;http://www.example.com/products/&quot;] |
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

<a id="certificatesimportcrlperiodicallycanamenameurlcrlurlpost"></a>
# **CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPost**
> ApiStatus CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPost (string NAME, string CRLURL, Object? body = null)



Periodically auto-import certificate revocation list via HTTP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCrlPeriodicallyApi(config);
            var NAME = "\"my_cert\"";  // string | Certificate name. (default to "my_cert")
            var CRLURL = "\"http://www.example.com/products/\"";  // string | URL in the form: http://host/file (default to "http://www.example.com/products/")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPost(NAME, CRLURL, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCrlPeriodicallyApi.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPostWithHttpInfo(NAME, CRLURL, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCrlPeriodicallyApi.CertificatesImportCrlPeriodicallyCaNameNAMEUrlCRLURLPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Certificate name. | [default to &quot;my_cert&quot;] |
| **CRLURL** | **string** | URL in the form: http://host/file | [default to &quot;http://www.example.com/products/&quot;] |
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

