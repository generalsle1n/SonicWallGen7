# SonicWallGen7.Api.DhcpServerIpv6LeasesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDhcpServerIpv6LeasesStatusGet**](DhcpServerIpv6LeasesApi.md#reportingdhcpserveripv6leasesstatusget) | **GET** /reporting/dhcp-server/ipv6/leases/status |  |
| [**ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Delete**](DhcpServerIpv6LeasesApi.md#reportingdhcpserveripv6leasesstatusipleaseipv6delete) | **DELETE** /reporting/dhcp-server/ipv6/leases/status/ip/{LEASEIPV6} |  |
| [**ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Get**](DhcpServerIpv6LeasesApi.md#reportingdhcpserveripv6leasesstatusipleaseipv6get) | **GET** /reporting/dhcp-server/ipv6/leases/status/ip/{LEASEIPV6} |  |

<a id="reportingdhcpserveripv6leasesstatusget"></a>
# **ReportingDhcpServerIpv6LeasesStatusGet**
> List&lt;ShowStatusDhcps6LeasesListInner&gt; ReportingDhcpServerIpv6LeasesStatusGet ()



Retrieve DHCP server IPv6 leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv6LeasesStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6LeasesApi(config);

            try
            {
                List<ShowStatusDhcps6LeasesListInner> result = apiInstance.ReportingDhcpServerIpv6LeasesStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6LeasesApi.ReportingDhcpServerIpv6LeasesStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv6LeasesStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcps6LeasesListInner>> response = apiInstance.ReportingDhcpServerIpv6LeasesStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6LeasesApi.ReportingDhcpServerIpv6LeasesStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDhcps6LeasesListInner&gt;**](ShowStatusDhcps6LeasesListInner.md)

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

<a id="reportingdhcpserveripv6leasesstatusipleaseipv6delete"></a>
# **ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Delete**
> ApiStatus ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Delete (string lEASEIPV6)



Clear IPv6 DHCP server leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6LeasesApi(config);
            var lEASEIPV6 = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPv6 DHCP server lease IP. (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")

            try
            {
                ApiStatus result = apiInstance.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Delete(lEASEIPV6);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6LeasesApi.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6DeleteWithHttpInfo(lEASEIPV6);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6LeasesApi.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lEASEIPV6** | **string** | IPv6 DHCP server lease IP. | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |

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

<a id="reportingdhcpserveripv6leasesstatusipleaseipv6get"></a>
# **ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Get**
> List&lt;ShowStatusDhcps6LeasesListInner&gt; ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Get (string lEASEIPV6)



Retrieve DHCP server IPv6 leases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6LeasesApi(config);
            var lEASEIPV6 = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPv6 DHCP server lease IP. (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")

            try
            {
                List<ShowStatusDhcps6LeasesListInner> result = apiInstance.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Get(lEASEIPV6);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6LeasesApi.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcps6LeasesListInner>> response = apiInstance.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6GetWithHttpInfo(lEASEIPV6);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6LeasesApi.ReportingDhcpServerIpv6LeasesStatusIpLEASEIPV6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lEASEIPV6** | **string** | IPv6 DHCP server lease IP. | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |

### Return type

[**List&lt;ShowStatusDhcps6LeasesListInner&gt;**](ShowStatusDhcps6LeasesListInner.md)

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

