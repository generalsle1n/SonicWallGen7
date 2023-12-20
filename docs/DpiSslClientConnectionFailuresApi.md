# SonicWallGen7.Api.DpiSslClientConnectionFailuresApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDpiSslClientConnectionFailuresGet**](DpiSslClientConnectionFailuresApi.md#reportingdpisslclientconnectionfailuresget) | **GET** /reporting/dpi-ssl/client/connection-failures |  |
| [**ReportingDpiSslClientConnectionFailuresNameCNAMEDelete**](DpiSslClientConnectionFailuresApi.md#reportingdpisslclientconnectionfailuresnamecnamedelete) | **DELETE** /reporting/dpi-ssl/client/connection-failures/name/{CNAME} |  |
| [**ReportingDpiSslClientConnectionFailuresNameCNAMEGet**](DpiSslClientConnectionFailuresApi.md#reportingdpisslclientconnectionfailuresnamecnameget) | **GET** /reporting/dpi-ssl/client/connection-failures/name/{CNAME} |  |

<a id="reportingdpisslclientconnectionfailuresget"></a>
# **ReportingDpiSslClientConnectionFailuresGet**
> List&lt;ShowStatusDpiSslClientConnectionFailuresListInner&gt; ReportingDpiSslClientConnectionFailuresGet ()



Retrieve DPI-SSL client connection failures statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDpiSslClientConnectionFailuresGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientConnectionFailuresApi(config);

            try
            {
                List<ShowStatusDpiSslClientConnectionFailuresListInner> result = apiInstance.ReportingDpiSslClientConnectionFailuresGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientConnectionFailuresApi.ReportingDpiSslClientConnectionFailuresGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDpiSslClientConnectionFailuresGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDpiSslClientConnectionFailuresListInner>> response = apiInstance.ReportingDpiSslClientConnectionFailuresGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientConnectionFailuresApi.ReportingDpiSslClientConnectionFailuresGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDpiSslClientConnectionFailuresListInner&gt;**](ShowStatusDpiSslClientConnectionFailuresListInner.md)

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

<a id="reportingdpisslclientconnectionfailuresnamecnamedelete"></a>
# **ReportingDpiSslClientConnectionFailuresNameCNAMEDelete**
> ApiStatus ReportingDpiSslClientConnectionFailuresNameCNAMEDelete (string CNAME)



Clear DPI-SSL client connection failure entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDpiSslClientConnectionFailuresNameCNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientConnectionFailuresApi(config);
            var CNAME = "\"update.software.cloud\"";  // string | Client connection failure entrY name (default to "update.software.cloud")

            try
            {
                ApiStatus result = apiInstance.ReportingDpiSslClientConnectionFailuresNameCNAMEDelete(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientConnectionFailuresApi.ReportingDpiSslClientConnectionFailuresNameCNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDpiSslClientConnectionFailuresNameCNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingDpiSslClientConnectionFailuresNameCNAMEDeleteWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientConnectionFailuresApi.ReportingDpiSslClientConnectionFailuresNameCNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Client connection failure entrY name | [default to &quot;update.software.cloud&quot;] |

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

<a id="reportingdpisslclientconnectionfailuresnamecnameget"></a>
# **ReportingDpiSslClientConnectionFailuresNameCNAMEGet**
> List&lt;ShowStatusDpiSslClientConnectionFailuresListInner&gt; ReportingDpiSslClientConnectionFailuresNameCNAMEGet (string CNAME)



Retrieve DPI-SSL client connection failures statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDpiSslClientConnectionFailuresNameCNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslClientConnectionFailuresApi(config);
            var CNAME = "\"update.software.cloud\"";  // string | Client connection failure entrY name (default to "update.software.cloud")

            try
            {
                List<ShowStatusDpiSslClientConnectionFailuresListInner> result = apiInstance.ReportingDpiSslClientConnectionFailuresNameCNAMEGet(CNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslClientConnectionFailuresApi.ReportingDpiSslClientConnectionFailuresNameCNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDpiSslClientConnectionFailuresNameCNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDpiSslClientConnectionFailuresListInner>> response = apiInstance.ReportingDpiSslClientConnectionFailuresNameCNAMEGetWithHttpInfo(CNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslClientConnectionFailuresApi.ReportingDpiSslClientConnectionFailuresNameCNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CNAME** | **string** | Client connection failure entrY name | [default to &quot;update.software.cloud&quot;] |

### Return type

[**List&lt;ShowStatusDpiSslClientConnectionFailuresListInner&gt;**](ShowStatusDpiSslClientConnectionFailuresListInner.md)

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

