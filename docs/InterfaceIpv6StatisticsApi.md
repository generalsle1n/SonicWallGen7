# SonicWallGen7.Api.InterfaceIpv6StatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingInterfacesIpv6StatisticsGet**](InterfaceIpv6StatisticsApi.md#reportinginterfacesipv6statisticsget) | **GET** /reporting/interfaces/ipv6/statistics |  |
| [**ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDelete**](InterfaceIpv6StatisticsApi.md#reportinginterfacesipv6statisticsnamenamevlanvlaniddelete) | **DELETE** /reporting/interfaces/ipv6/statistics/name/{NAME}/vlan/{VLANID} |  |
| [**ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGet**](InterfaceIpv6StatisticsApi.md#reportinginterfacesipv6statisticsnamenamevlanvlanidget) | **GET** /reporting/interfaces/ipv6/statistics/name/{NAME}/vlan/{VLANID} |  |

<a id="reportinginterfacesipv6statisticsget"></a>
# **ReportingInterfacesIpv6StatisticsGet**
> List&lt;ShowStatusInterfaceListInner&gt; ReportingInterfacesIpv6StatisticsGet ()



Retrieve IPv6 interfaces statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6StatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6StatisticsApi(config);

            try
            {
                List<ShowStatusInterfaceListInner> result = apiInstance.ReportingInterfacesIpv6StatisticsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6StatisticsApi.ReportingInterfacesIpv6StatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6StatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusInterfaceListInner>> response = apiInstance.ReportingInterfacesIpv6StatisticsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6StatisticsApi.ReportingInterfacesIpv6StatisticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusInterfaceListInner&gt;**](ShowStatusInterfaceListInner.md)

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

<a id="reportinginterfacesipv6statisticsnamenamevlanvlaniddelete"></a>
# **ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDelete**
> ApiStatus ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDelete (string NAME, decimal VLANID)



Clear IPv6 interfaces statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6StatisticsApi(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ApiStatus result = apiInstance.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDelete(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6StatisticsApi.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDeleteWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6StatisticsApi.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDDeleteWithHttpInfo: " + e.Message);
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

<a id="reportinginterfacesipv6statisticsnamenamevlanvlanidget"></a>
# **ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGet**
> ShowStatusInterfaceIpv6Detail ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGet (string NAME, decimal VLANID)



Retrieve IPv6 interfaces statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv6StatisticsApi(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ShowStatusInterfaceIpv6Detail result = apiInstance.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGet(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv6StatisticsApi.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusInterfaceIpv6Detail> response = apiInstance.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGetWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv6StatisticsApi.ReportingInterfacesIpv6StatisticsNameNAMEVlanVLANIDGetWithHttpInfo: " + e.Message);
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

[**ShowStatusInterfaceIpv6Detail**](ShowStatusInterfaceIpv6Detail.md)

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

