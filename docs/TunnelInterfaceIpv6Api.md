# SonicWallGen7.Api.TunnelInterfaceIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TunnelInterfacesIpv6Get**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6get) | **GET** /tunnel-interfaces/ipv6 |  |
| [**TunnelInterfacesIpv6NameTUNNELNAMEDelete**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6nametunnelnamedelete) | **DELETE** /tunnel-interfaces/ipv6/name/{TUNNELNAME} |  |
| [**TunnelInterfacesIpv6NameTUNNELNAMEGet**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6nametunnelnameget) | **GET** /tunnel-interfaces/ipv6/name/{TUNNELNAME} |  |
| [**TunnelInterfacesIpv6NameTUNNELNAMEPatch**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6nametunnelnamepatch) | **PATCH** /tunnel-interfaces/ipv6/name/{TUNNELNAME} |  |
| [**TunnelInterfacesIpv6NameTUNNELNAMEPut**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6nametunnelnameput) | **PUT** /tunnel-interfaces/ipv6/name/{TUNNELNAME} |  |
| [**TunnelInterfacesIpv6Patch**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6patch) | **PATCH** /tunnel-interfaces/ipv6 |  |
| [**TunnelInterfacesIpv6Post**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6post) | **POST** /tunnel-interfaces/ipv6 |  |
| [**TunnelInterfacesIpv6Put**](TunnelInterfaceIpv6Api.md#tunnelinterfacesipv6put) | **PUT** /tunnel-interfaces/ipv6 |  |

<a id="tunnelinterfacesipv6get"></a>
# **TunnelInterfacesIpv6Get**
> TunnelInterfaceIpv6Collection TunnelInterfacesIpv6Get ()



Retrieve IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);

            try
            {
                TunnelInterfaceIpv6Collection result = apiInstance.TunnelInterfacesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TunnelInterfaceIpv6Collection> response = apiInstance.TunnelInterfacesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TunnelInterfaceIpv6Collection**](TunnelInterfaceIpv6Collection.md)

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

<a id="tunnelinterfacesipv6nametunnelnamedelete"></a>
# **TunnelInterfacesIpv6NameTUNNELNAMEDelete**
> ApiStatus TunnelInterfacesIpv6NameTUNNELNAMEDelete (string TUNNELNAME)



