# SonicWallGen7.Api.DynamicDnsProfileStatusIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingDynamicDnsProfilesIpv4Get**](DynamicDnsProfileStatusIpv4Api.md#reportingdynamicdnsprofilesipv4get) | **GET** /reporting/dynamic-dns/profiles/ipv4 |  |
| [**ReportingDynamicDnsProfilesIpv4NameNAMEGet**](DynamicDnsProfileStatusIpv4Api.md#reportingdynamicdnsprofilesipv4namenameget) | **GET** /reporting/dynamic-dns/profiles/ipv4/name/{NAME} |  |

<a id="reportingdynamicdnsprofilesipv4get"></a>
# **ReportingDynamicDnsProfilesIpv4Get**
> List&lt;ShowStatusDynamicDnsStatusListInner&gt; ReportingDynamicDnsProfilesIpv4Get ()



Retrieve IPv4 dynamic DNS profiles status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDynamicDnsProfilesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileStatusIpv4Api(config);

            try
            {
                List<ShowStatusDynamicDnsStatusListInner> result = apiInstance.ReportingDynamicDnsProfilesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileStatusIpv4Api.ReportingDynamicDnsProfilesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDynamicDnsProfilesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDynamicDnsStatusListInner>> response = apiInstance.ReportingDynamicDnsProfilesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileStatusIpv4Api.ReportingDynamicDnsProfilesIpv4GetWithHttpInfo: " + e.Message);
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

<a id="reportingdynamicdnsprofilesipv4namenameget"></a>
# **ReportingDynamicDnsProfilesIpv4NameNAMEGet**
> List&lt;ShowStatusDynamicDnsStatusListInner&gt; ReportingDynamicDnsProfilesIpv4NameNAMEGet (string NAME)



Retrieve IPv4 dynamic DNS profiles status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingDynamicDnsProfilesIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileStatusIpv4Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")

            try
            {
                List<ShowStatusDynamicDnsStatusListInner> result = apiInstance.ReportingDynamicDnsProfilesIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileStatusIpv4Api.ReportingDynamicDnsProfilesIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingDynamicDnsProfilesIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusDynamicDnsStatusListInner>> response = apiInstance.ReportingDynamicDnsProfilesIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileStatusIpv4Api.ReportingDynamicDnsProfilesIpv4NameNAMEGetWithHttpInfo: " + e.Message);
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

