# SonicWallGen7.Api.UserSsoWindowsServiceUserNameApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoWindowsServiceUserNamesGet**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamesget) | **GET** /user/sso/windows-service-user-names |  |
| [**UserSsoWindowsServiceUserNamesNameNAMEDelete**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamesnamenamedelete) | **DELETE** /user/sso/windows-service-user-names/name/{NAME} |  |
| [**UserSsoWindowsServiceUserNamesNameNAMEGet**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamesnamenameget) | **GET** /user/sso/windows-service-user-names/name/{NAME} |  |
| [**UserSsoWindowsServiceUserNamesNameNAMEPatch**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamesnamenamepatch) | **PATCH** /user/sso/windows-service-user-names/name/{NAME} |  |
| [**UserSsoWindowsServiceUserNamesNameNAMEPut**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamesnamenameput) | **PUT** /user/sso/windows-service-user-names/name/{NAME} |  |
| [**UserSsoWindowsServiceUserNamesPatch**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamespatch) | **PATCH** /user/sso/windows-service-user-names |  |
| [**UserSsoWindowsServiceUserNamesPost**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamespost) | **POST** /user/sso/windows-service-user-names |  |
| [**UserSsoWindowsServiceUserNamesPut**](UserSsoWindowsServiceUserNameApi.md#userssowindowsserviceusernamesput) | **PUT** /user/sso/windows-service-user-names |  |

<a id="userssowindowsserviceusernamesget"></a>
# **UserSsoWindowsServiceUserNamesGet**
> UserSsoWindowsServiceUserNameCollection UserSsoWindowsServiceUserNamesGet ()



Retrieve user SSO Windows service user name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);

            try
            {
                UserSsoWindowsServiceUserNameCollection result = apiInstance.UserSsoWindowsServiceUserNamesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoWindowsServiceUserNameCollection> response = apiInstance.UserSsoWindowsServiceUserNamesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoWindowsServiceUserNameCollection**](UserSsoWindowsServiceUserNameCollection.md)

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

<a id="userssowindowsserviceusernamesnamenamedelete"></a>
# **UserSsoWindowsServiceUserNamesNameNAMEDelete**
> ApiStatus UserSsoWindowsServiceUserNamesNameNAMEDelete (string NAME)



DELETE SSO Windows service user name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var NAME = "\"abc\"";  // string | The login name of a windows service. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | The login name of a windows service. | [default to &quot;abc&quot;] |

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

<a id="userssowindowsserviceusernamesnamenameget"></a>
# **UserSsoWindowsServiceUserNamesNameNAMEGet**
> UserSsoWindowsServiceUserNameCollection UserSsoWindowsServiceUserNamesNameNAMEGet (string NAME)



