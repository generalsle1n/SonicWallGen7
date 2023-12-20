# SonicWallGen7.Api.ContentFilterUriListObjectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContentFilterUriListObjectsGet**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsget) | **GET** /content-filter/uri-list-objects |  |
| [**ContentFilterUriListObjectsNameNAMEDelete**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsnamenamedelete) | **DELETE** /content-filter/uri-list-objects/name/{NAME} |  |
| [**ContentFilterUriListObjectsNameNAMEGet**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsnamenameget) | **GET** /content-filter/uri-list-objects/name/{NAME} |  |
| [**ContentFilterUriListObjectsNameNAMEPatch**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsnamenamepatch) | **PATCH** /content-filter/uri-list-objects/name/{NAME} |  |
| [**ContentFilterUriListObjectsNameNAMEPut**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsnamenameput) | **PUT** /content-filter/uri-list-objects/name/{NAME} |  |
| [**ContentFilterUriListObjectsPatch**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectspatch) | **PATCH** /content-filter/uri-list-objects |  |
| [**ContentFilterUriListObjectsPost**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectspost) | **POST** /content-filter/uri-list-objects |  |
| [**ContentFilterUriListObjectsPut**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsput) | **PUT** /content-filter/uri-list-objects |  |
| [**ContentFilterUriListObjectsUuidUUIDDelete**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsuuiduuiddelete) | **DELETE** /content-filter/uri-list-objects/uuid/{UUID} |  |
| [**ContentFilterUriListObjectsUuidUUIDGet**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsuuiduuidget) | **GET** /content-filter/uri-list-objects/uuid/{UUID} |  |
| [**ContentFilterUriListObjectsUuidUUIDPatch**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsuuiduuidpatch) | **PATCH** /content-filter/uri-list-objects/uuid/{UUID} |  |
| [**ContentFilterUriListObjectsUuidUUIDPut**](ContentFilterUriListObjectApi.md#contentfilterurilistobjectsuuiduuidput) | **PUT** /content-filter/uri-list-objects/uuid/{UUID} |  |

<a id="contentfilterurilistobjectsget"></a>
# **ContentFilterUriListObjectsGet**
> ContentFilterUriListObjectCollection ContentFilterUriListObjectsGet ()



Retrieve content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);

            try
            {
                ContentFilterUriListObjectCollection result = apiInstance.ContentFilterUriListObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterUriListObjectCollection> response = apiInstance.ContentFilterUriListObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ContentFilterUriListObjectCollection**](ContentFilterUriListObjectCollection.md)

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

<a id="contentfilterurilistobjectsnamenamedelete"></a>
# **ContentFilterUriListObjectsNameNAMEDelete**
> ApiStatus ContentFilterUriListObjectsNameNAMEDelete (string NAME)



Delete a content filter URI list object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var NAME = "\"White URI list object\"";  // string | Content filter URI list object name. (default to "White URI list object")

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Content filter URI list object name. | [default to &quot;White URI list object&quot;] |

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

<a id="contentfilterurilistobjectsnamenameget"></a>
# **ContentFilterUriListObjectsNameNAMEGet**
> ContentFilterUriListObjectCollection ContentFilterUriListObjectsNameNAMEGet (string NAME)



Retrieve content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var NAME = "\"White URI list object\"";  // string | Content filter URI list object name. (default to "White URI list object")

            try
            {
                ContentFilterUriListObjectCollection result = apiInstance.ContentFilterUriListObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterUriListObjectCollection> response = apiInstance.ContentFilterUriListObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Content filter URI list object name. | [default to &quot;White URI list object&quot;] |

### Return type

[**ContentFilterUriListObjectCollection**](ContentFilterUriListObjectCollection.md)

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

<a id="contentfilterurilistobjectsnamenamepatch"></a>
# **ContentFilterUriListObjectsNameNAMEPatch**
> ApiStatus ContentFilterUriListObjectsNameNAMEPatch (string NAME, ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Patch content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var NAME = "\"White URI list object\"";  // string | Content filter URI list object name. (default to "White URI list object")
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsNameNAMEPatch(NAME, contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsNameNAMEPatchWithHttpInfo(NAME, contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Content filter URI list object name. | [default to &quot;White URI list object&quot;] |
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

<a id="contentfilterurilistobjectsnamenameput"></a>
# **ContentFilterUriListObjectsNameNAMEPut**
> ApiStatus ContentFilterUriListObjectsNameNAMEPut (string NAME, ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Edit content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var NAME = "\"White URI list object\"";  // string | Content filter URI list object name. (default to "White URI list object")
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsNameNAMEPut(NAME, contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsNameNAMEPutWithHttpInfo(NAME, contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Content filter URI list object name. | [default to &quot;White URI list object&quot;] |
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

<a id="contentfilterurilistobjectspatch"></a>
# **ContentFilterUriListObjectsPatch**
> ApiStatus ContentFilterUriListObjectsPatch (ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Patch content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsPatch(contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsPatchWithHttpInfo(contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

<a id="contentfilterurilistobjectspost"></a>
# **ContentFilterUriListObjectsPost**
> ApiStatus ContentFilterUriListObjectsPost (ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Create a new content filter URI list object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsPost(contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsPostWithHttpInfo(contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

<a id="contentfilterurilistobjectsput"></a>
# **ContentFilterUriListObjectsPut**
> ApiStatus ContentFilterUriListObjectsPut (ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Edit content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsPut(contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsPutWithHttpInfo(contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

<a id="contentfilterurilistobjectsuuiduuiddelete"></a>
# **ContentFilterUriListObjectsUuidUUIDDelete**
> ApiStatus ContentFilterUriListObjectsUuidUUIDDelete (string UUID)



Delete a content filter URI list object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

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

<a id="contentfilterurilistobjectsuuiduuidget"></a>
# **ContentFilterUriListObjectsUuidUUIDGet**
> ContentFilterUriListObjectCollection ContentFilterUriListObjectsUuidUUIDGet (string UUID)



Retrieve content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ContentFilterUriListObjectCollection result = apiInstance.ContentFilterUriListObjectsUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterUriListObjectCollection> response = apiInstance.ContentFilterUriListObjectsUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**ContentFilterUriListObjectCollection**](ContentFilterUriListObjectCollection.md)

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

<a id="contentfilterurilistobjectsuuiduuidpatch"></a>
# **ContentFilterUriListObjectsUuidUUIDPatch**
> ApiStatus ContentFilterUriListObjectsUuidUUIDPatch (string UUID, ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Patch content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsUuidUUIDPatch(UUID, contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsUuidUUIDPatchWithHttpInfo(UUID, contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

<a id="contentfilterurilistobjectsuuiduuidput"></a>
# **ContentFilterUriListObjectsUuidUUIDPut**
> ApiStatus ContentFilterUriListObjectsUuidUUIDPut (string UUID, ContentFilterUriListObjectCollection? contentFilterUriListObjectCollection = null)



Edit content filter URI list object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterUriListObjectsUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var contentFilterUriListObjectCollection = new ContentFilterUriListObjectCollection?(); // ContentFilterUriListObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterUriListObjectsUuidUUIDPut(UUID, contentFilterUriListObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterUriListObjectsUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterUriListObjectsUuidUUIDPutWithHttpInfo(UUID, contentFilterUriListObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectApi.ContentFilterUriListObjectsUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **contentFilterUriListObjectCollection** | [**ContentFilterUriListObjectCollection?**](ContentFilterUriListObjectCollection?.md) |  | [optional]  |

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

