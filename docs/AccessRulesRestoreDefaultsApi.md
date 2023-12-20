# SonicWallGen7.Api.AccessRulesRestoreDefaultsApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPost**](AccessRulesRestoreDefaultsApi.md#accessrulesrestoredefaultsfromsrczonetodstzonepost) | **POST** /access-rules/restore-defaults/from/{SRCZONE}/to/{DSTZONE} |  |
| [**AccessRulesRestoreDefaultsPost**](AccessRulesRestoreDefaultsApi.md#accessrulesrestoredefaultspost) | **POST** /access-rules/restore-defaults |  |

<a id="accessrulesrestoredefaultsfromsrczonetodstzonepost"></a>
# **AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPost**
> ApiStatus AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPost (string SRCZONE, string DSTZONE, Object? body = null)



Restore firewall access rules to default settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRulesRestoreDefaultsApi(config);
            var SRCZONE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var DSTZONE = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPost(SRCZONE, DSTZONE, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRulesRestoreDefaultsApi.AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPostWithHttpInfo(SRCZONE, DSTZONE, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRulesRestoreDefaultsApi.AccessRulesRestoreDefaultsFromSRCZONEToDSTZONEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SRCZONE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **DSTZONE** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
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

<a id="accessrulesrestoredefaultspost"></a>
# **AccessRulesRestoreDefaultsPost**
> ApiStatus AccessRulesRestoreDefaultsPost (Object? body = null)



Restore firewall access rules to default settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AccessRulesRestoreDefaultsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessRulesRestoreDefaultsApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AccessRulesRestoreDefaultsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRulesRestoreDefaultsApi.AccessRulesRestoreDefaultsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccessRulesRestoreDefaultsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AccessRulesRestoreDefaultsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRulesRestoreDefaultsApi.AccessRulesRestoreDefaultsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

