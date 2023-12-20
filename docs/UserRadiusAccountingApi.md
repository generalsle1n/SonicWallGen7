# SonicWallGen7.Api.UserRadiusAccountingApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingUserRadiusAccountingServersGet**](UserRadiusAccountingApi.md#reportinguserradiusaccountingserversget) | **GET** /reporting/user/radius/accounting/servers |  |

<a id="reportinguserradiusaccountingserversget"></a>
# **ReportingUserRadiusAccountingServersGet**
> List&lt;ShowStatusRadiusAccountingStatisticsListInner&gt; ReportingUserRadiusAccountingServersGet ()



Retrieve user radius accounting statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingUserRadiusAccountingServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingApi(config);

            try
            {
                List<ShowStatusRadiusAccountingStatisticsListInner> result = apiInstance.ReportingUserRadiusAccountingServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingApi.ReportingUserRadiusAccountingServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserRadiusAccountingServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusRadiusAccountingStatisticsListInner>> response = apiInstance.ReportingUserRadiusAccountingServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingApi.ReportingUserRadiusAccountingServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusRadiusAccountingStatisticsListInner&gt;**](ShowStatusRadiusAccountingStatisticsListInner.md)

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

