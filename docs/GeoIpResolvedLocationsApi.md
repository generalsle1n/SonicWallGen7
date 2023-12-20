# SonicWallGen7.Api.GeoIpResolvedLocationsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingGeoIpResolvedLocationsGet**](GeoIpResolvedLocationsApi.md#reportinggeoipresolvedlocationsget) | **GET** /reporting/geo-ip/resolved-locations |  |

<a id="reportinggeoipresolvedlocationsget"></a>
# **ReportingGeoIpResolvedLocationsGet**
> List&lt;ShowStatusGeoIpResolvedLocationsListInner&gt; ReportingGeoIpResolvedLocationsGet ()



Retrieve Geo-IP resolved locations statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingGeoIpResolvedLocationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpResolvedLocationsApi(config);

            try
            {
                List<ShowStatusGeoIpResolvedLocationsListInner> result = apiInstance.ReportingGeoIpResolvedLocationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpResolvedLocationsApi.ReportingGeoIpResolvedLocationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingGeoIpResolvedLocationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ShowStatusGeoIpResolvedLocationsListInner>> response = apiInstance.ReportingGeoIpResolvedLocationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpResolvedLocationsApi.ReportingGeoIpResolvedLocationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShowStatusGeoIpResolvedLocationsListInner&gt;**](ShowStatusGeoIpResolvedLocationsListInner.md)

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

