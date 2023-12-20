# SonicWallGen7.Api.UserGuestStatisticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingUserGuestStatisticIpUSERIPDelete**](UserGuestStatisticApi.md#reportingusergueststatisticipuseripdelete) | **DELETE** /reporting/user/guest/statistic/ip/{USERIP} |  |
| [**ReportingUserGuestStatisticIpUSERIPGet**](UserGuestStatisticApi.md#reportingusergueststatisticipuseripget) | **GET** /reporting/user/guest/statistic/ip/{USERIP} |  |

<a id="reportingusergueststatisticipuseripdelete"></a>
# **ReportingUserGuestStatisticIpUSERIPDelete**
> ApiStatus ReportingUserGuestStatisticIpUSERIPDelete (string USERIP)



Clear a guest user statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingUserGuestStatisticIpUSERIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserGuestStatisticApi(config);
            var USERIP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")

            try
            {
                ApiStatus result = apiInstance.ReportingUserGuestStatisticIpUSERIPDelete(USERIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserGuestStatisticApi.ReportingUserGuestStatisticIpUSERIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserGuestStatisticIpUSERIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingUserGuestStatisticIpUSERIPDeleteWithHttpInfo(USERIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserGuestStatisticApi.ReportingUserGuestStatisticIpUSERIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERIP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportingusergueststatisticipuseripget"></a>
# **ReportingUserGuestStatisticIpUSERIPGet**
> ShowStatusUserGuestUserStatisticDetail ReportingUserGuestStatisticIpUSERIPGet (string USERIP)



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
    public class ReportingUserGuestStatisticIpUSERIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserGuestStatisticApi(config);
            var USERIP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")

            try
            {
                ShowStatusUserGuestUserStatisticDetail result = apiInstance.ReportingUserGuestStatisticIpUSERIPGet(USERIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserGuestStatisticApi.ReportingUserGuestStatisticIpUSERIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingUserGuestStatisticIpUSERIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusUserGuestUserStatisticDetail> response = apiInstance.ReportingUserGuestStatisticIpUSERIPGetWithHttpInfo(USERIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserGuestStatisticApi.ReportingUserGuestStatisticIpUSERIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERIP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |

### Return type

[**ShowStatusUserGuestUserStatisticDetail**](ShowStatusUserGuestUserStatisticDetail.md)

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

