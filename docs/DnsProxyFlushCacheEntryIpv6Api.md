# SonicWallGen7.Api.DnsProxyFlushCacheEntryIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsProxyFlushCacheEntriesIpv6NameNAMEPost**](DnsProxyFlushCacheEntryIpv6Api.md#dnsproxyflushcacheentriesipv6namenamepost) | **POST** /dns-proxy/flush/cache-entries/ipv6/name/{NAME} |  |
| [**DnsProxyFlushCacheEntriesIpv6Post**](DnsProxyFlushCacheEntryIpv6Api.md#dnsproxyflushcacheentriesipv6post) | **POST** /dns-proxy/flush/cache-entries/ipv6 |  |

<a id="dnsproxyflushcacheentriesipv6namenamepost"></a>
# **DnsProxyFlushCacheEntriesIpv6NameNAMEPost**
> ApiStatus DnsProxyFlushCacheEntriesIpv6NameNAMEPost (string NAME, Object? body = null)



Flush the IPv6 dynamic DNS cache entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyFlushCacheEntriesIpv6NameNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyFlushCacheEntryIpv6Api(config);
            var NAME = "\"sonicwall.com\"";  // string | DNS proxy cache domain name. (default to "sonicwall.com")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyFlushCacheEntriesIpv6NameNAMEPost(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyFlushCacheEntryIpv6Api.DnsProxyFlushCacheEntriesIpv6NameNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyFlushCacheEntriesIpv6NameNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyFlushCacheEntriesIpv6NameNAMEPostWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyFlushCacheEntryIpv6Api.DnsProxyFlushCacheEntriesIpv6NameNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DNS proxy cache domain name. | [default to &quot;sonicwall.com&quot;] |
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

<a id="dnsproxyflushcacheentriesipv6post"></a>
# **DnsProxyFlushCacheEntriesIpv6Post**
> ApiStatus DnsProxyFlushCacheEntriesIpv6Post (Object? body = null)



Flush the IPv6 dynamic DNS cache entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyFlushCacheEntriesIpv6PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyFlushCacheEntryIpv6Api(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyFlushCacheEntriesIpv6Post(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyFlushCacheEntryIpv6Api.DnsProxyFlushCacheEntriesIpv6Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyFlushCacheEntriesIpv6PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyFlushCacheEntriesIpv6PostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyFlushCacheEntryIpv6Api.DnsProxyFlushCacheEntriesIpv6PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

