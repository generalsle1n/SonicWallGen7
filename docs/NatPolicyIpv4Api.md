# SonicWallGen7.Api.NatPolicyIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NatPoliciesIpv4Get**](NatPolicyIpv4Api.md#natpoliciesipv4get) | **GET** /nat-policies/ipv4 |  |
| [**NatPoliciesIpv4Patch**](NatPolicyIpv4Api.md#natpoliciesipv4patch) | **PATCH** /nat-policies/ipv4 |  |
| [**NatPoliciesIpv4Post**](NatPolicyIpv4Api.md#natpoliciesipv4post) | **POST** /nat-policies/ipv4 |  |
| [**NatPoliciesIpv4Put**](NatPolicyIpv4Api.md#natpoliciesipv4put) | **PUT** /nat-policies/ipv4 |  |
| [**NatPoliciesIpv4UuidUUIDDelete**](NatPolicyIpv4Api.md#natpoliciesipv4uuiduuiddelete) | **DELETE** /nat-policies/ipv4/uuid/{UUID} |  |
| [**NatPoliciesIpv4UuidUUIDGet**](NatPolicyIpv4Api.md#natpoliciesipv4uuiduuidget) | **GET** /nat-policies/ipv4/uuid/{UUID} |  |
| [**NatPoliciesIpv4UuidUUIDPatch**](NatPolicyIpv4Api.md#natpoliciesipv4uuiduuidpatch) | **PATCH** /nat-policies/ipv4/uuid/{UUID} |  |
| [**NatPoliciesIpv4UuidUUIDPut**](NatPolicyIpv4Api.md#natpoliciesipv4uuiduuidput) | **PUT** /nat-policies/ipv4/uuid/{UUID} |  |

<a id="natpoliciesipv4get"></a>
# **NatPoliciesIpv4Get**
> NatPolicyIpv4Collection NatPoliciesIpv4Get ()



Retrieve an IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);

            try
            {
                NatPolicyIpv4Collection result = apiInstance.NatPoliciesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NatPolicyIpv4Collection> response = apiInstance.NatPoliciesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**NatPolicyIpv4Collection**](NatPolicyIpv4Collection.md)

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

<a id="natpoliciesipv4patch"></a>
# **NatPoliciesIpv4Patch**
> ApiStatus NatPoliciesIpv4Patch (NatPolicyIpv4Collection? natPolicyIpv4Collection = null)



Patch an existing IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var natPolicyIpv4Collection = new NatPolicyIpv4Collection?(); // NatPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NatPoliciesIpv4Patch(natPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NatPoliciesIpv4PatchWithHttpInfo(natPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **natPolicyIpv4Collection** | [**NatPolicyIpv4Collection?**](NatPolicyIpv4Collection?.md) |  | [optional]  |

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

<a id="natpoliciesipv4post"></a>
# **NatPoliciesIpv4Post**
> ApiStatus NatPoliciesIpv4Post (NatPolicyIpv4Collection? natPolicyIpv4Collection = null)



Create a new IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var natPolicyIpv4Collection = new NatPolicyIpv4Collection?(); // NatPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NatPoliciesIpv4Post(natPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NatPoliciesIpv4PostWithHttpInfo(natPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **natPolicyIpv4Collection** | [**NatPolicyIpv4Collection?**](NatPolicyIpv4Collection?.md) |  | [optional]  |

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

<a id="natpoliciesipv4put"></a>
# **NatPoliciesIpv4Put**
> ApiStatus NatPoliciesIpv4Put (NatPolicyIpv4Collection? natPolicyIpv4Collection = null)



Edit an existing IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var natPolicyIpv4Collection = new NatPolicyIpv4Collection?(); // NatPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NatPoliciesIpv4Put(natPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NatPoliciesIpv4PutWithHttpInfo(natPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **natPolicyIpv4Collection** | [**NatPolicyIpv4Collection?**](NatPolicyIpv4Collection?.md) |  | [optional]  |

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

<a id="natpoliciesipv4uuiduuiddelete"></a>
# **NatPoliciesIpv4UuidUUIDDelete**
> ApiStatus NatPoliciesIpv4UuidUUIDDelete (string UUID)



Delete an IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4UuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.NatPoliciesIpv4UuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4UuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NatPoliciesIpv4UuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="natpoliciesipv4uuiduuidget"></a>
# **NatPoliciesIpv4UuidUUIDGet**
> NatPolicyIpv4Collection NatPoliciesIpv4UuidUUIDGet (string UUID)



Retrieve an IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                NatPolicyIpv4Collection result = apiInstance.NatPoliciesIpv4UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NatPolicyIpv4Collection> response = apiInstance.NatPoliciesIpv4UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**NatPolicyIpv4Collection**](NatPolicyIpv4Collection.md)

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

<a id="natpoliciesipv4uuiduuidpatch"></a>
# **NatPoliciesIpv4UuidUUIDPatch**
> ApiStatus NatPoliciesIpv4UuidUUIDPatch (string UUID, NatPolicyIpv4Collection? natPolicyIpv4Collection = null)



Patch an existing IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4UuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var natPolicyIpv4Collection = new NatPolicyIpv4Collection?(); // NatPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NatPoliciesIpv4UuidUUIDPatch(UUID, natPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4UuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NatPoliciesIpv4UuidUUIDPatchWithHttpInfo(UUID, natPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **natPolicyIpv4Collection** | [**NatPolicyIpv4Collection?**](NatPolicyIpv4Collection?.md) |  | [optional]  |

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

<a id="natpoliciesipv4uuiduuidput"></a>
# **NatPoliciesIpv4UuidUUIDPut**
> ApiStatus NatPoliciesIpv4UuidUUIDPut (string UUID, NatPolicyIpv4Collection? natPolicyIpv4Collection = null)



Edit an existing IPv4 nat policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NatPoliciesIpv4UuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NatPolicyIpv4Api(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var natPolicyIpv4Collection = new NatPolicyIpv4Collection?(); // NatPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NatPoliciesIpv4UuidUUIDPut(UUID, natPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NatPoliciesIpv4UuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NatPoliciesIpv4UuidUUIDPutWithHttpInfo(UUID, natPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NatPolicyIpv4Api.NatPoliciesIpv4UuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **natPolicyIpv4Collection** | [**NatPolicyIpv4Collection?**](NatPolicyIpv4Collection?.md) |  | [optional]  |

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

