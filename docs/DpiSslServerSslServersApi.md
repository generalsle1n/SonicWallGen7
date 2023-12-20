# SonicWallGen7.Api.DpiSslServerSslServersApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DpiSslServerSslServersGet**](DpiSslServerSslServersApi.md#dpisslserversslserversget) | **GET** /dpi-ssl/server/ssl-servers |  |
| [**DpiSslServerSslServersNameSSLSERVERDelete**](DpiSslServerSslServersApi.md#dpisslserversslserversnamesslserverdelete) | **DELETE** /dpi-ssl/server/ssl-servers/name/{SSLSERVER} |  |
| [**DpiSslServerSslServersNameSSLSERVERGet**](DpiSslServerSslServersApi.md#dpisslserversslserversnamesslserverget) | **GET** /dpi-ssl/server/ssl-servers/name/{SSLSERVER} |  |
| [**DpiSslServerSslServersPost**](DpiSslServerSslServersApi.md#dpisslserversslserverspost) | **POST** /dpi-ssl/server/ssl-servers |  |

<a id="dpisslserversslserversget"></a>
# **DpiSslServerSslServersGet**
> DpiSslServerSslServersCollection DpiSslServerSslServersGet ()



Retrieve DPI-SSL server SSL servers settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslServerSslServersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslServerSslServersApi(config);

            try
            {
                DpiSslServerSslServersCollection result = apiInstance.DpiSslServerSslServersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslServerSslServersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DpiSslServerSslServersCollection> response = apiInstance.DpiSslServerSslServersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DpiSslServerSslServersCollection**](DpiSslServerSslServersCollection.md)

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

<a id="dpisslserversslserversnamesslserverdelete"></a>
# **DpiSslServerSslServersNameSSLSERVERDelete**
> ApiStatus DpiSslServerSslServersNameSSLSERVERDelete (string SSLSERVER)



Delete a DPI-SSL SSL server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslServerSslServersNameSSLSERVERDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslServerSslServersApi(config);
            var SSLSERVER = "\"DPI-SSL Server Name\"";  // string | SSL server name. (default to "DPI-SSL Server Name")

            try
            {
                ApiStatus result = apiInstance.DpiSslServerSslServersNameSSLSERVERDelete(SSLSERVER);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersNameSSLSERVERDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslServerSslServersNameSSLSERVERDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DpiSslServerSslServersNameSSLSERVERDeleteWithHttpInfo(SSLSERVER);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersNameSSLSERVERDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SSLSERVER** | **string** | SSL server name. | [default to &quot;DPI-SSL Server Name&quot;] |

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

<a id="dpisslserversslserversnamesslserverget"></a>
# **DpiSslServerSslServersNameSSLSERVERGet**
> DpiSslServerSslServersCollection DpiSslServerSslServersNameSSLSERVERGet (string SSLSERVER)



Retrieve DPI-SSL server SSL servers settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslServerSslServersNameSSLSERVERGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslServerSslServersApi(config);
            var SSLSERVER = "\"DPI-SSL Server Name\"";  // string | SSL server name. (default to "DPI-SSL Server Name")

            try
            {
                DpiSslServerSslServersCollection result = apiInstance.DpiSslServerSslServersNameSSLSERVERGet(SSLSERVER);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersNameSSLSERVERGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslServerSslServersNameSSLSERVERGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DpiSslServerSslServersCollection> response = apiInstance.DpiSslServerSslServersNameSSLSERVERGetWithHttpInfo(SSLSERVER);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersNameSSLSERVERGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **SSLSERVER** | **string** | SSL server name. | [default to &quot;DPI-SSL Server Name&quot;] |

### Return type

[**DpiSslServerSslServersCollection**](DpiSslServerSslServersCollection.md)

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

<a id="dpisslserversslserverspost"></a>
# **DpiSslServerSslServersPost**
> ApiStatus DpiSslServerSslServersPost (DpiSslServerSslServersCollection? dpiSslServerSslServersCollection = null)



Add a DPI-SSL SSL server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class DpiSslServerSslServersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DpiSslServerSslServersApi(config);
            var dpiSslServerSslServersCollection = new DpiSslServerSslServersCollection?(); // DpiSslServerSslServersCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.DpiSslServerSslServersPost(dpiSslServerSslServersCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DpiSslServerSslServersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.DpiSslServerSslServersPostWithHttpInfo(dpiSslServerSslServersCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DpiSslServerSslServersApi.DpiSslServerSslServersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dpiSslServerSslServersCollection** | [**DpiSslServerSslServersCollection?**](DpiSslServerSslServersCollection?.md) |  | [optional]  |

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

