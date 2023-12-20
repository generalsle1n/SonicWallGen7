# SonicWallGen7.Api.EndpointSecurityProfileApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EndpointSecurityProfilesGet**](EndpointSecurityProfileApi.md#endpointsecurityprofilesget) | **GET** /endpoint-security/profiles |  |
| [**EndpointSecurityProfilesNameNAMEDelete**](EndpointSecurityProfileApi.md#endpointsecurityprofilesnamenamedelete) | **DELETE** /endpoint-security/profiles/name/{NAME} |  |
| [**EndpointSecurityProfilesNameNAMEGet**](EndpointSecurityProfileApi.md#endpointsecurityprofilesnamenameget) | **GET** /endpoint-security/profiles/name/{NAME} |  |
| [**EndpointSecurityProfilesNameNAMEPut**](EndpointSecurityProfileApi.md#endpointsecurityprofilesnamenameput) | **PUT** /endpoint-security/profiles/name/{NAME} |  |
| [**EndpointSecurityProfilesPost**](EndpointSecurityProfileApi.md#endpointsecurityprofilespost) | **POST** /endpoint-security/profiles |  |
| [**EndpointSecurityProfilesPut**](EndpointSecurityProfileApi.md#endpointsecurityprofilesput) | **PUT** /endpoint-security/profiles |  |

<a id="endpointsecurityprofilesget"></a>
# **EndpointSecurityProfilesGet**
> EndpointSecurityProfileCollection EndpointSecurityProfilesGet ()



Retrieve Endpoint Enforcement Profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityProfileApi(config);

            try
            {
                EndpointSecurityProfileCollection result = apiInstance.EndpointSecurityProfilesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EndpointSecurityProfileCollection> response = apiInstance.EndpointSecurityProfilesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EndpointSecurityProfileCollection**](EndpointSecurityProfileCollection.md)

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

<a id="endpointsecurityprofilesnamenamedelete"></a>
# **EndpointSecurityProfilesNameNAMEDelete**
> ApiStatus EndpointSecurityProfilesNameNAMEDelete (string NAME)



Delete a Endpoint Enforcement Profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityProfilesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityProfileApi(config);
            var NAME = "\"Market policy\"";  // string | Endpoint security policy name. (default to "Market policy")

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityProfilesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityProfilesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityProfilesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Endpoint security policy name. | [default to &quot;Market policy&quot;] |

### Return type

[**ApiStatus**](ApiStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | API status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="endpointsecurityprofilesnamenameget"></a>
# **EndpointSecurityProfilesNameNAMEGet**
> EndpointSecurityProfileCollection EndpointSecurityProfilesNameNAMEGet (string NAME)



Retrieve Endpoint Enforcement Profile object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityProfilesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityProfileApi(config);
            var NAME = "\"Market policy\"";  // string | Endpoint security policy name. (default to "Market policy")

            try
            {
                EndpointSecurityProfileCollection result = apiInstance.EndpointSecurityProfilesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityProfilesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EndpointSecurityProfileCollection> response = apiInstance.EndpointSecurityProfilesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Endpoint security policy name. | [default to &quot;Market policy&quot;] |

### Return type

[**EndpointSecurityProfileCollection**](EndpointSecurityProfileCollection.md)

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

<a id="endpointsecurityprofilesnamenameput"></a>
# **EndpointSecurityProfilesNameNAMEPut**
> ApiStatus EndpointSecurityProfilesNameNAMEPut (string NAME, EndpointSecurityProfileCollection? endpointSecurityProfileCollection = null)



Edit Endpoint Enforcement Profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityProfilesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityProfileApi(config);
            var NAME = "\"Market policy\"";  // string | Endpoint security policy name. (default to "Market policy")
            var endpointSecurityProfileCollection = new EndpointSecurityProfileCollection?(); // EndpointSecurityProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityProfilesNameNAMEPut(NAME, endpointSecurityProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityProfilesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityProfilesNameNAMEPutWithHttpInfo(NAME, endpointSecurityProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Endpoint security policy name. | [default to &quot;Market policy&quot;] |
| **endpointSecurityProfileCollection** | [**EndpointSecurityProfileCollection?**](EndpointSecurityProfileCollection?.md) |  | [optional]  |

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

<a id="endpointsecurityprofilespost"></a>
# **EndpointSecurityProfilesPost**
> ApiStatus EndpointSecurityProfilesPost (EndpointSecurityProfileCollection? endpointSecurityProfileCollection = null)



Create a new Endpoint Enforcement Profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityProfilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityProfileApi(config);
            var endpointSecurityProfileCollection = new EndpointSecurityProfileCollection?(); // EndpointSecurityProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityProfilesPost(endpointSecurityProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityProfilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityProfilesPostWithHttpInfo(endpointSecurityProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endpointSecurityProfileCollection** | [**EndpointSecurityProfileCollection?**](EndpointSecurityProfileCollection?.md) |  | [optional]  |

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

<a id="endpointsecurityprofilesput"></a>
# **EndpointSecurityProfilesPut**
> ApiStatus EndpointSecurityProfilesPut (EndpointSecurityProfileCollection? endpointSecurityProfileCollection = null)



Edit Endpoint Enforcement Profile configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityProfilesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityProfileApi(config);
            var endpointSecurityProfileCollection = new EndpointSecurityProfileCollection?(); // EndpointSecurityProfileCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityProfilesPut(endpointSecurityProfileCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityProfilesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityProfilesPutWithHttpInfo(endpointSecurityProfileCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityProfileApi.EndpointSecurityProfilesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endpointSecurityProfileCollection** | [**EndpointSecurityProfileCollection?**](EndpointSecurityProfileCollection?.md) |  | [optional]  |

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

