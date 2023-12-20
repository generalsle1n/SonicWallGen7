# SonicWallGen7.Api.DiagAdvancedDnsSecurityApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedDnsSecurityGet**](DiagAdvancedDnsSecurityApi.md#diagadvanceddnssecurityget) | **GET** /diag/advanced/dns-security |  |
| [**DiagAdvancedDnsSecurityPut**](DiagAdvancedDnsSecurityApi.md#diagadvanceddnssecurityput) | **PUT** /diag/advanced/dns-security |  |

<a id="diagadvanceddnssecurityget"></a>
# **DiagAdvancedDnsSecurityGet**
> DiagAdvancedDnsSecurity DiagAdvancedDnsSecurityGet ()



Retrieve advanced diag DNS security configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedDnsSecurityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedDnsSecurityApi(config);

            try
            {
                DiagAdvancedDnsSecurity result = apiInstance.DiagAdvancedDnsSecurityGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedDnsSecurityApi.DiagAdvancedDnsSecurityGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedDnsSecurityGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedDnsSecurity> response = apiInstance.DiagAdvancedDnsSecurityGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedDnsSecurityApi.DiagAdvancedDnsSecurityGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedDnsSecurity**](DiagAdvancedDnsSecurity.md)

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

<a id="diagadvanceddnssecurityput"></a>
# **DiagAdvancedDnsSecurityPut**
> ApiStatus DiagAdvancedDnsSecurityPut (DiagAdvancedDnsSecurity? diagAdvancedDnsSecurity = null)



Update advanced diag DNS security configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedDnsSecurityPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedDnsSecurityApi(config);
            var diagAdvancedDnsSecurity = new DiagAdvancedDnsSecurity?(); // DiagAdvancedDnsSecurity? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedDnsSecurityPut(diagAdvancedDnsSecurity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedDnsSecurityApi.DiagAdvancedDnsSecurityPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedDnsSecurityPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedDnsSecurityPutWithHttpInfo(diagAdvancedDnsSecurity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedDnsSecurityApi.DiagAdvancedDnsSecurityPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedDnsSecurity** | [**DiagAdvancedDnsSecurity?**](DiagAdvancedDnsSecurity?.md) |  | [optional]  |

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

