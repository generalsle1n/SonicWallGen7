# SonicWallGen7.Api.AppControlApplicationsListApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppControlApplicationsListCategoryNameNAMEGet**](AppControlApplicationsListApi.md#appcontrolapplicationslistcategorynamenameget) | **GET** /app-control/applications-list/category/name/{NAME} |  |

<a id="appcontrolapplicationslistcategorynamenameget"></a>
# **AppControlApplicationsListCategoryNameNAMEGet**
> AppControlApplicationsListCollection AppControlApplicationsListCategoryNameNAMEGet (string NAME)



Retrieve App control applications list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlApplicationsListCategoryNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlApplicationsListApi(config);
            var NAME = "\"APP-UPDATE\"";  // string | Category name. (default to "APP-UPDATE")

            try
            {
                AppControlApplicationsListCollection result = apiInstance.AppControlApplicationsListCategoryNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlApplicationsListApi.AppControlApplicationsListCategoryNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlApplicationsListCategoryNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlApplicationsListCollection> response = apiInstance.AppControlApplicationsListCategoryNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlApplicationsListApi.AppControlApplicationsListCategoryNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;APP-UPDATE&quot;] |

### Return type

[**AppControlApplicationsListCollection**](AppControlApplicationsListCollection.md)

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

