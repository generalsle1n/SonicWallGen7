# SonicWallGen7.Api.AppControlSignatureApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppControlSignaturesGet**](AppControlSignatureApi.md#appcontrolsignaturesget) | **GET** /app-control/signatures |  |
| [**AppControlSignaturesIdIDGet**](AppControlSignatureApi.md#appcontrolsignaturesididget) | **GET** /app-control/signatures/id/{ID} |  |
| [**AppControlSignaturesIdIDPut**](AppControlSignatureApi.md#appcontrolsignaturesididput) | **PUT** /app-control/signatures/id/{ID} |  |
| [**AppControlSignaturesNameNAMEGet**](AppControlSignatureApi.md#appcontrolsignaturesnamenameget) | **GET** /app-control/signatures/name/{NAME} |  |
| [**AppControlSignaturesNameNAMEPut**](AppControlSignatureApi.md#appcontrolsignaturesnamenameput) | **PUT** /app-control/signatures/name/{NAME} |  |
| [**AppControlSignaturesPost**](AppControlSignatureApi.md#appcontrolsignaturespost) | **POST** /app-control/signatures |  |
| [**AppControlSignaturesPut**](AppControlSignatureApi.md#appcontrolsignaturesput) | **PUT** /app-control/signatures |  |

<a id="appcontrolsignaturesget"></a>
# **AppControlSignaturesGet**
> AppControlSignatureCollection AppControlSignaturesGet ()



Retrieve app control edited signature object configuration (Modified Configuration Visible Only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);

            try
            {
                AppControlSignatureCollection result = apiInstance.AppControlSignaturesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlSignatureCollection> response = apiInstance.AppControlSignaturesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppControlSignatureCollection**](AppControlSignatureCollection.md)

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

<a id="appcontrolsignaturesididget"></a>
# **AppControlSignaturesIdIDGet**
> AppControlSignatureCollection AppControlSignaturesIdIDGet (decimal ID)



Retrieve app control edited signature object configuration (Modified Configuration Visible Only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesIdIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);
            var ID = 8.14D;  // decimal | Signature ID.

            try
            {
                AppControlSignatureCollection result = apiInstance.AppControlSignaturesIdIDGet(ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesIdIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesIdIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlSignatureCollection> response = apiInstance.AppControlSignaturesIdIDGetWithHttpInfo(ID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesIdIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Signature ID. |  |

### Return type

[**AppControlSignatureCollection**](AppControlSignatureCollection.md)

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

<a id="appcontrolsignaturesididput"></a>
# **AppControlSignaturesIdIDPut**
> ApiStatus AppControlSignaturesIdIDPut (decimal ID, AppControlSignatureCollection? appControlSignatureCollection = null)



Edit app control signature object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesIdIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);
            var ID = 8.14D;  // decimal | Signature ID.
            var appControlSignatureCollection = new AppControlSignatureCollection?(); // AppControlSignatureCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlSignaturesIdIDPut(ID, appControlSignatureCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesIdIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesIdIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlSignaturesIdIDPutWithHttpInfo(ID, appControlSignatureCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesIdIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Signature ID. |  |
| **appControlSignatureCollection** | [**AppControlSignatureCollection?**](AppControlSignatureCollection?.md) |  | [optional]  |

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

<a id="appcontrolsignaturesnamenameget"></a>
# **AppControlSignaturesNameNAMEGet**
> AppControlSignatureCollection AppControlSignaturesNameNAMEGet (string NAME)



Retrieve app control edited signature object configuration (Modified Configuration Visible Only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);
            var NAME = "\"\"";  // string | Signature name. (default to "")

            try
            {
                AppControlSignatureCollection result = apiInstance.AppControlSignaturesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlSignatureCollection> response = apiInstance.AppControlSignaturesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Signature name. | [default to &quot;&quot;] |

### Return type

[**AppControlSignatureCollection**](AppControlSignatureCollection.md)

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

<a id="appcontrolsignaturesnamenameput"></a>
# **AppControlSignaturesNameNAMEPut**
> ApiStatus AppControlSignaturesNameNAMEPut (string NAME, AppControlSignatureCollection? appControlSignatureCollection = null)



Edit app control signature object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);
            var NAME = "\"\"";  // string | Signature name. (default to "")
            var appControlSignatureCollection = new AppControlSignatureCollection?(); // AppControlSignatureCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlSignaturesNameNAMEPut(NAME, appControlSignatureCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlSignaturesNameNAMEPutWithHttpInfo(NAME, appControlSignatureCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Signature name. | [default to &quot;&quot;] |
| **appControlSignatureCollection** | [**AppControlSignatureCollection?**](AppControlSignatureCollection?.md) |  | [optional]  |

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

<a id="appcontrolsignaturespost"></a>
# **AppControlSignaturesPost**
> ApiStatus AppControlSignaturesPost (AppControlSignatureCollection? appControlSignatureCollection = null)



Create a new app control signature object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);
            var appControlSignatureCollection = new AppControlSignatureCollection?(); // AppControlSignatureCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlSignaturesPost(appControlSignatureCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlSignaturesPostWithHttpInfo(appControlSignatureCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appControlSignatureCollection** | [**AppControlSignatureCollection?**](AppControlSignatureCollection?.md) |  | [optional]  |

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

<a id="appcontrolsignaturesput"></a>
# **AppControlSignaturesPut**
> ApiStatus AppControlSignaturesPut (AppControlSignatureCollection? appControlSignatureCollection = null)



Edit app control signature object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignatureApi(config);
            var appControlSignatureCollection = new AppControlSignatureCollection?(); // AppControlSignatureCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AppControlSignaturesPut(appControlSignatureCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AppControlSignaturesPutWithHttpInfo(appControlSignatureCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignatureApi.AppControlSignaturesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appControlSignatureCollection** | [**AppControlSignatureCollection?**](AppControlSignatureCollection?.md) |  | [optional]  |

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

