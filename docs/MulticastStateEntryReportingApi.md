# SonicWallGen7.Api.MulticastStateEntryReportingApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingMulticastStateEntryAddressIPInterfaceIFNUMGet**](MulticastStateEntryReportingApi.md#reportingmulticaststateentryaddressipinterfaceifnumget) | **GET** /reporting/multicast/state-entry/address/{IP}/interface/{IFNUM} |  |

<a id="reportingmulticaststateentryaddressipinterfaceifnumget"></a>
# **ReportingMulticastStateEntryAddressIPInterfaceIFNUMGet**
> List&lt;ShowStatusMulticastStateEntryListInner&gt; ReportingMulticastStateEntryAddressIPInterfaceIFNUMGet (string IP, string IFNUM)



Retrieve multicast IGMP state entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingMulticastStateEntryAddressIPInterfaceIFNUMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MulticastStateEntryReportingApi(config);
            var IP = "\"IPV4: 192.168.168.168 IPV6: 2001:cdba:0000:0000:0000:0000:3257:9652 \"";  // string | IPV4: address object IPv4 host address in the form: D.D.D.D IPV6: address object IPv6 host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH . (default to "IPV4: 192.168.168.168
IPV6: 2001:cdba:0000:0000:0000:0000:3257:9652
")
            var IFNUM = "\"X0\"";  // string | Multicast interface name. (default to "X0")

            try
            {
                List<ShowStatusMulticastStateEntryListInner> result = apiInstance.ReportingMulticastStateEntryAddressIPInterfaceIFNUMGet(IP, IFNUM);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MulticastStateEntryReportingApi.ReportingMulticastStateEntryAddressIPInterfaceIFNUMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingMulticastStateEntryAddressIPInterfaceIFNUMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusMulticastStateEntryListInner>> response = apiInstance.ReportingMulticastStateEntryAddressIPInterfaceIFNUMGetWithHttpInfo(IP, IFNUM);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MulticastStateEntryReportingApi.ReportingMulticastStateEntryAddressIPInterfaceIFNUMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4: address object IPv4 host address in the form: D.D.D.D IPV6: address object IPv6 host address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH . | [default to &quot;IPV4: 192.168.168.168
IPV6: 2001:cdba:0000:0000:0000:0000:3257:9652
&quot;] |
| **IFNUM** | **string** | Multicast interface name. | [default to &quot;X0&quot;] |

### Return type

[**List&lt;ShowStatusMulticastStateEntryListInner&gt;**](ShowStatusMulticastStateEntryListInner.md)

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

