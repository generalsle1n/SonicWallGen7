# SonicWallGen7.Api.UserSsoTerminalServicesAgentApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoTerminalServicesAgentsGet**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentsget) | **GET** /user/sso/terminal-services-agents |  |
| [**UserSsoTerminalServicesAgentsNameNAMEDelete**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentsnamenamedelete) | **DELETE** /user/sso/terminal-services-agents/name/{NAME} |  |
| [**UserSsoTerminalServicesAgentsNameNAMEGet**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentsnamenameget) | **GET** /user/sso/terminal-services-agents/name/{NAME} |  |
| [**UserSsoTerminalServicesAgentsNameNAMEPatch**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentsnamenamepatch) | **PATCH** /user/sso/terminal-services-agents/name/{NAME} |  |
| [**UserSsoTerminalServicesAgentsNameNAMEPut**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentsnamenameput) | **PUT** /user/sso/terminal-services-agents/name/{NAME} |  |
| [**UserSsoTerminalServicesAgentsPatch**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentspatch) | **PATCH** /user/sso/terminal-services-agents |  |
| [**UserSsoTerminalServicesAgentsPost**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentspost) | **POST** /user/sso/terminal-services-agents |  |
| [**UserSsoTerminalServicesAgentsPut**](UserSsoTerminalServicesAgentApi.md#userssoterminalservicesagentsput) | **PUT** /user/sso/terminal-services-agents |  |

<a id="userssoterminalservicesagentsget"></a>
# **UserSsoTerminalServicesAgentsGet**
> UserSsoTerminalServicesAgentCollection UserSsoTerminalServicesAgentsGet ()



Retrieve user SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoTerminalServicesAgentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);

            try
            {
                UserSsoTerminalServicesAgentCollection result = apiInstance.UserSsoTerminalServicesAgentsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoTerminalServicesAgentCollection> response = apiInstance.UserSsoTerminalServicesAgentsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoTerminalServicesAgentCollection**](UserSsoTerminalServicesAgentCollection.md)

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

<a id="userssoterminalservicesagentsnamenamedelete"></a>
# **UserSsoTerminalServicesAgentsNameNAMEDelete**
> ApiStatus UserSsoTerminalServicesAgentsNameNAMEDelete (string NAME)



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
    public class UserSsoTerminalServicesAgentsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var NAME = "\"SSO-Terminal-Services-Agent\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "SSO-Terminal-Services-Agent")

            try
            {
                ApiStatus result = apiInstance.UserSsoTerminalServicesAgentsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoTerminalServicesAgentsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;SSO-Terminal-Services-Agent&quot;] |

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

<a id="userssoterminalservicesagentsnamenameget"></a>
# **UserSsoTerminalServicesAgentsNameNAMEGet**
> UserSsoTerminalServicesAgentCollection UserSsoTerminalServicesAgentsNameNAMEGet (string NAME)



Retrieve user SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoTerminalServicesAgentsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var NAME = "\"SSO-Terminal-Services-Agent\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "SSO-Terminal-Services-Agent")

            try
            {
                UserSsoTerminalServicesAgentCollection result = apiInstance.UserSsoTerminalServicesAgentsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoTerminalServicesAgentCollection> response = apiInstance.UserSsoTerminalServicesAgentsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;SSO-Terminal-Services-Agent&quot;] |

### Return type

[**UserSsoTerminalServicesAgentCollection**](UserSsoTerminalServicesAgentCollection.md)

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

<a id="userssoterminalservicesagentsnamenamepatch"></a>
# **UserSsoTerminalServicesAgentsNameNAMEPatch**
> ApiStatus UserSsoTerminalServicesAgentsNameNAMEPatch (string NAME, UserSsoTerminalServicesAgentCollection? userSsoTerminalServicesAgentCollection = null)



Patch user SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoTerminalServicesAgentsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var NAME = "\"SSO-Terminal-Services-Agent\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "SSO-Terminal-Services-Agent")
            var userSsoTerminalServicesAgentCollection = new UserSsoTerminalServicesAgentCollection?(); // UserSsoTerminalServicesAgentCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoTerminalServicesAgentsNameNAMEPatch(NAME, userSsoTerminalServicesAgentCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoTerminalServicesAgentsNameNAMEPatchWithHttpInfo(NAME, userSsoTerminalServicesAgentCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;SSO-Terminal-Services-Agent&quot;] |
