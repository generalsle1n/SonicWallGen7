# SonicWallGen7.Api.AccessRuleIpv6ConnectionLimitsDstConnectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet**](AccessRuleIpv6ConnectionLimitsDstConnectApi.md#reportingconnectionlimitsipv6dstconnectfromfromzonetotozonedestinationdstaddrservicesvcnametoptopxget) | **GET** /reporting/connection-limits/ipv6/dst-connect/from/{FROMZONE}/to/{TOZONE}/destination/{DSTADDR}/service/{SVCNAME}/top/{TOPX} |  |
| [**ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGet**](AccessRuleIpv6ConnectionLimitsDstConnectApi.md#reportingconnectionlimitsipv6dstconnectfromfromzonetotozoneget) | **GET** /reporting/connection-limits/ipv6/dst-connect/from/{FROMZONE}/to/{TOZONE} |  |
| [**ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet**](AccessRuleIpv6ConnectionLimitsDstConnectApi.md#reportingconnectionlimitsipv6dstconnectfromfromzonetotozonesourcesrcaddrdestinationdstaddrservicesvcnametoptopxget) | **GET** /reporting/connection-limits/ipv6/dst-connect/from/{FROMZONE}/to/{TOZONE}/source/{SRCADDR}/destination/{DSTADDR}/service/{SVCNAME}/top/{TOPX} |  |

<a id="reportingconnectionlimitsipv6dstconnectfromfromzonetotozonedestinationdstaddrservicesvcnametoptopxget"></a>
# **ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet**
> List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt; ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet (string FROMZONE, string TOZONE, string DSTADDR, string SVCNAME, decimal TOPX)



Retrieve IPv6 access rules that enabled and on which destination IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv6ConnectionLimitsDstConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var DSTADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SVCNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TOPX = 8.14D;  // decimal | Integer in the form: D OR 0xHH

            try
            {
                List<ShowStatusAccessRuleConnLimitDestListInner> result = apiInstance.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet(FROMZONE, TOZONE, DSTADDR, SVCNAME, TOPX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv6ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitDestListInner>> response = apiInstance.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo(FROMZONE, TOZONE, DSTADDR, SVCNAME, TOPX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv6ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |
| **TOZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |
| **DSTADDR** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **SVCNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **TOPX** | **decimal** | Integer in the form: D OR 0xHH |  |

### Return type

[**List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt;**](ShowStatusAccessRuleConnLimitDestListInner.md)

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

<a id="reportingconnectionlimitsipv6dstconnectfromfromzonetotozoneget"></a>
# **ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGet**
> List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt; ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGet (string FROMZONE, string TOZONE)



Retrieve IPv6 access rules that enabled and on which destination IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv6ConnectionLimitsDstConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")

            try
            {
                List<ShowStatusAccessRuleConnLimitDestListInner> result = apiInstance.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGet(FROMZONE, TOZONE);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv6ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitDestListInner>> response = apiInstance.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGetWithHttpInfo(FROMZONE, TOZONE);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv6ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |
| **TOZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |

### Return type

[**List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt;**](ShowStatusAccessRuleConnLimitDestListInner.md)

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

<a id="reportingconnectionlimitsipv6dstconnectfromfromzonetotozonesourcesrcaddrdestinationdstaddrservicesvcnametoptopxget"></a>
# **ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet**
> List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt; ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet (string FROMZONE, string TOZONE, string SRCADDR, string DSTADDR, string SVCNAME, decimal TOPX)



Retrieve IPv6 access rules that enabled and on which destination IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv6ConnectionLimitsDstConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var SRCADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SVCNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TOPX = 8.14D;  // decimal | Integer in the form: D OR 0xHH

            try
            {
                List<ShowStatusAccessRuleConnLimitDestListInner> result = apiInstance.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet(FROMZONE, TOZONE, SRCADDR, DSTADDR, SVCNAME, TOPX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv6ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitDestListInner>> response = apiInstance.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo(FROMZONE, TOZONE, SRCADDR, DSTADDR, SVCNAME, TOPX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv6ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv6DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |
| **TOZONE** | **string** | Access rule from | [default to &quot;DMZ&quot;] |
| **SRCADDR** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **DSTADDR** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **SVCNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **TOPX** | **decimal** | Integer in the form: D OR 0xHH |  |

### Return type

[**List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt;**](ShowStatusAccessRuleConnLimitDestListInner.md)

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

