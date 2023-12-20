# SonicWallGen7.Api.InterfaceIpv4StatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingInterfacesIpv4StatisticsGet**](InterfaceIpv4StatisticsApi.md#reportinginterfacesipv4statisticsget) | **GET** /reporting/interfaces/ipv4/statistics |  |
| [**ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDelete**](InterfaceIpv4StatisticsApi.md#reportinginterfacesipv4statisticsnamenamevlanvlaniddelete) | **DELETE** /reporting/interfaces/ipv4/statistics/name/{NAME}/vlan/{VLANID} |  |
| [**ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGet**](InterfaceIpv4StatisticsApi.md#reportinginterfacesipv4statisticsnamenamevlanvlanidget) | **GET** /reporting/interfaces/ipv4/statistics/name/{NAME}/vlan/{VLANID} |  |

<a id="reportinginterfacesipv4statisticsget"></a>
# **ReportingInterfacesIpv4StatisticsGet**
> List&lt;ShowStatusInterfaceListInner&gt; ReportingInterfacesIpv4StatisticsGet ()



Retrieve IPv4 interfaces statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv4StatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv4StatisticsApi(config);

            try
            {
                List<ShowStatusInterfaceListInner> result = apiInstance.ReportingInterfacesIpv4StatisticsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv4StatisticsApi.ReportingInterfacesIpv4StatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv4StatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusInterfaceListInner>> response = apiInstance.ReportingInterfacesIpv4StatisticsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv4StatisticsApi.ReportingInterfacesIpv4StatisticsGetWithHttpInfo: " + e.Message);
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

<a id="reportinginterfacesipv4statisticsnamenamevlanvlaniddelete"></a>
# **ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDelete**
> ApiStatus ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDelete (string NAME, decimal VLANID)



Clear IPv4 interfaces statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv4StatisticsApi(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ApiStatus result = apiInstance.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDelete(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv4StatisticsApi.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDeleteWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv4StatisticsApi.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDDeleteWithHttpInfo: " + e.Message);
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

<a id="reportinginterfacesipv4statisticsnamenamevlanvlanidget"></a>
# **ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGet**
> ShowStatusInterfaceDetail ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGet (string NAME, decimal VLANID)



Retrieve IPv4 interfaces statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InterfaceIpv4StatisticsApi(config);
            var NAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var VLANID = 8.14D;  // decimal | VLAN tag.

            try
            {
                ShowStatusInterfaceDetail result = apiInstance.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGet(NAME, VLANID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterfaceIpv4StatisticsApi.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusInterfaceDetail> response = apiInstance.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGetWithHttpInfo(NAME, VLANID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InterfaceIpv4StatisticsApi.ReportingInterfacesIpv4StatisticsNameNAMEVlanVLANIDGetWithHttpInfo: " + e.Message);
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

[**ShowStatusInterfaceDetail**](ShowStatusInterfaceDetail.md)

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

