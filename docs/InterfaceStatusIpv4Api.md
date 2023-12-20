# SonicWallGen7.Api.InterfaceStatusIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingInterfacesIpv4StatusGet**](InterfaceStatusIpv4Api.md#reportinginterfacesipv4statusget) | **GET** /reporting/interfaces/ipv4/status |  |
| [**ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGet**](InterfaceStatusIpv4Api.md#reportinginterfacesipv4statusnamenamevlanvlanidget) | **GET** /reporting/interfaces/ipv4/status/name/{NAME}/vlan/{VLANID} |  |

<a id="reportinginterfacesipv4statusget"></a>
# **ReportingInterfacesIpv4StatusGet**
> List&lt;ShowStatusInterfaceStatusListInner&gt; ReportingInterfacesIpv4StatusGet ()



Retrieve interfaces IPv4 status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv4StatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceStatusIpv4Api(config);

            try
            {
                List<ShowStatusInterfaceStatusListInner> result = apiInstance.ReportingInterfacesIpv4StatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceStatusIpv4Api.ReportingInterfacesIpv4StatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv4StatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusInterfaceStatusListInner>> response = apiInstance.ReportingInterfacesIpv4StatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceStatusIpv4Api.ReportingInterfacesIpv4StatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusInterfaceStatusListInner&gt;**](ShowStatusInterfaceStatusListInner.md)

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

<a id="reportinginterfacesipv4statusnamenamevlanvlanidget"></a>
# **ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGet**
> ShowStatusInterfaceStatusDetail ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGet (string NAME, decimal VLANID)



Retrieve interfaces IPv4 status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceStatusIpv4Api(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ShowStatusInterfaceStatusDetail result = apiInstance.ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGet(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceStatusIpv4Api.ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusInterfaceStatusDetail> response = apiInstance.ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGetWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceStatusIpv4Api.ReportingInterfacesIpv4StatusNameNAMEVlanVLANIDGetWithHttpInfo: " + e.Message);
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

[**ShowStatusInterfaceStatusDetail**](ShowStatusInterfaceStatusDetail.md)

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

