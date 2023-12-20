# SonicWallGen7.Api.DynamicDnsProfileIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DynamicDnsProfilesIpv6Get**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6get) | **GET** /dynamic-dns/profiles/ipv6 |  |
| [**DynamicDnsProfilesIpv6NameNAMEDelete**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6namenamedelete) | **DELETE** /dynamic-dns/profiles/ipv6/name/{NAME} |  |
| [**DynamicDnsProfilesIpv6NameNAMEGet**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6namenameget) | **GET** /dynamic-dns/profiles/ipv6/name/{NAME} |  |
| [**DynamicDnsProfilesIpv6NameNAMEPatch**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6namenamepatch) | **PATCH** /dynamic-dns/profiles/ipv6/name/{NAME} |  |
| [**DynamicDnsProfilesIpv6NameNAMEPut**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6namenameput) | **PUT** /dynamic-dns/profiles/ipv6/name/{NAME} |  |
| [**DynamicDnsProfilesIpv6Patch**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6patch) | **PATCH** /dynamic-dns/profiles/ipv6 |  |
| [**DynamicDnsProfilesIpv6Post**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6post) | **POST** /dynamic-dns/profiles/ipv6 |  |
| [**DynamicDnsProfilesIpv6Put**](DynamicDnsProfileIpv6Api.md#dynamicdnsprofilesipv6put) | **PUT** /dynamic-dns/profiles/ipv6 |  |

<a id="dynamicdnsprofilesipv6get"></a>
# **DynamicDnsProfilesIpv6Get**
> DynamicDnsProfileIpv6Collection DynamicDnsProfilesIpv6Get ()



Retrieve IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);

            try
            {
                DynamicDnsProfileIpv6Collection result = apiInstance.DynamicDnsProfilesIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DynamicDnsProfileIpv6Collection> response = apiInstance.DynamicDnsProfilesIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DynamicDnsProfileIpv6Collection**](DynamicDnsProfileIpv6Collection.md)

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

<a id="dynamicdnsprofilesipv6namenamedelete"></a>
# **DynamicDnsProfilesIpv6NameNAMEDelete**
> ApiStatus DynamicDnsProfilesIpv6NameNAMEDelete (string NAME)



delete IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv6NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv6NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |

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

<a id="dynamicdnsprofilesipv6namenameget"></a>
# **DynamicDnsProfilesIpv6NameNAMEGet**
> DynamicDnsProfileIpv6Collection DynamicDnsProfilesIpv6NameNAMEGet (string NAME)



Retrieve IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")

            try
            {
                DynamicDnsProfileIpv6Collection result = apiInstance.DynamicDnsProfilesIpv6NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DynamicDnsProfileIpv6Collection> response = apiInstance.DynamicDnsProfilesIpv6NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |

### Return type

[**DynamicDnsProfileIpv6Collection**](DynamicDnsProfileIpv6Collection.md)

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

<a id="dynamicdnsprofilesipv6namenamepatch"></a>
# **DynamicDnsProfilesIpv6NameNAMEPatch**
> ApiStatus DynamicDnsProfilesIpv6NameNAMEPatch (string NAME, DynamicDnsProfileIpv6Collection? dynamicDnsProfileIpv6Collection = null)



Patch IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")
            var dynamicDnsProfileIpv6Collection = new DynamicDnsProfileIpv6Collection?(); // DynamicDnsProfileIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv6NameNAMEPatch(NAME, dynamicDnsProfileIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv6NameNAMEPatchWithHttpInfo(NAME, dynamicDnsProfileIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |
| **dynamicDnsProfileIpv6Collection** | [**DynamicDnsProfileIpv6Collection?**](DynamicDnsProfileIpv6Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv6namenameput"></a>
# **DynamicDnsProfilesIpv6NameNAMEPut**
> ApiStatus DynamicDnsProfilesIpv6NameNAMEPut (string NAME, DynamicDnsProfileIpv6Collection? dynamicDnsProfileIpv6Collection = null)



Edit IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")
            var dynamicDnsProfileIpv6Collection = new DynamicDnsProfileIpv6Collection?(); // DynamicDnsProfileIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv6NameNAMEPut(NAME, dynamicDnsProfileIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv6NameNAMEPutWithHttpInfo(NAME, dynamicDnsProfileIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |
| **dynamicDnsProfileIpv6Collection** | [**DynamicDnsProfileIpv6Collection?**](DynamicDnsProfileIpv6Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv6patch"></a>
# **DynamicDnsProfilesIpv6Patch**
> ApiStatus DynamicDnsProfilesIpv6Patch (DynamicDnsProfileIpv6Collection? dynamicDnsProfileIpv6Collection = null)



Patch IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var dynamicDnsProfileIpv6Collection = new DynamicDnsProfileIpv6Collection?(); // DynamicDnsProfileIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv6Patch(dynamicDnsProfileIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv6PatchWithHttpInfo(dynamicDnsProfileIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicDnsProfileIpv6Collection** | [**DynamicDnsProfileIpv6Collection?**](DynamicDnsProfileIpv6Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv6post"></a>
# **DynamicDnsProfilesIpv6Post**
> ApiStatus DynamicDnsProfilesIpv6Post (DynamicDnsProfileIpv6Collection? dynamicDnsProfileIpv6Collection = null)



Add IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var dynamicDnsProfileIpv6Collection = new DynamicDnsProfileIpv6Collection?(); // DynamicDnsProfileIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv6Post(dynamicDnsProfileIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv6PostWithHttpInfo(dynamicDnsProfileIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicDnsProfileIpv6Collection** | [**DynamicDnsProfileIpv6Collection?**](DynamicDnsProfileIpv6Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv6put"></a>
# **DynamicDnsProfilesIpv6Put**
> ApiStatus DynamicDnsProfilesIpv6Put (DynamicDnsProfileIpv6Collection? dynamicDnsProfileIpv6Collection = null)



Edit IPv6 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv6Api(config);
            var dynamicDnsProfileIpv6Collection = new DynamicDnsProfileIpv6Collection?(); // DynamicDnsProfileIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv6Put(dynamicDnsProfileIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv6PutWithHttpInfo(dynamicDnsProfileIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv6Api.DynamicDnsProfilesIpv6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicDnsProfileIpv6Collection** | [**DynamicDnsProfileIpv6Collection?**](DynamicDnsProfileIpv6Collection?.md) |  | [optional]  |

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

