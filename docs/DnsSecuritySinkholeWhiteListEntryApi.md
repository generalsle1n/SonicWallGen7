# SonicWallGen7.Api.DnsSecuritySinkholeWhiteListEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsSecurityDnsSinkholeWhiteListEntriesGet**](DnsSecuritySinkholeWhiteListEntryApi.md#dnssecuritydnssinkholewhitelistentriesget) | **GET** /dns-security/dns-sinkhole/white-list-entries |  |
| [**DnsSecurityDnsSinkholeWhiteListEntriesPost**](DnsSecuritySinkholeWhiteListEntryApi.md#dnssecuritydnssinkholewhitelistentriespost) | **POST** /dns-security/dns-sinkhole/white-list-entries |  |

<a id="dnssecuritydnssinkholewhitelistentriesget"></a>
# **DnsSecurityDnsSinkholeWhiteListEntriesGet**
> DnsSecuritySinkholeWhiteListEntryCollection DnsSecurityDnsSinkholeWhiteListEntriesGet ()



Retrieve DNS security sinkhole white list entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsSinkholeWhiteListEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecuritySinkholeWhiteListEntryApi(config);

            try
            {
                DnsSecuritySinkholeWhiteListEntryCollection result = apiInstance.DnsSecurityDnsSinkholeWhiteListEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecuritySinkholeWhiteListEntryApi.DnsSecurityDnsSinkholeWhiteListEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsSinkholeWhiteListEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsSecuritySinkholeWhiteListEntryCollection> response = apiInstance.DnsSecurityDnsSinkholeWhiteListEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecuritySinkholeWhiteListEntryApi.DnsSecurityDnsSinkholeWhiteListEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DnsSecuritySinkholeWhiteListEntryCollection**](DnsSecuritySinkholeWhiteListEntryCollection.md)

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

<a id="dnssecuritydnssinkholewhitelistentriespost"></a>
# **DnsSecurityDnsSinkholeWhiteListEntriesPost**
> ApiStatus DnsSecurityDnsSinkholeWhiteListEntriesPost (DnsSecuritySinkholeWhiteListEntryCollection? dnsSecuritySinkholeWhiteListEntryCollection = null)



Create a new DNS security sinkhole white list entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsSinkholeWhiteListEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecuritySinkholeWhiteListEntryApi(config);
            var dnsSecuritySinkholeWhiteListEntryCollection = new DnsSecuritySinkholeWhiteListEntryCollection?(); // DnsSecuritySinkholeWhiteListEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSecurityDnsSinkholeWhiteListEntriesPost(dnsSecuritySinkholeWhiteListEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecuritySinkholeWhiteListEntryApi.DnsSecurityDnsSinkholeWhiteListEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsSinkholeWhiteListEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSecurityDnsSinkholeWhiteListEntriesPostWithHttpInfo(dnsSecuritySinkholeWhiteListEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecuritySinkholeWhiteListEntryApi.DnsSecurityDnsSinkholeWhiteListEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSecuritySinkholeWhiteListEntryCollection** | [**DnsSecuritySinkholeWhiteListEntryCollection?**](DnsSecuritySinkholeWhiteListEntryCollection?.md) |  | [optional]  |

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

