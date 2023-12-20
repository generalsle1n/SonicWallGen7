# SonicWallGen7.Api.UserSsoRadiusAccountingClientApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoRadiusAccountingClientsGet**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientsget) | **GET** /user/sso/radius-accounting-clients |  |
| [**UserSsoRadiusAccountingClientsNameNAMEDelete**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientsnamenamedelete) | **DELETE** /user/sso/radius-accounting-clients/name/{NAME} |  |
| [**UserSsoRadiusAccountingClientsNameNAMEGet**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientsnamenameget) | **GET** /user/sso/radius-accounting-clients/name/{NAME} |  |
| [**UserSsoRadiusAccountingClientsNameNAMEPatch**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientsnamenamepatch) | **PATCH** /user/sso/radius-accounting-clients/name/{NAME} |  |
| [**UserSsoRadiusAccountingClientsNameNAMEPut**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientsnamenameput) | **PUT** /user/sso/radius-accounting-clients/name/{NAME} |  |
| [**UserSsoRadiusAccountingClientsPatch**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientspatch) | **PATCH** /user/sso/radius-accounting-clients |  |
| [**UserSsoRadiusAccountingClientsPost**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientspost) | **POST** /user/sso/radius-accounting-clients |  |
| [**UserSsoRadiusAccountingClientsPut**](UserSsoRadiusAccountingClientApi.md#userssoradiusaccountingclientsput) | **PUT** /user/sso/radius-accounting-clients |  |

<a id="userssoradiusaccountingclientsget"></a>
# **UserSsoRadiusAccountingClientsGet**
> UserSsoRadiusAccountingClientCollection UserSsoRadiusAccountingClientsGet ()



Retrieve user SSO configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);

            try
            {
                UserSsoRadiusAccountingClientCollection result = apiInstance.UserSsoRadiusAccountingClientsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoRadiusAccountingClientCollection> response = apiInstance.UserSsoRadiusAccountingClientsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoRadiusAccountingClientCollection**](UserSsoRadiusAccountingClientCollection.md)

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

<a id="userssoradiusaccountingclientsnamenamedelete"></a>
# **UserSsoRadiusAccountingClientsNameNAMEDelete**
> ApiStatus UserSsoRadiusAccountingClientsNameNAMEDelete (string NAME)



DELETE SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var NAME = "\"example.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "example.com")

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusAccountingClientsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusAccountingClientsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;example.com&quot;] |

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

<a id="userssoradiusaccountingclientsnamenameget"></a>
# **UserSsoRadiusAccountingClientsNameNAMEGet**
> UserSsoRadiusAccountingClientCollection UserSsoRadiusAccountingClientsNameNAMEGet (string NAME)



Retrieve user SSO configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var NAME = "\"example.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "example.com")

            try
            {
                UserSsoRadiusAccountingClientCollection result = apiInstance.UserSsoRadiusAccountingClientsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoRadiusAccountingClientCollection> response = apiInstance.UserSsoRadiusAccountingClientsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;example.com&quot;] |

### Return type

[**UserSsoRadiusAccountingClientCollection**](UserSsoRadiusAccountingClientCollection.md)

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

<a id="userssoradiusaccountingclientsnamenamepatch"></a>
# **UserSsoRadiusAccountingClientsNameNAMEPatch**
> ApiStatus UserSsoRadiusAccountingClientsNameNAMEPatch (string NAME, UserSsoRadiusAccountingClientCollection? userSsoRadiusAccountingClientCollection = null)



Patch user SSO configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var NAME = "\"example.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "example.com")
            var userSsoRadiusAccountingClientCollection = new UserSsoRadiusAccountingClientCollection?(); // UserSsoRadiusAccountingClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusAccountingClientsNameNAMEPatch(NAME, userSsoRadiusAccountingClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusAccountingClientsNameNAMEPatchWithHttpInfo(NAME, userSsoRadiusAccountingClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;example.com&quot;] |
| **userSsoRadiusAccountingClientCollection** | [**UserSsoRadiusAccountingClientCollection?**](UserSsoRadiusAccountingClientCollection?.md) |  | [optional]  |

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

<a id="userssoradiusaccountingclientsnamenameput"></a>
# **UserSsoRadiusAccountingClientsNameNAMEPut**
> ApiStatus UserSsoRadiusAccountingClientsNameNAMEPut (string NAME, UserSsoRadiusAccountingClientCollection? userSsoRadiusAccountingClientCollection = null)



Update user SSO configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var NAME = "\"example.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "example.com")
            var userSsoRadiusAccountingClientCollection = new UserSsoRadiusAccountingClientCollection?(); // UserSsoRadiusAccountingClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusAccountingClientsNameNAMEPut(NAME, userSsoRadiusAccountingClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusAccountingClientsNameNAMEPutWithHttpInfo(NAME, userSsoRadiusAccountingClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;example.com&quot;] |
| **userSsoRadiusAccountingClientCollection** | [**UserSsoRadiusAccountingClientCollection?**](UserSsoRadiusAccountingClientCollection?.md) |  | [optional]  |

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

<a id="userssoradiusaccountingclientspatch"></a>
# **UserSsoRadiusAccountingClientsPatch**
> ApiStatus UserSsoRadiusAccountingClientsPatch (UserSsoRadiusAccountingClientCollection? userSsoRadiusAccountingClientCollection = null)



Patch user SSO configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var userSsoRadiusAccountingClientCollection = new UserSsoRadiusAccountingClientCollection?(); // UserSsoRadiusAccountingClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusAccountingClientsPatch(userSsoRadiusAccountingClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusAccountingClientsPatchWithHttpInfo(userSsoRadiusAccountingClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoRadiusAccountingClientCollection** | [**UserSsoRadiusAccountingClientCollection?**](UserSsoRadiusAccountingClientCollection?.md) |  | [optional]  |

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

<a id="userssoradiusaccountingclientspost"></a>
# **UserSsoRadiusAccountingClientsPost**
> ApiStatus UserSsoRadiusAccountingClientsPost (UserSsoRadiusAccountingClientCollection? userSsoRadiusAccountingClientCollection = null)



Create user SSO agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var userSsoRadiusAccountingClientCollection = new UserSsoRadiusAccountingClientCollection?(); // UserSsoRadiusAccountingClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusAccountingClientsPost(userSsoRadiusAccountingClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusAccountingClientsPostWithHttpInfo(userSsoRadiusAccountingClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoRadiusAccountingClientCollection** | [**UserSsoRadiusAccountingClientCollection?**](UserSsoRadiusAccountingClientCollection?.md) |  | [optional]  |

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

<a id="userssoradiusaccountingclientsput"></a>
# **UserSsoRadiusAccountingClientsPut**
> ApiStatus UserSsoRadiusAccountingClientsPut (UserSsoRadiusAccountingClientCollection? userSsoRadiusAccountingClientCollection = null)



Update user SSO configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusAccountingClientsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusAccountingClientApi(config);
            var userSsoRadiusAccountingClientCollection = new UserSsoRadiusAccountingClientCollection?(); // UserSsoRadiusAccountingClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusAccountingClientsPut(userSsoRadiusAccountingClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusAccountingClientsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusAccountingClientsPutWithHttpInfo(userSsoRadiusAccountingClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusAccountingClientApi.UserSsoRadiusAccountingClientsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoRadiusAccountingClientCollection** | [**UserSsoRadiusAccountingClientCollection?**](UserSsoRadiusAccountingClientCollection?.md) |  | [optional]  |

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

