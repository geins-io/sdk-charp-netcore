# Org.OpenAPITools.Api.PageAreaApi

All URIs are relative to *https://mgmtapi.carismar.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrUpdateAPageArea**](PageAreaApi.md#createorupdateapagearea) | **POST** /API/PageArea | Create or update a page area |
| [**CreateOrUpdatePageAreaFamily**](PageAreaApi.md#createorupdatepageareafamily) | **POST** /API/PageAreaFamily | Create or update a page area family |
| [**GetPageArea**](PageAreaApi.md#getpagearea) | **GET** /API/PageArea/{name} | Get a specific page area |
| [**GetPageAreaFamily**](PageAreaApi.md#getpageareafamily) | **GET** /API/PageAreaFamily/{familyId} | Get a specific page area family |
| [**ListPageAreaFamilies**](PageAreaApi.md#listpageareafamilies) | **GET** /API/PageAreaFamily/List | Gets a list of all page area families, including nested data |

<a name="createorupdateapagearea"></a>
# **CreateOrUpdateAPageArea**
> EnvelopePageAreaModelsReadPageArea CreateOrUpdateAPageArea (PageAreaModelsWritePageArea area)

Create or update a page area

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrUpdateAPageAreaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.carismar.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PageAreaApi(config);
            var area = new PageAreaModelsWritePageArea(); // PageAreaModelsWritePageArea | The area model to create or update.

            try
            {
                // Create or update a page area
                EnvelopePageAreaModelsReadPageArea result = apiInstance.CreateOrUpdateAPageArea(area);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PageAreaApi.CreateOrUpdateAPageArea: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateAPageAreaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or update a page area
    ApiResponse<EnvelopePageAreaModelsReadPageArea> response = apiInstance.CreateOrUpdateAPageAreaWithHttpInfo(area);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PageAreaApi.CreateOrUpdateAPageAreaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **area** | [**PageAreaModelsWritePageArea**](PageAreaModelsWritePageArea.md) | The area model to create or update. |  |

### Return type

[**EnvelopePageAreaModelsReadPageArea**](EnvelopePageAreaModelsReadPageArea.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorupdatepageareafamily"></a>
# **CreateOrUpdatePageAreaFamily**
> EnvelopePageAreaModelsReadPageAreaFamily CreateOrUpdatePageAreaFamily (PageAreaModelsWritePageAreaFamily family)

Create or update a page area family

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrUpdatePageAreaFamilyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.carismar.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PageAreaApi(config);
            var family = new PageAreaModelsWritePageAreaFamily(); // PageAreaModelsWritePageAreaFamily | The family model to create or update.

            try
            {
                // Create or update a page area family
                EnvelopePageAreaModelsReadPageAreaFamily result = apiInstance.CreateOrUpdatePageAreaFamily(family);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PageAreaApi.CreateOrUpdatePageAreaFamily: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdatePageAreaFamilyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or update a page area family
    ApiResponse<EnvelopePageAreaModelsReadPageAreaFamily> response = apiInstance.CreateOrUpdatePageAreaFamilyWithHttpInfo(family);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PageAreaApi.CreateOrUpdatePageAreaFamilyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **family** | [**PageAreaModelsWritePageAreaFamily**](PageAreaModelsWritePageAreaFamily.md) | The family model to create or update. |  |

### Return type

[**EnvelopePageAreaModelsReadPageAreaFamily**](EnvelopePageAreaModelsReadPageAreaFamily.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagearea"></a>
# **GetPageArea**
> PageAreaModelsReadPageArea GetPageArea (string name)

Get a specific page area

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPageAreaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.carismar.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PageAreaApi(config);
            var name = "name_example";  // string | The name of the page area to get.

            try
            {
                // Get a specific page area
                PageAreaModelsReadPageArea result = apiInstance.GetPageArea(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PageAreaApi.GetPageArea: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPageAreaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific page area
    ApiResponse<PageAreaModelsReadPageArea> response = apiInstance.GetPageAreaWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PageAreaApi.GetPageAreaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the page area to get. |  |

### Return type

[**PageAreaModelsReadPageArea**](PageAreaModelsReadPageArea.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageareafamily"></a>
# **GetPageAreaFamily**
> PageAreaModelsReadPageAreaFamily GetPageAreaFamily (int familyId)

Get a specific page area family

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPageAreaFamilyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.carismar.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PageAreaApi(config);
            var familyId = 56;  // int | The id of the page area family to get.

            try
            {
                // Get a specific page area family
                PageAreaModelsReadPageAreaFamily result = apiInstance.GetPageAreaFamily(familyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PageAreaApi.GetPageAreaFamily: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPageAreaFamilyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific page area family
    ApiResponse<PageAreaModelsReadPageAreaFamily> response = apiInstance.GetPageAreaFamilyWithHttpInfo(familyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PageAreaApi.GetPageAreaFamilyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **familyId** | **int** | The id of the page area family to get. |  |

### Return type

[**PageAreaModelsReadPageAreaFamily**](PageAreaModelsReadPageAreaFamily.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpageareafamilies"></a>
# **ListPageAreaFamilies**
> List&lt;PageAreaModelsReadPageAreaFamily&gt; ListPageAreaFamilies ()

Gets a list of all page area families, including nested data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListPageAreaFamiliesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.carismar.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PageAreaApi(config);

            try
            {
                // Gets a list of all page area families, including nested data
                List<PageAreaModelsReadPageAreaFamily> result = apiInstance.ListPageAreaFamilies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PageAreaApi.ListPageAreaFamilies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPageAreaFamiliesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of all page area families, including nested data
    ApiResponse<List<PageAreaModelsReadPageAreaFamily>> response = apiInstance.ListPageAreaFamiliesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PageAreaApi.ListPageAreaFamiliesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PageAreaModelsReadPageAreaFamily&gt;**](PageAreaModelsReadPageAreaFamily.md)

### Authorization

[apiKey](../README.md#apiKey), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

