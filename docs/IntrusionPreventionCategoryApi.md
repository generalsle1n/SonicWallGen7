# SonicWallGen7.Api.IntrusionPreventionCategoryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IntrusionPreventionCategoriesGet**](IntrusionPreventionCategoryApi.md#intrusionpreventioncategoriesget) | **GET** /intrusion-prevention/categories |  |
| [**IntrusionPreventionCategoriesIdIDGet**](IntrusionPreventionCategoryApi.md#intrusionpreventioncategoriesididget) | **GET** /intrusion-prevention/categories/id/{ID} |  |
| [**IntrusionPreventionCategoriesIdIDPut**](IntrusionPreventionCategoryApi.md#intrusionpreventioncategoriesididput) | **PUT** /intrusion-prevention/categories/id/{ID} |  |
| [**IntrusionPreventionCategoriesNameNAMEGet**](IntrusionPreventionCategoryApi.md#intrusionpreventioncategoriesnamenameget) | **GET** /intrusion-prevention/categories/name/{NAME} |  |
| [**IntrusionPreventionCategoriesNameNAMEPut**](IntrusionPreventionCategoryApi.md#intrusionpreventioncategoriesnamenameput) | **PUT** /intrusion-prevention/categories/name/{NAME} |  |
| [**IntrusionPreventionCategoriesPut**](IntrusionPreventionCategoryApi.md#intrusionpreventioncategoriesput) | **PUT** /intrusion-prevention/categories |  |

<a id="intrusionpreventioncategoriesget"></a>
# **IntrusionPreventionCategoriesGet**
> IntrusionPreventionCategoryCollection IntrusionPreventionCategoriesGet ()



Retrieve intrusion prevention category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionCategoriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionCategoryApi(config);

            try
            {
                IntrusionPreventionCategoryCollection result = apiInstance.IntrusionPreventionCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionCategoriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionCategoryCollection> response = apiInstance.IntrusionPreventionCategoriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IntrusionPreventionCategoryCollection**](IntrusionPreventionCategoryCollection.md)

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

<a id="intrusionpreventioncategoriesididget"></a>
# **IntrusionPreventionCategoriesIdIDGet**
> IntrusionPreventionCategoryCollection IntrusionPreventionCategoriesIdIDGet (decimal ID)



Retrieve intrusion prevention category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionCategoriesIdIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionCategoryApi(config);
            var ID = 8.14D;  // decimal | Category ID.

            try
            {
                IntrusionPreventionCategoryCollection result = apiInstance.IntrusionPreventionCategoriesIdIDGet(ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesIdIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionCategoriesIdIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionCategoryCollection> response = apiInstance.IntrusionPreventionCategoriesIdIDGetWithHttpInfo(ID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesIdIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Category ID. |  |

### Return type

[**IntrusionPreventionCategoryCollection**](IntrusionPreventionCategoryCollection.md)

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

<a id="intrusionpreventioncategoriesididput"></a>
# **IntrusionPreventionCategoriesIdIDPut**
> ApiStatus IntrusionPreventionCategoriesIdIDPut (decimal ID, IntrusionPreventionCategoryCollection? intrusionPreventionCategoryCollection = null)



Edit intrusion prevention category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionCategoriesIdIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionCategoryApi(config);
            var ID = 8.14D;  // decimal | Category ID.
            var intrusionPreventionCategoryCollection = new IntrusionPreventionCategoryCollection?(); // IntrusionPreventionCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionCategoriesIdIDPut(ID, intrusionPreventionCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesIdIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionCategoriesIdIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionCategoriesIdIDPutWithHttpInfo(ID, intrusionPreventionCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesIdIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Category ID. |  |
| **intrusionPreventionCategoryCollection** | [**IntrusionPreventionCategoryCollection?**](IntrusionPreventionCategoryCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventioncategoriesnamenameget"></a>
# **IntrusionPreventionCategoriesNameNAMEGet**
> IntrusionPreventionCategoryCollection IntrusionPreventionCategoriesNameNAMEGet (string NAME)



Retrieve intrusion prevention category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionCategoriesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionCategoryApi(config);
            var NAME = "\"ACTIVEX\"";  // string | Category name. (default to "ACTIVEX")

            try
            {
                IntrusionPreventionCategoryCollection result = apiInstance.IntrusionPreventionCategoriesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionCategoriesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionCategoryCollection> response = apiInstance.IntrusionPreventionCategoriesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;ACTIVEX&quot;] |

### Return type

[**IntrusionPreventionCategoryCollection**](IntrusionPreventionCategoryCollection.md)

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

<a id="intrusionpreventioncategoriesnamenameput"></a>
# **IntrusionPreventionCategoriesNameNAMEPut**
> ApiStatus IntrusionPreventionCategoriesNameNAMEPut (string NAME, IntrusionPreventionCategoryCollection? intrusionPreventionCategoryCollection = null)



Edit intrusion prevention category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionCategoriesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionCategoryApi(config);
            var NAME = "\"ACTIVEX\"";  // string | Category name. (default to "ACTIVEX")
            var intrusionPreventionCategoryCollection = new IntrusionPreventionCategoryCollection?(); // IntrusionPreventionCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionCategoriesNameNAMEPut(NAME, intrusionPreventionCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionCategoriesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionCategoriesNameNAMEPutWithHttpInfo(NAME, intrusionPreventionCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;ACTIVEX&quot;] |
| **intrusionPreventionCategoryCollection** | [**IntrusionPreventionCategoryCollection?**](IntrusionPreventionCategoryCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventioncategoriesput"></a>
# **IntrusionPreventionCategoriesPut**
> ApiStatus IntrusionPreventionCategoriesPut (IntrusionPreventionCategoryCollection? intrusionPreventionCategoryCollection = null)



Edit intrusion prevention category object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionCategoriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionCategoryApi(config);
            var intrusionPreventionCategoryCollection = new IntrusionPreventionCategoryCollection?(); // IntrusionPreventionCategoryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionCategoriesPut(intrusionPreventionCategoryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionCategoriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionCategoriesPutWithHttpInfo(intrusionPreventionCategoryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionCategoryApi.IntrusionPreventionCategoriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intrusionPreventionCategoryCollection** | [**IntrusionPreventionCategoryCollection?**](IntrusionPreventionCategoryCollection?.md) |  | [optional]  |

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

