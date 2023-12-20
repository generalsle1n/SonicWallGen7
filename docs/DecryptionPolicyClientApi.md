# SonicWallGen7.Api.DecryptionPolicyClientApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DecryptionPoliciesClientGet**](DecryptionPolicyClientApi.md#decryptionpoliciesclientget) | **GET** /decryption-policies/client |  |
| [**DecryptionPoliciesClientPost**](DecryptionPolicyClientApi.md#decryptionpoliciesclientpost) | **POST** /decryption-policies/client |  |
| [**DecryptionPoliciesClientPut**](DecryptionPolicyClientApi.md#decryptionpoliciesclientput) | **PUT** /decryption-policies/client |  |
| [**DecryptionPoliciesClientUuidUUIDDelete**](DecryptionPolicyClientApi.md#decryptionpoliciesclientuuiduuiddelete) | **DELETE** /decryption-policies/client/uuid/{UUID} |  |
| [**DecryptionPoliciesClientUuidUUIDGet**](DecryptionPolicyClientApi.md#decryptionpoliciesclientuuiduuidget) | **GET** /decryption-policies/client/uuid/{UUID} |  |
| [**DecryptionPoliciesClientUuidUUIDPut**](DecryptionPolicyClientApi.md#decryptionpoliciesclientuuiduuidput) | **PUT** /decryption-policies/client/uuid/{UUID} |  |

<a id="decryptionpoliciesclientget"></a>
# **DecryptionPoliciesClientGet**
> DecryptionPolicyClientCollection DecryptionPoliciesClientGet ()



Retrieve a decryption policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DecryptionPoliciesClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientApi(config);

            try
            {
                DecryptionPolicyClientCollection result = apiInstance.DecryptionPoliciesClientGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DecryptionPolicyClientCollection> response = apiInstance.DecryptionPoliciesClientGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DecryptionPolicyClientCollection**](DecryptionPolicyClientCollection.md)

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

<a id="decryptionpoliciesclientpost"></a>
# **DecryptionPoliciesClientPost**
> ApiStatus DecryptionPoliciesClientPost (DecryptionPolicyClientCollection? decryptionPolicyClientCollection = null)



Create a new decryption policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DecryptionPoliciesClientPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientApi(config);
            var decryptionPolicyClientCollection = new DecryptionPolicyClientCollection?(); // DecryptionPolicyClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesClientPost(decryptionPolicyClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesClientPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesClientPostWithHttpInfo(decryptionPolicyClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicyClientCollection** | [**DecryptionPolicyClientCollection?**](DecryptionPolicyClientCollection?.md) |  | [optional]  |

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

<a id="decryptionpoliciesclientput"></a>
# **DecryptionPoliciesClientPut**
> ApiStatus DecryptionPoliciesClientPut (DecryptionPolicyClientCollection? decryptionPolicyClientCollection = null)



Edit an existing decryption policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DecryptionPoliciesClientPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientApi(config);
            var decryptionPolicyClientCollection = new DecryptionPolicyClientCollection?(); // DecryptionPolicyClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesClientPut(decryptionPolicyClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesClientPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesClientPutWithHttpInfo(decryptionPolicyClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicyClientCollection** | [**DecryptionPolicyClientCollection?**](DecryptionPolicyClientCollection?.md) |  | [optional]  |

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

<a id="decryptionpoliciesclientuuiduuiddelete"></a>
# **DecryptionPoliciesClientUuidUUIDDelete**
> ApiStatus DecryptionPoliciesClientUuidUUIDDelete (string UUID)



Delete a decryption policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DecryptionPoliciesClientUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesClientUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesClientUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesClientUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientUuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |

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

<a id="decryptionpoliciesclientuuiduuidget"></a>
# **DecryptionPoliciesClientUuidUUIDGet**
> DecryptionPolicyClientCollection DecryptionPoliciesClientUuidUUIDGet (string UUID)



Retrieve a decryption policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DecryptionPoliciesClientUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                DecryptionPolicyClientCollection result = apiInstance.DecryptionPoliciesClientUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesClientUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DecryptionPolicyClientCollection> response = apiInstance.DecryptionPoliciesClientUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |

### Return type

[**DecryptionPolicyClientCollection**](DecryptionPolicyClientCollection.md)

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

<a id="decryptionpoliciesclientuuiduuidput"></a>
# **DecryptionPoliciesClientUuidUUIDPut**
> ApiStatus DecryptionPoliciesClientUuidUUIDPut (string UUID, DecryptionPolicyClientCollection? decryptionPolicyClientCollection = null)



Edit an existing decryption policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DecryptionPoliciesClientUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyClientApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")
            var decryptionPolicyClientCollection = new DecryptionPolicyClientCollection?(); // DecryptionPolicyClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesClientUuidUUIDPut(UUID, decryptionPolicyClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesClientUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesClientUuidUUIDPutWithHttpInfo(UUID, decryptionPolicyClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyClientApi.DecryptionPoliciesClientUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |
| **decryptionPolicyClientCollection** | [**DecryptionPolicyClientCollection?**](DecryptionPolicyClientCollection?.md) |  | [optional]  |

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