| **userSsoTerminalServicesAgentCollection** | [**UserSsoTerminalServicesAgentCollection?**](UserSsoTerminalServicesAgentCollection?.md) |  | [optional]  |

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

<a id="userssoterminalservicesagentsnamenameput"></a>
# **UserSsoTerminalServicesAgentsNameNAMEPut**
> ApiStatus UserSsoTerminalServicesAgentsNameNAMEPut (string NAME, UserSsoTerminalServicesAgentCollection? userSsoTerminalServicesAgentCollection = null)



Update user SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoTerminalServicesAgentsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var NAME = "\"SSO-Terminal-Services-Agent\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "SSO-Terminal-Services-Agent")
            var userSsoTerminalServicesAgentCollection = new UserSsoTerminalServicesAgentCollection?(); // UserSsoTerminalServicesAgentCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoTerminalServicesAgentsNameNAMEPut(NAME, userSsoTerminalServicesAgentCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoTerminalServicesAgentsNameNAMEPutWithHttpInfo(NAME, userSsoTerminalServicesAgentCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;SSO-Terminal-Services-Agent&quot;] |
| **userSsoTerminalServicesAgentCollection** | [**UserSsoTerminalServicesAgentCollection?**](UserSsoTerminalServicesAgentCollection?.md) |  | [optional]  |

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

<a id="userssoterminalservicesagentspatch"></a>
# **UserSsoTerminalServicesAgentsPatch**
> ApiStatus UserSsoTerminalServicesAgentsPatch (UserSsoTerminalServicesAgentCollection? userSsoTerminalServicesAgentCollection = null)



Patch user SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoTerminalServicesAgentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var userSsoTerminalServicesAgentCollection = new UserSsoTerminalServicesAgentCollection?(); // UserSsoTerminalServicesAgentCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoTerminalServicesAgentsPatch(userSsoTerminalServicesAgentCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoTerminalServicesAgentsPatchWithHttpInfo(userSsoTerminalServicesAgentCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoTerminalServicesAgentCollection** | [**UserSsoTerminalServicesAgentCollection?**](UserSsoTerminalServicesAgentCollection?.md) |  | [optional]  |

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

<a id="userssoterminalservicesagentspost"></a>
# **UserSsoTerminalServicesAgentsPost**
> ApiStatus UserSsoTerminalServicesAgentsPost (UserSsoTerminalServicesAgentCollection? userSsoTerminalServicesAgentCollection = null)



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
    public class UserSsoTerminalServicesAgentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var userSsoTerminalServicesAgentCollection = new UserSsoTerminalServicesAgentCollection?(); // UserSsoTerminalServicesAgentCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoTerminalServicesAgentsPost(userSsoTerminalServicesAgentCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoTerminalServicesAgentsPostWithHttpInfo(userSsoTerminalServicesAgentCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoTerminalServicesAgentCollection** | [**UserSsoTerminalServicesAgentCollection?**](UserSsoTerminalServicesAgentCollection?.md) |  | [optional]  |

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

<a id="userssoterminalservicesagentsput"></a>
# **UserSsoTerminalServicesAgentsPut**
> ApiStatus UserSsoTerminalServicesAgentsPut (UserSsoTerminalServicesAgentCollection? userSsoTerminalServicesAgentCollection = null)



Update user SSO agent configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoTerminalServicesAgentsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoTerminalServicesAgentApi(config);
            var userSsoTerminalServicesAgentCollection = new UserSsoTerminalServicesAgentCollection?(); // UserSsoTerminalServicesAgentCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoTerminalServicesAgentsPut(userSsoTerminalServicesAgentCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoTerminalServicesAgentsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoTerminalServicesAgentsPutWithHttpInfo(userSsoTerminalServicesAgentCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoTerminalServicesAgentApi.UserSsoTerminalServicesAgentsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoTerminalServicesAgentCollection** | [**UserSsoTerminalServicesAgentCollection?**](UserSsoTerminalServicesAgentCollection?.md) |  | [optional]  |

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

