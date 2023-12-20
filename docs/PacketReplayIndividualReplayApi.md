# SonicWallGen7.Api.PacketReplayIndividualReplayApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PacketReplayIndividualReplayActionValPost**](PacketReplayIndividualReplayApi.md#packetreplayindividualreplayactionvalpost) | **POST** /packet-replay/individual-replay/action-val |  |

<a id="packetreplayindividualreplayactionvalpost"></a>
# **PacketReplayIndividualReplayActionValPost**
> ApiStatus PacketReplayIndividualReplayActionValPost (PacketReplayIndividualReplay? packetReplayIndividualReplay = null)



Update packet replay configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class PacketReplayIndividualReplayActionValPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PacketReplayIndividualReplayApi(config);
            var packetReplayIndividualReplay = new PacketReplayIndividualReplay?(); // PacketReplayIndividualReplay? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.PacketReplayIndividualReplayActionValPost(packetReplayIndividualReplay);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PacketReplayIndividualReplayApi.PacketReplayIndividualReplayActionValPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PacketReplayIndividualReplayActionValPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.PacketReplayIndividualReplayActionValPostWithHttpInfo(packetReplayIndividualReplay);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PacketReplayIndividualReplayApi.PacketReplayIndividualReplayActionValPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packetReplayIndividualReplay** | [**PacketReplayIndividualReplay?**](PacketReplayIndividualReplay?.md) |  | [optional]  |

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

