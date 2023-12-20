# SonicWallGen7.Api.DhcpServerIpv6OptionObjectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv6OptionObjectsGet**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectsget) | **GET** /dhcp-server/ipv6/option/objects |  |
| [**DhcpServerIpv6OptionObjectsNameNAMEDelete**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectsnamenamedelete) | **DELETE** /dhcp-server/ipv6/option/objects/name/{NAME} |  |
| [**DhcpServerIpv6OptionObjectsNameNAMEGet**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectsnamenameget) | **GET** /dhcp-server/ipv6/option/objects/name/{NAME} |  |
| [**DhcpServerIpv6OptionObjectsNameNAMEPatch**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectsnamenamepatch) | **PATCH** /dhcp-server/ipv6/option/objects/name/{NAME} |  |
| [**DhcpServerIpv6OptionObjectsNameNAMEPut**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectsnamenameput) | **PUT** /dhcp-server/ipv6/option/objects/name/{NAME} |  |
| [**DhcpServerIpv6OptionObjectsPatch**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectspatch) | **PATCH** /dhcp-server/ipv6/option/objects |  |
| [**DhcpServerIpv6OptionObjectsPost**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectspost) | **POST** /dhcp-server/ipv6/option/objects |  |
| [**DhcpServerIpv6OptionObjectsPut**](DhcpServerIpv6OptionObjectApi.md#dhcpserveripv6optionobjectsput) | **PUT** /dhcp-server/ipv6/option/objects |  |

<a id="dhcpserveripv6optionobjectsget"></a>
# **DhcpServerIpv6OptionObjectsGet**
> DhcpServerIpv6OptionObjectCollection DhcpServerIpv6OptionObjectsGet ()



Retrieve DHCP server IPv6 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);

            try
            {
                DhcpServerIpv6OptionObjectCollection result = apiInstance.DhcpServerIpv6OptionObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6OptionObjectCollection> response = apiInstance.DhcpServerIpv6OptionObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerIpv6OptionObjectCollection**](DhcpServerIpv6OptionObjectCollection.md)

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

<a id="dhcpserveripv6optionobjectsnamenamedelete"></a>
# **DhcpServerIpv6OptionObjectsNameNAMEDelete**
> ApiStatus DhcpServerIpv6OptionObjectsNameNAMEDelete (string NAME)



Delete DHCP server IPv6 option object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="dhcpserveripv6optionobjectsnamenameget"></a>
# **DhcpServerIpv6OptionObjectsNameNAMEGet**
> DhcpServerIpv6OptionObjectCollection DhcpServerIpv6OptionObjectsNameNAMEGet (string NAME)



Retrieve DHCP server IPv6 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")

            try
            {
                DhcpServerIpv6OptionObjectCollection result = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6OptionObjectCollection> response = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |

### Return type

[**DhcpServerIpv6OptionObjectCollection**](DhcpServerIpv6OptionObjectCollection.md)

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

<a id="dhcpserveripv6optionobjectsnamenamepatch"></a>
# **DhcpServerIpv6OptionObjectsNameNAMEPatch**
> ApiStatus DhcpServerIpv6OptionObjectsNameNAMEPatch (string NAME, DhcpServerIpv6OptionObjectCollection? dhcpServerIpv6OptionObjectCollection = null)



Patch DHCP server IPv6 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")
            var dhcpServerIpv6OptionObjectCollection = new DhcpServerIpv6OptionObjectCollection?(); // DhcpServerIpv6OptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEPatch(NAME, dhcpServerIpv6OptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEPatchWithHttpInfo(NAME, dhcpServerIpv6OptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |
| **dhcpServerIpv6OptionObjectCollection** | [**DhcpServerIpv6OptionObjectCollection?**](DhcpServerIpv6OptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optionobjectsnamenameput"></a>
# **DhcpServerIpv6OptionObjectsNameNAMEPut**
> ApiStatus DhcpServerIpv6OptionObjectsNameNAMEPut (string NAME, DhcpServerIpv6OptionObjectCollection? dhcpServerIpv6OptionObjectCollection = null)



Update DHCP server IPv6 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var NAME = "\"Corp Network DHCP Options\"";  // string | DHCP server option object name. (default to "Corp Network DHCP Options")
            var dhcpServerIpv6OptionObjectCollection = new DhcpServerIpv6OptionObjectCollection?(); // DhcpServerIpv6OptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEPut(NAME, dhcpServerIpv6OptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionObjectsNameNAMEPutWithHttpInfo(NAME, dhcpServerIpv6OptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option object name. | [default to &quot;Corp Network DHCP Options&quot;] |
| **dhcpServerIpv6OptionObjectCollection** | [**DhcpServerIpv6OptionObjectCollection?**](DhcpServerIpv6OptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optionobjectspatch"></a>
# **DhcpServerIpv6OptionObjectsPatch**
> ApiStatus DhcpServerIpv6OptionObjectsPatch (DhcpServerIpv6OptionObjectCollection? dhcpServerIpv6OptionObjectCollection = null)



Patch DHCP server IPv6 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var dhcpServerIpv6OptionObjectCollection = new DhcpServerIpv6OptionObjectCollection?(); // DhcpServerIpv6OptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionObjectsPatch(dhcpServerIpv6OptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionObjectsPatchWithHttpInfo(dhcpServerIpv6OptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6OptionObjectCollection** | [**DhcpServerIpv6OptionObjectCollection?**](DhcpServerIpv6OptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optionobjectspost"></a>
# **DhcpServerIpv6OptionObjectsPost**
> ApiStatus DhcpServerIpv6OptionObjectsPost (DhcpServerIpv6OptionObjectCollection? dhcpServerIpv6OptionObjectCollection = null)



Add DHCP server IPv6 option object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var dhcpServerIpv6OptionObjectCollection = new DhcpServerIpv6OptionObjectCollection?(); // DhcpServerIpv6OptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionObjectsPost(dhcpServerIpv6OptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionObjectsPostWithHttpInfo(dhcpServerIpv6OptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6OptionObjectCollection** | [**DhcpServerIpv6OptionObjectCollection?**](DhcpServerIpv6OptionObjectCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optionobjectsput"></a>
# **DhcpServerIpv6OptionObjectsPut**
> ApiStatus DhcpServerIpv6OptionObjectsPut (DhcpServerIpv6OptionObjectCollection? dhcpServerIpv6OptionObjectCollection = null)



Update DHCP server IPv6 option object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionObjectApi(config);
            var dhcpServerIpv6OptionObjectCollection = new DhcpServerIpv6OptionObjectCollection?(); // DhcpServerIpv6OptionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionObjectsPut(dhcpServerIpv6OptionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionObjectsPutWithHttpInfo(dhcpServerIpv6OptionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionObjectApi.DhcpServerIpv6OptionObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6OptionObjectCollection** | [**DhcpServerIpv6OptionObjectCollection?**](DhcpServerIpv6OptionObjectCollection?.md) |  | [optional]  |

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

