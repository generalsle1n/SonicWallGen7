# SonicWallGen7.Api.DhcpOverVpnLeasesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDhcpOverVpnLeasesGet**](DhcpOverVpnLeasesApi.md#reportingdhcpovervpnleasesget) | **GET** /reporting/dhcp-over-vpn/leases |  |
| [**ReportingDhcpOverVpnLeasesIpLEASEIPDelete**](DhcpOverVpnLeasesApi.md#reportingdhcpovervpnleasesipleaseipdelete) | **DELETE** /reporting/dhcp-over-vpn/leases/ip/{LEASEIP} |  |
| [**ReportingDhcpOverVpnLeasesIpLEASEIPGet**](DhcpOverVpnLeasesApi.md#reportingdhcpovervpnleasesipleaseipget) | **GET** /reporting/dhcp-over-vpn/leases/ip/{LEASEIP} |  |

<a id="reportingdhcpovervpnleasesget"></a>
# **ReportingDhcpOverVpnLeasesGet**
> List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt; ReportingDhcpOverVpnLeasesGet ()



Retrieve DHCP over VPN leases

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpOverVpnLeasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnLeasesApi(config);

            try
            {
                List<ShowStatusDhcpOverVpnLeasesListInner> result = apiInstance.ReportingDhcpOverVpnLeasesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpOverVpnLeasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> response = apiInstance.ReportingDhcpOverVpnLeasesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;**](ShowStatusDhcpOverVpnLeasesListInner.md)

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

<a id="reportingdhcpovervpnleasesipleaseipdelete"></a>
# **ReportingDhcpOverVpnLeasesIpLEASEIPDelete**
> ApiStatus ReportingDhcpOverVpnLeasesIpLEASEIPDelete (string LEASEIP)



Clear DHCP over VPN leases

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpOverVpnLeasesIpLEASEIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnLeasesApi(config);
            var LEASEIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.ReportingDhcpOverVpnLeasesIpLEASEIPDelete(LEASEIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfo(LEASEIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfo: " + e.Message);
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

<a id="reportingdhcpovervpnleasesipleaseipget"></a>
# **ReportingDhcpOverVpnLeasesIpLEASEIPGet**
> List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt; ReportingDhcpOverVpnLeasesIpLEASEIPGet (string LEASEIP)



Retrieve DHCP over VPN leases

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDhcpOverVpnLeasesIpLEASEIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpOverVpnLeasesApi(config);
            var LEASEIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                List<ShowStatusDhcpOverVpnLeasesListInner> result = apiInstance.ReportingDhcpOverVpnLeasesIpLEASEIPGet(LEASEIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> response = apiInstance.ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfo(LEASEIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **LEASEIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

### Return type

[**List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;**](ShowStatusDhcpOverVpnLeasesListInner.md)

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

