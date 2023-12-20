# SonicWallGen7.Api.ContentFilterCfsCustomCategoryCategoryEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDelete**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriesdomainnamedelete) | **DELETE** /content-filter/cfs/custom-category/category-entries/domain/{NAME} |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGet**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriesdomainnameget) | **GET** /content-filter/cfs/custom-category/category-entries/domain/{NAME} |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatch**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriesdomainnamepatch) | **PATCH** /content-filter/cfs/custom-category/category-entries/domain/{NAME} |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPut**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriesdomainnameput) | **PUT** /content-filter/cfs/custom-category/category-entries/domain/{NAME} |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesGet**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriesget) | **GET** /content-filter/cfs/custom-category/category-entries |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesPatch**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriespatch) | **PATCH** /content-filter/cfs/custom-category/category-entries |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesPost**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriespost) | **POST** /content-filter/cfs/custom-category/category-entries |  |
| [**ContentFilterCfsCustomCategoryCategoryEntriesPut**](ContentFilterCfsCustomCategoryCategoryEntryApi.md#contentfiltercfscustomcategorycategoryentriesput) | **PUT** /content-filter/cfs/custom-category/category-entries |  |

<a id="contentfiltercfscustomcategorycategoryentriesdomainnamedelete"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDelete**
> ApiStatus ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDelete (string NAME)



Delete a content filter cfs custom-category category-entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var NAME = "\"google.com\"";  // string | CFS custom category domain. (default to "google.com")

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS custom category domain. | [default to &quot;google.com&quot;] |

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

<a id="contentfiltercfscustomcategorycategoryentriesdomainnameget"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGet**
> ContentFilterCfsCustomCategoryCategoryEntryCollection ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGet (string NAME)



Retrieve content filter cfs custom-category category-entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var NAME = "\"google.com\"";  // string | CFS custom category domain. (default to "google.com")

            try
            {
                ContentFilterCfsCustomCategoryCategoryEntryCollection result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterCfsCustomCategoryCategoryEntryCollection> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS custom category domain. | [default to &quot;google.com&quot;] |

### Return type

[**ContentFilterCfsCustomCategoryCategoryEntryCollection**](ContentFilterCfsCustomCategoryCategoryEntryCollection.md)

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

<a id="contentfiltercfscustomcategorycategoryentriesdomainnamepatch"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatch**
> ApiStatus ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatch (string NAME, ContentFilterCfsCustomCategoryCategoryEntryCollection? contentFilterCfsCustomCategoryCategoryEntryCollection = null)



Patch content filter cfs custom-category category-entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var NAME = "\"google.com\"";  // string | CFS custom category domain. (default to "google.com")
            var contentFilterCfsCustomCategoryCategoryEntryCollection = new ContentFilterCfsCustomCategoryCategoryEntryCollection?(); // ContentFilterCfsCustomCategoryCategoryEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatch(NAME, contentFilterCfsCustomCategoryCategoryEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatchWithHttpInfo(NAME, contentFilterCfsCustomCategoryCategoryEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS custom category domain. | [default to &quot;google.com&quot;] |
| **contentFilterCfsCustomCategoryCategoryEntryCollection** | [**ContentFilterCfsCustomCategoryCategoryEntryCollection?**](ContentFilterCfsCustomCategoryCategoryEntryCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfscustomcategorycategoryentriesdomainnameput"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPut**
> ApiStatus ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPut (string NAME, ContentFilterCfsCustomCategoryCategoryEntryCollection? contentFilterCfsCustomCategoryCategoryEntryCollection = null)



Edit content filter cfs custom-category category-entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var NAME = "\"google.com\"";  // string | CFS custom category domain. (default to "google.com")
            var contentFilterCfsCustomCategoryCategoryEntryCollection = new ContentFilterCfsCustomCategoryCategoryEntryCollection?(); // ContentFilterCfsCustomCategoryCategoryEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPut(NAME, contentFilterCfsCustomCategoryCategoryEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPutWithHttpInfo(NAME, contentFilterCfsCustomCategoryCategoryEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesDomainNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS custom category domain. | [default to &quot;google.com&quot;] |
| **contentFilterCfsCustomCategoryCategoryEntryCollection** | [**ContentFilterCfsCustomCategoryCategoryEntryCollection?**](ContentFilterCfsCustomCategoryCategoryEntryCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfscustomcategorycategoryentriesget"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesGet**
> ContentFilterCfsCustomCategoryCategoryEntryCollection ContentFilterCfsCustomCategoryCategoryEntriesGet ()



Retrieve content filter cfs custom-category category-entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);

            try
            {
                ContentFilterCfsCustomCategoryCategoryEntryCollection result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterCfsCustomCategoryCategoryEntryCollection> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ContentFilterCfsCustomCategoryCategoryEntryCollection**](ContentFilterCfsCustomCategoryCategoryEntryCollection.md)

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

<a id="contentfiltercfscustomcategorycategoryentriespatch"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesPatch**
> ApiStatus ContentFilterCfsCustomCategoryCategoryEntriesPatch (ContentFilterCfsCustomCategoryCategoryEntryCollection? contentFilterCfsCustomCategoryCategoryEntryCollection = null)



Patch content filter cfs custom-category category-entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var contentFilterCfsCustomCategoryCategoryEntryCollection = new ContentFilterCfsCustomCategoryCategoryEntryCollection?(); // ContentFilterCfsCustomCategoryCategoryEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesPatch(contentFilterCfsCustomCategoryCategoryEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesPatchWithHttpInfo(contentFilterCfsCustomCategoryCategoryEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsCustomCategoryCategoryEntryCollection** | [**ContentFilterCfsCustomCategoryCategoryEntryCollection?**](ContentFilterCfsCustomCategoryCategoryEntryCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfscustomcategorycategoryentriespost"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesPost**
> ApiStatus ContentFilterCfsCustomCategoryCategoryEntriesPost (ContentFilterCfsCustomCategoryCategoryEntryCollection? contentFilterCfsCustomCategoryCategoryEntryCollection = null)



Create a new content filter cfs custom-category category-entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var contentFilterCfsCustomCategoryCategoryEntryCollection = new ContentFilterCfsCustomCategoryCategoryEntryCollection?(); // ContentFilterCfsCustomCategoryCategoryEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesPost(contentFilterCfsCustomCategoryCategoryEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesPostWithHttpInfo(contentFilterCfsCustomCategoryCategoryEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsCustomCategoryCategoryEntryCollection** | [**ContentFilterCfsCustomCategoryCategoryEntryCollection?**](ContentFilterCfsCustomCategoryCategoryEntryCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfscustomcategorycategoryentriesput"></a>
# **ContentFilterCfsCustomCategoryCategoryEntriesPut**
> ApiStatus ContentFilterCfsCustomCategoryCategoryEntriesPut (ContentFilterCfsCustomCategoryCategoryEntryCollection? contentFilterCfsCustomCategoryCategoryEntryCollection = null)



Edit content filter cfs custom-category category-entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsCustomCategoryCategoryEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsCustomCategoryCategoryEntryApi(config);
            var contentFilterCfsCustomCategoryCategoryEntryCollection = new ContentFilterCfsCustomCategoryCategoryEntryCollection?(); // ContentFilterCfsCustomCategoryCategoryEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesPut(contentFilterCfsCustomCategoryCategoryEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsCustomCategoryCategoryEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsCustomCategoryCategoryEntriesPutWithHttpInfo(contentFilterCfsCustomCategoryCategoryEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsCustomCategoryCategoryEntryApi.ContentFilterCfsCustomCategoryCategoryEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsCustomCategoryCategoryEntryCollection** | [**ContentFilterCfsCustomCategoryCategoryEntryCollection?**](ContentFilterCfsCustomCategoryCategoryEntryCollection?.md) |  | [optional]  |

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

