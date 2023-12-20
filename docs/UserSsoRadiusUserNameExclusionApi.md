# SonicWallGen7.Api.UserSsoRadiusUserNameExclusionApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoRadiusUserNameExclusionsGet**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionsget) | **GET** /user/sso/radius-user-name-exclusions |  |
| [**UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDelete**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionsnamenametypetypedelete) | **DELETE** /user/sso/radius-user-name-exclusions/name/{NAME}/type/{TYPE} |  |
| [**UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGet**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionsnamenametypetypeget) | **GET** /user/sso/radius-user-name-exclusions/name/{NAME}/type/{TYPE} |  |
| [**UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatch**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionsnamenametypetypepatch) | **PATCH** /user/sso/radius-user-name-exclusions/name/{NAME}/type/{TYPE} |  |
| [**UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPut**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionsnamenametypetypeput) | **PUT** /user/sso/radius-user-name-exclusions/name/{NAME}/type/{TYPE} |  |
| [**UserSsoRadiusUserNameExclusionsPatch**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionspatch) | **PATCH** /user/sso/radius-user-name-exclusions |  |
| [**UserSsoRadiusUserNameExclusionsPost**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionspost) | **POST** /user/sso/radius-user-name-exclusions |  |
| [**UserSsoRadiusUserNameExclusionsPut**](UserSsoRadiusUserNameExclusionApi.md#userssoradiususernameexclusionsput) | **PUT** /user/sso/radius-user-name-exclusions |  |

<a id="userssoradiususernameexclusionsget"></a>
# **UserSsoRadiusUserNameExclusionsGet**
> UserSsoRadiusUserNameExclusionCollection UserSsoRadiusUserNameExclusionsGet ()



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
    public class UserSsoRadiusUserNameExclusionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);

            try
            {
                UserSsoRadiusUserNameExclusionCollection result = apiInstance.UserSsoRadiusUserNameExclusionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoRadiusUserNameExclusionCollection> response = apiInstance.UserSsoRadiusUserNameExclusionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoRadiusUserNameExclusionCollection**](UserSsoRadiusUserNameExclusionCollection.md)

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

<a id="userssoradiususernameexclusionsnamenametypetypedelete"></a>
# **UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDelete**
> ApiStatus UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDelete (string NAME, string TYPE)



DELETE RADIUS accounting user name exclusion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TYPE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDelete(NAME, TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDeleteWithHttpInfo(NAME, TYPE);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **TYPE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="userssoradiususernameexclusionsnamenametypetypeget"></a>
# **UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGet**
> UserSsoRadiusUserNameExclusionCollection UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGet (string NAME, string TYPE)



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
    public class UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TYPE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                UserSsoRadiusUserNameExclusionCollection result = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGet(NAME, TYPE);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoRadiusUserNameExclusionCollection> response = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGetWithHttpInfo(NAME, TYPE);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **TYPE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**UserSsoRadiusUserNameExclusionCollection**](UserSsoRadiusUserNameExclusionCollection.md)

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

<a id="userssoradiususernameexclusionsnamenametypetypepatch"></a>
# **UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatch**
> ApiStatus UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatch (string NAME, string TYPE, UserSsoRadiusUserNameExclusionCollection? userSsoRadiusUserNameExclusionCollection = null)



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
    public class UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TYPE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var userSsoRadiusUserNameExclusionCollection = new UserSsoRadiusUserNameExclusionCollection?(); // UserSsoRadiusUserNameExclusionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatch(NAME, TYPE, userSsoRadiusUserNameExclusionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatchWithHttpInfo(NAME, TYPE, userSsoRadiusUserNameExclusionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **TYPE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **userSsoRadiusUserNameExclusionCollection** | [**UserSsoRadiusUserNameExclusionCollection?**](UserSsoRadiusUserNameExclusionCollection?.md) |  | [optional]  |

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

<a id="userssoradiususernameexclusionsnamenametypetypeput"></a>
# **UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPut**
> ApiStatus UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPut (string NAME, string TYPE, UserSsoRadiusUserNameExclusionCollection? userSsoRadiusUserNameExclusionCollection = null)



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
    public class UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var TYPE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var userSsoRadiusUserNameExclusionCollection = new UserSsoRadiusUserNameExclusionCollection?(); // UserSsoRadiusUserNameExclusionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPut(NAME, TYPE, userSsoRadiusUserNameExclusionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPutWithHttpInfo(NAME, TYPE, userSsoRadiusUserNameExclusionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsNameNAMETypeTYPEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **TYPE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **userSsoRadiusUserNameExclusionCollection** | [**UserSsoRadiusUserNameExclusionCollection?**](UserSsoRadiusUserNameExclusionCollection?.md) |  | [optional]  |

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

<a id="userssoradiususernameexclusionspatch"></a>
# **UserSsoRadiusUserNameExclusionsPatch**
> ApiStatus UserSsoRadiusUserNameExclusionsPatch (UserSsoRadiusUserNameExclusionCollection? userSsoRadiusUserNameExclusionCollection = null)



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
    public class UserSsoRadiusUserNameExclusionsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var userSsoRadiusUserNameExclusionCollection = new UserSsoRadiusUserNameExclusionCollection?(); // UserSsoRadiusUserNameExclusionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusUserNameExclusionsPatch(userSsoRadiusUserNameExclusionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusUserNameExclusionsPatchWithHttpInfo(userSsoRadiusUserNameExclusionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoRadiusUserNameExclusionCollection** | [**UserSsoRadiusUserNameExclusionCollection?**](UserSsoRadiusUserNameExclusionCollection?.md) |  | [optional]  |

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

<a id="userssoradiususernameexclusionspost"></a>
# **UserSsoRadiusUserNameExclusionsPost**
> ApiStatus UserSsoRadiusUserNameExclusionsPost (UserSsoRadiusUserNameExclusionCollection? userSsoRadiusUserNameExclusionCollection = null)



Add RADIUS accounting user name exclusion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoRadiusUserNameExclusionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var userSsoRadiusUserNameExclusionCollection = new UserSsoRadiusUserNameExclusionCollection?(); // UserSsoRadiusUserNameExclusionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusUserNameExclusionsPost(userSsoRadiusUserNameExclusionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusUserNameExclusionsPostWithHttpInfo(userSsoRadiusUserNameExclusionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoRadiusUserNameExclusionCollection** | [**UserSsoRadiusUserNameExclusionCollection?**](UserSsoRadiusUserNameExclusionCollection?.md) |  | [optional]  |

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

<a id="userssoradiususernameexclusionsput"></a>
# **UserSsoRadiusUserNameExclusionsPut**
> ApiStatus UserSsoRadiusUserNameExclusionsPut (UserSsoRadiusUserNameExclusionCollection? userSsoRadiusUserNameExclusionCollection = null)



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
    public class UserSsoRadiusUserNameExclusionsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoRadiusUserNameExclusionApi(config);
            var userSsoRadiusUserNameExclusionCollection = new UserSsoRadiusUserNameExclusionCollection?(); // UserSsoRadiusUserNameExclusionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoRadiusUserNameExclusionsPut(userSsoRadiusUserNameExclusionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoRadiusUserNameExclusionsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoRadiusUserNameExclusionsPutWithHttpInfo(userSsoRadiusUserNameExclusionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoRadiusUserNameExclusionApi.UserSsoRadiusUserNameExclusionsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoRadiusUserNameExclusionCollection** | [**UserSsoRadiusUserNameExclusionCollection?**](UserSsoRadiusUserNameExclusionCollection?.md) |  | [optional]  |

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

