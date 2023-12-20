# SonicWallGen7.Api.UserTacacsAccountingApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingUserTacacsAccountingServersGet**](UserTacacsAccountingApi.md#reportingusertacacsaccountingserversget) | **GET** /reporting/user/tacacs/accounting/servers |  |

<a id="reportingusertacacsaccountingserversget"></a>
# **ReportingUserTacacsAccountingServersGet**
> List&lt;ShowStatusRadiusAccountingStatisticsListInner&gt; ReportingUserTacacsAccountingServersGet ()



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
    public class ReportingUserTacacsAccountingServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingApi(config);

            try
            {
                List<ShowStatusRadiusAccountingStatisticsListInner> result = apiInstance.ReportingUserTacacsAccountingServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingApi.ReportingUserTacacsAccountingServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserTacacsAccountingServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusRadiusAccountingStatisticsListInner>> response = apiInstance.ReportingUserTacacsAccountingServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingApi.ReportingUserTacacsAccountingServersGetWithHttpInfo: " + e.Message);
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

