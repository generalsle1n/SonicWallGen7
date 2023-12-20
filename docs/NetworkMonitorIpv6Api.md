# SonicWallGen7.Api.NetworkMonitorIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NetworkMonitorPoliciesIpv6Get**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6get) | **GET** /network-monitor/policies/ipv6 |  |
| [**NetworkMonitorPoliciesIpv6NameNAMEDelete**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6namenamedelete) | **DELETE** /network-monitor/policies/ipv6/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv6NameNAMEGet**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6namenameget) | **GET** /network-monitor/policies/ipv6/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv6NameNAMEPatch**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6namenamepatch) | **PATCH** /network-monitor/policies/ipv6/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv6NameNAMEPut**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6namenameput) | **PUT** /network-monitor/policies/ipv6/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv6Patch**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6patch) | **PATCH** /network-monitor/policies/ipv6 |  |
| [**NetworkMonitorPoliciesIpv6Post**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6post) | **POST** /network-monitor/policies/ipv6 |  |
| [**NetworkMonitorPoliciesIpv6Put**](NetworkMonitorIpv6Api.md#networkmonitorpoliciesipv6put) | **PUT** /network-monitor/policies/ipv6 |  |

<a id="networkmonitorpoliciesipv6get"></a>
# **NetworkMonitorPoliciesIpv6Get**
> NetworkMonitorIpv6Collection NetworkMonitorPoliciesIpv6Get ()



Retrieve network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);

            try
            {
                NetworkMonitorIpv6Collection result = apiInstance.NetworkMonitorPoliciesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NetworkMonitorIpv6Collection> response = apiInstance.NetworkMonitorPoliciesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**NetworkMonitorIpv6Collection**](NetworkMonitorIpv6Collection.md)

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

<a id="networkmonitorpoliciesipv6namenamedelete"></a>
# **NetworkMonitorPoliciesIpv6NameNAMEDelete**
> ApiStatus NetworkMonitorPoliciesIpv6NameNAMEDelete (string NAME)



Delete network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |

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

<a id="networkmonitorpoliciesipv6namenameget"></a>
# **NetworkMonitorPoliciesIpv6NameNAMEGet**
> NetworkMonitorIpv6Collection NetworkMonitorPoliciesIpv6NameNAMEGet (string NAME)



Retrieve network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                NetworkMonitorIpv6Collection result = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NetworkMonitorIpv6Collection> response = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |

### Return type

[**NetworkMonitorIpv6Collection**](NetworkMonitorIpv6Collection.md)

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

<a id="networkmonitorpoliciesipv6namenamepatch"></a>
# **NetworkMonitorPoliciesIpv6NameNAMEPatch**
> ApiStatus NetworkMonitorPoliciesIpv6NameNAMEPatch (string NAME, NetworkMonitorIpv6Collection? networkMonitorIpv6Collection = null)



Patch network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")
            var networkMonitorIpv6Collection = new NetworkMonitorIpv6Collection?(); // NetworkMonitorIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEPatch(NAME, networkMonitorIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEPatchWithHttpInfo(NAME, networkMonitorIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |
| **networkMonitorIpv6Collection** | [**NetworkMonitorIpv6Collection?**](NetworkMonitorIpv6Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv6namenameput"></a>
# **NetworkMonitorPoliciesIpv6NameNAMEPut**
> ApiStatus NetworkMonitorPoliciesIpv6NameNAMEPut (string NAME, NetworkMonitorIpv6Collection? networkMonitorIpv6Collection = null)



Edit network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")
            var networkMonitorIpv6Collection = new NetworkMonitorIpv6Collection?(); // NetworkMonitorIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEPut(NAME, networkMonitorIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv6NameNAMEPutWithHttpInfo(NAME, networkMonitorIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |
| **networkMonitorIpv6Collection** | [**NetworkMonitorIpv6Collection?**](NetworkMonitorIpv6Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv6patch"></a>
# **NetworkMonitorPoliciesIpv6Patch**
> ApiStatus NetworkMonitorPoliciesIpv6Patch (NetworkMonitorIpv6Collection? networkMonitorIpv6Collection = null)



Patch network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var networkMonitorIpv6Collection = new NetworkMonitorIpv6Collection?(); // NetworkMonitorIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv6Patch(networkMonitorIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv6PatchWithHttpInfo(networkMonitorIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkMonitorIpv6Collection** | [**NetworkMonitorIpv6Collection?**](NetworkMonitorIpv6Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv6post"></a>
# **NetworkMonitorPoliciesIpv6Post**
> ApiStatus NetworkMonitorPoliciesIpv6Post (NetworkMonitorIpv6Collection? networkMonitorIpv6Collection = null)



Add network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var networkMonitorIpv6Collection = new NetworkMonitorIpv6Collection?(); // NetworkMonitorIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv6Post(networkMonitorIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv6PostWithHttpInfo(networkMonitorIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkMonitorIpv6Collection** | [**NetworkMonitorIpv6Collection?**](NetworkMonitorIpv6Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv6put"></a>
# **NetworkMonitorPoliciesIpv6Put**
> ApiStatus NetworkMonitorPoliciesIpv6Put (NetworkMonitorIpv6Collection? networkMonitorIpv6Collection = null)



Edit network monitor IPv6 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv6Api(config);
            var networkMonitorIpv6Collection = new NetworkMonitorIpv6Collection?(); // NetworkMonitorIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv6Put(networkMonitorIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv6PutWithHttpInfo(networkMonitorIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv6Api.NetworkMonitorPoliciesIpv6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkMonitorIpv6Collection** | [**NetworkMonitorIpv6Collection?**](NetworkMonitorIpv6Collection?.md) |  | [optional]  |

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

