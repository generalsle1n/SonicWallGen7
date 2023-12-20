# SonicWallGen7.Api.UserPartitioningAutoAssignApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserPartitioningAutoAssignPartitionsNamePNAMEPost**](UserPartitioningAutoAssignApi.md#userpartitioningautoassignpartitionsnamepnamepost) | **POST** /user/partitioning/auto-assign/partitions/name/{PNAME} |  |
| [**UserPartitioningAutoAssignPartitionsPost**](UserPartitioningAutoAssignApi.md#userpartitioningautoassignpartitionspost) | **POST** /user/partitioning/auto-assign/partitions |  |

<a id="userpartitioningautoassignpartitionsnamepnamepost"></a>
# **UserPartitioningAutoAssignPartitionsNamePNAMEPost**
> ApiStatus UserPartitioningAutoAssignPartitionsNamePNAMEPost (string PNAME, Object? body = null)



User partioning auto assign partition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningAutoAssignPartitionsNamePNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningAutoAssignApi(config);
            var PNAME = "\"CorpSales\"";  // string | User authentication partition name (default to "CorpSales")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningAutoAssignPartitionsNamePNAMEPost(PNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningAutoAssignApi.UserPartitioningAutoAssignPartitionsNamePNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningAutoAssignPartitionsNamePNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningAutoAssignPartitionsNamePNAMEPostWithHttpInfo(PNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningAutoAssignApi.UserPartitioningAutoAssignPartitionsNamePNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **PNAME** | **string** | User authentication partition name | [default to &quot;CorpSales&quot;] |
| **body** | **Object?** |  | [optional]  |

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

<a id="userpartitioningautoassignpartitionspost"></a>
# **UserPartitioningAutoAssignPartitionsPost**
> ApiStatus UserPartitioningAutoAssignPartitionsPost (Object? body = null)



User partioning auto assign partition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserPartitioningAutoAssignPartitionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPartitioningAutoAssignApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserPartitioningAutoAssignPartitionsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPartitioningAutoAssignApi.UserPartitioningAutoAssignPartitionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPartitioningAutoAssignPartitionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserPartitioningAutoAssignPartitionsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPartitioningAutoAssignApi.UserPartitioningAutoAssignPartitionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

