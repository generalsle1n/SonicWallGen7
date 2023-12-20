# SonicWallGen7.Api.SecurityPolicyIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurityPoliciesIpv4Get**](SecurityPolicyIpv4Api.md#securitypoliciesipv4get) | **GET** /security-policies/ipv4 |  |
| [**SecurityPoliciesIpv4Post**](SecurityPolicyIpv4Api.md#securitypoliciesipv4post) | **POST** /security-policies/ipv4 |  |
| [**SecurityPoliciesIpv4Put**](SecurityPolicyIpv4Api.md#securitypoliciesipv4put) | **PUT** /security-policies/ipv4 |  |
| [**SecurityPoliciesIpv4UuidUUIDDelete**](SecurityPolicyIpv4Api.md#securitypoliciesipv4uuiduuiddelete) | **DELETE** /security-policies/ipv4/uuid/{UUID} |  |
| [**SecurityPoliciesIpv4UuidUUIDGet**](SecurityPolicyIpv4Api.md#securitypoliciesipv4uuiduuidget) | **GET** /security-policies/ipv4/uuid/{UUID} |  |
| [**SecurityPoliciesIpv4UuidUUIDPut**](SecurityPolicyIpv4Api.md#securitypoliciesipv4uuiduuidput) | **PUT** /security-policies/ipv4/uuid/{UUID} |  |

<a id="securitypoliciesipv4get"></a>
# **SecurityPoliciesIpv4Get**
> SecurityPolicyIpv4Collection SecurityPoliciesIpv4Get ()



Retrieve an IPv4 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv4Api(config);

            try
            {
                SecurityPolicyIpv4Collection result = apiInstance.SecurityPoliciesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityPolicyIpv4Collection> response = apiInstance.SecurityPoliciesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SecurityPolicyIpv4Collection**](SecurityPolicyIpv4Collection.md)

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

<a id="securitypoliciesipv4post"></a>
# **SecurityPoliciesIpv4Post**
> ApiStatus SecurityPoliciesIpv4Post (SecurityPolicyIpv4Collection? securityPolicyIpv4Collection = null)



Create a new IPv4 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv4Api(config);
            var securityPolicyIpv4Collection = new SecurityPolicyIpv4Collection?(); // SecurityPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv4Post(securityPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv4PostWithHttpInfo(securityPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityPolicyIpv4Collection** | [**SecurityPolicyIpv4Collection?**](SecurityPolicyIpv4Collection?.md) |  | [optional]  |

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

<a id="securitypoliciesipv4put"></a>
# **SecurityPoliciesIpv4Put**
> ApiStatus SecurityPoliciesIpv4Put (SecurityPolicyIpv4Collection? securityPolicyIpv4Collection = null)



Edit an existing IPv4 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv4Api(config);
            var securityPolicyIpv4Collection = new SecurityPolicyIpv4Collection?(); // SecurityPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv4Put(securityPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv4PutWithHttpInfo(securityPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityPolicyIpv4Collection** | [**SecurityPolicyIpv4Collection?**](SecurityPolicyIpv4Collection?.md) |  | [optional]  |

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

<a id="securitypoliciesipv4uuiduuiddelete"></a>
# **SecurityPoliciesIpv4UuidUUIDDelete**
> ApiStatus SecurityPoliciesIpv4UuidUUIDDelete (string UUID)



Delete an IPv4 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv4UuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv4Api(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv4UuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4UuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv4UuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv4UuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4UuidUUIDDeleteWithHttpInfo: " + e.Message);
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

<a id="securitypoliciesipv4uuiduuidget"></a>
# **SecurityPoliciesIpv4UuidUUIDGet**
> SecurityPolicyIpv4Collection SecurityPoliciesIpv4UuidUUIDGet (string UUID)



Retrieve an IPv4 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv4UuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv4Api(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")

            try
            {
                SecurityPolicyIpv4Collection result = apiInstance.SecurityPoliciesIpv4UuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4UuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv4UuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecurityPolicyIpv4Collection> response = apiInstance.SecurityPoliciesIpv4UuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4UuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |

### Return type

[**SecurityPolicyIpv4Collection**](SecurityPolicyIpv4Collection.md)

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

<a id="securitypoliciesipv4uuiduuidput"></a>
# **SecurityPoliciesIpv4UuidUUIDPut**
> ApiStatus SecurityPoliciesIpv4UuidUUIDPut (string UUID, SecurityPolicyIpv4Collection? securityPolicyIpv4Collection = null)



Edit an existing IPv4 security policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SecurityPoliciesIpv4UuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SecurityPolicyIpv4Api(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")
            var securityPolicyIpv4Collection = new SecurityPolicyIpv4Collection?(); // SecurityPolicyIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SecurityPoliciesIpv4UuidUUIDPut(UUID, securityPolicyIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4UuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurityPoliciesIpv4UuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SecurityPoliciesIpv4UuidUUIDPutWithHttpInfo(UUID, securityPolicyIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityPolicyIpv4Api.SecurityPoliciesIpv4UuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |
| **securityPolicyIpv4Collection** | [**SecurityPolicyIpv4Collection?**](SecurityPolicyIpv4Collection?.md) |  | [optional]  |

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

