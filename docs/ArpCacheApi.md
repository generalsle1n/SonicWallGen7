# SonicWallGen7.Api.ArpCacheApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingArpCacheIpIPInterfaceINTERFACENAMEDelete**](ArpCacheApi.md#reportingarpcacheipipinterfaceinterfacenamedelete) | **DELETE** /reporting/arp/cache/ip/{IP}/interface/{INTERFACENAME} |  |
| [**ReportingArpCacheIpIPInterfaceINTERFACENAMEGet**](ArpCacheApi.md#reportingarpcacheipipinterfaceinterfacenameget) | **GET** /reporting/arp/cache/ip/{IP}/interface/{INTERFACENAME} |  |

<a id="reportingarpcacheipipinterfaceinterfacenamedelete"></a>
# **ReportingArpCacheIpIPInterfaceINTERFACENAMEDelete**
> ApiStatus ReportingArpCacheIpIPInterfaceINTERFACENAMEDelete (string IP, string INTERFACENAME)



Clear ARP cache entry statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingArpCacheIpIPInterfaceINTERFACENAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpCacheApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var INTERFACENAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                ApiStatus result = apiInstance.ReportingArpCacheIpIPInterfaceINTERFACENAMEDelete(IP, INTERFACENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpCacheApi.ReportingArpCacheIpIPInterfaceINTERFACENAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingArpCacheIpIPInterfaceINTERFACENAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ReportingArpCacheIpIPInterfaceINTERFACENAMEDeleteWithHttpInfo(IP, INTERFACENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpCacheApi.ReportingArpCacheIpIPInterfaceINTERFACENAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **INTERFACENAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

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

<a id="reportingarpcacheipipinterfaceinterfacenameget"></a>
# **ReportingArpCacheIpIPInterfaceINTERFACENAMEGet**
> ShowStatusArpCacheDetail ReportingArpCacheIpIPInterfaceINTERFACENAMEGet (string IP, string INTERFACENAME)



Retrieve ARP cache statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingArpCacheIpIPInterfaceINTERFACENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpCacheApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var INTERFACENAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                ShowStatusArpCacheDetail result = apiInstance.ReportingArpCacheIpIPInterfaceINTERFACENAMEGet(IP, INTERFACENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpCacheApi.ReportingArpCacheIpIPInterfaceINTERFACENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingArpCacheIpIPInterfaceINTERFACENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusArpCacheDetail> response = apiInstance.ReportingArpCacheIpIPInterfaceINTERFACENAMEGetWithHttpInfo(IP, INTERFACENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpCacheApi.ReportingArpCacheIpIPInterfaceINTERFACENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **INTERFACENAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

### Return type

[**ShowStatusArpCacheDetail**](ShowStatusArpCacheDetail.md)

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

