# SonicWallGen7.Api.NdpEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NdpEntriesGet**](NdpEntryApi.md#ndpentriesget) | **GET** /ndp/entries |  |
| [**NdpEntriesIpIPMacMACInterfaceIFNAMEDelete**](NdpEntryApi.md#ndpentriesipipmacmacinterfaceifnamedelete) | **DELETE** /ndp/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**NdpEntriesIpIPMacMACInterfaceIFNAMEGet**](NdpEntryApi.md#ndpentriesipipmacmacinterfaceifnameget) | **GET** /ndp/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**NdpEntriesIpIPMacMACInterfaceIFNAMEPatch**](NdpEntryApi.md#ndpentriesipipmacmacinterfaceifnamepatch) | **PATCH** /ndp/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**NdpEntriesIpIPMacMACInterfaceIFNAMEPut**](NdpEntryApi.md#ndpentriesipipmacmacinterfaceifnameput) | **PUT** /ndp/entries/ip/{IP}/mac/{MAC}/interface/{IFNAME} |  |
| [**NdpEntriesPatch**](NdpEntryApi.md#ndpentriespatch) | **PATCH** /ndp/entries |  |
| [**NdpEntriesPost**](NdpEntryApi.md#ndpentriespost) | **POST** /ndp/entries |  |
| [**NdpEntriesPut**](NdpEntryApi.md#ndpentriesput) | **PUT** /ndp/entries |  |

<a id="ndpentriesget"></a>
# **NdpEntriesGet**
> NdpEntryCollection NdpEntriesGet ()



Retrieve neighbor discovery entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);

            try
            {
                NdpEntryCollection result = apiInstance.NdpEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NdpEntryCollection> response = apiInstance.NdpEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**NdpEntryCollection**](NdpEntryCollection.md)

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

<a id="ndpentriesipipmacmacinterfaceifnamedelete"></a>
# **NdpEntriesIpIPMacMACInterfaceIFNAMEDelete**
> ApiStatus NdpEntriesIpIPMacMACInterfaceIFNAMEDelete (string IP, string MAC, string IFNAME)



Delete a neighbor discovery entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesIpIPMacMACInterfaceIFNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var IP = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                ApiStatus result = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEDelete(IP, MAC, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo(IP, MAC, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

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

<a id="ndpentriesipipmacmacinterfaceifnameget"></a>
# **NdpEntriesIpIPMacMACInterfaceIFNAMEGet**
> NdpEntryCollection NdpEntriesIpIPMacMACInterfaceIFNAMEGet (string IP, string MAC, string IFNAME)



Retrieve neighbor discovery entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesIpIPMacMACInterfaceIFNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var IP = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                NdpEntryCollection result = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEGet(IP, MAC, IFNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NdpEntryCollection> response = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo(IP, MAC, IFNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

### Return type

[**NdpEntryCollection**](NdpEntryCollection.md)

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

<a id="ndpentriesipipmacmacinterfaceifnamepatch"></a>
# **NdpEntriesIpIPMacMACInterfaceIFNAMEPatch**
> ApiStatus NdpEntriesIpIPMacMACInterfaceIFNAMEPatch (string IP, string MAC, string IFNAME, NdpEntryCollection? ndpEntryCollection = null)



Patch neighbor discovery entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesIpIPMacMACInterfaceIFNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var IP = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var ndpEntryCollection = new NdpEntryCollection?(); // NdpEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEPatch(IP, MAC, IFNAME, ndpEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo(IP, MAC, IFNAME, ndpEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **ndpEntryCollection** | [**NdpEntryCollection?**](NdpEntryCollection?.md) |  | [optional]  |

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

<a id="ndpentriesipipmacmacinterfaceifnameput"></a>
# **NdpEntriesIpIPMacMACInterfaceIFNAMEPut**
> ApiStatus NdpEntriesIpIPMacMACInterfaceIFNAMEPut (string IP, string MAC, string IFNAME, NdpEntryCollection? ndpEntryCollection = null)



Edit neighbor discovery entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesIpIPMacMACInterfaceIFNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var IP = "\"2000:0000:0000:ff68:0205:62ef:ee8d:f25b\"";  // string | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH (default to "2000:0000:0000:ff68:0205:62ef:ee8d:f25b")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var IFNAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var ndpEntryCollection = new NdpEntryCollection?(); // NdpEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEPut(IP, MAC, IFNAME, ndpEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo(IP, MAC, IFNAME, ndpEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesIpIPMacMACInterfaceIFNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV6 Address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH | [default to &quot;2000:0000:0000:ff68:0205:62ef:ee8d:f25b&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **IFNAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **ndpEntryCollection** | [**NdpEntryCollection?**](NdpEntryCollection?.md) |  | [optional]  |

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

<a id="ndpentriespatch"></a>
# **NdpEntriesPatch**
> ApiStatus NdpEntriesPatch (NdpEntryCollection? ndpEntryCollection = null)



Patch neighbor discovery entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var ndpEntryCollection = new NdpEntryCollection?(); // NdpEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NdpEntriesPatch(ndpEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpEntriesPatchWithHttpInfo(ndpEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ndpEntryCollection** | [**NdpEntryCollection?**](NdpEntryCollection?.md) |  | [optional]  |

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

<a id="ndpentriespost"></a>
# **NdpEntriesPost**
> ApiStatus NdpEntriesPost (NdpEntryCollection? ndpEntryCollection = null)



Create a new neighbor discovery entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var ndpEntryCollection = new NdpEntryCollection?(); // NdpEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NdpEntriesPost(ndpEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpEntriesPostWithHttpInfo(ndpEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ndpEntryCollection** | [**NdpEntryCollection?**](NdpEntryCollection?.md) |  | [optional]  |

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

<a id="ndpentriesput"></a>
# **NdpEntriesPut**
> ApiStatus NdpEntriesPut (NdpEntryCollection? ndpEntryCollection = null)



Edit neighbor discovery entry object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class NdpEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new NdpEntryApi(config);
            var ndpEntryCollection = new NdpEntryCollection?(); // NdpEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.NdpEntriesPut(ndpEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NdpEntryApi.NdpEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NdpEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.NdpEntriesPutWithHttpInfo(ndpEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NdpEntryApi.NdpEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ndpEntryCollection** | [**NdpEntryCollection?**](NdpEntryCollection?.md) |  | [optional]  |

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

