# SonicWallGen7.Api.MacIpAntiSpoofIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MacIpAntiSpoofIpv6InterfacesGet**](MacIpAntiSpoofIpv6Api.md#macipantispoofipv6interfacesget) | **GET** /mac-ip-anti-spoof/ipv6/interfaces |  |
| [**MacIpAntiSpoofIpv6InterfacesNameNAMEGet**](MacIpAntiSpoofIpv6Api.md#macipantispoofipv6interfacesnamenameget) | **GET** /mac-ip-anti-spoof/ipv6/interfaces/name/{NAME} |  |
| [**MacIpAntiSpoofIpv6InterfacesNameNAMEPut**](MacIpAntiSpoofIpv6Api.md#macipantispoofipv6interfacesnamenameput) | **PUT** /mac-ip-anti-spoof/ipv6/interfaces/name/{NAME} |  |
| [**MacIpAntiSpoofIpv6InterfacesPut**](MacIpAntiSpoofIpv6Api.md#macipantispoofipv6interfacesput) | **PUT** /mac-ip-anti-spoof/ipv6/interfaces |  |

<a id="macipantispoofipv6interfacesget"></a>
# **MacIpAntiSpoofIpv6InterfacesGet**
> MacIpAntiSpoofIpv6Collection MacIpAntiSpoofIpv6InterfacesGet ()



Retrieve MAC IP anti spoof IPv6 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6InterfacesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv6Api(config);

            try
            {
                MacIpAntiSpoofIpv6Collection result = apiInstance.MacIpAntiSpoofIpv6InterfacesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6InterfacesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofIpv6Collection> response = apiInstance.MacIpAntiSpoofIpv6InterfacesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MacIpAntiSpoofIpv6Collection**](MacIpAntiSpoofIpv6Collection.md)

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

<a id="macipantispoofipv6interfacesnamenameget"></a>
# **MacIpAntiSpoofIpv6InterfacesNameNAMEGet**
> MacIpAntiSpoofIpv6Collection MacIpAntiSpoofIpv6InterfacesNameNAMEGet (string NAME)



Retrieve MAC IP anti spoof IPv6 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6InterfacesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv6Api(config);
            var NAME = "\"X0\"";  // string | MAC-IP anti-spoof interface. (default to "X0")

            try
            {
                MacIpAntiSpoofIpv6Collection result = apiInstance.MacIpAntiSpoofIpv6InterfacesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6InterfacesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofIpv6Collection> response = apiInstance.MacIpAntiSpoofIpv6InterfacesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | MAC-IP anti-spoof interface. | [default to &quot;X0&quot;] |

### Return type

[**MacIpAntiSpoofIpv6Collection**](MacIpAntiSpoofIpv6Collection.md)

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

<a id="macipantispoofipv6interfacesnamenameput"></a>
# **MacIpAntiSpoofIpv6InterfacesNameNAMEPut**
> ApiStatus MacIpAntiSpoofIpv6InterfacesNameNAMEPut (string NAME, MacIpAntiSpoofIpv6Collection? macIpAntiSpoofIpv6Collection = null)



Edit MAC IP anti spoof IPv6 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6InterfacesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv6Api(config);
            var NAME = "\"X0\"";  // string | MAC-IP anti-spoof interface. (default to "X0")
            var macIpAntiSpoofIpv6Collection = new MacIpAntiSpoofIpv6Collection?(); // MacIpAntiSpoofIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6InterfacesNameNAMEPut(NAME, macIpAntiSpoofIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6InterfacesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6InterfacesNameNAMEPutWithHttpInfo(NAME, macIpAntiSpoofIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | MAC-IP anti-spoof interface. | [default to &quot;X0&quot;] |
| **macIpAntiSpoofIpv6Collection** | [**MacIpAntiSpoofIpv6Collection?**](MacIpAntiSpoofIpv6Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv6interfacesput"></a>
# **MacIpAntiSpoofIpv6InterfacesPut**
> ApiStatus MacIpAntiSpoofIpv6InterfacesPut (MacIpAntiSpoofIpv6Collection? macIpAntiSpoofIpv6Collection = null)



Edit MAC IP anti spoof IPv6 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv6InterfacesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv6Api(config);
            var macIpAntiSpoofIpv6Collection = new MacIpAntiSpoofIpv6Collection?(); // MacIpAntiSpoofIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv6InterfacesPut(macIpAntiSpoofIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv6InterfacesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv6InterfacesPutWithHttpInfo(macIpAntiSpoofIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv6Api.MacIpAntiSpoofIpv6InterfacesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofIpv6Collection** | [**MacIpAntiSpoofIpv6Collection?**](MacIpAntiSpoofIpv6Collection?.md) |  | [optional]  |

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

