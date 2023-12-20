# SonicWallGen7.Api.VpnRenegotiateTunnelApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPost**](VpnRenegotiateTunnelApi.md#renegotiatetunnelsrciptypesrcnetsrcmaskdstiptypedstnetdstmaskinitcookiedstgwdstgwportisdhcpclinspipost) | **POST** /renegotiate/tunnel/{SRCIPTYPE}/{SRCNET}/{SRCMASK}/{DSTIPTYPE}/{DSTNET}/{DSTMASK}/{INITCOOKIE}/{DSTGW}/{DSTGWPORT}/{ISDHCPCL}/{INSPI} |  |

<a id="renegotiatetunnelsrciptypesrcnetsrcmaskdstiptypedstnetdstmaskinitcookiedstgwdstgwportisdhcpclinspipost"></a>
# **RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPost**
> ApiStatus RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPost (decimal SRCIPTYPE, string SRCNET, string SRCMASK, decimal DSTIPTYPE, string DSTNET, string DSTMASK, string INITCOOKIE, string DSTGW, decimal DSTGWPORT, decimal ISDHCPCL, decimal INSPI, Object? body = null)



Renegotiate the specific VPN tunnel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VpnRenegotiateTunnelApi(config);
            var SRCIPTYPE = 8.14D;  // decimal | Integer in the form: D OR 0xHH
            var SRCNET = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var SRCMASK = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var DSTIPTYPE = 8.14D;  // decimal | Integer in the form: D OR 0xHH
            var DSTNET = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var DSTMASK = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var INITCOOKIE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTGW = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var DSTGWPORT = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH
            var ISDHCPCL = 8.14D;  // decimal | Integer in the form: D OR 0xHH
            var INSPI = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPost(SRCIPTYPE, SRCNET, SRCMASK, DSTIPTYPE, DSTNET, DSTMASK, INITCOOKIE, DSTGW, DSTGWPORT, ISDHCPCL, INSPI, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VpnRenegotiateTunnelApi.RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPostWithHttpInfo(SRCIPTYPE, SRCNET, SRCMASK, DSTIPTYPE, DSTNET, DSTMASK, INITCOOKIE, DSTGW, DSTGWPORT, ISDHCPCL, INSPI, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VpnRenegotiateTunnelApi.RenegotiateTunnelSRCIPTYPESRCNETSRCMASKDSTIPTYPEDSTNETDSTMASKINITCOOKIEDSTGWDSTGWPORTISDHCPCLINSPIPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRCIPTYPE** | **decimal** | Integer in the form: D OR 0xHH |  |
| **SRCNET** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **SRCMASK** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **DSTIPTYPE** | **decimal** | Integer in the form: D OR 0xHH |  |
| **DSTNET** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **DSTMASK** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **INITCOOKIE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **DSTGW** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **DSTGWPORT** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |
| **ISDHCPCL** | **decimal** | Integer in the form: D OR 0xHH |  |
| **INSPI** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |
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

