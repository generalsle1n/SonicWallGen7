# SonicWallGen7.Api.LogDisableEventIdApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LogDisableEventIdEVENTIDPost**](LogDisableEventIdApi.md#logdisableeventideventidpost) | **POST** /log/disable/event-id/{EVENTID} |  |

<a id="logdisableeventideventidpost"></a>
# **LogDisableEventIdEVENTIDPost**
> ApiStatus LogDisableEventIdEVENTIDPost (decimal EVENTID, Object? body = null)



Disable Log Event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogDisableEventIdEVENTIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogDisableEventIdApi(config);
            var EVENTID = 8.14D;  // decimal | Event id.
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogDisableEventIdEVENTIDPost(EVENTID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogDisableEventIdApi.LogDisableEventIdEVENTIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogDisableEventIdEVENTIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogDisableEventIdEVENTIDPostWithHttpInfo(EVENTID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogDisableEventIdApi.LogDisableEventIdEVENTIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **EVENTID** | **decimal** | Event id. |  |
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

