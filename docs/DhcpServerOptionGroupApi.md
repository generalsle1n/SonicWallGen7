# SonicWallGen7.Api.DhcpServerOptionGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv4OptionGroupsGet**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupsget) | **GET** /dhcp-server/ipv4/option/groups |  |
| [**DhcpServerIpv4OptionGroupsNameNAMEDelete**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupsnamenamedelete) | **DELETE** /dhcp-server/ipv4/option/groups/name/{NAME} |  |
| [**DhcpServerIpv4OptionGroupsNameNAMEGet**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupsnamenameget) | **GET** /dhcp-server/ipv4/option/groups/name/{NAME} |  |
| [**DhcpServerIpv4OptionGroupsNameNAMEPatch**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupsnamenamepatch) | **PATCH** /dhcp-server/ipv4/option/groups/name/{NAME} |  |
| [**DhcpServerIpv4OptionGroupsNameNAMEPut**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupsnamenameput) | **PUT** /dhcp-server/ipv4/option/groups/name/{NAME} |  |
| [**DhcpServerIpv4OptionGroupsPatch**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupspatch) | **PATCH** /dhcp-server/ipv4/option/groups |  |
| [**DhcpServerIpv4OptionGroupsPost**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupspost) | **POST** /dhcp-server/ipv4/option/groups |  |
| [**DhcpServerIpv4OptionGroupsPut**](DhcpServerOptionGroupApi.md#dhcpserveripv4optiongroupsput) | **PUT** /dhcp-server/ipv4/option/groups |  |

<a id="dhcpserveripv4optiongroupsget"></a>
# **DhcpServerIpv4OptionGroupsGet**
> DhcpServerOptionGroupCollection DhcpServerIpv4OptionGroupsGet ()



Retrieve DHCP server IPv4 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);

            try
            {
                DhcpServerOptionGroupCollection result = apiInstance.DhcpServerIpv4OptionGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerOptionGroupCollection> response = apiInstance.DhcpServerIpv4OptionGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerOptionGroupCollection**](DhcpServerOptionGroupCollection.md)

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

<a id="dhcpserveripv4optiongroupsnamenamedelete"></a>
# **DhcpServerIpv4OptionGroupsNameNAMEDelete**
> ApiStatus DhcpServerIpv4OptionGroupsNameNAMEDelete (string NAME)



Delete DHCP server IPv4 option group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |

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

<a id="dhcpserveripv4optiongroupsnamenameget"></a>
# **DhcpServerIpv4OptionGroupsNameNAMEGet**
> DhcpServerOptionGroupCollection DhcpServerIpv4OptionGroupsNameNAMEGet (string NAME)



Retrieve DHCP server IPv4 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")

            try
            {
                DhcpServerOptionGroupCollection result = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerOptionGroupCollection> response = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |

### Return type

[**DhcpServerOptionGroupCollection**](DhcpServerOptionGroupCollection.md)

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

<a id="dhcpserveripv4optiongroupsnamenamepatch"></a>
# **DhcpServerIpv4OptionGroupsNameNAMEPatch**
> ApiStatus DhcpServerIpv4OptionGroupsNameNAMEPatch (string NAME, DhcpServerOptionGroupCollection? dhcpServerOptionGroupCollection = null)



Patch DHCP server IPv4 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")
            var dhcpServerOptionGroupCollection = new DhcpServerOptionGroupCollection?(); // DhcpServerOptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEPatch(NAME, dhcpServerOptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEPatchWithHttpInfo(NAME, dhcpServerOptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |
| **dhcpServerOptionGroupCollection** | [**DhcpServerOptionGroupCollection?**](DhcpServerOptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optiongroupsnamenameput"></a>
# **DhcpServerIpv4OptionGroupsNameNAMEPut**
> ApiStatus DhcpServerIpv4OptionGroupsNameNAMEPut (string NAME, DhcpServerOptionGroupCollection? dhcpServerOptionGroupCollection = null)



Update DHCP server IPv4 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")
            var dhcpServerOptionGroupCollection = new DhcpServerOptionGroupCollection?(); // DhcpServerOptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEPut(NAME, dhcpServerOptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionGroupsNameNAMEPutWithHttpInfo(NAME, dhcpServerOptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |
| **dhcpServerOptionGroupCollection** | [**DhcpServerOptionGroupCollection?**](DhcpServerOptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optiongroupspatch"></a>
# **DhcpServerIpv4OptionGroupsPatch**
> ApiStatus DhcpServerIpv4OptionGroupsPatch (DhcpServerOptionGroupCollection? dhcpServerOptionGroupCollection = null)



Patch DHCP server IPv4 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var dhcpServerOptionGroupCollection = new DhcpServerOptionGroupCollection?(); // DhcpServerOptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionGroupsPatch(dhcpServerOptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionGroupsPatchWithHttpInfo(dhcpServerOptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerOptionGroupCollection** | [**DhcpServerOptionGroupCollection?**](DhcpServerOptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optiongroupspost"></a>
# **DhcpServerIpv4OptionGroupsPost**
> ApiStatus DhcpServerIpv4OptionGroupsPost (DhcpServerOptionGroupCollection? dhcpServerOptionGroupCollection = null)



Add DHCP server IPv4 option group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var dhcpServerOptionGroupCollection = new DhcpServerOptionGroupCollection?(); // DhcpServerOptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionGroupsPost(dhcpServerOptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionGroupsPostWithHttpInfo(dhcpServerOptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerOptionGroupCollection** | [**DhcpServerOptionGroupCollection?**](DhcpServerOptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv4optiongroupsput"></a>
# **DhcpServerIpv4OptionGroupsPut**
> ApiStatus DhcpServerIpv4OptionGroupsPut (DhcpServerOptionGroupCollection? dhcpServerOptionGroupCollection = null)



Update DHCP server IPv4 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv4OptionGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerOptionGroupApi(config);
            var dhcpServerOptionGroupCollection = new DhcpServerOptionGroupCollection?(); // DhcpServerOptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv4OptionGroupsPut(dhcpServerOptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv4OptionGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv4OptionGroupsPutWithHttpInfo(dhcpServerOptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerOptionGroupApi.DhcpServerIpv4OptionGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerOptionGroupCollection** | [**DhcpServerOptionGroupCollection?**](DhcpServerOptionGroupCollection?.md) |  | [optional]  |

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

