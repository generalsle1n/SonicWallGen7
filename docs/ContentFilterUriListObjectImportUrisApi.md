# SonicWallGen7.Api.ContentFilterUriListObjectImportUrisApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ImportContentFilterUriListObjectUrisNameNAMEPut**](ContentFilterUriListObjectImportUrisApi.md#importcontentfilterurilistobjecturisnamenameput) | **PUT** /import/content-filter/uri-list-object/uris/name/{NAME} |  |

<a id="importcontentfilterurilistobjecturisnamenameput"></a>
# **ImportContentFilterUriListObjectUrisNameNAMEPut**
> ApiStatus ImportContentFilterUriListObjectUrisNameNAMEPut (string NAME, Object? body = null)



Upload uri expressions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ImportContentFilterUriListObjectUrisNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ContentFilterUriListObjectImportUrisApi(config);
            var NAME = "\"White URI list object\"";  // string | Content filter URI list object name. (default to "White URI list object")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ImportContentFilterUriListObjectUrisNameNAMEPut(NAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentFilterUriListObjectImportUrisApi.ImportContentFilterUriListObjectUrisNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportContentFilterUriListObjectUrisNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ImportContentFilterUriListObjectUrisNameNAMEPutWithHttpInfo(NAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentFilterUriListObjectImportUrisApi.ImportContentFilterUriListObjectUrisNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Content filter URI list object name. | [default to &quot;White URI list object&quot;] |
| **body** | **Object?** |  | [optional]  |

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

