# SonicWallGen7.Api.HaMonitoringIpv6Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HighAvailabilityMonitoringIpv6Get**](HaMonitoringIpv6Api.md#highavailabilitymonitoringipv6get) | **GET** /high-availability/monitoring/ipv6 |  |
| [**HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGet**](HaMonitoringIpv6Api.md#highavailabilitymonitoringipv6interfaceinterfacenameget) | **GET** /high-availability/monitoring/ipv6/interface/{INTERFACENAME} |  |
| [**HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPut**](HaMonitoringIpv6Api.md#highavailabilitymonitoringipv6interfaceinterfacenameput) | **PUT** /high-availability/monitoring/ipv6/interface/{INTERFACENAME} |  |
| [**HighAvailabilityMonitoringIpv6Put**](HaMonitoringIpv6Api.md#highavailabilitymonitoringipv6put) | **PUT** /high-availability/monitoring/ipv6 |  |

<a id="highavailabilitymonitoringipv6get"></a>
# **HighAvailabilityMonitoringIpv6Get**
> HaMonitoringIpv6Collection HighAvailabilityMonitoringIpv6Get ()



Retrieve high availability monitoring configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class HighAvailabilityMonitoringIpv6GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv6Api(config);

            try
            {
                HaMonitoringIpv6Collection result = apiInstance.HighAvailabilityMonitoringIpv6Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv6GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HaMonitoringIpv6Collection> response = apiInstance.HighAvailabilityMonitoringIpv6GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HaMonitoringIpv6Collection**](HaMonitoringIpv6Collection.md)

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

<a id="highavailabilitymonitoringipv6interfaceinterfacenameget"></a>
# **HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGet**
> HaMonitoringIpv6Collection HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGet (string INTERFACENAME)



Retrieve high availability monitoring configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv6Api(config);
            var INTERFACENAME = "\"X0\"";  // string | HA monitoring interface name. (default to "X0")

            try
            {
                HaMonitoringIpv6Collection result = apiInstance.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGet(INTERFACENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HaMonitoringIpv6Collection> response = apiInstance.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGetWithHttpInfo(INTERFACENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INTERFACENAME** | **string** | HA monitoring interface name. | [default to &quot;X0&quot;] |

### Return type

[**HaMonitoringIpv6Collection**](HaMonitoringIpv6Collection.md)

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

<a id="highavailabilitymonitoringipv6interfaceinterfacenameput"></a>
# **HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPut**
> ApiStatus HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPut (string INTERFACENAME, HaMonitoringIpv6Collection? haMonitoringIpv6Collection = null)



Update high availability monitoring configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv6Api(config);
            var INTERFACENAME = "\"X0\"";  // string | HA monitoring interface name. (default to "X0")
            var haMonitoringIpv6Collection = new HaMonitoringIpv6Collection?(); // HaMonitoringIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPut(INTERFACENAME, haMonitoringIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPutWithHttpInfo(INTERFACENAME, haMonitoringIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6InterfaceINTERFACENAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INTERFACENAME** | **string** | HA monitoring interface name. | [default to &quot;X0&quot;] |
| **haMonitoringIpv6Collection** | [**HaMonitoringIpv6Collection?**](HaMonitoringIpv6Collection?.md) |  | [optional]  |

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

<a id="highavailabilitymonitoringipv6put"></a>
# **HighAvailabilityMonitoringIpv6Put**
> ApiStatus HighAvailabilityMonitoringIpv6Put (HaMonitoringIpv6Collection? haMonitoringIpv6Collection = null)



Update high availability monitoring configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class HighAvailabilityMonitoringIpv6PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv6Api(config);
            var haMonitoringIpv6Collection = new HaMonitoringIpv6Collection?(); // HaMonitoringIpv6Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.HighAvailabilityMonitoringIpv6Put(haMonitoringIpv6Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv6PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.HighAvailabilityMonitoringIpv6PutWithHttpInfo(haMonitoringIpv6Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv6Api.HighAvailabilityMonitoringIpv6PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **haMonitoringIpv6Collection** | [**HaMonitoringIpv6Collection?**](HaMonitoringIpv6Collection?.md) |  | [optional]  |

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

