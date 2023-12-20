# SonicWallGen7.Api.CaptureAtpCheckMd5QueryStatusApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPost**](CaptureAtpCheckMd5QueryStatusApi.md#captureatpcheckmd5querystatusmd5querycontentpost) | **POST** /capture-atp/check/md5-query-status/{MD5QUERYCONTENT} |  |

<a id="captureatpcheckmd5querystatusmd5querycontentpost"></a>
# **CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPost**
> ApiStatus CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPost (string mD5QUERYCONTENT, Object? body = null)



Check MD5 query status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CaptureAtpCheckMd5QueryStatusApi(config);
            var mD5QUERYCONTENT = "\"11223344556677889900aabbccddeeff\"";  // string | MD5 exclusion entry in 32 hexadecimal digits. (default to "11223344556677889900aabbccddeeff")
            var body = null;  // Object? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPost(mD5QUERYCONTENT, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureAtpCheckMd5QueryStatusApi.CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPostWithHttpInfo(mD5QUERYCONTENT, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureAtpCheckMd5QueryStatusApi.CaptureAtpCheckMd5QueryStatusMD5QUERYCONTENTPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mD5QUERYCONTENT** | **string** | MD5 exclusion entry in 32 hexadecimal digits. | [default to &quot;11223344556677889900aabbccddeeff&quot;] |
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

