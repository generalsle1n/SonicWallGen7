# SonicWallGen7.Api.DecryptionPolicySshApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DecryptionPoliciesSshGet**](DecryptionPolicySshApi.md#decryptionpoliciessshget) | **GET** /decryption-policies/ssh |  |
| [**DecryptionPoliciesSshPost**](DecryptionPolicySshApi.md#decryptionpoliciessshpost) | **POST** /decryption-policies/ssh |  |
| [**DecryptionPoliciesSshPut**](DecryptionPolicySshApi.md#decryptionpoliciessshput) | **PUT** /decryption-policies/ssh |  |
| [**DecryptionPoliciesSshUuidUUIDDelete**](DecryptionPolicySshApi.md#decryptionpoliciessshuuiduuiddelete) | **DELETE** /decryption-policies/ssh/uuid/{UUID} |  |
| [**DecryptionPoliciesSshUuidUUIDGet**](DecryptionPolicySshApi.md#decryptionpoliciessshuuiduuidget) | **GET** /decryption-policies/ssh/uuid/{UUID} |  |
| [**DecryptionPoliciesSshUuidUUIDPut**](DecryptionPolicySshApi.md#decryptionpoliciessshuuiduuidput) | **PUT** /decryption-policies/ssh/uuid/{UUID} |  |

<a id="decryptionpoliciessshget"></a>
# **DecryptionPoliciesSshGet**
> DecryptionPolicySshCollection DecryptionPoliciesSshGet ()



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
    public class DecryptionPoliciesSshGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshApi(config);

            try
            {
                DecryptionPolicySshCollection result = apiInstance.DecryptionPoliciesSshGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesSshGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DecryptionPolicySshCollection> response = apiInstance.DecryptionPoliciesSshGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DecryptionPolicySshCollection**](DecryptionPolicySshCollection.md)

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

<a id="decryptionpoliciessshpost"></a>
# **DecryptionPoliciesSshPost**
> ApiStatus DecryptionPoliciesSshPost (DecryptionPolicySshCollection? decryptionPolicySshCollection = null)



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
    public class DecryptionPoliciesSshPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshApi(config);
            var decryptionPolicySshCollection = new DecryptionPolicySshCollection?(); // DecryptionPolicySshCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesSshPost(decryptionPolicySshCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesSshPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesSshPostWithHttpInfo(decryptionPolicySshCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicySshCollection** | [**DecryptionPolicySshCollection?**](DecryptionPolicySshCollection?.md) |  | [optional]  |

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

<a id="decryptionpoliciessshput"></a>
# **DecryptionPoliciesSshPut**
> ApiStatus DecryptionPoliciesSshPut (DecryptionPolicySshCollection? decryptionPolicySshCollection = null)



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
    public class DecryptionPoliciesSshPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshApi(config);
            var decryptionPolicySshCollection = new DecryptionPolicySshCollection?(); // DecryptionPolicySshCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesSshPut(decryptionPolicySshCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesSshPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesSshPutWithHttpInfo(decryptionPolicySshCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicySshCollection** | [**DecryptionPolicySshCollection?**](DecryptionPolicySshCollection?.md) |  | [optional]  |

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

<a id="decryptionpoliciessshuuiduuiddelete"></a>
# **DecryptionPoliciesSshUuidUUIDDelete**
> ApiStatus DecryptionPoliciesSshUuidUUIDDelete (string UUID)



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
    public class DecryptionPoliciesSshUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesSshUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesSshUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesSshUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshUuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="decryptionpoliciessshuuiduuidget"></a>
# **DecryptionPoliciesSshUuidUUIDGet**
> DecryptionPolicySshCollection DecryptionPoliciesSshUuidUUIDGet (string UUID)



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
    public class DecryptionPoliciesSshUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                DecryptionPolicySshCollection result = apiInstance.DecryptionPoliciesSshUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesSshUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DecryptionPolicySshCollection> response = apiInstance.DecryptionPoliciesSshUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |

### Return type

[**DecryptionPolicySshCollection**](DecryptionPolicySshCollection.md)

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

<a id="decryptionpoliciessshuuiduuidput"></a>
# **DecryptionPoliciesSshUuidUUIDPut**
> ApiStatus DecryptionPoliciesSshUuidUUIDPut (string UUID, DecryptionPolicySshCollection? decryptionPolicySshCollection = null)



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
    public class DecryptionPoliciesSshUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicySshApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")
            var decryptionPolicySshCollection = new DecryptionPolicySshCollection?(); // DecryptionPolicySshCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesSshUuidUUIDPut(UUID, decryptionPolicySshCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesSshUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesSshUuidUUIDPutWithHttpInfo(UUID, decryptionPolicySshCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicySshApi.DecryptionPoliciesSshUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |
| **decryptionPolicySshCollection** | [**DecryptionPolicySshCollection?**](DecryptionPolicySshCollection?.md) |  | [optional]  |

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

