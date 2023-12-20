# SonicWallGen7.Api.AntiSpywareExclusionEntryApi

All URIs are relative to *https://192.168.168.168:443/api/sonicos*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AntiSpywareExclusionListEntriesFromFROMIPToTOIPDelete**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriesfromfromiptotoipdelete) | **DELETE** /anti-spyware/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**AntiSpywareExclusionListEntriesFromFROMIPToTOIPGet**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriesfromfromiptotoipget) | **GET** /anti-spyware/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatch**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriesfromfromiptotoippatch) | **PATCH** /anti-spyware/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**AntiSpywareExclusionListEntriesFromFROMIPToTOIPPut**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriesfromfromiptotoipput) | **PUT** /anti-spyware/exclusion-list/entries/from/{FROMIP}/to/{TOIP} |  |
| [**AntiSpywareExclusionListEntriesGet**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriesget) | **GET** /anti-spyware/exclusion-list/entries |  |
| [**AntiSpywareExclusionListEntriesPatch**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriespatch) | **PATCH** /anti-spyware/exclusion-list/entries |  |
| [**AntiSpywareExclusionListEntriesPost**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriespost) | **POST** /anti-spyware/exclusion-list/entries |  |
| [**AntiSpywareExclusionListEntriesPut**](AntiSpywareExclusionEntryApi.md#antispywareexclusionlistentriesput) | **PUT** /anti-spyware/exclusion-list/entries |  |

<a id="antispywareexclusionlistentriesfromfromiptotoipdelete"></a>
# **AntiSpywareExclusionListEntriesFromFROMIPToTOIPDelete**
> ApiStatus AntiSpywareExclusionListEntriesFromFROMIPToTOIPDelete (string FROMIP, string TOIP)



Delete an existing anti spyware exclusion entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesFromFROMIPToTOIPDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | The from IP of anti-spyware exclusion range list. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | The end IP of anti-spyware exclusion range list. (default to "192.168.168.168")

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPDelete(FROMIP, TOIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo(FROMIP, TOIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | The from IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | The end IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |

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

<a id="antispywareexclusionlistentriesfromfromiptotoipget"></a>
# **AntiSpywareExclusionListEntriesFromFROMIPToTOIPGet**
> AntiSpywareExclusionEntryCollection AntiSpywareExclusionListEntriesFromFROMIPToTOIPGet (string FROMIP, string TOIP)



Retrieve anti spyware exclusion entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesFromFROMIPToTOIPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | The from IP of anti-spyware exclusion range list. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | The end IP of anti-spyware exclusion range list. (default to "192.168.168.168")

            try
            {
                AntiSpywareExclusionEntryCollection result = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPGet(FROMIP, TOIP);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywareExclusionEntryCollection> response = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo(FROMIP, TOIP);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | The from IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | The end IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |

### Return type

[**AntiSpywareExclusionEntryCollection**](AntiSpywareExclusionEntryCollection.md)

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

<a id="antispywareexclusionlistentriesfromfromiptotoippatch"></a>
# **AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatch**
> ApiStatus AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatch (string FROMIP, string TOIP, AntiSpywareExclusionEntryCollection? antiSpywareExclusionEntryCollection = null)



Patch anti spyware exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | The from IP of anti-spyware exclusion range list. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | The end IP of anti-spyware exclusion range list. (default to "192.168.168.168")
            var antiSpywareExclusionEntryCollection = new AntiSpywareExclusionEntryCollection?(); // AntiSpywareExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatch(FROMIP, TOIP, antiSpywareExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo(FROMIP, TOIP, antiSpywareExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | The from IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | The end IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |
| **antiSpywareExclusionEntryCollection** | [**AntiSpywareExclusionEntryCollection?**](AntiSpywareExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="antispywareexclusionlistentriesfromfromiptotoipput"></a>
# **AntiSpywareExclusionListEntriesFromFROMIPToTOIPPut**
> ApiStatus AntiSpywareExclusionListEntriesFromFROMIPToTOIPPut (string FROMIP, string TOIP, AntiSpywareExclusionEntryCollection? antiSpywareExclusionEntryCollection = null)



Edit anti spyware exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesFromFROMIPToTOIPPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var FROMIP = "\"192.168.168.168\"";  // string | The from IP of anti-spyware exclusion range list. (default to "192.168.168.168")
            var TOIP = "\"192.168.168.168\"";  // string | The end IP of anti-spyware exclusion range list. (default to "192.168.168.168")
            var antiSpywareExclusionEntryCollection = new AntiSpywareExclusionEntryCollection?(); // AntiSpywareExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPut(FROMIP, TOIP, antiSpywareExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo(FROMIP, TOIP, antiSpywareExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesFromFROMIPToTOIPPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **FROMIP** | **string** | The from IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |
| **TOIP** | **string** | The end IP of anti-spyware exclusion range list. | [default to &quot;192.168.168.168&quot;] |
| **antiSpywareExclusionEntryCollection** | [**AntiSpywareExclusionEntryCollection?**](AntiSpywareExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="antispywareexclusionlistentriesget"></a>
# **AntiSpywareExclusionListEntriesGet**
> AntiSpywareExclusionEntryCollection AntiSpywareExclusionListEntriesGet ()



Retrieve anti spyware exclusion entries configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);

            try
            {
                AntiSpywareExclusionEntryCollection result = apiInstance.AntiSpywareExclusionListEntriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AntiSpywareExclusionEntryCollection> response = apiInstance.AntiSpywareExclusionListEntriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AntiSpywareExclusionEntryCollection**](AntiSpywareExclusionEntryCollection.md)

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

<a id="antispywareexclusionlistentriespatch"></a>
# **AntiSpywareExclusionListEntriesPatch**
> ApiStatus AntiSpywareExclusionListEntriesPatch (AntiSpywareExclusionEntryCollection? antiSpywareExclusionEntryCollection = null)



Patch anti spyware exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var antiSpywareExclusionEntryCollection = new AntiSpywareExclusionEntryCollection?(); // AntiSpywareExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListEntriesPatch(antiSpywareExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListEntriesPatchWithHttpInfo(antiSpywareExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **antiSpywareExclusionEntryCollection** | [**AntiSpywareExclusionEntryCollection?**](AntiSpywareExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="antispywareexclusionlistentriespost"></a>
# **AntiSpywareExclusionListEntriesPost**
> ApiStatus AntiSpywareExclusionListEntriesPost (AntiSpywareExclusionEntryCollection? antiSpywareExclusionEntryCollection = null)



Add a new anti spyware exclusion entry object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var antiSpywareExclusionEntryCollection = new AntiSpywareExclusionEntryCollection?(); // AntiSpywareExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListEntriesPost(antiSpywareExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListEntriesPostWithHttpInfo(antiSpywareExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **antiSpywareExclusionEntryCollection** | [**AntiSpywareExclusionEntryCollection?**](AntiSpywareExclusionEntryCollection?.md) |  | [optional]  |

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

<a id="antispywareexclusionlistentriesput"></a>
# **AntiSpywareExclusionListEntriesPut**
> ApiStatus AntiSpywareExclusionListEntriesPut (AntiSpywareExclusionEntryCollection? antiSpywareExclusionEntryCollection = null)



Edit anti spyware exclusion entries object configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SonicWallGen7.Api;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace Example
{
    public class AntiSpywareExclusionListEntriesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.168.168:443/api/sonicos";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AntiSpywareExclusionEntryApi(config);
            var antiSpywareExclusionEntryCollection = new AntiSpywareExclusionEntryCollection?(); // AntiSpywareExclusionEntryCollection? |  (optional) 

            try
            {
                ApiStatus result = apiInstance.AntiSpywareExclusionListEntriesPut(antiSpywareExclusionEntryCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AntiSpywareExclusionListEntriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiStatus> response = apiInstance.AntiSpywareExclusionListEntriesPutWithHttpInfo(antiSpywareExclusionEntryCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AntiSpywareExclusionEntryApi.AntiSpywareExclusionListEntriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **antiSpywareExclusionEntryCollection** | [**AntiSpywareExclusionEntryCollection?**](AntiSpywareExclusionEntryCollection?.md) |  | [optional]  |

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

