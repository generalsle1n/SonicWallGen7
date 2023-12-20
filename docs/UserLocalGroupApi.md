# SonicWallGen7.Api.UserLocalGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserLocalGroupsGet**](UserLocalGroupApi.md#userlocalgroupsget) | **GET** /user/local/groups |  |
| [**UserLocalGroupsNameNAMEDomainDNAMEDelete**](UserLocalGroupApi.md#userlocalgroupsnamenamedomaindnamedelete) | **DELETE** /user/local/groups/name/{NAME}/domain/{DNAME} |  |
| [**UserLocalGroupsNameNAMEDomainDNAMEGet**](UserLocalGroupApi.md#userlocalgroupsnamenamedomaindnameget) | **GET** /user/local/groups/name/{NAME}/domain/{DNAME} |  |
| [**UserLocalGroupsNameNAMEDomainDNAMEPatch**](UserLocalGroupApi.md#userlocalgroupsnamenamedomaindnamepatch) | **PATCH** /user/local/groups/name/{NAME}/domain/{DNAME} |  |
| [**UserLocalGroupsNameNAMEDomainDNAMEPut**](UserLocalGroupApi.md#userlocalgroupsnamenamedomaindnameput) | **PUT** /user/local/groups/name/{NAME}/domain/{DNAME} |  |
| [**UserLocalGroupsPatch**](UserLocalGroupApi.md#userlocalgroupspatch) | **PATCH** /user/local/groups |  |
| [**UserLocalGroupsPost**](UserLocalGroupApi.md#userlocalgroupspost) | **POST** /user/local/groups |  |
| [**UserLocalGroupsPut**](UserLocalGroupApi.md#userlocalgroupsput) | **PUT** /user/local/groups |  |
| [**UserLocalGroupsUuidUUIDDelete**](UserLocalGroupApi.md#userlocalgroupsuuiduuiddelete) | **DELETE** /user/local/groups/uuid/{UUID} |  |
| [**UserLocalGroupsUuidUUIDGet**](UserLocalGroupApi.md#userlocalgroupsuuiduuidget) | **GET** /user/local/groups/uuid/{UUID} |  |
| [**UserLocalGroupsUuidUUIDPatch**](UserLocalGroupApi.md#userlocalgroupsuuiduuidpatch) | **PATCH** /user/local/groups/uuid/{UUID} |  |
| [**UserLocalGroupsUuidUUIDPut**](UserLocalGroupApi.md#userlocalgroupsuuiduuidput) | **PUT** /user/local/groups/uuid/{UUID} |  |

<a id="userlocalgroupsget"></a>
# **UserLocalGroupsGet**
> UserLocalGroupCollection UserLocalGroupsGet ()



Retrieve user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);

            try
            {
                UserLocalGroupCollection result = apiInstance.UserLocalGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserLocalGroupCollection> response = apiInstance.UserLocalGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserLocalGroupCollection**](UserLocalGroupCollection.md)

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

<a id="userlocalgroupsnamenamedomaindnamedelete"></a>
# **UserLocalGroupsNameNAMEDomainDNAMEDelete**
> ApiStatus UserLocalGroupsNameNAMEDomainDNAMEDelete (string NAME, string DNAME)



Delete user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsNameNAMEDomainDNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var NAME = "\"Limited Administrators\"";  // string | User group object name. (default to "Limited Administrators")
            var DNAME = "\"example.com\"";  // string | User group object domain name. (default to "example.com")

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEDelete(NAME, DNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsNameNAMEDomainDNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEDeleteWithHttpInfo(NAME, DNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | User group object name. | [default to &quot;Limited Administrators&quot;] |
| **DNAME** | **string** | User group object domain name. | [default to &quot;example.com&quot;] |

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

<a id="userlocalgroupsnamenamedomaindnameget"></a>
# **UserLocalGroupsNameNAMEDomainDNAMEGet**
> UserLocalGroupCollection UserLocalGroupsNameNAMEDomainDNAMEGet (string NAME, string DNAME)



Retrieve user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsNameNAMEDomainDNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var NAME = "\"Limited Administrators\"";  // string | User group object name. (default to "Limited Administrators")
            var DNAME = "\"example.com\"";  // string | User group object domain name. (default to "example.com")

            try
            {
                UserLocalGroupCollection result = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEGet(NAME, DNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsNameNAMEDomainDNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserLocalGroupCollection> response = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEGetWithHttpInfo(NAME, DNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | User group object name. | [default to &quot;Limited Administrators&quot;] |
| **DNAME** | **string** | User group object domain name. | [default to &quot;example.com&quot;] |

### Return type

[**UserLocalGroupCollection**](UserLocalGroupCollection.md)

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

<a id="userlocalgroupsnamenamedomaindnamepatch"></a>
# **UserLocalGroupsNameNAMEDomainDNAMEPatch**
> ApiStatus UserLocalGroupsNameNAMEDomainDNAMEPatch (string NAME, string DNAME, UserLocalGroupCollection? userLocalGroupCollection = null)



Patch user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsNameNAMEDomainDNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var NAME = "\"Limited Administrators\"";  // string | User group object name. (default to "Limited Administrators")
            var DNAME = "\"example.com\"";  // string | User group object domain name. (default to "example.com")
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEPatch(NAME, DNAME, userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsNameNAMEDomainDNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEPatchWithHttpInfo(NAME, DNAME, userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | User group object name. | [default to &quot;Limited Administrators&quot;] |
| **DNAME** | **string** | User group object domain name. | [default to &quot;example.com&quot;] |
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

<a id="userlocalgroupsnamenamedomaindnameput"></a>
# **UserLocalGroupsNameNAMEDomainDNAMEPut**
> ApiStatus UserLocalGroupsNameNAMEDomainDNAMEPut (string NAME, string DNAME, UserLocalGroupCollection? userLocalGroupCollection = null)



Update user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsNameNAMEDomainDNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var NAME = "\"Limited Administrators\"";  // string | User group object name. (default to "Limited Administrators")
            var DNAME = "\"example.com\"";  // string | User group object domain name. (default to "example.com")
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEPut(NAME, DNAME, userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsNameNAMEDomainDNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsNameNAMEDomainDNAMEPutWithHttpInfo(NAME, DNAME, userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsNameNAMEDomainDNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | User group object name. | [default to &quot;Limited Administrators&quot;] |
| **DNAME** | **string** | User group object domain name. | [default to &quot;example.com&quot;] |
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

<a id="userlocalgroupspatch"></a>
# **UserLocalGroupsPatch**
> ApiStatus UserLocalGroupsPatch (UserLocalGroupCollection? userLocalGroupCollection = null)



Patch user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsPatch(userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsPatchWithHttpInfo(userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

<a id="userlocalgroupspost"></a>
# **UserLocalGroupsPost**
> ApiStatus UserLocalGroupsPost (UserLocalGroupCollection? userLocalGroupCollection = null)



create local group .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsPost(userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsPostWithHttpInfo(userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

<a id="userlocalgroupsput"></a>
# **UserLocalGroupsPut**
> ApiStatus UserLocalGroupsPut (UserLocalGroupCollection? userLocalGroupCollection = null)



Update user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsPut(userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsPutWithHttpInfo(userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

<a id="userlocalgroupsuuiduuiddelete"></a>
# **UserLocalGroupsUuidUUIDDelete**
> ApiStatus UserLocalGroupsUuidUUIDDelete (string UUID)



Delete user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsUuidUUIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsUuidUUIDDelete(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsUuidUUIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsUuidUUIDDeleteWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

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

<a id="userlocalgroupsuuiduuidget"></a>
# **UserLocalGroupsUuidUUIDGet**
> UserLocalGroupCollection UserLocalGroupsUuidUUIDGet (string UUID)



Retrieve user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsUuidUUIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")

            try
            {
                UserLocalGroupCollection result = apiInstance.UserLocalGroupsUuidUUIDGet(UUID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsUuidUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserLocalGroupCollection> response = apiInstance.UserLocalGroupsUuidUUIDGetWithHttpInfo(UUID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |

### Return type

[**UserLocalGroupCollection**](UserLocalGroupCollection.md)

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

<a id="userlocalgroupsuuiduuidpatch"></a>
# **UserLocalGroupsUuidUUIDPatch**
> ApiStatus UserLocalGroupsUuidUUIDPatch (string UUID, UserLocalGroupCollection? userLocalGroupCollection = null)



Patch user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsUuidUUIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsUuidUUIDPatch(UUID, userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsUuidUUIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsUuidUUIDPatchWithHttpInfo(UUID, userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

<a id="userlocalgroupsuuiduuidput"></a>
# **UserLocalGroupsUuidUUIDPut**
> ApiStatus UserLocalGroupsUuidUUIDPut (string UUID, UserLocalGroupCollection? userLocalGroupCollection = null)



Update user local group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLocalGroupsUuidUUIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocalGroupApi(config);
            var UUID = "\"138a224d-c4c7-d621-0a00-c0eae49ce84c\"";  // string | Universally Unique Identifier (UUID) (default to "138a224d-c4c7-d621-0a00-c0eae49ce84c")
            var userLocalGroupCollection = new UserLocalGroupCollection?(); // UserLocalGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLocalGroupsUuidUUIDPut(UUID, userLocalGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocalGroupsUuidUUIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLocalGroupsUuidUUIDPutWithHttpInfo(UUID, userLocalGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocalGroupApi.UserLocalGroupsUuidUUIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Universally Unique Identifier (UUID) | [default to &quot;138a224d-c4c7-d621-0a00-c0eae49ce84c&quot;] |
| **userLocalGroupCollection** | [**UserLocalGroupCollection?**](UserLocalGroupCollection?.md) |  | [optional]  |

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

