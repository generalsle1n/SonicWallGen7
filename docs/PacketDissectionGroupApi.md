# SonicWallGen7.Api.PacketDissectionGroupApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PacketDissectionGroupsGet**](PacketDissectionGroupApi.md#packetdissectiongroupsget) | **GET** /packet-dissection-groups |  |
| [**PacketDissectionGroupsNameNAMEDelete**](PacketDissectionGroupApi.md#packetdissectiongroupsnamenamedelete) | **DELETE** /packet-dissection-groups/name/{NAME} |  |
| [**PacketDissectionGroupsNameNAMEGet**](PacketDissectionGroupApi.md#packetdissectiongroupsnamenameget) | **GET** /packet-dissection-groups/name/{NAME} |  |
| [**PacketDissectionGroupsNameNAMEPatch**](PacketDissectionGroupApi.md#packetdissectiongroupsnamenamepatch) | **PATCH** /packet-dissection-groups/name/{NAME} |  |
| [**PacketDissectionGroupsNameNAMEPut**](PacketDissectionGroupApi.md#packetdissectiongroupsnamenameput) | **PUT** /packet-dissection-groups/name/{NAME} |  |
| [**PacketDissectionGroupsPatch**](PacketDissectionGroupApi.md#packetdissectiongroupspatch) | **PATCH** /packet-dissection-groups |  |
| [**PacketDissectionGroupsPost**](PacketDissectionGroupApi.md#packetdissectiongroupspost) | **POST** /packet-dissection-groups |  |
| [**PacketDissectionGroupsPut**](PacketDissectionGroupApi.md#packetdissectiongroupsput) | **PUT** /packet-dissection-groups |  |

<a id="packetdissectiongroupsget"></a>
# **PacketDissectionGroupsGet**
> PacketDissectionGroupCollection PacketDissectionGroupsGet ()



Retrieve packet dissection group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);

            try
            {
                PacketDissectionGroupCollection result = apiInstance.PacketDissectionGroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PacketDissectionGroupCollection> response = apiInstance.PacketDissectionGroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PacketDissectionGroupCollection**](PacketDissectionGroupCollection.md)

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

<a id="packetdissectiongroupsnamenamedelete"></a>
# **PacketDissectionGroupsNameNAMEDelete**
> ApiStatus PacketDissectionGroupsNameNAMEDelete (string NAME)



Delete a packet dissection group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var NAME = "\"PdfGroupName\"";  // string | Packet Dissection Group name. (default to "PdfGroupName")

            try
            {
                ApiStatus result = apiInstance.PacketDissectionGroupsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionGroupsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection Group name. | [default to &quot;PdfGroupName&quot;] |

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

<a id="packetdissectiongroupsnamenameget"></a>
# **PacketDissectionGroupsNameNAMEGet**
> PacketDissectionGroupCollection PacketDissectionGroupsNameNAMEGet (string NAME)



Retrieve packet dissection group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var NAME = "\"PdfGroupName\"";  // string | Packet Dissection Group name. (default to "PdfGroupName")

            try
            {
                PacketDissectionGroupCollection result = apiInstance.PacketDissectionGroupsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PacketDissectionGroupCollection> response = apiInstance.PacketDissectionGroupsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection Group name. | [default to &quot;PdfGroupName&quot;] |

### Return type

[**PacketDissectionGroupCollection**](PacketDissectionGroupCollection.md)

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

<a id="packetdissectiongroupsnamenamepatch"></a>
# **PacketDissectionGroupsNameNAMEPatch**
> ApiStatus PacketDissectionGroupsNameNAMEPatch (string NAME, PacketDissectionGroupCollection? packetDissectionGroupCollection = null)



Patch packet dissection group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var NAME = "\"PdfGroupName\"";  // string | Packet Dissection Group name. (default to "PdfGroupName")
            var packetDissectionGroupCollection = new PacketDissectionGroupCollection?(); // PacketDissectionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionGroupsNameNAMEPatch(NAME, packetDissectionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionGroupsNameNAMEPatchWithHttpInfo(NAME, packetDissectionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection Group name. | [default to &quot;PdfGroupName&quot;] |
| **packetDissectionGroupCollection** | [**PacketDissectionGroupCollection?**](PacketDissectionGroupCollection?.md) |  | [optional]  |

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

<a id="packetdissectiongroupsnamenameput"></a>
# **PacketDissectionGroupsNameNAMEPut**
> ApiStatus PacketDissectionGroupsNameNAMEPut (string NAME, PacketDissectionGroupCollection? packetDissectionGroupCollection = null)



Edit packet-dissection group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var NAME = "\"PdfGroupName\"";  // string | Packet Dissection Group name. (default to "PdfGroupName")
            var packetDissectionGroupCollection = new PacketDissectionGroupCollection?(); // PacketDissectionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionGroupsNameNAMEPut(NAME, packetDissectionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionGroupsNameNAMEPutWithHttpInfo(NAME, packetDissectionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection Group name. | [default to &quot;PdfGroupName&quot;] |
| **packetDissectionGroupCollection** | [**PacketDissectionGroupCollection?**](PacketDissectionGroupCollection?.md) |  | [optional]  |

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

<a id="packetdissectiongroupspatch"></a>
# **PacketDissectionGroupsPatch**
> ApiStatus PacketDissectionGroupsPatch (PacketDissectionGroupCollection? packetDissectionGroupCollection = null)



Patch packet dissection group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var packetDissectionGroupCollection = new PacketDissectionGroupCollection?(); // PacketDissectionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionGroupsPatch(packetDissectionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionGroupsPatchWithHttpInfo(packetDissectionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetDissectionGroupCollection** | [**PacketDissectionGroupCollection?**](PacketDissectionGroupCollection?.md) |  | [optional]  |

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

<a id="packetdissectiongroupspost"></a>
# **PacketDissectionGroupsPost**
> ApiStatus PacketDissectionGroupsPost (PacketDissectionGroupCollection? packetDissectionGroupCollection = null)



Create a new packet dissection group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var packetDissectionGroupCollection = new PacketDissectionGroupCollection?(); // PacketDissectionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionGroupsPost(packetDissectionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionGroupsPostWithHttpInfo(packetDissectionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetDissectionGroupCollection** | [**PacketDissectionGroupCollection?**](PacketDissectionGroupCollection?.md) |  | [optional]  |

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

<a id="packetdissectiongroupsput"></a>
# **PacketDissectionGroupsPut**
> ApiStatus PacketDissectionGroupsPut (PacketDissectionGroupCollection? packetDissectionGroupCollection = null)



Edit packet-dissection group configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionGroupsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionGroupApi(config);
            var packetDissectionGroupCollection = new PacketDissectionGroupCollection?(); // PacketDissectionGroupCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionGroupsPut(packetDissectionGroupCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionGroupsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionGroupsPutWithHttpInfo(packetDissectionGroupCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionGroupApi.PacketDissectionGroupsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetDissectionGroupCollection** | [**PacketDissectionGroupCollection?**](PacketDissectionGroupCollection?.md) |  | [optional]  |

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

