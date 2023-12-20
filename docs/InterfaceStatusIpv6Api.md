# SonicWallGen7.Api.InterfaceStatusIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingInterfacesIpv6StatusGet**](InterfaceStatusIpv6Api.md#reportinginterfacesipv6statusget) | **GET** /reporting/interfaces/ipv6/status |  |
| [**ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGet**](InterfaceStatusIpv6Api.md#reportinginterfacesipv6statusnamenamevlanvlanidget) | **GET** /reporting/interfaces/ipv6/status/name/{NAME}/vlan/{VLANID} |  |

<a id="reportinginterfacesipv6statusget"></a>
# **ReportingInterfacesIpv6StatusGet**
> List&lt;ShowStatusInterfaceIpIpv6ListInner&gt; ReportingInterfacesIpv6StatusGet ()



Retrieve interfaces IPv6 status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6StatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceStatusIpv6Api(config);

            try
            {
                List<ShowStatusInterfaceIpIpv6ListInner> result = apiInstance.ReportingInterfacesIpv6StatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceStatusIpv6Api.ReportingInterfacesIpv6StatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6StatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusInterfaceIpIpv6ListInner>> response = apiInstance.ReportingInterfacesIpv6StatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceStatusIpv6Api.ReportingInterfacesIpv6StatusGetWithHttpInfo: " + e.Message);
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

<a id="reportinginterfacesipv6statusnamenamevlanvlanidget"></a>
# **ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGet**
> ShowStatusInterfaceIpIpv6Detail ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGet (string NAME, decimal VLANID)



Retrieve interfaces IPv6 status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceStatusIpv6Api(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ShowStatusInterfaceIpIpv6Detail result = apiInstance.ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGet(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceStatusIpv6Api.ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusInterfaceIpIpv6Detail> response = apiInstance.ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGetWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceStatusIpv6Api.ReportingInterfacesIpv6StatusNameNAMEVlanVLANIDGetWithHttpInfo: " + e.Message);
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

