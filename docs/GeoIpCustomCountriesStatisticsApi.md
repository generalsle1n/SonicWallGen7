# SonicWallGen7.Api.GeoIpCustomCountriesStatisticsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingGeoIpCustomCountriesStatisticsGet**](GeoIpCustomCountriesStatisticsApi.md#reportinggeoipcustomcountriesstatisticsget) | **GET** /reporting/geo-ip/custom-countries-statistics |  |

<a id="reportinggeoipcustomcountriesstatisticsget"></a>
# **ReportingGeoIpCustomCountriesStatisticsGet**
> ShowStatusGeoIpCustomCountriesStatisticsDetail ReportingGeoIpCustomCountriesStatisticsGet ()



Retrieve Geo-IP custom cuntries statistics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ReportingGeoIpCustomCountriesStatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpCustomCountriesStatisticsApi(config);

            try
            {
                ShowStatusGeoIpCustomCountriesStatisticsDetail result = apiInstance.ReportingGeoIpCustomCountriesStatisticsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpCustomCountriesStatisticsApi.ReportingGeoIpCustomCountriesStatisticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingGeoIpCustomCountriesStatisticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShowStatusGeoIpCustomCountriesStatisticsDetail> response = apiInstance.ReportingGeoIpCustomCountriesStatisticsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpCustomCountriesStatisticsApi.ReportingGeoIpCustomCountriesStatisticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ShowStatusGeoIpCustomCountriesStatisticsDetail**](ShowStatusGeoIpCustomCountriesStatisticsDetail.md)

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

