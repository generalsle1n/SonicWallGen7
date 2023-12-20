# SonicWallGen7.Api.VpnL2tpServerSessionsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingL2tpServerSessionsGet**](VpnL2tpServerSessionsApi.md#reportingl2tpserversessionsget) | **GET** /reporting/l2tp-server/sessions |  |

<a id="reportingl2tpserversessionsget"></a>
# **ReportingL2tpServerSessionsGet**
> List&lt;ShowStatusL2tpServerSessionsListInner&gt; ReportingL2tpServerSessionsGet ()



Retrieve L2TP server active sessions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingL2tpServerSessionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnL2tpServerSessionsApi(config);

            try
            {
                List<ShowStatusL2tpServerSessionsListInner> result = apiInstance.ReportingL2tpServerSessionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnL2tpServerSessionsApi.ReportingL2tpServerSessionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingL2tpServerSessionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusL2tpServerSessionsListInner>> response = apiInstance.ReportingL2tpServerSessionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnL2tpServerSessionsApi.ReportingL2tpServerSessionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusL2tpServerSessionsListInner&gt;**](ShowStatusL2tpServerSessionsListInner.md)

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

