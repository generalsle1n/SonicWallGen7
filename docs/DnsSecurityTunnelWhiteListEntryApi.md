# SonicWallGen7.Api.DnsSecurityTunnelWhiteListEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsSecurityDnsTunnelWhiteListEntriesGet**](DnsSecurityTunnelWhiteListEntryApi.md#dnssecuritydnstunnelwhitelistentriesget) | **GET** /dns-security/dns-tunnel/white-list-entries |  |
| [**DnsSecurityDnsTunnelWhiteListEntriesPost**](DnsSecurityTunnelWhiteListEntryApi.md#dnssecuritydnstunnelwhitelistentriespost) | **POST** /dns-security/dns-tunnel/white-list-entries |  |

<a id="dnssecuritydnstunnelwhitelistentriesget"></a>
# **DnsSecurityDnsTunnelWhiteListEntriesGet**
> DnsSecurityTunnelWhiteListEntryCollection DnsSecurityDnsTunnelWhiteListEntriesGet ()



Retrieve DNS security tunnel white list entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsTunnelWhiteListEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecurityTunnelWhiteListEntryApi(config);

            try
            {
                DnsSecurityTunnelWhiteListEntryCollection result = apiInstance.DnsSecurityDnsTunnelWhiteListEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsSecurityTunnelWhiteListEntryCollection> response = apiInstance.DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DnsSecurityTunnelWhiteListEntryCollection**](DnsSecurityTunnelWhiteListEntryCollection.md)

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

<a id="dnssecuritydnstunnelwhitelistentriespost"></a>
# **DnsSecurityDnsTunnelWhiteListEntriesPost**
> ApiStatus DnsSecurityDnsTunnelWhiteListEntriesPost (DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = null)



Create a new DNS security tunnel white list entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsTunnelWhiteListEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecurityTunnelWhiteListEntryApi(config);
            var dnsSecurityTunnelWhiteListEntryCollection = new DnsSecurityTunnelWhiteListEntryCollection?(); // DnsSecurityTunnelWhiteListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSecurityDnsTunnelWhiteListEntriesPost(dnsSecurityTunnelWhiteListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfo(dnsSecurityTunnelWhiteListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSecurityTunnelWhiteListEntryCollection** | [**DnsSecurityTunnelWhiteListEntryCollection?**](DnsSecurityTunnelWhiteListEntryCollection?.md) |  | [optional]  |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

