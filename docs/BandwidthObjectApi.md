# SonicWallGen7.Api.BandwidthObjectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BandwidthObjectsGet**](BandwidthObjectApi.md#bandwidthobjectsget) | **GET** /bandwidth-objects |  |
| [**BandwidthObjectsNameNAMEDelete**](BandwidthObjectApi.md#bandwidthobjectsnamenamedelete) | **DELETE** /bandwidth-objects/name/{NAME} |  |
| [**BandwidthObjectsNameNAMEGet**](BandwidthObjectApi.md#bandwidthobjectsnamenameget) | **GET** /bandwidth-objects/name/{NAME} |  |
| [**BandwidthObjectsNameNAMEPatch**](BandwidthObjectApi.md#bandwidthobjectsnamenamepatch) | **PATCH** /bandwidth-objects/name/{NAME} |  |
| [**BandwidthObjectsNameNAMEPut**](BandwidthObjectApi.md#bandwidthobjectsnamenameput) | **PUT** /bandwidth-objects/name/{NAME} |  |
| [**BandwidthObjectsPatch**](BandwidthObjectApi.md#bandwidthobjectspatch) | **PATCH** /bandwidth-objects |  |
| [**BandwidthObjectsPost**](BandwidthObjectApi.md#bandwidthobjectspost) | **POST** /bandwidth-objects |  |
| [**BandwidthObjectsPut**](BandwidthObjectApi.md#bandwidthobjectsput) | **PUT** /bandwidth-objects |  |

<a id="bandwidthobjectsget"></a>
# **BandwidthObjectsGet**
> BandwidthObjectCollection BandwidthObjectsGet ()



Retrieve bandwidth object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);

            try
            {
                BandwidthObjectCollection result = apiInstance.BandwidthObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BandwidthObjectCollection> response = apiInstance.BandwidthObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**BandwidthObjectCollection**](BandwidthObjectCollection.md)

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

<a id="bandwidthobjectsnamenamedelete"></a>
# **BandwidthObjectsNameNAMEDelete**
> ApiStatus BandwidthObjectsNameNAMEDelete (string NAME)



Delete a bandwidth object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var NAME = "\"\"Corp High Priority\"\"";  // string | Bandwidth object name (default to ""Corp High Priority"")

            try
            {
                ApiStatus result = apiInstance.BandwidthObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BandwidthObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Bandwidth object name | [default to &quot;&quot;Corp High Priority&quot;&quot;] |

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

<a id="bandwidthobjectsnamenameget"></a>
# **BandwidthObjectsNameNAMEGet**
> BandwidthObjectCollection BandwidthObjectsNameNAMEGet (string NAME)



Retrieve bandwidth object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var NAME = "\"\"Corp High Priority\"\"";  // string | Bandwidth object name (default to ""Corp High Priority"")

            try
            {
                BandwidthObjectCollection result = apiInstance.BandwidthObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BandwidthObjectCollection> response = apiInstance.BandwidthObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Bandwidth object name | [default to &quot;&quot;Corp High Priority&quot;&quot;] |

### Return type

[**BandwidthObjectCollection**](BandwidthObjectCollection.md)

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

<a id="bandwidthobjectsnamenamepatch"></a>
# **BandwidthObjectsNameNAMEPatch**
> ApiStatus BandwidthObjectsNameNAMEPatch (string NAME, BandwidthObjectCollection? bandwidthObjectCollection = null)



Patch bandwidth object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var NAME = "\"\"Corp High Priority\"\"";  // string | Bandwidth object name (default to ""Corp High Priority"")
            var bandwidthObjectCollection = new BandwidthObjectCollection?(); // BandwidthObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BandwidthObjectsNameNAMEPatch(NAME, bandwidthObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BandwidthObjectsNameNAMEPatchWithHttpInfo(NAME, bandwidthObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Bandwidth object name | [default to &quot;&quot;Corp High Priority&quot;&quot;] |
| **bandwidthObjectCollection** | [**BandwidthObjectCollection?**](BandwidthObjectCollection?.md) |  | [optional]  |

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

<a id="bandwidthobjectsnamenameput"></a>
# **BandwidthObjectsNameNAMEPut**
> ApiStatus BandwidthObjectsNameNAMEPut (string NAME, BandwidthObjectCollection? bandwidthObjectCollection = null)



Edit bandwidth object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var NAME = "\"\"Corp High Priority\"\"";  // string | Bandwidth object name (default to ""Corp High Priority"")
            var bandwidthObjectCollection = new BandwidthObjectCollection?(); // BandwidthObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BandwidthObjectsNameNAMEPut(NAME, bandwidthObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BandwidthObjectsNameNAMEPutWithHttpInfo(NAME, bandwidthObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Bandwidth object name | [default to &quot;&quot;Corp High Priority&quot;&quot;] |
| **bandwidthObjectCollection** | [**BandwidthObjectCollection?**](BandwidthObjectCollection?.md) |  | [optional]  |

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

<a id="bandwidthobjectspatch"></a>
# **BandwidthObjectsPatch**
> ApiStatus BandwidthObjectsPatch (BandwidthObjectCollection? bandwidthObjectCollection = null)



Patch bandwidth object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var bandwidthObjectCollection = new BandwidthObjectCollection?(); // BandwidthObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BandwidthObjectsPatch(bandwidthObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BandwidthObjectsPatchWithHttpInfo(bandwidthObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bandwidthObjectCollection** | [**BandwidthObjectCollection?**](BandwidthObjectCollection?.md) |  | [optional]  |

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

<a id="bandwidthobjectspost"></a>
# **BandwidthObjectsPost**
> ApiStatus BandwidthObjectsPost (BandwidthObjectCollection? bandwidthObjectCollection = null)



Create a new bandwidth object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var bandwidthObjectCollection = new BandwidthObjectCollection?(); // BandwidthObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BandwidthObjectsPost(bandwidthObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BandwidthObjectsPostWithHttpInfo(bandwidthObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bandwidthObjectCollection** | [**BandwidthObjectCollection?**](BandwidthObjectCollection?.md) |  | [optional]  |

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

<a id="bandwidthobjectsput"></a>
# **BandwidthObjectsPut**
> ApiStatus BandwidthObjectsPut (BandwidthObjectCollection? bandwidthObjectCollection = null)



Edit bandwidth object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BandwidthObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BandwidthObjectApi(config);
            var bandwidthObjectCollection = new BandwidthObjectCollection?(); // BandwidthObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BandwidthObjectsPut(bandwidthObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BandwidthObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BandwidthObjectsPutWithHttpInfo(bandwidthObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BandwidthObjectApi.BandwidthObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bandwidthObjectCollection** | [**BandwidthObjectCollection?**](BandwidthObjectCollection?.md) |  | [optional]  |

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

