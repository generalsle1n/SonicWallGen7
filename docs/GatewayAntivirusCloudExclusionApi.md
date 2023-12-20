# SonicWallGen7.Api.GatewayAntivirusCloudExclusionApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GatewayAntivirusCloudExclusionsGet**](GatewayAntivirusCloudExclusionApi.md#gatewayantiviruscloudexclusionsget) | **GET** /gateway-antivirus/cloud/exclusions |  |
| [**GatewayAntivirusCloudExclusionsPost**](GatewayAntivirusCloudExclusionApi.md#gatewayantiviruscloudexclusionspost) | **POST** /gateway-antivirus/cloud/exclusions |  |

<a id="gatewayantiviruscloudexclusionsget"></a>
# **GatewayAntivirusCloudExclusionsGet**
> GatewayAntivirusCloudExclusionCollection GatewayAntivirusCloudExclusionsGet ()



Retrieve Cloud Anti-Virus Database exclusions configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusCloudExclusionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusCloudExclusionApi(config);

            try
            {
                GatewayAntivirusCloudExclusionCollection result = apiInstance.GatewayAntivirusCloudExclusionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusCloudExclusionApi.GatewayAntivirusCloudExclusionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusCloudExclusionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GatewayAntivirusCloudExclusionCollection> response = apiInstance.GatewayAntivirusCloudExclusionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusCloudExclusionApi.GatewayAntivirusCloudExclusionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GatewayAntivirusCloudExclusionCollection**](GatewayAntivirusCloudExclusionCollection.md)

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

<a id="gatewayantiviruscloudexclusionspost"></a>
# **GatewayAntivirusCloudExclusionsPost**
> ApiStatus GatewayAntivirusCloudExclusionsPost (GatewayAntivirusCloudExclusionCollection? gatewayAntivirusCloudExclusionCollection = null)



Add a new Cloud Anti-Virus Database exclusion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusCloudExclusionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusCloudExclusionApi(config);
            var gatewayAntivirusCloudExclusionCollection = new GatewayAntivirusCloudExclusionCollection?(); // GatewayAntivirusCloudExclusionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusCloudExclusionsPost(gatewayAntivirusCloudExclusionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusCloudExclusionApi.GatewayAntivirusCloudExclusionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusCloudExclusionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusCloudExclusionsPostWithHttpInfo(gatewayAntivirusCloudExclusionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusCloudExclusionApi.GatewayAntivirusCloudExclusionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayAntivirusCloudExclusionCollection** | [**GatewayAntivirusCloudExclusionCollection?**](GatewayAntivirusCloudExclusionCollection?.md) |  | [optional]  |

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

