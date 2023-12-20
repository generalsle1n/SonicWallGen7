# SonicWallGen7.Api.UserStatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserStatusAccountLockedOutGet**](UserStatusApi.md#userstatusaccountlockedoutget) | **GET** /user/status/account-locked-out |  |
| [**UserStatusActiveGet**](UserStatusApi.md#userstatusactiveget) | **GET** /user/status/active |  |
| [**UserStatusActiveIpUSERIPGet**](UserStatusApi.md#userstatusactiveipuseripget) | **GET** /user/status/active/ip/{USERIP} |  |
| [**UserStatusActiveNameUSERNAMEGet**](UserStatusApi.md#userstatusactivenameusernameget) | **GET** /user/status/active/name/{USERNAME} |  |
| [**UserStatusActiveSortByInactivityRemainingGet**](UserStatusApi.md#userstatusactivesortbyinactivityremainingget) | **GET** /user/status/active/sort-by/inactivity-remaining |  |
| [**UserStatusActiveSortByInvertedGet**](UserStatusApi.md#userstatusactivesortbyinvertedget) | **GET** /user/status/active/sort-by/inverted |  |
| [**UserStatusActiveSortByIpAddressGet**](UserStatusApi.md#userstatusactivesortbyipaddressget) | **GET** /user/status/active/sort-by/ip-address |  |
| [**UserStatusActiveSortByPartitionGet**](UserStatusApi.md#userstatusactivesortbypartitionget) | **GET** /user/status/active/sort-by/partition |  |
| [**UserStatusActiveSortBySessionTimeGet**](UserStatusApi.md#userstatusactivesortbysessiontimeget) | **GET** /user/status/active/sort-by/session-time |  |
| [**UserStatusActiveSortByTimeRemainingGet**](UserStatusApi.md#userstatusactivesortbytimeremainingget) | **GET** /user/status/active/sort-by/time-remaining |  |
| [**UserStatusActiveSortByTypeOrModeGet**](UserStatusApi.md#userstatusactivesortbytypeormodeget) | **GET** /user/status/active/sort-by/type-or-mode |  |
| [**UserStatusActiveSortByUserNameGet**](UserStatusApi.md#userstatusactivesortbyusernameget) | **GET** /user/status/active/sort-by/user-name |  |
| [**UserStatusAtIPGet**](UserStatusApi.md#userstatusatipget) | **GET** /user/status/at/{IP} |  |
| [**UserStatusAtIPUserUSERNUMBERGet**](UserStatusApi.md#userstatusatipuserusernumberget) | **GET** /user/status/at/{IP}/user/{USER-NUMBER} |  |
| [**UserStatusCliGet**](UserStatusApi.md#userstatuscliget) | **GET** /user/status/cli |  |
| [**UserStatusFromThisLoginGet**](UserStatusApi.md#userstatusfromthisloginget) | **GET** /user/status/from-this-login |  |
| [**UserStatusInactiveGet**](UserStatusApi.md#userstatusinactiveget) | **GET** /user/status/inactive |  |
| [**UserStatusInactiveIpUSERIPGet**](UserStatusApi.md#userstatusinactiveipuseripget) | **GET** /user/status/inactive/ip/{USERIP} |  |
| [**UserStatusInactiveNameUSERNAMEGet**](UserStatusApi.md#userstatusinactivenameusernameget) | **GET** /user/status/inactive/name/{USERNAME} |  |
| [**UserStatusInactiveSortByInactivityRemainingGet**](UserStatusApi.md#userstatusinactivesortbyinactivityremainingget) | **GET** /user/status/inactive/sort-by/inactivity-remaining |  |
| [**UserStatusInactiveSortByInvertedGet**](UserStatusApi.md#userstatusinactivesortbyinvertedget) | **GET** /user/status/inactive/sort-by/inverted |  |
| [**UserStatusInactiveSortByIpAddressGet**](UserStatusApi.md#userstatusinactivesortbyipaddressget) | **GET** /user/status/inactive/sort-by/ip-address |  |
| [**UserStatusInactiveSortByPartitionGet**](UserStatusApi.md#userstatusinactivesortbypartitionget) | **GET** /user/status/inactive/sort-by/partition |  |
| [**UserStatusInactiveSortBySessionTimeGet**](UserStatusApi.md#userstatusinactivesortbysessiontimeget) | **GET** /user/status/inactive/sort-by/session-time |  |
| [**UserStatusInactiveSortByTimeRemainingGet**](UserStatusApi.md#userstatusinactivesortbytimeremainingget) | **GET** /user/status/inactive/sort-by/time-remaining |  |
| [**UserStatusInactiveSortByTypeOrModeGet**](UserStatusApi.md#userstatusinactivesortbytypeormodeget) | **GET** /user/status/inactive/sort-by/type-or-mode |  |
| [**UserStatusInactiveSortByUserNameGet**](UserStatusApi.md#userstatusinactivesortbyusernameget) | **GET** /user/status/inactive/sort-by/user-name |  |
| [**UserStatusLockedOutGet**](UserStatusApi.md#userstatuslockedoutget) | **GET** /user/status/locked-out |  |
| [**UserStatusLoggedInActiveGet**](UserStatusApi.md#userstatusloggedinactiveget) | **GET** /user/status/logged-in/active |  |
| [**UserStatusLoggedInAllGet**](UserStatusApi.md#userstatusloggedinallget) | **GET** /user/status/logged-in/all |  |
| [**UserStatusLoggedInGet**](UserStatusApi.md#userstatusloggedinget) | **GET** /user/status/logged-in |  |
| [**UserStatusLoggedInInactiveGet**](UserStatusApi.md#userstatusloggedininactiveget) | **GET** /user/status/logged-in/inactive |  |
| [**UserStatusLoggedInIpUSERIPGet**](UserStatusApi.md#userstatusloggedinipuseripget) | **GET** /user/status/logged-in/ip/{USERIP} |  |
| [**UserStatusLoggedInNameUSERNAMEGet**](UserStatusApi.md#userstatusloggedinnameusernameget) | **GET** /user/status/logged-in/name/{USERNAME} |  |
| [**UserStatusNameNAMEGet**](UserStatusApi.md#userstatusnamenameget) | **GET** /user/status/name/{NAME} |  |
| [**UserStatusPendingGet**](UserStatusApi.md#userstatuspendingget) | **GET** /user/status/pending |  |
| [**UserStatusUnauthenticatedGet**](UserStatusApi.md#userstatusunauthenticatedget) | **GET** /user/status/unauthenticated |  |

<a id="userstatusaccountlockedoutget"></a>
# **UserStatusAccountLockedOutGet**
> Object UserStatusAccountLockedOutGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusAccountLockedOutGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusAccountLockedOutGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusAccountLockedOutGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusAccountLockedOutGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusAccountLockedOutGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusAccountLockedOutGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactiveget"></a>
# **UserStatusActiveGet**
> Object UserStatusActiveGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactiveipuseripget"></a>
# **UserStatusActiveIpUSERIPGet**
> Object UserStatusActiveIpUSERIPGet (string USERIP)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveIpUSERIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var USERIP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")

            try
            {
                Object result = apiInstance.UserStatusActiveIpUSERIPGet(USERIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveIpUSERIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveIpUSERIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveIpUSERIPGetWithHttpInfo(USERIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveIpUSERIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERIP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |

### Return type

**Object**

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

<a id="userstatusactivenameusernameget"></a>
# **UserStatusActiveNameUSERNAMEGet**
> Object UserStatusActiveNameUSERNAMEGet (string USERNAME)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveNameUSERNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var USERNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                Object result = apiInstance.UserStatusActiveNameUSERNAMEGet(USERNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveNameUSERNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveNameUSERNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveNameUSERNAMEGetWithHttpInfo(USERNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveNameUSERNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

**Object**

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

<a id="userstatusactivesortbyinactivityremainingget"></a>
# **UserStatusActiveSortByInactivityRemainingGet**
> Object UserStatusActiveSortByInactivityRemainingGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByInactivityRemainingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByInactivityRemainingGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByInactivityRemainingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByInactivityRemainingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByInactivityRemainingGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByInactivityRemainingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbyinvertedget"></a>
# **UserStatusActiveSortByInvertedGet**
> Object UserStatusActiveSortByInvertedGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByInvertedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByInvertedGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByInvertedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByInvertedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByInvertedGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByInvertedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbyipaddressget"></a>
# **UserStatusActiveSortByIpAddressGet**
> Object UserStatusActiveSortByIpAddressGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByIpAddressGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByIpAddressGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByIpAddressGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByIpAddressGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByIpAddressGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByIpAddressGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbypartitionget"></a>
# **UserStatusActiveSortByPartitionGet**
> Object UserStatusActiveSortByPartitionGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByPartitionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByPartitionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByPartitionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByPartitionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByPartitionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByPartitionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbysessiontimeget"></a>
# **UserStatusActiveSortBySessionTimeGet**
> Object UserStatusActiveSortBySessionTimeGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortBySessionTimeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortBySessionTimeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortBySessionTimeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortBySessionTimeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortBySessionTimeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortBySessionTimeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbytimeremainingget"></a>
# **UserStatusActiveSortByTimeRemainingGet**
> Object UserStatusActiveSortByTimeRemainingGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByTimeRemainingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByTimeRemainingGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByTimeRemainingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByTimeRemainingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByTimeRemainingGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByTimeRemainingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbytypeormodeget"></a>
# **UserStatusActiveSortByTypeOrModeGet**
> Object UserStatusActiveSortByTypeOrModeGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByTypeOrModeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByTypeOrModeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByTypeOrModeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByTypeOrModeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByTypeOrModeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByTypeOrModeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusactivesortbyusernameget"></a>
# **UserStatusActiveSortByUserNameGet**
> Object UserStatusActiveSortByUserNameGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusActiveSortByUserNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusActiveSortByUserNameGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByUserNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusActiveSortByUserNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusActiveSortByUserNameGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusActiveSortByUserNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusatipget"></a>
# **UserStatusAtIPGet**
> Object UserStatusAtIPGet (string IP)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusAtIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")

            try
            {
                Object result = apiInstance.UserStatusAtIPGet(IP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusAtIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusAtIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusAtIPGetWithHttpInfo(IP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusAtIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |

### Return type

**Object**

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

<a id="userstatusatipuserusernumberget"></a>
# **UserStatusAtIPUserUSERNUMBERGet**
> Object UserStatusAtIPUserUSERNUMBERGet (string IP, decimal USER_NUMBER)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusAtIPUserUSERNUMBERGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var USER_NUMBER = 8.14D;  // decimal | Integer in the form: D OR 0xHHHHHHHH

            try
            {
                Object result = apiInstance.UserStatusAtIPUserUSERNUMBERGet(IP, USER_NUMBER);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusAtIPUserUSERNUMBERGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusAtIPUserUSERNUMBERGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusAtIPUserUSERNUMBERGetWithHttpInfo(IP, USER_NUMBER);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusAtIPUserUSERNUMBERGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **USER_NUMBER** | **decimal** | Integer in the form: D OR 0xHHHHHHHH |  |

### Return type

**Object**

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

<a id="userstatuscliget"></a>
# **UserStatusCliGet**
> Object UserStatusCliGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusCliGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusCliGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusCliGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusCliGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusCliGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusCliGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusfromthisloginget"></a>
# **UserStatusFromThisLoginGet**
> Object UserStatusFromThisLoginGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusFromThisLoginGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusFromThisLoginGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusFromThisLoginGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusFromThisLoginGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusFromThisLoginGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusFromThisLoginGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactiveget"></a>
# **UserStatusInactiveGet**
> Object UserStatusInactiveGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactiveipuseripget"></a>
# **UserStatusInactiveIpUSERIPGet**
> Object UserStatusInactiveIpUSERIPGet (string USERIP)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveIpUSERIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var USERIP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")

            try
            {
                Object result = apiInstance.UserStatusInactiveIpUSERIPGet(USERIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveIpUSERIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveIpUSERIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveIpUSERIPGetWithHttpInfo(USERIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveIpUSERIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERIP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |

### Return type

**Object**

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

<a id="userstatusinactivenameusernameget"></a>
# **UserStatusInactiveNameUSERNAMEGet**
> Object UserStatusInactiveNameUSERNAMEGet (string USERNAME)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveNameUSERNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var USERNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                Object result = apiInstance.UserStatusInactiveNameUSERNAMEGet(USERNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveNameUSERNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveNameUSERNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveNameUSERNAMEGetWithHttpInfo(USERNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveNameUSERNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

**Object**

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

<a id="userstatusinactivesortbyinactivityremainingget"></a>
# **UserStatusInactiveSortByInactivityRemainingGet**
> Object UserStatusInactiveSortByInactivityRemainingGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByInactivityRemainingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByInactivityRemainingGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByInactivityRemainingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByInactivityRemainingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByInactivityRemainingGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByInactivityRemainingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbyinvertedget"></a>
# **UserStatusInactiveSortByInvertedGet**
> Object UserStatusInactiveSortByInvertedGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByInvertedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByInvertedGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByInvertedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByInvertedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByInvertedGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByInvertedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbyipaddressget"></a>
# **UserStatusInactiveSortByIpAddressGet**
> Object UserStatusInactiveSortByIpAddressGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByIpAddressGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByIpAddressGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByIpAddressGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByIpAddressGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByIpAddressGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByIpAddressGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbypartitionget"></a>
# **UserStatusInactiveSortByPartitionGet**
> Object UserStatusInactiveSortByPartitionGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByPartitionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByPartitionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByPartitionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByPartitionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByPartitionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByPartitionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbysessiontimeget"></a>
# **UserStatusInactiveSortBySessionTimeGet**
> Object UserStatusInactiveSortBySessionTimeGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortBySessionTimeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortBySessionTimeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortBySessionTimeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortBySessionTimeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortBySessionTimeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortBySessionTimeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbytimeremainingget"></a>
# **UserStatusInactiveSortByTimeRemainingGet**
> Object UserStatusInactiveSortByTimeRemainingGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByTimeRemainingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByTimeRemainingGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByTimeRemainingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByTimeRemainingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByTimeRemainingGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByTimeRemainingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbytypeormodeget"></a>
# **UserStatusInactiveSortByTypeOrModeGet**
> Object UserStatusInactiveSortByTypeOrModeGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByTypeOrModeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByTypeOrModeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByTypeOrModeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByTypeOrModeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByTypeOrModeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByTypeOrModeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusinactivesortbyusernameget"></a>
# **UserStatusInactiveSortByUserNameGet**
> Object UserStatusInactiveSortByUserNameGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusInactiveSortByUserNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusInactiveSortByUserNameGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByUserNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusInactiveSortByUserNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusInactiveSortByUserNameGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusInactiveSortByUserNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatuslockedoutget"></a>
# **UserStatusLockedOutGet**
> Object UserStatusLockedOutGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLockedOutGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusLockedOutGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLockedOutGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLockedOutGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLockedOutGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLockedOutGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusloggedinactiveget"></a>
# **UserStatusLoggedInActiveGet**
> Object UserStatusLoggedInActiveGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLoggedInActiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusLoggedInActiveGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInActiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLoggedInActiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLoggedInActiveGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInActiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusloggedinallget"></a>
# **UserStatusLoggedInAllGet**
> Object UserStatusLoggedInAllGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLoggedInAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusLoggedInAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLoggedInAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLoggedInAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusloggedinget"></a>
# **UserStatusLoggedInGet**
> Object UserStatusLoggedInGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLoggedInGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusLoggedInGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLoggedInGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLoggedInGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusloggedininactiveget"></a>
# **UserStatusLoggedInInactiveGet**
> Object UserStatusLoggedInInactiveGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLoggedInInactiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusLoggedInInactiveGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInInactiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLoggedInInactiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLoggedInInactiveGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInInactiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusloggedinipuseripget"></a>
# **UserStatusLoggedInIpUSERIPGet**
> Object UserStatusLoggedInIpUSERIPGet (string USERIP)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLoggedInIpUSERIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var USERIP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")

            try
            {
                Object result = apiInstance.UserStatusLoggedInIpUSERIPGet(USERIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInIpUSERIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLoggedInIpUSERIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLoggedInIpUSERIPGetWithHttpInfo(USERIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInIpUSERIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERIP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |

### Return type

**Object**

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

<a id="userstatusloggedinnameusernameget"></a>
# **UserStatusLoggedInNameUSERNAMEGet**
> Object UserStatusLoggedInNameUSERNAMEGet (string USERNAME)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusLoggedInNameUSERNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var USERNAME = "\"jdoe\"";  // string | A connected user's login name. (default to "jdoe")

            try
            {
                Object result = apiInstance.UserStatusLoggedInNameUSERNAMEGet(USERNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInNameUSERNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusLoggedInNameUSERNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusLoggedInNameUSERNAMEGetWithHttpInfo(USERNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusLoggedInNameUSERNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **USERNAME** | **string** | A connected user&#39;s login name. | [default to &quot;jdoe&quot;] |

### Return type

**Object**

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

<a id="userstatusnamenameget"></a>
# **UserStatusNameNAMEGet**
> Object UserStatusNameNAMEGet (string NAME)



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);
            var NAME = "\"jdoe\"";  // string | A connected user's login name. (default to "jdoe")

            try
            {
                Object result = apiInstance.UserStatusNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | A connected user&#39;s login name. | [default to &quot;jdoe&quot;] |

### Return type

**Object**

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

<a id="userstatuspendingget"></a>
# **UserStatusPendingGet**
> Object UserStatusPendingGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusPendingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusPendingGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusPendingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusPendingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusPendingGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusPendingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="userstatusunauthenticatedget"></a>
# **UserStatusUnauthenticatedGet**
> Object UserStatusUnauthenticatedGet ()



Retrieve user status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserStatusUnauthenticatedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserStatusApi(config);

            try
            {
                Object result = apiInstance.UserStatusUnauthenticatedGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatusApi.UserStatusUnauthenticatedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserStatusUnauthenticatedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.UserStatusUnauthenticatedGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatusApi.UserStatusUnauthenticatedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

