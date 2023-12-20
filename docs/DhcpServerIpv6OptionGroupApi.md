# SonicWallGen7.Api.DhcpServerIpv6OptionGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DhcpServerIpv6OptionGroupsGet**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupsget) | **GET** /dhcp-server/ipv6/option/groups |  |
| [**DhcpServerIpv6OptionGroupsNameNAMEDelete**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupsnamenamedelete) | **DELETE** /dhcp-server/ipv6/option/groups/name/{NAME} |  |
| [**DhcpServerIpv6OptionGroupsNameNAMEGet**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupsnamenameget) | **GET** /dhcp-server/ipv6/option/groups/name/{NAME} |  |
| [**DhcpServerIpv6OptionGroupsNameNAMEPatch**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupsnamenamepatch) | **PATCH** /dhcp-server/ipv6/option/groups/name/{NAME} |  |
| [**DhcpServerIpv6OptionGroupsNameNAMEPut**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupsnamenameput) | **PUT** /dhcp-server/ipv6/option/groups/name/{NAME} |  |
| [**DhcpServerIpv6OptionGroupsPatch**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupspatch) | **PATCH** /dhcp-server/ipv6/option/groups |  |
| [**DhcpServerIpv6OptionGroupsPost**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupspost) | **POST** /dhcp-server/ipv6/option/groups |  |
| [**DhcpServerIpv6OptionGroupsPut**](DhcpServerIpv6OptionGroupApi.md#dhcpserveripv6optiongroupsput) | **PUT** /dhcp-server/ipv6/option/groups |  |

<a id="dhcpserveripv6optiongroupsget"></a>
# **DhcpServerIpv6OptionGroupsGet**
> DhcpServerIpv6OptionGroupCollection DhcpServerIpv6OptionGroupsGet ()



Retrieve DHCP server IPv6 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);

            try
            {
                DhcpServerIpv6OptionGroupCollection result = apiInstance.DhcpServerIpv6OptionGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6OptionGroupCollection> response = apiInstance.DhcpServerIpv6OptionGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DhcpServerIpv6OptionGroupCollection**](DhcpServerIpv6OptionGroupCollection.md)

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

<a id="dhcpserveripv6optiongroupsnamenamedelete"></a>
# **DhcpServerIpv6OptionGroupsNameNAMEDelete**
> ApiStatus DhcpServerIpv6OptionGroupsNameNAMEDelete (string NAME)



Delete DHCP server IPv6 option group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEDeleteWithHttpInfo: " + e.Message);
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

<a id="dhcpserveripv6optiongroupsnamenameget"></a>
# **DhcpServerIpv6OptionGroupsNameNAMEGet**
> DhcpServerIpv6OptionGroupCollection DhcpServerIpv6OptionGroupsNameNAMEGet (string NAME)



Retrieve DHCP server IPv6 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")

            try
            {
                DhcpServerIpv6OptionGroupCollection result = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DhcpServerIpv6OptionGroupCollection> response = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |

### Return type

[**DhcpServerIpv6OptionGroupCollection**](DhcpServerIpv6OptionGroupCollection.md)

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

<a id="dhcpserveripv6optiongroupsnamenamepatch"></a>
# **DhcpServerIpv6OptionGroupsNameNAMEPatch**
> ApiStatus DhcpServerIpv6OptionGroupsNameNAMEPatch (string NAME, DhcpServerIpv6OptionGroupCollection? dhcpServerIpv6OptionGroupCollection = null)



Patch DHCP server IPv6 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")
            var dhcpServerIpv6OptionGroupCollection = new DhcpServerIpv6OptionGroupCollection?(); // DhcpServerIpv6OptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEPatch(NAME, dhcpServerIpv6OptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEPatchWithHttpInfo(NAME, dhcpServerIpv6OptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |
| **dhcpServerIpv6OptionGroupCollection** | [**DhcpServerIpv6OptionGroupCollection?**](DhcpServerIpv6OptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optiongroupsnamenameput"></a>
# **DhcpServerIpv6OptionGroupsNameNAMEPut**
> ApiStatus DhcpServerIpv6OptionGroupsNameNAMEPut (string NAME, DhcpServerIpv6OptionGroupCollection? dhcpServerIpv6OptionGroupCollection = null)



Update DHCP server IPv6 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var NAME = "\"Corp Network DHCP Group\"";  // string | DHCP server option group name. (default to "Corp Network DHCP Group")
            var dhcpServerIpv6OptionGroupCollection = new DhcpServerIpv6OptionGroupCollection?(); // DhcpServerIpv6OptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEPut(NAME, dhcpServerIpv6OptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionGroupsNameNAMEPutWithHttpInfo(NAME, dhcpServerIpv6OptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | DHCP server option group name. | [default to &quot;Corp Network DHCP Group&quot;] |
| **dhcpServerIpv6OptionGroupCollection** | [**DhcpServerIpv6OptionGroupCollection?**](DhcpServerIpv6OptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optiongroupspatch"></a>
# **DhcpServerIpv6OptionGroupsPatch**
> ApiStatus DhcpServerIpv6OptionGroupsPatch (DhcpServerIpv6OptionGroupCollection? dhcpServerIpv6OptionGroupCollection = null)



Patch DHCP server IPv6 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var dhcpServerIpv6OptionGroupCollection = new DhcpServerIpv6OptionGroupCollection?(); // DhcpServerIpv6OptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionGroupsPatch(dhcpServerIpv6OptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionGroupsPatchWithHttpInfo(dhcpServerIpv6OptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6OptionGroupCollection** | [**DhcpServerIpv6OptionGroupCollection?**](DhcpServerIpv6OptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optiongroupspost"></a>
# **DhcpServerIpv6OptionGroupsPost**
> ApiStatus DhcpServerIpv6OptionGroupsPost (DhcpServerIpv6OptionGroupCollection? dhcpServerIpv6OptionGroupCollection = null)



Add DHCP server IPv6 option group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var dhcpServerIpv6OptionGroupCollection = new DhcpServerIpv6OptionGroupCollection?(); // DhcpServerIpv6OptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionGroupsPost(dhcpServerIpv6OptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionGroupsPostWithHttpInfo(dhcpServerIpv6OptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6OptionGroupCollection** | [**DhcpServerIpv6OptionGroupCollection?**](DhcpServerIpv6OptionGroupCollection?.md) |  | [optional]  |

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

<a id="dhcpserveripv6optiongroupsput"></a>
# **DhcpServerIpv6OptionGroupsPut**
> ApiStatus DhcpServerIpv6OptionGroupsPut (DhcpServerIpv6OptionGroupCollection? dhcpServerIpv6OptionGroupCollection = null)



Update DHCP server IPv6 option group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DhcpServerIpv6OptionGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DhcpServerIpv6OptionGroupApi(config);
            var dhcpServerIpv6OptionGroupCollection = new DhcpServerIpv6OptionGroupCollection?(); // DhcpServerIpv6OptionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DhcpServerIpv6OptionGroupsPut(dhcpServerIpv6OptionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DhcpServerIpv6OptionGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DhcpServerIpv6OptionGroupsPutWithHttpInfo(dhcpServerIpv6OptionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DhcpServerIpv6OptionGroupApi.DhcpServerIpv6OptionGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dhcpServerIpv6OptionGroupCollection** | [**DhcpServerIpv6OptionGroupCollection?**](DhcpServerIpv6OptionGroupCollection?.md) |  | [optional]  |

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

