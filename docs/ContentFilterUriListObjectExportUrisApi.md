# SonicWallGen7.Api.ContentFilterUriListObjectExportUrisApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportContentFilterUriListObjectUrisNameNAMEGet**](ContentFilterUriListObjectExportUrisApi.md#exportcontentfilterurilistobjecturisnamenameget) | **GET** /export/content-filter/uri-list-object/uris/name/{NAME} |  |

<a id="exportcontentfilterurilistobjecturisnamenameget"></a>
# **ExportContentFilterUriListObjectUrisNameNAMEGet**
> Object ExportContentFilterUriListObjectUrisNameNAMEGet (string NAME)



Download uri expressions through api.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportContentFilterUriListObjectUrisNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectExportUrisApi(config);
            var NAME = "\"White URI list object\"";  // string | Content filter URI list object name. (default to "White URI list object")

            try
            {
                Object result = apiInstance.ExportContentFilterUriListObjectUrisNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectExportUrisApi.ExportContentFilterUriListObjectUrisNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportContentFilterUriListObjectUrisNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportContentFilterUriListObjectUrisNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectExportUrisApi.ExportContentFilterUriListObjectUrisNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Content filter URI list object name. | [default to &quot;White URI list object&quot;] |

### Return type

**Object**

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

