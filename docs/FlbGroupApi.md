# SonicWallGen7.Api.FlbGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FailoverLbGroupsGet**](FlbGroupApi.md#failoverlbgroupsget) | **GET** /failover-lb/groups |  |
| [**FailoverLbGroupsNameNAMEDelete**](FlbGroupApi.md#failoverlbgroupsnamenamedelete) | **DELETE** /failover-lb/groups/name/{NAME} |  |
| [**FailoverLbGroupsNameNAMEGet**](FlbGroupApi.md#failoverlbgroupsnamenameget) | **GET** /failover-lb/groups/name/{NAME} |  |
| [**FailoverLbGroupsNameNAMEPut**](FlbGroupApi.md#failoverlbgroupsnamenameput) | **PUT** /failover-lb/groups/name/{NAME} |  |
| [**FailoverLbGroupsPut**](FlbGroupApi.md#failoverlbgroupsput) | **PUT** /failover-lb/groups |  |

<a id="failoverlbgroupsget"></a>
# **FailoverLbGroupsGet**
> FlbGroupCollection FailoverLbGroupsGet ()



Retrieve failover load balancing group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupApi(config);

            try
            {
                FlbGroupCollection result = apiInstance.FailoverLbGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FlbGroupCollection> response = apiInstance.FailoverLbGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FlbGroupCollection**](FlbGroupCollection.md)

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

<a id="failoverlbgroupsnamenamedelete"></a>
# **FailoverLbGroupsNameNAMEDelete**
> ApiStatus FailoverLbGroupsNameNAMEDelete (string NAME)



Remove interface load balancing group member API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")

            try
            {
                ApiStatus result = apiInstance.FailoverLbGroupsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.FailoverLbGroupsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |

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

<a id="failoverlbgroupsnamenameget"></a>
# **FailoverLbGroupsNameNAMEGet**
> FlbGroupCollection FailoverLbGroupsNameNAMEGet (string NAME)



Retrieve failover load balancing group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")

            try
            {
                FlbGroupCollection result = apiInstance.FailoverLbGroupsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FlbGroupCollection> response = apiInstance.FailoverLbGroupsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |

### Return type

[**FlbGroupCollection**](FlbGroupCollection.md)

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

<a id="failoverlbgroupsnamenameput"></a>
# **FailoverLbGroupsNameNAMEPut**
> ApiStatus FailoverLbGroupsNameNAMEPut (string NAME, FlbGroupCollection? flbGroupCollection = null)



Edit failover load balancing group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupApi(config);
            var NAME = "\"myFLBGroup\"";  // string | Failover & LB group name. (default to "myFLBGroup")
            var flbGroupCollection = new FlbGroupCollection?(); // FlbGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.FailoverLbGroupsNameNAMEPut(NAME, flbGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.FailoverLbGroupsNameNAMEPutWithHttpInfo(NAME, flbGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Failover &amp; LB group name. | [default to &quot;myFLBGroup&quot;] |
| **flbGroupCollection** | [**FlbGroupCollection?**](FlbGroupCollection?.md) |  | [optional]  |

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

<a id="failoverlbgroupsput"></a>
# **FailoverLbGroupsPut**
> ApiStatus FailoverLbGroupsPut (FlbGroupCollection? flbGroupCollection = null)



Edit failover load balancing group object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class FailoverLbGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FlbGroupApi(config);
            var flbGroupCollection = new FlbGroupCollection?(); // FlbGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.FailoverLbGroupsPut(flbGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FailoverLbGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.FailoverLbGroupsPutWithHttpInfo(flbGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlbGroupApi.FailoverLbGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **flbGroupCollection** | [**FlbGroupCollection?**](FlbGroupCollection?.md) |  | [optional]  |

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

