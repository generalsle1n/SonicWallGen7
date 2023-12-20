# SonicWallGen7.Api.ConnectionCacheElementApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDelete**](ConnectionCacheElementApi.md#connectioncacheelementsrcipsrcipsrcportsrcportdstipdstipdstportdstportprotoprotocalsrcifsrcifacedstifdstifacedstnatnatdelete) | **DELETE** /connection-cache-element/src-ip/{SRCIP}/src-port/{SRCPORT}/dst-ip/{DSTIP}/dst-port/{DSTPORT}/proto/{PROTOCAL}/srcIf/{SRCIFACE}/dstIf/{DSTIFACE}/dstNat/{NAT} |  |

<a id="connectioncacheelementsrcipsrcipsrcportsrcportdstipdstipdstportdstportprotoprotocalsrcifsrcifacedstifdstifacedstnatnatdelete"></a>
# **ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDelete**
> ApiStatus ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDelete (string SRCIP, decimal SRCPORT, string DSTIP, decimal DSTPORT, string PROTOCAL, string SRCIFACE, string DSTIFACE, decimal NAT)



delete connection cache element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ConnectionCacheElementApi(config);
            var SRCIP = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SRCPORT = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH
            var DSTIP = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTPORT = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH
            var PROTOCAL = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var SRCIFACE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTIFACE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var NAT = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH

            try
            {
                ApiStatus result = apiInstance.ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDelete(SRCIP, SRCPORT, DSTIP, DSTPORT, PROTOCAL, SRCIFACE, DSTIFACE, NAT);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionCacheElementApi.ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDeleteWithHttpInfo(SRCIP, SRCPORT, DSTIP, DSTPORT, PROTOCAL, SRCIFACE, DSTIFACE, NAT);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionCacheElementApi.ConnectionCacheElementSrcIpSRCIPSrcPortSRCPORTDstIpDSTIPDstPortDSTPORTProtoPROTOCALSrcIfSRCIFACEDstIfDSTIFACEDstNatNATDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRCIP** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **SRCPORT** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |
| **DSTIP** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **DSTPORT** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |
| **PROTOCAL** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **SRCIFACE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **DSTIFACE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **NAT** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |

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

