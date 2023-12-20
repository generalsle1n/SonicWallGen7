# SonicWallGen7.Api.DiagAdvancedUserAuthenticationApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedUserAuthenticationBaseGet**](DiagAdvancedUserAuthenticationApi.md#diagadvanceduserauthenticationbaseget) | **GET** /diag/advanced/user-authentication/base |  |
| [**DiagAdvancedUserAuthenticationBasePut**](DiagAdvancedUserAuthenticationApi.md#diagadvanceduserauthenticationbaseput) | **PUT** /diag/advanced/user-authentication/base |  |

<a id="diagadvanceduserauthenticationbaseget"></a>
# **DiagAdvancedUserAuthenticationBaseGet**
> DiagAdvancedUserAuthentication DiagAdvancedUserAuthenticationBaseGet ()



Retrieve advanced diag user-authentication configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationApi(config);

            try
            {
                DiagAdvancedUserAuthentication result = apiInstance.DiagAdvancedUserAuthenticationBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationApi.DiagAdvancedUserAuthenticationBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedUserAuthentication> response = apiInstance.DiagAdvancedUserAuthenticationBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationApi.DiagAdvancedUserAuthenticationBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedUserAuthentication**](DiagAdvancedUserAuthentication.md)

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

<a id="diagadvanceduserauthenticationbaseput"></a>
# **DiagAdvancedUserAuthenticationBasePut**
> ApiStatus DiagAdvancedUserAuthenticationBasePut (DiagAdvancedUserAuthentication? diagAdvancedUserAuthentication = null)



Update advanced diag user-authentication configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedUserAuthenticationBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedUserAuthenticationApi(config);
            var diagAdvancedUserAuthentication = new DiagAdvancedUserAuthentication?(); // DiagAdvancedUserAuthentication? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedUserAuthenticationBasePut(diagAdvancedUserAuthentication);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedUserAuthenticationApi.DiagAdvancedUserAuthenticationBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedUserAuthenticationBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedUserAuthenticationBasePutWithHttpInfo(diagAdvancedUserAuthentication);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedUserAuthenticationApi.DiagAdvancedUserAuthenticationBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedUserAuthentication** | [**DiagAdvancedUserAuthentication?**](DiagAdvancedUserAuthentication?.md) |  | [optional]  |

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

