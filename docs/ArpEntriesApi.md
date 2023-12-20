# SonicWallGen7.Api.ArpEntriesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ArpEntriesGet**](ArpEntriesApi.md#arpentriesget) | **GET** /arp/entries |  |
| [**ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDelete**](ArpEntriesApi.md#arpentriesipipmacmacinterfaceinterfacenamedelete) | **DELETE** /arp/entries/ip/{IP}/mac/{MAC}/interface/{INTERFACENAME} |  |
| [**ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGet**](ArpEntriesApi.md#arpentriesipipmacmacinterfaceinterfacenameget) | **GET** /arp/entries/ip/{IP}/mac/{MAC}/interface/{INTERFACENAME} |  |
| [**ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatch**](ArpEntriesApi.md#arpentriesipipmacmacinterfaceinterfacenamepatch) | **PATCH** /arp/entries/ip/{IP}/mac/{MAC}/interface/{INTERFACENAME} |  |
| [**ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPut**](ArpEntriesApi.md#arpentriesipipmacmacinterfaceinterfacenameput) | **PUT** /arp/entries/ip/{IP}/mac/{MAC}/interface/{INTERFACENAME} |  |
| [**ArpEntriesPatch**](ArpEntriesApi.md#arpentriespatch) | **PATCH** /arp/entries |  |
| [**ArpEntriesPost**](ArpEntriesApi.md#arpentriespost) | **POST** /arp/entries |  |
| [**ArpEntriesPut**](ArpEntriesApi.md#arpentriesput) | **PUT** /arp/entries |  |

<a id="arpentriesget"></a>
# **ArpEntriesGet**
> ArpEntriesCollection ArpEntriesGet ()



Retrieve ARP entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);

            try
            {
                ArpEntriesCollection result = apiInstance.ArpEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArpEntriesCollection> response = apiInstance.ArpEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ArpEntriesCollection**](ArpEntriesCollection.md)

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

<a id="arpentriesipipmacmacinterfaceinterfacenamedelete"></a>
# **ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDelete**
> ApiStatus ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDelete (string IP, string MAC, string INTERFACENAME)



Delete ARP entry configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var INTERFACENAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                ApiStatus result = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDelete(IP, MAC, INTERFACENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDeleteWithHttpInfo(IP, MAC, INTERFACENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **INTERFACENAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

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

<a id="arpentriesipipmacmacinterfaceinterfacenameget"></a>
# **ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGet**
> ArpEntriesCollection ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGet (string IP, string MAC, string INTERFACENAME)



Retrieve ARP entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var INTERFACENAME = "\"X0\"";  // string | Interface name. (default to "X0")

            try
            {
                ArpEntriesCollection result = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGet(IP, MAC, INTERFACENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArpEntriesCollection> response = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGetWithHttpInfo(IP, MAC, INTERFACENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **INTERFACENAME** | **string** | Interface name. | [default to &quot;X0&quot;] |

### Return type

[**ArpEntriesCollection**](ArpEntriesCollection.md)

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

<a id="arpentriesipipmacmacinterfaceinterfacenamepatch"></a>
# **ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatch**
> ApiStatus ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatch (string IP, string MAC, string INTERFACENAME, ArpEntriesCollection? arpEntriesCollection = null)



Patch ARP entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var INTERFACENAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var arpEntriesCollection = new ArpEntriesCollection?(); // ArpEntriesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatch(IP, MAC, INTERFACENAME, arpEntriesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatchWithHttpInfo(IP, MAC, INTERFACENAME, arpEntriesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **INTERFACENAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **arpEntriesCollection** | [**ArpEntriesCollection?**](ArpEntriesCollection?.md) |  | [optional]  |

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

<a id="arpentriesipipmacmacinterfaceinterfacenameput"></a>
# **ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPut**
> ApiStatus ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPut (string IP, string MAC, string INTERFACENAME, ArpEntriesCollection? arpEntriesCollection = null)



Update ARP entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var IP = "\"192.168.168.168\"";  // string | IPV4 Address in the form: a.b.c.d (default to "192.168.168.168")
            var MAC = "\"00:0C:F1:56:98:AD\"";  // string | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH (default to "00:0C:F1:56:98:AD")
            var INTERFACENAME = "\"X0\"";  // string | Interface name. (default to "X0")
            var arpEntriesCollection = new ArpEntriesCollection?(); // ArpEntriesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPut(IP, MAC, INTERFACENAME, arpEntriesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPutWithHttpInfo(IP, MAC, INTERFACENAME, arpEntriesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesIpIPMacMACInterfaceINTERFACENAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4 Address in the form: a.b.c.d | [default to &quot;192.168.168.168&quot;] |
| **MAC** | **string** | MAC address in the form: HH:HH:HH:HH:HH:HH OR HHHHHHHHHHHH | [default to &quot;00:0C:F1:56:98:AD&quot;] |
| **INTERFACENAME** | **string** | Interface name. | [default to &quot;X0&quot;] |
| **arpEntriesCollection** | [**ArpEntriesCollection?**](ArpEntriesCollection?.md) |  | [optional]  |

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

<a id="arpentriespatch"></a>
# **ArpEntriesPatch**
> ApiStatus ArpEntriesPatch (ArpEntriesCollection? arpEntriesCollection = null)



Patch ARP entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var arpEntriesCollection = new ArpEntriesCollection?(); // ArpEntriesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ArpEntriesPatch(arpEntriesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ArpEntriesPatchWithHttpInfo(arpEntriesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **arpEntriesCollection** | [**ArpEntriesCollection?**](ArpEntriesCollection?.md) |  | [optional]  |

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

<a id="arpentriespost"></a>
# **ArpEntriesPost**
> ApiStatus ArpEntriesPost (ArpEntriesCollection? arpEntriesCollection = null)



Add ARP entry configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var arpEntriesCollection = new ArpEntriesCollection?(); // ArpEntriesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ArpEntriesPost(arpEntriesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ArpEntriesPostWithHttpInfo(arpEntriesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **arpEntriesCollection** | [**ArpEntriesCollection?**](ArpEntriesCollection?.md) |  | [optional]  |

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

<a id="arpentriesput"></a>
# **ArpEntriesPut**
> ApiStatus ArpEntriesPut (ArpEntriesCollection? arpEntriesCollection = null)



Update ARP entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ArpEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArpEntriesApi(config);
            var arpEntriesCollection = new ArpEntriesCollection?(); // ArpEntriesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.ArpEntriesPut(arpEntriesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArpEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.ArpEntriesPutWithHttpInfo(arpEntriesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArpEntriesApi.ArpEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **arpEntriesCollection** | [**ArpEntriesCollection?**](ArpEntriesCollection?.md) |  | [optional]  |

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

