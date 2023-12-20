# SonicWallGen7.Api.GeoIpAddressesApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GeoIpAddressesGet**](GeoIpAddressesApi.md#geoipaddressesget) | **GET** /geo-ip/addresses |  |
| [**GeoIpAddressesGroupGRPNAMEDelete**](GeoIpAddressesApi.md#geoipaddressesgroupgrpnamedelete) | **DELETE** /geo-ip/addresses/group/{GRPNAME} |  |
| [**GeoIpAddressesGroupGRPNAMEGet**](GeoIpAddressesApi.md#geoipaddressesgroupgrpnameget) | **GET** /geo-ip/addresses/group/{GRPNAME} |  |
| [**GeoIpAddressesGroupGRPNAMEPatch**](GeoIpAddressesApi.md#geoipaddressesgroupgrpnamepatch) | **PATCH** /geo-ip/addresses/group/{GRPNAME} |  |
| [**GeoIpAddressesGroupGRPNAMEPut**](GeoIpAddressesApi.md#geoipaddressesgroupgrpnameput) | **PUT** /geo-ip/addresses/group/{GRPNAME} |  |
| [**GeoIpAddressesNameNAMEDelete**](GeoIpAddressesApi.md#geoipaddressesnamenamedelete) | **DELETE** /geo-ip/addresses/name/{NAME} |  |
| [**GeoIpAddressesNameNAMEGet**](GeoIpAddressesApi.md#geoipaddressesnamenameget) | **GET** /geo-ip/addresses/name/{NAME} |  |
| [**GeoIpAddressesNameNAMEPatch**](GeoIpAddressesApi.md#geoipaddressesnamenamepatch) | **PATCH** /geo-ip/addresses/name/{NAME} |  |
| [**GeoIpAddressesNameNAMEPut**](GeoIpAddressesApi.md#geoipaddressesnamenameput) | **PUT** /geo-ip/addresses/name/{NAME} |  |
| [**GeoIpAddressesPatch**](GeoIpAddressesApi.md#geoipaddressespatch) | **PATCH** /geo-ip/addresses |  |
| [**GeoIpAddressesPost**](GeoIpAddressesApi.md#geoipaddressespost) | **POST** /geo-ip/addresses |  |
| [**GeoIpAddressesPut**](GeoIpAddressesApi.md#geoipaddressesput) | **PUT** /geo-ip/addresses |  |

<a id="geoipaddressesget"></a>
# **GeoIpAddressesGet**
> GeoIpAddressesCollection GeoIpAddressesGet ()



Retrieve address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);

            try
            {
                GeoIpAddressesCollection result = apiInstance.GeoIpAddressesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GeoIpAddressesCollection> response = apiInstance.GeoIpAddressesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GeoIpAddressesCollection**](GeoIpAddressesCollection.md)

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

<a id="geoipaddressesgroupgrpnamedelete"></a>
# **GeoIpAddressesGroupGRPNAMEDelete**
> ApiStatus GeoIpAddressesGroupGRPNAMEDelete (string GRPNAME)



Delete address objects in the custom Geo-IP list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesGroupGRPNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var GRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesGroupGRPNAMEDelete(GRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesGroupGRPNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesGroupGRPNAMEDeleteWithHttpInfo(GRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

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

<a id="geoipaddressesgroupgrpnameget"></a>
# **GeoIpAddressesGroupGRPNAMEGet**
> GeoIpAddressesCollection GeoIpAddressesGroupGRPNAMEGet (string GRPNAME)



Retrieve address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesGroupGRPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var GRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")

            try
            {
                GeoIpAddressesCollection result = apiInstance.GeoIpAddressesGroupGRPNAMEGet(GRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesGroupGRPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GeoIpAddressesCollection> response = apiInstance.GeoIpAddressesGroupGRPNAMEGetWithHttpInfo(GRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |

### Return type

[**GeoIpAddressesCollection**](GeoIpAddressesCollection.md)

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

<a id="geoipaddressesgroupgrpnamepatch"></a>
# **GeoIpAddressesGroupGRPNAMEPatch**
> ApiStatus GeoIpAddressesGroupGRPNAMEPatch (string GRPNAME, GeoIpAddressesCollection? geoIpAddressesCollection = null)



Patch address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesGroupGRPNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var GRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesGroupGRPNAMEPatch(GRPNAME, geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesGroupGRPNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesGroupGRPNAMEPatchWithHttpInfo(GRPNAME, geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

<a id="geoipaddressesgroupgrpnameput"></a>
# **GeoIpAddressesGroupGRPNAMEPut**
> ApiStatus GeoIpAddressesGroupGRPNAMEPut (string GRPNAME, GeoIpAddressesCollection? geoIpAddressesCollection = null)



Update address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesGroupGRPNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var GRPNAME = "\"Sales Group\"";  // string | Group address object name. (default to "Sales Group")
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesGroupGRPNAMEPut(GRPNAME, geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesGroupGRPNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesGroupGRPNAMEPutWithHttpInfo(GRPNAME, geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesGroupGRPNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Group address object name. | [default to &quot;Sales Group&quot;] |
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

<a id="geoipaddressesnamenamedelete"></a>
# **GeoIpAddressesNameNAMEDelete**
> ApiStatus GeoIpAddressesNameNAMEDelete (string NAME)



Delete address objects in the custom Geo-IP list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var NAME = "\"Web Server\"";  // string | Address object name. (default to "Web Server")

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Address object name. | [default to &quot;Web Server&quot;] |

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

<a id="geoipaddressesnamenameget"></a>
# **GeoIpAddressesNameNAMEGet**
> GeoIpAddressesCollection GeoIpAddressesNameNAMEGet (string NAME)



Retrieve address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var NAME = "\"Web Server\"";  // string | Address object name. (default to "Web Server")

            try
            {
                GeoIpAddressesCollection result = apiInstance.GeoIpAddressesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GeoIpAddressesCollection> response = apiInstance.GeoIpAddressesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Address object name. | [default to &quot;Web Server&quot;] |

### Return type

[**GeoIpAddressesCollection**](GeoIpAddressesCollection.md)

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

<a id="geoipaddressesnamenamepatch"></a>
# **GeoIpAddressesNameNAMEPatch**
> ApiStatus GeoIpAddressesNameNAMEPatch (string NAME, GeoIpAddressesCollection? geoIpAddressesCollection = null)



Patch address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var NAME = "\"Web Server\"";  // string | Address object name. (default to "Web Server")
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesNameNAMEPatch(NAME, geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesNameNAMEPatchWithHttpInfo(NAME, geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Address object name. | [default to &quot;Web Server&quot;] |
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

<a id="geoipaddressesnamenameput"></a>
# **GeoIpAddressesNameNAMEPut**
> ApiStatus GeoIpAddressesNameNAMEPut (string NAME, GeoIpAddressesCollection? geoIpAddressesCollection = null)



Update address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var NAME = "\"Web Server\"";  // string | Address object name. (default to "Web Server")
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesNameNAMEPut(NAME, geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesNameNAMEPutWithHttpInfo(NAME, geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Address object name. | [default to &quot;Web Server&quot;] |
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

<a id="geoipaddressespatch"></a>
# **GeoIpAddressesPatch**
> ApiStatus GeoIpAddressesPatch (GeoIpAddressesCollection? geoIpAddressesCollection = null)



Patch address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesPatch(geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesPatchWithHttpInfo(geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

<a id="geoipaddressespost"></a>
# **GeoIpAddressesPost**
> ApiStatus GeoIpAddressesPost (GeoIpAddressesCollection? geoIpAddressesCollection = null)



Add address objects in the custom Geo-IP list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesPost(geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesPostWithHttpInfo(geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

<a id="geoipaddressesput"></a>
# **GeoIpAddressesPut**
> ApiStatus GeoIpAddressesPut (GeoIpAddressesCollection? geoIpAddressesCollection = null)



Update address objects in the custom Geo-IP list configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class GeoIpAddressesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GeoIpAddressesApi(config);
            var geoIpAddressesCollection = new GeoIpAddressesCollection?(); // GeoIpAddressesCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.GeoIpAddressesPut(geoIpAddressesCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoIpAddressesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.GeoIpAddressesPutWithHttpInfo(geoIpAddressesCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoIpAddressesApi.GeoIpAddressesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **geoIpAddressesCollection** | [**GeoIpAddressesCollection?**](GeoIpAddressesCollection?.md) |  | [optional]  |

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

