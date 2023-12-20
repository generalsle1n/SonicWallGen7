# SonicWallGen7.Api.SshServerKillSessionApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SshServerKillSessionsIpIPPortPORTPost**](SshServerKillSessionApi.md#sshserverkillsessionsipipportportpost) | **POST** /ssh/server/kill/sessions/ip/{IP}/port/{PORT} |  |
| [**SshServerKillSessionsPost**](SshServerKillSessionApi.md#sshserverkillsessionspost) | **POST** /ssh/server/kill/sessions |  |

<a id="sshserverkillsessionsipipportportpost"></a>
# **SshServerKillSessionsIpIPPortPORTPost**
> ApiStatus SshServerKillSessionsIpIPPortPORTPost (string IP, decimal PORT, Object? body = null)



Terminate specified SSH session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SshServerKillSessionsIpIPPortPORTPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SshServerKillSessionApi(config);
            var IP = "\"2001:cdba:0000:0000:0000:0000:3257:9652\"";  // string | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  (default to "2001:cdba:0000:0000:0000:0000:3257:9652")
            var PORT = 8.14D;  // decimal | Integer in the form: D OR 0xHHHH
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SshServerKillSessionsIpIPPortPORTPost(IP, PORT, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SshServerKillSessionApi.SshServerKillSessionsIpIPPortPORTPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SshServerKillSessionsIpIPPortPORTPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SshServerKillSessionsIpIPPortPORTPostWithHttpInfo(IP, PORT, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SshServerKillSessionApi.SshServerKillSessionsIpIPPortPORTPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **IP** | **string** | IPV4: address in the form: D.D.D.D IPV6: address in the form: HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH:HHHH  | [default to &quot;2001:cdba:0000:0000:0000:0000:3257:9652&quot;] |
| **PORT** | **decimal** | Integer in the form: D OR 0xHHHH |  |
| **body** | **Object?** |  | [optional]  |

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

<a id="sshserverkillsessionspost"></a>
# **SshServerKillSessionsPost**
> ApiStatus SshServerKillSessionsPost (Object? body = null)



Terminate specified SSH session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class SshServerKillSessionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SshServerKillSessionApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.SshServerKillSessionsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SshServerKillSessionApi.SshServerKillSessionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SshServerKillSessionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.SshServerKillSessionsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SshServerKillSessionApi.SshServerKillSessionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

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

