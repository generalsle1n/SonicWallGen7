# SonicWallGen7.Api.AddressObjectIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddressObjectsIpv4Get**](AddressObjectIpv4Api.md#addressobjectsipv4get) | **GET** /address-objects/ipv4 |  |
| [**AddressObjectsIpv4NameNAMEDelete**](AddressObjectIpv4Api.md#addressobjectsipv4namenamedelete) | **DELETE** /address-objects/ipv4/name/{NAME} |  |
| [**AddressObjectsIpv4NameNAMEGet**](AddressObjectIpv4Api.md#addressobjectsipv4namenameget) | **GET** /address-objects/ipv4/name/{NAME} |  |
| [**AddressObjectsIpv4NameNAMEPatch**](AddressObjectIpv4Api.md#addressobjectsipv4namenamepatch) | **PATCH** /address-objects/ipv4/name/{NAME} |  |
| [**AddressObjectsIpv4NameNAMEPut**](AddressObjectIpv4Api.md#addressobjectsipv4namenameput) | **PUT** /address-objects/ipv4/name/{NAME} |  |
| [**AddressObjectsIpv4Patch**](AddressObjectIpv4Api.md#addressobjectsipv4patch) | **PATCH** /address-objects/ipv4 |  |
| [**AddressObjectsIpv4Post**](AddressObjectIpv4Api.md#addressobjectsipv4post) | **POST** /address-objects/ipv4 |  |
| [**AddressObjectsIpv4Put**](AddressObjectIpv4Api.md#addressobjectsipv4put) | **PUT** /address-objects/ipv4 |  |
| [**AddressObjectsIpv4UuidUUIDDelete**](AddressObjectIpv4Api.md#addressobjectsipv4uuiduuiddelete) | **DELETE** /address-objects/ipv4/uuid/{UUID} |  |
| [**AddressObjectsIpv4UuidUUIDGet**](AddressObjectIpv4Api.md#addressobjectsipv4uuiduuidget) | **GET** /address-objects/ipv4/uuid/{UUID} |  |
| [**AddressObjectsIpv4UuidUUIDPatch**](AddressObjectIpv4Api.md#addressobjectsipv4uuiduuidpatch) | **PATCH** /address-objects/ipv4/uuid/{UUID} |  |
| [**AddressObjectsIpv4UuidUUIDPut**](AddressObjectIpv4Api.md#addressobjectsipv4uuiduuidput) | **PUT** /address-objects/ipv4/uuid/{UUID} |  |

<a id="addressobjectsipv4get"></a>
# **AddressObjectsIpv4Get**
> AddressObjectIpv4Collection AddressObjectsIpv4Get ()



Retrieve IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);

            try
            {
                AddressObjectIpv4Collection result = apiInstance.AddressObjectsIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressObjectIpv4Collection> response = apiInstance.AddressObjectsIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AddressObjectIpv4Collection**](AddressObjectIpv4Collection.md)

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

<a id="addressobjectsipv4namenamedelete"></a>
# **AddressObjectsIpv4NameNAMEDelete**
> ApiStatus AddressObjectsIpv4NameNAMEDelete (string NAME)



Delete an IPv4 address object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var NAME = "\"Web Server\"";  // string | Host/network/range address object name. (default to "Web Server")

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Host/network/range address object name. | [default to &quot;Web Server&quot;] |

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

<a id="addressobjectsipv4namenameget"></a>
# **AddressObjectsIpv4NameNAMEGet**
> AddressObjectIpv4Collection AddressObjectsIpv4NameNAMEGet (string NAME)



Retrieve IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var NAME = "\"Web Server\"";  // string | Host/network/range address object name. (default to "Web Server")

            try
            {
                AddressObjectIpv4Collection result = apiInstance.AddressObjectsIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressObjectIpv4Collection> response = apiInstance.AddressObjectsIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Host/network/range address object name. | [default to &quot;Web Server&quot;] |

### Return type

[**AddressObjectIpv4Collection**](AddressObjectIpv4Collection.md)

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

<a id="addressobjectsipv4namenamepatch"></a>
# **AddressObjectsIpv4NameNAMEPatch**
> ApiStatus AddressObjectsIpv4NameNAMEPatch (string NAME, AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Patch IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var NAME = "\"Web Server\"";  // string | Host/network/range address object name. (default to "Web Server")
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4NameNAMEPatch(NAME, addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4NameNAMEPatchWithHttpInfo(NAME, addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Host/network/range address object name. | [default to &quot;Web Server&quot;] |
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

<a id="addressobjectsipv4namenameput"></a>
# **AddressObjectsIpv4NameNAMEPut**
> ApiStatus AddressObjectsIpv4NameNAMEPut (string NAME, AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Edit IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var NAME = "\"Web Server\"";  // string | Host/network/range address object name. (default to "Web Server")
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4NameNAMEPut(NAME, addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4NameNAMEPutWithHttpInfo(NAME, addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Host/network/range address object name. | [default to &quot;Web Server&quot;] |
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

<a id="addressobjectsipv4patch"></a>
# **AddressObjectsIpv4Patch**
> ApiStatus AddressObjectsIpv4Patch (AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Patch IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4Patch(addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4PatchWithHttpInfo(addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

<a id="addressobjectsipv4post"></a>
# **AddressObjectsIpv4Post**
> ApiStatus AddressObjectsIpv4Post (AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Create a new IPv4 address object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4Post(addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4PostWithHttpInfo(addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

<a id="addressobjectsipv4put"></a>
# **AddressObjectsIpv4Put**
> ApiStatus AddressObjectsIpv4Put (AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Edit IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4Put(addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4PutWithHttpInfo(addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

<a id="addressobjectsipv4uuiduuiddelete"></a>
# **AddressObjectsIpv4UuidUUIDDelete**
> ApiStatus AddressObjectsIpv4UuidUUIDDelete (string UUID)



Delete an IPv4 address object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4UuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4UuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4UuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4UuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="addressobjectsipv4uuiduuidget"></a>
# **AddressObjectsIpv4UuidUUIDGet**
> AddressObjectIpv4Collection AddressObjectsIpv4UuidUUIDGet (string UUID)



Retrieve IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                AddressObjectIpv4Collection result = apiInstance.AddressObjectsIpv4UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressObjectIpv4Collection> response = apiInstance.AddressObjectsIpv4UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**AddressObjectIpv4Collection**](AddressObjectIpv4Collection.md)

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

<a id="addressobjectsipv4uuiduuidpatch"></a>
# **AddressObjectsIpv4UuidUUIDPatch**
> ApiStatus AddressObjectsIpv4UuidUUIDPatch (string UUID, AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Patch IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4UuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4UuidUUIDPatch(UUID, addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4UuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4UuidUUIDPatchWithHttpInfo(UUID, addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

<a id="addressobjectsipv4uuiduuidput"></a>
# **AddressObjectsIpv4UuidUUIDPut**
> ApiStatus AddressObjectsIpv4UuidUUIDPut (string UUID, AddressObjectIpv4Collection? addressObjectIpv4Collection = null)



Edit IPv4 address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectsIpv4UuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var addressObjectIpv4Collection = new AddressObjectIpv4Collection?(); // AddressObjectIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectsIpv4UuidUUIDPut(UUID, addressObjectIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectsIpv4UuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectsIpv4UuidUUIDPutWithHttpInfo(UUID, addressObjectIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectIpv4Api.AddressObjectsIpv4UuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **addressObjectIpv4Collection** | [**AddressObjectIpv4Collection?**](AddressObjectIpv4Collection?.md) |  | [optional]  |

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

