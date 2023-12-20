# SonicWallGen7.Api.UserTacacsAccountingTestApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserTacacsAccountingTestPost**](UserTacacsAccountingTestApi.md#usertacacsaccountingtestpost) | **POST** /user/tacacs/accounting/test |  |

<a id="usertacacsaccountingtestpost"></a>
# **UserTacacsAccountingTestPost**
> ApiStatus UserTacacsAccountingTestPost (UserTacacsAccountingTest? userTacacsAccountingTest = null)



Test TACACS accounging server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class UserTacacsAccountingTestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTacacsAccountingTestApi(config);
            var userTacacsAccountingTest = new UserTacacsAccountingTest?(); // UserTacacsAccountingTest? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.UserTacacsAccountingTestPost(userTacacsAccountingTest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTacacsAccountingTestApi.UserTacacsAccountingTestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTacacsAccountingTestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.UserTacacsAccountingTestPostWithHttpInfo(userTacacsAccountingTest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserTacacsAccountingTestApi.UserTacacsAccountingTestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTacacsAccountingTest** | [**UserTacacsAccountingTest?**](UserTacacsAccountingTest?.md) |  | [optional]  |

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

