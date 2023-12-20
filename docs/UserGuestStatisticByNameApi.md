# SonicWallGen7.Api.UserGuestStatisticByNameApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingUserGuestStatisticsGet**](UserGuestStatisticByNameApi.md#reportingusergueststatisticsget) | **GET** /reporting/user/guest/statistics |  |
| [**ReportingUserGuestStatisticsNameNAMEGet**](UserGuestStatisticByNameApi.md#reportingusergueststatisticsnamenameget) | **GET** /reporting/user/guest/statistics/name/{NAME} |  |

<a id="reportingusergueststatisticsget"></a>
# **ReportingUserGuestStatisticsGet**
> List&lt;ShowStatusUserGuestUserBynameStatisticListInner&gt; ReportingUserGuestStatisticsGet ()



Retrieve a guest user statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingUserGuestStatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserGuestStatisticByNameApi(config);

            try
            {
                List<ShowStatusUserGuestUserBynameStatisticListInner> result = apiInstance.ReportingUserGuestStatisticsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserGuestStatisticByNameApi.ReportingUserGuestStatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserGuestStatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusUserGuestUserBynameStatisticListInner>> response = apiInstance.ReportingUserGuestStatisticsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserGuestStatisticByNameApi.ReportingUserGuestStatisticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusUserGuestUserBynameStatisticListInner&gt;**](ShowStatusUserGuestUserBynameStatisticListInner.md)

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

<a id="reportingusergueststatisticsnamenameget"></a>
# **ReportingUserGuestStatisticsNameNAMEGet**
> List&lt;ShowStatusUserGuestUserBynameStatisticListInner&gt; ReportingUserGuestStatisticsNameNAMEGet (string NAME)



Retrieve a guest user statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingUserGuestStatisticsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserGuestStatisticByNameApi(config);
            var NAME = "\"guest1\"";  // string | Guest user name. (default to "guest1")

            try
            {
                List<ShowStatusUserGuestUserBynameStatisticListInner> result = apiInstance.ReportingUserGuestStatisticsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserGuestStatisticByNameApi.ReportingUserGuestStatisticsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserGuestStatisticsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusUserGuestUserBynameStatisticListInner>> response = apiInstance.ReportingUserGuestStatisticsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserGuestStatisticByNameApi.ReportingUserGuestStatisticsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Guest user name. | [default to &quot;guest1&quot;] |

### Return type

[**List&lt;ShowStatusUserGuestUserBynameStatisticListInner&gt;**](ShowStatusUserGuestUserBynameStatisticListInner.md)

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

