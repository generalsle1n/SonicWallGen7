# SonicWallGen7.Api.DhcpServerIpv6ScopeStaticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv6ScopesStaticGet**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticget) | **GET** /dhcp-server/ipv6/scopes/static |  |
| [**DhcpServerIpv6ScopesStaticNameNAMEDelete**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticnamenamedelete) | **DELETE** /dhcp-server/ipv6/scopes/static/name/{NAME} |  |
| [**DhcpServerIpv6ScopesStaticNameNAMEGet**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticnamenameget) | **GET** /dhcp-server/ipv6/scopes/static/name/{NAME} |  |
| [**DhcpServerIpv6ScopesStaticNameNAMEPatch**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticnamenamepatch) | **PATCH** /dhcp-server/ipv6/scopes/static/name/{NAME} |  |
| [**DhcpServerIpv6ScopesStaticNameNAMEPut**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticnamenameput) | **PUT** /dhcp-server/ipv6/scopes/static/name/{NAME} |  |
| [**DhcpServerIpv6ScopesStaticPatch**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticpatch) | **PATCH** /dhcp-server/ipv6/scopes/static |  |
| [**DhcpServerIpv6ScopesStaticPost**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticpost) | **POST** /dhcp-server/ipv6/scopes/static |  |
| [**DhcpServerIpv6ScopesStaticPut**](DhcpServerIpv6ScopeStaticApi.md#dhcpserveripv6scopesstaticput) | **PUT** /dhcp-server/ipv6/scopes/static |  |

<a id="dhcpserveripv6scopesstaticget"></a>
# **DhcpServerIpv6ScopesStaticGet**
> DhcpServerIpv6ScopeStaticCollection DhcpServerIpv6ScopesStaticGet ()



Retrieve DHCP server IPv6 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);

            try
            {
                DhcpServerIpv6ScopeStaticCollection result = apiInstance.DhcpServerIpv6ScopesStaticGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6ScopeStaticCollection> response = apiInstance.DhcpServerIpv6ScopesStaticGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerIpv6ScopeStaticCollection**](DhcpServerIpv6ScopeStaticCollection.md)

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

<a id="dhcpserveripv6scopesstaticnamenamedelete"></a>
# **DhcpServerIpv6ScopesStaticNameNAMEDelete**
> ApiStatus DhcpServerIpv6ScopesStaticNameNAMEDelete (string NAME)



Delete DHCP server IPv6 static scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server static scope name. (default to "abc")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server static scope name. | [default to &quot;abc&quot;] |

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

<a id="dhcpserveripv6scopesstaticnamenameget"></a>
# **DhcpServerIpv6ScopesStaticNameNAMEGet**
> DhcpServerIpv6ScopeStaticCollection DhcpServerIpv6ScopesStaticNameNAMEGet (string NAME)



Retrieve DHCP server IPv6 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server static scope name. (default to "abc")

            try
            {
                DhcpServerIpv6ScopeStaticCollection result = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6ScopeStaticCollection> response = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server static scope name. | [default to &quot;abc&quot;] |

### Return type

[**DhcpServerIpv6ScopeStaticCollection**](DhcpServerIpv6ScopeStaticCollection.md)

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

<a id="dhcpserveripv6scopesstaticnamenamepatch"></a>
# **DhcpServerIpv6ScopesStaticNameNAMEPatch**
> ApiStatus DhcpServerIpv6ScopesStaticNameNAMEPatch (string NAME, DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null)



Patch DHCP server IPv6 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server static scope name. (default to "abc")
            var dhcpServerIpv6ScopeStaticCollection = new DhcpServerIpv6ScopeStaticCollection?(); // DhcpServerIpv6ScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEPatch(NAME, dhcpServerIpv6ScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEPatchWithHttpInfo(NAME, dhcpServerIpv6ScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server static scope name. | [default to &quot;abc&quot;] |
| **dhcpServerIpv6ScopeStaticCollection** | [**DhcpServerIpv6ScopeStaticCollection?**](DhcpServerIpv6ScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesstaticnamenameput"></a>
# **DhcpServerIpv6ScopesStaticNameNAMEPut**
> ApiStatus DhcpServerIpv6ScopesStaticNameNAMEPut (string NAME, DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null)



Update DHCP server IPv6 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var NAME = "\"abc\"";  // string | IPv6 DHCP server static scope name. (default to "abc")
            var dhcpServerIpv6ScopeStaticCollection = new DhcpServerIpv6ScopeStaticCollection?(); // DhcpServerIpv6ScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEPut(NAME, dhcpServerIpv6ScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesStaticNameNAMEPutWithHttpInfo(NAME, dhcpServerIpv6ScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | IPv6 DHCP server static scope name. | [default to &quot;abc&quot;] |
| **dhcpServerIpv6ScopeStaticCollection** | [**DhcpServerIpv6ScopeStaticCollection?**](DhcpServerIpv6ScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesstaticpatch"></a>
# **DhcpServerIpv6ScopesStaticPatch**
> ApiStatus DhcpServerIpv6ScopesStaticPatch (DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null)



Patch DHCP server IPv6 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var dhcpServerIpv6ScopeStaticCollection = new DhcpServerIpv6ScopeStaticCollection?(); // DhcpServerIpv6ScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesStaticPatch(dhcpServerIpv6ScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesStaticPatchWithHttpInfo(dhcpServerIpv6ScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6ScopeStaticCollection** | [**DhcpServerIpv6ScopeStaticCollection?**](DhcpServerIpv6ScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesstaticpost"></a>
# **DhcpServerIpv6ScopesStaticPost**
> ApiStatus DhcpServerIpv6ScopesStaticPost (DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null)



Add DHCP server IPv6 static scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var dhcpServerIpv6ScopeStaticCollection = new DhcpServerIpv6ScopeStaticCollection?(); // DhcpServerIpv6ScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesStaticPost(dhcpServerIpv6ScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesStaticPostWithHttpInfo(dhcpServerIpv6ScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6ScopeStaticCollection** | [**DhcpServerIpv6ScopeStaticCollection?**](DhcpServerIpv6ScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6scopesstaticput"></a>
# **DhcpServerIpv6ScopesStaticPut**
> ApiStatus DhcpServerIpv6ScopesStaticPut (DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null)



Update DHCP server IPv6 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6ScopesStaticPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6ScopeStaticApi(config);
            var dhcpServerIpv6ScopeStaticCollection = new DhcpServerIpv6ScopeStaticCollection?(); // DhcpServerIpv6ScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6ScopesStaticPut(dhcpServerIpv6ScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6ScopesStaticPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6ScopesStaticPutWithHttpInfo(dhcpServerIpv6ScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6ScopeStaticApi.DhcpServerIpv6ScopesStaticPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6ScopeStaticCollection** | [**DhcpServerIpv6ScopeStaticCollection?**](DhcpServerIpv6ScopeStaticCollection?.md) |  | [optional]  |

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

