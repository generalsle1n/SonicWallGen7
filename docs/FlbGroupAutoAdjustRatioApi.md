# SonicWallGen7.Api.FlbGroupAutoAdjustRatioApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FailoverLbGroupAutoAdjustRatioNameNAMEPut**](FlbGroupAutoAdjustRatioApi.md#failoverlbgroupautoadjustrationamenameput) | **PUT** /failover-lb/group-auto-adjust-ratio/name/{NAME} |  |

<a id="failoverlbgroupautoadjustrationamenameput"></a>
# **FailoverLbGroupAutoAdjustRatioNameNAMEPut**
> ApiStatus FailoverLbGroupAutoAdjustRatioNameNAMEPut (string NAME, Object? body = null)



Automatically adjust all member ratios so total is 100%.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupAutoAdjustRatioNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupAutoAdjustRatioApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.FailoverLbGroupAutoAdjustRatioNameNAMEPut(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupAutoAdjustRatioApi.FailoverLbGroupAutoAdjustRatioNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupAutoAdjustRatioNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.FailoverLbGroupAutoAdjustRatioNameNAMEPutWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupAutoAdjustRatioApi.FailoverLbGroupAutoAdjustRatioNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |
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

