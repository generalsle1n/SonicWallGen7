# SonicWallGen7.Api.SdwanPathSelectionProfilesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SdwanPathSelectionProfilesGet**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilesget) | **GET** /sdwan/path-selection-profiles |  |
| [**SdwanPathSelectionProfilesNameNAMEDelete**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilesnamenamedelete) | **DELETE** /sdwan/path-selection-profiles/name/{NAME} |  |
| [**SdwanPathSelectionProfilesNameNAMEGet**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilesnamenameget) | **GET** /sdwan/path-selection-profiles/name/{NAME} |  |
| [**SdwanPathSelectionProfilesNameNAMEPatch**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilesnamenamepatch) | **PATCH** /sdwan/path-selection-profiles/name/{NAME} |  |
| [**SdwanPathSelectionProfilesNameNAMEPut**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilesnamenameput) | **PUT** /sdwan/path-selection-profiles/name/{NAME} |  |
| [**SdwanPathSelectionProfilesPatch**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilespatch) | **PATCH** /sdwan/path-selection-profiles |  |
| [**SdwanPathSelectionProfilesPost**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilespost) | **POST** /sdwan/path-selection-profiles |  |
| [**SdwanPathSelectionProfilesPut**](SdwanPathSelectionProfilesApi.md#sdwanpathselectionprofilesput) | **PUT** /sdwan/path-selection-profiles |  |

<a id="sdwanpathselectionprofilesget"></a>
# **SdwanPathSelectionProfilesGet**
> SdwanPathSelectionProfilesCollection SdwanPathSelectionProfilesGet ()



Retrieve SD-WAN path selection profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);

            try
            {
                SdwanPathSelectionProfilesCollection result = apiInstance.SdwanPathSelectionProfilesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SdwanPathSelectionProfilesCollection> response = apiInstance.SdwanPathSelectionProfilesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SdwanPathSelectionProfilesCollection**](SdwanPathSelectionProfilesCollection.md)

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

<a id="sdwanpathselectionprofilesnamenamedelete"></a>
# **SdwanPathSelectionProfilesNameNAMEDelete**
> ApiStatus SdwanPathSelectionProfilesNameNAMEDelete (string NAME)



Delete SD-WAN path selection profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.SdwanPathSelectionProfilesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanPathSelectionProfilesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="sdwanpathselectionprofilesnamenameget"></a>
# **SdwanPathSelectionProfilesNameNAMEGet**
> SdwanPathSelectionProfilesCollection SdwanPathSelectionProfilesNameNAMEGet (string NAME)



Retrieve SD-WAN path selection profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                SdwanPathSelectionProfilesCollection result = apiInstance.SdwanPathSelectionProfilesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SdwanPathSelectionProfilesCollection> response = apiInstance.SdwanPathSelectionProfilesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**SdwanPathSelectionProfilesCollection**](SdwanPathSelectionProfilesCollection.md)

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

<a id="sdwanpathselectionprofilesnamenamepatch"></a>
# **SdwanPathSelectionProfilesNameNAMEPatch**
> ApiStatus SdwanPathSelectionProfilesNameNAMEPatch (string NAME, SdwanPathSelectionProfilesCollection? sdwanPathSelectionProfilesCollection = null)



Patch SD-WAN path selection profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var sdwanPathSelectionProfilesCollection = new SdwanPathSelectionProfilesCollection?(); // SdwanPathSelectionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanPathSelectionProfilesNameNAMEPatch(NAME, sdwanPathSelectionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanPathSelectionProfilesNameNAMEPatchWithHttpInfo(NAME, sdwanPathSelectionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **sdwanPathSelectionProfilesCollection** | [**SdwanPathSelectionProfilesCollection?**](SdwanPathSelectionProfilesCollection?.md) |  | [optional]  |

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

<a id="sdwanpathselectionprofilesnamenameput"></a>
# **SdwanPathSelectionProfilesNameNAMEPut**
> ApiStatus SdwanPathSelectionProfilesNameNAMEPut (string NAME, SdwanPathSelectionProfilesCollection? sdwanPathSelectionProfilesCollection = null)



Update SD-WAN path selection profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var sdwanPathSelectionProfilesCollection = new SdwanPathSelectionProfilesCollection?(); // SdwanPathSelectionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanPathSelectionProfilesNameNAMEPut(NAME, sdwanPathSelectionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanPathSelectionProfilesNameNAMEPutWithHttpInfo(NAME, sdwanPathSelectionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **sdwanPathSelectionProfilesCollection** | [**SdwanPathSelectionProfilesCollection?**](SdwanPathSelectionProfilesCollection?.md) |  | [optional]  |

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

<a id="sdwanpathselectionprofilespatch"></a>
# **SdwanPathSelectionProfilesPatch**
> ApiStatus SdwanPathSelectionProfilesPatch (SdwanPathSelectionProfilesCollection? sdwanPathSelectionProfilesCollection = null)



Patch SD-WAN path selection profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var sdwanPathSelectionProfilesCollection = new SdwanPathSelectionProfilesCollection?(); // SdwanPathSelectionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanPathSelectionProfilesPatch(sdwanPathSelectionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanPathSelectionProfilesPatchWithHttpInfo(sdwanPathSelectionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanPathSelectionProfilesCollection** | [**SdwanPathSelectionProfilesCollection?**](SdwanPathSelectionProfilesCollection?.md) |  | [optional]  |

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

<a id="sdwanpathselectionprofilespost"></a>
# **SdwanPathSelectionProfilesPost**
> ApiStatus SdwanPathSelectionProfilesPost (SdwanPathSelectionProfilesCollection? sdwanPathSelectionProfilesCollection = null)



create SD-WAN path selection profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var sdwanPathSelectionProfilesCollection = new SdwanPathSelectionProfilesCollection?(); // SdwanPathSelectionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanPathSelectionProfilesPost(sdwanPathSelectionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanPathSelectionProfilesPostWithHttpInfo(sdwanPathSelectionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanPathSelectionProfilesCollection** | [**SdwanPathSelectionProfilesCollection?**](SdwanPathSelectionProfilesCollection?.md) |  | [optional]  |

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

<a id="sdwanpathselectionprofilesput"></a>
# **SdwanPathSelectionProfilesPut**
> ApiStatus SdwanPathSelectionProfilesPut (SdwanPathSelectionProfilesCollection? sdwanPathSelectionProfilesCollection = null)



Update SD-WAN path selection profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanPathSelectionProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanPathSelectionProfilesApi(config);
            var sdwanPathSelectionProfilesCollection = new SdwanPathSelectionProfilesCollection?(); // SdwanPathSelectionProfilesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanPathSelectionProfilesPut(sdwanPathSelectionProfilesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanPathSelectionProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanPathSelectionProfilesPutWithHttpInfo(sdwanPathSelectionProfilesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanPathSelectionProfilesApi.SdwanPathSelectionProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanPathSelectionProfilesCollection** | [**SdwanPathSelectionProfilesCollection?**](SdwanPathSelectionProfilesCollection?.md) |  | [optional]  |

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

