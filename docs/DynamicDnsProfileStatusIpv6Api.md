# SonicWallGen7.Api.DynamicDnsProfileStatusIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDynamicDnsProfilesIpv6Get**](DynamicDnsProfileStatusIpv6Api.md#reportingdynamicdnsprofilesipv6get) | **GET** /reporting/dynamic-dns/profiles/ipv6 |  |
| [**ReportingDynamicDnsProfilesIpv6NameNAMEGet**](DynamicDnsProfileStatusIpv6Api.md#reportingdynamicdnsprofilesipv6namenameget) | **GET** /reporting/dynamic-dns/profiles/ipv6/name/{NAME} |  |

<a id="reportingdynamicdnsprofilesipv6get"></a>
# **ReportingDynamicDnsProfilesIpv6Get**
> List&lt;ShowStatusDynamicDnsStatusListInner&gt; ReportingDynamicDnsProfilesIpv6Get ()



Retrieve IPv6 dynamic DNS profiles status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDynamicDnsProfilesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileStatusIpv6Api(config);

            try
            {
                List<ShowStatusDynamicDnsStatusListInner> result = apiInstance.ReportingDynamicDnsProfilesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileStatusIpv6Api.ReportingDynamicDnsProfilesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDynamicDnsProfilesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDynamicDnsStatusListInner>> response = apiInstance.ReportingDynamicDnsProfilesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileStatusIpv6Api.ReportingDynamicDnsProfilesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusDynamicDnsStatusListInner&gt;**](ShowStatusDynamicDnsStatusListInner.md)

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

<a id="reportingdynamicdnsprofilesipv6namenameget"></a>
# **ReportingDynamicDnsProfilesIpv6NameNAMEGet**
> List&lt;ShowStatusDynamicDnsStatusListInner&gt; ReportingDynamicDnsProfilesIpv6NameNAMEGet (string NAME)



Retrieve IPv6 dynamic DNS profiles status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDynamicDnsProfilesIpv6NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileStatusIpv6Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")

            try
            {
                List<ShowStatusDynamicDnsStatusListInner> result = apiInstance.ReportingDynamicDnsProfilesIpv6NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileStatusIpv6Api.ReportingDynamicDnsProfilesIpv6NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDynamicDnsProfilesIpv6NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDynamicDnsStatusListInner>> response = apiInstance.ReportingDynamicDnsProfilesIpv6NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileStatusIpv6Api.ReportingDynamicDnsProfilesIpv6NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |

### Return type

[**List&lt;ShowStatusDynamicDnsStatusListInner&gt;**](ShowStatusDynamicDnsStatusListInner.md)

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

