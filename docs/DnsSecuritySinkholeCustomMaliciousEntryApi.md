# SonicWallGen7.Api.DnsSecuritySinkholeCustomMaliciousEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DnsSecurityDnsSinkholeCustomMaliciousEntriesGet**](DnsSecuritySinkholeCustomMaliciousEntryApi.md#dnssecuritydnssinkholecustommaliciousentriesget) | **GET** /dns-security/dns-sinkhole/custom-malicious-entries |  |
| [**DnsSecurityDnsSinkholeCustomMaliciousEntriesPost**](DnsSecuritySinkholeCustomMaliciousEntryApi.md#dnssecuritydnssinkholecustommaliciousentriespost) | **POST** /dns-security/dns-sinkhole/custom-malicious-entries |  |

<a id="dnssecuritydnssinkholecustommaliciousentriesget"></a>
# **DnsSecurityDnsSinkholeCustomMaliciousEntriesGet**
> DnsSecuritySinkholeCustomMaliciousEntryCollection DnsSecurityDnsSinkholeCustomMaliciousEntriesGet ()



Retrieve DNS security sinkhole custom malicious entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsSinkholeCustomMaliciousEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecuritySinkholeCustomMaliciousEntryApi(config);

            try
            {
                DnsSecuritySinkholeCustomMaliciousEntryCollection result = apiInstance.DnsSecurityDnsSinkholeCustomMaliciousEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecuritySinkholeCustomMaliciousEntryApi.DnsSecurityDnsSinkholeCustomMaliciousEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsSinkholeCustomMaliciousEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DnsSecuritySinkholeCustomMaliciousEntryCollection> response = apiInstance.DnsSecurityDnsSinkholeCustomMaliciousEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecuritySinkholeCustomMaliciousEntryApi.DnsSecurityDnsSinkholeCustomMaliciousEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DnsSecuritySinkholeCustomMaliciousEntryCollection**](DnsSecuritySinkholeCustomMaliciousEntryCollection.md)

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

<a id="dnssecuritydnssinkholecustommaliciousentriespost"></a>
# **DnsSecurityDnsSinkholeCustomMaliciousEntriesPost**
> ApiStatus DnsSecurityDnsSinkholeCustomMaliciousEntriesPost (DnsSecuritySinkholeCustomMaliciousEntryCollection? dnsSecuritySinkholeCustomMaliciousEntryCollection = null)



Create a new DNS security sinkhole custom malicious entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DnsSecurityDnsSinkholeCustomMaliciousEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DnsSecuritySinkholeCustomMaliciousEntryApi(config);
            var dnsSecuritySinkholeCustomMaliciousEntryCollection = new DnsSecuritySinkholeCustomMaliciousEntryCollection?(); // DnsSecuritySinkholeCustomMaliciousEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DnsSecurityDnsSinkholeCustomMaliciousEntriesPost(dnsSecuritySinkholeCustomMaliciousEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DnsSecuritySinkholeCustomMaliciousEntryApi.DnsSecurityDnsSinkholeCustomMaliciousEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DnsSecurityDnsSinkholeCustomMaliciousEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DnsSecurityDnsSinkholeCustomMaliciousEntriesPostWithHttpInfo(dnsSecuritySinkholeCustomMaliciousEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DnsSecuritySinkholeCustomMaliciousEntryApi.DnsSecurityDnsSinkholeCustomMaliciousEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSecuritySinkholeCustomMaliciousEntryCollection** | [**DnsSecuritySinkholeCustomMaliciousEntryCollection?**](DnsSecuritySinkholeCustomMaliciousEntryCollection?.md) |  | [optional]  |

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

