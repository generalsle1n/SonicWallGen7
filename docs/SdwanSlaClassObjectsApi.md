# SonicWallGen7.Api.SdwanSlaClassObjectsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SdwanSlaClassObjectsGet**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectsget) | **GET** /sdwan/sla-class-objects |  |
| [**SdwanSlaClassObjectsNameNAMEDelete**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectsnamenamedelete) | **DELETE** /sdwan/sla-class-objects/name/{NAME} |  |
| [**SdwanSlaClassObjectsNameNAMEGet**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectsnamenameget) | **GET** /sdwan/sla-class-objects/name/{NAME} |  |
| [**SdwanSlaClassObjectsNameNAMEPatch**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectsnamenamepatch) | **PATCH** /sdwan/sla-class-objects/name/{NAME} |  |
| [**SdwanSlaClassObjectsNameNAMEPut**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectsnamenameput) | **PUT** /sdwan/sla-class-objects/name/{NAME} |  |
| [**SdwanSlaClassObjectsPatch**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectspatch) | **PATCH** /sdwan/sla-class-objects |  |
| [**SdwanSlaClassObjectsPost**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectspost) | **POST** /sdwan/sla-class-objects |  |
| [**SdwanSlaClassObjectsPut**](SdwanSlaClassObjectsApi.md#sdwanslaclassobjectsput) | **PUT** /sdwan/sla-class-objects |  |

<a id="sdwanslaclassobjectsget"></a>
# **SdwanSlaClassObjectsGet**
> SdwanSlaClassObjectsCollection SdwanSlaClassObjectsGet ()



Retrieve SD-WAN SLA class object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);

            try
            {
                SdwanSlaClassObjectsCollection result = apiInstance.SdwanSlaClassObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SdwanSlaClassObjectsCollection> response = apiInstance.SdwanSlaClassObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SdwanSlaClassObjectsCollection**](SdwanSlaClassObjectsCollection.md)

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

<a id="sdwanslaclassobjectsnamenamedelete"></a>
# **SdwanSlaClassObjectsNameNAMEDelete**
> ApiStatus SdwanSlaClassObjectsNameNAMEDelete (string NAME)



Delete a SD-WAN SLA class object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var NAME = "\"Lowest Jitter\"";  // string | Atom Object name. (default to "Lowest Jitter")

            try
            {
                ApiStatus result = apiInstance.SdwanSlaClassObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaClassObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Lowest Jitter&quot;] |

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

<a id="sdwanslaclassobjectsnamenameget"></a>
# **SdwanSlaClassObjectsNameNAMEGet**
> SdwanSlaClassObjectsCollection SdwanSlaClassObjectsNameNAMEGet (string NAME)



Retrieve SD-WAN SLA class object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var NAME = "\"Lowest Jitter\"";  // string | Atom Object name. (default to "Lowest Jitter")

            try
            {
                SdwanSlaClassObjectsCollection result = apiInstance.SdwanSlaClassObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SdwanSlaClassObjectsCollection> response = apiInstance.SdwanSlaClassObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Lowest Jitter&quot;] |

### Return type

[**SdwanSlaClassObjectsCollection**](SdwanSlaClassObjectsCollection.md)

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

<a id="sdwanslaclassobjectsnamenamepatch"></a>
# **SdwanSlaClassObjectsNameNAMEPatch**
> ApiStatus SdwanSlaClassObjectsNameNAMEPatch (string NAME, SdwanSlaClassObjectsCollection? sdwanSlaClassObjectsCollection = null)



Patch an SD-WAN SLA class object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var NAME = "\"Lowest Jitter\"";  // string | Atom Object name. (default to "Lowest Jitter")
            var sdwanSlaClassObjectsCollection = new SdwanSlaClassObjectsCollection?(); // SdwanSlaClassObjectsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaClassObjectsNameNAMEPatch(NAME, sdwanSlaClassObjectsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaClassObjectsNameNAMEPatchWithHttpInfo(NAME, sdwanSlaClassObjectsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Lowest Jitter&quot;] |
| **sdwanSlaClassObjectsCollection** | [**SdwanSlaClassObjectsCollection?**](SdwanSlaClassObjectsCollection?.md) |  | [optional]  |

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

<a id="sdwanslaclassobjectsnamenameput"></a>
# **SdwanSlaClassObjectsNameNAMEPut**
> ApiStatus SdwanSlaClassObjectsNameNAMEPut (string NAME, SdwanSlaClassObjectsCollection? sdwanSlaClassObjectsCollection = null)



Update an SD-WAN SLA class object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var NAME = "\"Lowest Jitter\"";  // string | Atom Object name. (default to "Lowest Jitter")
            var sdwanSlaClassObjectsCollection = new SdwanSlaClassObjectsCollection?(); // SdwanSlaClassObjectsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaClassObjectsNameNAMEPut(NAME, sdwanSlaClassObjectsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaClassObjectsNameNAMEPutWithHttpInfo(NAME, sdwanSlaClassObjectsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Lowest Jitter&quot;] |
| **sdwanSlaClassObjectsCollection** | [**SdwanSlaClassObjectsCollection?**](SdwanSlaClassObjectsCollection?.md) |  | [optional]  |

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

<a id="sdwanslaclassobjectspatch"></a>
# **SdwanSlaClassObjectsPatch**
> ApiStatus SdwanSlaClassObjectsPatch (SdwanSlaClassObjectsCollection? sdwanSlaClassObjectsCollection = null)



Patch an SD-WAN SLA class object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var sdwanSlaClassObjectsCollection = new SdwanSlaClassObjectsCollection?(); // SdwanSlaClassObjectsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaClassObjectsPatch(sdwanSlaClassObjectsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaClassObjectsPatchWithHttpInfo(sdwanSlaClassObjectsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanSlaClassObjectsCollection** | [**SdwanSlaClassObjectsCollection?**](SdwanSlaClassObjectsCollection?.md) |  | [optional]  |

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

<a id="sdwanslaclassobjectspost"></a>
# **SdwanSlaClassObjectsPost**
> ApiStatus SdwanSlaClassObjectsPost (SdwanSlaClassObjectsCollection? sdwanSlaClassObjectsCollection = null)



Create a new SD-WAN SLA class object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var sdwanSlaClassObjectsCollection = new SdwanSlaClassObjectsCollection?(); // SdwanSlaClassObjectsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaClassObjectsPost(sdwanSlaClassObjectsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaClassObjectsPostWithHttpInfo(sdwanSlaClassObjectsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanSlaClassObjectsCollection** | [**SdwanSlaClassObjectsCollection?**](SdwanSlaClassObjectsCollection?.md) |  | [optional]  |

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

<a id="sdwanslaclassobjectsput"></a>
# **SdwanSlaClassObjectsPut**
> ApiStatus SdwanSlaClassObjectsPut (SdwanSlaClassObjectsCollection? sdwanSlaClassObjectsCollection = null)



Update an SD-WAN SLA class object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaClassObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaClassObjectsApi(config);
            var sdwanSlaClassObjectsCollection = new SdwanSlaClassObjectsCollection?(); // SdwanSlaClassObjectsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaClassObjectsPut(sdwanSlaClassObjectsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaClassObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaClassObjectsPutWithHttpInfo(sdwanSlaClassObjectsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaClassObjectsApi.SdwanSlaClassObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanSlaClassObjectsCollection** | [**SdwanSlaClassObjectsCollection?**](SdwanSlaClassObjectsCollection?.md) |  | [optional]  |

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

