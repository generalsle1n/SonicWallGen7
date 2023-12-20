# SonicWallGen7.Api.CipherControlTlsCipherListApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingCipherControlTlsCipherListGet**](CipherControlTlsCipherListApi.md#reportingciphercontroltlscipherlistget) | **GET** /reporting/cipher-control/tls-cipher-list |  |

<a id="reportingciphercontroltlscipherlistget"></a>
# **ReportingCipherControlTlsCipherListGet**
> List&lt;ShowStatusCipherControlTlsCipherListInner&gt; ReportingCipherControlTlsCipherListGet ()



Retrieve cipher control TLS cipher lists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingCipherControlTlsCipherListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CipherControlTlsCipherListApi(config);

            try
            {
                List<ShowStatusCipherControlTlsCipherListInner> result = apiInstance.ReportingCipherControlTlsCipherListGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CipherControlTlsCipherListApi.ReportingCipherControlTlsCipherListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingCipherControlTlsCipherListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusCipherControlTlsCipherListInner>> response = apiInstance.ReportingCipherControlTlsCipherListGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CipherControlTlsCipherListApi.ReportingCipherControlTlsCipherListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusCipherControlTlsCipherListInner&gt;**](ShowStatusCipherControlTlsCipherListInner.md)

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

