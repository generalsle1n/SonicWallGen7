# SonicWallGen7.Api.PolicySectionApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PolicySectionsGet**](PolicySectionApi.md#policysectionsget) | **GET** /policy/sections |  |
| [**PolicySectionsPost**](PolicySectionApi.md#policysectionspost) | **POST** /policy/sections |  |
| [**PolicySectionsPut**](PolicySectionApi.md#policysectionsput) | **PUT** /policy/sections |  |
| [**PolicySectionsUuidUUIDNameNAMEDelete**](PolicySectionApi.md#policysectionsuuiduuidnamenamedelete) | **DELETE** /policy/sections/uuid/{UUID}/name/{NAME} |  |
| [**PolicySectionsUuidUUIDNameNAMEGet**](PolicySectionApi.md#policysectionsuuiduuidnamenameget) | **GET** /policy/sections/uuid/{UUID}/name/{NAME} |  |
| [**PolicySectionsUuidUUIDNameNAMEPut**](PolicySectionApi.md#policysectionsuuiduuidnamenameput) | **PUT** /policy/sections/uuid/{UUID}/name/{NAME} |  |

<a id="policysectionsget"></a>
# **PolicySectionsGet**
> PolicySectionCollection PolicySectionsGet ()



Retrieve a policy section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PolicySectionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicySectionApi(config);

            try
            {
                PolicySectionCollection result = apiInstance.PolicySectionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicySectionApi.PolicySectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PolicySectionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PolicySectionCollection> response = apiInstance.PolicySectionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolicySectionApi.PolicySectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PolicySectionCollection**](PolicySectionCollection.md)

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

<a id="policysectionspost"></a>
# **PolicySectionsPost**
> ApiStatus PolicySectionsPost (PolicySectionCollection? policySectionCollection = null)



Create a new policy section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PolicySectionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicySectionApi(config);
            var policySectionCollection = new PolicySectionCollection?(); // PolicySectionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PolicySectionsPost(policySectionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicySectionApi.PolicySectionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PolicySectionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PolicySectionsPostWithHttpInfo(policySectionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolicySectionApi.PolicySectionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policySectionCollection** | [**PolicySectionCollection?**](PolicySectionCollection?.md) |  | [optional]  |

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

<a id="policysectionsput"></a>
# **PolicySectionsPut**
> ApiStatus PolicySectionsPut (PolicySectionCollection? policySectionCollection = null)



Edit an existing policy section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PolicySectionsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicySectionApi(config);
            var policySectionCollection = new PolicySectionCollection?(); // PolicySectionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PolicySectionsPut(policySectionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicySectionApi.PolicySectionsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PolicySectionsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PolicySectionsPutWithHttpInfo(policySectionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolicySectionApi.PolicySectionsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policySectionCollection** | [**PolicySectionCollection?**](PolicySectionCollection?.md) |  | [optional]  |

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

<a id="policysectionsuuiduuidnamenamedelete"></a>
# **PolicySectionsUuidUUIDNameNAMEDelete**
> ApiStatus PolicySectionsUuidUUIDNameNAMEDelete (string UUID, string NAME)



Delete a policy section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PolicySectionsUuidUUIDNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicySectionApi(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.PolicySectionsUuidUUIDNameNAMEDelete(UUID, NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicySectionApi.PolicySectionsUuidUUIDNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PolicySectionsUuidUUIDNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PolicySectionsUuidUUIDNameNAMEDeleteWithHttpInfo(UUID, NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolicySectionApi.PolicySectionsUuidUUIDNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="policysectionsuuiduuidnamenameget"></a>
# **PolicySectionsUuidUUIDNameNAMEGet**
> PolicySectionCollection PolicySectionsUuidUUIDNameNAMEGet (string UUID, string NAME)



Retrieve a policy section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PolicySectionsUuidUUIDNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicySectionApi(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                PolicySectionCollection result = apiInstance.PolicySectionsUuidUUIDNameNAMEGet(UUID, NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicySectionApi.PolicySectionsUuidUUIDNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PolicySectionsUuidUUIDNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PolicySectionCollection> response = apiInstance.PolicySectionsUuidUUIDNameNAMEGetWithHttpInfo(UUID, NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolicySectionApi.PolicySectionsUuidUUIDNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**PolicySectionCollection**](PolicySectionCollection.md)

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

<a id="policysectionsuuiduuidnamenameput"></a>
# **PolicySectionsUuidUUIDNameNAMEPut**
> ApiStatus PolicySectionsUuidUUIDNameNAMEPut (string UUID, string NAME, PolicySectionCollection? policySectionCollection = null)



Edit an existing policy section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PolicySectionsUuidUUIDNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PolicySectionApi(config);
            var UUID = "\"00000000-0000-0001-0700-2cb8ed4acd38\"";  // string | Security policy UUID. (default to "00000000-0000-0001-0700-2cb8ed4acd38")
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var policySectionCollection = new PolicySectionCollection?(); // PolicySectionCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PolicySectionsUuidUUIDNameNAMEPut(UUID, NAME, policySectionCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicySectionApi.PolicySectionsUuidUUIDNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PolicySectionsUuidUUIDNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PolicySectionsUuidUUIDNameNAMEPutWithHttpInfo(UUID, NAME, policySectionCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PolicySectionApi.PolicySectionsUuidUUIDNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **UUID** | **string** | Security policy UUID. | [default to &quot;00000000-0000-0001-0700-2cb8ed4acd38&quot;] |
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **policySectionCollection** | [**PolicySectionCollection?**](PolicySectionCollection?.md) |  | [optional]  |

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

