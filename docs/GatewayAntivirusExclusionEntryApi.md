# SonicWallGen7.Api.GatewayAntivirusExclusionEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDelete**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriesfromfromiptotoipdelete) | **DELETE** /gateway-antivirus/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGet**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriesfromfromiptotoipget) | **GET** /gateway-antivirus/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatch**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriesfromfromiptotoippatch) | **PATCH** /gateway-antivirus/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPut**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriesfromfromiptotoipput) | **PUT** /gateway-antivirus/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**GatewayAntivirusExclusionListEntriesGet**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriesget) | **GET** /gateway-antivirus/exclusion-list/entries |  |
| [**GatewayAntivirusExclusionListEntriesPatch**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriespatch) | **PATCH** /gateway-antivirus/exclusion-list/entries |  |
| [**GatewayAntivirusExclusionListEntriesPost**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriespost) | **POST** /gateway-antivirus/exclusion-list/entries |  |
| [**GatewayAntivirusExclusionListEntriesPut**](GatewayAntivirusExclusionEntryApi.md#gatewayantivirusexclusionlistentriesput) | **PUT** /gateway-antivirus/exclusion-list/entries |  |

<a id="gatewayantivirusexclusionlistentriesfromfromiptotoipdelete"></a>
# **GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDelete**
> ApiStatus GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDelete (string FROMIP, string TOIP)



Delete a gateway antivirus exclusion entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDelete(FROMIP, TOIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo(FROMIP, TOIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |

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

<a id="gatewayantivirusexclusionlistentriesfromfromiptotoipget"></a>
# **GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGet**
> GatewayAntivirusExclusionEntryCollection GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGet (string FROMIP, string TOIP)



Retrieve gateway antivirus exclusion entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")

            try
            {
                GatewayAntivirusExclusionEntryCollection result = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGet(FROMIP, TOIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GatewayAntivirusExclusionEntryCollection> response = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo(FROMIP, TOIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |

### Return type

[**GatewayAntivirusExclusionEntryCollection**](GatewayAntivirusExclusionEntryCollection.md)

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

<a id="gatewayantivirusexclusionlistentriesfromfromiptotoippatch"></a>
# **GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatch**
> ApiStatus GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatch (string FROMIP, string TOIP, GatewayAntivirusExclusionEntryCollection? gatewayAntivirusExclusionEntryCollection = null)



Patch gateway antivirus exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var gatewayAntivirusExclusionEntryCollection = new GatewayAntivirusExclusionEntryCollection?(); // GatewayAntivirusExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatch(FROMIP, TOIP, gatewayAntivirusExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo(FROMIP, TOIP, gatewayAntivirusExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **gatewayAntivirusExclusionEntryCollection** | [**GatewayAntivirusExclusionEntryCollection?**](GatewayAntivirusExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="gatewayantivirusexclusionlistentriesfromfromiptotoipput"></a>
# **GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPut**
> ApiStatus GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPut (string FROMIP, string TOIP, GatewayAntivirusExclusionEntryCollection? gatewayAntivirusExclusionEntryCollection = null)



Edit gateway antivirus exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. (default to "192.168.168.168")
            var gatewayAntivirusExclusionEntryCollection = new GatewayAntivirusExclusionEntryCollection?(); // GatewayAntivirusExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPut(FROMIP, TOIP, gatewayAntivirusExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo(FROMIP, TOIP, gatewayAntivirusExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | Gateway AV Exclusion List entry begin IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | Gateway AV Exclusion List entry end IPv4 in the form: D.D.D.D. | [default to &quot;192.168.168.168&quot;] |
| **gatewayAntivirusExclusionEntryCollection** | [**GatewayAntivirusExclusionEntryCollection?**](GatewayAntivirusExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="gatewayantivirusexclusionlistentriesget"></a>
# **GatewayAntivirusExclusionListEntriesGet**
> GatewayAntivirusExclusionEntryCollection GatewayAntivirusExclusionListEntriesGet ()



Retrieve gateway antivirus exclusion entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);

            try
            {
                GatewayAntivirusExclusionEntryCollection result = apiInstance.GatewayAntivirusExclusionListEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GatewayAntivirusExclusionEntryCollection> response = apiInstance.GatewayAntivirusExclusionListEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GatewayAntivirusExclusionEntryCollection**](GatewayAntivirusExclusionEntryCollection.md)

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

<a id="gatewayantivirusexclusionlistentriespatch"></a>
# **GatewayAntivirusExclusionListEntriesPatch**
> ApiStatus GatewayAntivirusExclusionListEntriesPatch (GatewayAntivirusExclusionEntryCollection? gatewayAntivirusExclusionEntryCollection = null)



Patch gateway antivirus exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var gatewayAntivirusExclusionEntryCollection = new GatewayAntivirusExclusionEntryCollection?(); // GatewayAntivirusExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusExclusionListEntriesPatch(gatewayAntivirusExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusExclusionListEntriesPatchWithHttpInfo(gatewayAntivirusExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayAntivirusExclusionEntryCollection** | [**GatewayAntivirusExclusionEntryCollection?**](GatewayAntivirusExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="gatewayantivirusexclusionlistentriespost"></a>
# **GatewayAntivirusExclusionListEntriesPost**
> ApiStatus GatewayAntivirusExclusionListEntriesPost (GatewayAntivirusExclusionEntryCollection? gatewayAntivirusExclusionEntryCollection = null)



Create a new gateway antivirus exclusion entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var gatewayAntivirusExclusionEntryCollection = new GatewayAntivirusExclusionEntryCollection?(); // GatewayAntivirusExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusExclusionListEntriesPost(gatewayAntivirusExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusExclusionListEntriesPostWithHttpInfo(gatewayAntivirusExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayAntivirusExclusionEntryCollection** | [**GatewayAntivirusExclusionEntryCollection?**](GatewayAntivirusExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="gatewayantivirusexclusionlistentriesput"></a>
# **GatewayAntivirusExclusionListEntriesPut**
> ApiStatus GatewayAntivirusExclusionListEntriesPut (GatewayAntivirusExclusionEntryCollection? gatewayAntivirusExclusionEntryCollection = null)



Edit gateway antivirus exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GatewayAntivirusExclusionListEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GatewayAntivirusExclusionEntryApi(config);
            var gatewayAntivirusExclusionEntryCollection = new GatewayAntivirusExclusionEntryCollection?(); // GatewayAntivirusExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GatewayAntivirusExclusionListEntriesPut(gatewayAntivirusExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GatewayAntivirusExclusionListEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GatewayAntivirusExclusionListEntriesPutWithHttpInfo(gatewayAntivirusExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GatewayAntivirusExclusionEntryApi.GatewayAntivirusExclusionListEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayAntivirusExclusionEntryCollection** | [**GatewayAntivirusExclusionEntryCollection?**](GatewayAntivirusExclusionEntryCollection?.md) |  | [optional]  |

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

