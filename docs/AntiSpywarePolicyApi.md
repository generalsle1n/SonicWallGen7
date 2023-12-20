# SonicWallGen7.Api.AntiSpywarePolicyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AntiSpywarePoliciesGet**](AntiSpywarePolicyApi.md#antispywarepoliciesget) | **GET** /anti-spyware/policies |  |
| [**AntiSpywarePoliciesIdIDGet**](AntiSpywarePolicyApi.md#antispywarepoliciesididget) | **GET** /anti-spyware/policies/id/{ID} |  |
| [**AntiSpywarePoliciesIdIDPut**](AntiSpywarePolicyApi.md#antispywarepoliciesididput) | **PUT** /anti-spyware/policies/id/{ID} |  |
| [**AntiSpywarePoliciesPut**](AntiSpywarePolicyApi.md#antispywarepoliciesput) | **PUT** /anti-spyware/policies |  |

<a id="antispywarepoliciesget"></a>
# **AntiSpywarePoliciesGet**
> AntiSpywarePolicyCollection AntiSpywarePoliciesGet ()



Retrieve anti spyware edited policy object configuration (Modified Configuration Visible Only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywarePoliciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywarePolicyApi(config);

            try
            {
                AntiSpywarePolicyCollection result = apiInstance.AntiSpywarePoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywarePoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywarePolicyCollection> response = apiInstance.AntiSpywarePoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AntiSpywarePolicyCollection**](AntiSpywarePolicyCollection.md)

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

<a id="antispywarepoliciesididget"></a>
# **AntiSpywarePoliciesIdIDGet**
> AntiSpywarePolicyCollection AntiSpywarePoliciesIdIDGet (decimal ID)



Retrieve anti spyware edited policy object configuration (Modified Configuration Visible Only).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywarePoliciesIdIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywarePolicyApi(config);
            var ID = 8.14D;  // decimal | The policy ID of the specified anti-spyware product.

            try
            {
                AntiSpywarePolicyCollection result = apiInstance.AntiSpywarePoliciesIdIDGet(ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesIdIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywarePoliciesIdIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywarePolicyCollection> response = apiInstance.AntiSpywarePoliciesIdIDGetWithHttpInfo(ID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesIdIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | The policy ID of the specified anti-spyware product. |  |

### Return type

[**AntiSpywarePolicyCollection**](AntiSpywarePolicyCollection.md)

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

<a id="antispywarepoliciesididput"></a>
# **AntiSpywarePoliciesIdIDPut**
> ApiStatus AntiSpywarePoliciesIdIDPut (decimal ID, AntiSpywarePolicyCollection? antiSpywarePolicyCollection = null)



Edit anti spyware policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywarePoliciesIdIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywarePolicyApi(config);
            var ID = 8.14D;  // decimal | The policy ID of the specified anti-spyware product.
            var antiSpywarePolicyCollection = new AntiSpywarePolicyCollection?(); // AntiSpywarePolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywarePoliciesIdIDPut(ID, antiSpywarePolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesIdIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywarePoliciesIdIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywarePoliciesIdIDPutWithHttpInfo(ID, antiSpywarePolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesIdIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | The policy ID of the specified anti-spyware product. |  |
| **antiSpywarePolicyCollection** | [**AntiSpywarePolicyCollection?**](AntiSpywarePolicyCollection?.md) |  | [optional]  |

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

<a id="antispywarepoliciesput"></a>
# **AntiSpywarePoliciesPut**
> ApiStatus AntiSpywarePoliciesPut (AntiSpywarePolicyCollection? antiSpywarePolicyCollection = null)



Edit anti spyware policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywarePoliciesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywarePolicyApi(config);
            var antiSpywarePolicyCollection = new AntiSpywarePolicyCollection?(); // AntiSpywarePolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywarePoliciesPut(antiSpywarePolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywarePoliciesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywarePoliciesPutWithHttpInfo(antiSpywarePolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywarePolicyApi.AntiSpywarePoliciesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **antiSpywarePolicyCollection** | [**AntiSpywarePolicyCollection?**](AntiSpywarePolicyCollection?.md) |  | [optional]  |

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

