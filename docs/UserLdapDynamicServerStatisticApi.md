# SonicWallGen7.Api.UserLdapDynamicServerStatisticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingLdapStatisticDynamicServersGet**](UserLdapDynamicServerStatisticApi.md#reportingldapstatisticdynamicserversget) | **GET** /reporting/ldap-statistic/dynamic-servers |  |
| [**ReportingLdapStatisticDynamicServersNameNAMEDelete**](UserLdapDynamicServerStatisticApi.md#reportingldapstatisticdynamicserversnamenamedelete) | **DELETE** /reporting/ldap-statistic/dynamic-servers/name/{NAME} |  |
| [**ReportingLdapStatisticDynamicServersNameNAMEGet**](UserLdapDynamicServerStatisticApi.md#reportingldapstatisticdynamicserversnamenameget) | **GET** /reporting/ldap-statistic/dynamic-servers/name/{NAME} |  |

<a id="reportingldapstatisticdynamicserversget"></a>
# **ReportingLdapStatisticDynamicServersGet**
> ShowStatusLdapServerStatisticsDetail ReportingLdapStatisticDynamicServersGet ()



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
    public class ReportingLdapStatisticDynamicServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapDynamicServerStatisticApi(config);

            try
            {
                ShowStatusLdapServerStatisticsDetail result = apiInstance.ReportingLdapStatisticDynamicServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapDynamicServerStatisticApi.ReportingLdapStatisticDynamicServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingLdapStatisticDynamicServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusLdapServerStatisticsDetail> response = apiInstance.ReportingLdapStatisticDynamicServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapDynamicServerStatisticApi.ReportingLdapStatisticDynamicServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusLdapServerStatisticsDetail**](ShowStatusLdapServerStatisticsDetail.md)

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

<a id="reportingldapstatisticdynamicserversnamenamedelete"></a>
# **ReportingLdapStatisticDynamicServersNameNAMEDelete**
> ApiStatus ReportingLdapStatisticDynamicServersNameNAMEDelete (string NAME)



clear user LDAP dynamic server statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingLdapStatisticDynamicServersNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapDynamicServerStatisticApi(config);
            var NAME = "\"LDAP-Server\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "LDAP-Server")

            try
            {
                ApiStatus result = apiInstance.ReportingLdapStatisticDynamicServersNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapDynamicServerStatisticApi.ReportingLdapStatisticDynamicServersNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingLdapStatisticDynamicServersNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingLdapStatisticDynamicServersNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapDynamicServerStatisticApi.ReportingLdapStatisticDynamicServersNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;LDAP-Server&quot;] |

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

<a id="reportingldapstatisticdynamicserversnamenameget"></a>
# **ReportingLdapStatisticDynamicServersNameNAMEGet**
> ShowStatusLdapServerStatisticsDetail ReportingLdapStatisticDynamicServersNameNAMEGet (string NAME)



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
    public class ReportingLdapStatisticDynamicServersNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLdapDynamicServerStatisticApi(config);
            var NAME = "\"LDAP-Server\"";  // string | Hostname in the form: hostname OR a.b.c.d (default to "LDAP-Server")

            try
            {
                ShowStatusLdapServerStatisticsDetail result = apiInstance.ReportingLdapStatisticDynamicServersNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLdapDynamicServerStatisticApi.ReportingLdapStatisticDynamicServersNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingLdapStatisticDynamicServersNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusLdapServerStatisticsDetail> response = apiInstance.ReportingLdapStatisticDynamicServersNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLdapDynamicServerStatisticApi.ReportingLdapStatisticDynamicServersNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Hostname in the form: hostname OR a.b.c.d | [default to &quot;LDAP-Server&quot;] |

### Return type

[**ShowStatusLdapServerStatisticsDetail**](ShowStatusLdapServerStatisticsDetail.md)

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

