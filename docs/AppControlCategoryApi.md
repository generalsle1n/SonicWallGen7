# SonicWallGen7.Api.AppControlCategoryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppControlCategoriesGet**](AppControlCategoryApi.md#appcontrolcategoriesget) | **GET** /app-control/categories |  |
| [**AppControlCategoriesIdIDGet**](AppControlCategoryApi.md#appcontrolcategoriesididget) | **GET** /app-control/categories/id/{ID} |  |
| [**AppControlCategoriesIdIDPut**](AppControlCategoryApi.md#appcontrolcategoriesididput) | **PUT** /app-control/categories/id/{ID} |  |
| [**AppControlCategoriesNameNAMEGet**](AppControlCategoryApi.md#appcontrolcategoriesnamenameget) | **GET** /app-control/categories/name/{NAME} |  |
| [**AppControlCategoriesNameNAMEPut**](AppControlCategoryApi.md#appcontrolcategoriesnamenameput) | **PUT** /app-control/categories/name/{NAME} |  |
| [**AppControlCategoriesPost**](AppControlCategoryApi.md#appcontrolcategoriespost) | **POST** /app-control/categories |  |
| [**AppControlCategoriesPut**](AppControlCategoryApi.md#appcontrolcategoriesput) | **PUT** /app-control/categories |  |

<a id="appcontrolcategoriesget"></a>
# **AppControlCategoriesGet**
> AppControlCategoryCollection AppControlCategoriesGet ()



Retrieve app control category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);

            try
            {
                AppControlCategoryCollection result = apiInstance.AppControlCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlCategoryCollection> response = apiInstance.AppControlCategoriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppControlCategoryCollection**](AppControlCategoryCollection.md)

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

<a id="appcontrolcategoriesididget"></a>
# **AppControlCategoriesIdIDGet**
> AppControlCategoryCollection AppControlCategoriesIdIDGet (decimal ID)



Retrieve app control category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesIdIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);
            var ID = 8.14D;  // decimal | Category ID.

            try
            {
                AppControlCategoryCollection result = apiInstance.AppControlCategoriesIdIDGet(ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesIdIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesIdIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlCategoryCollection> response = apiInstance.AppControlCategoriesIdIDGetWithHttpInfo(ID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesIdIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Category ID. |  |

### Return type

[**AppControlCategoryCollection**](AppControlCategoryCollection.md)

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

<a id="appcontrolcategoriesididput"></a>
# **AppControlCategoriesIdIDPut**
> ApiStatus AppControlCategoriesIdIDPut (decimal ID, AppControlCategoryCollection? appControlCategoryCollection = null)



Edit app control category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesIdIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);
            var ID = 8.14D;  // decimal | Category ID.
            var appControlCategoryCollection = new AppControlCategoryCollection?(); // AppControlCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlCategoriesIdIDPut(ID, appControlCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesIdIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesIdIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlCategoriesIdIDPutWithHttpInfo(ID, appControlCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesIdIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Category ID. |  |
| **appControlCategoryCollection** | [**AppControlCategoryCollection?**](AppControlCategoryCollection?.md) |  | [optional]  |

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

<a id="appcontrolcategoriesnamenameget"></a>
# **AppControlCategoriesNameNAMEGet**
> AppControlCategoryCollection AppControlCategoriesNameNAMEGet (string NAME)



Retrieve app control category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);
            var NAME = "\"APP-UPDATE\"";  // string | Category name. (default to "APP-UPDATE")

            try
            {
                AppControlCategoryCollection result = apiInstance.AppControlCategoriesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlCategoryCollection> response = apiInstance.AppControlCategoriesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;APP-UPDATE&quot;] |

### Return type

[**AppControlCategoryCollection**](AppControlCategoryCollection.md)

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

<a id="appcontrolcategoriesnamenameput"></a>
# **AppControlCategoriesNameNAMEPut**
> ApiStatus AppControlCategoriesNameNAMEPut (string NAME, AppControlCategoryCollection? appControlCategoryCollection = null)



Edit app control category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);
            var NAME = "\"APP-UPDATE\"";  // string | Category name. (default to "APP-UPDATE")
            var appControlCategoryCollection = new AppControlCategoryCollection?(); // AppControlCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlCategoriesNameNAMEPut(NAME, appControlCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlCategoriesNameNAMEPutWithHttpInfo(NAME, appControlCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;APP-UPDATE&quot;] |
| **appControlCategoryCollection** | [**AppControlCategoryCollection?**](AppControlCategoryCollection?.md) |  | [optional]  |

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

<a id="appcontrolcategoriespost"></a>
# **AppControlCategoriesPost**
> ApiStatus AppControlCategoriesPost (AppControlCategoryCollection? appControlCategoryCollection = null)



Create a new app control category object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);
            var appControlCategoryCollection = new AppControlCategoryCollection?(); // AppControlCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlCategoriesPost(appControlCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlCategoriesPostWithHttpInfo(appControlCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appControlCategoryCollection** | [**AppControlCategoryCollection?**](AppControlCategoryCollection?.md) |  | [optional]  |

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

<a id="appcontrolcategoriesput"></a>
# **AppControlCategoriesPut**
> ApiStatus AppControlCategoriesPut (AppControlCategoryCollection? appControlCategoryCollection = null)



Edit app control category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlCategoriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlCategoryApi(config);
            var appControlCategoryCollection = new AppControlCategoryCollection?(); // AppControlCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlCategoriesPut(appControlCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlCategoriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlCategoriesPutWithHttpInfo(appControlCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlCategoryApi.AppControlCategoriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appControlCategoryCollection** | [**AppControlCategoryCollection?**](AppControlCategoryCollection?.md) |  | [optional]  |

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

