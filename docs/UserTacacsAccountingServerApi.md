# SonicWallGen7.Api.UserTacacsAccountingServerApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserTacacsAccountingServersGet**](UserTacacsAccountingServerApi.md#usertacacsaccountingserversget) | **GET** /user/tacacs/accounting/servers |  |
| [**UserTacacsAccountingServersNameNAMEDelete**](UserTacacsAccountingServerApi.md#usertacacsaccountingserversnamenamedelete) | **DELETE** /user/tacacs/accounting/servers/name/{NAME} |  |
| [**UserTacacsAccountingServersNameNAMEGet**](UserTacacsAccountingServerApi.md#usertacacsaccountingserversnamenameget) | **GET** /user/tacacs/accounting/servers/name/{NAME} |  |
| [**UserTacacsAccountingServersNameNAMEPatch**](UserTacacsAccountingServerApi.md#usertacacsaccountingserversnamenamepatch) | **PATCH** /user/tacacs/accounting/servers/name/{NAME} |  |
| [**UserTacacsAccountingServersNameNAMEPut**](UserTacacsAccountingServerApi.md#usertacacsaccountingserversnamenameput) | **PUT** /user/tacacs/accounting/servers/name/{NAME} |  |
| [**UserTacacsAccountingServersPatch**](UserTacacsAccountingServerApi.md#usertacacsaccountingserverspatch) | **PATCH** /user/tacacs/accounting/servers |  |
| [**UserTacacsAccountingServersPost**](UserTacacsAccountingServerApi.md#usertacacsaccountingserverspost) | **POST** /user/tacacs/accounting/servers |  |
| [**UserTacacsAccountingServersPut**](UserTacacsAccountingServerApi.md#usertacacsaccountingserversput) | **PUT** /user/tacacs/accounting/servers |  |

<a id="usertacacsaccountingserversget"></a>
# **UserTacacsAccountingServersGet**
> UserTacacsAccountingServerCollection UserTacacsAccountingServersGet ()



Retrieve TACACS accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);

            try
            {
                UserTacacsAccountingServerCollection result = apiInstance.UserTacacsAccountingServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserTacacsAccountingServerCollection> response = apiInstance.UserTacacsAccountingServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserTacacsAccountingServerCollection**](UserTacacsAccountingServerCollection.md)

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

<a id="usertacacsaccountingserversnamenamedelete"></a>
# **UserTacacsAccountingServersNameNAMEDelete**
> ApiStatus UserTacacsAccountingServersNameNAMEDelete (string NAME)



Delete a TACACS accounting server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingServersNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingServersNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="usertacacsaccountingserversnamenameget"></a>
# **UserTacacsAccountingServersNameNAMEGet**
> UserTacacsAccountingServerCollection UserTacacsAccountingServersNameNAMEGet (string NAME)



Retrieve TACACS accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")

            try
            {
                UserTacacsAccountingServerCollection result = apiInstance.UserTacacsAccountingServersNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserTacacsAccountingServerCollection> response = apiInstance.UserTacacsAccountingServersNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEGetWithHttpInfo: " + e.Message);
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

[**UserTacacsAccountingServerCollection**](UserTacacsAccountingServerCollection.md)

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

<a id="usertacacsaccountingserversnamenamepatch"></a>
# **UserTacacsAccountingServersNameNAMEPatch**
> ApiStatus UserTacacsAccountingServersNameNAMEPatch (string NAME, UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null)



Patch TACACS accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")
            var userTacacsAccountingServerCollection = new UserTacacsAccountingServerCollection?(); // UserTacacsAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingServersNameNAMEPatch(NAME, userTacacsAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingServersNameNAMEPatchWithHttpInfo(NAME, userTacacsAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |
| **userTacacsAccountingServerCollection** | [**UserTacacsAccountingServerCollection?**](UserTacacsAccountingServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsaccountingserversnamenameput"></a>
# **UserTacacsAccountingServersNameNAMEPut**
> ApiStatus UserTacacsAccountingServersNameNAMEPut (string NAME, UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null)



Update TACACS accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.tacacsServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.tacacsServer.com")
            var userTacacsAccountingServerCollection = new UserTacacsAccountingServerCollection?(); // UserTacacsAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingServersNameNAMEPut(NAME, userTacacsAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingServersNameNAMEPutWithHttpInfo(NAME, userTacacsAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.tacacsServer.com&quot;] |
| **userTacacsAccountingServerCollection** | [**UserTacacsAccountingServerCollection?**](UserTacacsAccountingServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsaccountingserverspatch"></a>
# **UserTacacsAccountingServersPatch**
> ApiStatus UserTacacsAccountingServersPatch (UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null)



Patch TACACS accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var userTacacsAccountingServerCollection = new UserTacacsAccountingServerCollection?(); // UserTacacsAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingServersPatch(userTacacsAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingServersPatchWithHttpInfo(userTacacsAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsAccountingServerCollection** | [**UserTacacsAccountingServerCollection?**](UserTacacsAccountingServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsaccountingserverspost"></a>
# **UserTacacsAccountingServersPost**
> ApiStatus UserTacacsAccountingServersPost (UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null)



Create a TACACS accounting server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var userTacacsAccountingServerCollection = new UserTacacsAccountingServerCollection?(); // UserTacacsAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingServersPost(userTacacsAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingServersPostWithHttpInfo(userTacacsAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsAccountingServerCollection** | [**UserTacacsAccountingServerCollection?**](UserTacacsAccountingServerCollection?.md) |  | [optional]  |

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

<a id="usertacacsaccountingserversput"></a>
# **UserTacacsAccountingServersPut**
> ApiStatus UserTacacsAccountingServersPut (UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null)



Update TACACS accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingServerApi(config);
            var userTacacsAccountingServerCollection = new UserTacacsAccountingServerCollection?(); // UserTacacsAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingServersPut(userTacacsAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingServersPutWithHttpInfo(userTacacsAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingServerApi.UserTacacsAccountingServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsAccountingServerCollection** | [**UserTacacsAccountingServerCollection?**](UserTacacsAccountingServerCollection?.md) |  | [optional]  |

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

