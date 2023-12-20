# SonicWallGen7.Api.NdpCacheEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NdpCacheEntriesDelete**](NdpCacheEntryApi.md#ndpcacheentriesdelete) | **DELETE** /ndp/cache/entries |  |
| [**NdpCacheEntriesIpIPInterfaceIFNAMEDelete**](NdpCacheEntryApi.md#ndpcacheentriesipipinterfaceifnamedelete) | **DELETE** /ndp/cache/entries/ip/{IP}/interface/{IFNAME} |  |

<a id="ndpcacheentriesdelete"></a>
# **NdpCacheEntriesDelete**
> ApiStatus NdpCacheEntriesDelete ()



Clear neighbor discovery cache entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpCacheEntriesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpCacheEntryApi(config);

            try
            {
                ApiStatus result = apiInstance.NdpCacheEntriesDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpCacheEntryApi.NdpCacheEntriesDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpCacheEntriesDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpCacheEntriesDeleteWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpCacheEntryApi.NdpCacheEntriesDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="ndpcacheentriesipipinterfaceifnamedelete"></a>
# **NdpCacheEntriesIpIPInterfaceIFNAMEDelete**
> ApiStatus NdpCacheEntriesIpIPInterfaceIFNAMEDelete (string IP, string IFNAME)



Clear neighbor discovery cache entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpCacheEntriesIpIPInterfaceIFNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpCacheEntryApi(config);
            var IP = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")
            var IFNAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                ApiStatus result = apiInstance.NdpCacheEntriesIpIPInterfaceIFNAMEDelete(IP, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpCacheEntryApi.NdpCacheEntriesIpIPInterfaceIFNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpCacheEntriesIpIPInterfaceIFNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpCacheEntriesIpIPInterfaceIFNAMEDeleteWithHttpInfo(IP, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpCacheEntryApi.NdpCacheEntriesIpIPInterfaceIFNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |
| **IFNAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

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

