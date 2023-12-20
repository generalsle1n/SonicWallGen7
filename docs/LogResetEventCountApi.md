# SonicWallGen7.Api.LogResetEventCountApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost**](LogResetEventCountApi.md#logreseteventcountcategorycatnamegroupgrpnameeventeventnamepost) | **POST** /log/reset/event-count/category/{CATNAME}/group/{GRPNAME}/event/{EVENTNAME} |  |
| [**LogResetEventCountCategoryCATNAMEPost**](LogResetEventCountApi.md#logreseteventcountcategorycatnamepost) | **POST** /log/reset/event-count/category/{CATNAME} |  |

<a id="logreseteventcountcategorycatnamegroupgrpnameeventeventnamepost"></a>
# **LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost**
> ApiStatus LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost (string CATNAME, string GRPNAME, string EVENTNAME, Object? body = null)



Log reset event count for specify category or group or event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogResetEventCountApi(config);
            var CATNAME = "\"Firewall\"";  // string | Log category name. (default to "Firewall")
            var GRPNAME = "\"Firewall Event\"";  // string | Group name. (default to "Firewall Event")
            var EVENTNAME = "\"Activate Firewall\"";  // string | Event name. (default to "Activate Firewall")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost(CATNAME, GRPNAME, EVENTNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogResetEventCountApi.LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPostWithHttpInfo(CATNAME, GRPNAME, EVENTNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogResetEventCountApi.LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CATNAME** | **string** | Log category name. | [default to &quot;Firewall&quot;] |
| **GRPNAME** | **string** | Group name. | [default to &quot;Firewall Event&quot;] |
| **EVENTNAME** | **string** | Event name. | [default to &quot;Activate Firewall&quot;] |
| **body** | **Object?** |  | [optional]  |

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

<a id="logreseteventcountcategorycatnamepost"></a>
# **LogResetEventCountCategoryCATNAMEPost**
> ApiStatus LogResetEventCountCategoryCATNAMEPost (string CATNAME, Object? body = null)



Log reset event count for specify category or group or event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogResetEventCountCategoryCATNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogResetEventCountApi(config);
            var CATNAME = "\"Firewall\"";  // string | Log category name. (default to "Firewall")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogResetEventCountCategoryCATNAMEPost(CATNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogResetEventCountApi.LogResetEventCountCategoryCATNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogResetEventCountCategoryCATNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogResetEventCountCategoryCATNAMEPostWithHttpInfo(CATNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogResetEventCountApi.LogResetEventCountCategoryCATNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CATNAME** | **string** | Log category name. | [default to &quot;Firewall&quot;] |
| **body** | **Object?** |  | [optional]  |

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

