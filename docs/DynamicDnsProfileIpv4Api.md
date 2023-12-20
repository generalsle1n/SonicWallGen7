# SonicWallGen7.Api.DynamicDnsProfileIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DynamicDnsProfilesIpv4Get**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4get) | **GET** /dynamic-dns/profiles/ipv4 |  |
| [**DynamicDnsProfilesIpv4NameNAMEDelete**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4namenamedelete) | **DELETE** /dynamic-dns/profiles/ipv4/name/{NAME} |  |
| [**DynamicDnsProfilesIpv4NameNAMEGet**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4namenameget) | **GET** /dynamic-dns/profiles/ipv4/name/{NAME} |  |
| [**DynamicDnsProfilesIpv4NameNAMEPatch**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4namenamepatch) | **PATCH** /dynamic-dns/profiles/ipv4/name/{NAME} |  |
| [**DynamicDnsProfilesIpv4NameNAMEPut**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4namenameput) | **PUT** /dynamic-dns/profiles/ipv4/name/{NAME} |  |
| [**DynamicDnsProfilesIpv4Patch**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4patch) | **PATCH** /dynamic-dns/profiles/ipv4 |  |
| [**DynamicDnsProfilesIpv4Post**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4post) | **POST** /dynamic-dns/profiles/ipv4 |  |
| [**DynamicDnsProfilesIpv4Put**](DynamicDnsProfileIpv4Api.md#dynamicdnsprofilesipv4put) | **PUT** /dynamic-dns/profiles/ipv4 |  |

<a id="dynamicdnsprofilesipv4get"></a>
# **DynamicDnsProfilesIpv4Get**
> DynamicDnsProfileIpv4Collection DynamicDnsProfilesIpv4Get ()



Retrieve IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);

            try
            {
                DynamicDnsProfileIpv4Collection result = apiInstance.DynamicDnsProfilesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DynamicDnsProfileIpv4Collection> response = apiInstance.DynamicDnsProfilesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DynamicDnsProfileIpv4Collection**](DynamicDnsProfileIpv4Collection.md)

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

<a id="dynamicdnsprofilesipv4namenamedelete"></a>
# **DynamicDnsProfilesIpv4NameNAMEDelete**
> ApiStatus DynamicDnsProfilesIpv4NameNAMEDelete (string NAME)



delete IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv4NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv4NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="dynamicdnsprofilesipv4namenameget"></a>
# **DynamicDnsProfilesIpv4NameNAMEGet**
> DynamicDnsProfileIpv4Collection DynamicDnsProfilesIpv4NameNAMEGet (string NAME)



Retrieve IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")

            try
            {
                DynamicDnsProfileIpv4Collection result = apiInstance.DynamicDnsProfilesIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DynamicDnsProfileIpv4Collection> response = apiInstance.DynamicDnsProfilesIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |

### Return type

[**DynamicDnsProfileIpv4Collection**](DynamicDnsProfileIpv4Collection.md)

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

<a id="dynamicdnsprofilesipv4namenamepatch"></a>
# **DynamicDnsProfilesIpv4NameNAMEPatch**
> ApiStatus DynamicDnsProfilesIpv4NameNAMEPatch (string NAME, DynamicDnsProfileIpv4Collection? dynamicDnsProfileIpv4Collection = null)



Patch IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")
            var dynamicDnsProfileIpv4Collection = new DynamicDnsProfileIpv4Collection?(); // DynamicDnsProfileIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv4NameNAMEPatch(NAME, dynamicDnsProfileIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv4NameNAMEPatchWithHttpInfo(NAME, dynamicDnsProfileIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |
| **dynamicDnsProfileIpv4Collection** | [**DynamicDnsProfileIpv4Collection?**](DynamicDnsProfileIpv4Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv4namenameput"></a>
# **DynamicDnsProfilesIpv4NameNAMEPut**
> ApiStatus DynamicDnsProfilesIpv4NameNAMEPut (string NAME, DynamicDnsProfileIpv4Collection? dynamicDnsProfileIpv4Collection = null)



Edit IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var NAME = "\"mydns\"";  // string | Dynamic DNS profile name. (default to "mydns")
            var dynamicDnsProfileIpv4Collection = new DynamicDnsProfileIpv4Collection?(); // DynamicDnsProfileIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv4NameNAMEPut(NAME, dynamicDnsProfileIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv4NameNAMEPutWithHttpInfo(NAME, dynamicDnsProfileIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Dynamic DNS profile name. | [default to &quot;mydns&quot;] |
| **dynamicDnsProfileIpv4Collection** | [**DynamicDnsProfileIpv4Collection?**](DynamicDnsProfileIpv4Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv4patch"></a>
# **DynamicDnsProfilesIpv4Patch**
> ApiStatus DynamicDnsProfilesIpv4Patch (DynamicDnsProfileIpv4Collection? dynamicDnsProfileIpv4Collection = null)



Patch IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var dynamicDnsProfileIpv4Collection = new DynamicDnsProfileIpv4Collection?(); // DynamicDnsProfileIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv4Patch(dynamicDnsProfileIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv4PatchWithHttpInfo(dynamicDnsProfileIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicDnsProfileIpv4Collection** | [**DynamicDnsProfileIpv4Collection?**](DynamicDnsProfileIpv4Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv4post"></a>
# **DynamicDnsProfilesIpv4Post**
> ApiStatus DynamicDnsProfilesIpv4Post (DynamicDnsProfileIpv4Collection? dynamicDnsProfileIpv4Collection = null)



Add IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var dynamicDnsProfileIpv4Collection = new DynamicDnsProfileIpv4Collection?(); // DynamicDnsProfileIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv4Post(dynamicDnsProfileIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv4PostWithHttpInfo(dynamicDnsProfileIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicDnsProfileIpv4Collection** | [**DynamicDnsProfileIpv4Collection?**](DynamicDnsProfileIpv4Collection?.md) |  | [optional]  |

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

<a id="dynamicdnsprofilesipv4put"></a>
# **DynamicDnsProfilesIpv4Put**
> ApiStatus DynamicDnsProfilesIpv4Put (DynamicDnsProfileIpv4Collection? dynamicDnsProfileIpv4Collection = null)



Edit IPv4 dynamic DNS profiles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DynamicDnsProfilesIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DynamicDnsProfileIpv4Api(config);
            var dynamicDnsProfileIpv4Collection = new DynamicDnsProfileIpv4Collection?(); // DynamicDnsProfileIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DynamicDnsProfilesIpv4Put(dynamicDnsProfileIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DynamicDnsProfilesIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DynamicDnsProfilesIpv4PutWithHttpInfo(dynamicDnsProfileIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicDnsProfileIpv4Api.DynamicDnsProfilesIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dynamicDnsProfileIpv4Collection** | [**DynamicDnsProfileIpv4Collection?**](DynamicDnsProfileIpv4Collection?.md) |  | [optional]  |

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

