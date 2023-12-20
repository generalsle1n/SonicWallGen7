# SonicWallGen7.Api.UserSso3rdPartyApiClientApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoThirdPartyApiClientsGet**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientsget) | **GET** /user/sso/third-party-api/clients |  |
| [**UserSsoThirdPartyApiClientsNameNAMEDelete**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientsnamenamedelete) | **DELETE** /user/sso/third-party-api/clients/name/{NAME} |  |
| [**UserSsoThirdPartyApiClientsNameNAMEGet**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientsnamenameget) | **GET** /user/sso/third-party-api/clients/name/{NAME} |  |
| [**UserSsoThirdPartyApiClientsNameNAMEPatch**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientsnamenamepatch) | **PATCH** /user/sso/third-party-api/clients/name/{NAME} |  |
| [**UserSsoThirdPartyApiClientsNameNAMEPut**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientsnamenameput) | **PUT** /user/sso/third-party-api/clients/name/{NAME} |  |
| [**UserSsoThirdPartyApiClientsPatch**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientspatch) | **PATCH** /user/sso/third-party-api/clients |  |
| [**UserSsoThirdPartyApiClientsPost**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientspost) | **POST** /user/sso/third-party-api/clients |  |
| [**UserSsoThirdPartyApiClientsPut**](UserSso3rdPartyApiClientApi.md#userssothirdpartyapiclientsput) | **PUT** /user/sso/third-party-api/clients |  |

<a id="userssothirdpartyapiclientsget"></a>
# **UserSsoThirdPartyApiClientsGet**
> UserSso3rdPartyApiClientCollection UserSsoThirdPartyApiClientsGet ()



Retrieve 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);

            try
            {
                UserSso3rdPartyApiClientCollection result = apiInstance.UserSsoThirdPartyApiClientsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSso3rdPartyApiClientCollection> response = apiInstance.UserSsoThirdPartyApiClientsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSso3rdPartyApiClientCollection**](UserSso3rdPartyApiClientCollection.md)

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

<a id="userssothirdpartyapiclientsnamenamedelete"></a>
# **UserSsoThirdPartyApiClientsNameNAMEDelete**
> ApiStatus UserSsoThirdPartyApiClientsNameNAMEDelete (string NAME)



Delete 3rd party api client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiClientsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiClientsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |

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

<a id="userssothirdpartyapiclientsnamenameget"></a>
# **UserSsoThirdPartyApiClientsNameNAMEGet**
> UserSso3rdPartyApiClientCollection UserSsoThirdPartyApiClientsNameNAMEGet (string NAME)



Retrieve 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")

            try
            {
                UserSso3rdPartyApiClientCollection result = apiInstance.UserSsoThirdPartyApiClientsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSso3rdPartyApiClientCollection> response = apiInstance.UserSsoThirdPartyApiClientsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |

### Return type

[**UserSso3rdPartyApiClientCollection**](UserSso3rdPartyApiClientCollection.md)

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

<a id="userssothirdpartyapiclientsnamenamepatch"></a>
# **UserSsoThirdPartyApiClientsNameNAMEPatch**
> ApiStatus UserSsoThirdPartyApiClientsNameNAMEPatch (string NAME, UserSso3rdPartyApiClientCollection? userSso3rdPartyApiClientCollection = null)



Patch 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")
            var userSso3rdPartyApiClientCollection = new UserSso3rdPartyApiClientCollection?(); // UserSso3rdPartyApiClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiClientsNameNAMEPatch(NAME, userSso3rdPartyApiClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiClientsNameNAMEPatchWithHttpInfo(NAME, userSso3rdPartyApiClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |
| **userSso3rdPartyApiClientCollection** | [**UserSso3rdPartyApiClientCollection?**](UserSso3rdPartyApiClientCollection?.md) |  | [optional]  |

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

<a id="userssothirdpartyapiclientsnamenameput"></a>
# **UserSsoThirdPartyApiClientsNameNAMEPut**
> ApiStatus UserSsoThirdPartyApiClientsNameNAMEPut (string NAME, UserSso3rdPartyApiClientCollection? userSso3rdPartyApiClientCollection = null)



Update 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")
            var userSso3rdPartyApiClientCollection = new UserSso3rdPartyApiClientCollection?(); // UserSso3rdPartyApiClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiClientsNameNAMEPut(NAME, userSso3rdPartyApiClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiClientsNameNAMEPutWithHttpInfo(NAME, userSso3rdPartyApiClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |
| **userSso3rdPartyApiClientCollection** | [**UserSso3rdPartyApiClientCollection?**](UserSso3rdPartyApiClientCollection?.md) |  | [optional]  |

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

<a id="userssothirdpartyapiclientspatch"></a>
# **UserSsoThirdPartyApiClientsPatch**
> ApiStatus UserSsoThirdPartyApiClientsPatch (UserSso3rdPartyApiClientCollection? userSso3rdPartyApiClientCollection = null)



Patch 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var userSso3rdPartyApiClientCollection = new UserSso3rdPartyApiClientCollection?(); // UserSso3rdPartyApiClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiClientsPatch(userSso3rdPartyApiClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiClientsPatchWithHttpInfo(userSso3rdPartyApiClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSso3rdPartyApiClientCollection** | [**UserSso3rdPartyApiClientCollection?**](UserSso3rdPartyApiClientCollection?.md) |  | [optional]  |

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

<a id="userssothirdpartyapiclientspost"></a>
# **UserSsoThirdPartyApiClientsPost**
> ApiStatus UserSsoThirdPartyApiClientsPost (UserSso3rdPartyApiClientCollection? userSso3rdPartyApiClientCollection = null)



Create 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var userSso3rdPartyApiClientCollection = new UserSso3rdPartyApiClientCollection?(); // UserSso3rdPartyApiClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiClientsPost(userSso3rdPartyApiClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiClientsPostWithHttpInfo(userSso3rdPartyApiClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSso3rdPartyApiClientCollection** | [**UserSso3rdPartyApiClientCollection?**](UserSso3rdPartyApiClientCollection?.md) |  | [optional]  |

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

<a id="userssothirdpartyapiclientsput"></a>
# **UserSsoThirdPartyApiClientsPut**
> ApiStatus UserSsoThirdPartyApiClientsPut (UserSso3rdPartyApiClientCollection? userSso3rdPartyApiClientCollection = null)



Update 3rd party api client configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoThirdPartyApiClientsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSso3rdPartyApiClientApi(config);
            var userSso3rdPartyApiClientCollection = new UserSso3rdPartyApiClientCollection?(); // UserSso3rdPartyApiClientCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoThirdPartyApiClientsPut(userSso3rdPartyApiClientCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoThirdPartyApiClientsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoThirdPartyApiClientsPutWithHttpInfo(userSso3rdPartyApiClientCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSso3rdPartyApiClientApi.UserSsoThirdPartyApiClientsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSso3rdPartyApiClientCollection** | [**UserSso3rdPartyApiClientCollection?**](UserSso3rdPartyApiClientCollection?.md) |  | [optional]  |

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

