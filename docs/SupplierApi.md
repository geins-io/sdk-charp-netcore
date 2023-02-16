# Org.OpenAPITools.Api.SupplierApi

All URIs are relative to *https://mgmtapi.carismar.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSupplier**](SupplierApi.md#createsupplier) | **POST** /API/Supplier | Create a new supplier |
| [**GetSupplierById**](SupplierApi.md#getsupplierbyid) | **GET** /API/Supplier/{id} | Get a specific supplier |
| [**QuerySuppliers**](SupplierApi.md#querysuppliers) | **POST** /API/Supplier/Query | Query suppliers |
| [**UpdateSupplier**](SupplierApi.md#updatesupplier) | **PUT** /API/Supplier/{id} | Updates a supplier |

<a name="createsupplier"></a>
# **CreateSupplier**
> EnvelopeSupplierModelsReadSupplier CreateSupplier (SupplierModelsWriteSupplier supplier)

Create a new supplier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSupplierExample
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

            var apiInstance = new SupplierApi(config);
            var supplier = new SupplierModelsWriteSupplier(); // SupplierModelsWriteSupplier | The supplier to create.

            try
            {
                // Create a new supplier
                EnvelopeSupplierModelsReadSupplier result = apiInstance.CreateSupplier(supplier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.CreateSupplier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSupplierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new supplier
    ApiResponse<EnvelopeSupplierModelsReadSupplier> response = apiInstance.CreateSupplierWithHttpInfo(supplier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.CreateSupplierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supplier** | [**SupplierModelsWriteSupplier**](SupplierModelsWriteSupplier.md) | The supplier to create. |  |

### Return type

[**EnvelopeSupplierModelsReadSupplier**](EnvelopeSupplierModelsReadSupplier.md)

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

<a name="getsupplierbyid"></a>
# **GetSupplierById**
> EnvelopeSupplierModelsReadSupplier GetSupplierById (int id)

Get a specific supplier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSupplierByIdExample
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

            var apiInstance = new SupplierApi(config);
            var id = 56;  // int | The id of the supplier to get.

            try
            {
                // Get a specific supplier
                EnvelopeSupplierModelsReadSupplier result = apiInstance.GetSupplierById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.GetSupplierById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupplierByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific supplier
    ApiResponse<EnvelopeSupplierModelsReadSupplier> response = apiInstance.GetSupplierByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.GetSupplierByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The id of the supplier to get. |  |

### Return type

[**EnvelopeSupplierModelsReadSupplier**](EnvelopeSupplierModelsReadSupplier.md)

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

<a name="querysuppliers"></a>
# **QuerySuppliers**
> List&lt;SupplierModelsReadSupplier&gt; QuerySuppliers (SupplierModelsSupplierQuery query)

Query suppliers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuerySuppliersExample
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

            var apiInstance = new SupplierApi(config);
            var query = new SupplierModelsSupplierQuery(); // SupplierModelsSupplierQuery | The details of the query

            try
            {
                // Query suppliers
                List<SupplierModelsReadSupplier> result = apiInstance.QuerySuppliers(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.QuerySuppliers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuerySuppliersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query suppliers
    ApiResponse<List<SupplierModelsReadSupplier>> response = apiInstance.QuerySuppliersWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.QuerySuppliersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**SupplierModelsSupplierQuery**](SupplierModelsSupplierQuery.md) | The details of the query |  |

### Return type

[**List&lt;SupplierModelsReadSupplier&gt;**](SupplierModelsReadSupplier.md)

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

<a name="updatesupplier"></a>
# **UpdateSupplier**
> EnvelopeSupplierModelsReadSupplier UpdateSupplier (int id, SupplierModelsWriteSupplier supplier)

Updates a supplier

Leaving out a property will ensure no changes are made to that property.  Collection properties will delete and/or add as necessary to match the supplied data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateSupplierExample
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

            var apiInstance = new SupplierApi(config);
            var id = 56;  // int | The id of the supplier to update.
            var supplier = new SupplierModelsWriteSupplier(); // SupplierModelsWriteSupplier | The supplier data to update.

            try
            {
                // Updates a supplier
                EnvelopeSupplierModelsReadSupplier result = apiInstance.UpdateSupplier(id, supplier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.UpdateSupplier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSupplierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a supplier
    ApiResponse<EnvelopeSupplierModelsReadSupplier> response = apiInstance.UpdateSupplierWithHttpInfo(id, supplier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.UpdateSupplierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The id of the supplier to update. |  |
| **supplier** | [**SupplierModelsWriteSupplier**](SupplierModelsWriteSupplier.md) | The supplier data to update. |  |

### Return type

[**EnvelopeSupplierModelsReadSupplier**](EnvelopeSupplierModelsReadSupplier.md)

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

