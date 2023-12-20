# SonicWallGen7.Api.DhcpServerIpv6ScopeDynamicApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv6ScopesDynamicGet**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicget) | **GET** /dhcp-server/ipv6/scopes/dynamic |  |
| [**DhcpServerIpv6ScopesDynamicNameNAMEDelete**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicnamenamedelete) | **DELETE** /dhcp-server/ipv6/scopes/dynamic/name/{NAME} |  |
| [**DhcpServerIpv6ScopesDynamicNameNAMEGet**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicnamenameget) | **GET** /dhcp-server/ipv6/scopes/dynamic/name/{NAME} |  |
| [**DhcpServerIpv6ScopesDynamicNameNAMEPatch**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicnamenamepatch) | **PATCH** /dhcp-server/ipv6/scopes/dynamic/name/{NAME} |  |
| [**DhcpServerIpv6ScopesDynamicNameNAMEPut**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicnamenameput) | **PUT** /dhcp-server/ipv6/scopes/dynamic/name/{NAME} |  |
| [**DhcpServerIpv6ScopesDynamicPatch**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicpatch) | **PATCH** /dhcp-server/ipv6/scopes/dynamic |  |
| [**DhcpServerIpv6ScopesDynamicPost**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicpost) | **POST** /dhcp-server/ipv6/scopes/dynamic |  |
| [**DhcpServerIpv6ScopesDynamicPut**](DhcpServerIpv6ScopeDynamicApi.md#dhcpserveripv6scopesdynamicput) | **PUT** /dhcp-server/ipv6/scopes/dynamic |  |

<a id="dhcpserveripv6scopesdynamicget"></a>
# **DhcpServerIpv6ScopesDynamicGet**
> DhcpServerIpv6ScopeDynamicCollection DhcpServerIpv6ScopesDynamicGet ()



Retrieve DHCP server IPv6 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);

            try
            {
                DhcpServerIpv6ScopeDynamicCollection result = apiInstance.DhcpServerIpv6ScopesDynamicGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6ScopeDynamicCollection> response = apiInstance.DhcpServerIpv6ScopesDynamicGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerIpv6ScopeDynamicCollection**](DhcpServerIpv6ScopeDynamicCollection.md)

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

<a id="dhcpserveripv6scopesdynamicnamenamedelete"></a>
# **DhcpServerIpv6ScopesDynamicNameNAMEDelete**
> ApiStatus DhcpServerIpv6ScopesDynamicNameNAMEDelete (string NAME)



Delete DHCP server IPv6 dynamic scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server dynamic scope name. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server dynamic scope name. | [default to &quot;abc&quot;] |

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

<a id="dhcpserveripv6scopesdynamicnamenameget"></a>
# **DhcpServerIpv6ScopesDynamicNameNAMEGet**
> DhcpServerIpv6ScopeDynamicCollection DhcpServerIpv6ScopesDynamicNameNAMEGet (string NAME)



Retrieve DHCP server IPv6 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server dynamic scope name. (default to "abc")

            try
            {
                DhcpServerIpv6ScopeDynamicCollection result = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6ScopeDynamicCollection> response = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server dynamic scope name. | [default to &quot;abc&quot;] |

### Return type

[**DhcpServerIpv6ScopeDynamicCollection**](DhcpServerIpv6ScopeDynamicCollection.md)

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

<a id="dhcpserveripv6scopesdynamicnamenamepatch"></a>
# **DhcpServerIpv6ScopesDynamicNameNAMEPatch**
> ApiStatus DhcpServerIpv6ScopesDynamicNameNAMEPatch (string NAME, DhcpServerIpv6ScopeDynamicCollection? dhcpServerIpv6ScopeDynamicCollection = null)



Patch DHCP server IPv6 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server dynamic scope name. (default to "abc")
            var dhcpServerIpv6ScopeDynamicCollection = new DhcpServerIpv6ScopeDynamicCollection?(); // DhcpServerIpv6ScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEPatch(NAME, dhcpServerIpv6ScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEPatchWithHttpInfo(NAME, dhcpServerIpv6ScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server dynamic scope name. | [default to &quot;abc&quot;] |
| **dhcpServerIpv6ScopeDynamicCollection** | [**DhcpServerIpv6ScopeDynamicCollection?**](DhcpServerIpv6ScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesdynamicnamenameput"></a>
# **DhcpServerIpv6ScopesDynamicNameNAMEPut**
> ApiStatus DhcpServerIpv6ScopesDynamicNameNAMEPut (string NAME, DhcpServerIpv6ScopeDynamicCollection? dhcpServerIpv6ScopeDynamicCollection = null)



Update DHCP server IPv6 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server dynamic scope name. (default to "abc")
            var dhcpServerIpv6ScopeDynamicCollection = new DhcpServerIpv6ScopeDynamicCollection?(); // DhcpServerIpv6ScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEPut(NAME, dhcpServerIpv6ScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesDynamicNameNAMEPutWithHttpInfo(NAME, dhcpServerIpv6ScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server dynamic scope name. | [default to &quot;abc&quot;] |
| **dhcpServerIpv6ScopeDynamicCollection** | [**DhcpServerIpv6ScopeDynamicCollection?**](DhcpServerIpv6ScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesdynamicpatch"></a>
# **DhcpServerIpv6ScopesDynamicPatch**
> ApiStatus DhcpServerIpv6ScopesDynamicPatch (DhcpServerIpv6ScopeDynamicCollection? dhcpServerIpv6ScopeDynamicCollection = null)



Patch DHCP server IPv6 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var dhcpServerIpv6ScopeDynamicCollection = new DhcpServerIpv6ScopeDynamicCollection?(); // DhcpServerIpv6ScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesDynamicPatch(dhcpServerIpv6ScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesDynamicPatchWithHttpInfo(dhcpServerIpv6ScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6ScopeDynamicCollection** | [**DhcpServerIpv6ScopeDynamicCollection?**](DhcpServerIpv6ScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesdynamicpost"></a>
# **DhcpServerIpv6ScopesDynamicPost**
> ApiStatus DhcpServerIpv6ScopesDynamicPost (DhcpServerIpv6ScopeDynamicCollection? dhcpServerIpv6ScopeDynamicCollection = null)



Add DHCP server IPv6 dynamic scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var dhcpServerIpv6ScopeDynamicCollection = new DhcpServerIpv6ScopeDynamicCollection?(); // DhcpServerIpv6ScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesDynamicPost(dhcpServerIpv6ScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesDynamicPostWithHttpInfo(dhcpServerIpv6ScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6ScopeDynamicCollection** | [**DhcpServerIpv6ScopeDynamicCollection?**](DhcpServerIpv6ScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesdynamicput"></a>
# **DhcpServerIpv6ScopesDynamicPut**
> ApiStatus DhcpServerIpv6ScopesDynamicPut (DhcpServerIpv6ScopeDynamicCollection? dhcpServerIpv6ScopeDynamicCollection = null)



Update DHCP server IPv6 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesDynamicPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeDynamicApi(config);
            var dhcpServerIpv6ScopeDynamicCollection = new DhcpServerIpv6ScopeDynamicCollection?(); // DhcpServerIpv6ScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesDynamicPut(dhcpServerIpv6ScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesDynamicPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesDynamicPutWithHttpInfo(dhcpServerIpv6ScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeDynamicApi.DhcpServerIpv6ScopesDynamicPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6ScopeDynamicCollection** | [**DhcpServerIpv6ScopeDynamicCollection?**](DhcpServerIpv6ScopeDynamicCollection?.md) |  | [optional]  |

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

