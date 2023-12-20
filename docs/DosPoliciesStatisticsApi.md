# SonicWallGen7.Api.DosPoliciesStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDosPoliciesStatisticsGet**](DosPoliciesStatisticsApi.md#reportingdospoliciesstatisticsget) | **GET** /reporting/dos-policies/statistics |  |
| [**ReportingDosPoliciesStatisticsUuidUUIDDelete**](DosPoliciesStatisticsApi.md#reportingdospoliciesstatisticsuuiduuiddelete) | **DELETE** /reporting/dos-policies/statistics/uuid/{UUID} |  |
| [**ReportingDosPoliciesStatisticsUuidUUIDGet**](DosPoliciesStatisticsApi.md#reportingdospoliciesstatisticsuuiduuidget) | **GET** /reporting/dos-policies/statistics/uuid/{UUID} |  |

<a id="reportingdospoliciesstatisticsget"></a>
# **ReportingDosPoliciesStatisticsGet**
> List&lt;ShowStatusDosPolicyStatusListInner&gt; ReportingDosPoliciesStatisticsGet ()



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
    public class ReportingDosPoliciesStatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosPoliciesStatisticsApi(config);

            try
            {
                List<ShowStatusDosPolicyStatusListInner> result = apiInstance.ReportingDosPoliciesStatisticsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosPoliciesStatisticsApi.ReportingDosPoliciesStatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDosPoliciesStatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDosPolicyStatusListInner>> response = apiInstance.ReportingDosPoliciesStatisticsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosPoliciesStatisticsApi.ReportingDosPoliciesStatisticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDosPolicyStatusListInner&gt;**](ShowStatusDosPolicyStatusListInner.md)

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

<a id="reportingdospoliciesstatisticsuuiduuiddelete"></a>
# **ReportingDosPoliciesStatisticsUuidUUIDDelete**
> ApiStatus ReportingDosPoliciesStatisticsUuidUUIDDelete (string UUID)



Clear DOS policies statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDosPoliciesStatisticsUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosPoliciesStatisticsApi(config);
            var UUID = "\"00000000-0000-0004-1d00-2cb8ed3d8a10\"";  // string | DOS policy UUID. (default to "00000000-0000-0004-1d00-2cb8ed3d8a10")

            try
            {
                ApiStatus result = apiInstance.ReportingDosPoliciesStatisticsUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosPoliciesStatisticsApi.ReportingDosPoliciesStatisticsUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDosPoliciesStatisticsUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingDosPoliciesStatisticsUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosPoliciesStatisticsApi.ReportingDosPoliciesStatisticsUuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | DOS policy UUID. | [default to &quot;00000000-0000-0004-1d00-2cb8ed3d8a10&quot;] |

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

<a id="reportingdospoliciesstatisticsuuiduuidget"></a>
# **ReportingDosPoliciesStatisticsUuidUUIDGet**
> List&lt;ShowStatusDosPolicyStatusListInner&gt; ReportingDosPoliciesStatisticsUuidUUIDGet (string UUID)



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
    public class ReportingDosPoliciesStatisticsUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosPoliciesStatisticsApi(config);
            var UUID = "\"00000000-0000-0004-1d00-2cb8ed3d8a10\"";  // string | DOS policy UUID. (default to "00000000-0000-0004-1d00-2cb8ed3d8a10")

            try
            {
                List<ShowStatusDosPolicyStatusListInner> result = apiInstance.ReportingDosPoliciesStatisticsUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosPoliciesStatisticsApi.ReportingDosPoliciesStatisticsUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDosPoliciesStatisticsUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDosPolicyStatusListInner>> response = apiInstance.ReportingDosPoliciesStatisticsUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosPoliciesStatisticsApi.ReportingDosPoliciesStatisticsUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | DOS policy UUID. | [default to &quot;00000000-0000-0004-1d00-2cb8ed3d8a10&quot;] |

### Return type

[**List&lt;ShowStatusDosPolicyStatusListInner&gt;**](ShowStatusDosPolicyStatusListInner.md)

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

