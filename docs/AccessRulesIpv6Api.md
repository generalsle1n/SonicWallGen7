# SonicWallGen7.Api.AccessRulesIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGet**](AccessRulesIpv6Api.md#reportingaccessrulesipv6fromsrczonetodstzoneget) | **GET** /reporting/access-rules-ipv6/from/{SRCZONE}/to/{DSTZONE} |  |

<a id="reportingaccessrulesipv6fromsrczonetodstzoneget"></a>
# **ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGet**
> Object ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGet (string SRCZONE, string DSTZONE)



Retrieve IPv6 access rule policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRulesIpv6Api(config);
            var SRCZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var DSTZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")

            try
            {
                Object result = apiInstance.ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGet(SRCZONE, DSTZONE);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRulesIpv6Api.ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGetWithHttpInfo(SRCZONE, DSTZONE);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRulesIpv6Api.ReportingAccessRulesIpv6FromSRCZONEToDSTZONEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRCZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |
| **DSTZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |

### Return type

**Object**

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