Delete IPv6 tunnel interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6NameTUNNELNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var TUNNELNAME = "\"myTunnelInterface\"";  // string | IPv6 Interface name. (default to "myTunnelInterface")

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEDelete(TUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6NameTUNNELNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEDeleteWithHttpInfo(TUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | IPv6 Interface name. | [default to &quot;myTunnelInterface&quot;] |

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

<a id="tunnelinterfacesipv6nametunnelnameget"></a>
# **TunnelInterfacesIpv6NameTUNNELNAMEGet**
> TunnelInterfaceIpv6Collection TunnelInterfacesIpv6NameTUNNELNAMEGet (string TUNNELNAME)



Retrieve IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6NameTUNNELNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var TUNNELNAME = "\"myTunnelInterface\"";  // string | IPv6 Interface name. (default to "myTunnelInterface")

            try
            {
                TunnelInterfaceIpv6Collection result = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEGet(TUNNELNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6NameTUNNELNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TunnelInterfaceIpv6Collection> response = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEGetWithHttpInfo(TUNNELNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | IPv6 Interface name. | [default to &quot;myTunnelInterface&quot;] |

### Return type

[**TunnelInterfaceIpv6Collection**](TunnelInterfaceIpv6Collection.md)

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

<a id="tunnelinterfacesipv6nametunnelnamepatch"></a>
# **TunnelInterfacesIpv6NameTUNNELNAMEPatch**
> ApiStatus TunnelInterfacesIpv6NameTUNNELNAMEPatch (string TUNNELNAME, TunnelInterfaceIpv6Collection? tunnelInterfaceIpv6Collection = null)



Patch IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6NameTUNNELNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var TUNNELNAME = "\"myTunnelInterface\"";  // string | IPv6 Interface name. (default to "myTunnelInterface")
            var tunnelInterfaceIpv6Collection = new TunnelInterfaceIpv6Collection?(); // TunnelInterfaceIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEPatch(TUNNELNAME, tunnelInterfaceIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6NameTUNNELNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEPatchWithHttpInfo(TUNNELNAME, tunnelInterfaceIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | IPv6 Interface name. | [default to &quot;myTunnelInterface&quot;] |
| **tunnelInterfaceIpv6Collection** | [**TunnelInterfaceIpv6Collection?**](TunnelInterfaceIpv6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesipv6nametunnelnameput"></a>
# **TunnelInterfacesIpv6NameTUNNELNAMEPut**
> ApiStatus TunnelInterfacesIpv6NameTUNNELNAMEPut (string TUNNELNAME, TunnelInterfaceIpv6Collection? tunnelInterfaceIpv6Collection = null)



Edit IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6NameTUNNELNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var TUNNELNAME = "\"myTunnelInterface\"";  // string | IPv6 Interface name. (default to "myTunnelInterface")
            var tunnelInterfaceIpv6Collection = new TunnelInterfaceIpv6Collection?(); // TunnelInterfaceIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEPut(TUNNELNAME, tunnelInterfaceIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6NameTUNNELNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesIpv6NameTUNNELNAMEPutWithHttpInfo(TUNNELNAME, tunnelInterfaceIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6NameTUNNELNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **TUNNELNAME** | **string** | IPv6 Interface name. | [default to &quot;myTunnelInterface&quot;] |
| **tunnelInterfaceIpv6Collection** | [**TunnelInterfaceIpv6Collection?**](TunnelInterfaceIpv6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesipv6patch"></a>
# **TunnelInterfacesIpv6Patch**
> ApiStatus TunnelInterfacesIpv6Patch (TunnelInterfaceIpv6Collection? tunnelInterfaceIpv6Collection = null)



Patch IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var tunnelInterfaceIpv6Collection = new TunnelInterfaceIpv6Collection?(); // TunnelInterfaceIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesIpv6Patch(tunnelInterfaceIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesIpv6PatchWithHttpInfo(tunnelInterfaceIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterfaceIpv6Collection** | [**TunnelInterfaceIpv6Collection?**](TunnelInterfaceIpv6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesipv6post"></a>
# **TunnelInterfacesIpv6Post**
> ApiStatus TunnelInterfacesIpv6Post (TunnelInterfaceIpv6Collection? tunnelInterfaceIpv6Collection = null)



Add IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var tunnelInterfaceIpv6Collection = new TunnelInterfaceIpv6Collection?(); // TunnelInterfaceIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesIpv6Post(tunnelInterfaceIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesIpv6PostWithHttpInfo(tunnelInterfaceIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterfaceIpv6Collection** | [**TunnelInterfaceIpv6Collection?**](TunnelInterfaceIpv6Collection?.md) |  | [optional]  |

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

<a id="tunnelinterfacesipv6put"></a>
# **TunnelInterfacesIpv6Put**
> ApiStatus TunnelInterfacesIpv6Put (TunnelInterfaceIpv6Collection? tunnelInterfaceIpv6Collection = null)



Edit IPv6 tunnel interface configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class TunnelInterfacesIpv6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TunnelInterfaceIpv6Api(config);
            var tunnelInterfaceIpv6Collection = new TunnelInterfaceIpv6Collection?(); // TunnelInterfaceIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.TunnelInterfacesIpv6Put(tunnelInterfaceIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TunnelInterfacesIpv6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.TunnelInterfacesIpv6PutWithHttpInfo(tunnelInterfaceIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TunnelInterfaceIpv6Api.TunnelInterfacesIpv6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tunnelInterfaceIpv6Collection** | [**TunnelInterfaceIpv6Collection?**](TunnelInterfaceIpv6Collection?.md) |  | [optional]  |

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

