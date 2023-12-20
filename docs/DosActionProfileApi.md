# SonicWallGen7.Api.DosActionProfileApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DosActionProfilesGet**](DosActionProfileApi.md#dosactionprofilesget) | **GET** /dos-action-profiles |  |
| [**DosActionProfilesNameNAMEDelete**](DosActionProfileApi.md#dosactionprofilesnamenamedelete) | **DELETE** /dos-action-profiles/name/{NAME} |  |
| [**DosActionProfilesNameNAMEGet**](DosActionProfileApi.md#dosactionprofilesnamenameget) | **GET** /dos-action-profiles/name/{NAME} |  |
| [**DosActionProfilesNameNAMEPut**](DosActionProfileApi.md#dosactionprofilesnamenameput) | **PUT** /dos-action-profiles/name/{NAME} |  |
| [**DosActionProfilesPost**](DosActionProfileApi.md#dosactionprofilespost) | **POST** /dos-action-profiles |  |
| [**DosActionProfilesPut**](DosActionProfileApi.md#dosactionprofilesput) | **PUT** /dos-action-profiles |  |
| [**DosActionProfilesUuidUUIDDelete**](DosActionProfileApi.md#dosactionprofilesuuiduuiddelete) | **DELETE** /dos-action-profiles/uuid/{UUID} |  |
| [**DosActionProfilesUuidUUIDGet**](DosActionProfileApi.md#dosactionprofilesuuiduuidget) | **GET** /dos-action-profiles/uuid/{UUID} |  |
| [**DosActionProfilesUuidUUIDPut**](DosActionProfileApi.md#dosactionprofilesuuiduuidput) | **PUT** /dos-action-profiles/uuid/{UUID} |  |

<a id="dosactionprofilesget"></a>
# **DosActionProfilesGet**
> DosActionProfileCollection DosActionProfilesGet ()



Retrieve a dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);

            try
            {
                DosActionProfileCollection result = apiInstance.DosActionProfilesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DosActionProfileCollection> response = apiInstance.DosActionProfilesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DosActionProfileCollection**](DosActionProfileCollection.md)

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

<a id="dosactionprofilesnamenamedelete"></a>
# **DosActionProfilesNameNAMEDelete**
> ApiStatus DosActionProfilesNameNAMEDelete (string NAME)



Delete a dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var NAME = "\"Office DoS Action Profile\"";  // string | Dos action profile name. (default to "Office DoS Action Profile")

            try
            {
                ApiStatus result = apiInstance.DosActionProfilesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DosActionProfilesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dos action profile name. | [default to &quot;Office DoS Action Profile&quot;] |

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

<a id="dosactionprofilesnamenameget"></a>
# **DosActionProfilesNameNAMEGet**
> DosActionProfileCollection DosActionProfilesNameNAMEGet (string NAME)



Retrieve a dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var NAME = "\"Office DoS Action Profile\"";  // string | Dos action profile name. (default to "Office DoS Action Profile")

            try
            {
                DosActionProfileCollection result = apiInstance.DosActionProfilesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DosActionProfileCollection> response = apiInstance.DosActionProfilesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dos action profile name. | [default to &quot;Office DoS Action Profile&quot;] |

### Return type

[**DosActionProfileCollection**](DosActionProfileCollection.md)

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

<a id="dosactionprofilesnamenameput"></a>
# **DosActionProfilesNameNAMEPut**
> ApiStatus DosActionProfilesNameNAMEPut (string NAME, DosActionProfileCollection? dosActionProfileCollection = null)



Edit an existing dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var NAME = "\"Office DoS Action Profile\"";  // string | Dos action profile name. (default to "Office DoS Action Profile")
            var dosActionProfileCollection = new DosActionProfileCollection?(); // DosActionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DosActionProfilesNameNAMEPut(NAME, dosActionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DosActionProfilesNameNAMEPutWithHttpInfo(NAME, dosActionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dos action profile name. | [default to &quot;Office DoS Action Profile&quot;] |
| **dosActionProfileCollection** | [**DosActionProfileCollection?**](DosActionProfileCollection?.md) |  | [optional]  |

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

<a id="dosactionprofilespost"></a>
# **DosActionProfilesPost**
> ApiStatus DosActionProfilesPost (DosActionProfileCollection? dosActionProfileCollection = null)



Create a new dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var dosActionProfileCollection = new DosActionProfileCollection?(); // DosActionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DosActionProfilesPost(dosActionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DosActionProfilesPostWithHttpInfo(dosActionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dosActionProfileCollection** | [**DosActionProfileCollection?**](DosActionProfileCollection?.md) |  | [optional]  |

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

<a id="dosactionprofilesput"></a>
# **DosActionProfilesPut**
> ApiStatus DosActionProfilesPut (DosActionProfileCollection? dosActionProfileCollection = null)



Edit an existing dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var dosActionProfileCollection = new DosActionProfileCollection?(); // DosActionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DosActionProfilesPut(dosActionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DosActionProfilesPutWithHttpInfo(dosActionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dosActionProfileCollection** | [**DosActionProfileCollection?**](DosActionProfileCollection?.md) |  | [optional]  |

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

<a id="dosactionprofilesuuiduuiddelete"></a>
# **DosActionProfilesUuidUUIDDelete**
> ApiStatus DosActionProfilesUuidUUIDDelete (string UUID)



Delete a dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var UUID = "\"7df86117-0a7c-f329-3400-2cb8ed3d8a10\"";  // string | DOS action profile UUID. (default to "7df86117-0a7c-f329-3400-2cb8ed3d8a10")

            try
            {
                ApiStatus result = apiInstance.DosActionProfilesUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DosActionProfilesUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesUuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | DOS action profile UUID. | [default to &quot;7df86117-0a7c-f329-3400-2cb8ed3d8a10&quot;] |

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

<a id="dosactionprofilesuuiduuidget"></a>
# **DosActionProfilesUuidUUIDGet**
> DosActionProfileCollection DosActionProfilesUuidUUIDGet (string UUID)



Retrieve a dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var UUID = "\"7df86117-0a7c-f329-3400-2cb8ed3d8a10\"";  // string | DOS action profile UUID. (default to "7df86117-0a7c-f329-3400-2cb8ed3d8a10")

            try
            {
                DosActionProfileCollection result = apiInstance.DosActionProfilesUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DosActionProfileCollection> response = apiInstance.DosActionProfilesUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | DOS action profile UUID. | [default to &quot;7df86117-0a7c-f329-3400-2cb8ed3d8a10&quot;] |

### Return type

[**DosActionProfileCollection**](DosActionProfileCollection.md)

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

<a id="dosactionprofilesuuiduuidput"></a>
# **DosActionProfilesUuidUUIDPut**
> ApiStatus DosActionProfilesUuidUUIDPut (string UUID, DosActionProfileCollection? dosActionProfileCollection = null)



Edit an existing dos action profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DosActionProfilesUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DosActionProfileApi(config);
            var UUID = "\"7df86117-0a7c-f329-3400-2cb8ed3d8a10\"";  // string | DOS action profile UUID. (default to "7df86117-0a7c-f329-3400-2cb8ed3d8a10")
            var dosActionProfileCollection = new DosActionProfileCollection?(); // DosActionProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DosActionProfilesUuidUUIDPut(UUID, dosActionProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DosActionProfilesUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DosActionProfilesUuidUUIDPutWithHttpInfo(UUID, dosActionProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DosActionProfileApi.DosActionProfilesUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | DOS action profile UUID. | [default to &quot;7df86117-0a7c-f329-3400-2cb8ed3d8a10&quot;] |
| **dosActionProfileCollection** | [**DosActionProfileCollection?**](DosActionProfileCollection?.md) |  | [optional]  |

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

