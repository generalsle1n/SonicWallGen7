# SonicWallGen7.Api.DosPoliciesCountersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDosPoliciesCountersGet**](DosPoliciesCountersApi.md#reportingdospoliciescountersget) | **GET** /reporting/dos-policies/counters |  |
| [**ReportingDosPoliciesCountersUuidUUIDGet**](DosPoliciesCountersApi.md#reportingdospoliciescountersuuiduuidget) | **GET** /reporting/dos-policies/counters/uuid/{UUID} |  |

<a id="reportingdospoliciescountersget"></a>
# **ReportingDosPoliciesCountersGet**
> List&lt;ShowStatusDosPolicyCountersListInner&gt; ReportingDosPoliciesCountersGet ()



Retrieve DOS policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDosPoliciesCountersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosPoliciesCountersApi(config);

            try
            {
                List<ShowStatusDosPolicyCountersListInner> result = apiInstance.ReportingDosPoliciesCountersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosPoliciesCountersApi.ReportingDosPoliciesCountersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDosPoliciesCountersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDosPolicyCountersListInner>> response = apiInstance.ReportingDosPoliciesCountersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosPoliciesCountersApi.ReportingDosPoliciesCountersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDosPolicyCountersListInner&gt;**](ShowStatusDosPolicyCountersListInner.md)

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

<a id="reportingdospoliciescountersuuiduuidget"></a>
# **ReportingDosPoliciesCountersUuidUUIDGet**
> List&lt;ShowStatusDosPolicyCountersListInner&gt; ReportingDosPoliciesCountersUuidUUIDGet (string UUID)



Retrieve DOS policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDosPoliciesCountersUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosPoliciesCountersApi(config);
            var UUID = "\"00000000-0000-0004-1d00-2cb8ed3d8a10\"";  // string | DOS policy UUID. (default to "00000000-0000-0004-1d00-2cb8ed3d8a10")

            try
            {
                List<ShowStatusDosPolicyCountersListInner> result = apiInstance.ReportingDosPoliciesCountersUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosPoliciesCountersApi.ReportingDosPoliciesCountersUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDosPoliciesCountersUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDosPolicyCountersListInner>> response = apiInstance.ReportingDosPoliciesCountersUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosPoliciesCountersApi.ReportingDosPoliciesCountersUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | DOS policy UUID. | [default to &quot;00000000-0000-0004-1d00-2cb8ed3d8a10&quot;] |

### Return type

[**List&lt;ShowStatusDosPolicyCountersListInner&gt;**](ShowStatusDosPolicyCountersListInner.md)

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

