# SonicWallGen7.Api.UserSsoEnforceOnZoneApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoEnforceOnZonesGet**](UserSsoEnforceOnZoneApi.md#userssoenforceonzonesget) | **GET** /user/sso/enforce-on-zones |  |
| [**UserSsoEnforceOnZonesNameNAMEDelete**](UserSsoEnforceOnZoneApi.md#userssoenforceonzonesnamenamedelete) | **DELETE** /user/sso/enforce-on-zones/name/{NAME} |  |
| [**UserSsoEnforceOnZonesNameNAMEGet**](UserSsoEnforceOnZoneApi.md#userssoenforceonzonesnamenameget) | **GET** /user/sso/enforce-on-zones/name/{NAME} |  |
| [**UserSsoEnforceOnZonesNameNAMEPut**](UserSsoEnforceOnZoneApi.md#userssoenforceonzonesnamenameput) | **PUT** /user/sso/enforce-on-zones/name/{NAME} |  |
| [**UserSsoEnforceOnZonesPost**](UserSsoEnforceOnZoneApi.md#userssoenforceonzonespost) | **POST** /user/sso/enforce-on-zones |  |
| [**UserSsoEnforceOnZonesPut**](UserSsoEnforceOnZoneApi.md#userssoenforceonzonesput) | **PUT** /user/sso/enforce-on-zones |  |

<a id="userssoenforceonzonesget"></a>
# **UserSsoEnforceOnZonesGet**
> UserSsoEnforceOnZoneCollection UserSsoEnforceOnZonesGet ()



Retrieve user SSO enforce on zone configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoEnforceOnZonesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoEnforceOnZoneApi(config);

            try
            {
                UserSsoEnforceOnZoneCollection result = apiInstance.UserSsoEnforceOnZonesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoEnforceOnZonesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoEnforceOnZoneCollection> response = apiInstance.UserSsoEnforceOnZonesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoEnforceOnZoneCollection**](UserSsoEnforceOnZoneCollection.md)

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

<a id="userssoenforceonzonesnamenamedelete"></a>
# **UserSsoEnforceOnZonesNameNAMEDelete**
> ApiStatus UserSsoEnforceOnZonesNameNAMEDelete (string NAME)



DELETE SSO enforce on zone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoEnforceOnZonesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoEnforceOnZoneApi(config);
            var NAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")

            try
            {
                ApiStatus result = apiInstance.UserSsoEnforceOnZonesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoEnforceOnZonesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoEnforceOnZonesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |

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

<a id="userssoenforceonzonesnamenameget"></a>
# **UserSsoEnforceOnZonesNameNAMEGet**
> UserSsoEnforceOnZoneCollection UserSsoEnforceOnZonesNameNAMEGet (string NAME)



Retrieve user SSO enforce on zone configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoEnforceOnZonesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoEnforceOnZoneApi(config);
            var NAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")

            try
            {
                UserSsoEnforceOnZoneCollection result = apiInstance.UserSsoEnforceOnZonesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoEnforceOnZonesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoEnforceOnZoneCollection> response = apiInstance.UserSsoEnforceOnZonesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |

### Return type

[**UserSsoEnforceOnZoneCollection**](UserSsoEnforceOnZoneCollection.md)

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

<a id="userssoenforceonzonesnamenameput"></a>
# **UserSsoEnforceOnZonesNameNAMEPut**
> ApiStatus UserSsoEnforceOnZonesNameNAMEPut (string NAME, UserSsoEnforceOnZoneCollection? userSsoEnforceOnZoneCollection = null)



Update user SSO enforce on zone configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoEnforceOnZonesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoEnforceOnZoneApi(config);
            var NAME = "\"DMZ\"";  // string | Zone object name. (default to "DMZ")
            var userSsoEnforceOnZoneCollection = new UserSsoEnforceOnZoneCollection?(); // UserSsoEnforceOnZoneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoEnforceOnZonesNameNAMEPut(NAME, userSsoEnforceOnZoneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoEnforceOnZonesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoEnforceOnZonesNameNAMEPutWithHttpInfo(NAME, userSsoEnforceOnZoneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Zone object name. | [default to &quot;DMZ&quot;] |
| **userSsoEnforceOnZoneCollection** | [**UserSsoEnforceOnZoneCollection?**](UserSsoEnforceOnZoneCollection?.md) |  | [optional]  |

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

<a id="userssoenforceonzonespost"></a>
# **UserSsoEnforceOnZonesPost**
> ApiStatus UserSsoEnforceOnZonesPost (UserSsoEnforceOnZoneCollection? userSsoEnforceOnZoneCollection = null)



Create user SSO enforce on zone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoEnforceOnZonesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoEnforceOnZoneApi(config);
            var userSsoEnforceOnZoneCollection = new UserSsoEnforceOnZoneCollection?(); // UserSsoEnforceOnZoneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoEnforceOnZonesPost(userSsoEnforceOnZoneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoEnforceOnZonesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoEnforceOnZonesPostWithHttpInfo(userSsoEnforceOnZoneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoEnforceOnZoneCollection** | [**UserSsoEnforceOnZoneCollection?**](UserSsoEnforceOnZoneCollection?.md) |  | [optional]  |

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

<a id="userssoenforceonzonesput"></a>
# **UserSsoEnforceOnZonesPut**
> ApiStatus UserSsoEnforceOnZonesPut (UserSsoEnforceOnZoneCollection? userSsoEnforceOnZoneCollection = null)



Update user SSO enforce on zone configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoEnforceOnZonesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoEnforceOnZoneApi(config);
            var userSsoEnforceOnZoneCollection = new UserSsoEnforceOnZoneCollection?(); // UserSsoEnforceOnZoneCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoEnforceOnZonesPut(userSsoEnforceOnZoneCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoEnforceOnZonesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoEnforceOnZonesPutWithHttpInfo(userSsoEnforceOnZoneCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoEnforceOnZoneApi.UserSsoEnforceOnZonesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoEnforceOnZoneCollection** | [**UserSsoEnforceOnZoneCollection?**](UserSsoEnforceOnZoneCollection?.md) |  | [optional]  |

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

