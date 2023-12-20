# SonicWallGen7.Api.SslVpnBookmarkApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SslVpnBookmarksGet**](SslVpnBookmarkApi.md#sslvpnbookmarksget) | **GET** /ssl-vpn/bookmarks |  |
| [**SslVpnBookmarksNameNAMEDelete**](SslVpnBookmarkApi.md#sslvpnbookmarksnamenamedelete) | **DELETE** /ssl-vpn/bookmarks/name/{NAME} |  |
| [**SslVpnBookmarksNameNAMEGet**](SslVpnBookmarkApi.md#sslvpnbookmarksnamenameget) | **GET** /ssl-vpn/bookmarks/name/{NAME} |  |
| [**SslVpnBookmarksNameNAMEPatch**](SslVpnBookmarkApi.md#sslvpnbookmarksnamenamepatch) | **PATCH** /ssl-vpn/bookmarks/name/{NAME} |  |
| [**SslVpnBookmarksNameNAMEPut**](SslVpnBookmarkApi.md#sslvpnbookmarksnamenameput) | **PUT** /ssl-vpn/bookmarks/name/{NAME} |  |
| [**SslVpnBookmarksPatch**](SslVpnBookmarkApi.md#sslvpnbookmarkspatch) | **PATCH** /ssl-vpn/bookmarks |  |
| [**SslVpnBookmarksPost**](SslVpnBookmarkApi.md#sslvpnbookmarkspost) | **POST** /ssl-vpn/bookmarks |  |
| [**SslVpnBookmarksPut**](SslVpnBookmarkApi.md#sslvpnbookmarksput) | **PUT** /ssl-vpn/bookmarks |  |

<a id="sslvpnbookmarksget"></a>
# **SslVpnBookmarksGet**
> SslVpnBookmarkCollection SslVpnBookmarksGet ()



Retrieve SSL VPN bookmark object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);

            try
            {
                SslVpnBookmarkCollection result = apiInstance.SslVpnBookmarksGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslVpnBookmarkCollection> response = apiInstance.SslVpnBookmarksGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SslVpnBookmarkCollection**](SslVpnBookmarkCollection.md)

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

<a id="sslvpnbookmarksnamenamedelete"></a>
# **SslVpnBookmarksNameNAMEDelete**
> ApiStatus SslVpnBookmarksNameNAMEDelete (string NAME)



Delete a SSL VPN bookmark object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.SslVpnBookmarksNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnBookmarksNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="sslvpnbookmarksnamenameget"></a>
# **SslVpnBookmarksNameNAMEGet**
> SslVpnBookmarkCollection SslVpnBookmarksNameNAMEGet (string NAME)



Retrieve SSL VPN bookmark object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                SslVpnBookmarkCollection result = apiInstance.SslVpnBookmarksNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SslVpnBookmarkCollection> response = apiInstance.SslVpnBookmarksNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**SslVpnBookmarkCollection**](SslVpnBookmarkCollection.md)

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

<a id="sslvpnbookmarksnamenamepatch"></a>
# **SslVpnBookmarksNameNAMEPatch**
> ApiStatus SslVpnBookmarksNameNAMEPatch (string NAME, SslVpnBookmarkCollection? sslVpnBookmarkCollection = null)



Patch SSL VPN bookmark object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var sslVpnBookmarkCollection = new SslVpnBookmarkCollection?(); // SslVpnBookmarkCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnBookmarksNameNAMEPatch(NAME, sslVpnBookmarkCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnBookmarksNameNAMEPatchWithHttpInfo(NAME, sslVpnBookmarkCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **sslVpnBookmarkCollection** | [**SslVpnBookmarkCollection?**](SslVpnBookmarkCollection?.md) |  | [optional]  |

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

<a id="sslvpnbookmarksnamenameput"></a>
# **SslVpnBookmarksNameNAMEPut**
> ApiStatus SslVpnBookmarksNameNAMEPut (string NAME, SslVpnBookmarkCollection? sslVpnBookmarkCollection = null)



Edit SSL VPN bookmark object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var sslVpnBookmarkCollection = new SslVpnBookmarkCollection?(); // SslVpnBookmarkCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnBookmarksNameNAMEPut(NAME, sslVpnBookmarkCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnBookmarksNameNAMEPutWithHttpInfo(NAME, sslVpnBookmarkCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **sslVpnBookmarkCollection** | [**SslVpnBookmarkCollection?**](SslVpnBookmarkCollection?.md) |  | [optional]  |

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

<a id="sslvpnbookmarkspatch"></a>
# **SslVpnBookmarksPatch**
> ApiStatus SslVpnBookmarksPatch (SslVpnBookmarkCollection? sslVpnBookmarkCollection = null)



Patch SSL VPN bookmark object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var sslVpnBookmarkCollection = new SslVpnBookmarkCollection?(); // SslVpnBookmarkCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnBookmarksPatch(sslVpnBookmarkCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnBookmarksPatchWithHttpInfo(sslVpnBookmarkCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslVpnBookmarkCollection** | [**SslVpnBookmarkCollection?**](SslVpnBookmarkCollection?.md) |  | [optional]  |

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

<a id="sslvpnbookmarkspost"></a>
# **SslVpnBookmarksPost**
> ApiStatus SslVpnBookmarksPost (SslVpnBookmarkCollection? sslVpnBookmarkCollection = null)



Create a new SSL VPN bookmark object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var sslVpnBookmarkCollection = new SslVpnBookmarkCollection?(); // SslVpnBookmarkCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnBookmarksPost(sslVpnBookmarkCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnBookmarksPostWithHttpInfo(sslVpnBookmarkCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslVpnBookmarkCollection** | [**SslVpnBookmarkCollection?**](SslVpnBookmarkCollection?.md) |  | [optional]  |

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

<a id="sslvpnbookmarksput"></a>
# **SslVpnBookmarksPut**
> ApiStatus SslVpnBookmarksPut (SslVpnBookmarkCollection? sslVpnBookmarkCollection = null)



Edit SSL VPN bookmark object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SslVpnBookmarksPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SslVpnBookmarkApi(config);
            var sslVpnBookmarkCollection = new SslVpnBookmarkCollection?(); // SslVpnBookmarkCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SslVpnBookmarksPut(sslVpnBookmarkCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SslVpnBookmarksPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SslVpnBookmarksPutWithHttpInfo(sslVpnBookmarkCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SslVpnBookmarkApi.SslVpnBookmarksPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sslVpnBookmarkCollection** | [**SslVpnBookmarkCollection?**](SslVpnBookmarkCollection?.md) |  | [optional]  |

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

