# SonicWallGen7.Api.AntiSpywareProductApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AntiSpywareProductsGet**](AntiSpywareProductApi.md#antispywareproductsget) | **GET** /anti-spyware/products |  |
| [**AntiSpywareProductsIdIDGet**](AntiSpywareProductApi.md#antispywareproductsididget) | **GET** /anti-spyware/products/id/{ID} |  |
| [**AntiSpywareProductsIdIDPut**](AntiSpywareProductApi.md#antispywareproductsididput) | **PUT** /anti-spyware/products/id/{ID} |  |
| [**AntiSpywareProductsNameNAMEGet**](AntiSpywareProductApi.md#antispywareproductsnamenameget) | **GET** /anti-spyware/products/name/{NAME} |  |
| [**AntiSpywareProductsNameNAMEPut**](AntiSpywareProductApi.md#antispywareproductsnamenameput) | **PUT** /anti-spyware/products/name/{NAME} |  |
| [**AntiSpywareProductsPut**](AntiSpywareProductApi.md#antispywareproductsput) | **PUT** /anti-spyware/products |  |

<a id="antispywareproductsget"></a>
# **AntiSpywareProductsGet**
> AntiSpywareProductCollection AntiSpywareProductsGet ()



Retrieve anti spyware product object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareProductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareProductApi(config);

            try
            {
                AntiSpywareProductCollection result = apiInstance.AntiSpywareProductsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareProductsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywareProductCollection> response = apiInstance.AntiSpywareProductsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AntiSpywareProductCollection**](AntiSpywareProductCollection.md)

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

<a id="antispywareproductsididget"></a>
# **AntiSpywareProductsIdIDGet**
> AntiSpywareProductCollection AntiSpywareProductsIdIDGet (decimal ID)



Retrieve anti spyware product object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareProductsIdIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareProductApi(config);
            var ID = 8.14D;  // decimal | The ID of anti-spyware product.

            try
            {
                AntiSpywareProductCollection result = apiInstance.AntiSpywareProductsIdIDGet(ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsIdIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareProductsIdIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywareProductCollection> response = apiInstance.AntiSpywareProductsIdIDGetWithHttpInfo(ID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsIdIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | The ID of anti-spyware product. |  |

### Return type

[**AntiSpywareProductCollection**](AntiSpywareProductCollection.md)

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

<a id="antispywareproductsididput"></a>
# **AntiSpywareProductsIdIDPut**
> ApiStatus AntiSpywareProductsIdIDPut (decimal ID, AntiSpywareProductCollection? antiSpywareProductCollection = null)



Edit anti spyware product object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareProductsIdIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareProductApi(config);
            var ID = 8.14D;  // decimal | The ID of anti-spyware product.
            var antiSpywareProductCollection = new AntiSpywareProductCollection?(); // AntiSpywareProductCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareProductsIdIDPut(ID, antiSpywareProductCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsIdIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareProductsIdIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareProductsIdIDPutWithHttpInfo(ID, antiSpywareProductCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsIdIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | The ID of anti-spyware product. |  |
| **antiSpywareProductCollection** | [**AntiSpywareProductCollection?**](AntiSpywareProductCollection?.md) |  | [optional]  |

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

<a id="antispywareproductsnamenameget"></a>
# **AntiSpywareProductsNameNAMEGet**
> AntiSpywareProductCollection AntiSpywareProductsNameNAMEGet (string NAME)



Retrieve anti spyware product object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareProductsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareProductApi(config);
            var NAME = "\"abc\"";  // string | The name of anti-spyware product. (default to "abc")

            try
            {
                AntiSpywareProductCollection result = apiInstance.AntiSpywareProductsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareProductsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywareProductCollection> response = apiInstance.AntiSpywareProductsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | The name of anti-spyware product. | [default to &quot;abc&quot;] |

### Return type

[**AntiSpywareProductCollection**](AntiSpywareProductCollection.md)

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

<a id="antispywareproductsnamenameput"></a>
# **AntiSpywareProductsNameNAMEPut**
> ApiStatus AntiSpywareProductsNameNAMEPut (string NAME, AntiSpywareProductCollection? antiSpywareProductCollection = null)



Edit anti spyware product object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareProductsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareProductApi(config);
            var NAME = "\"abc\"";  // string | The name of anti-spyware product. (default to "abc")
            var antiSpywareProductCollection = new AntiSpywareProductCollection?(); // AntiSpywareProductCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareProductsNameNAMEPut(NAME, antiSpywareProductCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareProductsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareProductsNameNAMEPutWithHttpInfo(NAME, antiSpywareProductCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | The name of anti-spyware product. | [default to &quot;abc&quot;] |
| **antiSpywareProductCollection** | [**AntiSpywareProductCollection?**](AntiSpywareProductCollection?.md) |  | [optional]  |

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

<a id="antispywareproductsput"></a>
# **AntiSpywareProductsPut**
> ApiStatus AntiSpywareProductsPut (AntiSpywareProductCollection? antiSpywareProductCollection = null)



Edit anti spyware product object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareProductsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareProductApi(config);
            var antiSpywareProductCollection = new AntiSpywareProductCollection?(); // AntiSpywareProductCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareProductsPut(antiSpywareProductCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareProductsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareProductsPutWithHttpInfo(antiSpywareProductCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareProductApi.AntiSpywareProductsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **antiSpywareProductCollection** | [**AntiSpywareProductCollection?**](AntiSpywareProductCollection?.md) |  | [optional]  |

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

