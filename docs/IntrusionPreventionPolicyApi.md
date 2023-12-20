# SonicWallGen7.Api.IntrusionPreventionPolicyApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IntrusionPreventionPoliciesGet**](IntrusionPreventionPolicyApi.md#intrusionpreventionpoliciesget) | **GET** /intrusion-prevention/policies |  |
| [**IntrusionPreventionPoliciesIdIDGet**](IntrusionPreventionPolicyApi.md#intrusionpreventionpoliciesididget) | **GET** /intrusion-prevention/policies/id/{ID} |  |
| [**IntrusionPreventionPoliciesIdIDPut**](IntrusionPreventionPolicyApi.md#intrusionpreventionpoliciesididput) | **PUT** /intrusion-prevention/policies/id/{ID} |  |
| [**IntrusionPreventionPoliciesNameNAMEGet**](IntrusionPreventionPolicyApi.md#intrusionpreventionpoliciesnamenameget) | **GET** /intrusion-prevention/policies/name/{NAME} |  |
| [**IntrusionPreventionPoliciesNameNAMEPut**](IntrusionPreventionPolicyApi.md#intrusionpreventionpoliciesnamenameput) | **PUT** /intrusion-prevention/policies/name/{NAME} |  |
| [**IntrusionPreventionPoliciesPut**](IntrusionPreventionPolicyApi.md#intrusionpreventionpoliciesput) | **PUT** /intrusion-prevention/policies |  |

<a id="intrusionpreventionpoliciesget"></a>
# **IntrusionPreventionPoliciesGet**
> IntrusionPreventionPolicyCollection IntrusionPreventionPoliciesGet ()



Retrieve intrusion prevention edited policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionPoliciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionPolicyApi(config);

            try
            {
                IntrusionPreventionPolicyCollection result = apiInstance.IntrusionPreventionPoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionPoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionPolicyCollection> response = apiInstance.IntrusionPreventionPoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IntrusionPreventionPolicyCollection**](IntrusionPreventionPolicyCollection.md)

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

<a id="intrusionpreventionpoliciesididget"></a>
# **IntrusionPreventionPoliciesIdIDGet**
> IntrusionPreventionPolicyCollection IntrusionPreventionPoliciesIdIDGet (decimal ID)



Retrieve intrusion prevention edited policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionPoliciesIdIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionPolicyApi(config);
            var ID = 8.14D;  // decimal | Policy ID.

            try
            {
                IntrusionPreventionPolicyCollection result = apiInstance.IntrusionPreventionPoliciesIdIDGet(ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesIdIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionPoliciesIdIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionPolicyCollection> response = apiInstance.IntrusionPreventionPoliciesIdIDGetWithHttpInfo(ID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesIdIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Policy ID. |  |

### Return type

[**IntrusionPreventionPolicyCollection**](IntrusionPreventionPolicyCollection.md)

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

<a id="intrusionpreventionpoliciesididput"></a>
# **IntrusionPreventionPoliciesIdIDPut**
> ApiStatus IntrusionPreventionPoliciesIdIDPut (decimal ID, IntrusionPreventionPolicyCollection? intrusionPreventionPolicyCollection = null)



Edit intrusion prevention policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionPoliciesIdIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionPolicyApi(config);
            var ID = 8.14D;  // decimal | Policy ID.
            var intrusionPreventionPolicyCollection = new IntrusionPreventionPolicyCollection?(); // IntrusionPreventionPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionPoliciesIdIDPut(ID, intrusionPreventionPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesIdIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionPoliciesIdIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionPoliciesIdIDPutWithHttpInfo(ID, intrusionPreventionPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesIdIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **decimal** | Policy ID. |  |
| **intrusionPreventionPolicyCollection** | [**IntrusionPreventionPolicyCollection?**](IntrusionPreventionPolicyCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventionpoliciesnamenameget"></a>
# **IntrusionPreventionPoliciesNameNAMEGet**
> IntrusionPreventionPolicyCollection IntrusionPreventionPoliciesNameNAMEGet (string NAME)



Retrieve intrusion prevention edited policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionPoliciesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionPolicyApi(config);
            var NAME = "\"ActivePDF WebGrabber ActiveX Instantiation\"";  // string | Policy name. (default to "ActivePDF WebGrabber ActiveX Instantiation")

            try
            {
                IntrusionPreventionPolicyCollection result = apiInstance.IntrusionPreventionPoliciesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionPoliciesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntrusionPreventionPolicyCollection> response = apiInstance.IntrusionPreventionPoliciesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Policy name. | [default to &quot;ActivePDF WebGrabber ActiveX Instantiation&quot;] |

### Return type

[**IntrusionPreventionPolicyCollection**](IntrusionPreventionPolicyCollection.md)

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

<a id="intrusionpreventionpoliciesnamenameput"></a>
# **IntrusionPreventionPoliciesNameNAMEPut**
> ApiStatus IntrusionPreventionPoliciesNameNAMEPut (string NAME, IntrusionPreventionPolicyCollection? intrusionPreventionPolicyCollection = null)



Edit intrusion prevention policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionPoliciesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionPolicyApi(config);
            var NAME = "\"ActivePDF WebGrabber ActiveX Instantiation\"";  // string | Policy name. (default to "ActivePDF WebGrabber ActiveX Instantiation")
            var intrusionPreventionPolicyCollection = new IntrusionPreventionPolicyCollection?(); // IntrusionPreventionPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionPoliciesNameNAMEPut(NAME, intrusionPreventionPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionPoliciesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionPoliciesNameNAMEPutWithHttpInfo(NAME, intrusionPreventionPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Policy name. | [default to &quot;ActivePDF WebGrabber ActiveX Instantiation&quot;] |
| **intrusionPreventionPolicyCollection** | [**IntrusionPreventionPolicyCollection?**](IntrusionPreventionPolicyCollection?.md) |  | [optional]  |

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

<a id="intrusionpreventionpoliciesput"></a>
# **IntrusionPreventionPoliciesPut**
> ApiStatus IntrusionPreventionPoliciesPut (IntrusionPreventionPolicyCollection? intrusionPreventionPolicyCollection = null)



Edit intrusion prevention policy object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class IntrusionPreventionPoliciesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IntrusionPreventionPolicyApi(config);
            var intrusionPreventionPolicyCollection = new IntrusionPreventionPolicyCollection?(); // IntrusionPreventionPolicyCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.IntrusionPreventionPoliciesPut(intrusionPreventionPolicyCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntrusionPreventionPoliciesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.IntrusionPreventionPoliciesPutWithHttpInfo(intrusionPreventionPolicyCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntrusionPreventionPolicyApi.IntrusionPreventionPoliciesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intrusionPreventionPolicyCollection** | [**IntrusionPreventionPolicyCollection?**](IntrusionPreventionPolicyCollection?.md) |  | [optional]  |

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

