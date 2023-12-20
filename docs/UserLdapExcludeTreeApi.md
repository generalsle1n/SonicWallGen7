# SonicWallGen7.Api.UserLdapExcludeTreeApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserLdapExcludeTreesGet**](UserLdapExcludeTreeApi.md#userldapexcludetreesget) | **GET** /user/ldap/exclude-trees |  |
| [**UserLdapExcludeTreesNameNAMEDelete**](UserLdapExcludeTreeApi.md#userldapexcludetreesnamenamedelete) | **DELETE** /user/ldap/exclude-trees/name/{NAME} |  |
| [**UserLdapExcludeTreesNameNAMEGet**](UserLdapExcludeTreeApi.md#userldapexcludetreesnamenameget) | **GET** /user/ldap/exclude-trees/name/{NAME} |  |
| [**UserLdapExcludeTreesPost**](UserLdapExcludeTreeApi.md#userldapexcludetreespost) | **POST** /user/ldap/exclude-trees |  |

<a id="userldapexcludetreesget"></a>
# **UserLdapExcludeTreesGet**
> UserLdapExcludeTreeCollection UserLdapExcludeTreesGet ()



Retrieve user LDAP exclude-tree configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLdapExcludeTreesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapExcludeTreeApi(config);

            try
            {
                UserLdapExcludeTreeCollection result = apiInstance.UserLdapExcludeTreesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLdapExcludeTreesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserLdapExcludeTreeCollection> response = apiInstance.UserLdapExcludeTreesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserLdapExcludeTreeCollection**](UserLdapExcludeTreeCollection.md)

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

<a id="userldapexcludetreesnamenamedelete"></a>
# **UserLdapExcludeTreesNameNAMEDelete**
> ApiStatus UserLdapExcludeTreesNameNAMEDelete (string NAME)



Delete user LDAP exclude-tree.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLdapExcludeTreesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapExcludeTreeApi(config);
            var NAME = "\"abc\"";  // string | LDAP exclude tree. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.UserLdapExcludeTreesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLdapExcludeTreesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLdapExcludeTreesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | LDAP exclude tree. | [default to &quot;abc&quot;] |

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

<a id="userldapexcludetreesnamenameget"></a>
# **UserLdapExcludeTreesNameNAMEGet**
> UserLdapExcludeTreeCollection UserLdapExcludeTreesNameNAMEGet (string NAME)



Retrieve user LDAP exclude-tree configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLdapExcludeTreesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapExcludeTreeApi(config);
            var NAME = "\"abc\"";  // string | LDAP exclude tree. (default to "abc")

            try
            {
                UserLdapExcludeTreeCollection result = apiInstance.UserLdapExcludeTreesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLdapExcludeTreesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserLdapExcludeTreeCollection> response = apiInstance.UserLdapExcludeTreesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | LDAP exclude tree. | [default to &quot;abc&quot;] |

### Return type

[**UserLdapExcludeTreeCollection**](UserLdapExcludeTreeCollection.md)

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

<a id="userldapexcludetreespost"></a>
# **UserLdapExcludeTreesPost**
> ApiStatus UserLdapExcludeTreesPost (UserLdapExcludeTreeCollection? userLdapExcludeTreeCollection = null)



Create user LDAP exclude-tree.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserLdapExcludeTreesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapExcludeTreeApi(config);
            var userLdapExcludeTreeCollection = new UserLdapExcludeTreeCollection?(); // UserLdapExcludeTreeCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserLdapExcludeTreesPost(userLdapExcludeTreeCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLdapExcludeTreesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserLdapExcludeTreesPostWithHttpInfo(userLdapExcludeTreeCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapExcludeTreeApi.UserLdapExcludeTreesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userLdapExcludeTreeCollection** | [**UserLdapExcludeTreeCollection?**](UserLdapExcludeTreeCollection?.md) |  | [optional]  |

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

