# Org.OpenAPITools.Api.VariantApi

All URIs are relative to *https://mgmtapi.geins.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddProductToVariantGroup**](VariantApi.md#addproducttovariantgroup) | **PUT** /API/VariantGroup/{groupId}/{productId} | Adds a product to an existing group |
| [**AddProductToVariantGroupByProductId**](VariantApi.md#addproducttovariantgroupbyproductid) | **PUT** /API/Variant/{productId1}/{productId2} | Adds a product to an existing group |
| [**CreateVariantGroup**](VariantApi.md#createvariantgroup) | **POST** /API/VariantGroup | Create a new variant group |
| [**CreateVariantGroupWithProduct**](VariantApi.md#createvariantgroupwithproduct) | **POST** /API/Variant/{productId}/VariantGroup | Create a new group for the provided product id |
| [**DeleteVariantGroup**](VariantApi.md#deletevariantgroup) | **DELETE** /API/VariantGroup/{groupId} | Delete an entire variant group |
| [**DeleteVariantGroupByProductId**](VariantApi.md#deletevariantgroupbyproductid) | **DELETE** /API/Variant/{productId}/VariantGroup | Delete an entire variant group |
| [**GetVariantGroup**](VariantApi.md#getvariantgroup) | **GET** /API/VariantGroup/{groupId} | Get a specific variant group |
| [**GetVariantGroupByProductId**](VariantApi.md#getvariantgroupbyproductid) | **GET** /API/Variant/{productId}/VariantGroup | Get the variant group for the provided id |
| [**GetVariantLabels**](VariantApi.md#getvariantlabels) | **GET** /API/Variant/Labels | Get all valid variant labels |
| [**RemoveProductFromVariantGroup**](VariantApi.md#removeproductfromvariantgroup) | **DELETE** /API/Variant/{productId} | Remove a product from its variant group |
| [**UpdateVariant**](VariantApi.md#updatevariant) | **PUT** /API/Variant/{productId} | Adds the variant details for the product with the provided ID |
| [**UpdateVariantGroup**](VariantApi.md#updatevariantgroup) | **PUT** /API/VariantGroup/{groupId} | Updates the settings of a group |

<a name="addproducttovariantgroup"></a>
# **AddProductToVariantGroup**
> EnvelopeVariantModelsReadVariantGroup AddProductToVariantGroup (int groupId, string productId, List<VariantModelsWriteVariant> variant, int? productIdType = null, string include = null)

Adds a product to an existing group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddProductToVariantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var groupId = 56;  // int | The ID of the group to which a product should be added
            var productId = "productId_example";  // string | The ID of the product to be added to the target group.
            var variant = new List<VariantModelsWriteVariant>(); // List<VariantModelsWriteVariant> | The variant details.
            var productIdType = 0;  // int? | The type of product id provided. (optional) 
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Adds a product to an existing group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.AddProductToVariantGroup(groupId, productId, variant, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.AddProductToVariantGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddProductToVariantGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a product to an existing group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.AddProductToVariantGroupWithHttpInfo(groupId, productId, variant, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.AddProductToVariantGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** | The ID of the group to which a product should be added |  |
| **productId** | **string** | The ID of the product to be added to the target group. |  |
| **variant** | [**List&lt;VariantModelsWriteVariant&gt;**](VariantModelsWriteVariant.md) | The variant details. |  |
| **productIdType** | **int?** | The type of product id provided. | [optional]  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="addproducttovariantgroupbyproductid"></a>
# **AddProductToVariantGroupByProductId**
> EnvelopeVariantModelsReadVariantGroup AddProductToVariantGroupByProductId (string productId1, string productId2, int? productIdType = null, string include = null)

Adds a product to an existing group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddProductToVariantGroupByProductIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var productId1 = "productId1_example";  // string | The ID of a product belonging to the target group.
            var productId2 = "productId2_example";  // string | The ID of the product to be added to the target group.
            var productIdType = 0;  // int? | The type of product id provided. (optional) 
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Adds a product to an existing group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.AddProductToVariantGroupByProductId(productId1, productId2, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.AddProductToVariantGroupByProductId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddProductToVariantGroupByProductIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a product to an existing group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.AddProductToVariantGroupByProductIdWithHttpInfo(productId1, productId2, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.AddProductToVariantGroupByProductIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId1** | **string** | The ID of a product belonging to the target group. |  |
| **productId2** | **string** | The ID of the product to be added to the target group. |  |
| **productIdType** | **int?** | The type of product id provided. | [optional]  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="createvariantgroup"></a>
# **CreateVariantGroup**
> EnvelopeVariantModelsReadVariantGroup CreateVariantGroup (VariantModelsWriteVariantGroup variantGroup, string include = null)

Create a new variant group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateVariantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var variantGroup = new VariantModelsWriteVariantGroup(); // VariantModelsWriteVariantGroup | The settings for the new group.
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Create a new variant group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.CreateVariantGroup(variantGroup, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.CreateVariantGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVariantGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new variant group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.CreateVariantGroupWithHttpInfo(variantGroup, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.CreateVariantGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variantGroup** | [**VariantModelsWriteVariantGroup**](VariantModelsWriteVariantGroup.md) | The settings for the new group. |  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="createvariantgroupwithproduct"></a>
# **CreateVariantGroupWithProduct**
> EnvelopeVariantModelsReadVariantGroup CreateVariantGroupWithProduct (string productId, VariantModelsWriteVariantGroup variantGroup, int? productIdType = null, string include = null)

Create a new group for the provided product id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateVariantGroupWithProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var productId = "productId_example";  // string | The id of the product, for which to create a group.
            var variantGroup = new VariantModelsWriteVariantGroup(); // VariantModelsWriteVariantGroup | The settings for the new group.
            var productIdType = 0;  // int? | The type of product id provided. (optional) 
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Create a new group for the provided product id
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.CreateVariantGroupWithProduct(productId, variantGroup, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.CreateVariantGroupWithProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVariantGroupWithProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new group for the provided product id
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.CreateVariantGroupWithProductWithHttpInfo(productId, variantGroup, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.CreateVariantGroupWithProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product, for which to create a group. |  |
| **variantGroup** | [**VariantModelsWriteVariantGroup**](VariantModelsWriteVariantGroup.md) | The settings for the new group. |  |
| **productIdType** | **int?** | The type of product id provided. | [optional]  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="deletevariantgroup"></a>
# **DeleteVariantGroup**
> EnvelopeVariantModelsReadVariantGroup DeleteVariantGroup (int groupId)

Delete an entire variant group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteVariantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var groupId = 56;  // int | The ID of the group to delete

            try
            {
                // Delete an entire variant group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.DeleteVariantGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.DeleteVariantGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVariantGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an entire variant group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.DeleteVariantGroupWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.DeleteVariantGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** | The ID of the group to delete |  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="deletevariantgroupbyproductid"></a>
# **DeleteVariantGroupByProductId**
> Envelope DeleteVariantGroupByProductId (string productId, int? productIdType = null)

Delete an entire variant group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteVariantGroupByProductIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var productId = "productId_example";  // string | The id of a product that belongs to the group to remove.
            var productIdType = 0;  // int? | The type of product id provided. (optional) 

            try
            {
                // Delete an entire variant group
                Envelope result = apiInstance.DeleteVariantGroupByProductId(productId, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.DeleteVariantGroupByProductId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVariantGroupByProductIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an entire variant group
    ApiResponse<Envelope> response = apiInstance.DeleteVariantGroupByProductIdWithHttpInfo(productId, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.DeleteVariantGroupByProductIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of a product that belongs to the group to remove. |  |
| **productIdType** | **int?** | The type of product id provided. | [optional]  |

### Return type

[**Envelope**](Envelope.md)

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

<a name="getvariantgroup"></a>
# **GetVariantGroup**
> EnvelopeVariantModelsReadVariantGroup GetVariantGroup (int groupId, string include = null)

Get a specific variant group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVariantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var groupId = 56;  // int | The ID of the group to get
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Get a specific variant group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.GetVariantGroup(groupId, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.GetVariantGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVariantGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific variant group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.GetVariantGroupWithHttpInfo(groupId, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.GetVariantGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** | The ID of the group to get |  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="getvariantgroupbyproductid"></a>
# **GetVariantGroupByProductId**
> EnvelopeVariantModelsReadVariantGroup GetVariantGroupByProductId (string productId, int? productIdType = null, string include = null)

Get the variant group for the provided id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVariantGroupByProductIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var productId = "productId_example";  // string | The id of the product, for which to get the group.
            var productIdType = 0;  // int? | The type of id. (optional) 
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Get the variant group for the provided id
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.GetVariantGroupByProductId(productId, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.GetVariantGroupByProductId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVariantGroupByProductIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the variant group for the provided id
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.GetVariantGroupByProductIdWithHttpInfo(productId, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.GetVariantGroupByProductIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product, for which to get the group. |  |
| **productIdType** | **int?** | The type of id. | [optional]  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="getvariantlabels"></a>
# **GetVariantLabels**
> EnvelopeString GetVariantLabels ()

Get all valid variant labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVariantLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);

            try
            {
                // Get all valid variant labels
                EnvelopeString result = apiInstance.GetVariantLabels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.GetVariantLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVariantLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all valid variant labels
    ApiResponse<EnvelopeString> response = apiInstance.GetVariantLabelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.GetVariantLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EnvelopeString**](EnvelopeString.md)

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

<a name="removeproductfromvariantgroup"></a>
# **RemoveProductFromVariantGroup**
> EnvelopeVariantModelsReadVariantGroup RemoveProductFromVariantGroup (string productId, int? productIdType = null, string include = null)

Remove a product from its variant group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RemoveProductFromVariantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var productId = "productId_example";  // string | The id of the product to remove from group.
            var productIdType = 0;  // int? | The type of product id provided. (optional) 
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Remove a product from its variant group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.RemoveProductFromVariantGroup(productId, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.RemoveProductFromVariantGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveProductFromVariantGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a product from its variant group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.RemoveProductFromVariantGroupWithHttpInfo(productId, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.RemoveProductFromVariantGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product to remove from group. |  |
| **productIdType** | **int?** | The type of product id provided. | [optional]  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

<a name="updatevariant"></a>
# **UpdateVariant**
> EnvelopeVariantModelsReadVariant UpdateVariant (string productId, List<VariantModelsWriteVariant> variant, int? productIdType = null)

Adds the variant details for the product with the provided ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateVariantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var productId = "productId_example";  // string | The ID of the product for which to update the variant details.
            var variant = new List<VariantModelsWriteVariant>(); // List<VariantModelsWriteVariant> | The variant details.
            var productIdType = 0;  // int? | The type of product id provided. (optional) 

            try
            {
                // Adds the variant details for the product with the provided ID
                EnvelopeVariantModelsReadVariant result = apiInstance.UpdateVariant(productId, variant, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.UpdateVariant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVariantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds the variant details for the product with the provided ID
    ApiResponse<EnvelopeVariantModelsReadVariant> response = apiInstance.UpdateVariantWithHttpInfo(productId, variant, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.UpdateVariantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The ID of the product for which to update the variant details. |  |
| **variant** | [**List&lt;VariantModelsWriteVariant&gt;**](VariantModelsWriteVariant.md) | The variant details. |  |
| **productIdType** | **int?** | The type of product id provided. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariant**](EnvelopeVariantModelsReadVariant.md)

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

<a name="updatevariantgroup"></a>
# **UpdateVariantGroup**
> EnvelopeVariantModelsReadVariantGroup UpdateVariantGroup (int groupId, VariantModelsWriteVariantGroup variantGroup, string include = null)

Updates the settings of a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateVariantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mgmtapi.geins.io";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-apikey", "Bearer");
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VariantApi(config);
            var groupId = 56;  // int | The ID of the group to update
            var variantGroup = new VariantModelsWriteVariantGroup(); // VariantModelsWriteVariantGroup | The new settings for the group
            var include = "include_example";  // string | Comma separated list of product child collections to also include with the variant group. Set to \"product\" to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Updates the settings of a group
                EnvelopeVariantModelsReadVariantGroup result = apiInstance.UpdateVariantGroup(groupId, variantGroup, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariantApi.UpdateVariantGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVariantGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the settings of a group
    ApiResponse<EnvelopeVariantModelsReadVariantGroup> response = apiInstance.UpdateVariantGroupWithHttpInfo(groupId, variantGroup, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariantApi.UpdateVariantGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** | The ID of the group to update |  |
| **variantGroup** | [**VariantModelsWriteVariantGroup**](VariantModelsWriteVariantGroup.md) | The new settings for the group |  |
| **include** | **string** | Comma separated list of product child collections to also include with the variant group. Set to \&quot;product\&quot; to only include basic product data and to null (skip) to not include any product data. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeVariantModelsReadVariantGroup**](EnvelopeVariantModelsReadVariantGroup.md)

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

