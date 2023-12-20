# SonicWallGen7.Api.ContentFilterCfsPolicyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContentFilterCfsPoliciesGet**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesget) | **GET** /content-filter/cfs/policies |  |
| [**ContentFilterCfsPoliciesNameNAMEDelete**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesnamenamedelete) | **DELETE** /content-filter/cfs/policies/name/{NAME} |  |
| [**ContentFilterCfsPoliciesNameNAMEGet**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesnamenameget) | **GET** /content-filter/cfs/policies/name/{NAME} |  |
| [**ContentFilterCfsPoliciesNameNAMEPatch**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesnamenamepatch) | **PATCH** /content-filter/cfs/policies/name/{NAME} |  |
| [**ContentFilterCfsPoliciesNameNAMEPut**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesnamenameput) | **PUT** /content-filter/cfs/policies/name/{NAME} |  |
| [**ContentFilterCfsPoliciesPatch**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciespatch) | **PATCH** /content-filter/cfs/policies |  |
| [**ContentFilterCfsPoliciesPost**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciespost) | **POST** /content-filter/cfs/policies |  |
| [**ContentFilterCfsPoliciesPut**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesput) | **PUT** /content-filter/cfs/policies |  |
| [**ContentFilterCfsPoliciesUuidUUIDDelete**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesuuiduuiddelete) | **DELETE** /content-filter/cfs/policies/uuid/{UUID} |  |
| [**ContentFilterCfsPoliciesUuidUUIDGet**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesuuiduuidget) | **GET** /content-filter/cfs/policies/uuid/{UUID} |  |
| [**ContentFilterCfsPoliciesUuidUUIDPatch**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesuuiduuidpatch) | **PATCH** /content-filter/cfs/policies/uuid/{UUID} |  |
| [**ContentFilterCfsPoliciesUuidUUIDPut**](ContentFilterCfsPolicyApi.md#contentfiltercfspoliciesuuiduuidput) | **PUT** /content-filter/cfs/policies/uuid/{UUID} |  |

<a id="contentfiltercfspoliciesget"></a>
# **ContentFilterCfsPoliciesGet**
> ContentFilterCfsPolicyCollection ContentFilterCfsPoliciesGet ()



Retrieve content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);

            try
            {
                ContentFilterCfsPolicyCollection result = apiInstance.ContentFilterCfsPoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterCfsPolicyCollection> response = apiInstance.ContentFilterCfsPoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ContentFilterCfsPolicyCollection**](ContentFilterCfsPolicyCollection.md)

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

<a id="contentfiltercfspoliciesnamenamedelete"></a>
# **ContentFilterCfsPoliciesNameNAMEDelete**
> ApiStatus ContentFilterCfsPoliciesNameNAMEDelete (string NAME)



Delete a content filter cfs policy object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | CFS policy name. (default to "Market policy")

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS policy name. | [default to &quot;Market policy&quot;] |

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

<a id="contentfiltercfspoliciesnamenameget"></a>
# **ContentFilterCfsPoliciesNameNAMEGet**
> ContentFilterCfsPolicyCollection ContentFilterCfsPoliciesNameNAMEGet (string NAME)



Retrieve content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | CFS policy name. (default to "Market policy")

            try
            {
                ContentFilterCfsPolicyCollection result = apiInstance.ContentFilterCfsPoliciesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterCfsPolicyCollection> response = apiInstance.ContentFilterCfsPoliciesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS policy name. | [default to &quot;Market policy&quot;] |

### Return type

[**ContentFilterCfsPolicyCollection**](ContentFilterCfsPolicyCollection.md)

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

<a id="contentfiltercfspoliciesnamenamepatch"></a>
# **ContentFilterCfsPoliciesNameNAMEPatch**
> ApiStatus ContentFilterCfsPoliciesNameNAMEPatch (string NAME, ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Patch content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | CFS policy name. (default to "Market policy")
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesNameNAMEPatch(NAME, contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesNameNAMEPatchWithHttpInfo(NAME, contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS policy name. | [default to &quot;Market policy&quot;] |
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfspoliciesnamenameput"></a>
# **ContentFilterCfsPoliciesNameNAMEPut**
> ApiStatus ContentFilterCfsPoliciesNameNAMEPut (string NAME, ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Edit content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | CFS policy name. (default to "Market policy")
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesNameNAMEPut(NAME, contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesNameNAMEPutWithHttpInfo(NAME, contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | CFS policy name. | [default to &quot;Market policy&quot;] |
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfspoliciespatch"></a>
# **ContentFilterCfsPoliciesPatch**
> ApiStatus ContentFilterCfsPoliciesPatch (ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Patch content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesPatch(contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesPatchWithHttpInfo(contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfspoliciespost"></a>
# **ContentFilterCfsPoliciesPost**
> ApiStatus ContentFilterCfsPoliciesPost (ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Create a new content filter cfs policy object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesPost(contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesPostWithHttpInfo(contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfspoliciesput"></a>
# **ContentFilterCfsPoliciesPut**
> ApiStatus ContentFilterCfsPoliciesPut (ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Edit content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesPut(contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesPutWithHttpInfo(contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfspoliciesuuiduuiddelete"></a>
# **ContentFilterCfsPoliciesUuidUUIDDelete**
> ApiStatus ContentFilterCfsPoliciesUuidUUIDDelete (string UUID)



Delete a content filter cfs policy object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="contentfiltercfspoliciesuuiduuidget"></a>
# **ContentFilterCfsPoliciesUuidUUIDGet**
> ContentFilterCfsPolicyCollection ContentFilterCfsPoliciesUuidUUIDGet (string UUID)



Retrieve content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ContentFilterCfsPolicyCollection result = apiInstance.ContentFilterCfsPoliciesUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentFilterCfsPolicyCollection> response = apiInstance.ContentFilterCfsPoliciesUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**ContentFilterCfsPolicyCollection**](ContentFilterCfsPolicyCollection.md)

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

<a id="contentfiltercfspoliciesuuiduuidpatch"></a>
# **ContentFilterCfsPoliciesUuidUUIDPatch**
> ApiStatus ContentFilterCfsPoliciesUuidUUIDPatch (string UUID, ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Patch content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesUuidUUIDPatch(UUID, contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesUuidUUIDPatchWithHttpInfo(UUID, contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

<a id="contentfiltercfspoliciesuuiduuidput"></a>
# **ContentFilterCfsPoliciesUuidUUIDPut**
> ApiStatus ContentFilterCfsPoliciesUuidUUIDPut (string UUID, ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null)



Edit content filter cfs policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ContentFilterCfsPoliciesUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterCfsPolicyApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var contentFilterCfsPolicyCollection = new ContentFilterCfsPolicyCollection?(); // ContentFilterCfsPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ContentFilterCfsPoliciesUuidUUIDPut(UUID, contentFilterCfsPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentFilterCfsPoliciesUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ContentFilterCfsPoliciesUuidUUIDPutWithHttpInfo(UUID, contentFilterCfsPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterCfsPolicyApi.ContentFilterCfsPoliciesUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **contentFilterCfsPolicyCollection** | [**ContentFilterCfsPolicyCollection?**](ContentFilterCfsPolicyCollection?.md) |  | [optional]  |

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

