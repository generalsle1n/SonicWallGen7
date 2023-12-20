# SonicWallGen7.Api.DnsProxyCacheEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsProxyCacheEntriesDomainNAMEDelete**](DnsProxyCacheEntryApi.md#dnsproxycacheentriesdomainnamedelete) | **DELETE** /dns-proxy/cache-entries/domain/{NAME} |  |
| [**DnsProxyCacheEntriesDomainNAMEGet**](DnsProxyCacheEntryApi.md#dnsproxycacheentriesdomainnameget) | **GET** /dns-proxy/cache-entries/domain/{NAME} |  |
| [**DnsProxyCacheEntriesDomainNAMEPatch**](DnsProxyCacheEntryApi.md#dnsproxycacheentriesdomainnamepatch) | **PATCH** /dns-proxy/cache-entries/domain/{NAME} |  |
| [**DnsProxyCacheEntriesDomainNAMEPut**](DnsProxyCacheEntryApi.md#dnsproxycacheentriesdomainnameput) | **PUT** /dns-proxy/cache-entries/domain/{NAME} |  |
| [**DnsProxyCacheEntriesGet**](DnsProxyCacheEntryApi.md#dnsproxycacheentriesget) | **GET** /dns-proxy/cache-entries |  |
| [**DnsProxyCacheEntriesPatch**](DnsProxyCacheEntryApi.md#dnsproxycacheentriespatch) | **PATCH** /dns-proxy/cache-entries |  |
| [**DnsProxyCacheEntriesPost**](DnsProxyCacheEntryApi.md#dnsproxycacheentriespost) | **POST** /dns-proxy/cache-entries |  |
| [**DnsProxyCacheEntriesPut**](DnsProxyCacheEntryApi.md#dnsproxycacheentriesput) | **PUT** /dns-proxy/cache-entries |  |

<a id="dnsproxycacheentriesdomainnamedelete"></a>
# **DnsProxyCacheEntriesDomainNAMEDelete**
> ApiStatus DnsProxyCacheEntriesDomainNAMEDelete (string NAME)



Delete a DNS proxy cache entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesDomainNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Static DNS cache domain name. (default to "sonicwall.com")

            try
            {
                ApiStatus result = apiInstance.DnsProxyCacheEntriesDomainNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesDomainNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyCacheEntriesDomainNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Static DNS cache domain name. | [default to &quot;sonicwall.com&quot;] |

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

<a id="dnsproxycacheentriesdomainnameget"></a>
# **DnsProxyCacheEntriesDomainNAMEGet**
> DnsProxyCacheEntryCollection DnsProxyCacheEntriesDomainNAMEGet (string NAME)



Retrieve DNS proxy cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesDomainNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Static DNS cache domain name. (default to "sonicwall.com")

            try
            {
                DnsProxyCacheEntryCollection result = apiInstance.DnsProxyCacheEntriesDomainNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesDomainNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsProxyCacheEntryCollection> response = apiInstance.DnsProxyCacheEntriesDomainNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Static DNS cache domain name. | [default to &quot;sonicwall.com&quot;] |

### Return type

[**DnsProxyCacheEntryCollection**](DnsProxyCacheEntryCollection.md)

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

<a id="dnsproxycacheentriesdomainnamepatch"></a>
# **DnsProxyCacheEntriesDomainNAMEPatch**
> ApiStatus DnsProxyCacheEntriesDomainNAMEPatch (string NAME, DnsProxyCacheEntryCollection? dnsProxyCacheEntryCollection = null)



Patch DNS proxy cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesDomainNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Static DNS cache domain name. (default to "sonicwall.com")
            var dnsProxyCacheEntryCollection = new DnsProxyCacheEntryCollection?(); // DnsProxyCacheEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyCacheEntriesDomainNAMEPatch(NAME, dnsProxyCacheEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesDomainNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyCacheEntriesDomainNAMEPatchWithHttpInfo(NAME, dnsProxyCacheEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Static DNS cache domain name. | [default to &quot;sonicwall.com&quot;] |
| **dnsProxyCacheEntryCollection** | [**DnsProxyCacheEntryCollection?**](DnsProxyCacheEntryCollection?.md) |  | [optional]  |

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

<a id="dnsproxycacheentriesdomainnameput"></a>
# **DnsProxyCacheEntriesDomainNAMEPut**
> ApiStatus DnsProxyCacheEntriesDomainNAMEPut (string NAME, DnsProxyCacheEntryCollection? dnsProxyCacheEntryCollection = null)



Edit DNS proxy cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesDomainNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Static DNS cache domain name. (default to "sonicwall.com")
            var dnsProxyCacheEntryCollection = new DnsProxyCacheEntryCollection?(); // DnsProxyCacheEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyCacheEntriesDomainNAMEPut(NAME, dnsProxyCacheEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesDomainNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyCacheEntriesDomainNAMEPutWithHttpInfo(NAME, dnsProxyCacheEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesDomainNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Static DNS cache domain name. | [default to &quot;sonicwall.com&quot;] |
| **dnsProxyCacheEntryCollection** | [**DnsProxyCacheEntryCollection?**](DnsProxyCacheEntryCollection?.md) |  | [optional]  |

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

<a id="dnsproxycacheentriesget"></a>
# **DnsProxyCacheEntriesGet**
> DnsProxyCacheEntryCollection DnsProxyCacheEntriesGet ()



Retrieve DNS proxy cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);

            try
            {
                DnsProxyCacheEntryCollection result = apiInstance.DnsProxyCacheEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsProxyCacheEntryCollection> response = apiInstance.DnsProxyCacheEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DnsProxyCacheEntryCollection**](DnsProxyCacheEntryCollection.md)

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

<a id="dnsproxycacheentriespatch"></a>
# **DnsProxyCacheEntriesPatch**
> ApiStatus DnsProxyCacheEntriesPatch (DnsProxyCacheEntryCollection? dnsProxyCacheEntryCollection = null)



Patch DNS proxy cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var dnsProxyCacheEntryCollection = new DnsProxyCacheEntryCollection?(); // DnsProxyCacheEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyCacheEntriesPatch(dnsProxyCacheEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyCacheEntriesPatchWithHttpInfo(dnsProxyCacheEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsProxyCacheEntryCollection** | [**DnsProxyCacheEntryCollection?**](DnsProxyCacheEntryCollection?.md) |  | [optional]  |

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

<a id="dnsproxycacheentriespost"></a>
# **DnsProxyCacheEntriesPost**
> ApiStatus DnsProxyCacheEntriesPost (DnsProxyCacheEntryCollection? dnsProxyCacheEntryCollection = null)



Create a new DNS proxy cache entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var dnsProxyCacheEntryCollection = new DnsProxyCacheEntryCollection?(); // DnsProxyCacheEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyCacheEntriesPost(dnsProxyCacheEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyCacheEntriesPostWithHttpInfo(dnsProxyCacheEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsProxyCacheEntryCollection** | [**DnsProxyCacheEntryCollection?**](DnsProxyCacheEntryCollection?.md) |  | [optional]  |

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

<a id="dnsproxycacheentriesput"></a>
# **DnsProxyCacheEntriesPut**
> ApiStatus DnsProxyCacheEntriesPut (DnsProxyCacheEntryCollection? dnsProxyCacheEntryCollection = null)



Edit DNS proxy cache entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsProxyCacheEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheEntryApi(config);
            var dnsProxyCacheEntryCollection = new DnsProxyCacheEntryCollection?(); // DnsProxyCacheEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsProxyCacheEntriesPut(dnsProxyCacheEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsProxyCacheEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsProxyCacheEntriesPutWithHttpInfo(dnsProxyCacheEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheEntryApi.DnsProxyCacheEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsProxyCacheEntryCollection** | [**DnsProxyCacheEntryCollection?**](DnsProxyCacheEntryCollection?.md) |  | [optional]  |

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

