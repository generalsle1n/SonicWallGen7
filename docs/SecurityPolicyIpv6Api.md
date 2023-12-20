# SonicWallGen7.Api.SecurityPolicyIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurityPoliciesIpv6Get**](SecurityPolicyIpv6Api.md#securitypoliciesipv6get) | **GET** /security-policies/ipv6 |  |
| [**SecurityPoliciesIpv6Post**](SecurityPolicyIpv6Api.md#securitypoliciesipv6post) | **POST** /security-policies/ipv6 |  |
| [**SecurityPoliciesIpv6Put**](SecurityPolicyIpv6Api.md#securitypoliciesipv6put) | **PUT** /security-policies/ipv6 |  |
| [**SecurityPoliciesIpv6UuidUUIDDelete**](SecurityPolicyIpv6Api.md#securitypoliciesipv6uuiduuiddelete) | **DELETE** /security-policies/ipv6/uuid/{UUID} |  |
| [**SecurityPoliciesIpv6UuidUUIDGet**](SecurityPolicyIpv6Api.md#securitypoliciesipv6uuiduuidget) | **GET** /security-policies/ipv6/uuid/{UUID} |  |
| [**SecurityPoliciesIpv6UuidUUIDPut**](SecurityPolicyIpv6Api.md#securitypoliciesipv6uuiduuidput) | **PUT** /security-policies/ipv6/uuid/{UUID} |  |

<a id="securitypoliciesipv6get"></a>
# **SecurityPoliciesIpv6Get**
> SecurityPolicyIpv6Collection SecurityPoliciesIpv6Get ()



Retrieve an IPv6 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6Api(config);

            try
            {
                SecurityPolicyIpv6Collection result = apiInstance.SecurityPoliciesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityPolicyIpv6Collection> response = apiInstance.SecurityPoliciesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SecurityPolicyIpv6Collection**](SecurityPolicyIpv6Collection.md)

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

<a id="securitypoliciesipv6post"></a>
# **SecurityPoliciesIpv6Post**
> ApiStatus SecurityPoliciesIpv6Post (SecurityPolicyIpv6Collection? securityPolicyIpv6Collection = null)



Create a new IPv6 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv6PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6Api(config);
            var securityPolicyIpv6Collection = new SecurityPolicyIpv6Collection?(); // SecurityPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv6Post(securityPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv6PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv6PostWithHttpInfo(securityPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityPolicyIpv6Collection** | [**SecurityPolicyIpv6Collection?**](SecurityPolicyIpv6Collection?.md) |  | [optional]  |

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

<a id="securitypoliciesipv6put"></a>
# **SecurityPoliciesIpv6Put**
> ApiStatus SecurityPoliciesIpv6Put (SecurityPolicyIpv6Collection? securityPolicyIpv6Collection = null)



Edit an existing IPv6 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6Api(config);
            var securityPolicyIpv6Collection = new SecurityPolicyIpv6Collection?(); // SecurityPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv6Put(securityPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv6PutWithHttpInfo(securityPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityPolicyIpv6Collection** | [**SecurityPolicyIpv6Collection?**](SecurityPolicyIpv6Collection?.md) |  | [optional]  |

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

<a id="securitypoliciesipv6uuiduuiddelete"></a>
# **SecurityPoliciesIpv6UuidUUIDDelete**
> ApiStatus SecurityPoliciesIpv6UuidUUIDDelete (string UUID)



Delete an IPv6 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv6UuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6Api(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv6UuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6UuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv6UuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv6UuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6UuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |

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

<a id="securitypoliciesipv6uuiduuidget"></a>
# **SecurityPoliciesIpv6UuidUUIDGet**
> SecurityPolicyIpv6Collection SecurityPoliciesIpv6UuidUUIDGet (string UUID)



Retrieve an IPv6 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv6UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6Api(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")

            try
            {
                SecurityPolicyIpv6Collection result = apiInstance.SecurityPoliciesIpv6UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv6UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityPolicyIpv6Collection> response = apiInstance.SecurityPoliciesIpv6UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |

### Return type

[**SecurityPolicyIpv6Collection**](SecurityPolicyIpv6Collection.md)

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

<a id="securitypoliciesipv6uuiduuidput"></a>
# **SecurityPoliciesIpv6UuidUUIDPut**
> ApiStatus SecurityPoliciesIpv6UuidUUIDPut (string UUID, SecurityPolicyIpv6Collection? securityPolicyIpv6Collection = null)



Edit an existing IPv6 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv6UuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv6Api(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")
            var securityPolicyIpv6Collection = new SecurityPolicyIpv6Collection?(); // SecurityPolicyIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv6UuidUUIDPut(UUID, securityPolicyIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6UuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv6UuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv6UuidUUIDPutWithHttpInfo(UUID, securityPolicyIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv6Api.SecurityPoliciesIpv6UuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |
| **securityPolicyIpv6Collection** | [**SecurityPolicyIpv6Collection?**](SecurityPolicyIpv6Collection?.md) |  | [optional]  |

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

