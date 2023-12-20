# SonicWallGen7.Api.ThreatPreventionProfileApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ThreatPreventionProfilesGet**](ThreatPreventionProfileApi.md#threatpreventionprofilesget) | **GET** /threat-prevention-profiles |  |
| [**ThreatPreventionProfilesNameNAMEDelete**](ThreatPreventionProfileApi.md#threatpreventionprofilesnamenamedelete) | **DELETE** /threat-prevention-profiles/name/{NAME} |  |
| [**ThreatPreventionProfilesNameNAMEGet**](ThreatPreventionProfileApi.md#threatpreventionprofilesnamenameget) | **GET** /threat-prevention-profiles/name/{NAME} |  |
| [**ThreatPreventionProfilesNameNAMEPatch**](ThreatPreventionProfileApi.md#threatpreventionprofilesnamenamepatch) | **PATCH** /threat-prevention-profiles/name/{NAME} |  |
| [**ThreatPreventionProfilesNameNAMEPut**](ThreatPreventionProfileApi.md#threatpreventionprofilesnamenameput) | **PUT** /threat-prevention-profiles/name/{NAME} |  |
| [**ThreatPreventionProfilesPatch**](ThreatPreventionProfileApi.md#threatpreventionprofilespatch) | **PATCH** /threat-prevention-profiles |  |
| [**ThreatPreventionProfilesPost**](ThreatPreventionProfileApi.md#threatpreventionprofilespost) | **POST** /threat-prevention-profiles |  |
| [**ThreatPreventionProfilesPut**](ThreatPreventionProfileApi.md#threatpreventionprofilesput) | **PUT** /threat-prevention-profiles |  |
| [**ThreatPreventionProfilesUuidUUIDDelete**](ThreatPreventionProfileApi.md#threatpreventionprofilesuuiduuiddelete) | **DELETE** /threat-prevention-profiles/uuid/{UUID} |  |
| [**ThreatPreventionProfilesUuidUUIDGet**](ThreatPreventionProfileApi.md#threatpreventionprofilesuuiduuidget) | **GET** /threat-prevention-profiles/uuid/{UUID} |  |
| [**ThreatPreventionProfilesUuidUUIDPatch**](ThreatPreventionProfileApi.md#threatpreventionprofilesuuiduuidpatch) | **PATCH** /threat-prevention-profiles/uuid/{UUID} |  |
| [**ThreatPreventionProfilesUuidUUIDPut**](ThreatPreventionProfileApi.md#threatpreventionprofilesuuiduuidput) | **PUT** /threat-prevention-profiles/uuid/{UUID} |  |

<a id="threatpreventionprofilesget"></a>
# **ThreatPreventionProfilesGet**
> ThreatPreventionProfileCollection ThreatPreventionProfilesGet ()



Retrieve threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);

            try
            {
                ThreatPreventionProfileCollection result = apiInstance.ThreatPreventionProfilesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ThreatPreventionProfileCollection> response = apiInstance.ThreatPreventionProfilesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ThreatPreventionProfileCollection**](ThreatPreventionProfileCollection.md)

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

<a id="threatpreventionprofilesnamenamedelete"></a>
# **ThreatPreventionProfilesNameNAMEDelete**
> ApiStatus ThreatPreventionProfilesNameNAMEDelete (string NAME)



Delete a threat prevention profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var NAME = "\"DNS Category Profile\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "DNS Category Profile")

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;DNS Category Profile&quot;] |

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

<a id="threatpreventionprofilesnamenameget"></a>
# **ThreatPreventionProfilesNameNAMEGet**
> ThreatPreventionProfileCollection ThreatPreventionProfilesNameNAMEGet (string NAME)



Retrieve threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var NAME = "\"DNS Category Profile\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "DNS Category Profile")

            try
            {
                ThreatPreventionProfileCollection result = apiInstance.ThreatPreventionProfilesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ThreatPreventionProfileCollection> response = apiInstance.ThreatPreventionProfilesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;DNS Category Profile&quot;] |

### Return type

[**ThreatPreventionProfileCollection**](ThreatPreventionProfileCollection.md)

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

<a id="threatpreventionprofilesnamenamepatch"></a>
# **ThreatPreventionProfilesNameNAMEPatch**
> ApiStatus ThreatPreventionProfilesNameNAMEPatch (string NAME, ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Patch threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var NAME = "\"DNS Category Profile\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "DNS Category Profile")
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesNameNAMEPatch(NAME, threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesNameNAMEPatchWithHttpInfo(NAME, threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;DNS Category Profile&quot;] |
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

<a id="threatpreventionprofilesnamenameput"></a>
# **ThreatPreventionProfilesNameNAMEPut**
> ApiStatus ThreatPreventionProfilesNameNAMEPut (string NAME, ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Edit threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var NAME = "\"DNS Category Profile\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "DNS Category Profile")
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesNameNAMEPut(NAME, threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesNameNAMEPutWithHttpInfo(NAME, threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;DNS Category Profile&quot;] |
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

<a id="threatpreventionprofilespatch"></a>
# **ThreatPreventionProfilesPatch**
> ApiStatus ThreatPreventionProfilesPatch (ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Patch threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesPatch(threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesPatchWithHttpInfo(threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

<a id="threatpreventionprofilespost"></a>
# **ThreatPreventionProfilesPost**
> ApiStatus ThreatPreventionProfilesPost (ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Create a new threat prevention profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesPost(threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesPostWithHttpInfo(threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

<a id="threatpreventionprofilesput"></a>
# **ThreatPreventionProfilesPut**
> ApiStatus ThreatPreventionProfilesPut (ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Edit threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesPut(threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesPutWithHttpInfo(threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

<a id="threatpreventionprofilesuuiduuiddelete"></a>
# **ThreatPreventionProfilesUuidUUIDDelete**
> ApiStatus ThreatPreventionProfilesUuidUUIDDelete (string UUID)



Delete a threat prevention profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="threatpreventionprofilesuuiduuidget"></a>
# **ThreatPreventionProfilesUuidUUIDGet**
> ThreatPreventionProfileCollection ThreatPreventionProfilesUuidUUIDGet (string UUID)



Retrieve threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ThreatPreventionProfileCollection result = apiInstance.ThreatPreventionProfilesUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ThreatPreventionProfileCollection> response = apiInstance.ThreatPreventionProfilesUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**ThreatPreventionProfileCollection**](ThreatPreventionProfileCollection.md)

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

<a id="threatpreventionprofilesuuiduuidpatch"></a>
# **ThreatPreventionProfilesUuidUUIDPatch**
> ApiStatus ThreatPreventionProfilesUuidUUIDPatch (string UUID, ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Patch threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesUuidUUIDPatch(UUID, threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesUuidUUIDPatchWithHttpInfo(UUID, threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

<a id="threatpreventionprofilesuuiduuidput"></a>
# **ThreatPreventionProfilesUuidUUIDPut**
> ApiStatus ThreatPreventionProfilesUuidUUIDPut (string UUID, ThreatPreventionProfileCollection? threatPreventionProfileCollection = null)



Edit threat prevention profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ThreatPreventionProfilesUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ThreatPreventionProfileApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var threatPreventionProfileCollection = new ThreatPreventionProfileCollection?(); // ThreatPreventionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ThreatPreventionProfilesUuidUUIDPut(UUID, threatPreventionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ThreatPreventionProfilesUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ThreatPreventionProfilesUuidUUIDPutWithHttpInfo(UUID, threatPreventionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreatPreventionProfileApi.ThreatPreventionProfilesUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **threatPreventionProfileCollection** | [**ThreatPreventionProfileCollection?**](ThreatPreventionProfileCollection?.md) |  | [optional]  |

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

