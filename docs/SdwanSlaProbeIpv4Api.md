# SonicWallGen7.Api.SdwanSlaProbeIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SdwanSlaProbesIpv4Get**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4get) | **GET** /sdwan/sla-probes/ipv4 |  |
| [**SdwanSlaProbesIpv4NameNAMEDelete**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4namenamedelete) | **DELETE** /sdwan/sla-probes/ipv4/name/{NAME} |  |
| [**SdwanSlaProbesIpv4NameNAMEGet**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4namenameget) | **GET** /sdwan/sla-probes/ipv4/name/{NAME} |  |
| [**SdwanSlaProbesIpv4NameNAMEPatch**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4namenamepatch) | **PATCH** /sdwan/sla-probes/ipv4/name/{NAME} |  |
| [**SdwanSlaProbesIpv4NameNAMEPut**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4namenameput) | **PUT** /sdwan/sla-probes/ipv4/name/{NAME} |  |
| [**SdwanSlaProbesIpv4Patch**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4patch) | **PATCH** /sdwan/sla-probes/ipv4 |  |
| [**SdwanSlaProbesIpv4Post**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4post) | **POST** /sdwan/sla-probes/ipv4 |  |
| [**SdwanSlaProbesIpv4Put**](SdwanSlaProbeIpv4Api.md#sdwanslaprobesipv4put) | **PUT** /sdwan/sla-probes/ipv4 |  |

<a id="sdwanslaprobesipv4get"></a>
# **SdwanSlaProbesIpv4Get**
> SdwanSlaProbeIpv4Collection SdwanSlaProbesIpv4Get ()



Retrieve IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);

            try
            {
                SdwanSlaProbeIpv4Collection result = apiInstance.SdwanSlaProbesIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SdwanSlaProbeIpv4Collection> response = apiInstance.SdwanSlaProbesIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SdwanSlaProbeIpv4Collection**](SdwanSlaProbeIpv4Collection.md)

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

<a id="sdwanslaprobesipv4namenamedelete"></a>
# **SdwanSlaProbesIpv4NameNAMEDelete**
> ApiStatus SdwanSlaProbesIpv4NameNAMEDelete (string NAME)



Delete an IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4NameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                ApiStatus result = apiInstance.SdwanSlaProbesIpv4NameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4NameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaProbesIpv4NameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="sdwanslaprobesipv4namenameget"></a>
# **SdwanSlaProbesIpv4NameNAMEGet**
> SdwanSlaProbeIpv4Collection SdwanSlaProbesIpv4NameNAMEGet (string NAME)



Retrieve IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4NameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")

            try
            {
                SdwanSlaProbeIpv4Collection result = apiInstance.SdwanSlaProbesIpv4NameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4NameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SdwanSlaProbeIpv4Collection> response = apiInstance.SdwanSlaProbesIpv4NameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |

### Return type

[**SdwanSlaProbeIpv4Collection**](SdwanSlaProbeIpv4Collection.md)

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

<a id="sdwanslaprobesipv4namenamepatch"></a>
# **SdwanSlaProbesIpv4NameNAMEPatch**
> ApiStatus SdwanSlaProbesIpv4NameNAMEPatch (string NAME, SdwanSlaProbeIpv4Collection? sdwanSlaProbeIpv4Collection = null)



Patch an IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4NameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")
            var sdwanSlaProbeIpv4Collection = new SdwanSlaProbeIpv4Collection?(); // SdwanSlaProbeIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaProbesIpv4NameNAMEPatch(NAME, sdwanSlaProbeIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4NameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaProbesIpv4NameNAMEPatchWithHttpInfo(NAME, sdwanSlaProbeIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |
| **sdwanSlaProbeIpv4Collection** | [**SdwanSlaProbeIpv4Collection?**](SdwanSlaProbeIpv4Collection?.md) |  | [optional]  |

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

<a id="sdwanslaprobesipv4namenameput"></a>
# **SdwanSlaProbesIpv4NameNAMEPut**
> ApiStatus SdwanSlaProbesIpv4NameNAMEPut (string NAME, SdwanSlaProbeIpv4Collection? sdwanSlaProbeIpv4Collection = null)



Update an IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4NameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var NAME = "\"Web Services Monitor\"";  // string | Atom Object name. (default to "Web Services Monitor")
            var sdwanSlaProbeIpv4Collection = new SdwanSlaProbeIpv4Collection?(); // SdwanSlaProbeIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaProbesIpv4NameNAMEPut(NAME, sdwanSlaProbeIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4NameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaProbesIpv4NameNAMEPutWithHttpInfo(NAME, sdwanSlaProbeIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4NameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Atom Object name. | [default to &quot;Web Services Monitor&quot;] |
| **sdwanSlaProbeIpv4Collection** | [**SdwanSlaProbeIpv4Collection?**](SdwanSlaProbeIpv4Collection?.md) |  | [optional]  |

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

<a id="sdwanslaprobesipv4patch"></a>
# **SdwanSlaProbesIpv4Patch**
> ApiStatus SdwanSlaProbesIpv4Patch (SdwanSlaProbeIpv4Collection? sdwanSlaProbeIpv4Collection = null)



Patch an IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var sdwanSlaProbeIpv4Collection = new SdwanSlaProbeIpv4Collection?(); // SdwanSlaProbeIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaProbesIpv4Patch(sdwanSlaProbeIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaProbesIpv4PatchWithHttpInfo(sdwanSlaProbeIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanSlaProbeIpv4Collection** | [**SdwanSlaProbeIpv4Collection?**](SdwanSlaProbeIpv4Collection?.md) |  | [optional]  |

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

<a id="sdwanslaprobesipv4post"></a>
# **SdwanSlaProbesIpv4Post**
> ApiStatus SdwanSlaProbesIpv4Post (SdwanSlaProbeIpv4Collection? sdwanSlaProbeIpv4Collection = null)



Create a new IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var sdwanSlaProbeIpv4Collection = new SdwanSlaProbeIpv4Collection?(); // SdwanSlaProbeIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaProbesIpv4Post(sdwanSlaProbeIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaProbesIpv4PostWithHttpInfo(sdwanSlaProbeIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanSlaProbeIpv4Collection** | [**SdwanSlaProbeIpv4Collection?**](SdwanSlaProbeIpv4Collection?.md) |  | [optional]  |

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

<a id="sdwanslaprobesipv4put"></a>
# **SdwanSlaProbesIpv4Put**
> ApiStatus SdwanSlaProbesIpv4Put (SdwanSlaProbeIpv4Collection? sdwanSlaProbeIpv4Collection = null)



Update an IPv4 SD-WAN SLA probe configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SdwanSlaProbesIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SdwanSlaProbeIpv4Api(config);
            var sdwanSlaProbeIpv4Collection = new SdwanSlaProbeIpv4Collection?(); // SdwanSlaProbeIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SdwanSlaProbesIpv4Put(sdwanSlaProbeIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SdwanSlaProbesIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SdwanSlaProbesIpv4PutWithHttpInfo(sdwanSlaProbeIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SdwanSlaProbeIpv4Api.SdwanSlaProbesIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sdwanSlaProbeIpv4Collection** | [**SdwanSlaProbeIpv4Collection?**](SdwanSlaProbeIpv4Collection?.md) |  | [optional]  |

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

