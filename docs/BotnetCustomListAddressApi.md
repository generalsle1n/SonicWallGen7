# SonicWallGen7.Api.BotnetCustomListAddressApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BotnetCustomListAddressesGet**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesget) | **GET** /botnet/custom-list-addresses |  |
| [**BotnetCustomListAddressesGroupGRPNAMEDelete**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesgroupgrpnamedelete) | **DELETE** /botnet/custom-list-addresses/group/{GRPNAME} |  |
| [**BotnetCustomListAddressesGroupGRPNAMEGet**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesgroupgrpnameget) | **GET** /botnet/custom-list-addresses/group/{GRPNAME} |  |
| [**BotnetCustomListAddressesGroupGRPNAMEPatch**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesgroupgrpnamepatch) | **PATCH** /botnet/custom-list-addresses/group/{GRPNAME} |  |
| [**BotnetCustomListAddressesGroupGRPNAMEPut**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesgroupgrpnameput) | **PUT** /botnet/custom-list-addresses/group/{GRPNAME} |  |
| [**BotnetCustomListAddressesNameNAMEDelete**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesnamenamedelete) | **DELETE** /botnet/custom-list-addresses/name/{NAME} |  |
| [**BotnetCustomListAddressesNameNAMEGet**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesnamenameget) | **GET** /botnet/custom-list-addresses/name/{NAME} |  |
| [**BotnetCustomListAddressesNameNAMEPatch**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesnamenamepatch) | **PATCH** /botnet/custom-list-addresses/name/{NAME} |  |
| [**BotnetCustomListAddressesNameNAMEPut**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesnamenameput) | **PUT** /botnet/custom-list-addresses/name/{NAME} |  |
| [**BotnetCustomListAddressesPatch**](BotnetCustomListAddressApi.md#botnetcustomlistaddressespatch) | **PATCH** /botnet/custom-list-addresses |  |
| [**BotnetCustomListAddressesPost**](BotnetCustomListAddressApi.md#botnetcustomlistaddressespost) | **POST** /botnet/custom-list-addresses |  |
| [**BotnetCustomListAddressesPut**](BotnetCustomListAddressApi.md#botnetcustomlistaddressesput) | **PUT** /botnet/custom-list-addresses |  |

<a id="botnetcustomlistaddressesget"></a>
# **BotnetCustomListAddressesGet**
> BotnetCustomListAddressCollection BotnetCustomListAddressesGet ()



Retrieve botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);

            try
            {
                BotnetCustomListAddressCollection result = apiInstance.BotnetCustomListAddressesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BotnetCustomListAddressCollection> response = apiInstance.BotnetCustomListAddressesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**BotnetCustomListAddressCollection**](BotnetCustomListAddressCollection.md)

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

<a id="botnetcustomlistaddressesgroupgrpnamedelete"></a>
# **BotnetCustomListAddressesGroupGRPNAMEDelete**
> ApiStatus BotnetCustomListAddressesGroupGRPNAMEDelete (string GRPNAME)



Delete a botnet custom list IP address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesGroupGRPNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var GRPNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesGroupGRPNAMEDelete(GRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesGroupGRPNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesGroupGRPNAMEDeleteWithHttpInfo(GRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="botnetcustomlistaddressesgroupgrpnameget"></a>
# **BotnetCustomListAddressesGroupGRPNAMEGet**
> BotnetCustomListAddressCollection BotnetCustomListAddressesGroupGRPNAMEGet (string GRPNAME)



Retrieve botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesGroupGRPNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var GRPNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                BotnetCustomListAddressCollection result = apiInstance.BotnetCustomListAddressesGroupGRPNAMEGet(GRPNAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesGroupGRPNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BotnetCustomListAddressCollection> response = apiInstance.BotnetCustomListAddressesGroupGRPNAMEGetWithHttpInfo(GRPNAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**BotnetCustomListAddressCollection**](BotnetCustomListAddressCollection.md)

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

<a id="botnetcustomlistaddressesgroupgrpnamepatch"></a>
# **BotnetCustomListAddressesGroupGRPNAMEPatch**
> ApiStatus BotnetCustomListAddressesGroupGRPNAMEPatch (string GRPNAME, BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Patch botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesGroupGRPNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var GRPNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesGroupGRPNAMEPatch(GRPNAME, botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesGroupGRPNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesGroupGRPNAMEPatchWithHttpInfo(GRPNAME, botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

<a id="botnetcustomlistaddressesgroupgrpnameput"></a>
# **BotnetCustomListAddressesGroupGRPNAMEPut**
> ApiStatus BotnetCustomListAddressesGroupGRPNAMEPut (string GRPNAME, BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Update botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesGroupGRPNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var GRPNAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesGroupGRPNAMEPut(GRPNAME, botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesGroupGRPNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesGroupGRPNAMEPutWithHttpInfo(GRPNAME, botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesGroupGRPNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **GRPNAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

<a id="botnetcustomlistaddressesnamenamedelete"></a>
# **BotnetCustomListAddressesNameNAMEDelete**
> ApiStatus BotnetCustomListAddressesNameNAMEDelete (string NAME)



Delete a botnet custom list IP address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesNameNAMEDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesNameNAMEDelete(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesNameNAMEDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesNameNAMEDeleteWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

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

<a id="botnetcustomlistaddressesnamenameget"></a>
# **BotnetCustomListAddressesNameNAMEGet**
> BotnetCustomListAddressCollection BotnetCustomListAddressesNameNAMEGet (string NAME)



Retrieve botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesNameNAMEGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")

            try
            {
                BotnetCustomListAddressCollection result = apiInstance.BotnetCustomListAddressesNameNAMEGet(NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesNameNAMEGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BotnetCustomListAddressCollection> response = apiInstance.BotnetCustomListAddressesNameNAMEGetWithHttpInfo(NAME);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |

### Return type

[**BotnetCustomListAddressCollection**](BotnetCustomListAddressCollection.md)

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

<a id="botnetcustomlistaddressesnamenamepatch"></a>
# **BotnetCustomListAddressesNameNAMEPatch**
> ApiStatus BotnetCustomListAddressesNameNAMEPatch (string NAME, BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Patch botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesNameNAMEPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesNameNAMEPatch(NAME, botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesNameNAMEPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesNameNAMEPatchWithHttpInfo(NAME, botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

<a id="botnetcustomlistaddressesnamenameput"></a>
# **BotnetCustomListAddressesNameNAMEPut**
> ApiStatus BotnetCustomListAddressesNameNAMEPut (string NAME, BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Update botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesNameNAMEPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var NAME = "\"abc\"";  // string | Word in the form: WORD or \"QUOTED STRING\" (default to "abc")
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesNameNAMEPut(NAME, botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesNameNAMEPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesNameNAMEPutWithHttpInfo(NAME, botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesNameNAMEPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **NAME** | **string** | Word in the form: WORD or \&quot;QUOTED STRING\&quot; | [default to &quot;abc&quot;] |
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

<a id="botnetcustomlistaddressespatch"></a>
# **BotnetCustomListAddressesPatch**
> ApiStatus BotnetCustomListAddressesPatch (BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Patch botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesPatch(botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesPatchWithHttpInfo(botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

<a id="botnetcustomlistaddressespost"></a>
# **BotnetCustomListAddressesPost**
> ApiStatus BotnetCustomListAddressesPost (BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Create a new botnet custom list IP address object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesPost(botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesPostWithHttpInfo(botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

<a id="botnetcustomlistaddressesput"></a>
# **BotnetCustomListAddressesPut**
> ApiStatus BotnetCustomListAddressesPut (BotnetCustomListAddressCollection? botnetCustomListAddressCollection = null)



Update botnet custom list addresses configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class BotnetCustomListAddressesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotnetCustomListAddressApi(config);
            var botnetCustomListAddressCollection = new BotnetCustomListAddressCollection?(); // BotnetCustomListAddressCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.BotnetCustomListAddressesPut(botnetCustomListAddressCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BotnetCustomListAddressesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.BotnetCustomListAddressesPutWithHttpInfo(botnetCustomListAddressCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotnetCustomListAddressApi.BotnetCustomListAddressesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botnetCustomListAddressCollection** | [**BotnetCustomListAddressCollection?**](BotnetCustomListAddressCollection?.md) |  | [optional]  |

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

