# SonicWallGen7.Api.UserPartitioningPoliciesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserPartitioningPoliciesGet**](UserPartitioningPoliciesApi.md#userpartitioningpoliciesget) | **GET** /user/partitioning/policies |  |
| [**UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDelete**](UserPartitioningPoliciesApi.md#userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonamedelete) | **DELETE** /user/partitioning/policies/interface/{IF}/zone/{ZONENAME}/address-object/{AONAME} |  |
| [**UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGet**](UserPartitioningPoliciesApi.md#userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonameget) | **GET** /user/partitioning/policies/interface/{IF}/zone/{ZONENAME}/address-object/{AONAME} |  |
| [**UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatch**](UserPartitioningPoliciesApi.md#userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonamepatch) | **PATCH** /user/partitioning/policies/interface/{IF}/zone/{ZONENAME}/address-object/{AONAME} |  |
| [**UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPut**](UserPartitioningPoliciesApi.md#userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonameput) | **PUT** /user/partitioning/policies/interface/{IF}/zone/{ZONENAME}/address-object/{AONAME} |  |
| [**UserPartitioningPoliciesPatch**](UserPartitioningPoliciesApi.md#userpartitioningpoliciespatch) | **PATCH** /user/partitioning/policies |  |
| [**UserPartitioningPoliciesPost**](UserPartitioningPoliciesApi.md#userpartitioningpoliciespost) | **POST** /user/partitioning/policies |  |
| [**UserPartitioningPoliciesPut**](UserPartitioningPoliciesApi.md#userpartitioningpoliciesput) | **PUT** /user/partitioning/policies |  |

<a id="userpartitioningpoliciesget"></a>
# **UserPartitioningPoliciesGet**
> UserPartitioningPoliciesCollection UserPartitioningPoliciesGet ()



Retrieve user partition selection policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);

            try
            {
                UserPartitioningPoliciesCollection result = apiInstance.UserPartitioningPoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserPartitioningPoliciesCollection> response = apiInstance.UserPartitioningPoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserPartitioningPoliciesCollection**](UserPartitioningPoliciesCollection.md)

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

<a id="userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonamedelete"></a>
# **UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDelete**
> ApiStatus UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDelete (string IF, string ZONENAME, string AONAME)



Delete partition selection policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var IF = "\"X1\"";  // string | User authentication interface name (default to "X1")
            var ZONENAME = "\"LAN\"";  // string | User authentication zone name (default to "LAN")
            var AONAME = "\"X0 Subnet\"";  // string | User authentication address-object name. (default to "X0 Subnet")

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDelete(IF, ZONENAME, AONAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDeleteWithHttpInfo(IF, ZONENAME, AONAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IF** | **string** | User authentication interface name | [default to &quot;X1&quot;] |
| **ZONENAME** | **string** | User authentication zone name | [default to &quot;LAN&quot;] |
| **AONAME** | **string** | User authentication address-object name. | [default to &quot;X0 Subnet&quot;] |

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

<a id="userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonameget"></a>
# **UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGet**
> UserPartitioningPoliciesCollection UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGet (string IF, string ZONENAME, string AONAME)



Retrieve user partition selection policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var IF = "\"X1\"";  // string | User authentication interface name (default to "X1")
            var ZONENAME = "\"LAN\"";  // string | User authentication zone name (default to "LAN")
            var AONAME = "\"X0 Subnet\"";  // string | User authentication address-object name. (default to "X0 Subnet")

            try
            {
                UserPartitioningPoliciesCollection result = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGet(IF, ZONENAME, AONAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserPartitioningPoliciesCollection> response = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGetWithHttpInfo(IF, ZONENAME, AONAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IF** | **string** | User authentication interface name | [default to &quot;X1&quot;] |
| **ZONENAME** | **string** | User authentication zone name | [default to &quot;LAN&quot;] |
| **AONAME** | **string** | User authentication address-object name. | [default to &quot;X0 Subnet&quot;] |

### Return type

[**UserPartitioningPoliciesCollection**](UserPartitioningPoliciesCollection.md)

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

<a id="userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonamepatch"></a>
# **UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatch**
> ApiStatus UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatch (string IF, string ZONENAME, string AONAME, UserPartitioningPoliciesCollection? userPartitioningPoliciesCollection = null)



Patch user partition selection policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var IF = "\"X1\"";  // string | User authentication interface name (default to "X1")
            var ZONENAME = "\"LAN\"";  // string | User authentication zone name (default to "LAN")
            var AONAME = "\"X0 Subnet\"";  // string | User authentication address-object name. (default to "X0 Subnet")
            var userPartitioningPoliciesCollection = new UserPartitioningPoliciesCollection?(); // UserPartitioningPoliciesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatch(IF, ZONENAME, AONAME, userPartitioningPoliciesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatchWithHttpInfo(IF, ZONENAME, AONAME, userPartitioningPoliciesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IF** | **string** | User authentication interface name | [default to &quot;X1&quot;] |
| **ZONENAME** | **string** | User authentication zone name | [default to &quot;LAN&quot;] |
| **AONAME** | **string** | User authentication address-object name. | [default to &quot;X0 Subnet&quot;] |
| **userPartitioningPoliciesCollection** | [**UserPartitioningPoliciesCollection?**](UserPartitioningPoliciesCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpoliciesinterfaceifzonezonenameaddressobjectaonameput"></a>
# **UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPut**
> ApiStatus UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPut (string IF, string ZONENAME, string AONAME, UserPartitioningPoliciesCollection? userPartitioningPoliciesCollection = null)



Update user partition selection policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var IF = "\"X1\"";  // string | User authentication interface name (default to "X1")
            var ZONENAME = "\"LAN\"";  // string | User authentication zone name (default to "LAN")
            var AONAME = "\"X0 Subnet\"";  // string | User authentication address-object name. (default to "X0 Subnet")
            var userPartitioningPoliciesCollection = new UserPartitioningPoliciesCollection?(); // UserPartitioningPoliciesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPut(IF, ZONENAME, AONAME, userPartitioningPoliciesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPutWithHttpInfo(IF, ZONENAME, AONAME, userPartitioningPoliciesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesInterfaceIFZoneZONENAMEAddressObjectAONAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IF** | **string** | User authentication interface name | [default to &quot;X1&quot;] |
| **ZONENAME** | **string** | User authentication zone name | [default to &quot;LAN&quot;] |
| **AONAME** | **string** | User authentication address-object name. | [default to &quot;X0 Subnet&quot;] |
| **userPartitioningPoliciesCollection** | [**UserPartitioningPoliciesCollection?**](UserPartitioningPoliciesCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpoliciespatch"></a>
# **UserPartitioningPoliciesPatch**
> ApiStatus UserPartitioningPoliciesPatch (UserPartitioningPoliciesCollection? userPartitioningPoliciesCollection = null)



Patch user partition selection policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var userPartitioningPoliciesCollection = new UserPartitioningPoliciesCollection?(); // UserPartitioningPoliciesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPoliciesPatch(userPartitioningPoliciesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPoliciesPatchWithHttpInfo(userPartitioningPoliciesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPartitioningPoliciesCollection** | [**UserPartitioningPoliciesCollection?**](UserPartitioningPoliciesCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpoliciespost"></a>
# **UserPartitioningPoliciesPost**
> ApiStatus UserPartitioningPoliciesPost (UserPartitioningPoliciesCollection? userPartitioningPoliciesCollection = null)



Creat a new partition selection policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var userPartitioningPoliciesCollection = new UserPartitioningPoliciesCollection?(); // UserPartitioningPoliciesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPoliciesPost(userPartitioningPoliciesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPoliciesPostWithHttpInfo(userPartitioningPoliciesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPartitioningPoliciesCollection** | [**UserPartitioningPoliciesCollection?**](UserPartitioningPoliciesCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpoliciesput"></a>
# **UserPartitioningPoliciesPut**
> ApiStatus UserPartitioningPoliciesPut (UserPartitioningPoliciesCollection? userPartitioningPoliciesCollection = null)



Update user partition selection policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPoliciesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPoliciesApi(config);
            var userPartitioningPoliciesCollection = new UserPartitioningPoliciesCollection?(); // UserPartitioningPoliciesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPoliciesPut(userPartitioningPoliciesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPoliciesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPoliciesPutWithHttpInfo(userPartitioningPoliciesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPoliciesApi.UserPartitioningPoliciesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPartitioningPoliciesCollection** | [**UserPartitioningPoliciesCollection?**](UserPartitioningPoliciesCollection?.md) |  | [optional]  |

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

