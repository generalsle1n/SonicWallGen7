# SonicWallGen7.Api.DiagAdvancedFqdnDynAddrObjApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiagAdvancedFqdnDynamicAddressObjectGet**](DiagAdvancedFqdnDynAddrObjApi.md#diagadvancedfqdndynamicaddressobjectget) | **GET** /diag/advanced/fqdn-dynamic-address-object |  |
| [**DiagAdvancedFqdnDynamicAddressObjectPut**](DiagAdvancedFqdnDynAddrObjApi.md#diagadvancedfqdndynamicaddressobjectput) | **PUT** /diag/advanced/fqdn-dynamic-address-object |  |

<a id="diagadvancedfqdndynamicaddressobjectget"></a>
# **DiagAdvancedFqdnDynamicAddressObjectGet**
> DiagAdvancedFqdnDynAddrObj DiagAdvancedFqdnDynamicAddressObjectGet ()



Retrieve advanced diag FQDN dynamic address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedFqdnDynamicAddressObjectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedFqdnDynAddrObjApi(config);

            try
            {
                DiagAdvancedFqdnDynAddrObj result = apiInstance.DiagAdvancedFqdnDynamicAddressObjectGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedFqdnDynAddrObjApi.DiagAdvancedFqdnDynamicAddressObjectGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedFqdnDynamicAddressObjectGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagAdvancedFqdnDynAddrObj> response = apiInstance.DiagAdvancedFqdnDynamicAddressObjectGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedFqdnDynAddrObjApi.DiagAdvancedFqdnDynamicAddressObjectGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DiagAdvancedFqdnDynAddrObj**](DiagAdvancedFqdnDynAddrObj.md)

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

<a id="diagadvancedfqdndynamicaddressobjectput"></a>
# **DiagAdvancedFqdnDynamicAddressObjectPut**
> ApiStatus DiagAdvancedFqdnDynamicAddressObjectPut (DiagAdvancedFqdnDynAddrObj? diagAdvancedFqdnDynAddrObj = null)



Update advanced diag FQDN dynamic address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DiagAdvancedFqdnDynamicAddressObjectPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiagAdvancedFqdnDynAddrObjApi(config);
            var diagAdvancedFqdnDynAddrObj = new DiagAdvancedFqdnDynAddrObj?(); // DiagAdvancedFqdnDynAddrObj? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DiagAdvancedFqdnDynamicAddressObjectPut(diagAdvancedFqdnDynAddrObj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagAdvancedFqdnDynAddrObjApi.DiagAdvancedFqdnDynamicAddressObjectPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiagAdvancedFqdnDynamicAddressObjectPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DiagAdvancedFqdnDynamicAddressObjectPutWithHttpInfo(diagAdvancedFqdnDynAddrObj);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagAdvancedFqdnDynAddrObjApi.DiagAdvancedFqdnDynamicAddressObjectPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diagAdvancedFqdnDynAddrObj** | [**DiagAdvancedFqdnDynAddrObj?**](DiagAdvancedFqdnDynAddrObj?.md) |  | [optional]  |

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

