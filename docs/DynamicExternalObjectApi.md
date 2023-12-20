# SonicWallGen7.Api.DynamicExternalObjectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DynamicExternalObjectsGet**](DynamicExternalObjectApi.md#dynamicexternalobjectsget) | **GET** /dynamic-external-objects |  |
| [**DynamicExternalObjectsNameNAMEDelete**](DynamicExternalObjectApi.md#dynamicexternalobjectsnamenamedelete) | **DELETE** /dynamic-external-objects/name/{NAME} |  |
| [**DynamicExternalObjectsNameNAMEGet**](DynamicExternalObjectApi.md#dynamicexternalobjectsnamenameget) | **GET** /dynamic-external-objects/name/{NAME} |  |
| [**DynamicExternalObjectsNameNAMEPatch**](DynamicExternalObjectApi.md#dynamicexternalobjectsnamenamepatch) | **PATCH** /dynamic-external-objects/name/{NAME} |  |
| [**DynamicExternalObjectsNameNAMEPut**](DynamicExternalObjectApi.md#dynamicexternalobjectsnamenameput) | **PUT** /dynamic-external-objects/name/{NAME} |  |
| [**DynamicExternalObjectsPatch**](DynamicExternalObjectApi.md#dynamicexternalobjectspatch) | **PATCH** /dynamic-external-objects |  |
| [**DynamicExternalObjectsPost**](DynamicExternalObjectApi.md#dynamicexternalobjectspost) | **POST** /dynamic-external-objects |  |
| [**DynamicExternalObjectsPut**](DynamicExternalObjectApi.md#dynamicexternalobjectsput) | **PUT** /dynamic-external-objects |  |

<a id="dynamicexternalobjectsget"></a>
# **DynamicExternalObjectsGet**
> DynamicExternalObjectCollection DynamicExternalObjectsGet ()



Retrieve dynamic external object(s) configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);

            try
            {
                DynamicExternalObjectCollection result = apiInstance.DynamicExternalObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DynamicExternalObjectCollection> response = apiInstance.DynamicExternalObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DynamicExternalObjectCollection**](DynamicExternalObjectCollection.md)

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

<a id="dynamicexternalobjectsnamenamedelete"></a>
# **DynamicExternalObjectsNameNAMEDelete**
> ApiStatus DynamicExternalObjectsNameNAMEDelete (string NAME)



Delete a dynamic external object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.DynamicExternalObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicExternalObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="dynamicexternalobjectsnamenameget"></a>
# **DynamicExternalObjectsNameNAMEGet**
> DynamicExternalObjectCollection DynamicExternalObjectsNameNAMEGet (string NAME)



Retrieve dynamic external object(s) configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                DynamicExternalObjectCollection result = apiInstance.DynamicExternalObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DynamicExternalObjectCollection> response = apiInstance.DynamicExternalObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**DynamicExternalObjectCollection**](DynamicExternalObjectCollection.md)

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

<a id="dynamicexternalobjectsnamenamepatch"></a>
# **DynamicExternalObjectsNameNAMEPatch**
> ApiStatus DynamicExternalObjectsNameNAMEPatch (string NAME, DynamicExternalObjectCollection? dynamicExternalObjectCollection = null)



Patch dynamic external object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var dynamicExternalObjectCollection = new DynamicExternalObjectCollection?(); // DynamicExternalObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicExternalObjectsNameNAMEPatch(NAME, dynamicExternalObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicExternalObjectsNameNAMEPatchWithHttpInfo(NAME, dynamicExternalObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **dynamicExternalObjectCollection** | [**DynamicExternalObjectCollection?**](DynamicExternalObjectCollection?.md) |  | [optional]  |

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

<a id="dynamicexternalobjectsnamenameput"></a>
# **DynamicExternalObjectsNameNAMEPut**
> ApiStatus DynamicExternalObjectsNameNAMEPut (string NAME, DynamicExternalObjectCollection? dynamicExternalObjectCollection = null)



Edit dynamic external object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var dynamicExternalObjectCollection = new DynamicExternalObjectCollection?(); // DynamicExternalObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicExternalObjectsNameNAMEPut(NAME, dynamicExternalObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicExternalObjectsNameNAMEPutWithHttpInfo(NAME, dynamicExternalObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **dynamicExternalObjectCollection** | [**DynamicExternalObjectCollection?**](DynamicExternalObjectCollection?.md) |  | [optional]  |

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

<a id="dynamicexternalobjectspatch"></a>
# **DynamicExternalObjectsPatch**
> ApiStatus DynamicExternalObjectsPatch (DynamicExternalObjectCollection? dynamicExternalObjectCollection = null)



Patch dynamic external object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var dynamicExternalObjectCollection = new DynamicExternalObjectCollection?(); // DynamicExternalObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicExternalObjectsPatch(dynamicExternalObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicExternalObjectsPatchWithHttpInfo(dynamicExternalObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicExternalObjectCollection** | [**DynamicExternalObjectCollection?**](DynamicExternalObjectCollection?.md) |  | [optional]  |

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

<a id="dynamicexternalobjectspost"></a>
# **DynamicExternalObjectsPost**
> ApiStatus DynamicExternalObjectsPost (DynamicExternalObjectCollection? dynamicExternalObjectCollection = null)



Create a new dynamic external object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var dynamicExternalObjectCollection = new DynamicExternalObjectCollection?(); // DynamicExternalObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicExternalObjectsPost(dynamicExternalObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicExternalObjectsPostWithHttpInfo(dynamicExternalObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicExternalObjectCollection** | [**DynamicExternalObjectCollection?**](DynamicExternalObjectCollection?.md) |  | [optional]  |

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

<a id="dynamicexternalobjectsput"></a>
# **DynamicExternalObjectsPut**
> ApiStatus DynamicExternalObjectsPut (DynamicExternalObjectCollection? dynamicExternalObjectCollection = null)



Edit dynamic external object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicExternalObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicExternalObjectApi(config);
            var dynamicExternalObjectCollection = new DynamicExternalObjectCollection?(); // DynamicExternalObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicExternalObjectsPut(dynamicExternalObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicExternalObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicExternalObjectsPutWithHttpInfo(dynamicExternalObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicExternalObjectApi.DynamicExternalObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicExternalObjectCollection** | [**DynamicExternalObjectCollection?**](DynamicExternalObjectCollection?.md) |  | [optional]  |

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