Retrieve user SSO Windows service user name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var NAME = "\"abc\"";  // string | The login name of a windows service. (default to "abc")

            try
            {
                UserSsoWindowsServiceUserNameCollection result = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoWindowsServiceUserNameCollection> response = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | The login name of a windows service. | [default to &quot;abc&quot;] |

### Return type

[**UserSsoWindowsServiceUserNameCollection**](UserSsoWindowsServiceUserNameCollection.md)

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

<a id="userssowindowsserviceusernamesnamenamepatch"></a>
# **UserSsoWindowsServiceUserNamesNameNAMEPatch**
> ApiStatus UserSsoWindowsServiceUserNamesNameNAMEPatch (string NAME, UserSsoWindowsServiceUserNameCollection? userSsoWindowsServiceUserNameCollection = null)



Patch user SSO Windows service user name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var NAME = "\"abc\"";  // string | The login name of a windows service. (default to "abc")
            var userSsoWindowsServiceUserNameCollection = new UserSsoWindowsServiceUserNameCollection?(); // UserSsoWindowsServiceUserNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEPatch(NAME, userSsoWindowsServiceUserNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEPatchWithHttpInfo(NAME, userSsoWindowsServiceUserNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | The login name of a windows service. | [default to &quot;abc&quot;] |
| **userSsoWindowsServiceUserNameCollection** | [**UserSsoWindowsServiceUserNameCollection?**](UserSsoWindowsServiceUserNameCollection?.md) |  | [optional]  |

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

<a id="userssowindowsserviceusernamesnamenameput"></a>
# **UserSsoWindowsServiceUserNamesNameNAMEPut**
> ApiStatus UserSsoWindowsServiceUserNamesNameNAMEPut (string NAME, UserSsoWindowsServiceUserNameCollection? userSsoWindowsServiceUserNameCollection = null)



Update user SSO Windows service user name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var NAME = "\"abc\"";  // string | The login name of a windows service. (default to "abc")
            var userSsoWindowsServiceUserNameCollection = new UserSsoWindowsServiceUserNameCollection?(); // UserSsoWindowsServiceUserNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEPut(NAME, userSsoWindowsServiceUserNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoWindowsServiceUserNamesNameNAMEPutWithHttpInfo(NAME, userSsoWindowsServiceUserNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | The login name of a windows service. | [default to &quot;abc&quot;] |
| **userSsoWindowsServiceUserNameCollection** | [**UserSsoWindowsServiceUserNameCollection?**](UserSsoWindowsServiceUserNameCollection?.md) |  | [optional]  |

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

<a id="userssowindowsserviceusernamespatch"></a>
# **UserSsoWindowsServiceUserNamesPatch**
> ApiStatus UserSsoWindowsServiceUserNamesPatch (UserSsoWindowsServiceUserNameCollection? userSsoWindowsServiceUserNameCollection = null)



Patch user SSO Windows service user name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var userSsoWindowsServiceUserNameCollection = new UserSsoWindowsServiceUserNameCollection?(); // UserSsoWindowsServiceUserNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoWindowsServiceUserNamesPatch(userSsoWindowsServiceUserNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoWindowsServiceUserNamesPatchWithHttpInfo(userSsoWindowsServiceUserNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoWindowsServiceUserNameCollection** | [**UserSsoWindowsServiceUserNameCollection?**](UserSsoWindowsServiceUserNameCollection?.md) |  | [optional]  |

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

<a id="userssowindowsserviceusernamespost"></a>
# **UserSsoWindowsServiceUserNamesPost**
> ApiStatus UserSsoWindowsServiceUserNamesPost (UserSsoWindowsServiceUserNameCollection? userSsoWindowsServiceUserNameCollection = null)



Create user SSO Windows service user name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var userSsoWindowsServiceUserNameCollection = new UserSsoWindowsServiceUserNameCollection?(); // UserSsoWindowsServiceUserNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoWindowsServiceUserNamesPost(userSsoWindowsServiceUserNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoWindowsServiceUserNamesPostWithHttpInfo(userSsoWindowsServiceUserNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoWindowsServiceUserNameCollection** | [**UserSsoWindowsServiceUserNameCollection?**](UserSsoWindowsServiceUserNameCollection?.md) |  | [optional]  |

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

<a id="userssowindowsserviceusernamesput"></a>
# **UserSsoWindowsServiceUserNamesPut**
> ApiStatus UserSsoWindowsServiceUserNamesPut (UserSsoWindowsServiceUserNameCollection? userSsoWindowsServiceUserNameCollection = null)



Update user SSO Windows service user name configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoWindowsServiceUserNamesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoWindowsServiceUserNameApi(config);
            var userSsoWindowsServiceUserNameCollection = new UserSsoWindowsServiceUserNameCollection?(); // UserSsoWindowsServiceUserNameCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoWindowsServiceUserNamesPut(userSsoWindowsServiceUserNameCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoWindowsServiceUserNamesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoWindowsServiceUserNamesPutWithHttpInfo(userSsoWindowsServiceUserNameCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoWindowsServiceUserNameApi.UserSsoWindowsServiceUserNamesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoWindowsServiceUserNameCollection** | [**UserSsoWindowsServiceUserNameCollection?**](UserSsoWindowsServiceUserNameCollection?.md) |  | [optional]  |

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

