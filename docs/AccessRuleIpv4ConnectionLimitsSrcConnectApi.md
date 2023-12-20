# SonicWallGen7.Api.AccessRuleIpv4ConnectionLimitsSrcConnectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet**](AccessRuleIpv4ConnectionLimitsSrcConnectApi.md#reportingconnectionlimitsipv4srcconnectfromfromzonetotozonedestinationdstaddrservicesvcnametoptopxget) | **GET** /reporting/connection-limits/ipv4/src-connect/from/{FROMZONE}/to/{TOZONE}/destination/{DSTADDR}/service/{SVCNAME}/top/{TOPX} |  |
| [**ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGet**](AccessRuleIpv4ConnectionLimitsSrcConnectApi.md#reportingconnectionlimitsipv4srcconnectfromfromzonetotozoneget) | **GET** /reporting/connection-limits/ipv4/src-connect/from/{FROMZONE}/to/{TOZONE} |  |
| [**ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet**](AccessRuleIpv4ConnectionLimitsSrcConnectApi.md#reportingconnectionlimitsipv4srcconnectfromfromzonetotozonesourcesrcaddrdestinationdstaddrservicesvcnametoptopxget) | **GET** /reporting/connection-limits/ipv4/src-connect/from/{FROMZONE}/to/{TOZONE}/source/{SRCADDR}/destination/{DSTADDR}/service/{SVCNAME}/top/{TOPX} |  |

<a id="reportingconnectionlimitsipv4srcconnectfromfromzonetotozonedestinationdstaddrservicesvcnametoptopxget"></a>
# **ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet**
> List&lt;ShowStatusAccessRuleConnLimitSourceListInner&gt; ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet (string FROMZONE, string TOZONE, string DSTADDR, string SVCNAME, decimal TOPX)



Retrieve IPv4 access rules that enabled and on which source IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv4ConnectionLimitsSrcConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var DSTADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SVCNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TOPX = 8.14D;  // decimal | Integer in the form: D OR 0xHH

            try
            {
                List<ShowStatusAccessRuleConnLimitSourceListInner> result = apiInstance.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet(FROMZONE, TOZONE, DSTADDR, SVCNAME, TOPX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsSrcConnectApi.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitSourceListInner>> response = apiInstance.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo(FROMZONE, TOZONE, DSTADDR, SVCNAME, TOPX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsSrcConnectApi.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo: " + e.Message);
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

[**List&lt;ShowStatusAccessRuleConnLimitSourceListInner&gt;**](ShowStatusAccessRuleConnLimitSourceListInner.md)

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

<a id="reportingconnectionlimitsipv4srcconnectfromfromzonetotozoneget"></a>
# **ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGet**
> List&lt;ShowStatusAccessRuleConnLimitSourceListInner&gt; ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGet (string FROMZONE, string TOZONE)



Retrieve IPv4 access rules that enabled and on which source IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv4ConnectionLimitsSrcConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")

            try
            {
                List<ShowStatusAccessRuleConnLimitSourceListInner> result = apiInstance.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGet(FROMZONE, TOZONE);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsSrcConnectApi.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitSourceListInner>> response = apiInstance.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGetWithHttpInfo(FROMZONE, TOZONE);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsSrcConnectApi.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONEGetWithHttpInfo: " + e.Message);
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

[**List&lt;ShowStatusAccessRuleConnLimitSourceListInner&gt;**](ShowStatusAccessRuleConnLimitSourceListInner.md)

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

<a id="reportingconnectionlimitsipv4srcconnectfromfromzonetotozonesourcesrcaddrdestinationdstaddrservicesvcnametoptopxget"></a>
# **ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet**
> List&lt;ShowStatusAccessRuleConnLimitSourceListInner&gt; ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet (string FROMZONE, string TOZONE, string SRCADDR, string DSTADDR, string SVCNAME, decimal TOPX)



Retrieve IPv4 access rules that enabled and on which source IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv4ConnectionLimitsSrcConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var SRCADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SVCNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TOPX = 8.14D;  // decimal | Integer in the form: D OR 0xHH

            try
            {
                List<ShowStatusAccessRuleConnLimitSourceListInner> result = apiInstance.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet(FROMZONE, TOZONE, SRCADDR, DSTADDR, SVCNAME, TOPX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsSrcConnectApi.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitSourceListInner>> response = apiInstance.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo(FROMZONE, TOZONE, SRCADDR, DSTADDR, SVCNAME, TOPX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsSrcConnectApi.ReportingConnectionLimitsIpv4SrcConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo: " + e.Message);
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

[**List&lt;ShowStatusAccessRuleConnLimitSourceListInner&gt;**](ShowStatusAccessRuleConnLimitSourceListInner.md)

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

