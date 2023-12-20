# SonicWallGen7.Api.AppControlSignaturesListApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGet**](AppControlSignaturesListApi.md#appcontrolsignatureslistcategorynamenameapplicationnameappnameget) | **GET** /app-control/signatures-list/category/name/{NAME}/application/name/{APPNAME} |  |
| [**AppControlSignaturesListCategoryNameNAMEGet**](AppControlSignaturesListApi.md#appcontrolsignatureslistcategorynamenameget) | **GET** /app-control/signatures-list/category/name/{NAME} |  |

<a id="appcontrolsignatureslistcategorynamenameapplicationnameappnameget"></a>
# **AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGet**
> AppControlSignaturesListCollection AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGet (string NAME, string APPNAME)



Retrieve App control signatures list by category and application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignaturesListApi(config);
            var NAME = "\"APP-UPDATE\"";  // string | Category name. (default to "APP-UPDATE")
            var APPNAME = "\"APP-UPDATE\"";  // string | Application name. (default to "APP-UPDATE")

            try
            {
                AppControlSignaturesListCollection result = apiInstance.AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGet(NAME, APPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignaturesListApi.AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlSignaturesListCollection> response = apiInstance.AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGetWithHttpInfo(NAME, APPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignaturesListApi.AppControlSignaturesListCategoryNameNAMEApplicationNameAPPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;APP-UPDATE&quot;] |
| **APPNAME** | **string** | Application name. | [default to &quot;APP-UPDATE&quot;] |

### Return type

[**AppControlSignaturesListCollection**](AppControlSignaturesListCollection.md)

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

<a id="appcontrolsignatureslistcategorynamenameget"></a>
# **AppControlSignaturesListCategoryNameNAMEGet**
> AppControlSignaturesListCollection AppControlSignaturesListCategoryNameNAMEGet (string NAME)



Retrieve App control signatures list by category and application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AppControlSignaturesListCategoryNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppControlSignaturesListApi(config);
            var NAME = "\"APP-UPDATE\"";  // string | Category name. (default to "APP-UPDATE")

            try
            {
                AppControlSignaturesListCollection result = apiInstance.AppControlSignaturesListCategoryNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppControlSignaturesListApi.AppControlSignaturesListCategoryNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppControlSignaturesListCategoryNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppControlSignaturesListCollection> response = apiInstance.AppControlSignaturesListCategoryNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppControlSignaturesListApi.AppControlSignaturesListCategoryNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Category name. | [default to &quot;APP-UPDATE&quot;] |

### Return type

[**AppControlSignaturesListCollection**](AppControlSignaturesListCollection.md)

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

