# SonicWallGen7.Api.PacketDissectionObjectApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PacketDissectionObjectsGet**](PacketDissectionObjectApi.md#packetdissectionobjectsget) | **GET** /packet-dissection-objects |  |
| [**PacketDissectionObjectsNameNAMEDelete**](PacketDissectionObjectApi.md#packetdissectionobjectsnamenamedelete) | **DELETE** /packet-dissection-objects/name/{NAME} |  |
| [**PacketDissectionObjectsNameNAMEGet**](PacketDissectionObjectApi.md#packetdissectionobjectsnamenameget) | **GET** /packet-dissection-objects/name/{NAME} |  |
| [**PacketDissectionObjectsNameNAMEPatch**](PacketDissectionObjectApi.md#packetdissectionobjectsnamenamepatch) | **PATCH** /packet-dissection-objects/name/{NAME} |  |
| [**PacketDissectionObjectsNameNAMEPut**](PacketDissectionObjectApi.md#packetdissectionobjectsnamenameput) | **PUT** /packet-dissection-objects/name/{NAME} |  |
| [**PacketDissectionObjectsPatch**](PacketDissectionObjectApi.md#packetdissectionobjectspatch) | **PATCH** /packet-dissection-objects |  |
| [**PacketDissectionObjectsPost**](PacketDissectionObjectApi.md#packetdissectionobjectspost) | **POST** /packet-dissection-objects |  |
| [**PacketDissectionObjectsPut**](PacketDissectionObjectApi.md#packetdissectionobjectsput) | **PUT** /packet-dissection-objects |  |

<a id="packetdissectionobjectsget"></a>
# **PacketDissectionObjectsGet**
> PacketDissectionObjectCollection PacketDissectionObjectsGet ()



Retrieve packet dissection object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);

            try
            {
                PacketDissectionObjectCollection result = apiInstance.PacketDissectionObjectsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PacketDissectionObjectCollection> response = apiInstance.PacketDissectionObjectsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PacketDissectionObjectCollection**](PacketDissectionObjectCollection.md)

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

<a id="packetdissectionobjectsnamenamedelete"></a>
# **PacketDissectionObjectsNameNAMEDelete**
> ApiStatus PacketDissectionObjectsNameNAMEDelete (string NAME)



Delete a packet dissection object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var NAME = "\"PdfName\"";  // string | Packet Dissection object name. (default to "PdfName")

            try
            {
                ApiStatus result = apiInstance.PacketDissectionObjectsNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionObjectsNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection object name. | [default to &quot;PdfName&quot;] |

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

<a id="packetdissectionobjectsnamenameget"></a>
# **PacketDissectionObjectsNameNAMEGet**
> PacketDissectionObjectCollection PacketDissectionObjectsNameNAMEGet (string NAME)



Retrieve packet dissection object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var NAME = "\"PdfName\"";  // string | Packet Dissection object name. (default to "PdfName")

            try
            {
                PacketDissectionObjectCollection result = apiInstance.PacketDissectionObjectsNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PacketDissectionObjectCollection> response = apiInstance.PacketDissectionObjectsNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection object name. | [default to &quot;PdfName&quot;] |

### Return type

[**PacketDissectionObjectCollection**](PacketDissectionObjectCollection.md)

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

<a id="packetdissectionobjectsnamenamepatch"></a>
# **PacketDissectionObjectsNameNAMEPatch**
> ApiStatus PacketDissectionObjectsNameNAMEPatch (string NAME, PacketDissectionObjectCollection? packetDissectionObjectCollection = null)



Patch packet dissection object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var NAME = "\"PdfName\"";  // string | Packet Dissection object name. (default to "PdfName")
            var packetDissectionObjectCollection = new PacketDissectionObjectCollection?(); // PacketDissectionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionObjectsNameNAMEPatch(NAME, packetDissectionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionObjectsNameNAMEPatchWithHttpInfo(NAME, packetDissectionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection object name. | [default to &quot;PdfName&quot;] |
| **packetDissectionObjectCollection** | [**PacketDissectionObjectCollection?**](PacketDissectionObjectCollection?.md) |  | [optional]  |

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

<a id="packetdissectionobjectsnamenameput"></a>
# **PacketDissectionObjectsNameNAMEPut**
> ApiStatus PacketDissectionObjectsNameNAMEPut (string NAME, PacketDissectionObjectCollection? packetDissectionObjectCollection = null)



Edit packet-dissection object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var NAME = "\"PdfName\"";  // string | Packet Dissection object name. (default to "PdfName")
            var packetDissectionObjectCollection = new PacketDissectionObjectCollection?(); // PacketDissectionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionObjectsNameNAMEPut(NAME, packetDissectionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionObjectsNameNAMEPutWithHttpInfo(NAME, packetDissectionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Packet Dissection object name. | [default to &quot;PdfName&quot;] |
| **packetDissectionObjectCollection** | [**PacketDissectionObjectCollection?**](PacketDissectionObjectCollection?.md) |  | [optional]  |

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

<a id="packetdissectionobjectspatch"></a>
# **PacketDissectionObjectsPatch**
> ApiStatus PacketDissectionObjectsPatch (PacketDissectionObjectCollection? packetDissectionObjectCollection = null)



Patch packet dissection object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var packetDissectionObjectCollection = new PacketDissectionObjectCollection?(); // PacketDissectionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionObjectsPatch(packetDissectionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionObjectsPatchWithHttpInfo(packetDissectionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetDissectionObjectCollection** | [**PacketDissectionObjectCollection?**](PacketDissectionObjectCollection?.md) |  | [optional]  |

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

<a id="packetdissectionobjectspost"></a>
# **PacketDissectionObjectsPost**
> ApiStatus PacketDissectionObjectsPost (PacketDissectionObjectCollection? packetDissectionObjectCollection = null)



Create a new packet dissection object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var packetDissectionObjectCollection = new PacketDissectionObjectCollection?(); // PacketDissectionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionObjectsPost(packetDissectionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionObjectsPostWithHttpInfo(packetDissectionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetDissectionObjectCollection** | [**PacketDissectionObjectCollection?**](PacketDissectionObjectCollection?.md) |  | [optional]  |

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

<a id="packetdissectionobjectsput"></a>
# **PacketDissectionObjectsPut**
> ApiStatus PacketDissectionObjectsPut (PacketDissectionObjectCollection? packetDissectionObjectCollection = null)



Edit packet-dissection object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketDissectionObjectsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketDissectionObjectApi(config);
            var packetDissectionObjectCollection = new PacketDissectionObjectCollection?(); // PacketDissectionObjectCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketDissectionObjectsPut(packetDissectionObjectCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketDissectionObjectsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketDissectionObjectsPutWithHttpInfo(packetDissectionObjectCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketDissectionObjectApi.PacketDissectionObjectsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetDissectionObjectCollection** | [**PacketDissectionObjectCollection?**](PacketDissectionObjectCollection?.md) |  | [optional]  |

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

