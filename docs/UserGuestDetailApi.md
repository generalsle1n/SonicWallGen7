# SonicWallGen7.Api.UserGuestDetailApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingUserGuestDetailGet**](UserGuestDetailApi.md#reportinguserguestdetailget) | **GET** /reporting/user/guest/detail |  |
| [**ReportingUserGuestDetailNameNAMEGet**](UserGuestDetailApi.md#reportinguserguestdetailnamenameget) | **GET** /reporting/user/guest/detail/name/{NAME} |  |

<a id="reportinguserguestdetailget"></a>
# **ReportingUserGuestDetailGet**
> List&lt;ShowStatusUserGuestUserDetailListInner&gt; ReportingUserGuestDetailGet ()



Retrieve user detail information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingUserGuestDetailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserGuestDetailApi(config);

            try
            {
                List<ShowStatusUserGuestUserDetailListInner> result = apiInstance.ReportingUserGuestDetailGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserGuestDetailApi.ReportingUserGuestDetailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserGuestDetailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusUserGuestUserDetailListInner>> response = apiInstance.ReportingUserGuestDetailGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserGuestDetailApi.ReportingUserGuestDetailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusUserGuestUserDetailListInner&gt;**](ShowStatusUserGuestUserDetailListInner.md)

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

<a id="reportinguserguestdetailnamenameget"></a>
# **ReportingUserGuestDetailNameNAMEGet**
> ShowStatusUserGuestUserDetailDetail ReportingUserGuestDetailNameNAMEGet (string NAME)



Retrieve user detail information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingUserGuestDetailNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserGuestDetailApi(config);
            var NAME = "\"guest1\"";  // string | Guest user name. (default to "guest1")

            try
            {
                ShowStatusUserGuestUserDetailDetail result = apiInstance.ReportingUserGuestDetailNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserGuestDetailApi.ReportingUserGuestDetailNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserGuestDetailNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusUserGuestUserDetailDetail> response = apiInstance.ReportingUserGuestDetailNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserGuestDetailApi.ReportingUserGuestDetailNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Guest user name. | [default to &quot;guest1&quot;] |

### Return type

[**ShowStatusUserGuestUserDetailDetail**](ShowStatusUserGuestUserDetailDetail.md)

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

