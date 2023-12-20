# SonicWallGen7.Api.ActionObjectBwmUsageApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingActionObjectsBandwidthUsageGet**](ActionObjectBwmUsageApi.md#reportingactionobjectsbandwidthusageget) | **GET** /reporting/action-objects/bandwidth-usage |  |
| [**ReportingActionObjectsBandwidthUsageNameNAMEGet**](ActionObjectBwmUsageApi.md#reportingactionobjectsbandwidthusagenamenameget) | **GET** /reporting/action-objects/bandwidth-usage/name/{NAME} |  |

<a id="reportingactionobjectsbandwidthusageget"></a>
# **ReportingActionObjectsBandwidthUsageGet**
> List&lt;ShowStatusActionObjectsBwmUsageListInner&gt; ReportingActionObjectsBandwidthUsageGet ()



Action objects bandwidth management usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingActionObjectsBandwidthUsageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActionObjectBwmUsageApi(config);

            try
            {
                List<ShowStatusActionObjectsBwmUsageListInner> result = apiInstance.ReportingActionObjectsBandwidthUsageGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionObjectBwmUsageApi.ReportingActionObjectsBandwidthUsageGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingActionObjectsBandwidthUsageGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusActionObjectsBwmUsageListInner>> response = apiInstance.ReportingActionObjectsBandwidthUsageGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActionObjectBwmUsageApi.ReportingActionObjectsBandwidthUsageGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusActionObjectsBwmUsageListInner&gt;**](ShowStatusActionObjectsBwmUsageListInner.md)

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

<a id="reportingactionobjectsbandwidthusagenamenameget"></a>
# **ReportingActionObjectsBandwidthUsageNameNAMEGet**
> List&lt;ShowStatusActionObjectsBwmUsageListInner&gt; ReportingActionObjectsBandwidthUsageNameNAMEGet (string NAME)



Action objects bandwidth management usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingActionObjectsBandwidthUsageNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActionObjectBwmUsageApi(config);
            var NAME = "\"HTTP Block Page\"";  // string | Action object name. (default to "HTTP Block Page")

            try
            {
                List<ShowStatusActionObjectsBwmUsageListInner> result = apiInstance.ReportingActionObjectsBandwidthUsageNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionObjectBwmUsageApi.ReportingActionObjectsBandwidthUsageNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingActionObjectsBandwidthUsageNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusActionObjectsBwmUsageListInner>> response = apiInstance.ReportingActionObjectsBandwidthUsageNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActionObjectBwmUsageApi.ReportingActionObjectsBandwidthUsageNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Action object name. | [default to &quot;HTTP Block Page&quot;] |

### Return type

[**List&lt;ShowStatusActionObjectsBwmUsageListInner&gt;**](ShowStatusActionObjectsBwmUsageListInner.md)

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

