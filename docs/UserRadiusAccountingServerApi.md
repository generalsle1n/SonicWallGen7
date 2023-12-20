# SonicWallGen7.Api.UserRadiusAccountingServerApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserRadiusAccountingServersGet**](UserRadiusAccountingServerApi.md#userradiusaccountingserversget) | **GET** /user/radius/accounting/servers |  |
| [**UserRadiusAccountingServersNameNAMEDelete**](UserRadiusAccountingServerApi.md#userradiusaccountingserversnamenamedelete) | **DELETE** /user/radius/accounting/servers/name/{NAME} |  |
| [**UserRadiusAccountingServersNameNAMEGet**](UserRadiusAccountingServerApi.md#userradiusaccountingserversnamenameget) | **GET** /user/radius/accounting/servers/name/{NAME} |  |
| [**UserRadiusAccountingServersNameNAMEPatch**](UserRadiusAccountingServerApi.md#userradiusaccountingserversnamenamepatch) | **PATCH** /user/radius/accounting/servers/name/{NAME} |  |
| [**UserRadiusAccountingServersNameNAMEPut**](UserRadiusAccountingServerApi.md#userradiusaccountingserversnamenameput) | **PUT** /user/radius/accounting/servers/name/{NAME} |  |
| [**UserRadiusAccountingServersPatch**](UserRadiusAccountingServerApi.md#userradiusaccountingserverspatch) | **PATCH** /user/radius/accounting/servers |  |
| [**UserRadiusAccountingServersPost**](UserRadiusAccountingServerApi.md#userradiusaccountingserverspost) | **POST** /user/radius/accounting/servers |  |
| [**UserRadiusAccountingServersPut**](UserRadiusAccountingServerApi.md#userradiusaccountingserversput) | **PUT** /user/radius/accounting/servers |  |

<a id="userradiusaccountingserversget"></a>
# **UserRadiusAccountingServersGet**
> UserRadiusAccountingServerCollection UserRadiusAccountingServersGet ()



Retrieve radius accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);

            try
            {
                UserRadiusAccountingServerCollection result = apiInstance.UserRadiusAccountingServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserRadiusAccountingServerCollection> response = apiInstance.UserRadiusAccountingServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserRadiusAccountingServerCollection**](UserRadiusAccountingServerCollection.md)

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

<a id="userradiusaccountingserversnamenamedelete"></a>
# **UserRadiusAccountingServersNameNAMEDelete**
> ApiStatus UserRadiusAccountingServersNameNAMEDelete (string NAME)



Delete a radius accounting server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.radiusServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.radiusServer.com")

            try
            {
                ApiStatus result = apiInstance.UserRadiusAccountingServersNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserRadiusAccountingServersNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.radiusServer.com&quot;] |

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

<a id="userradiusaccountingserversnamenameget"></a>
# **UserRadiusAccountingServersNameNAMEGet**
> UserRadiusAccountingServerCollection UserRadiusAccountingServersNameNAMEGet (string NAME)



Retrieve radius accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.radiusServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.radiusServer.com")

            try
            {
                UserRadiusAccountingServerCollection result = apiInstance.UserRadiusAccountingServersNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserRadiusAccountingServerCollection> response = apiInstance.UserRadiusAccountingServersNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.radiusServer.com&quot;] |

### Return type

[**UserRadiusAccountingServerCollection**](UserRadiusAccountingServerCollection.md)

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

<a id="userradiusaccountingserversnamenamepatch"></a>
# **UserRadiusAccountingServersNameNAMEPatch**
> ApiStatus UserRadiusAccountingServersNameNAMEPatch (string NAME, UserRadiusAccountingServerCollection? userRadiusAccountingServerCollection = null)



Patch radius accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.radiusServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.radiusServer.com")
            var userRadiusAccountingServerCollection = new UserRadiusAccountingServerCollection?(); // UserRadiusAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserRadiusAccountingServersNameNAMEPatch(NAME, userRadiusAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserRadiusAccountingServersNameNAMEPatchWithHttpInfo(NAME, userRadiusAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.radiusServer.com&quot;] |
| **userRadiusAccountingServerCollection** | [**UserRadiusAccountingServerCollection?**](UserRadiusAccountingServerCollection?.md) |  | [optional]  |

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

<a id="userradiusaccountingserversnamenameput"></a>
# **UserRadiusAccountingServersNameNAMEPut**
> ApiStatus UserRadiusAccountingServersNameNAMEPut (string NAME, UserRadiusAccountingServerCollection? userRadiusAccountingServerCollection = null)



Update radius accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var NAME = "\"10.10.10.10 www.radiusServer.com\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "10.10.10.10
www.radiusServer.com")
            var userRadiusAccountingServerCollection = new UserRadiusAccountingServerCollection?(); // UserRadiusAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserRadiusAccountingServersNameNAMEPut(NAME, userRadiusAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserRadiusAccountingServersNameNAMEPutWithHttpInfo(NAME, userRadiusAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;10.10.10.10
www.radiusServer.com&quot;] |
| **userRadiusAccountingServerCollection** | [**UserRadiusAccountingServerCollection?**](UserRadiusAccountingServerCollection?.md) |  | [optional]  |

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

<a id="userradiusaccountingserverspatch"></a>
# **UserRadiusAccountingServersPatch**
> ApiStatus UserRadiusAccountingServersPatch (UserRadiusAccountingServerCollection? userRadiusAccountingServerCollection = null)



Patch radius accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var userRadiusAccountingServerCollection = new UserRadiusAccountingServerCollection?(); // UserRadiusAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserRadiusAccountingServersPatch(userRadiusAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserRadiusAccountingServersPatchWithHttpInfo(userRadiusAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRadiusAccountingServerCollection** | [**UserRadiusAccountingServerCollection?**](UserRadiusAccountingServerCollection?.md) |  | [optional]  |

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

<a id="userradiusaccountingserverspost"></a>
# **UserRadiusAccountingServersPost**
> ApiStatus UserRadiusAccountingServersPost (UserRadiusAccountingServerCollection? userRadiusAccountingServerCollection = null)



Create a radius accounting server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var userRadiusAccountingServerCollection = new UserRadiusAccountingServerCollection?(); // UserRadiusAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserRadiusAccountingServersPost(userRadiusAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserRadiusAccountingServersPostWithHttpInfo(userRadiusAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRadiusAccountingServerCollection** | [**UserRadiusAccountingServerCollection?**](UserRadiusAccountingServerCollection?.md) |  | [optional]  |

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

<a id="userradiusaccountingserversput"></a>
# **UserRadiusAccountingServersPut**
> ApiStatus UserRadiusAccountingServersPut (UserRadiusAccountingServerCollection? userRadiusAccountingServerCollection = null)



Update radius accounting server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserRadiusAccountingServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserRadiusAccountingServerApi(config);
            var userRadiusAccountingServerCollection = new UserRadiusAccountingServerCollection?(); // UserRadiusAccountingServerCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserRadiusAccountingServersPut(userRadiusAccountingServerCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserRadiusAccountingServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserRadiusAccountingServersPutWithHttpInfo(userRadiusAccountingServerCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRadiusAccountingServerApi.UserRadiusAccountingServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRadiusAccountingServerCollection** | [**UserRadiusAccountingServerCollection?**](UserRadiusAccountingServerCollection?.md) |  | [optional]  |

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

