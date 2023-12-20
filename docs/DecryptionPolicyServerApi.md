# SonicWallGen7.Api.DecryptionPolicyServerApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DecryptionPoliciesServerGet**](DecryptionPolicyServerApi.md#decryptionpoliciesserverget) | **GET** /decryption-policies/server |  |
| [**DecryptionPoliciesServerPost**](DecryptionPolicyServerApi.md#decryptionpoliciesserverpost) | **POST** /decryption-policies/server |  |
| [**DecryptionPoliciesServerPut**](DecryptionPolicyServerApi.md#decryptionpoliciesserverput) | **PUT** /decryption-policies/server |  |
| [**DecryptionPoliciesServerUuidUUIDDelete**](DecryptionPolicyServerApi.md#decryptionpoliciesserveruuiduuiddelete) | **DELETE** /decryption-policies/server/uuid/{UUID} |  |
| [**DecryptionPoliciesServerUuidUUIDGet**](DecryptionPolicyServerApi.md#decryptionpoliciesserveruuiduuidget) | **GET** /decryption-policies/server/uuid/{UUID} |  |
| [**DecryptionPoliciesServerUuidUUIDPut**](DecryptionPolicyServerApi.md#decryptionpoliciesserveruuiduuidput) | **PUT** /decryption-policies/server/uuid/{UUID} |  |

<a id="decryptionpoliciesserverget"></a>
# **DecryptionPoliciesServerGet**
> DecryptionPolicyServerCollection DecryptionPoliciesServerGet ()



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
    public class DecryptionPoliciesServerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerApi(config);

            try
            {
                DecryptionPolicyServerCollection result = apiInstance.DecryptionPoliciesServerGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesServerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DecryptionPolicyServerCollection> response = apiInstance.DecryptionPoliciesServerGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DecryptionPolicyServerCollection**](DecryptionPolicyServerCollection.md)

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

<a id="decryptionpoliciesserverpost"></a>
# **DecryptionPoliciesServerPost**
> ApiStatus DecryptionPoliciesServerPost (DecryptionPolicyServerCollection? decryptionPolicyServerCollection = null)



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
    public class DecryptionPoliciesServerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerApi(config);
            var decryptionPolicyServerCollection = new DecryptionPolicyServerCollection?(); // DecryptionPolicyServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesServerPost(decryptionPolicyServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesServerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesServerPostWithHttpInfo(decryptionPolicyServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicyServerCollection** | [**DecryptionPolicyServerCollection?**](DecryptionPolicyServerCollection?.md) |  | [optional]  |

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

<a id="decryptionpoliciesserverput"></a>
# **DecryptionPoliciesServerPut**
> ApiStatus DecryptionPoliciesServerPut (DecryptionPolicyServerCollection? decryptionPolicyServerCollection = null)



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
    public class DecryptionPoliciesServerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerApi(config);
            var decryptionPolicyServerCollection = new DecryptionPolicyServerCollection?(); // DecryptionPolicyServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesServerPut(decryptionPolicyServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesServerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesServerPutWithHttpInfo(decryptionPolicyServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **decryptionPolicyServerCollection** | [**DecryptionPolicyServerCollection?**](DecryptionPolicyServerCollection?.md) |  | [optional]  |

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

<a id="decryptionpoliciesserveruuiduuiddelete"></a>
# **DecryptionPoliciesServerUuidUUIDDelete**
> ApiStatus DecryptionPoliciesServerUuidUUIDDelete (string UUID)



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
    public class DecryptionPoliciesServerUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesServerUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesServerUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesServerUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerUuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="decryptionpoliciesserveruuiduuidget"></a>
# **DecryptionPoliciesServerUuidUUIDGet**
> DecryptionPolicyServerCollection DecryptionPoliciesServerUuidUUIDGet (string UUID)



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
    public class DecryptionPoliciesServerUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")

            try
            {
                DecryptionPolicyServerCollection result = apiInstance.DecryptionPoliciesServerUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesServerUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DecryptionPolicyServerCollection> response = apiInstance.DecryptionPoliciesServerUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |

### Return type

[**DecryptionPolicyServerCollection**](DecryptionPolicyServerCollection.md)

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

<a id="decryptionpoliciesserveruuiduuidput"></a>
# **DecryptionPoliciesServerUuidUUIDPut**
> ApiStatus DecryptionPoliciesServerUuidUUIDPut (string UUID, DecryptionPolicyServerCollection? decryptionPolicyServerCollection = null)



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
    public class DecryptionPoliciesServerUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DecryptionPolicyServerApi(config);
            var UUID = "\"550e8400-e29b-41d4-a716-446655440000\"";  // string | Universally Unique Identifier (UUID) (default to "550e8400-e29b-41d4-a716-446655440000")
            var decryptionPolicyServerCollection = new DecryptionPolicyServerCollection?(); // DecryptionPolicyServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DecryptionPoliciesServerUuidUUIDPut(UUID, decryptionPolicyServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DecryptionPoliciesServerUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DecryptionPoliciesServerUuidUUIDPutWithHttpInfo(UUID, decryptionPolicyServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DecryptionPolicyServerApi.DecryptionPoliciesServerUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;550e8400-e29b-41d4-a716-446655440000&quot;] |
| **decryptionPolicyServerCollection** | [**DecryptionPolicyServerCollection?**](DecryptionPolicyServerCollection?.md) |  | [optional]  |

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

