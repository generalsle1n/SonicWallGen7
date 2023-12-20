# SonicWallGen7.Api.FlbStatusGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingFailoverLbStatusGroupsGet**](FlbStatusGroupApi.md#reportingfailoverlbstatusgroupsget) | **GET** /reporting/failover-lb/status/groups |  |
| [**ReportingFailoverLbStatusGroupsNameNAMEGet**](FlbStatusGroupApi.md#reportingfailoverlbstatusgroupsnamenameget) | **GET** /reporting/failover-lb/status/groups/name/{NAME} |  |

<a id="reportingfailoverlbstatusgroupsget"></a>
# **ReportingFailoverLbStatusGroupsGet**
> List&lt;ShowStatusFlbGroupStatusListInner&gt; ReportingFailoverLbStatusGroupsGet ()



Retrieve failover load balancing groups status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingFailoverLbStatusGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbStatusGroupApi(config);

            try
            {
                List<ShowStatusFlbGroupStatusListInner> result = apiInstance.ReportingFailoverLbStatusGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbStatusGroupApi.ReportingFailoverLbStatusGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingFailoverLbStatusGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusFlbGroupStatusListInner>> response = apiInstance.ReportingFailoverLbStatusGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbStatusGroupApi.ReportingFailoverLbStatusGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusFlbGroupStatusListInner&gt;**](ShowStatusFlbGroupStatusListInner.md)

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

<a id="reportingfailoverlbstatusgroupsnamenameget"></a>
# **ReportingFailoverLbStatusGroupsNameNAMEGet**
> ShowStatusFlbGroupStatusDetail ReportingFailoverLbStatusGroupsNameNAMEGet (string NAME)



Retrieve failover load balancing groups status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingFailoverLbStatusGroupsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbStatusGroupApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")

            try
            {
                ShowStatusFlbGroupStatusDetail result = apiInstance.ReportingFailoverLbStatusGroupsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbStatusGroupApi.ReportingFailoverLbStatusGroupsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingFailoverLbStatusGroupsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusFlbGroupStatusDetail> response = apiInstance.ReportingFailoverLbStatusGroupsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbStatusGroupApi.ReportingFailoverLbStatusGroupsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |

### Return type

[**ShowStatusFlbGroupStatusDetail**](ShowStatusFlbGroupStatusDetail.md)

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

