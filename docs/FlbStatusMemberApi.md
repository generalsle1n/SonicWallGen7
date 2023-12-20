# SonicWallGen7.Api.FlbStatusMemberApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingFailoverLbStatusMembersGet**](FlbStatusMemberApi.md#reportingfailoverlbstatusmembersget) | **GET** /reporting/failover-lb/status/members |  |
| [**ReportingFailoverLbStatusMembersNameNAMEGet**](FlbStatusMemberApi.md#reportingfailoverlbstatusmembersnamenameget) | **GET** /reporting/failover-lb/status/members/name/{NAME} |  |

<a id="reportingfailoverlbstatusmembersget"></a>
# **ReportingFailoverLbStatusMembersGet**
> List&lt;ShowStatusFlbMemberStatusListInner&gt; ReportingFailoverLbStatusMembersGet ()



Retrieve failover load balancing members status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingFailoverLbStatusMembersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbStatusMemberApi(config);

            try
            {
                List<ShowStatusFlbMemberStatusListInner> result = apiInstance.ReportingFailoverLbStatusMembersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbStatusMemberApi.ReportingFailoverLbStatusMembersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingFailoverLbStatusMembersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusFlbMemberStatusListInner>> response = apiInstance.ReportingFailoverLbStatusMembersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbStatusMemberApi.ReportingFailoverLbStatusMembersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusFlbMemberStatusListInner&gt;**](ShowStatusFlbMemberStatusListInner.md)

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

<a id="reportingfailoverlbstatusmembersnamenameget"></a>
# **ReportingFailoverLbStatusMembersNameNAMEGet**
> ShowStatusFlbMemberStatusDetail ReportingFailoverLbStatusMembersNameNAMEGet (string NAME)



Retrieve failover load balancing members status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingFailoverLbStatusMembersNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbStatusMemberApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")

            try
            {
                ShowStatusFlbMemberStatusDetail result = apiInstance.ReportingFailoverLbStatusMembersNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbStatusMemberApi.ReportingFailoverLbStatusMembersNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingFailoverLbStatusMembersNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusFlbMemberStatusDetail> response = apiInstance.ReportingFailoverLbStatusMembersNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbStatusMemberApi.ReportingFailoverLbStatusMembersNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |

### Return type

[**ShowStatusFlbMemberStatusDetail**](ShowStatusFlbMemberStatusDetail.md)

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

