# SonicWallGen7.Api.EndpointSecurityPolicyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EndpointSecurityPoliciesGet**](EndpointSecurityPolicyApi.md#endpointsecuritypoliciesget) | **GET** /endpoint-security/policies |  |
| [**EndpointSecurityPoliciesNameNAMEDelete**](EndpointSecurityPolicyApi.md#endpointsecuritypoliciesnamenamedelete) | **DELETE** /endpoint-security/policies/name/{NAME} |  |
| [**EndpointSecurityPoliciesNameNAMEGet**](EndpointSecurityPolicyApi.md#endpointsecuritypoliciesnamenameget) | **GET** /endpoint-security/policies/name/{NAME} |  |
| [**EndpointSecurityPoliciesNameNAMEPut**](EndpointSecurityPolicyApi.md#endpointsecuritypoliciesnamenameput) | **PUT** /endpoint-security/policies/name/{NAME} |  |
| [**EndpointSecurityPoliciesPost**](EndpointSecurityPolicyApi.md#endpointsecuritypoliciespost) | **POST** /endpoint-security/policies |  |
| [**EndpointSecurityPoliciesPut**](EndpointSecurityPolicyApi.md#endpointsecuritypoliciesput) | **PUT** /endpoint-security/policies |  |

<a id="endpointsecuritypoliciesget"></a>
# **EndpointSecurityPoliciesGet**
> EndpointSecurityPolicyCollection EndpointSecurityPoliciesGet ()



Retrieve Endpoint Enforcement Policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityPoliciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityPolicyApi(config);

            try
            {
                EndpointSecurityPolicyCollection result = apiInstance.EndpointSecurityPoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityPoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EndpointSecurityPolicyCollection> response = apiInstance.EndpointSecurityPoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EndpointSecurityPolicyCollection**](EndpointSecurityPolicyCollection.md)

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

<a id="endpointsecuritypoliciesnamenamedelete"></a>
# **EndpointSecurityPoliciesNameNAMEDelete**
> ApiStatus EndpointSecurityPoliciesNameNAMEDelete (string NAME)



Delete a Endpoint Enforcement Policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityPoliciesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | Endpoint security policy name. (default to "Market policy")

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityPoliciesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityPoliciesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityPoliciesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="endpointsecuritypoliciesnamenameget"></a>
# **EndpointSecurityPoliciesNameNAMEGet**
> EndpointSecurityPolicyCollection EndpointSecurityPoliciesNameNAMEGet (string NAME)



Retrieve Endpoint Enforcement Policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityPoliciesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | Endpoint security policy name. (default to "Market policy")

            try
            {
                EndpointSecurityPolicyCollection result = apiInstance.EndpointSecurityPoliciesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityPoliciesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EndpointSecurityPolicyCollection> response = apiInstance.EndpointSecurityPoliciesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Endpoint security policy name. | [default to &quot;Market policy&quot;] |

### Return type

[**EndpointSecurityPolicyCollection**](EndpointSecurityPolicyCollection.md)

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

<a id="endpointsecuritypoliciesnamenameput"></a>
# **EndpointSecurityPoliciesNameNAMEPut**
> ApiStatus EndpointSecurityPoliciesNameNAMEPut (string NAME, EndpointSecurityPolicyCollection? endpointSecurityPolicyCollection = null)



Edit Endpoint Enforcement Policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityPoliciesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityPolicyApi(config);
            var NAME = "\"Market policy\"";  // string | Endpoint security policy name. (default to "Market policy")
            var endpointSecurityPolicyCollection = new EndpointSecurityPolicyCollection?(); // EndpointSecurityPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityPoliciesNameNAMEPut(NAME, endpointSecurityPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityPoliciesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityPoliciesNameNAMEPutWithHttpInfo(NAME, endpointSecurityPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Endpoint security policy name. | [default to &quot;Market policy&quot;] |
| **endpointSecurityPolicyCollection** | [**EndpointSecurityPolicyCollection?**](EndpointSecurityPolicyCollection?.md) |  | [optional]  |

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

<a id="endpointsecuritypoliciespost"></a>
# **EndpointSecurityPoliciesPost**
> ApiStatus EndpointSecurityPoliciesPost (EndpointSecurityPolicyCollection? endpointSecurityPolicyCollection = null)



Create a new Endpoint Enforcement Policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityPoliciesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityPolicyApi(config);
            var endpointSecurityPolicyCollection = new EndpointSecurityPolicyCollection?(); // EndpointSecurityPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityPoliciesPost(endpointSecurityPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityPoliciesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityPoliciesPostWithHttpInfo(endpointSecurityPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endpointSecurityPolicyCollection** | [**EndpointSecurityPolicyCollection?**](EndpointSecurityPolicyCollection?.md) |  | [optional]  |

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

<a id="endpointsecuritypoliciesput"></a>
# **EndpointSecurityPoliciesPut**
> ApiStatus EndpointSecurityPoliciesPut (EndpointSecurityPolicyCollection? endpointSecurityPolicyCollection = null)



Edit Endpoint Enforcement Policy configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class EndpointSecurityPoliciesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EndpointSecurityPolicyApi(config);
            var endpointSecurityPolicyCollection = new EndpointSecurityPolicyCollection?(); // EndpointSecurityPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.EndpointSecurityPoliciesPut(endpointSecurityPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndpointSecurityPoliciesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.EndpointSecurityPoliciesPutWithHttpInfo(endpointSecurityPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointSecurityPolicyApi.EndpointSecurityPoliciesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endpointSecurityPolicyCollection** | [**EndpointSecurityPolicyCollection?**](EndpointSecurityPolicyCollection?.md) |  | [optional]  |

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

