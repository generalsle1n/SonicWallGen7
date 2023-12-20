# SonicWallGen7.Api.InterfaceIpIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingInterfacesIpv6IpGet**](InterfaceIpIpv6Api.md#reportinginterfacesipv6ipget) | **GET** /reporting/interfaces/ipv6/ip |  |
| [**ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGet**](InterfaceIpIpv6Api.md#reportinginterfacesipv6ipnamenamevlanvlanidget) | **GET** /reporting/interfaces/ipv6/ip/name/{NAME}/vlan/{VLANID} |  |

<a id="reportinginterfacesipv6ipget"></a>
# **ReportingInterfacesIpv6IpGet**
> List&lt;ShowStatusInterfaceIpIpv6ListInner&gt; ReportingInterfacesIpv6IpGet ()



Retrieve interfaces IPv6 IP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6IpGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpIpv6Api(config);

            try
            {
                List<ShowStatusInterfaceIpIpv6ListInner> result = apiInstance.ReportingInterfacesIpv6IpGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpIpv6Api.ReportingInterfacesIpv6IpGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6IpGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusInterfaceIpIpv6ListInner>> response = apiInstance.ReportingInterfacesIpv6IpGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpIpv6Api.ReportingInterfacesIpv6IpGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusInterfaceIpIpv6ListInner&gt;**](ShowStatusInterfaceIpIpv6ListInner.md)

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

<a id="reportinginterfacesipv6ipnamenamevlanvlanidget"></a>
# **ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGet**
> ShowStatusInterfaceIpIpv6Detail ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGet (string NAME, decimal VLANID)



Retrieve interfaces IPv6 IP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpIpv6Api(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ShowStatusInterfaceIpIpv6Detail result = apiInstance.ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGet(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpIpv6Api.ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusInterfaceIpIpv6Detail> response = apiInstance.ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGetWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpIpv6Api.ReportingInterfacesIpv6IpNameNAMEVlanVLANIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **VLANID** | **decimal** | VLAN tag. |  |

### Return type

[**ShowStatusInterfaceIpIpv6Detail**](ShowStatusInterfaceIpIpv6Detail.md)

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

