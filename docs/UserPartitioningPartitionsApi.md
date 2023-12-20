# SonicWallGen7.Api.UserPartitioningPartitionsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserPartitioningPartitionsGet**](UserPartitioningPartitionsApi.md#userpartitioningpartitionsget) | **GET** /user/partitioning/partitions |  |
| [**UserPartitioningPartitionsNamePNAMEDelete**](UserPartitioningPartitionsApi.md#userpartitioningpartitionsnamepnamedelete) | **DELETE** /user/partitioning/partitions/name/{PNAME} |  |
| [**UserPartitioningPartitionsNamePNAMEGet**](UserPartitioningPartitionsApi.md#userpartitioningpartitionsnamepnameget) | **GET** /user/partitioning/partitions/name/{PNAME} |  |
| [**UserPartitioningPartitionsNamePNAMEPatch**](UserPartitioningPartitionsApi.md#userpartitioningpartitionsnamepnamepatch) | **PATCH** /user/partitioning/partitions/name/{PNAME} |  |
| [**UserPartitioningPartitionsNamePNAMEPut**](UserPartitioningPartitionsApi.md#userpartitioningpartitionsnamepnameput) | **PUT** /user/partitioning/partitions/name/{PNAME} |  |
| [**UserPartitioningPartitionsPatch**](UserPartitioningPartitionsApi.md#userpartitioningpartitionspatch) | **PATCH** /user/partitioning/partitions |  |
| [**UserPartitioningPartitionsPost**](UserPartitioningPartitionsApi.md#userpartitioningpartitionspost) | **POST** /user/partitioning/partitions |  |
| [**UserPartitioningPartitionsPut**](UserPartitioningPartitionsApi.md#userpartitioningpartitionsput) | **PUT** /user/partitioning/partitions |  |

<a id="userpartitioningpartitionsget"></a>
# **UserPartitioningPartitionsGet**
> UserPartitioningPartitionsCollection UserPartitioningPartitionsGet ()



Retrieve user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);

            try
            {
                UserPartitioningPartitionsCollection result = apiInstance.UserPartitioningPartitionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserPartitioningPartitionsCollection> response = apiInstance.UserPartitioningPartitionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserPartitioningPartitionsCollection**](UserPartitioningPartitionsCollection.md)

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

<a id="userpartitioningpartitionsnamepnamedelete"></a>
# **UserPartitioningPartitionsNamePNAMEDelete**
> ApiStatus UserPartitioningPartitionsNamePNAMEDelete (string PNAME)



Delete user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsNamePNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var PNAME = "\"CorpSales\"";  // string | User authentication partition name (default to "CorpSales")

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPartitionsNamePNAMEDelete(PNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsNamePNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPartitionsNamePNAMEDeleteWithHttpInfo(PNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PNAME** | **string** | User authentication partition name | [default to &quot;CorpSales&quot;] |

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

<a id="userpartitioningpartitionsnamepnameget"></a>
# **UserPartitioningPartitionsNamePNAMEGet**
> UserPartitioningPartitionsCollection UserPartitioningPartitionsNamePNAMEGet (string PNAME)



Retrieve user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsNamePNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var PNAME = "\"CorpSales\"";  // string | User authentication partition name (default to "CorpSales")

            try
            {
                UserPartitioningPartitionsCollection result = apiInstance.UserPartitioningPartitionsNamePNAMEGet(PNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsNamePNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserPartitioningPartitionsCollection> response = apiInstance.UserPartitioningPartitionsNamePNAMEGetWithHttpInfo(PNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PNAME** | **string** | User authentication partition name | [default to &quot;CorpSales&quot;] |

### Return type

[**UserPartitioningPartitionsCollection**](UserPartitioningPartitionsCollection.md)

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

<a id="userpartitioningpartitionsnamepnamepatch"></a>
# **UserPartitioningPartitionsNamePNAMEPatch**
> ApiStatus UserPartitioningPartitionsNamePNAMEPatch (string PNAME, UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null)



Patch user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsNamePNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var PNAME = "\"CorpSales\"";  // string | User authentication partition name (default to "CorpSales")
            var userPartitioningPartitionsCollection = new UserPartitioningPartitionsCollection?(); // UserPartitioningPartitionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPartitionsNamePNAMEPatch(PNAME, userPartitioningPartitionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsNamePNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPartitionsNamePNAMEPatchWithHttpInfo(PNAME, userPartitioningPartitionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PNAME** | **string** | User authentication partition name | [default to &quot;CorpSales&quot;] |
| **userPartitioningPartitionsCollection** | [**UserPartitioningPartitionsCollection?**](UserPartitioningPartitionsCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpartitionsnamepnameput"></a>
# **UserPartitioningPartitionsNamePNAMEPut**
> ApiStatus UserPartitioningPartitionsNamePNAMEPut (string PNAME, UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null)



Update user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsNamePNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var PNAME = "\"CorpSales\"";  // string | User authentication partition name (default to "CorpSales")
            var userPartitioningPartitionsCollection = new UserPartitioningPartitionsCollection?(); // UserPartitioningPartitionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPartitionsNamePNAMEPut(PNAME, userPartitioningPartitionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsNamePNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPartitionsNamePNAMEPutWithHttpInfo(PNAME, userPartitioningPartitionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsNamePNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PNAME** | **string** | User authentication partition name | [default to &quot;CorpSales&quot;] |
| **userPartitioningPartitionsCollection** | [**UserPartitioningPartitionsCollection?**](UserPartitioningPartitionsCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpartitionspatch"></a>
# **UserPartitioningPartitionsPatch**
> ApiStatus UserPartitioningPartitionsPatch (UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null)



Patch user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var userPartitioningPartitionsCollection = new UserPartitioningPartitionsCollection?(); // UserPartitioningPartitionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPartitionsPatch(userPartitioningPartitionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPartitionsPatchWithHttpInfo(userPartitioningPartitionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPartitioningPartitionsCollection** | [**UserPartitioningPartitionsCollection?**](UserPartitioningPartitionsCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpartitionspost"></a>
# **UserPartitioningPartitionsPost**
> ApiStatus UserPartitioningPartitionsPost (UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null)



Creat a new user authentication partition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var userPartitioningPartitionsCollection = new UserPartitioningPartitionsCollection?(); // UserPartitioningPartitionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPartitionsPost(userPartitioningPartitionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPartitionsPostWithHttpInfo(userPartitioningPartitionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPartitioningPartitionsCollection** | [**UserPartitioningPartitionsCollection?**](UserPartitioningPartitionsCollection?.md) |  | [optional]  |

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

<a id="userpartitioningpartitionsput"></a>
# **UserPartitioningPartitionsPut**
> ApiStatus UserPartitioningPartitionsPut (UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null)



Update user authentication partitions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningPartitionsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningPartitionsApi(config);
            var userPartitioningPartitionsCollection = new UserPartitioningPartitionsCollection?(); // UserPartitioningPartitionsCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningPartitionsPut(userPartitioningPartitionsCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningPartitionsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningPartitionsPutWithHttpInfo(userPartitioningPartitionsCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningPartitionsApi.UserPartitioningPartitionsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPartitioningPartitionsCollection** | [**UserPartitioningPartitionsCollection?**](UserPartitioningPartitionsCollection?.md) |  | [optional]  |

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

