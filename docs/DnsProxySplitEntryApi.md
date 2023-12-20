# SonicWallGen7.Api.DnsProxySplitEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDnsProxySplitEntriesGet**](DnsProxySplitEntryApi.md#reportingdnsproxysplitentriesget) | **GET** /reporting/dns-proxy/split-entries |  |
| [**ReportingDnsProxySplitEntriesNameNAMEGet**](DnsProxySplitEntryApi.md#reportingdnsproxysplitentriesnamenameget) | **GET** /reporting/dns-proxy/split-entries/name/{NAME} |  |

<a id="reportingdnsproxysplitentriesget"></a>
# **ReportingDnsProxySplitEntriesGet**
> List&lt;ShowStatusDnsProxySplitEntriesListInner&gt; ReportingDnsProxySplitEntriesGet ()



Retrieve DNS proxy split entries statucs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDnsProxySplitEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxySplitEntryApi(config);

            try
            {
                List<ShowStatusDnsProxySplitEntriesListInner> result = apiInstance.ReportingDnsProxySplitEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxySplitEntryApi.ReportingDnsProxySplitEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDnsProxySplitEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDnsProxySplitEntriesListInner>> response = apiInstance.ReportingDnsProxySplitEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxySplitEntryApi.ReportingDnsProxySplitEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDnsProxySplitEntriesListInner&gt;**](ShowStatusDnsProxySplitEntriesListInner.md)

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

<a id="reportingdnsproxysplitentriesnamenameget"></a>
# **ReportingDnsProxySplitEntriesNameNAMEGet**
> List&lt;ShowStatusDnsProxySplitEntriesListInner&gt; ReportingDnsProxySplitEntriesNameNAMEGet (string NAME)



Retrieve DNS proxy split entries statucs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDnsProxySplitEntriesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsProxySplitEntryApi(config);
            var NAME = "\"sonicwall.com\"";  // string | Split DNS entry domain name (default to "sonicwall.com")

            try
            {
                List<ShowStatusDnsProxySplitEntriesListInner> result = apiInstance.ReportingDnsProxySplitEntriesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsProxySplitEntryApi.ReportingDnsProxySplitEntriesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDnsProxySplitEntriesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDnsProxySplitEntriesListInner>> response = apiInstance.ReportingDnsProxySplitEntriesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsProxySplitEntryApi.ReportingDnsProxySplitEntriesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Split DNS entry domain name | [default to &quot;sonicwall.com&quot;] |

### Return type

[**List&lt;ShowStatusDnsProxySplitEntriesListInner&gt;**](ShowStatusDnsProxySplitEntriesListInner.md)

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

