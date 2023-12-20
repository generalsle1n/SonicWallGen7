# SonicWallGen7.Api.LogViewpointSyslogServersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LogViewpointSyslogServersGet**](LogViewpointSyslogServersApi.md#logviewpointsyslogserversget) | **GET** /log/viewpoint/syslog-servers |  |
| [**LogViewpointSyslogServersPatch**](LogViewpointSyslogServersApi.md#logviewpointsyslogserverspatch) | **PATCH** /log/viewpoint/syslog-servers |  |
| [**LogViewpointSyslogServersPost**](LogViewpointSyslogServersApi.md#logviewpointsyslogserverspost) | **POST** /log/viewpoint/syslog-servers |  |
| [**LogViewpointSyslogServersPut**](LogViewpointSyslogServersApi.md#logviewpointsyslogserversput) | **PUT** /log/viewpoint/syslog-servers |  |

<a id="logviewpointsyslogserversget"></a>
# **LogViewpointSyslogServersGet**
> LogViewpointSyslogServersCollection LogViewpointSyslogServersGet ()



Retrieve log syslog server settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogViewpointSyslogServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogViewpointSyslogServersApi(config);

            try
            {
                LogViewpointSyslogServersCollection result = apiInstance.LogViewpointSyslogServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogViewpointSyslogServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LogViewpointSyslogServersCollection> response = apiInstance.LogViewpointSyslogServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LogViewpointSyslogServersCollection**](LogViewpointSyslogServersCollection.md)

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

<a id="logviewpointsyslogserverspatch"></a>
# **LogViewpointSyslogServersPatch**
> ApiStatus LogViewpointSyslogServersPatch (LogViewpointSyslogServersCollection? logViewpointSyslogServersCollection = null)



Patch log syslog server settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogViewpointSyslogServersPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogViewpointSyslogServersApi(config);
            var logViewpointSyslogServersCollection = new LogViewpointSyslogServersCollection?(); // LogViewpointSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogViewpointSyslogServersPatch(logViewpointSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogViewpointSyslogServersPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogViewpointSyslogServersPatchWithHttpInfo(logViewpointSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logViewpointSyslogServersCollection** | [**LogViewpointSyslogServersCollection?**](LogViewpointSyslogServersCollection?.md) |  | [optional]  |

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

<a id="logviewpointsyslogserverspost"></a>
# **LogViewpointSyslogServersPost**
> ApiStatus LogViewpointSyslogServersPost (LogViewpointSyslogServersCollection? logViewpointSyslogServersCollection = null)



Add an syslog server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogViewpointSyslogServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogViewpointSyslogServersApi(config);
            var logViewpointSyslogServersCollection = new LogViewpointSyslogServersCollection?(); // LogViewpointSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogViewpointSyslogServersPost(logViewpointSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogViewpointSyslogServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogViewpointSyslogServersPostWithHttpInfo(logViewpointSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logViewpointSyslogServersCollection** | [**LogViewpointSyslogServersCollection?**](LogViewpointSyslogServersCollection?.md) |  | [optional]  |

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

<a id="logviewpointsyslogserversput"></a>
# **LogViewpointSyslogServersPut**
> ApiStatus LogViewpointSyslogServersPut (LogViewpointSyslogServersCollection? logViewpointSyslogServersCollection = null)



Update log syslog server settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogViewpointSyslogServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogViewpointSyslogServersApi(config);
            var logViewpointSyslogServersCollection = new LogViewpointSyslogServersCollection?(); // LogViewpointSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogViewpointSyslogServersPut(logViewpointSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogViewpointSyslogServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogViewpointSyslogServersPutWithHttpInfo(logViewpointSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogViewpointSyslogServersApi.LogViewpointSyslogServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logViewpointSyslogServersCollection** | [**LogViewpointSyslogServersCollection?**](LogViewpointSyslogServersCollection?.md) |  | [optional]  |

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

