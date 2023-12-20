# SonicWallGen7.Api.DnsProxyCacheIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDnsProxyCachesIpv4Get**](DnsProxyCacheIpv4Api.md#reportingdnsproxycachesipv4get) | **GET** /reporting/dns-proxy/caches/ipv4 |  |
| [**ReportingDnsProxyCachesIpv4NameNAMEGet**](DnsProxyCacheIpv4Api.md#reportingdnsproxycachesipv4namenameget) | **GET** /reporting/dns-proxy/caches/ipv4/name/{NAME} |  |

<a id="reportingdnsproxycachesipv4get"></a>
# **ReportingDnsProxyCachesIpv4Get**
> List&lt;ShowStatusDnsProxyCacheListInner&gt; ReportingDnsProxyCachesIpv4Get ()



Retrieve DNS proxy IPv4 DNS caches statucs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDnsProxyCachesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheIpv4Api(config);

            try
            {
                List<ShowStatusDnsProxyCacheListInner> result = apiInstance.ReportingDnsProxyCachesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheIpv4Api.ReportingDnsProxyCachesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDnsProxyCachesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDnsProxyCacheListInner>> response = apiInstance.ReportingDnsProxyCachesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheIpv4Api.ReportingDnsProxyCachesIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDnsProxyCacheListInner&gt;**](ShowStatusDnsProxyCacheListInner.md)

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

<a id="reportingdnsproxycachesipv4namenameget"></a>
# **ReportingDnsProxyCachesIpv4NameNAMEGet**
> List&lt;ShowStatusDnsProxyCacheListInner&gt; ReportingDnsProxyCachesIpv4NameNAMEGet (string NAME)



Retrieve DNS proxy IPv4 DNS caches statucs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDnsProxyCachesIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxyCacheIpv4Api(config);
            var NAME = "\"sonicwall.com\"";  // string | DNS proxy cache domain name. (default to "sonicwall.com")

            try
            {
                List<ShowStatusDnsProxyCacheListInner> result = apiInstance.ReportingDnsProxyCachesIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxyCacheIpv4Api.ReportingDnsProxyCachesIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDnsProxyCachesIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDnsProxyCacheListInner>> response = apiInstance.ReportingDnsProxyCachesIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxyCacheIpv4Api.ReportingDnsProxyCachesIpv4NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DNS proxy cache domain name. | [default to &quot;sonicwall.com&quot;] |

### Return type

[**List&lt;ShowStatusDnsProxyCacheListInner&gt;**](ShowStatusDnsProxyCacheListInner.md)

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

