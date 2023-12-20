# SonicWallGen7.Api.FlbGroupMemberPercentApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPut**](FlbGroupMemberPercentApi.md#failoverlbgroupmemberpercentnamenameinterfaceifnamepercentput) | **PUT** /failover-lb/group-member-percent/name/{NAME}/interface/{IFNAME}/{PERCENT} |  |

<a id="failoverlbgroupmemberpercentnamenameinterfaceifnamepercentput"></a>
# **FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPut**
> ApiStatus FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPut (string NAME, string IFNAME, decimal PERCENT, Object? body = null)



Set the member usage percent for the interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupMemberPercentApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")
            var IFNAME = "\"X0\"";  // string | Group member name. (default to "X0")
            var PERCENT = 8.14D;  // decimal | Integer in the form: D OR 0xHH
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPut(NAME, IFNAME, PERCENT, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupMemberPercentApi.FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPutWithHttpInfo(NAME, IFNAME, PERCENT, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupMemberPercentApi.FailoverLbGroupMemberPercentNameNAMEInterfaceIFNAMEPERCENTPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |
| **IFNAME** | **string** | Group member name. | [default to &quot;X0&quot;] |
| **PERCENT** | **decimal** | Integer in the form: D OR 0xHH |  |
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

