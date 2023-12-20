# SonicWallGen7.Api.UserSsoConsistentDomainNameApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoConsistentDomainNamesDnDNDelete**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamesdndndelete) | **DELETE** /user/sso/consistent-domain-names/dn/{DN} |  |
| [**UserSsoConsistentDomainNamesDnDNGet**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamesdndnget) | **GET** /user/sso/consistent-domain-names/dn/{DN} |  |
| [**UserSsoConsistentDomainNamesDnDNPatch**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamesdndnpatch) | **PATCH** /user/sso/consistent-domain-names/dn/{DN} |  |
| [**UserSsoConsistentDomainNamesDnDNPut**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamesdndnput) | **PUT** /user/sso/consistent-domain-names/dn/{DN} |  |
| [**UserSsoConsistentDomainNamesGet**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamesget) | **GET** /user/sso/consistent-domain-names |  |
| [**UserSsoConsistentDomainNamesPatch**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamespatch) | **PATCH** /user/sso/consistent-domain-names |  |
| [**UserSsoConsistentDomainNamesPost**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamespost) | **POST** /user/sso/consistent-domain-names |  |
| [**UserSsoConsistentDomainNamesPut**](UserSsoConsistentDomainNameApi.md#userssoconsistentdomainnamesput) | **PUT** /user/sso/consistent-domain-names |  |

<a id="userssoconsistentdomainnamesdndndelete"></a>
# **UserSsoConsistentDomainNamesDnDNDelete**
> ApiStatus UserSsoConsistentDomainNamesDnDNDelete (string DN)



Delete consistent domain name .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesDnDNDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var DN = "\"dc=mydomain,dc=com\"";  // string | User domain name use - DN. (default to "dc=mydomain,dc=com")

            try
            {
                ApiStatus result = apiInstance.UserSsoConsistentDomainNamesDnDNDelete(DN);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesDnDNDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoConsistentDomainNamesDnDNDeleteWithHttpInfo(DN);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **DN** | **string** | User domain name use - DN. | [default to &quot;dc&#x3D;mydomain,dc&#x3D;com&quot;] |

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

<a id="userssoconsistentdomainnamesdndnget"></a>
# **UserSsoConsistentDomainNamesDnDNGet**
> UserSsoConsistentDomainNameCollection UserSsoConsistentDomainNamesDnDNGet (string DN)



Retrieve consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesDnDNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var DN = "\"dc=mydomain,dc=com\"";  // string | User domain name use - DN. (default to "dc=mydomain,dc=com")

            try
            {
                UserSsoConsistentDomainNameCollection result = apiInstance.UserSsoConsistentDomainNamesDnDNGet(DN);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesDnDNGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoConsistentDomainNameCollection> response = apiInstance.UserSsoConsistentDomainNamesDnDNGetWithHttpInfo(DN);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **DN** | **string** | User domain name use - DN. | [default to &quot;dc&#x3D;mydomain,dc&#x3D;com&quot;] |

### Return type

[**UserSsoConsistentDomainNameCollection**](UserSsoConsistentDomainNameCollection.md)

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

<a id="userssoconsistentdomainnamesdndnpatch"></a>
# **UserSsoConsistentDomainNamesDnDNPatch**
> ApiStatus UserSsoConsistentDomainNamesDnDNPatch (string DN, UserSsoConsistentDomainNameCollection? userSsoConsistentDomainNameCollection = null)



Patch consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesDnDNPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var DN = "\"dc=mydomain,dc=com\"";  // string | User domain name use - DN. (default to "dc=mydomain,dc=com")
            var userSsoConsistentDomainNameCollection = new UserSsoConsistentDomainNameCollection?(); // UserSsoConsistentDomainNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoConsistentDomainNamesDnDNPatch(DN, userSsoConsistentDomainNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesDnDNPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoConsistentDomainNamesDnDNPatchWithHttpInfo(DN, userSsoConsistentDomainNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **DN** | **string** | User domain name use - DN. | [default to &quot;dc&#x3D;mydomain,dc&#x3D;com&quot;] |
| **userSsoConsistentDomainNameCollection** | [**UserSsoConsistentDomainNameCollection?**](UserSsoConsistentDomainNameCollection?.md) |  | [optional]  |

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

<a id="userssoconsistentdomainnamesdndnput"></a>
# **UserSsoConsistentDomainNamesDnDNPut**
> ApiStatus UserSsoConsistentDomainNamesDnDNPut (string DN, UserSsoConsistentDomainNameCollection? userSsoConsistentDomainNameCollection = null)



Update consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesDnDNPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var DN = "\"dc=mydomain,dc=com\"";  // string | User domain name use - DN. (default to "dc=mydomain,dc=com")
            var userSsoConsistentDomainNameCollection = new UserSsoConsistentDomainNameCollection?(); // UserSsoConsistentDomainNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoConsistentDomainNamesDnDNPut(DN, userSsoConsistentDomainNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesDnDNPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoConsistentDomainNamesDnDNPutWithHttpInfo(DN, userSsoConsistentDomainNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesDnDNPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **DN** | **string** | User domain name use - DN. | [default to &quot;dc&#x3D;mydomain,dc&#x3D;com&quot;] |
| **userSsoConsistentDomainNameCollection** | [**UserSsoConsistentDomainNameCollection?**](UserSsoConsistentDomainNameCollection?.md) |  | [optional]  |

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

<a id="userssoconsistentdomainnamesget"></a>
# **UserSsoConsistentDomainNamesGet**
> UserSsoConsistentDomainNameCollection UserSsoConsistentDomainNamesGet ()



Retrieve consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);

            try
            {
                UserSsoConsistentDomainNameCollection result = apiInstance.UserSsoConsistentDomainNamesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoConsistentDomainNameCollection> response = apiInstance.UserSsoConsistentDomainNamesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoConsistentDomainNameCollection**](UserSsoConsistentDomainNameCollection.md)

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

<a id="userssoconsistentdomainnamespatch"></a>
# **UserSsoConsistentDomainNamesPatch**
> ApiStatus UserSsoConsistentDomainNamesPatch (UserSsoConsistentDomainNameCollection? userSsoConsistentDomainNameCollection = null)



Patch consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var userSsoConsistentDomainNameCollection = new UserSsoConsistentDomainNameCollection?(); // UserSsoConsistentDomainNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoConsistentDomainNamesPatch(userSsoConsistentDomainNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoConsistentDomainNamesPatchWithHttpInfo(userSsoConsistentDomainNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoConsistentDomainNameCollection** | [**UserSsoConsistentDomainNameCollection?**](UserSsoConsistentDomainNameCollection?.md) |  | [optional]  |

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

<a id="userssoconsistentdomainnamespost"></a>
# **UserSsoConsistentDomainNamesPost**
> ApiStatus UserSsoConsistentDomainNamesPost (UserSsoConsistentDomainNameCollection? userSsoConsistentDomainNameCollection = null)



Create consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var userSsoConsistentDomainNameCollection = new UserSsoConsistentDomainNameCollection?(); // UserSsoConsistentDomainNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoConsistentDomainNamesPost(userSsoConsistentDomainNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoConsistentDomainNamesPostWithHttpInfo(userSsoConsistentDomainNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoConsistentDomainNameCollection** | [**UserSsoConsistentDomainNameCollection?**](UserSsoConsistentDomainNameCollection?.md) |  | [optional]  |

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

<a id="userssoconsistentdomainnamesput"></a>
# **UserSsoConsistentDomainNamesPut**
> ApiStatus UserSsoConsistentDomainNamesPut (UserSsoConsistentDomainNameCollection? userSsoConsistentDomainNameCollection = null)



Update consistent domain name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoConsistentDomainNamesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoConsistentDomainNameApi(config);
            var userSsoConsistentDomainNameCollection = new UserSsoConsistentDomainNameCollection?(); // UserSsoConsistentDomainNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoConsistentDomainNamesPut(userSsoConsistentDomainNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoConsistentDomainNamesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoConsistentDomainNamesPutWithHttpInfo(userSsoConsistentDomainNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoConsistentDomainNameApi.UserSsoConsistentDomainNamesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoConsistentDomainNameCollection** | [**UserSsoConsistentDomainNameCollection?**](UserSsoConsistentDomainNameCollection?.md) |  | [optional]  |

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

