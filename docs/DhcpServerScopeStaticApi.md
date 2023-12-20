# SonicWallGen7.Api.DhcpServerScopeStaticApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv4ScopesStaticGet**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticget) | **GET** /dhcp-server/ipv4/scopes/static |  |
| [**DhcpServerIpv4ScopesStaticIpIPMacMACDelete**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticipipmacmacdelete) | **DELETE** /dhcp-server/ipv4/scopes/static/ip/{IP}/mac/{MAC} |  |
| [**DhcpServerIpv4ScopesStaticIpIPMacMACGet**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticipipmacmacget) | **GET** /dhcp-server/ipv4/scopes/static/ip/{IP}/mac/{MAC} |  |
| [**DhcpServerIpv4ScopesStaticIpIPMacMACPatch**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticipipmacmacpatch) | **PATCH** /dhcp-server/ipv4/scopes/static/ip/{IP}/mac/{MAC} |  |
| [**DhcpServerIpv4ScopesStaticIpIPMacMACPut**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticipipmacmacput) | **PUT** /dhcp-server/ipv4/scopes/static/ip/{IP}/mac/{MAC} |  |
| [**DhcpServerIpv4ScopesStaticPatch**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticpatch) | **PATCH** /dhcp-server/ipv4/scopes/static |  |
| [**DhcpServerIpv4ScopesStaticPost**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticpost) | **POST** /dhcp-server/ipv4/scopes/static |  |
| [**DhcpServerIpv4ScopesStaticPut**](DhcpServerScopeStaticApi.md#dhcpserveripv4scopesstaticput) | **PUT** /dhcp-server/ipv4/scopes/static |  |

<a id="dhcpserveripv4scopesstaticget"></a>
# **DhcpServerIpv4ScopesStaticGet**
> DhcpServerScopeStaticCollection DhcpServerIpv4ScopesStaticGet ()



Retrieve DHCP server IPv4 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);

            try
            {
                DhcpServerScopeStaticCollection result = apiInstance.DhcpServerIpv4ScopesStaticGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerScopeStaticCollection> response = apiInstance.DhcpServerIpv4ScopesStaticGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerScopeStaticCollection**](DhcpServerScopeStaticCollection.md)

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

<a id="dhcpserveripv4scopesstaticipipmacmacdelete"></a>
# **DhcpServerIpv4ScopesStaticIpIPMacMACDelete**
> ApiStatus DhcpServerIpv4ScopesStaticIpIPMacMACDelete (string IP, string MAC)



Delete DHCP server IPv4 static scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticIpIPMacMACDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACDelete(IP, MAC);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticIpIPMacMACDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACDeleteWithHttpInfo(IP, MAC);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |

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

<a id="dhcpserveripv4scopesstaticipipmacmacget"></a>
# **DhcpServerIpv4ScopesStaticIpIPMacMACGet**
> DhcpServerScopeStaticCollection DhcpServerIpv4ScopesStaticIpIPMacMACGet (string IP, string MAC)



Retrieve DHCP server IPv4 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticIpIPMacMACGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")

            try
            {
                DhcpServerScopeStaticCollection result = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACGet(IP, MAC);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticIpIPMacMACGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerScopeStaticCollection> response = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACGetWithHttpInfo(IP, MAC);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |

### Return type

[**DhcpServerScopeStaticCollection**](DhcpServerScopeStaticCollection.md)

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

<a id="dhcpserveripv4scopesstaticipipmacmacpatch"></a>
# **DhcpServerIpv4ScopesStaticIpIPMacMACPatch**
> ApiStatus DhcpServerIpv4ScopesStaticIpIPMacMACPatch (string IP, string MAC, DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null)



Patch DHCP server IPv4 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticIpIPMacMACPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var dhcpServerScopeStaticCollection = new DhcpServerScopeStaticCollection?(); // DhcpServerScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACPatch(IP, MAC, dhcpServerScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticIpIPMacMACPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACPatchWithHttpInfo(IP, MAC, dhcpServerScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **dhcpServerScopeStaticCollection** | [**DhcpServerScopeStaticCollection?**](DhcpServerScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesstaticipipmacmacput"></a>
# **DhcpServerIpv4ScopesStaticIpIPMacMACPut**
> ApiStatus DhcpServerIpv4ScopesStaticIpIPMacMACPut (string IP, string MAC, DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null)



Update DHCP server IPv4 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticIpIPMacMACPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var dhcpServerScopeStaticCollection = new DhcpServerScopeStaticCollection?(); // DhcpServerScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACPut(IP, MAC, dhcpServerScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticIpIPMacMACPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesStaticIpIPMacMACPutWithHttpInfo(IP, MAC, dhcpServerScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticIpIPMacMACPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **dhcpServerScopeStaticCollection** | [**DhcpServerScopeStaticCollection?**](DhcpServerScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesstaticpatch"></a>
# **DhcpServerIpv4ScopesStaticPatch**
> ApiStatus DhcpServerIpv4ScopesStaticPatch (DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null)



Patch DHCP server IPv4 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var dhcpServerScopeStaticCollection = new DhcpServerScopeStaticCollection?(); // DhcpServerScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesStaticPatch(dhcpServerScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesStaticPatchWithHttpInfo(dhcpServerScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerScopeStaticCollection** | [**DhcpServerScopeStaticCollection?**](DhcpServerScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesstaticpost"></a>
# **DhcpServerIpv4ScopesStaticPost**
> ApiStatus DhcpServerIpv4ScopesStaticPost (DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null)



Add DHCP server IPv4 static scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var dhcpServerScopeStaticCollection = new DhcpServerScopeStaticCollection?(); // DhcpServerScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesStaticPost(dhcpServerScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesStaticPostWithHttpInfo(dhcpServerScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerScopeStaticCollection** | [**DhcpServerScopeStaticCollection?**](DhcpServerScopeStaticCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4scopesstaticput"></a>
# **DhcpServerIpv4ScopesStaticPut**
> ApiStatus DhcpServerIpv4ScopesStaticPut (DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null)



Update DHCP server IPv4 static scopes configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4ScopesStaticPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerScopeStaticApi(config);
            var dhcpServerScopeStaticCollection = new DhcpServerScopeStaticCollection?(); // DhcpServerScopeStaticCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4ScopesStaticPut(dhcpServerScopeStaticCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4ScopesStaticPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4ScopesStaticPutWithHttpInfo(dhcpServerScopeStaticCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerScopeStaticApi.DhcpServerIpv4ScopesStaticPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerScopeStaticCollection** | [**DhcpServerScopeStaticCollection?**](DhcpServerScopeStaticCollection?.md) |  | [optional]  |

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

