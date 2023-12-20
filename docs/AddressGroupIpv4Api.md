# SonicWallGen7.Api.AddressGroupIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddressGroupsIpv4Get**](AddressGroupIpv4Api.md#addressgroupsipv4get) | **GET** /address-groups/ipv4 |  |
| [**AddressGroupsIpv4NameNAMEDelete**](AddressGroupIpv4Api.md#addressgroupsipv4namenamedelete) | **DELETE** /address-groups/ipv4/name/{NAME} |  |
| [**AddressGroupsIpv4NameNAMEGet**](AddressGroupIpv4Api.md#addressgroupsipv4namenameget) | **GET** /address-groups/ipv4/name/{NAME} |  |
| [**AddressGroupsIpv4NameNAMEPatch**](AddressGroupIpv4Api.md#addressgroupsipv4namenamepatch) | **PATCH** /address-groups/ipv4/name/{NAME} |  |
| [**AddressGroupsIpv4NameNAMEPut**](AddressGroupIpv4Api.md#addressgroupsipv4namenameput) | **PUT** /address-groups/ipv4/name/{NAME} |  |
| [**AddressGroupsIpv4Patch**](AddressGroupIpv4Api.md#addressgroupsipv4patch) | **PATCH** /address-groups/ipv4 |  |
| [**AddressGroupsIpv4Post**](AddressGroupIpv4Api.md#addressgroupsipv4post) | **POST** /address-groups/ipv4 |  |
| [**AddressGroupsIpv4Put**](AddressGroupIpv4Api.md#addressgroupsipv4put) | **PUT** /address-groups/ipv4 |  |
| [**AddressGroupsIpv4UuidUUIDDelete**](AddressGroupIpv4Api.md#addressgroupsipv4uuiduuiddelete) | **DELETE** /address-groups/ipv4/uuid/{UUID} |  |
| [**AddressGroupsIpv4UuidUUIDGet**](AddressGroupIpv4Api.md#addressgroupsipv4uuiduuidget) | **GET** /address-groups/ipv4/uuid/{UUID} |  |
| [**AddressGroupsIpv4UuidUUIDPatch**](AddressGroupIpv4Api.md#addressgroupsipv4uuiduuidpatch) | **PATCH** /address-groups/ipv4/uuid/{UUID} |  |
| [**AddressGroupsIpv4UuidUUIDPut**](AddressGroupIpv4Api.md#addressgroupsipv4uuiduuidput) | **PUT** /address-groups/ipv4/uuid/{UUID} |  |

<a id="addressgroupsipv4get"></a>
# **AddressGroupsIpv4Get**
> AddressGroupIpv4Collection AddressGroupsIpv4Get ()



Retrieve IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);

            try
            {
                AddressGroupIpv4Collection result = apiInstance.AddressGroupsIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressGroupIpv4Collection> response = apiInstance.AddressGroupsIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AddressGroupIpv4Collection**](AddressGroupIpv4Collection.md)

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

<a id="addressgroupsipv4namenamedelete"></a>
# **AddressGroupsIpv4NameNAMEDelete**
> ApiStatus AddressGroupsIpv4NameNAMEDelete (string NAME)



Delete an IPv4 address group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var NAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

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

<a id="addressgroupsipv4namenameget"></a>
# **AddressGroupsIpv4NameNAMEGet**
> AddressGroupIpv4Collection AddressGroupsIpv4NameNAMEGet (string NAME)



Retrieve IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var NAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                AddressGroupIpv4Collection result = apiInstance.AddressGroupsIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressGroupIpv4Collection> response = apiInstance.AddressGroupsIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

### Return type

[**AddressGroupIpv4Collection**](AddressGroupIpv4Collection.md)

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

<a id="addressgroupsipv4namenamepatch"></a>
# **AddressGroupsIpv4NameNAMEPatch**
> ApiStatus AddressGroupsIpv4NameNAMEPatch (string NAME, AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Edit IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var NAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4NameNAMEPatch(NAME, addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4NameNAMEPatchWithHttpInfo(NAME, addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

<a id="addressgroupsipv4namenameput"></a>
# **AddressGroupsIpv4NameNAMEPut**
> ApiStatus AddressGroupsIpv4NameNAMEPut (string NAME, AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Edit IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var NAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4NameNAMEPut(NAME, addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4NameNAMEPutWithHttpInfo(NAME, addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

<a id="addressgroupsipv4patch"></a>
# **AddressGroupsIpv4Patch**
> ApiStatus AddressGroupsIpv4Patch (AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Edit IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4Patch(addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4PatchWithHttpInfo(addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

<a id="addressgroupsipv4post"></a>
# **AddressGroupsIpv4Post**
> ApiStatus AddressGroupsIpv4Post (AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Create a new IPv4 address group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4Post(addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4PostWithHttpInfo(addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

<a id="addressgroupsipv4put"></a>
# **AddressGroupsIpv4Put**
> ApiStatus AddressGroupsIpv4Put (AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Edit IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4Put(addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4PutWithHttpInfo(addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

<a id="addressgroupsipv4uuiduuiddelete"></a>
# **AddressGroupsIpv4UuidUUIDDelete**
> ApiStatus AddressGroupsIpv4UuidUUIDDelete (string UUID)



Delete an IPv4 address group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4UuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4UuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4UuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4UuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="addressgroupsipv4uuiduuidget"></a>
# **AddressGroupsIpv4UuidUUIDGet**
> AddressGroupIpv4Collection AddressGroupsIpv4UuidUUIDGet (string UUID)



Retrieve IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                AddressGroupIpv4Collection result = apiInstance.AddressGroupsIpv4UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddressGroupIpv4Collection> response = apiInstance.AddressGroupsIpv4UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**AddressGroupIpv4Collection**](AddressGroupIpv4Collection.md)

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

<a id="addressgroupsipv4uuiduuidpatch"></a>
# **AddressGroupsIpv4UuidUUIDPatch**
> ApiStatus AddressGroupsIpv4UuidUUIDPatch (string UUID, AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Edit IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4UuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4UuidUUIDPatch(UUID, addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4UuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4UuidUUIDPatchWithHttpInfo(UUID, addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

<a id="addressgroupsipv4uuiduuidput"></a>
# **AddressGroupsIpv4UuidUUIDPut**
> ApiStatus AddressGroupsIpv4UuidUUIDPut (string UUID, AddressGroupIpv4Collection? addressGroupIpv4Collection = null)



Edit IPv4 address group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressGroupsIpv4UuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressGroupIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var addressGroupIpv4Collection = new AddressGroupIpv4Collection?(); // AddressGroupIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressGroupsIpv4UuidUUIDPut(UUID, addressGroupIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressGroupsIpv4UuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressGroupsIpv4UuidUUIDPutWithHttpInfo(UUID, addressGroupIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressGroupIpv4Api.AddressGroupsIpv4UuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **addressGroupIpv4Collection** | [**AddressGroupIpv4Collection?**](AddressGroupIpv4Collection?.md) |  | [optional]  |

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

