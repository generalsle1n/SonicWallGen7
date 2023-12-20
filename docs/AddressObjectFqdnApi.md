# SonicWallGen7.Api.AddressObjectFqdnApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddressObjectsFqdnGet**](AddressObjectFqdnApi.md#addressobjectsfqdnget) | **GET** /address-objects/fqdn |  |
| [**AddressObjectsFqdnNameNAMEDelete**](AddressObjectFqdnApi.md#addressobjectsfqdnnamenamedelete) | **DELETE** /address-objects/fqdn/name/{NAME} |  |
| [**AddressObjectsFqdnNameNAMEGet**](AddressObjectFqdnApi.md#addressobjectsfqdnnamenameget) | **GET** /address-objects/fqdn/name/{NAME} |  |
| [**AddressObjectsFqdnNameNAMEPatch**](AddressObjectFqdnApi.md#addressobjectsfqdnnamenamepatch) | **PATCH** /address-objects/fqdn/name/{NAME} |  |
| [**AddressObjectsFqdnNameNAMEPut**](AddressObjectFqdnApi.md#addressobjectsfqdnnamenameput) | **PUT** /address-objects/fqdn/name/{NAME} |  |
| [**AddressObjectsFqdnPatch**](AddressObjectFqdnApi.md#addressobjectsfqdnpatch) | **PATCH** /address-objects/fqdn |  |
| [**AddressObjectsFqdnPost**](AddressObjectFqdnApi.md#addressobjectsfqdnpost) | **POST** /address-objects/fqdn |  |
| [**AddressObjectsFqdnPut**](AddressObjectFqdnApi.md#addressobjectsfqdnput) | **PUT** /address-objects/fqdn |  |
| [**AddressObjectsFqdnUuidUUIDDelete**](AddressObjectFqdnApi.md#addressobjectsfqdnuuiduuiddelete) | **DELETE** /address-objects/fqdn/uuid/{UUID} |  |
| [**AddressObjectsFqdnUuidUUIDGet**](AddressObjectFqdnApi.md#addressobjectsfqdnuuiduuidget) | **GET** /address-objects/fqdn/uuid/{UUID} |  |
| [**AddressObjectsFqdnUuidUUIDPatch**](AddressObjectFqdnApi.md#addressobjectsfqdnuuiduuidpatch) | **PATCH** /address-objects/fqdn/uuid/{UUID} |  |
| [**AddressObjectsFqdnUuidUUIDPut**](AddressObjectFqdnApi.md#addressobjectsfqdnuuiduuidput) | **PUT** /address-objects/fqdn/uuid/{UUID} |  |

<a id="addressobjectsfqdnget"></a>
# **AddressObjectsFqdnGet**
> AddressObjectFqdnCollection AddressObjectsFqdnGet ()



Retrieve FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);

            try
            {
                AddressObjectFqdnCollection result = apiInstance.AddressObjectsFqdnGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressObjectFqdnCollection> response = apiInstance.AddressObjectsFqdnGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AddressObjectFqdnCollection**](AddressObjectFqdnCollection.md)

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

<a id="addressobjectsfqdnnamenamedelete"></a>
# **AddressObjectsFqdnNameNAMEDelete**
> ApiStatus AddressObjectsFqdnNameNAMEDelete (string NAME)



Delete an FQDN address object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var NAME = "\"www.example.com\"";  // string | FQDN address object name. (default to "www.example.com")

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | FQDN address object name. | [default to &quot;www.example.com&quot;] |

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

<a id="addressobjectsfqdnnamenameget"></a>
# **AddressObjectsFqdnNameNAMEGet**
> AddressObjectFqdnCollection AddressObjectsFqdnNameNAMEGet (string NAME)



Retrieve FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var NAME = "\"www.example.com\"";  // string | FQDN address object name. (default to "www.example.com")

            try
            {
                AddressObjectFqdnCollection result = apiInstance.AddressObjectsFqdnNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressObjectFqdnCollection> response = apiInstance.AddressObjectsFqdnNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | FQDN address object name. | [default to &quot;www.example.com&quot;] |

### Return type

[**AddressObjectFqdnCollection**](AddressObjectFqdnCollection.md)

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

<a id="addressobjectsfqdnnamenamepatch"></a>
# **AddressObjectsFqdnNameNAMEPatch**
> ApiStatus AddressObjectsFqdnNameNAMEPatch (string NAME, AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Edit FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var NAME = "\"www.example.com\"";  // string | FQDN address object name. (default to "www.example.com")
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnNameNAMEPatch(NAME, addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnNameNAMEPatchWithHttpInfo(NAME, addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | FQDN address object name. | [default to &quot;www.example.com&quot;] |
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

<a id="addressobjectsfqdnnamenameput"></a>
# **AddressObjectsFqdnNameNAMEPut**
> ApiStatus AddressObjectsFqdnNameNAMEPut (string NAME, AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Edit FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var NAME = "\"www.example.com\"";  // string | FQDN address object name. (default to "www.example.com")
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnNameNAMEPut(NAME, addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnNameNAMEPutWithHttpInfo(NAME, addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | FQDN address object name. | [default to &quot;www.example.com&quot;] |
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

<a id="addressobjectsfqdnpatch"></a>
# **AddressObjectsFqdnPatch**
> ApiStatus AddressObjectsFqdnPatch (AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Edit FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnPatch(addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnPatchWithHttpInfo(addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

<a id="addressobjectsfqdnpost"></a>
# **AddressObjectsFqdnPost**
> ApiStatus AddressObjectsFqdnPost (AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Create a new FQDN address object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnPost(addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnPostWithHttpInfo(addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

<a id="addressobjectsfqdnput"></a>
# **AddressObjectsFqdnPut**
> ApiStatus AddressObjectsFqdnPut (AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Edit FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnPut(addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnPutWithHttpInfo(addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

<a id="addressobjectsfqdnuuiduuiddelete"></a>
# **AddressObjectsFqdnUuidUUIDDelete**
> ApiStatus AddressObjectsFqdnUuidUUIDDelete (string UUID)



Delete an FQDN address object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="addressobjectsfqdnuuiduuidget"></a>
# **AddressObjectsFqdnUuidUUIDGet**
> AddressObjectFqdnCollection AddressObjectsFqdnUuidUUIDGet (string UUID)



Retrieve FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                AddressObjectFqdnCollection result = apiInstance.AddressObjectsFqdnUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressObjectFqdnCollection> response = apiInstance.AddressObjectsFqdnUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**AddressObjectFqdnCollection**](AddressObjectFqdnCollection.md)

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

<a id="addressobjectsfqdnuuiduuidpatch"></a>
# **AddressObjectsFqdnUuidUUIDPatch**
> ApiStatus AddressObjectsFqdnUuidUUIDPatch (string UUID, AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Edit FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnUuidUUIDPatch(UUID, addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnUuidUUIDPatchWithHttpInfo(UUID, addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

<a id="addressobjectsfqdnuuiduuidput"></a>
# **AddressObjectsFqdnUuidUUIDPut**
> ApiStatus AddressObjectsFqdnUuidUUIDPut (string UUID, AddressObjectFqdnCollection? addressObjectFqdnCollection = null)



Edit FQDN address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsFqdnUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectFqdnApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var addressObjectFqdnCollection = new AddressObjectFqdnCollection?(); // AddressObjectFqdnCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsFqdnUuidUUIDPut(UUID, addressObjectFqdnCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsFqdnUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsFqdnUuidUUIDPutWithHttpInfo(UUID, addressObjectFqdnCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectFqdnApi.AddressObjectsFqdnUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **addressObjectFqdnCollection** | [**AddressObjectFqdnCollection?**](AddressObjectFqdnCollection?.md) |  | [optional]  |

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

