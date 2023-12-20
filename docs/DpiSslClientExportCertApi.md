# SonicWallGen7.Api.DpiSslClientExportCertApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportDpiSslClientCertificateDefault2048BitGet**](DpiSslClientExportCertApi.md#exportdpisslclientcertificatedefault2048bitget) | **GET** /export/dpi-ssl-client/certificate/default-2048-bit |  |
| [**ExportDpiSslClientCertificateDefaultGet**](DpiSslClientExportCertApi.md#exportdpisslclientcertificatedefaultget) | **GET** /export/dpi-ssl-client/certificate/default |  |

<a id="exportdpisslclientcertificatedefault2048bitget"></a>
# **ExportDpiSslClientCertificateDefault2048BitGet**
> Object ExportDpiSslClientCertificateDefault2048BitGet ()



Export DPI-SSL client certificate to file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportDpiSslClientCertificateDefault2048BitGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientExportCertApi(config);

            try
            {
                Object result = apiInstance.ExportDpiSslClientCertificateDefault2048BitGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientExportCertApi.ExportDpiSslClientCertificateDefault2048BitGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportDpiSslClientCertificateDefault2048BitGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportDpiSslClientCertificateDefault2048BitGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientExportCertApi.ExportDpiSslClientCertificateDefault2048BitGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="exportdpisslclientcertificatedefaultget"></a>
# **ExportDpiSslClientCertificateDefaultGet**
> Object ExportDpiSslClientCertificateDefaultGet ()



Export DPI-SSL client certificate to file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportDpiSslClientCertificateDefaultGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientExportCertApi(config);

            try
            {
                Object result = apiInstance.ExportDpiSslClientCertificateDefaultGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientExportCertApi.ExportDpiSslClientCertificateDefaultGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportDpiSslClientCertificateDefaultGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportDpiSslClientCertificateDefaultGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientExportCertApi.ExportDpiSslClientCertificateDefaultGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

