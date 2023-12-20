# SonicWallGen7.Api.MacIpAntiSpoofCacheIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MacIpAntiSpoofIpv6CacheEntriesGet**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriesget) | **GET** /mac-ip-anti-spoof/ipv6/cache/entries |  |
| [**MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDelete**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriesipipmacmacinterfaceifnamedelete) | **DELETE** /mac-ip-anti-spoof/ipv6/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGet**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriesipipmacmacinterfaceifnameget) | **GET** /mac-ip-anti-spoof/ipv6/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatch**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriesipipmacmacinterfaceifnamepatch) | **PATCH** /mac-ip-anti-spoof/ipv6/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPut**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriesipipmacmacinterfaceifnameput) | **PUT** /mac-ip-anti-spoof/ipv6/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv6CacheEntriesPatch**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriespatch) | **PATCH** /mac-ip-anti-spoof/ipv6/cache/entries |  |
| [**MacIpAntiSpoofIpv6CacheEntriesPost**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriespost) | **POST** /mac-ip-anti-spoof/ipv6/cache/entries |  |
| [**MacIpAntiSpoofIpv6CacheEntriesPut**](MacIpAntiSpoofCacheIpv6Api.md#macipantispoofipv6cacheentriesput) | **PUT** /mac-ip-anti-spoof/ipv6/cache/entries |  |

<a id="macipantispoofipv6cacheentriesget"></a>
# **MacIpAntiSpoofIpv6CacheEntriesGet**
> MacIpAntiSpoofCacheIpv6Collection MacIpAntiSpoofIpv6CacheEntriesGet ()



Retrieve MAC IP anti spoof IPv6 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);

            try
            {
                MacIpAntiSpoofCacheIpv6Collection result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofCacheIpv6Collection> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MacIpAntiSpoofCacheIpv6Collection**](MacIpAntiSpoofCacheIpv6Collection.md)

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

<a id="macipantispoofipv6cacheentriesipipmacmacinterfaceifnamedelete"></a>
# **MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDelete**
> ApiStatus MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDelete (string IP, string MAC, string IFNAME)



Delete a MAC IP anti spoof IPv6 cache entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDelete(IP, MAC, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo(IP, MAC, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | MAC-IP anti-spoof static ip. | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **MAC** | **string** | MAC-IP anti-spoof static mac. | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | MAC-IP anti-spoof enabled static interface. | [default to &quot;X0&quot;] |

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

<a id="macipantispoofipv6cacheentriesipipmacmacinterfaceifnameget"></a>
# **MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGet**
> MacIpAntiSpoofCacheIpv6Collection MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGet (string IP, string MAC, string IFNAME)



Retrieve MAC IP anti spoof IPv6 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")

            try
            {
                MacIpAntiSpoofCacheIpv6Collection result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGet(IP, MAC, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofCacheIpv6Collection> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo(IP, MAC, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | MAC-IP anti-spoof static ip. | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **MAC** | **string** | MAC-IP anti-spoof static mac. | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | MAC-IP anti-spoof enabled static interface. | [default to &quot;X0&quot;] |

### Return type

[**MacIpAntiSpoofCacheIpv6Collection**](MacIpAntiSpoofCacheIpv6Collection.md)

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

<a id="macipantispoofipv6cacheentriesipipmacmacinterfaceifnamepatch"></a>
# **MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatch**
> ApiStatus MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatch (string IP, string MAC, string IFNAME, MacIpAntiSpoofCacheIpv6Collection? macIpAntiSpoofCacheIpv6Collection = null)



Patch MAC IP anti spoof IPv6 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")
            var macIpAntiSpoofCacheIpv6Collection = new MacIpAntiSpoofCacheIpv6Collection?(); // MacIpAntiSpoofCacheIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatch(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | MAC-IP anti-spoof static ip. | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **MAC** | **string** | MAC-IP anti-spoof static mac. | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | MAC-IP anti-spoof enabled static interface. | [default to &quot;X0&quot;] |
| **macIpAntiSpoofCacheIpv6Collection** | [**MacIpAntiSpoofCacheIpv6Collection?**](MacIpAntiSpoofCacheIpv6Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv6cacheentriesipipmacmacinterfaceifnameput"></a>
# **MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPut**
> ApiStatus MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPut (string IP, string MAC, string IFNAME, MacIpAntiSpoofCacheIpv6Collection? macIpAntiSpoofCacheIpv6Collection = null)



Edit MAC IP anti spoof IPv6 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")
            var macIpAntiSpoofCacheIpv6Collection = new MacIpAntiSpoofCacheIpv6Collection?(); // MacIpAntiSpoofCacheIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPut(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | MAC-IP anti-spoof static ip. | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **MAC** | **string** | MAC-IP anti-spoof static mac. | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | MAC-IP anti-spoof enabled static interface. | [default to &quot;X0&quot;] |
| **macIpAntiSpoofCacheIpv6Collection** | [**MacIpAntiSpoofCacheIpv6Collection?**](MacIpAntiSpoofCacheIpv6Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv6cacheentriespatch"></a>
# **MacIpAntiSpoofIpv6CacheEntriesPatch**
> ApiStatus MacIpAntiSpoofIpv6CacheEntriesPatch (MacIpAntiSpoofCacheIpv6Collection? macIpAntiSpoofCacheIpv6Collection = null)



Patch MAC IP anti spoof IPv6 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var macIpAntiSpoofCacheIpv6Collection = new MacIpAntiSpoofCacheIpv6Collection?(); // MacIpAntiSpoofCacheIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesPatch(macIpAntiSpoofCacheIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesPatchWithHttpInfo(macIpAntiSpoofCacheIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofCacheIpv6Collection** | [**MacIpAntiSpoofCacheIpv6Collection?**](MacIpAntiSpoofCacheIpv6Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv6cacheentriespost"></a>
# **MacIpAntiSpoofIpv6CacheEntriesPost**
> ApiStatus MacIpAntiSpoofIpv6CacheEntriesPost (MacIpAntiSpoofCacheIpv6Collection? macIpAntiSpoofCacheIpv6Collection = null)



Create a new MAC IP anti spoof IPv6 cache entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var macIpAntiSpoofCacheIpv6Collection = new MacIpAntiSpoofCacheIpv6Collection?(); // MacIpAntiSpoofCacheIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesPost(macIpAntiSpoofCacheIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesPostWithHttpInfo(macIpAntiSpoofCacheIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofCacheIpv6Collection** | [**MacIpAntiSpoofCacheIpv6Collection?**](MacIpAntiSpoofCacheIpv6Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv6cacheentriesput"></a>
# **MacIpAntiSpoofIpv6CacheEntriesPut**
> ApiStatus MacIpAntiSpoofIpv6CacheEntriesPut (MacIpAntiSpoofCacheIpv6Collection? macIpAntiSpoofCacheIpv6Collection = null)



Edit MAC IP anti spoof IPv6 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6CacheEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv6Api(config);
            var macIpAntiSpoofCacheIpv6Collection = new MacIpAntiSpoofCacheIpv6Collection?(); // MacIpAntiSpoofCacheIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6CacheEntriesPut(macIpAntiSpoofCacheIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6CacheEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6CacheEntriesPutWithHttpInfo(macIpAntiSpoofCacheIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv6Api.MacIpAntiSpoofIpv6CacheEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofCacheIpv6Collection** | [**MacIpAntiSpoofCacheIpv6Collection?**](MacIpAntiSpoofCacheIpv6Collection?.md) |  | [optional]  |

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

