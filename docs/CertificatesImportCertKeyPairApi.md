# SonicWallGen7.Api.CertificatesImportCertKeyPairApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPut**](CertificatesImportCertKeyPairApi.md#importcertificatescertkeypairnamenamepasswordpasswdput) | **PUT** /import/certificates/cert-key-pair/name/{NAME}/password/{PASSWD} |  |

<a id="importcertificatescertkeypairnamenamepasswordpasswdput"></a>
# **ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPut**
> ApiStatus ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPut (string NAME, string PASSWD, Object? body = null)



Import certificate signing request or certificate / key pair.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CertificatesImportCertKeyPairApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var PASSWD = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPut(NAME, PASSWD, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesImportCertKeyPairApi.ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPutWithHttpInfo(NAME, PASSWD, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesImportCertKeyPairApi.ImportCertificatesCertKeyPairNameNAMEPasswordPASSWDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **PASSWD** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
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

