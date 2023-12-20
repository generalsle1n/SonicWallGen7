# SonicWallGen7.Api.WebsiteGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebsiteGroupsGet**](WebsiteGroupApi.md#websitegroupsget) | **GET** /website-groups |  |
| [**WebsiteGroupsNameNAMEDelete**](WebsiteGroupApi.md#websitegroupsnamenamedelete) | **DELETE** /website-groups/name/{NAME} |  |
| [**WebsiteGroupsNameNAMEGet**](WebsiteGroupApi.md#websitegroupsnamenameget) | **GET** /website-groups/name/{NAME} |  |
| [**WebsiteGroupsNameNAMEPatch**](WebsiteGroupApi.md#websitegroupsnamenamepatch) | **PATCH** /website-groups/name/{NAME} |  |
| [**WebsiteGroupsNameNAMEPut**](WebsiteGroupApi.md#websitegroupsnamenameput) | **PUT** /website-groups/name/{NAME} |  |
| [**WebsiteGroupsPatch**](WebsiteGroupApi.md#websitegroupspatch) | **PATCH** /website-groups |  |
| [**WebsiteGroupsPost**](WebsiteGroupApi.md#websitegroupspost) | **POST** /website-groups |  |
| [**WebsiteGroupsPut**](WebsiteGroupApi.md#websitegroupsput) | **PUT** /website-groups |  |
| [**WebsiteGroupsUuidUUIDDelete**](WebsiteGroupApi.md#websitegroupsuuiduuiddelete) | **DELETE** /website-groups/uuid/{UUID} |  |
| [**WebsiteGroupsUuidUUIDGet**](WebsiteGroupApi.md#websitegroupsuuiduuidget) | **GET** /website-groups/uuid/{UUID} |  |
| [**WebsiteGroupsUuidUUIDPatch**](WebsiteGroupApi.md#websitegroupsuuiduuidpatch) | **PATCH** /website-groups/uuid/{UUID} |  |
| [**WebsiteGroupsUuidUUIDPut**](WebsiteGroupApi.md#websitegroupsuuiduuidput) | **PUT** /website-groups/uuid/{UUID} |  |

<a id="websitegroupsget"></a>
# **WebsiteGroupsGet**
> WebsiteGroupCollection WebsiteGroupsGet ()



Retrieve website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);

            try
            {
                WebsiteGroupCollection result = apiInstance.WebsiteGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebsiteGroupCollection> response = apiInstance.WebsiteGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WebsiteGroupCollection**](WebsiteGroupCollection.md)

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

<a id="websitegroupsnamenamedelete"></a>
# **WebsiteGroupsNameNAMEDelete**
> ApiStatus WebsiteGroupsNameNAMEDelete (string NAME)



Delete a website group object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var NAME = "\"Website domain group\"";  // string | Website group name. (default to "Website domain group")

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Website group name. | [default to &quot;Website domain group&quot;] |

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

<a id="websitegroupsnamenameget"></a>
# **WebsiteGroupsNameNAMEGet**
> WebsiteGroupCollection WebsiteGroupsNameNAMEGet (string NAME)



Retrieve website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var NAME = "\"Website domain group\"";  // string | Website group name. (default to "Website domain group")

            try
            {
                WebsiteGroupCollection result = apiInstance.WebsiteGroupsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebsiteGroupCollection> response = apiInstance.WebsiteGroupsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Website group name. | [default to &quot;Website domain group&quot;] |

### Return type

[**WebsiteGroupCollection**](WebsiteGroupCollection.md)

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

<a id="websitegroupsnamenamepatch"></a>
# **WebsiteGroupsNameNAMEPatch**
> ApiStatus WebsiteGroupsNameNAMEPatch (string NAME, WebsiteGroupCollection? websiteGroupCollection = null)



Patch website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var NAME = "\"Website domain group\"";  // string | Website group name. (default to "Website domain group")
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsNameNAMEPatch(NAME, websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsNameNAMEPatchWithHttpInfo(NAME, websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Website group name. | [default to &quot;Website domain group&quot;] |
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

<a id="websitegroupsnamenameput"></a>
# **WebsiteGroupsNameNAMEPut**
> ApiStatus WebsiteGroupsNameNAMEPut (string NAME, WebsiteGroupCollection? websiteGroupCollection = null)



Edit website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var NAME = "\"Website domain group\"";  // string | Website group name. (default to "Website domain group")
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsNameNAMEPut(NAME, websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsNameNAMEPutWithHttpInfo(NAME, websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Website group name. | [default to &quot;Website domain group&quot;] |
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

<a id="websitegroupspatch"></a>
# **WebsiteGroupsPatch**
> ApiStatus WebsiteGroupsPatch (WebsiteGroupCollection? websiteGroupCollection = null)



Patch website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsPatch(websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsPatchWithHttpInfo(websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

<a id="websitegroupspost"></a>
# **WebsiteGroupsPost**
> ApiStatus WebsiteGroupsPost (WebsiteGroupCollection? websiteGroupCollection = null)



Create a new website group object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsPost(websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsPostWithHttpInfo(websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

<a id="websitegroupsput"></a>
# **WebsiteGroupsPut**
> ApiStatus WebsiteGroupsPut (WebsiteGroupCollection? websiteGroupCollection = null)



Edit website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsPut(websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsPutWithHttpInfo(websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

<a id="websitegroupsuuiduuiddelete"></a>
# **WebsiteGroupsUuidUUIDDelete**
> ApiStatus WebsiteGroupsUuidUUIDDelete (string UUID)



Delete a website group object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="websitegroupsuuiduuidget"></a>
# **WebsiteGroupsUuidUUIDGet**
> WebsiteGroupCollection WebsiteGroupsUuidUUIDGet (string UUID)



Retrieve website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                WebsiteGroupCollection result = apiInstance.WebsiteGroupsUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebsiteGroupCollection> response = apiInstance.WebsiteGroupsUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**WebsiteGroupCollection**](WebsiteGroupCollection.md)

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

<a id="websitegroupsuuiduuidpatch"></a>
# **WebsiteGroupsUuidUUIDPatch**
> ApiStatus WebsiteGroupsUuidUUIDPatch (string UUID, WebsiteGroupCollection? websiteGroupCollection = null)



Patch website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsUuidUUIDPatch(UUID, websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsUuidUUIDPatchWithHttpInfo(UUID, websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

<a id="websitegroupsuuiduuidput"></a>
# **WebsiteGroupsUuidUUIDPut**
> ApiStatus WebsiteGroupsUuidUUIDPut (string UUID, WebsiteGroupCollection? websiteGroupCollection = null)



Edit website group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class WebsiteGroupsUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebsiteGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var websiteGroupCollection = new WebsiteGroupCollection?(); // WebsiteGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.WebsiteGroupsUuidUUIDPut(UUID, websiteGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebsiteGroupsUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.WebsiteGroupsUuidUUIDPutWithHttpInfo(UUID, websiteGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebsiteGroupApi.WebsiteGroupsUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **websiteGroupCollection** | [**WebsiteGroupCollection?**](WebsiteGroupCollection?.md) |  | [optional]  |

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

