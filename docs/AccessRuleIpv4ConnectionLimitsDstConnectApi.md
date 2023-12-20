# SonicWallGen7.Api.AccessRuleIpv4ConnectionLimitsDstConnectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet**](AccessRuleIpv4ConnectionLimitsDstConnectApi.md#reportingconnectionlimitsipv4dstconnectfromfromzonetotozonedestinationdstaddrservicesvcnametoptopxget) | **GET** /reporting/connection-limits/ipv4/dst-connect/from/{FROMZONE}/to/{TOZONE}/destination/{DSTADDR}/service/{SVCNAME}/top/{TOPX} |  |
| [**ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGet**](AccessRuleIpv4ConnectionLimitsDstConnectApi.md#reportingconnectionlimitsipv4dstconnectfromfromzonetotozoneget) | **GET** /reporting/connection-limits/ipv4/dst-connect/from/{FROMZONE}/to/{TOZONE} |  |
| [**ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet**](AccessRuleIpv4ConnectionLimitsDstConnectApi.md#reportingconnectionlimitsipv4dstconnectfromfromzonetotozonesourcesrcaddrdestinationdstaddrservicesvcnametoptopxget) | **GET** /reporting/connection-limits/ipv4/dst-connect/from/{FROMZONE}/to/{TOZONE}/source/{SRCADDR}/destination/{DSTADDR}/service/{SVCNAME}/top/{TOPX} |  |

<a id="reportingconnectionlimitsipv4dstconnectfromfromzonetotozonedestinationdstaddrservicesvcnametoptopxget"></a>
# **ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet**
> List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt; ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet (string FROMZONE, string TOZONE, string DSTADDR, string SVCNAME, decimal TOPX)



Retrieve IPv4 access rules that enabled and on which destination IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv4ConnectionLimitsDstConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var DSTADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SVCNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TOPX = 8.14D;  // decimal | Integer in the form: D OR 0xHH

            try
            {
                List<ShowStatusAccessRuleConnLimitDestListInner> result = apiInstance.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet(FROMZONE, TOZONE, DSTADDR, SVCNAME, TOPX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitDestListInner>> response = apiInstance.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo(FROMZONE, TOZONE, DSTADDR, SVCNAME, TOPX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo: " + e.Message);
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

<a id="reportingconnectionlimitsipv4dstconnectfromfromzonetotozoneget"></a>
# **ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGet**
> List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt; ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGet (string FROMZONE, string TOZONE)



Retrieve IPv4 access rules that enabled and on which destination IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv4ConnectionLimitsDstConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")

            try
            {
                List<ShowStatusAccessRuleConnLimitDestListInner> result = apiInstance.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGet(FROMZONE, TOZONE);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitDestListInner>> response = apiInstance.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGetWithHttpInfo(FROMZONE, TOZONE);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONEGetWithHttpInfo: " + e.Message);
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

<a id="reportingconnectionlimitsipv4dstconnectfromfromzonetotozonesourcesrcaddrdestinationdstaddrservicesvcnametoptopxget"></a>
# **ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet**
> List&lt;ShowStatusAccessRuleConnLimitDestListInner&gt; ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet (string FROMZONE, string TOZONE, string SRCADDR, string DSTADDR, string SVCNAME, decimal TOPX)



Retrieve IPv4 access rules that enabled and on which destination IP address connection limit is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRuleIpv4ConnectionLimitsDstConnectApi(config);
            var FROMZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var TOZONE = "\"DMZ\"";  // string | Access rule from (default to "DMZ")
            var SRCADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTADDR = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SVCNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TOPX = 8.14D;  // decimal | Integer in the form: D OR 0xHH

            try
            {
                List<ShowStatusAccessRuleConnLimitDestListInner> result = apiInstance.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet(FROMZONE, TOZONE, SRCADDR, DSTADDR, SVCNAME, TOPX);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusAccessRuleConnLimitDestListInner>> response = apiInstance.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo(FROMZONE, TOZONE, SRCADDR, DSTADDR, SVCNAME, TOPX);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRuleIpv4ConnectionLimitsDstConnectApi.ReportingConnectionLimitsIpv4DstConnectFromFROMZONEToTOZONESourceSRCADDRDestinationDSTADDRServiceSVCNAMETopTOPXGetWithHttpInfo: " + e.Message);
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

