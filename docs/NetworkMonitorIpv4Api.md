# SonicWallGen7.Api.NetworkMonitorIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NetworkMonitorPoliciesIpv4Get**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4get) | **GET** /network-monitor/policies/ipv4 |  |
| [**NetworkMonitorPoliciesIpv4NameNAMEDelete**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4namenamedelete) | **DELETE** /network-monitor/policies/ipv4/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv4NameNAMEGet**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4namenameget) | **GET** /network-monitor/policies/ipv4/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv4NameNAMEPatch**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4namenamepatch) | **PATCH** /network-monitor/policies/ipv4/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv4NameNAMEPut**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4namenameput) | **PUT** /network-monitor/policies/ipv4/name/{NAME} |  |
| [**NetworkMonitorPoliciesIpv4Patch**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4patch) | **PATCH** /network-monitor/policies/ipv4 |  |
| [**NetworkMonitorPoliciesIpv4Post**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4post) | **POST** /network-monitor/policies/ipv4 |  |
| [**NetworkMonitorPoliciesIpv4Put**](NetworkMonitorIpv4Api.md#networkmonitorpoliciesipv4put) | **PUT** /network-monitor/policies/ipv4 |  |

<a id="networkmonitorpoliciesipv4get"></a>
# **NetworkMonitorPoliciesIpv4Get**
> NetworkMonitorIpv4Collection NetworkMonitorPoliciesIpv4Get ()



Retrieve network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);

            try
            {
                NetworkMonitorIpv4Collection result = apiInstance.NetworkMonitorPoliciesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NetworkMonitorIpv4Collection> response = apiInstance.NetworkMonitorPoliciesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**NetworkMonitorIpv4Collection**](NetworkMonitorIpv4Collection.md)

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

<a id="networkmonitorpoliciesipv4namenamedelete"></a>
# **NetworkMonitorPoliciesIpv4NameNAMEDelete**
> ApiStatus NetworkMonitorPoliciesIpv4NameNAMEDelete (string NAME)



Delete network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="networkmonitorpoliciesipv4namenameget"></a>
# **NetworkMonitorPoliciesIpv4NameNAMEGet**
> NetworkMonitorIpv4Collection NetworkMonitorPoliciesIpv4NameNAMEGet (string NAME)



Retrieve network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                NetworkMonitorIpv4Collection result = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NetworkMonitorIpv4Collection> response = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |

### Return type

[**NetworkMonitorIpv4Collection**](NetworkMonitorIpv4Collection.md)

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

<a id="networkmonitorpoliciesipv4namenamepatch"></a>
# **NetworkMonitorPoliciesIpv4NameNAMEPatch**
> ApiStatus NetworkMonitorPoliciesIpv4NameNAMEPatch (string NAME, NetworkMonitorIpv4Collection? networkMonitorIpv4Collection = null)



Patch network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")
            var networkMonitorIpv4Collection = new NetworkMonitorIpv4Collection?(); // NetworkMonitorIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEPatch(NAME, networkMonitorIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEPatchWithHttpInfo(NAME, networkMonitorIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |
| **networkMonitorIpv4Collection** | [**NetworkMonitorIpv4Collection?**](NetworkMonitorIpv4Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv4namenameput"></a>
# **NetworkMonitorPoliciesIpv4NameNAMEPut**
> ApiStatus NetworkMonitorPoliciesIpv4NameNAMEPut (string NAME, NetworkMonitorIpv4Collection? networkMonitorIpv4Collection = null)



Edit network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")
            var networkMonitorIpv4Collection = new NetworkMonitorIpv4Collection?(); // NetworkMonitorIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEPut(NAME, networkMonitorIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv4NameNAMEPutWithHttpInfo(NAME, networkMonitorIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |
| **networkMonitorIpv4Collection** | [**NetworkMonitorIpv4Collection?**](NetworkMonitorIpv4Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv4patch"></a>
# **NetworkMonitorPoliciesIpv4Patch**
> ApiStatus NetworkMonitorPoliciesIpv4Patch (NetworkMonitorIpv4Collection? networkMonitorIpv4Collection = null)



Patch network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var networkMonitorIpv4Collection = new NetworkMonitorIpv4Collection?(); // NetworkMonitorIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv4Patch(networkMonitorIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv4PatchWithHttpInfo(networkMonitorIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkMonitorIpv4Collection** | [**NetworkMonitorIpv4Collection?**](NetworkMonitorIpv4Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv4post"></a>
# **NetworkMonitorPoliciesIpv4Post**
> ApiStatus NetworkMonitorPoliciesIpv4Post (NetworkMonitorIpv4Collection? networkMonitorIpv4Collection = null)



Add network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var networkMonitorIpv4Collection = new NetworkMonitorIpv4Collection?(); // NetworkMonitorIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv4Post(networkMonitorIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv4PostWithHttpInfo(networkMonitorIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkMonitorIpv4Collection** | [**NetworkMonitorIpv4Collection?**](NetworkMonitorIpv4Collection?.md) |  | [optional]  |

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

<a id="networkmonitorpoliciesipv4put"></a>
# **NetworkMonitorPoliciesIpv4Put**
> ApiStatus NetworkMonitorPoliciesIpv4Put (NetworkMonitorIpv4Collection? networkMonitorIpv4Collection = null)



Edit network monitor IPv4 policies configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NetworkMonitorPoliciesIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NetworkMonitorIpv4Api(config);
            var networkMonitorIpv4Collection = new NetworkMonitorIpv4Collection?(); // NetworkMonitorIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NetworkMonitorPoliciesIpv4Put(networkMonitorIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkMonitorPoliciesIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NetworkMonitorPoliciesIpv4PutWithHttpInfo(networkMonitorIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworkMonitorIpv4Api.NetworkMonitorPoliciesIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkMonitorIpv4Collection** | [**NetworkMonitorIpv4Collection?**](NetworkMonitorIpv4Collection?.md) |  | [optional]  |

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

