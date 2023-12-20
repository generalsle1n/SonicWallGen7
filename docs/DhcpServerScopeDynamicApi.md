# SonicWallGen7.Api.DhcpServerScopeDynamicApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv4ScopesDynamicGet**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicget) | **GET** /dhcp-server/ipv4/scopes/dynamic |  |
| [**DhcpServerIpv4ScopesDynamicPatch**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicpatch) | **PATCH** /dhcp-server/ipv4/scopes/dynamic |  |
| [**DhcpServerIpv4ScopesDynamicPost**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicpost) | **POST** /dhcp-server/ipv4/scopes/dynamic |  |
| [**DhcpServerIpv4ScopesDynamicPut**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicput) | **PUT** /dhcp-server/ipv4/scopes/dynamic |  |
| [**DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDelete**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicstartstratipendendipdelete) | **DELETE** /dhcp-server/ipv4/scopes/dynamic/start/{STRATIP}/end/{ENDIP} |  |
| [**DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGet**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicstartstratipendendipget) | **GET** /dhcp-server/ipv4/scopes/dynamic/start/{STRATIP}/end/{ENDIP} |  |
| [**DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatch**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicstartstratipendendippatch) | **PATCH** /dhcp-server/ipv4/scopes/dynamic/start/{STRATIP}/end/{ENDIP} |  |
| [**DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPut**](DhcpServerScopeDynamicApi.md#dhcpserveripv4scopesdynamicstartstratipendendipput) | **PUT** /dhcp-server/ipv4/scopes/dynamic/start/{STRATIP}/end/{ENDIP} |  |

<a id="dhcpserveripv4scopesdynamicget"></a>
# **DhcpServerIpv4ScopesDynamicGet**
> DhcpServerScopeDynamicCollection DhcpServerIpv4ScopesDynamicGet ()



Retrieve DHCP server IPv4 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);

            try
            {
                DhcpServerScopeDynamicCollection result = apiInstance.DhcpServerIpv4ScopesDynamicGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerScopeDynamicCollection> response = apiInstance.DhcpServerIpv4ScopesDynamicGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerScopeDynamicCollection**](DhcpServerScopeDynamicCollection.md)

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

<a id="dhcpserveripv4scopesdynamicpatch"></a>
# **DhcpServerIpv4ScopesDynamicPatch**
> ApiStatus DhcpServerIpv4ScopesDynamicPatch (DhcpServerScopeDynamicCollection? dhcpServerScopeDynamicCollection = null)



Patch DHCP server IPv4 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var dhcpServerScopeDynamicCollection = new DhcpServerScopeDynamicCollection?(); // DhcpServerScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesDynamicPatch(dhcpServerScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesDynamicPatchWithHttpInfo(dhcpServerScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerScopeDynamicCollection** | [**DhcpServerScopeDynamicCollection?**](DhcpServerScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesdynamicpost"></a>
# **DhcpServerIpv4ScopesDynamicPost**
> ApiStatus DhcpServerIpv4ScopesDynamicPost (DhcpServerScopeDynamicCollection? dhcpServerScopeDynamicCollection = null)



Add DHCP server IPv4 dynamic scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var dhcpServerScopeDynamicCollection = new DhcpServerScopeDynamicCollection?(); // DhcpServerScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesDynamicPost(dhcpServerScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesDynamicPostWithHttpInfo(dhcpServerScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerScopeDynamicCollection** | [**DhcpServerScopeDynamicCollection?**](DhcpServerScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesdynamicput"></a>
# **DhcpServerIpv4ScopesDynamicPut**
> ApiStatus DhcpServerIpv4ScopesDynamicPut (DhcpServerScopeDynamicCollection? dhcpServerScopeDynamicCollection = null)



Update DHCP server IPv4 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var dhcpServerScopeDynamicCollection = new DhcpServerScopeDynamicCollection?(); // DhcpServerScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesDynamicPut(dhcpServerScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesDynamicPutWithHttpInfo(dhcpServerScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerScopeDynamicCollection** | [**DhcpServerScopeDynamicCollection?**](DhcpServerScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesdynamicstartstratipendendipdelete"></a>
# **DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDelete**
> ApiStatus DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDelete (string STRATIP, string ENDIP)



Delete DHCP server IPv4 dynamic scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var STRATIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var ENDIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDelete(STRATIP, ENDIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDeleteWithHttpInfo(STRATIP, ENDIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **STRATIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **ENDIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

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

<a id="dhcpserveripv4scopesdynamicstartstratipendendipget"></a>
# **DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGet**
> DhcpServerScopeDynamicCollection DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGet (string STRATIP, string ENDIP)



Retrieve DHCP server IPv4 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var STRATIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var ENDIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")

            try
            {
                DhcpServerScopeDynamicCollection result = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGet(STRATIP, ENDIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerScopeDynamicCollection> response = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGetWithHttpInfo(STRATIP, ENDIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **STRATIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **ENDIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |

### Return type

[**DhcpServerScopeDynamicCollection**](DhcpServerScopeDynamicCollection.md)

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

<a id="dhcpserveripv4scopesdynamicstartstratipendendippatch"></a>
# **DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatch**
> ApiStatus DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatch (string STRATIP, string ENDIP, DhcpServerScopeDynamicCollection? dhcpServerScopeDynamicCollection = null)



Patch DHCP server IPv4 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var STRATIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var ENDIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var dhcpServerScopeDynamicCollection = new DhcpServerScopeDynamicCollection?(); // DhcpServerScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatch(STRATIP, ENDIP, dhcpServerScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatchWithHttpInfo(STRATIP, ENDIP, dhcpServerScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **STRATIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **ENDIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **dhcpServerScopeDynamicCollection** | [**DhcpServerScopeDynamicCollection?**](DhcpServerScopeDynamicCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesdynamicstartstratipendendipput"></a>
# **DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPut**
> ApiStatus DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPut (string STRATIP, string ENDIP, DhcpServerScopeDynamicCollection? dhcpServerScopeDynamicCollection = null)



Update DHCP server IPv4 dynamic scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeDynamicApi(config);
            var STRATIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var ENDIP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var dhcpServerScopeDynamicCollection = new DhcpServerScopeDynamicCollection?(); // DhcpServerScopeDynamicCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPut(STRATIP, ENDIP, dhcpServerScopeDynamicCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPutWithHttpInfo(STRATIP, ENDIP, dhcpServerScopeDynamicCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeDynamicApi.DhcpServerIpv4ScopesDynamicStartSTRATIPEndENDIPPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **STRATIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **ENDIP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **dhcpServerScopeDynamicCollection** | [**DhcpServerScopeDynamicCollection?**](DhcpServerScopeDynamicCollection?.md) |  | [optional]  |

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

