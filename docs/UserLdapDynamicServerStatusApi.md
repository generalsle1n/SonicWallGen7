# SonicWallGen7.Api.UserLdapDynamicServerStatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingLdapDynamicServersGet**](UserLdapDynamicServerStatusApi.md#reportingldapdynamicserversget) | **GET** /reporting/ldap/dynamic-servers |  |
| [**ReportingLdapDynamicServersNameNAMEDelete**](UserLdapDynamicServerStatusApi.md#reportingldapdynamicserversnamenamedelete) | **DELETE** /reporting/ldap/dynamic-servers/name/{NAME} |  |
| [**ReportingLdapDynamicServersNameNAMEGet**](UserLdapDynamicServerStatusApi.md#reportingldapdynamicserversnamenameget) | **GET** /reporting/ldap/dynamic-servers/name/{NAME} |  |

<a id="reportingldapdynamicserversget"></a>
# **ReportingLdapDynamicServersGet**
> List&lt;ShowStatusLdapDynamicServerStatusListInner&gt; ReportingLdapDynamicServersGet ()



Retrieve LDAP dynamic server statistic.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingLdapDynamicServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapDynamicServerStatusApi(config);

            try
            {
                List<ShowStatusLdapDynamicServerStatusListInner> result = apiInstance.ReportingLdapDynamicServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapDynamicServerStatusApi.ReportingLdapDynamicServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingLdapDynamicServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusLdapDynamicServerStatusListInner>> response = apiInstance.ReportingLdapDynamicServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapDynamicServerStatusApi.ReportingLdapDynamicServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusLdapDynamicServerStatusListInner&gt;**](ShowStatusLdapDynamicServerStatusListInner.md)

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

<a id="reportingldapdynamicserversnamenamedelete"></a>
# **ReportingLdapDynamicServersNameNAMEDelete**
> ApiStatus ReportingLdapDynamicServersNameNAMEDelete (string NAME)



Delete a ldap dynamic server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingLdapDynamicServersNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapDynamicServerStatusApi(config);
            var NAME = "\"LDAP-Dynamic-Server\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "LDAP-Dynamic-Server")

            try
            {
                ApiStatus result = apiInstance.ReportingLdapDynamicServersNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapDynamicServerStatusApi.ReportingLdapDynamicServersNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingLdapDynamicServersNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingLdapDynamicServersNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapDynamicServerStatusApi.ReportingLdapDynamicServersNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;LDAP-Dynamic-Server&quot;] |

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

<a id="reportingldapdynamicserversnamenameget"></a>
# **ReportingLdapDynamicServersNameNAMEGet**
> List&lt;ShowStatusLdapDynamicServerStatusListInner&gt; ReportingLdapDynamicServersNameNAMEGet (string NAME)



Retrieve LDAP dynamic server statistic.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingLdapDynamicServersNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapDynamicServerStatusApi(config);
            var NAME = "\"LDAP-Dynamic-Server\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "LDAP-Dynamic-Server")

            try
            {
                List<ShowStatusLdapDynamicServerStatusListInner> result = apiInstance.ReportingLdapDynamicServersNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapDynamicServerStatusApi.ReportingLdapDynamicServersNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingLdapDynamicServersNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusLdapDynamicServerStatusListInner>> response = apiInstance.ReportingLdapDynamicServersNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapDynamicServerStatusApi.ReportingLdapDynamicServersNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;LDAP-Dynamic-Server&quot;] |

### Return type

[**List&lt;ShowStatusLdapDynamicServerStatusListInner&gt;**](ShowStatusLdapDynamicServerStatusListInner.md)

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

