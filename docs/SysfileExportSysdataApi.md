# SonicWallGen7.Api.SysfileExportSysdataApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportSysfileSysdataTxtNAMEGet**](SysfileExportSysdataApi.md#exportsysfilesysdatatxtnameget) | **GET** /export/sysfile/sysdata/txt/{NAME} |  |

<a id="exportsysfilesysdatatxtnameget"></a>
# **ExportSysfileSysdataTxtNAMEGet**
> Object ExportSysfileSysdataTxtNAMEGet (string NAME)



export sysdata files.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class ExportSysfileSysdataTxtNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SysfileExportSysdataApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                Object result = apiInstance.ExportSysfileSysdataTxtNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SysfileExportSysdataApi.ExportSysfileSysdataTxtNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportSysfileSysdataTxtNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ExportSysfileSysdataTxtNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SysfileExportSysdataApi.ExportSysfileSysdataTxtNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

**Object**

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

