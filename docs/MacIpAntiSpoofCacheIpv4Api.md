# SonicWallGen7.Api.MacIpAntiSpoofCacheIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MacIpAntiSpoofIpv4CacheEntriesGet**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriesget) | **GET** /mac-ip-anti-spoof/ipv4/cache/entries |  |
| [**MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriesipipmacmacinterfaceifnamedelete) | **DELETE** /mac-ip-anti-spoof/ipv4/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriesipipmacmacinterfaceifnameget) | **GET** /mac-ip-anti-spoof/ipv4/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriesipipmacmacinterfaceifnamepatch) | **PATCH** /mac-ip-anti-spoof/ipv4/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriesipipmacmacinterfaceifnameput) | **PUT** /mac-ip-anti-spoof/ipv4/cache/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**MacIpAntiSpoofIpv4CacheEntriesPatch**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriespatch) | **PATCH** /mac-ip-anti-spoof/ipv4/cache/entries |  |
| [**MacIpAntiSpoofIpv4CacheEntriesPost**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriespost) | **POST** /mac-ip-anti-spoof/ipv4/cache/entries |  |
| [**MacIpAntiSpoofIpv4CacheEntriesPut**](MacIpAntiSpoofCacheIpv4Api.md#macipantispoofipv4cacheentriesput) | **PUT** /mac-ip-anti-spoof/ipv4/cache/entries |  |

<a id="macipantispoofipv4cacheentriesget"></a>
# **MacIpAntiSpoofIpv4CacheEntriesGet**
> MacIpAntiSpoofCacheIpv4Collection MacIpAntiSpoofIpv4CacheEntriesGet ()



Retrieve MAC IP anti spoof IPv4 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);

            try
            {
                MacIpAntiSpoofCacheIpv4Collection result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofCacheIpv4Collection> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MacIpAntiSpoofCacheIpv4Collection**](MacIpAntiSpoofCacheIpv4Collection.md)

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

<a id="macipantispoofipv4cacheentriesipipmacmacinterfaceifnamedelete"></a>
# **MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete**
> ApiStatus MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete (string IP, string MAC, string IFNAME)



Delete a MAC IP anti spoof IPv4 cache entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete(IP, MAC, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo(IP, MAC, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="macipantispoofipv4cacheentriesipipmacmacinterfaceifnameget"></a>
# **MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet**
> MacIpAntiSpoofCacheIpv4Collection MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet (string IP, string MAC, string IFNAME)



Retrieve MAC IP anti spoof IPv4 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")

            try
            {
                MacIpAntiSpoofCacheIpv4Collection result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet(IP, MAC, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofCacheIpv4Collection> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo(IP, MAC, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo: " + e.Message);
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

[**MacIpAntiSpoofCacheIpv4Collection**](MacIpAntiSpoofCacheIpv4Collection.md)

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

<a id="macipantispoofipv4cacheentriesipipmacmacinterfaceifnamepatch"></a>
# **MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch**
> ApiStatus MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch (string IP, string MAC, string IFNAME, MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null)



Patch MAC IP anti spoof IPv4 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")
            var macIpAntiSpoofCacheIpv4Collection = new MacIpAntiSpoofCacheIpv4Collection?(); // MacIpAntiSpoofCacheIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo: " + e.Message);
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
| **macIpAntiSpoofCacheIpv4Collection** | [**MacIpAntiSpoofCacheIpv4Collection?**](MacIpAntiSpoofCacheIpv4Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv4cacheentriesipipmacmacinterfaceifnameput"></a>
# **MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut**
> ApiStatus MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut (string IP, string MAC, string IFNAME, MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null)



Edit MAC IP anti spoof IPv4 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | MAC-IP anti-spoof static ip. (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC-IP anti-spoof static mac. (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | MAC-IP anti-spoof enabled static interface. (default to "X0")
            var macIpAntiSpoofCacheIpv4Collection = new MacIpAntiSpoofCacheIpv4Collection?(); // MacIpAntiSpoofCacheIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo: " + e.Message);
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
| **macIpAntiSpoofCacheIpv4Collection** | [**MacIpAntiSpoofCacheIpv4Collection?**](MacIpAntiSpoofCacheIpv4Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv4cacheentriespatch"></a>
# **MacIpAntiSpoofIpv4CacheEntriesPatch**
> ApiStatus MacIpAntiSpoofIpv4CacheEntriesPatch (MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null)



Patch MAC IP anti spoof IPv4 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var macIpAntiSpoofCacheIpv4Collection = new MacIpAntiSpoofCacheIpv4Collection?(); // MacIpAntiSpoofCacheIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesPatch(macIpAntiSpoofCacheIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesPatchWithHttpInfo(macIpAntiSpoofCacheIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofCacheIpv4Collection** | [**MacIpAntiSpoofCacheIpv4Collection?**](MacIpAntiSpoofCacheIpv4Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv4cacheentriespost"></a>
# **MacIpAntiSpoofIpv4CacheEntriesPost**
> ApiStatus MacIpAntiSpoofIpv4CacheEntriesPost (MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null)



Create a new MAC IP anti spoof IPv4 cache entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var macIpAntiSpoofCacheIpv4Collection = new MacIpAntiSpoofCacheIpv4Collection?(); // MacIpAntiSpoofCacheIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesPost(macIpAntiSpoofCacheIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesPostWithHttpInfo(macIpAntiSpoofCacheIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofCacheIpv4Collection** | [**MacIpAntiSpoofCacheIpv4Collection?**](MacIpAntiSpoofCacheIpv4Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv4cacheentriesput"></a>
# **MacIpAntiSpoofIpv4CacheEntriesPut**
> ApiStatus MacIpAntiSpoofIpv4CacheEntriesPut (MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null)



Edit MAC IP anti spoof IPv4 cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4CacheEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofCacheIpv4Api(config);
            var macIpAntiSpoofCacheIpv4Collection = new MacIpAntiSpoofCacheIpv4Collection?(); // MacIpAntiSpoofCacheIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4CacheEntriesPut(macIpAntiSpoofCacheIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4CacheEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4CacheEntriesPutWithHttpInfo(macIpAntiSpoofCacheIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofCacheIpv4Api.MacIpAntiSpoofIpv4CacheEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofCacheIpv4Collection** | [**MacIpAntiSpoofCacheIpv4Collection?**](MacIpAntiSpoofCacheIpv4Collection?.md) |  | [optional]  |

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

