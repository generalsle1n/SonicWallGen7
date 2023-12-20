# SonicWallGen7.Api.LogSyslogServersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LogSyslogSyslogServersGet**](LogSyslogServersApi.md#logsyslogsyslogserversget) | **GET** /log/syslog/syslog-servers |  |
| [**LogSyslogSyslogServersPatch**](LogSyslogServersApi.md#logsyslogsyslogserverspatch) | **PATCH** /log/syslog/syslog-servers |  |
| [**LogSyslogSyslogServersPost**](LogSyslogServersApi.md#logsyslogsyslogserverspost) | **POST** /log/syslog/syslog-servers |  |
| [**LogSyslogSyslogServersPut**](LogSyslogServersApi.md#logsyslogsyslogserversput) | **PUT** /log/syslog/syslog-servers |  |
| [**LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDelete**](LogSyslogServersApi.md#logsyslogsyslogserversserversrvnameportportidprofileproiddelete) | **DELETE** /log/syslog/syslog-servers/server/{SRVNAME}/port/{PORTID}/profile/{PROID} |  |
| [**LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGet**](LogSyslogServersApi.md#logsyslogsyslogserversserversrvnameportportidprofileproidget) | **GET** /log/syslog/syslog-servers/server/{SRVNAME}/port/{PORTID}/profile/{PROID} |  |
| [**LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatch**](LogSyslogServersApi.md#logsyslogsyslogserversserversrvnameportportidprofileproidpatch) | **PATCH** /log/syslog/syslog-servers/server/{SRVNAME}/port/{PORTID}/profile/{PROID} |  |
| [**LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPut**](LogSyslogServersApi.md#logsyslogsyslogserversserversrvnameportportidprofileproidput) | **PUT** /log/syslog/syslog-servers/server/{SRVNAME}/port/{PORTID}/profile/{PROID} |  |

<a id="logsyslogsyslogserversget"></a>
# **LogSyslogSyslogServersGet**
> LogSyslogServersCollection LogSyslogSyslogServersGet ()



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
    public class LogSyslogSyslogServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);

            try
            {
                LogSyslogServersCollection result = apiInstance.LogSyslogSyslogServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LogSyslogServersCollection> response = apiInstance.LogSyslogSyslogServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LogSyslogServersCollection**](LogSyslogServersCollection.md)

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

<a id="logsyslogsyslogserverspatch"></a>
# **LogSyslogSyslogServersPatch**
> ApiStatus LogSyslogSyslogServersPatch (LogSyslogServersCollection? logSyslogServersCollection = null)



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
    public class LogSyslogSyslogServersPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var logSyslogServersCollection = new LogSyslogServersCollection?(); // LogSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogSyslogSyslogServersPatch(logSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogSyslogSyslogServersPatchWithHttpInfo(logSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logSyslogServersCollection** | [**LogSyslogServersCollection?**](LogSyslogServersCollection?.md) |  | [optional]  |

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

<a id="logsyslogsyslogserverspost"></a>
# **LogSyslogSyslogServersPost**
> ApiStatus LogSyslogSyslogServersPost (LogSyslogServersCollection? logSyslogServersCollection = null)



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
    public class LogSyslogSyslogServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var logSyslogServersCollection = new LogSyslogServersCollection?(); // LogSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogSyslogSyslogServersPost(logSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogSyslogSyslogServersPostWithHttpInfo(logSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logSyslogServersCollection** | [**LogSyslogServersCollection?**](LogSyslogServersCollection?.md) |  | [optional]  |

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

<a id="logsyslogsyslogserversput"></a>
# **LogSyslogSyslogServersPut**
> ApiStatus LogSyslogSyslogServersPut (LogSyslogServersCollection? logSyslogServersCollection = null)



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
    public class LogSyslogSyslogServersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var logSyslogServersCollection = new LogSyslogServersCollection?(); // LogSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogSyslogSyslogServersPut(logSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogSyslogSyslogServersPutWithHttpInfo(logSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logSyslogServersCollection** | [**LogSyslogServersCollection?**](LogSyslogServersCollection?.md) |  | [optional]  |

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

<a id="logsyslogsyslogserversserversrvnameportportidprofileproiddelete"></a>
# **LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDelete**
> ApiStatus LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDelete (string SRVNAME, decimal PORTID, decimal PROID)



Delete an syslog server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var SRVNAME = "\"abc\"";  // string | Syslog custom server in the form: hostname OR a.b.c.d. (default to "abc")
            var PORTID = 8.14D;  // decimal | Syslog custom server port.
            var PROID = 8.14D;  // decimal | Syslog server profile.

            try
            {
                ApiStatus result = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDelete(SRVNAME, PORTID, PROID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDeleteWithHttpInfo(SRVNAME, PORTID, PROID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRVNAME** | **string** | Syslog custom server in the form: hostname OR a.b.c.d. | [default to &quot;abc&quot;] |
| **PORTID** | **decimal** | Syslog custom server port. |  |
| **PROID** | **decimal** | Syslog server profile. |  |

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

<a id="logsyslogsyslogserversserversrvnameportportidprofileproidget"></a>
# **LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGet**
> LogSyslogServersCollection LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGet (string SRVNAME, decimal PORTID, decimal PROID)



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
    public class LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var SRVNAME = "\"abc\"";  // string | Syslog custom server in the form: hostname OR a.b.c.d. (default to "abc")
            var PORTID = 8.14D;  // decimal | Syslog custom server port.
            var PROID = 8.14D;  // decimal | Syslog server profile.

            try
            {
                LogSyslogServersCollection result = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGet(SRVNAME, PORTID, PROID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LogSyslogServersCollection> response = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGetWithHttpInfo(SRVNAME, PORTID, PROID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRVNAME** | **string** | Syslog custom server in the form: hostname OR a.b.c.d. | [default to &quot;abc&quot;] |
| **PORTID** | **decimal** | Syslog custom server port. |  |
| **PROID** | **decimal** | Syslog server profile. |  |

### Return type

[**LogSyslogServersCollection**](LogSyslogServersCollection.md)

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

<a id="logsyslogsyslogserversserversrvnameportportidprofileproidpatch"></a>
# **LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatch**
> ApiStatus LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatch (string SRVNAME, decimal PORTID, decimal PROID, LogSyslogServersCollection? logSyslogServersCollection = null)



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
    public class LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var SRVNAME = "\"abc\"";  // string | Syslog custom server in the form: hostname OR a.b.c.d. (default to "abc")
            var PORTID = 8.14D;  // decimal | Syslog custom server port.
            var PROID = 8.14D;  // decimal | Syslog server profile.
            var logSyslogServersCollection = new LogSyslogServersCollection?(); // LogSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatch(SRVNAME, PORTID, PROID, logSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatchWithHttpInfo(SRVNAME, PORTID, PROID, logSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRVNAME** | **string** | Syslog custom server in the form: hostname OR a.b.c.d. | [default to &quot;abc&quot;] |
| **PORTID** | **decimal** | Syslog custom server port. |  |
| **PROID** | **decimal** | Syslog server profile. |  |
| **logSyslogServersCollection** | [**LogSyslogServersCollection?**](LogSyslogServersCollection?.md) |  | [optional]  |

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

<a id="logsyslogsyslogserversserversrvnameportportidprofileproidput"></a>
# **LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPut**
> ApiStatus LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPut (string SRVNAME, decimal PORTID, decimal PROID, LogSyslogServersCollection? logSyslogServersCollection = null)



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
    public class LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LogSyslogServersApi(config);
            var SRVNAME = "\"abc\"";  // string | Syslog custom server in the form: hostname OR a.b.c.d. (default to "abc")
            var PORTID = 8.14D;  // decimal | Syslog custom server port.
            var PROID = 8.14D;  // decimal | Syslog server profile.
            var logSyslogServersCollection = new LogSyslogServersCollection?(); // LogSyslogServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPut(SRVNAME, PORTID, PROID, logSyslogServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPutWithHttpInfo(SRVNAME, PORTID, PROID, logSyslogServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogSyslogServersApi.LogSyslogSyslogServersServerSRVNAMEPortPORTIDProfilePROIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRVNAME** | **string** | Syslog custom server in the form: hostname OR a.b.c.d. | [default to &quot;abc&quot;] |
| **PORTID** | **decimal** | Syslog custom server port. |  |
| **PROID** | **decimal** | Syslog server profile. |  |
| **logSyslogServersCollection** | [**LogSyslogServersCollection?**](LogSyslogServersCollection?.md) |  | [optional]  |

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

