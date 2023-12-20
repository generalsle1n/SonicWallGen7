# SonicWallGen7.Api.UserTacacsServerApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserTacacsServersGet**](UserTacacsServerApi.md#usertacacsserversget) | **GET** /user/tacacs/servers |  |
| [**UserTacacsServersNameNAMEDelete**](UserTacacsServerApi.md#usertacacsserversnamenamedelete) | **DELETE** /user/tacacs/servers/name/{NAME} |  |
| [**UserTacacsServersNameNAMEGet**](UserTacacsServerApi.md#usertacacsserversnamenameget) | **GET** /user/tacacs/servers/name/{NAME} |  |
| [**UserTacacsServersNameNAMEPatch**](UserTacacsServerApi.md#usertacacsserversnamenamepatch) | **PATCH** /user/tacacs/servers/name/{NAME} |  |
| [**UserTacacsServersNameNAMEPut**](UserTacacsServerApi.md#usertacacsserversnamenameput) | **PUT** /user/tacacs/servers/name/{NAME} |  |
| [**UserTacacsServersPatch**](UserTacacsServerApi.md#usertacacsserverspatch) | **PATCH** /user/tacacs/servers |  |
| [**UserTacacsServersPost**](UserTacacsServerApi.md#usertacacsserverspost) | **POST** /user/tacacs/servers |  |
| [**UserTacacsServersPut**](UserTacacsServerApi.md#usertacacsserversput) | **PUT** /user/tacacs/servers |  |

<a id="usertacacsserversget"></a>
# **UserTacacsServersGet**
> UserTacacsServerCollection UserTacacsServersGet ()



Retrieve TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);

            try
            {
                UserTacacsServerCollection result = apiInstance.UserTacacsServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserTacacsServerCollection> response = apiInstance.UserTacacsServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserTacacsServerCollection**](UserTacacsServerCollection.md)

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

<a id="usertacacsserversnamenamedelete"></a>
# **UserTacacsServersNameNAMEDelete**
> ApiStatus UserTacacsServersNameNAMEDelete (string NAME)



Delete user TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")

            try
            {
                ApiStatus result = apiInstance.UserTacacsServersNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsServersNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="usertacacsserversnamenameget"></a>
# **UserTacacsServersNameNAMEGet**
> UserTacacsServerCollection UserTacacsServersNameNAMEGet (string NAME)



Retrieve TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")

            try
            {
                UserTacacsServerCollection result = apiInstance.UserTacacsServersNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserTacacsServerCollection> response = apiInstance.UserTacacsServersNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEGetWithHttpInfo: " + e.Message);
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

[**UserTacacsServerCollection**](UserTacacsServerCollection.md)

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

<a id="usertacacsserversnamenamepatch"></a>
# **UserTacacsServersNameNAMEPatch**
> ApiStatus UserTacacsServersNameNAMEPatch (string NAME, UserTacacsServerCollection? userTacacsServerCollection = null)



Patch TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")
            var userTacacsServerCollection = new UserTacacsServerCollection?(); // UserTacacsServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsServersNameNAMEPatch(NAME, userTacacsServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsServersNameNAMEPatchWithHttpInfo(NAME, userTacacsServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |
| **userTacacsServerCollection** | [**UserTacacsServerCollection?**](UserTacacsServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsserversnamenameput"></a>
# **UserTacacsServersNameNAMEPut**
> ApiStatus UserTacacsServersNameNAMEPut (string NAME, UserTacacsServerCollection? userTacacsServerCollection = null)



Update TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")
            var userTacacsServerCollection = new UserTacacsServerCollection?(); // UserTacacsServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsServersNameNAMEPut(NAME, userTacacsServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsServersNameNAMEPutWithHttpInfo(NAME, userTacacsServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |
| **userTacacsServerCollection** | [**UserTacacsServerCollection?**](UserTacacsServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsserverspatch"></a>
# **UserTacacsServersPatch**
> ApiStatus UserTacacsServersPatch (UserTacacsServerCollection? userTacacsServerCollection = null)



Patch TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var userTacacsServerCollection = new UserTacacsServerCollection?(); // UserTacacsServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsServersPatch(userTacacsServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsServersPatchWithHttpInfo(userTacacsServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsServerCollection** | [**UserTacacsServerCollection?**](UserTacacsServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsserverspost"></a>
# **UserTacacsServersPost**
> ApiStatus UserTacacsServersPost (UserTacacsServerCollection? userTacacsServerCollection = null)



Create TACACS server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var userTacacsServerCollection = new UserTacacsServerCollection?(); // UserTacacsServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsServersPost(userTacacsServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsServersPostWithHttpInfo(userTacacsServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsServerCollection** | [**UserTacacsServerCollection?**](UserTacacsServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsserversput"></a>
# **UserTacacsServersPut**
> ApiStatus UserTacacsServersPut (UserTacacsServerCollection? userTacacsServerCollection = null)



Update TACACS configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsServerApi(config);
            var userTacacsServerCollection = new UserTacacsServerCollection?(); // UserTacacsServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsServersPut(userTacacsServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsServersPutWithHttpInfo(userTacacsServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsServerApi.UserTacacsServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsServerCollection** | [**UserTacacsServerCollection?**](UserTacacsServerCollection?.md) |  | [optional]  |

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

