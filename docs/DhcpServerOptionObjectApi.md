# SonicWallGen7.Api.DhcpServerOptionObjectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv4OptionObjectsGet**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectsget) | **GET** /dhcp-server/ipv4/option/objects |  |
| [**DhcpServerIpv4OptionObjectsNameNAMEDelete**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectsnamenamedelete) | **DELETE** /dhcp-server/ipv4/option/objects/name/{NAME} |  |
| [**DhcpServerIpv4OptionObjectsNameNAMEGet**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectsnamenameget) | **GET** /dhcp-server/ipv4/option/objects/name/{NAME} |  |
| [**DhcpServerIpv4OptionObjectsNameNAMEPatch**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectsnamenamepatch) | **PATCH** /dhcp-server/ipv4/option/objects/name/{NAME} |  |
| [**DhcpServerIpv4OptionObjectsNameNAMEPut**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectsnamenameput) | **PUT** /dhcp-server/ipv4/option/objects/name/{NAME} |  |
| [**DhcpServerIpv4OptionObjectsPatch**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectspatch) | **PATCH** /dhcp-server/ipv4/option/objects |  |
| [**DhcpServerIpv4OptionObjectsPost**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectspost) | **POST** /dhcp-server/ipv4/option/objects |  |
| [**DhcpServerIpv4OptionObjectsPut**](DhcpServerOptionObjectApi.md#dhcpserveripv4optionobjectsput) | **PUT** /dhcp-server/ipv4/option/objects |  |

<a id="dhcpserveripv4optionobjectsget"></a>
# **DhcpServerIpv4OptionObjectsGet**
> DhcpServerOptionObjectCollection DhcpServerIpv4OptionObjectsGet ()



Retrieve DHCP server IPv4 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);

            try
            {
                DhcpServerOptionObjectCollection result = apiInstance.DhcpServerIpv4OptionObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerOptionObjectCollection> response = apiInstance.DhcpServerIpv4OptionObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerOptionObjectCollection**](DhcpServerOptionObjectCollection.md)

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

<a id="dhcpserveripv4optionobjectsnamenamedelete"></a>
# **DhcpServerIpv4OptionObjectsNameNAMEDelete**
> ApiStatus DhcpServerIpv4OptionObjectsNameNAMEDelete (string NAME)



Delete DHCP server IPv4 option object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |

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

<a id="dhcpserveripv4optionobjectsnamenameget"></a>
# **DhcpServerIpv4OptionObjectsNameNAMEGet**
> DhcpServerOptionObjectCollection DhcpServerIpv4OptionObjectsNameNAMEGet (string NAME)



Retrieve DHCP server IPv4 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")

            try
            {
                DhcpServerOptionObjectCollection result = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerOptionObjectCollection> response = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |

### Return type

[**DhcpServerOptionObjectCollection**](DhcpServerOptionObjectCollection.md)

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

<a id="dhcpserveripv4optionobjectsnamenamepatch"></a>
# **DhcpServerIpv4OptionObjectsNameNAMEPatch**
> ApiStatus DhcpServerIpv4OptionObjectsNameNAMEPatch (string NAME, DhcpServerOptionObjectCollection? dhcpServerOptionObjectCollection = null)



Patch DHCP server IPv4 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")
            var dhcpServerOptionObjectCollection = new DhcpServerOptionObjectCollection?(); // DhcpServerOptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEPatch(NAME, dhcpServerOptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEPatchWithHttpInfo(NAME, dhcpServerOptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |
| **dhcpServerOptionObjectCollection** | [**DhcpServerOptionObjectCollection?**](DhcpServerOptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optionobjectsnamenameput"></a>
# **DhcpServerIpv4OptionObjectsNameNAMEPut**
> ApiStatus DhcpServerIpv4OptionObjectsNameNAMEPut (string NAME, DhcpServerOptionObjectCollection? dhcpServerOptionObjectCollection = null)



Update DHCP server IPv4 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")
            var dhcpServerOptionObjectCollection = new DhcpServerOptionObjectCollection?(); // DhcpServerOptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEPut(NAME, dhcpServerOptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionObjectsNameNAMEPutWithHttpInfo(NAME, dhcpServerOptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |
| **dhcpServerOptionObjectCollection** | [**DhcpServerOptionObjectCollection?**](DhcpServerOptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optionobjectspatch"></a>
# **DhcpServerIpv4OptionObjectsPatch**
> ApiStatus DhcpServerIpv4OptionObjectsPatch (DhcpServerOptionObjectCollection? dhcpServerOptionObjectCollection = null)



Patch DHCP server IPv4 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var dhcpServerOptionObjectCollection = new DhcpServerOptionObjectCollection?(); // DhcpServerOptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionObjectsPatch(dhcpServerOptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionObjectsPatchWithHttpInfo(dhcpServerOptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerOptionObjectCollection** | [**DhcpServerOptionObjectCollection?**](DhcpServerOptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optionobjectspost"></a>
# **DhcpServerIpv4OptionObjectsPost**
> ApiStatus DhcpServerIpv4OptionObjectsPost (DhcpServerOptionObjectCollection? dhcpServerOptionObjectCollection = null)



Add DHCP server IPv4 option object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var dhcpServerOptionObjectCollection = new DhcpServerOptionObjectCollection?(); // DhcpServerOptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionObjectsPost(dhcpServerOptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionObjectsPostWithHttpInfo(dhcpServerOptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerOptionObjectCollection** | [**DhcpServerOptionObjectCollection?**](DhcpServerOptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optionobjectsput"></a>
# **DhcpServerIpv4OptionObjectsPut**
> ApiStatus DhcpServerIpv4OptionObjectsPut (DhcpServerOptionObjectCollection? dhcpServerOptionObjectCollection = null)



Update DHCP server IPv4 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionObjectApi(config);
            var dhcpServerOptionObjectCollection = new DhcpServerOptionObjectCollection?(); // DhcpServerOptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionObjectsPut(dhcpServerOptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionObjectsPutWithHttpInfo(dhcpServerOptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionObjectApi.DhcpServerIpv4OptionObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerOptionObjectCollection** | [**DhcpServerOptionObjectCollection?**](DhcpServerOptionObjectCollection?.md) |  | [optional]  |

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

