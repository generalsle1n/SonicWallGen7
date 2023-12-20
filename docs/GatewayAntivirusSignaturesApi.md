# SonicWallGen7.Api.GatewayAntivirusSignaturesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GatewayAntivirusSignaturesGet**](GatewayAntivirusSignaturesApi.md#gatewayantivirussignaturesget) | **GET** /gateway-antivirus/signatures |  |
| [**GatewayAntivirusSignaturesPut**](GatewayAntivirusSignaturesApi.md#gatewayantivirussignaturesput) | **PUT** /gateway-antivirus/signatures |  |

<a id="gatewayantivirussignaturesget"></a>
# **GatewayAntivirusSignaturesGet**
> GatewayAntivirusSignaturesCollection GatewayAntivirusSignaturesGet ()



Retrieve gateway Anti-Virus signatures configuration (Enabled Objects Visible Only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusSignaturesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusSignaturesApi(config);

            try
            {
                GatewayAntivirusSignaturesCollection result = apiInstance.GatewayAntivirusSignaturesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusSignaturesApi.GatewayAntivirusSignaturesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusSignaturesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GatewayAntivirusSignaturesCollection> response = apiInstance.GatewayAntivirusSignaturesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusSignaturesApi.GatewayAntivirusSignaturesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GatewayAntivirusSignaturesCollection**](GatewayAntivirusSignaturesCollection.md)

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

<a id="gatewayantivirussignaturesput"></a>
# **GatewayAntivirusSignaturesPut**
> ApiStatus GatewayAntivirusSignaturesPut (GatewayAntivirusSignaturesCollection? gatewayAntivirusSignaturesCollection = null)



Update gateway Anti-Virus signatures configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusSignaturesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusSignaturesApi(config);
            var gatewayAntivirusSignaturesCollection = new GatewayAntivirusSignaturesCollection?(); // GatewayAntivirusSignaturesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusSignaturesPut(gatewayAntivirusSignaturesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusSignaturesApi.GatewayAntivirusSignaturesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusSignaturesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusSignaturesPutWithHttpInfo(gatewayAntivirusSignaturesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusSignaturesApi.GatewayAntivirusSignaturesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayAntivirusSignaturesCollection** | [**GatewayAntivirusSignaturesCollection?**](GatewayAntivirusSignaturesCollection?.md) |  | [optional]  |

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

