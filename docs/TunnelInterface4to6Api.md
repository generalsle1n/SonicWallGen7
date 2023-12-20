# SonicWallGen7.Api.TunnelInterface4to6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TunnelInterfaces4to6Get**](TunnelInterface4to6Api.md#tunnelinterfaces4to6get) | **GET** /tunnel-interfaces/4to6 |  |
| [**TunnelInterfaces4to6NameTUNNELNAMEDelete**](TunnelInterface4to6Api.md#tunnelinterfaces4to6nametunnelnamedelete) | **DELETE** /tunnel-interfaces/4to6/name/{TUNNELNAME} |  |
| [**TunnelInterfaces4to6NameTUNNELNAMEGet**](TunnelInterface4to6Api.md#tunnelinterfaces4to6nametunnelnameget) | **GET** /tunnel-interfaces/4to6/name/{TUNNELNAME} |  |
| [**TunnelInterfaces4to6NameTUNNELNAMEPatch**](TunnelInterface4to6Api.md#tunnelinterfaces4to6nametunnelnamepatch) | **PATCH** /tunnel-interfaces/4to6/name/{TUNNELNAME} |  |
| [**TunnelInterfaces4to6NameTUNNELNAMEPut**](TunnelInterface4to6Api.md#tunnelinterfaces4to6nametunnelnameput) | **PUT** /tunnel-interfaces/4to6/name/{TUNNELNAME} |  |
| [**TunnelInterfaces4to6Patch**](TunnelInterface4to6Api.md#tunnelinterfaces4to6patch) | **PATCH** /tunnel-interfaces/4to6 |  |
| [**TunnelInterfaces4to6Post**](TunnelInterface4to6Api.md#tunnelinterfaces4to6post) | **POST** /tunnel-interfaces/4to6 |  |
| [**TunnelInterfaces4to6Put**](TunnelInterface4to6Api.md#tunnelinterfaces4to6put) | **PUT** /tunnel-interfaces/4to6 |  |

<a id="tunnelinterfaces4to6get"></a>
# **TunnelInterfaces4to6Get**
> TunnelInterface4to6Collection TunnelInterfaces4to6Get ()



Retrieve 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);

            try
            {
                TunnelInterface4to6Collection result = apiInstance.TunnelInterfaces4to6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TunnelInterface4to6Collection> response = apiInstance.TunnelInterfaces4to6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TunnelInterface4to6Collection**](TunnelInterface4to6Collection.md)

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

<a id="tunnelinterfaces4to6nametunnelnamedelete"></a>
# **TunnelInterfaces4to6NameTUNNELNAMEDelete**
> ApiStatus TunnelInterfaces4to6NameTUNNELNAMEDelete (string TUNNELNAME)



Delete 4to6 tunnel interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6NameTUNNELNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var TUNNELNAME = "\"tunnel6TunnelInterface\"";  // string | Tunnel6 tunnel interface name. (default to "tunnel6TunnelInterface")

            try
            {
                ApiStatus result = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEDelete(TUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6NameTUNNELNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEDeleteWithHttpInfo(TUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | Tunnel6 tunnel interface name. | [default to &quot;tunnel6TunnelInterface&quot;] |

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

<a id="tunnelinterfaces4to6nametunnelnameget"></a>
# **TunnelInterfaces4to6NameTUNNELNAMEGet**
> TunnelInterface4to6Collection TunnelInterfaces4to6NameTUNNELNAMEGet (string TUNNELNAME)



Retrieve 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6NameTUNNELNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var TUNNELNAME = "\"tunnel6TunnelInterface\"";  // string | Tunnel6 tunnel interface name. (default to "tunnel6TunnelInterface")

            try
            {
                TunnelInterface4to6Collection result = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEGet(TUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6NameTUNNELNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TunnelInterface4to6Collection> response = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEGetWithHttpInfo(TUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | Tunnel6 tunnel interface name. | [default to &quot;tunnel6TunnelInterface&quot;] |

### Return type

[**TunnelInterface4to6Collection**](TunnelInterface4to6Collection.md)

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

<a id="tunnelinterfaces4to6nametunnelnamepatch"></a>
# **TunnelInterfaces4to6NameTUNNELNAMEPatch**
> ApiStatus TunnelInterfaces4to6NameTUNNELNAMEPatch (string TUNNELNAME, TunnelInterface4to6Collection? tunnelInterface4to6Collection = null)



Patch 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6NameTUNNELNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var TUNNELNAME = "\"tunnel6TunnelInterface\"";  // string | Tunnel6 tunnel interface name. (default to "tunnel6TunnelInterface")
            var tunnelInterface4to6Collection = new TunnelInterface4to6Collection?(); // TunnelInterface4to6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEPatch(TUNNELNAME, tunnelInterface4to6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6NameTUNNELNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEPatchWithHttpInfo(TUNNELNAME, tunnelInterface4to6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | Tunnel6 tunnel interface name. | [default to &quot;tunnel6TunnelInterface&quot;] |
| **tunnelInterface4to6Collection** | [**TunnelInterface4to6Collection?**](TunnelInterface4to6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfaces4to6nametunnelnameput"></a>
# **TunnelInterfaces4to6NameTUNNELNAMEPut**
> ApiStatus TunnelInterfaces4to6NameTUNNELNAMEPut (string TUNNELNAME, TunnelInterface4to6Collection? tunnelInterface4to6Collection = null)



Edit 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6NameTUNNELNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var TUNNELNAME = "\"tunnel6TunnelInterface\"";  // string | Tunnel6 tunnel interface name. (default to "tunnel6TunnelInterface")
            var tunnelInterface4to6Collection = new TunnelInterface4to6Collection?(); // TunnelInterface4to6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEPut(TUNNELNAME, tunnelInterface4to6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6NameTUNNELNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfaces4to6NameTUNNELNAMEPutWithHttpInfo(TUNNELNAME, tunnelInterface4to6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6NameTUNNELNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | Tunnel6 tunnel interface name. | [default to &quot;tunnel6TunnelInterface&quot;] |
| **tunnelInterface4to6Collection** | [**TunnelInterface4to6Collection?**](TunnelInterface4to6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfaces4to6patch"></a>
# **TunnelInterfaces4to6Patch**
> ApiStatus TunnelInterfaces4to6Patch (TunnelInterface4to6Collection? tunnelInterface4to6Collection = null)



Patch 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var tunnelInterface4to6Collection = new TunnelInterface4to6Collection?(); // TunnelInterface4to6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfaces4to6Patch(tunnelInterface4to6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfaces4to6PatchWithHttpInfo(tunnelInterface4to6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterface4to6Collection** | [**TunnelInterface4to6Collection?**](TunnelInterface4to6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfaces4to6post"></a>
# **TunnelInterfaces4to6Post**
> ApiStatus TunnelInterfaces4to6Post (TunnelInterface4to6Collection? tunnelInterface4to6Collection = null)



Add 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var tunnelInterface4to6Collection = new TunnelInterface4to6Collection?(); // TunnelInterface4to6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfaces4to6Post(tunnelInterface4to6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfaces4to6PostWithHttpInfo(tunnelInterface4to6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterface4to6Collection** | [**TunnelInterface4to6Collection?**](TunnelInterface4to6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfaces4to6put"></a>
# **TunnelInterfaces4to6Put**
> ApiStatus TunnelInterfaces4to6Put (TunnelInterface4to6Collection? tunnelInterface4to6Collection = null)



Edit 4to6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfaces4to6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterface4to6Api(config);
            var tunnelInterface4to6Collection = new TunnelInterface4to6Collection?(); // TunnelInterface4to6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfaces4to6Put(tunnelInterface4to6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfaces4to6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfaces4to6PutWithHttpInfo(tunnelInterface4to6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterface4to6Api.TunnelInterfaces4to6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterface4to6Collection** | [**TunnelInterface4to6Collection?**](TunnelInterface4to6Collection?.md) |  | [optional]  |

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

