# SonicWallGen7.Api.DnsSplitEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsSplitEntriesDomainNAMEDelete**](DnsSplitEntryApi.md#dnssplitentriesdomainnamedelete) | **DELETE** /dns/split-entries/domain/{NAME} |  |
| [**DnsSplitEntriesDomainNAMEGet**](DnsSplitEntryApi.md#dnssplitentriesdomainnameget) | **GET** /dns/split-entries/domain/{NAME} |  |
| [**DnsSplitEntriesDomainNAMEPatch**](DnsSplitEntryApi.md#dnssplitentriesdomainnamepatch) | **PATCH** /dns/split-entries/domain/{NAME} |  |
| [**DnsSplitEntriesDomainNAMEPut**](DnsSplitEntryApi.md#dnssplitentriesdomainnameput) | **PUT** /dns/split-entries/domain/{NAME} |  |
| [**DnsSplitEntriesGet**](DnsSplitEntryApi.md#dnssplitentriesget) | **GET** /dns/split-entries |  |
| [**DnsSplitEntriesPatch**](DnsSplitEntryApi.md#dnssplitentriespatch) | **PATCH** /dns/split-entries |  |
| [**DnsSplitEntriesPost**](DnsSplitEntryApi.md#dnssplitentriespost) | **POST** /dns/split-entries |  |
| [**DnsSplitEntriesPut**](DnsSplitEntryApi.md#dnssplitentriesput) | **PUT** /dns/split-entries |  |

<a id="dnssplitentriesdomainnamedelete"></a>
# **DnsSplitEntriesDomainNAMEDelete**
> ApiStatus DnsSplitEntriesDomainNAMEDelete (string NAME)



Delete a DNS split DNS entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesDomainNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Split DNS entry domain name (default to "sonicwall.com")

            try
            {
                ApiStatus result = apiInstance.DnsSplitEntriesDomainNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesDomainNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSplitEntriesDomainNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Split DNS entry domain name | [default to &quot;sonicwall.com&quot;] |

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

<a id="dnssplitentriesdomainnameget"></a>
# **DnsSplitEntriesDomainNAMEGet**
> DnsSplitEntryCollection DnsSplitEntriesDomainNAMEGet (string NAME)



Retrieve DNS split DNS entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesDomainNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Split DNS entry domain name (default to "sonicwall.com")

            try
            {
                DnsSplitEntryCollection result = apiInstance.DnsSplitEntriesDomainNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesDomainNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsSplitEntryCollection> response = apiInstance.DnsSplitEntriesDomainNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Split DNS entry domain name | [default to &quot;sonicwall.com&quot;] |

### Return type

[**DnsSplitEntryCollection**](DnsSplitEntryCollection.md)

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

<a id="dnssplitentriesdomainnamepatch"></a>
# **DnsSplitEntriesDomainNAMEPatch**
> ApiStatus DnsSplitEntriesDomainNAMEPatch (string NAME, DnsSplitEntryCollection? dnsSplitEntryCollection = null)



Patch DNS split DNS entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesDomainNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Split DNS entry domain name (default to "sonicwall.com")
            var dnsSplitEntryCollection = new DnsSplitEntryCollection?(); // DnsSplitEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSplitEntriesDomainNAMEPatch(NAME, dnsSplitEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesDomainNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSplitEntriesDomainNAMEPatchWithHttpInfo(NAME, dnsSplitEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Split DNS entry domain name | [default to &quot;sonicwall.com&quot;] |
| **dnsSplitEntryCollection** | [**DnsSplitEntryCollection?**](DnsSplitEntryCollection?.md) |  | [optional]  |

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

<a id="dnssplitentriesdomainnameput"></a>
# **DnsSplitEntriesDomainNAMEPut**
> ApiStatus DnsSplitEntriesDomainNAMEPut (string NAME, DnsSplitEntryCollection? dnsSplitEntryCollection = null)



Edit DNS split DNS entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesDomainNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Split DNS entry domain name (default to "sonicwall.com")
            var dnsSplitEntryCollection = new DnsSplitEntryCollection?(); // DnsSplitEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSplitEntriesDomainNAMEPut(NAME, dnsSplitEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesDomainNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSplitEntriesDomainNAMEPutWithHttpInfo(NAME, dnsSplitEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesDomainNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Split DNS entry domain name | [default to &quot;sonicwall.com&quot;] |
| **dnsSplitEntryCollection** | [**DnsSplitEntryCollection?**](DnsSplitEntryCollection?.md) |  | [optional]  |

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

<a id="dnssplitentriesget"></a>
# **DnsSplitEntriesGet**
> DnsSplitEntryCollection DnsSplitEntriesGet ()



Retrieve DNS split DNS entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);

            try
            {
                DnsSplitEntryCollection result = apiInstance.DnsSplitEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsSplitEntryCollection> response = apiInstance.DnsSplitEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DnsSplitEntryCollection**](DnsSplitEntryCollection.md)

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

<a id="dnssplitentriespatch"></a>
# **DnsSplitEntriesPatch**
> ApiStatus DnsSplitEntriesPatch (DnsSplitEntryCollection? dnsSplitEntryCollection = null)



Patch DNS split DNS entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var dnsSplitEntryCollection = new DnsSplitEntryCollection?(); // DnsSplitEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSplitEntriesPatch(dnsSplitEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSplitEntriesPatchWithHttpInfo(dnsSplitEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSplitEntryCollection** | [**DnsSplitEntryCollection?**](DnsSplitEntryCollection?.md) |  | [optional]  |

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

<a id="dnssplitentriespost"></a>
# **DnsSplitEntriesPost**
> ApiStatus DnsSplitEntriesPost (DnsSplitEntryCollection? dnsSplitEntryCollection = null)



Create a new DNS split DNS entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var dnsSplitEntryCollection = new DnsSplitEntryCollection?(); // DnsSplitEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSplitEntriesPost(dnsSplitEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSplitEntriesPostWithHttpInfo(dnsSplitEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSplitEntryCollection** | [**DnsSplitEntryCollection?**](DnsSplitEntryCollection?.md) |  | [optional]  |

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

<a id="dnssplitentriesput"></a>
# **DnsSplitEntriesPut**
> ApiStatus DnsSplitEntriesPut (DnsSplitEntryCollection? dnsSplitEntryCollection = null)



Edit DNS split DNS entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSplitEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSplitEntryApi(config);
            var dnsSplitEntryCollection = new DnsSplitEntryCollection?(); // DnsSplitEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSplitEntriesPut(dnsSplitEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSplitEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSplitEntriesPutWithHttpInfo(dnsSplitEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSplitEntryApi.DnsSplitEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSplitEntryCollection** | [**DnsSplitEntryCollection?**](DnsSplitEntryCollection?.md) |  | [optional]  |

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

