# SonicWallGen7.Api.AmazonWebServicesConnectionApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AmazonWebServicesConnectionGet**](AmazonWebServicesConnectionApi.md#amazonwebservicesconnectionget) | **GET** /amazon-web-services/connection |  |
| [**AmazonWebServicesConnectionPut**](AmazonWebServicesConnectionApi.md#amazonwebservicesconnectionput) | **PUT** /amazon-web-services/connection |  |

<a id="amazonwebservicesconnectionget"></a>
# **AmazonWebServicesConnectionGet**
> AmazonWebServicesConnection AmazonWebServicesConnectionGet ()



Retrieve amazon-web-services connection configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesConnectionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AmazonWebServicesConnectionApi(config);

            try
            {
                AmazonWebServicesConnection result = apiInstance.AmazonWebServicesConnectionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonWebServicesConnectionApi.AmazonWebServicesConnectionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesConnectionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AmazonWebServicesConnection> response = apiInstance.AmazonWebServicesConnectionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonWebServicesConnectionApi.AmazonWebServicesConnectionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AmazonWebServicesConnection**](AmazonWebServicesConnection.md)

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

<a id="amazonwebservicesconnectionput"></a>
# **AmazonWebServicesConnectionPut**
> ApiStatus AmazonWebServicesConnectionPut (AmazonWebServicesConnection? amazonWebServicesConnection = null)



Update amazon-web-services connection configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AmazonWebServicesConnectionPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AmazonWebServicesConnectionApi(config);
            var amazonWebServicesConnection = new AmazonWebServicesConnection?(); // AmazonWebServicesConnection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AmazonWebServicesConnectionPut(amazonWebServicesConnection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonWebServicesConnectionApi.AmazonWebServicesConnectionPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AmazonWebServicesConnectionPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AmazonWebServicesConnectionPutWithHttpInfo(amazonWebServicesConnection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonWebServicesConnectionApi.AmazonWebServicesConnectionPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonWebServicesConnection** | [**AmazonWebServicesConnection?**](AmazonWebServicesConnection?.md) |  | [optional]  |

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

