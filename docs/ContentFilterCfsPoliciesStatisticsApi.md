# SonicWallGen7.Api.ContentFilterCfsPoliciesStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingContentFilterCfsPoliciesStatisticsGet**](ContentFilterCfsPoliciesStatisticsApi.md#reportingcontentfiltercfspoliciesstatisticsget) | **GET** /reporting/content-filter/cfs/policies/statistics |  |
| [**ReportingContentFilterCfsPoliciesStatisticsNameNAMEDelete**](ContentFilterCfsPoliciesStatisticsApi.md#reportingcontentfiltercfspoliciesstatisticsnamenamedelete) | **DELETE** /reporting/content-filter/cfs/policies/statistics/name/{NAME} |  |
| [**ReportingContentFilterCfsPoliciesStatisticsNameNAMEGet**](ContentFilterCfsPoliciesStatisticsApi.md#reportingcontentfiltercfspoliciesstatisticsnamenameget) | **GET** /reporting/content-filter/cfs/policies/statistics/name/{NAME} |  |

<a id="reportingcontentfiltercfspoliciesstatisticsget"></a>
# **ReportingContentFilterCfsPoliciesStatisticsGet**
> List&lt;ShowStatusCfsPoliciesStatisticsListInner&gt; ReportingContentFilterCfsPoliciesStatisticsGet ()



Retrieve TCP statistics of content filter cfs policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingContentFilterCfsPoliciesStatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPoliciesStatisticsApi(config);

            try
            {
                List<ShowStatusCfsPoliciesStatisticsListInner> result = apiInstance.ReportingContentFilterCfsPoliciesStatisticsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPoliciesStatisticsApi.ReportingContentFilterCfsPoliciesStatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingContentFilterCfsPoliciesStatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusCfsPoliciesStatisticsListInner>> response = apiInstance.ReportingContentFilterCfsPoliciesStatisticsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPoliciesStatisticsApi.ReportingContentFilterCfsPoliciesStatisticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusCfsPoliciesStatisticsListInner&gt;**](ShowStatusCfsPoliciesStatisticsListInner.md)

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

<a id="reportingcontentfiltercfspoliciesstatisticsnamenamedelete"></a>
# **ReportingContentFilterCfsPoliciesStatisticsNameNAMEDelete**
> ApiStatus ReportingContentFilterCfsPoliciesStatisticsNameNAMEDelete (string NAME)



Clear TCP statistics of content filter CFS policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingContentFilterCfsPoliciesStatisticsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPoliciesStatisticsApi(config);
            var NAME = "\"Market policy\"";  // string | CFS policy name. (default to "Market policy")

            try
            {
                ApiStatus result = apiInstance.ReportingContentFilterCfsPoliciesStatisticsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPoliciesStatisticsApi.ReportingContentFilterCfsPoliciesStatisticsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingContentFilterCfsPoliciesStatisticsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingContentFilterCfsPoliciesStatisticsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPoliciesStatisticsApi.ReportingContentFilterCfsPoliciesStatisticsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS policy name. | [default to &quot;Market policy&quot;] |

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

<a id="reportingcontentfiltercfspoliciesstatisticsnamenameget"></a>
# **ReportingContentFilterCfsPoliciesStatisticsNameNAMEGet**
> ShowStatusCfsPoliciesStatisticsDetail ReportingContentFilterCfsPoliciesStatisticsNameNAMEGet (string NAME)



Retrieve TCP statistics of content filter cfs policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingContentFilterCfsPoliciesStatisticsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPoliciesStatisticsApi(config);
            var NAME = "\"Market policy\"";  // string | CFS policy name. (default to "Market policy")

            try
            {
                ShowStatusCfsPoliciesStatisticsDetail result = apiInstance.ReportingContentFilterCfsPoliciesStatisticsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPoliciesStatisticsApi.ReportingContentFilterCfsPoliciesStatisticsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingContentFilterCfsPoliciesStatisticsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusCfsPoliciesStatisticsDetail> response = apiInstance.ReportingContentFilterCfsPoliciesStatisticsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPoliciesStatisticsApi.ReportingContentFilterCfsPoliciesStatisticsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS policy name. | [default to &quot;Market policy&quot;] |

### Return type

[**ShowStatusCfsPoliciesStatisticsDetail**](ShowStatusCfsPoliciesStatisticsDetail.md)

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

