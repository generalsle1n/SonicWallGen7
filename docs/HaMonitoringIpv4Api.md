# SonicWallGen7.Api.HaMonitoringIpv4Api

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HighAvailabilityMonitoringIpv4Get**](HaMonitoringIpv4Api.md#highavailabilitymonitoringipv4get) | **GET** /high-availability/monitoring/ipv4 |  |
| [**HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGet**](HaMonitoringIpv4Api.md#highavailabilitymonitoringipv4interfaceinterfacenameget) | **GET** /high-availability/monitoring/ipv4/interface/{INTERFACENAME} |  |
| [**HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPut**](HaMonitoringIpv4Api.md#highavailabilitymonitoringipv4interfaceinterfacenameput) | **PUT** /high-availability/monitoring/ipv4/interface/{INTERFACENAME} |  |
| [**HighAvailabilityMonitoringIpv4Put**](HaMonitoringIpv4Api.md#highavailabilitymonitoringipv4put) | **PUT** /high-availability/monitoring/ipv4 |  |

<a id="highavailabilitymonitoringipv4get"></a>
# **HighAvailabilityMonitoringIpv4Get**
> HaMonitoringIpv4Collection HighAvailabilityMonitoringIpv4Get ()



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
    public class HighAvailabilityMonitoringIpv4GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv4Api(config);

            try
            {
                HaMonitoringIpv4Collection result = apiInstance.HighAvailabilityMonitoringIpv4Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv4GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HaMonitoringIpv4Collection> response = apiInstance.HighAvailabilityMonitoringIpv4GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HaMonitoringIpv4Collection**](HaMonitoringIpv4Collection.md)

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

<a id="highavailabilitymonitoringipv4interfaceinterfacenameget"></a>
# **HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGet**
> HaMonitoringIpv4Collection HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGet (string INTERFACENAME)



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
    public class HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv4Api(config);
            var INTERFACENAME = "\"X0\"";  // string | HA monitoring interface name. (default to "X0")

            try
            {
                HaMonitoringIpv4Collection result = apiInstance.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGet(INTERFACENAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HaMonitoringIpv4Collection> response = apiInstance.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGetWithHttpInfo(INTERFACENAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INTERFACENAME** | **string** | HA monitoring interface name. | [default to &quot;X0&quot;] |

### Return type

[**HaMonitoringIpv4Collection**](HaMonitoringIpv4Collection.md)

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

<a id="highavailabilitymonitoringipv4interfaceinterfacenameput"></a>
# **HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPut**
> ApiStatus HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPut (string INTERFACENAME, HaMonitoringIpv4Collection? haMonitoringIpv4Collection = null)



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
    public class HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv4Api(config);
            var INTERFACENAME = "\"X0\"";  // string | HA monitoring interface name. (default to "X0")
            var haMonitoringIpv4Collection = new HaMonitoringIpv4Collection?(); // HaMonitoringIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPut(INTERFACENAME, haMonitoringIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPutWithHttpInfo(INTERFACENAME, haMonitoringIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4InterfaceINTERFACENAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **INTERFACENAME** | **string** | HA monitoring interface name. | [default to &quot;X0&quot;] |
| **haMonitoringIpv4Collection** | [**HaMonitoringIpv4Collection?**](HaMonitoringIpv4Collection?.md) |  | [optional]  |

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

<a id="highavailabilitymonitoringipv4put"></a>
# **HighAvailabilityMonitoringIpv4Put**
> ApiStatus HighAvailabilityMonitoringIpv4Put (HaMonitoringIpv4Collection? haMonitoringIpv4Collection = null)



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
    public class HighAvailabilityMonitoringIpv4PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HaMonitoringIpv4Api(config);
            var haMonitoringIpv4Collection = new HaMonitoringIpv4Collection?(); // HaMonitoringIpv4Collection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.HighAvailabilityMonitoringIpv4Put(haMonitoringIpv4Collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HighAvailabilityMonitoringIpv4PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.HighAvailabilityMonitoringIpv4PutWithHttpInfo(haMonitoringIpv4Collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HaMonitoringIpv4Api.HighAvailabilityMonitoringIpv4PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **haMonitoringIpv4Collection** | [**HaMonitoringIpv4Collection?**](HaMonitoringIpv4Collection?.md) |  | [optional]  |

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

