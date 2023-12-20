# SonicWallGen7.Api.MacIpAntiSpoofIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MacIpAntiSpoofIpv4InterfacesGet**](MacIpAntiSpoofIpv4Api.md#macipantispoofipv4interfacesget) | **GET** /mac-ip-anti-spoof/ipv4/interfaces |  |
| [**MacIpAntiSpoofIpv4InterfacesNameNAMEGet**](MacIpAntiSpoofIpv4Api.md#macipantispoofipv4interfacesnamenameget) | **GET** /mac-ip-anti-spoof/ipv4/interfaces/name/{NAME} |  |
| [**MacIpAntiSpoofIpv4InterfacesNameNAMEPut**](MacIpAntiSpoofIpv4Api.md#macipantispoofipv4interfacesnamenameput) | **PUT** /mac-ip-anti-spoof/ipv4/interfaces/name/{NAME} |  |
| [**MacIpAntiSpoofIpv4InterfacesPut**](MacIpAntiSpoofIpv4Api.md#macipantispoofipv4interfacesput) | **PUT** /mac-ip-anti-spoof/ipv4/interfaces |  |

<a id="macipantispoofipv4interfacesget"></a>
# **MacIpAntiSpoofIpv4InterfacesGet**
> MacIpAntiSpoofIpv4Collection MacIpAntiSpoofIpv4InterfacesGet ()



Retrieve MAC IP anti spoof IPv4 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4InterfacesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv4Api(config);

            try
            {
                MacIpAntiSpoofIpv4Collection result = apiInstance.MacIpAntiSpoofIpv4InterfacesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4InterfacesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofIpv4Collection> response = apiInstance.MacIpAntiSpoofIpv4InterfacesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MacIpAntiSpoofIpv4Collection**](MacIpAntiSpoofIpv4Collection.md)

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

<a id="macipantispoofipv4interfacesnamenameget"></a>
# **MacIpAntiSpoofIpv4InterfacesNameNAMEGet**
> MacIpAntiSpoofIpv4Collection MacIpAntiSpoofIpv4InterfacesNameNAMEGet (string NAME)



Retrieve MAC IP anti spoof IPv4 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4InterfacesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv4Api(config);
            var NAME = "\"X0\"";  // string | MAC-IP anti-spoof interface. (default to "X0")

            try
            {
                MacIpAntiSpoofIpv4Collection result = apiInstance.MacIpAntiSpoofIpv4InterfacesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4InterfacesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MacIpAntiSpoofIpv4Collection> response = apiInstance.MacIpAntiSpoofIpv4InterfacesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | MAC-IP anti-spoof interface. | [default to &quot;X0&quot;] |

### Return type

[**MacIpAntiSpoofIpv4Collection**](MacIpAntiSpoofIpv4Collection.md)

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

<a id="macipantispoofipv4interfacesnamenameput"></a>
# **MacIpAntiSpoofIpv4InterfacesNameNAMEPut**
> ApiStatus MacIpAntiSpoofIpv4InterfacesNameNAMEPut (string NAME, MacIpAntiSpoofIpv4Collection? macIpAntiSpoofIpv4Collection = null)



Edit MAC IP anti spoof IPv4 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4InterfacesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv4Api(config);
            var NAME = "\"X0\"";  // string | MAC-IP anti-spoof interface. (default to "X0")
            var macIpAntiSpoofIpv4Collection = new MacIpAntiSpoofIpv4Collection?(); // MacIpAntiSpoofIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4InterfacesNameNAMEPut(NAME, macIpAntiSpoofIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4InterfacesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4InterfacesNameNAMEPutWithHttpInfo(NAME, macIpAntiSpoofIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | MAC-IP anti-spoof interface. | [default to &quot;X0&quot;] |
| **macIpAntiSpoofIpv4Collection** | [**MacIpAntiSpoofIpv4Collection?**](MacIpAntiSpoofIpv4Collection?.md) |  | [optional]  |

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

<a id="macipantispoofipv4interfacesput"></a>
# **MacIpAntiSpoofIpv4InterfacesPut**
> ApiStatus MacIpAntiSpoofIpv4InterfacesPut (MacIpAntiSpoofIpv4Collection? macIpAntiSpoofIpv4Collection = null)



Edit MAC IP anti spoof IPv4 interface object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class MacIpAntiSpoofIpv4InterfacesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MacIpAntiSpoofIpv4Api(config);
            var macIpAntiSpoofIpv4Collection = new MacIpAntiSpoofIpv4Collection?(); // MacIpAntiSpoofIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.MacIpAntiSpoofIpv4InterfacesPut(macIpAntiSpoofIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MacIpAntiSpoofIpv4InterfacesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.MacIpAntiSpoofIpv4InterfacesPutWithHttpInfo(macIpAntiSpoofIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MacIpAntiSpoofIpv4Api.MacIpAntiSpoofIpv4InterfacesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **macIpAntiSpoofIpv4Collection** | [**MacIpAntiSpoofIpv4Collection?**](MacIpAntiSpoofIpv4Collection?.md) |  | [optional]  |

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

