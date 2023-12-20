# SonicWallGen7.Api.DiagAdvancedUserAuthenticationKillAllInactiveUsersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPost**](DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.md#diagadvanceduserauthenticationkillallinactiveusersallpost) | **POST** /diag/advanced/user-authentication/kill-all-inactive-users/all |  |
| [**DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPost**](DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.md#diagadvanceduserauthenticationkillallinactiveusersntlmpost) | **POST** /diag/advanced/user-authentication/kill-all-inactive-users/ntlm |  |
| [**DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPost**](DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.md#diagadvanceduserauthenticationkillallinactiveusersradacctpost) | **POST** /diag/advanced/user-authentication/kill-all-inactive-users/rad-acct |  |
| [**DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPost**](DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.md#diagadvanceduserauthenticationkillallinactiveusersssoagentpost) | **POST** /diag/advanced/user-authentication/kill-all-inactive-users/sso-agent |  |
| [**DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPost**](DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.md#diagadvanceduserauthenticationkillallinactiveuserstsapost) | **POST** /diag/advanced/user-authentication/kill-all-inactive-users/tsa |  |

<a id="diagadvanceduserauthenticationkillallinactiveusersallpost"></a>
# **DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPost**
> ApiStatus DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPost (Object? body = null)



Advanced diag user authentication kill all inactive users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationKillAllInactiveUsersApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersAllPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

<a id="diagadvanceduserauthenticationkillallinactiveusersntlmpost"></a>
# **DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPost**
> ApiStatus DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPost (Object? body = null)



Advanced diag user authentication kill all inactive users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationKillAllInactiveUsersApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersNtlmPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

<a id="diagadvanceduserauthenticationkillallinactiveusersradacctpost"></a>
# **DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPost**
> ApiStatus DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPost (Object? body = null)



Advanced diag user authentication kill all inactive users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationKillAllInactiveUsersApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersRadAcctPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

<a id="diagadvanceduserauthenticationkillallinactiveusersssoagentpost"></a>
# **DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPost**
> ApiStatus DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPost (Object? body = null)



Advanced diag user authentication kill all inactive users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationKillAllInactiveUsersApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersSsoAgentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

<a id="diagadvanceduserauthenticationkillallinactiveuserstsapost"></a>
# **DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPost**
> ApiStatus DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPost (Object? body = null)



Advanced diag user authentication kill all inactive users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationKillAllInactiveUsersApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationKillAllInactiveUsersApi.DiagAdvancedUserAuthenticationKillAllInactiveUsersTsaPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

