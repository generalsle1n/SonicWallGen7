# SonicWallGen7.Api.UserSsoSecurityServiceBypassApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDelete**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassaddressgroupaddrgrpnamedelete) | **DELETE** /user/sso/security-services-bypass/address/group/{ADDRGRPNAME} |  |
| [**UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGet**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassaddressgroupaddrgrpnameget) | **GET** /user/sso/security-services-bypass/address/group/{ADDRGRPNAME} |  |
| [**UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPut**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassaddressgroupaddrgrpnameput) | **PUT** /user/sso/security-services-bypass/address/group/{ADDRGRPNAME} |  |
| [**UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDelete**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassaddressnameaddrobjnamedelete) | **DELETE** /user/sso/security-services-bypass/address/name/{ADDROBJNAME} |  |
| [**UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGet**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassaddressnameaddrobjnameget) | **GET** /user/sso/security-services-bypass/address/name/{ADDROBJNAME} |  |
| [**UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPut**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassaddressnameaddrobjnameput) | **PUT** /user/sso/security-services-bypass/address/name/{ADDROBJNAME} |  |
| [**UserSsoSecurityServicesBypassGet**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassget) | **GET** /user/sso/security-services-bypass |  |
| [**UserSsoSecurityServicesBypassPost**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypasspost) | **POST** /user/sso/security-services-bypass |  |
| [**UserSsoSecurityServicesBypassPut**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassput) | **PUT** /user/sso/security-services-bypass |  |
| [**UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDelete**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicebuiltinbltnamedelete) | **DELETE** /user/sso/security-services-bypass/service/built-in/{BLTNAME} |  |
| [**UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGet**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicebuiltinbltnameget) | **GET** /user/sso/security-services-bypass/service/built-in/{BLTNAME} |  |
| [**UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPut**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicebuiltinbltnameput) | **PUT** /user/sso/security-services-bypass/service/built-in/{BLTNAME} |  |
| [**UserSsoSecurityServicesBypassServiceGroupGRPNAMEDelete**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicegroupgrpnamedelete) | **DELETE** /user/sso/security-services-bypass/service/group/{GRPNAME} |  |
| [**UserSsoSecurityServicesBypassServiceGroupGRPNAMEGet**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicegroupgrpnameget) | **GET** /user/sso/security-services-bypass/service/group/{GRPNAME} |  |
| [**UserSsoSecurityServicesBypassServiceGroupGRPNAMEPut**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicegroupgrpnameput) | **PUT** /user/sso/security-services-bypass/service/group/{GRPNAME} |  |
| [**UserSsoSecurityServicesBypassServiceNameOBJNAMEDelete**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicenameobjnamedelete) | **DELETE** /user/sso/security-services-bypass/service/name/{OBJNAME} |  |
| [**UserSsoSecurityServicesBypassServiceNameOBJNAMEGet**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicenameobjnameget) | **GET** /user/sso/security-services-bypass/service/name/{OBJNAME} |  |
| [**UserSsoSecurityServicesBypassServiceNameOBJNAMEPut**](UserSsoSecurityServiceBypassApi.md#userssosecurityservicesbypassservicenameobjnameput) | **PUT** /user/sso/security-services-bypass/service/name/{OBJNAME} |  |

<a id="userssosecurityservicesbypassaddressgroupaddrgrpnamedelete"></a>
# **UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDelete**
> ApiStatus UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDelete (string ADDRGRPNAME)



DELETE SSO security service bypass.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var ADDRGRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDelete(ADDRGRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDeleteWithHttpInfo(ADDRGRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ADDRGRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

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

<a id="userssosecurityservicesbypassaddressgroupaddrgrpnameget"></a>
# **UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGet**
> UserSsoSecurityServiceBypassCollection UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGet (string ADDRGRPNAME)



Retrieve user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var ADDRGRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                UserSsoSecurityServiceBypassCollection result = apiInstance.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGet(ADDRGRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoSecurityServiceBypassCollection> response = apiInstance.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGetWithHttpInfo(ADDRGRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ADDRGRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

### Return type

[**UserSsoSecurityServiceBypassCollection**](UserSsoSecurityServiceBypassCollection.md)

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

<a id="userssosecurityservicesbypassaddressgroupaddrgrpnameput"></a>
# **UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPut**
> ApiStatus UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPut (string ADDRGRPNAME, UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Update user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var ADDRGRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPut(ADDRGRPNAME, userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPutWithHttpInfo(ADDRGRPNAME, userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressGroupADDRGRPNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ADDRGRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

<a id="userssosecurityservicesbypassaddressnameaddrobjnamedelete"></a>
# **UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDelete**
> ApiStatus UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDelete (string ADDROBJNAME)



DELETE SSO security service bypass.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var ADDROBJNAME = "\"Web Server\"";  // string | Security service bypass IP name. (default to "Web Server")

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDelete(ADDROBJNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDeleteWithHttpInfo(ADDROBJNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ADDROBJNAME** | **string** | Security service bypass IP name. | [default to &quot;Web Server&quot;] |

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

<a id="userssosecurityservicesbypassaddressnameaddrobjnameget"></a>
# **UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGet**
> UserSsoSecurityServiceBypassCollection UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGet (string ADDROBJNAME)



Retrieve user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var ADDROBJNAME = "\"Web Server\"";  // string | Security service bypass IP name. (default to "Web Server")

            try
            {
                UserSsoSecurityServiceBypassCollection result = apiInstance.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGet(ADDROBJNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoSecurityServiceBypassCollection> response = apiInstance.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGetWithHttpInfo(ADDROBJNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ADDROBJNAME** | **string** | Security service bypass IP name. | [default to &quot;Web Server&quot;] |

### Return type

[**UserSsoSecurityServiceBypassCollection**](UserSsoSecurityServiceBypassCollection.md)

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

<a id="userssosecurityservicesbypassaddressnameaddrobjnameput"></a>
# **UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPut**
> ApiStatus UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPut (string ADDROBJNAME, UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Update user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var ADDROBJNAME = "\"Web Server\"";  // string | Security service bypass IP name. (default to "Web Server")
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPut(ADDROBJNAME, userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPutWithHttpInfo(ADDROBJNAME, userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassAddressNameADDROBJNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ADDROBJNAME** | **string** | Security service bypass IP name. | [default to &quot;Web Server&quot;] |
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

<a id="userssosecurityservicesbypassget"></a>
# **UserSsoSecurityServicesBypassGet**
> UserSsoSecurityServiceBypassCollection UserSsoSecurityServicesBypassGet ()



Retrieve user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);

            try
            {
                UserSsoSecurityServiceBypassCollection result = apiInstance.UserSsoSecurityServicesBypassGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoSecurityServiceBypassCollection> response = apiInstance.UserSsoSecurityServicesBypassGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSsoSecurityServiceBypassCollection**](UserSsoSecurityServiceBypassCollection.md)

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

<a id="userssosecurityservicesbypasspost"></a>
# **UserSsoSecurityServicesBypassPost**
> ApiStatus UserSsoSecurityServicesBypassPost (UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Create user SSO security service bypass.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassPost(userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassPostWithHttpInfo(userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

<a id="userssosecurityservicesbypassput"></a>
# **UserSsoSecurityServicesBypassPut**
> ApiStatus UserSsoSecurityServicesBypassPut (UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Update user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassPut(userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassPutWithHttpInfo(userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

<a id="userssosecurityservicesbypassservicebuiltinbltnamedelete"></a>
# **UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDelete**
> ApiStatus UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDelete (string BLTNAME)



DELETE SSO security service bypass.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var BLTNAME = "\"abc\"";  // string | SSO bypass built-in object name. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDelete(BLTNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDeleteWithHttpInfo(BLTNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **BLTNAME** | **string** | SSO bypass built-in object name. | [default to &quot;abc&quot;] |

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

<a id="userssosecurityservicesbypassservicebuiltinbltnameget"></a>
# **UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGet**
> UserSsoSecurityServiceBypassCollection UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGet (string BLTNAME)



Retrieve user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var BLTNAME = "\"abc\"";  // string | SSO bypass built-in object name. (default to "abc")

            try
            {
                UserSsoSecurityServiceBypassCollection result = apiInstance.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGet(BLTNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoSecurityServiceBypassCollection> response = apiInstance.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGetWithHttpInfo(BLTNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **BLTNAME** | **string** | SSO bypass built-in object name. | [default to &quot;abc&quot;] |

### Return type

[**UserSsoSecurityServiceBypassCollection**](UserSsoSecurityServiceBypassCollection.md)

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

<a id="userssosecurityservicesbypassservicebuiltinbltnameput"></a>
# **UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPut**
> ApiStatus UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPut (string BLTNAME, UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Update user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var BLTNAME = "\"abc\"";  // string | SSO bypass built-in object name. (default to "abc")
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPut(BLTNAME, userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPutWithHttpInfo(BLTNAME, userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceBuiltInBLTNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **BLTNAME** | **string** | SSO bypass built-in object name. | [default to &quot;abc&quot;] |
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

<a id="userssosecurityservicesbypassservicegroupgrpnamedelete"></a>
# **UserSsoSecurityServicesBypassServiceGroupGRPNAMEDelete**
> ApiStatus UserSsoSecurityServicesBypassServiceGroupGRPNAMEDelete (string GRPNAME)



DELETE SSO security service bypass.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceGroupGRPNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var GRPNAME = "\"VOIP\"";  // string | Service object group name. (default to "VOIP")

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassServiceGroupGRPNAMEDelete(GRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceGroupGRPNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceGroupGRPNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassServiceGroupGRPNAMEDeleteWithHttpInfo(GRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceGroupGRPNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Service object group name. | [default to &quot;VOIP&quot;] |

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

<a id="userssosecurityservicesbypassservicegroupgrpnameget"></a>
# **UserSsoSecurityServicesBypassServiceGroupGRPNAMEGet**
> UserSsoSecurityServiceBypassCollection UserSsoSecurityServicesBypassServiceGroupGRPNAMEGet (string GRPNAME)



Retrieve user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceGroupGRPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var GRPNAME = "\"VOIP\"";  // string | Service object group name. (default to "VOIP")

            try
            {
                UserSsoSecurityServiceBypassCollection result = apiInstance.UserSsoSecurityServicesBypassServiceGroupGRPNAMEGet(GRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceGroupGRPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceGroupGRPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoSecurityServiceBypassCollection> response = apiInstance.UserSsoSecurityServicesBypassServiceGroupGRPNAMEGetWithHttpInfo(GRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceGroupGRPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Service object group name. | [default to &quot;VOIP&quot;] |

### Return type

[**UserSsoSecurityServiceBypassCollection**](UserSsoSecurityServiceBypassCollection.md)

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

<a id="userssosecurityservicesbypassservicegroupgrpnameput"></a>
# **UserSsoSecurityServicesBypassServiceGroupGRPNAMEPut**
> ApiStatus UserSsoSecurityServicesBypassServiceGroupGRPNAMEPut (string GRPNAME, UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Update user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceGroupGRPNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var GRPNAME = "\"VOIP\"";  // string | Service object group name. (default to "VOIP")
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassServiceGroupGRPNAMEPut(GRPNAME, userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceGroupGRPNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceGroupGRPNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassServiceGroupGRPNAMEPutWithHttpInfo(GRPNAME, userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceGroupGRPNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Service object group name. | [default to &quot;VOIP&quot;] |
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

<a id="userssosecurityservicesbypassservicenameobjnamedelete"></a>
# **UserSsoSecurityServicesBypassServiceNameOBJNAMEDelete**
> ApiStatus UserSsoSecurityServicesBypassServiceNameOBJNAMEDelete (string OBJNAME)



DELETE SSO security service bypass.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceNameOBJNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var OBJNAME = "\"abc\"";  // string | SSO bypass rule service name. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassServiceNameOBJNAMEDelete(OBJNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceNameOBJNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceNameOBJNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassServiceNameOBJNAMEDeleteWithHttpInfo(OBJNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceNameOBJNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **OBJNAME** | **string** | SSO bypass rule service name. | [default to &quot;abc&quot;] |

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

<a id="userssosecurityservicesbypassservicenameobjnameget"></a>
# **UserSsoSecurityServicesBypassServiceNameOBJNAMEGet**
> UserSsoSecurityServiceBypassCollection UserSsoSecurityServicesBypassServiceNameOBJNAMEGet (string OBJNAME)



Retrieve user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceNameOBJNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var OBJNAME = "\"abc\"";  // string | SSO bypass rule service name. (default to "abc")

            try
            {
                UserSsoSecurityServiceBypassCollection result = apiInstance.UserSsoSecurityServicesBypassServiceNameOBJNAMEGet(OBJNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceNameOBJNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceNameOBJNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSsoSecurityServiceBypassCollection> response = apiInstance.UserSsoSecurityServicesBypassServiceNameOBJNAMEGetWithHttpInfo(OBJNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceNameOBJNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **OBJNAME** | **string** | SSO bypass rule service name. | [default to &quot;abc&quot;] |

### Return type

[**UserSsoSecurityServiceBypassCollection**](UserSsoSecurityServiceBypassCollection.md)

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

<a id="userssosecurityservicesbypassservicenameobjnameput"></a>
# **UserSsoSecurityServicesBypassServiceNameOBJNAMEPut**
> ApiStatus UserSsoSecurityServicesBypassServiceNameOBJNAMEPut (string OBJNAME, UserSsoSecurityServiceBypassCollection? userSsoSecurityServiceBypassCollection = null)



Update user SSO security service bypass configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserSsoSecurityServicesBypassServiceNameOBJNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSsoSecurityServiceBypassApi(config);
            var OBJNAME = "\"abc\"";  // string | SSO bypass rule service name. (default to "abc")
            var userSsoSecurityServiceBypassCollection = new UserSsoSecurityServiceBypassCollection?(); // UserSsoSecurityServiceBypassCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserSsoSecurityServicesBypassServiceNameOBJNAMEPut(OBJNAME, userSsoSecurityServiceBypassCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceNameOBJNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSsoSecurityServicesBypassServiceNameOBJNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserSsoSecurityServicesBypassServiceNameOBJNAMEPutWithHttpInfo(OBJNAME, userSsoSecurityServiceBypassCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSsoSecurityServiceBypassApi.UserSsoSecurityServicesBypassServiceNameOBJNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **OBJNAME** | **string** | SSO bypass rule service name. | [default to &quot;abc&quot;] |
| **userSsoSecurityServiceBypassCollection** | [**UserSsoSecurityServiceBypassCollection?**](UserSsoSecurityServiceBypassCollection?.md) |  | [optional]  |

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

