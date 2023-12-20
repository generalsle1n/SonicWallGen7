# SonicWallGen7.Api.SslVpnDeviceProfileClientDnsInheritApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslVpnDeviceProfileClientDnsInheritNameNAMEPut**](SslVpnDeviceProfileClientDnsInheritApi.md#sslvpndeviceprofileclientdnsinheritnamenameput) | **PUT** /ssl-vpn/device-profile-client-dns-inherit/name/{NAME} |  |

<a id="sslvpndeviceprofileclientdnsinheritnamenameput"></a>
# **SslVpnDeviceProfileClientDnsInheritNameNAMEPut**
> ApiStatus SslVpnDeviceProfileClientDnsInheritNameNAMEPut (string NAME, Object? body = null)



Inherit DNS servers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnDeviceProfileClientDnsInheritNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnDeviceProfileClientDnsInheritApi(config);
            var NAME = "\"Default Device Profile\"";  // string | Device name in the form: WORD or \"QUOTED STRING\" (default to "Default Device Profile")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnDeviceProfileClientDnsInheritNameNAMEPut(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnDeviceProfileClientDnsInheritApi.SslVpnDeviceProfileClientDnsInheritNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnDeviceProfileClientDnsInheritNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnDeviceProfileClientDnsInheritNameNAMEPutWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnDeviceProfileClientDnsInheritApi.SslVpnDeviceProfileClientDnsInheritNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Device name in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;Default Device Profile&quot;] |
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

