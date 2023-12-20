# SonicWallGen7.Api.AddressObjectResolveApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddressObjectResolveFqdnFQDNNAMEPost**](AddressObjectResolveApi.md#addressobjectresolvefqdnfqdnnamepost) | **POST** /address-object/resolve/fqdn/{FQDNNAME} |  |
| [**AddressObjectResolveMacMACNAMEPost**](AddressObjectResolveApi.md#addressobjectresolvemacmacnamepost) | **POST** /address-object/resolve/mac/{MACNAME} |  |
| [**AddressObjectResolvePost**](AddressObjectResolveApi.md#addressobjectresolvepost) | **POST** /address-object/resolve |  |

<a id="addressobjectresolvefqdnfqdnnamepost"></a>
# **AddressObjectResolveFqdnFQDNNAMEPost**
> ApiStatus AddressObjectResolveFqdnFQDNNAMEPost (string FQDNNAME, Object? body = null)



Resolve a specified MAC/FQDN address object or all address objects API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectResolveFqdnFQDNNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectResolveApi(config);
            var FQDNNAME = "\"www.example.com\"";  // string | FQDN address object name. (default to "www.example.com")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectResolveFqdnFQDNNAMEPost(FQDNNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectResolveApi.AddressObjectResolveFqdnFQDNNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectResolveFqdnFQDNNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectResolveFqdnFQDNNAMEPostWithHttpInfo(FQDNNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectResolveApi.AddressObjectResolveFqdnFQDNNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FQDNNAME** | **string** | FQDN address object name. | [default to &quot;www.example.com&quot;] |
| **body** | **Object?** |  | [optional]  |

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

<a id="addressobjectresolvemacmacnamepost"></a>
# **AddressObjectResolveMacMACNAMEPost**
> ApiStatus AddressObjectResolveMacMACNAMEPost (string MACNAME, Object? body = null)



Resolve a specified MAC/FQDN address object or all address objects API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectResolveMacMACNAMEPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectResolveApi(config);
            var MACNAME = "\"Sales Network Access Point\"";  // string | MAC address object name. (default to "Sales Network Access Point")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectResolveMacMACNAMEPost(MACNAME, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectResolveApi.AddressObjectResolveMacMACNAMEPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectResolveMacMACNAMEPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectResolveMacMACNAMEPostWithHttpInfo(MACNAME, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectResolveApi.AddressObjectResolveMacMACNAMEPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **MACNAME** | **string** | MAC address object name. | [default to &quot;Sales Network Access Point&quot;] |
| **body** | **Object?** |  | [optional]  |

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

<a id="addressobjectresolvepost"></a>
# **AddressObjectResolvePost**
> ApiStatus AddressObjectResolvePost (Object? body = null)



Resolve a specified MAC/FQDN address object or all address objects API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AddressObjectResolvePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressObjectResolveApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AddressObjectResolvePost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressObjectResolveApi.AddressObjectResolvePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressObjectResolvePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AddressObjectResolvePostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressObjectResolveApi.AddressObjectResolvePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

