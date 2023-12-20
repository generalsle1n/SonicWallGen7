# SonicWallGen7.Api.DhcpServerIpv4LeasesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDhcpServerIpv4LeasesStatusGet**](DhcpServerIpv4LeasesApi.md#reportingdhcpserveripv4leasesstatusget) | **GET** /reporting/dhcp-server/ipv4/leases/status |  |
| [**ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDelete**](DhcpServerIpv4LeasesApi.md#reportingdhcpserveripv4leasesstatusipleaseipdelete) | **DELETE** /reporting/dhcp-server/ipv4/leases/status/ip/{LEASEIP} |  |
| [**ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGet**](DhcpServerIpv4LeasesApi.md#reportingdhcpserveripv4leasesstatusipleaseipget) | **GET** /reporting/dhcp-server/ipv4/leases/status/ip/{LEASEIP} |  |

<a id="reportingdhcpserveripv4leasesstatusget"></a>
# **ReportingDhcpServerIpv4LeasesStatusGet**
> List&lt;ShowStatusDhcpLeasesListInner&gt; ReportingDhcpServerIpv4LeasesStatusGet ()



Retrieve DHCP server IPv4 leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv4LeasesStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv4LeasesApi(config);

            try
            {
                List<ShowStatusDhcpLeasesListInner> result = apiInstance.ReportingDhcpServerIpv4LeasesStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv4LeasesApi.ReportingDhcpServerIpv4LeasesStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv4LeasesStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcpLeasesListInner>> response = apiInstance.ReportingDhcpServerIpv4LeasesStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv4LeasesApi.ReportingDhcpServerIpv4LeasesStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDhcpLeasesListInner&gt;**](ShowStatusDhcpLeasesListInner.md)

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

<a id="reportingdhcpserveripv4leasesstatusipleaseipdelete"></a>
# **ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDelete**
> ApiStatus ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDelete (string LEASEIP)



Clear DHCP server leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv4LeasesApi(config);
            var LEASEIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDelete(LEASEIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv4LeasesApi.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDeleteWithHttpInfo(LEASEIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv4LeasesApi.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **LEASEIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

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

<a id="reportingdhcpserveripv4leasesstatusipleaseipget"></a>
# **ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGet**
> List&lt;ShowStatusDhcpLeasesListInner&gt; ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGet (string LEASEIP)



Retrieve DHCP server IPv4 leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv4LeasesApi(config);
            var LEASEIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                List<ShowStatusDhcpLeasesListInner> result = apiInstance.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGet(LEASEIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv4LeasesApi.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcpLeasesListInner>> response = apiInstance.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGetWithHttpInfo(LEASEIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv4LeasesApi.ReportingDhcpServerIpv4LeasesStatusIpLEASEIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **LEASEIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

### Return type

[**List&lt;ShowStatusDhcpLeasesListInner&gt;**](ShowStatusDhcpLeasesListInner.md)

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

