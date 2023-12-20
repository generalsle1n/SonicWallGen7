# SonicWallGen7.Api.SslVpnSessionsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingSslVpnSessionsGet**](SslVpnSessionsApi.md#reportingsslvpnsessionsget) | **GET** /reporting/ssl-vpn/sessions |  |

<a id="reportingsslvpnsessionsget"></a>
# **ReportingSslVpnSessionsGet**
> List&lt;ShowStatusSslvpnSessionListInner&gt; ReportingSslVpnSessionsGet ()



Retrieve SSL VPN sessions statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingSslVpnSessionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnSessionsApi(config);

            try
            {
                List<ShowStatusSslvpnSessionListInner> result = apiInstance.ReportingSslVpnSessionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnSessionsApi.ReportingSslVpnSessionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSslVpnSessionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusSslvpnSessionListInner>> response = apiInstance.ReportingSslVpnSessionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnSessionsApi.ReportingSslVpnSessionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusSslvpnSessionListInner&gt;**](ShowStatusSslvpnSessionListInner.md)

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

