# SonicWallGen7.Api.AntiSpywareExclusionListApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AntiSpywareExclusionListBaseGet**](AntiSpywareExclusionListApi.md#antispywareexclusionlistbaseget) | **GET** /anti-spyware/exclusion-list/base |  |
| [**AntiSpywareExclusionListBasePut**](AntiSpywareExclusionListApi.md#antispywareexclusionlistbaseput) | **PUT** /anti-spyware/exclusion-list/base |  |

<a id="antispywareexclusionlistbaseget"></a>
# **AntiSpywareExclusionListBaseGet**
> AntiSpywareExclusionList AntiSpywareExclusionListBaseGet ()



Retrieve anti spyware exclusion list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListBaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionListApi(config);

            try
            {
                AntiSpywareExclusionList result = apiInstance.AntiSpywareExclusionListBaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionListApi.AntiSpywareExclusionListBaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListBaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywareExclusionList> response = apiInstance.AntiSpywareExclusionListBaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionListApi.AntiSpywareExclusionListBaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AntiSpywareExclusionList**](AntiSpywareExclusionList.md)

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

<a id="antispywareexclusionlistbaseput"></a>
# **AntiSpywareExclusionListBasePut**
> ApiStatus AntiSpywareExclusionListBasePut (AntiSpywareExclusionList? antiSpywareExclusionList = null)



Update anti spyware exclusion list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListBasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionListApi(config);
            var antiSpywareExclusionList = new AntiSpywareExclusionList?(); // AntiSpywareExclusionList? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListBasePut(antiSpywareExclusionList);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionListApi.AntiSpywareExclusionListBasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListBasePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListBasePutWithHttpInfo(antiSpywareExclusionList);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionListApi.AntiSpywareExclusionListBasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **antiSpywareExclusionList** | [**AntiSpywareExclusionList?**](AntiSpywareExclusionList?.md) |  | [optional]  |

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

