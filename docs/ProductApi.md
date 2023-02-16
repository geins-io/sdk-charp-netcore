# Org.OpenAPITools.Api.ProductApi

All URIs are relative to *https://mgmtapi.geins.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAvailabilityMonitor**](ProductApi.md#addavailabilitymonitor) | **POST** /API/Product/MonitorAvailability | Add a product availability monitor |
| [**AddCategoryToProduct**](ProductApi.md#addcategorytoproduct) | **PUT** /API/Product/{productId}/Category | Adds a category relation to a product |
| [**AddImageToProduct**](ProductApi.md#addimagetoproduct) | **PUT** /API/Product/{productId}/Image/{imageName} | Adds an image relation to a product |
| [**AddRelatedProductsToProduct**](ProductApi.md#addrelatedproductstoproduct) | **PUT** /API/Product/{productId}/Related | Add related products to a product |
| [**BatchUpdateProductItems**](ProductApi.md#batchupdateproductitems) | **PUT** /API/Product/Items | Updates product items in batch |
| [**BatchUpdateStockValues**](ProductApi.md#batchupdatestockvalues) | **PUT** /API/Product/Stock | Update stock values for multiple product items |
| [**CreateProduct**](ProductApi.md#createproduct) | **POST** /API/Product | Create a new product |
| [**CreateProductItems**](ProductApi.md#createproductitems) | **POST** /API/Product/{productId}/Item | Create a new product item |
| [**GetProductById**](ProductApi.md#getproductbyid) | **GET** /API/Product/{productId} | Get a specific product |
| [**GetProductItemById**](ProductApi.md#getproductitembyid) | **GET** /API/Product/Item/{itemId} | Get a specific product item |
| [**LinkRelatedProductsByRelationId**](ProductApi.md#linkrelatedproductsbyrelationid) | **PUT** /API/Product/{productId}/Related/{relationTypeId} | Add related products to a product using a fixed relation type |
| [**ListAllProductItemsPaged**](ProductApi.md#listallproductitemspaged) | **GET** /API/Product/Items/{page} | Get all product items with pagination |
| [**ListFeeds**](ProductApi.md#listfeeds) | **GET** /API/Product/Feeds | Gets a list of all feeds |
| [**ListProductItems**](ProductApi.md#listproductitems) | **GET** /API/Product/Items | Get all product items |
| [**ListProductRelationTypes**](ProductApi.md#listproductrelationtypes) | **GET** /API/Product/RelationTypes | Gets a list of product relation types |
| [**QueryProducts**](ProductApi.md#queryproducts) | **POST** /API/Product/Query | Query products |
| [**QueryProductsPaged**](ProductApi.md#queryproductspaged) | **POST** /API/Product/Query/{page} | Query products with pagination |
| [**QueryStock**](ProductApi.md#querystock) | **POST** /API/Product/Stock/Query | Query stock |
| [**UpdateProduct**](ProductApi.md#updateproduct) | **PUT** /API/Product/{productId} | Updates a product |
| [**UpdateProductItem**](ProductApi.md#updateproductitem) | **PUT** /API/Product/Item/{itemId} | Updates a product item |

<a name="addavailabilitymonitor"></a>
# **AddAvailabilityMonitor**
> Envelope AddAvailabilityMonitor (ProductModelsMonitorSku model)

Add a product availability monitor

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddAvailabilityMonitorExample
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

            var apiInstance = new ProductApi(config);
            var model = new ProductModelsMonitorSku(); // ProductModelsMonitorSku | 

            try
            {
                // Add a product availability monitor
                Envelope result = apiInstance.AddAvailabilityMonitor(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.AddAvailabilityMonitor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAvailabilityMonitorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a product availability monitor
    ApiResponse<Envelope> response = apiInstance.AddAvailabilityMonitorWithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.AddAvailabilityMonitorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**ProductModelsMonitorSku**](ProductModelsMonitorSku.md) |  |  |

### Return type

[**Envelope**](Envelope.md)

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

<a name="addcategorytoproduct"></a>
# **AddCategoryToProduct**
> Envelope AddCategoryToProduct (string productId, ProductModelsProductCategory productCategory, int? productIdType = null)

Adds a category relation to a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddCategoryToProductExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the product to update.
            var productCategory = new ProductModelsProductCategory(); // ProductModelsProductCategory | The category to relate the product to.
            var productIdType = 0;  // int? | The type of product id supplied in {productId}. (optional) 

            try
            {
                // Adds a category relation to a product
                Envelope result = apiInstance.AddCategoryToProduct(productId, productCategory, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.AddCategoryToProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddCategoryToProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a category relation to a product
    ApiResponse<Envelope> response = apiInstance.AddCategoryToProductWithHttpInfo(productId, productCategory, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.AddCategoryToProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product to update. |  |
| **productCategory** | [**ProductModelsProductCategory**](ProductModelsProductCategory.md) | The category to relate the product to. |  |
| **productIdType** | **int?** | The type of product id supplied in {productId}. | [optional]  |

### Return type

[**Envelope**](Envelope.md)

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

<a name="addimagetoproduct"></a>
# **AddImageToProduct**
> Envelope AddImageToProduct (string productId, string imageName, bool? isPrimaryImage = null, int? productIdType = null)

Adds an image relation to a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddImageToProductExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the product to update.
            var imageName = "imageName_example";  // string | The name of the image to set to product.
            var isPrimaryImage = true;  // bool? | Specifies whether {imageName} should be set as the primary image of the product. (optional) 
            var productIdType = 0;  // int? | The type of product id supplied in {productId}. (optional) 

            try
            {
                // Adds an image relation to a product
                Envelope result = apiInstance.AddImageToProduct(productId, imageName, isPrimaryImage, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.AddImageToProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddImageToProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds an image relation to a product
    ApiResponse<Envelope> response = apiInstance.AddImageToProductWithHttpInfo(productId, imageName, isPrimaryImage, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.AddImageToProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product to update. |  |
| **imageName** | **string** | The name of the image to set to product. |  |
| **isPrimaryImage** | **bool?** | Specifies whether {imageName} should be set as the primary image of the product. | [optional]  |
| **productIdType** | **int?** | The type of product id supplied in {productId}. | [optional]  |

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

<a name="addrelatedproductstoproduct"></a>
# **AddRelatedProductsToProduct**
> ProductModelsRelatedProductEnvelope AddRelatedProductsToProduct (string productId, List<ProductModelsWriteRelatedProduct> relatedProducts, int? productIdType = null)

Add related products to a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddRelatedProductsToProductExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the main product to which the relations will be created
            var relatedProducts = new List<ProductModelsWriteRelatedProduct>(); // List<ProductModelsWriteRelatedProduct> | The list of related products to link with the main product.
            var productIdType = 0;  // int? | The type of product id for {productId} and supplied in {relatedProducts}. (optional) 

            try
            {
                // Add related products to a product
                ProductModelsRelatedProductEnvelope result = apiInstance.AddRelatedProductsToProduct(productId, relatedProducts, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.AddRelatedProductsToProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddRelatedProductsToProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add related products to a product
    ApiResponse<ProductModelsRelatedProductEnvelope> response = apiInstance.AddRelatedProductsToProductWithHttpInfo(productId, relatedProducts, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.AddRelatedProductsToProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the main product to which the relations will be created |  |
| **relatedProducts** | [**List&lt;ProductModelsWriteRelatedProduct&gt;**](ProductModelsWriteRelatedProduct.md) | The list of related products to link with the main product. |  |
| **productIdType** | **int?** | The type of product id for {productId} and supplied in {relatedProducts}. | [optional]  |

### Return type

[**ProductModelsRelatedProductEnvelope**](ProductModelsRelatedProductEnvelope.md)

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

<a name="batchupdateproductitems"></a>
# **BatchUpdateProductItems**
> Envelope BatchUpdateProductItems (List<ProductModelsWriteProductItem> productItems, int? productItemIdType = null)

Updates product items in batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchUpdateProductItemsExample
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

            var apiInstance = new ProductApi(config);
            var productItems = new List<ProductModelsWriteProductItem>(); // List<ProductModelsWriteProductItem> | The product items to update
            var productItemIdType = 0;  // int? | The type of product item id (optional) 

            try
            {
                // Updates product items in batch
                Envelope result = apiInstance.BatchUpdateProductItems(productItems, productItemIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BatchUpdateProductItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpdateProductItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates product items in batch
    ApiResponse<Envelope> response = apiInstance.BatchUpdateProductItemsWithHttpInfo(productItems, productItemIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BatchUpdateProductItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productItems** | [**List&lt;ProductModelsWriteProductItem&gt;**](ProductModelsWriteProductItem.md) | The product items to update |  |
| **productItemIdType** | **int?** | The type of product item id | [optional]  |

### Return type

[**Envelope**](Envelope.md)

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

<a name="batchupdatestockvalues"></a>
# **BatchUpdateStockValues**
> ProductModelsStockEnvelope BatchUpdateStockValues (List<ProductModelsWriteProductItemStock> productItemStocks, int? productItemIdType = null)

Update stock values for multiple product items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchUpdateStockValuesExample
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

            var apiInstance = new ProductApi(config);
            var productItemStocks = new List<ProductModelsWriteProductItemStock>(); // List<ProductModelsWriteProductItemStock> | List of product item ids with new stock values.
            var productItemIdType = 0;  // int? | The type of product item id supplied in {productItemStocks}. (optional) 

            try
            {
                // Update stock values for multiple product items
                ProductModelsStockEnvelope result = apiInstance.BatchUpdateStockValues(productItemStocks, productItemIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.BatchUpdateStockValues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpdateStockValuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update stock values for multiple product items
    ApiResponse<ProductModelsStockEnvelope> response = apiInstance.BatchUpdateStockValuesWithHttpInfo(productItemStocks, productItemIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.BatchUpdateStockValuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productItemStocks** | [**List&lt;ProductModelsWriteProductItemStock&gt;**](ProductModelsWriteProductItemStock.md) | List of product item ids with new stock values. |  |
| **productItemIdType** | **int?** | The type of product item id supplied in {productItemStocks}. | [optional]  |

### Return type

[**ProductModelsStockEnvelope**](ProductModelsStockEnvelope.md)

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

<a name="createproduct"></a>
# **CreateProduct**
> EnvelopeProductModelsReadProduct CreateProduct (ProductModelsWriteProduct product, string include = null)

Create a new product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateProductExample
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

            var apiInstance = new ProductApi(config);
            var product = new ProductModelsWriteProduct(); // ProductModelsWriteProduct | The product to create.
            var include = "include_example";  // string | Comma separated list of child-collections to also include with the created product. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Create a new product
                EnvelopeProductModelsReadProduct result = apiInstance.CreateProduct(product, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new product
    ApiResponse<EnvelopeProductModelsReadProduct> response = apiInstance.CreateProductWithHttpInfo(product, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.CreateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **product** | [**ProductModelsWriteProduct**](ProductModelsWriteProduct.md) | The product to create. |  |
| **include** | **string** | Comma separated list of child-collections to also include with the created product. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeProductModelsReadProduct**](EnvelopeProductModelsReadProduct.md)

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

<a name="createproductitems"></a>
# **CreateProductItems**
> EnvelopeProductModelsReadProductItem CreateProductItems (string productId, ProductModelsWriteProductItem productItem, int? productIdType = null)

Create a new product item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateProductItemsExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the product to create an item on.
            var productItem = new ProductModelsWriteProductItem(); // ProductModelsWriteProductItem | The product item to create.
            var productIdType = 0;  // int? | The type of product id supplied in {productId}. (optional) 

            try
            {
                // Create a new product item
                EnvelopeProductModelsReadProductItem result = apiInstance.CreateProductItems(productId, productItem, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProductItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new product item
    ApiResponse<EnvelopeProductModelsReadProductItem> response = apiInstance.CreateProductItemsWithHttpInfo(productId, productItem, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.CreateProductItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product to create an item on. |  |
| **productItem** | [**ProductModelsWriteProductItem**](ProductModelsWriteProductItem.md) | The product item to create. |  |
| **productIdType** | **int?** | The type of product id supplied in {productId}. | [optional]  |

### Return type

[**EnvelopeProductModelsReadProductItem**](EnvelopeProductModelsReadProductItem.md)

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

<a name="getproductbyid"></a>
# **GetProductById**
> EnvelopeProductModelsReadProduct GetProductById (string productId, int? productIdType = null, string include = null)

Get a specific product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetProductByIdExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the product to get.
            var productIdType = 0;  // int? | The type of product id supplied in {productId}. (optional) 
            var include = "include_example";  // string | Comma separated list of child-collections to also include with the requested product. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Get a specific product
                EnvelopeProductModelsReadProduct result = apiInstance.GetProductById(productId, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific product
    ApiResponse<EnvelopeProductModelsReadProduct> response = apiInstance.GetProductByIdWithHttpInfo(productId, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetProductByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product to get. |  |
| **productIdType** | **int?** | The type of product id supplied in {productId}. | [optional]  |
| **include** | **string** | Comma separated list of child-collections to also include with the requested product. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeProductModelsReadProduct**](EnvelopeProductModelsReadProduct.md)

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

<a name="getproductitembyid"></a>
# **GetProductItemById**
> ProductProductItemEnvelope GetProductItemById (string itemId, int? productItemIdType = null)

Get a specific product item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetProductItemByIdExample
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

            var apiInstance = new ProductApi(config);
            var itemId = "itemId_example";  // string | The id of the product item to get.
            var productItemIdType = 0;  // int? | The type of product item id supplied in {itemId}. (optional) 

            try
            {
                // Get a specific product item
                ProductProductItemEnvelope result = apiInstance.GetProductItemById(itemId, productItemIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductItemById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductItemByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific product item
    ApiResponse<ProductProductItemEnvelope> response = apiInstance.GetProductItemByIdWithHttpInfo(itemId, productItemIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetProductItemByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **itemId** | **string** | The id of the product item to get. |  |
| **productItemIdType** | **int?** | The type of product item id supplied in {itemId}. | [optional]  |

### Return type

[**ProductProductItemEnvelope**](ProductProductItemEnvelope.md)

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

<a name="linkrelatedproductsbyrelationid"></a>
# **LinkRelatedProductsByRelationId**
> ProductModelsRelatedProductEnvelope LinkRelatedProductsByRelationId (string productId, int relationTypeId, List<ProductModelsWriteRelatedProduct> relatedProducts, int? productIdType = null)

Add related products to a product using a fixed relation type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LinkRelatedProductsByRelationIdExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the main product to which the relations will be created
            var relationTypeId = 56;  // int | The relation type id that will apply to all related products in {relatedProducts}
            var relatedProducts = new List<ProductModelsWriteRelatedProduct>(); // List<ProductModelsWriteRelatedProduct> | The list of related products to link with the main product.
            var productIdType = 0;  // int? | The type of product id for {productId} and supplied in {relatedProducts}. (optional) 

            try
            {
                // Add related products to a product using a fixed relation type
                ProductModelsRelatedProductEnvelope result = apiInstance.LinkRelatedProductsByRelationId(productId, relationTypeId, relatedProducts, productIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.LinkRelatedProductsByRelationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkRelatedProductsByRelationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add related products to a product using a fixed relation type
    ApiResponse<ProductModelsRelatedProductEnvelope> response = apiInstance.LinkRelatedProductsByRelationIdWithHttpInfo(productId, relationTypeId, relatedProducts, productIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.LinkRelatedProductsByRelationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the main product to which the relations will be created |  |
| **relationTypeId** | **int** | The relation type id that will apply to all related products in {relatedProducts} |  |
| **relatedProducts** | [**List&lt;ProductModelsWriteRelatedProduct&gt;**](ProductModelsWriteRelatedProduct.md) | The list of related products to link with the main product. |  |
| **productIdType** | **int?** | The type of product id for {productId} and supplied in {relatedProducts}. | [optional]  |

### Return type

[**ProductModelsRelatedProductEnvelope**](ProductModelsRelatedProductEnvelope.md)

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

<a name="listallproductitemspaged"></a>
# **ListAllProductItemsPaged**
> EnvelopeListProductModelsReadProductItem ListAllProductItemsPaged (int page)

Get all product items with pagination

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllProductItemsPagedExample
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

            var apiInstance = new ProductApi(config);
            var page = 56;  // int | The page to fetch

            try
            {
                // Get all product items with pagination
                EnvelopeListProductModelsReadProductItem result = apiInstance.ListAllProductItemsPaged(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListAllProductItemsPaged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllProductItemsPagedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all product items with pagination
    ApiResponse<EnvelopeListProductModelsReadProductItem> response = apiInstance.ListAllProductItemsPagedWithHttpInfo(page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListAllProductItemsPagedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | The page to fetch |  |

### Return type

[**EnvelopeListProductModelsReadProductItem**](EnvelopeListProductModelsReadProductItem.md)

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

<a name="listfeeds"></a>
# **ListFeeds**
> EnvelopeListProductModelsReadFeed ListFeeds ()

Gets a list of all feeds

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListFeedsExample
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

            var apiInstance = new ProductApi(config);

            try
            {
                // Gets a list of all feeds
                EnvelopeListProductModelsReadFeed result = apiInstance.ListFeeds();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListFeeds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFeedsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of all feeds
    ApiResponse<EnvelopeListProductModelsReadFeed> response = apiInstance.ListFeedsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListFeedsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EnvelopeListProductModelsReadFeed**](EnvelopeListProductModelsReadFeed.md)

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

<a name="listproductitems"></a>
# **ListProductItems**
> List&lt;ProductModelsReadProductItem&gt; ListProductItems ()

Get all product items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListProductItemsExample
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

            var apiInstance = new ProductApi(config);

            try
            {
                // Get all product items
                List<ProductModelsReadProductItem> result = apiInstance.ListProductItems();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListProductItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all product items
    ApiResponse<List<ProductModelsReadProductItem>> response = apiInstance.ListProductItemsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListProductItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ProductModelsReadProductItem&gt;**](ProductModelsReadProductItem.md)

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

<a name="listproductrelationtypes"></a>
# **ListProductRelationTypes**
> EnvelopeListProductModelsReadRelationType ListProductRelationTypes ()

Gets a list of product relation types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListProductRelationTypesExample
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

            var apiInstance = new ProductApi(config);

            try
            {
                // Gets a list of product relation types
                EnvelopeListProductModelsReadRelationType result = apiInstance.ListProductRelationTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ListProductRelationTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductRelationTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of product relation types
    ApiResponse<EnvelopeListProductModelsReadRelationType> response = apiInstance.ListProductRelationTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ListProductRelationTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EnvelopeListProductModelsReadRelationType**](EnvelopeListProductModelsReadRelationType.md)

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

<a name="queryproducts"></a>
# **QueryProducts**
> EnvelopeListProductModelsReadProduct QueryProducts (ProductModelsProductQuery query, string include = null)

Query products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryProductsExample
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

            var apiInstance = new ProductApi(config);
            var query = new ProductModelsProductQuery(); // ProductModelsProductQuery | The details of the query
            var include = "include_example";  // string | Comma separated list of child-collections to also include with the queried products. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Query products
                EnvelopeListProductModelsReadProduct result = apiInstance.QueryProducts(query, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.QueryProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query products
    ApiResponse<EnvelopeListProductModelsReadProduct> response = apiInstance.QueryProductsWithHttpInfo(query, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.QueryProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**ProductModelsProductQuery**](ProductModelsProductQuery.md) | The details of the query |  |
| **include** | **string** | Comma separated list of child-collections to also include with the queried products. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeListProductModelsReadProduct**](EnvelopeListProductModelsReadProduct.md)

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

<a name="queryproductspaged"></a>
# **QueryProductsPaged**
> EnvelopeListProductModelsReadProduct QueryProductsPaged (int page, ProductModelsProductQuery query, string include = null)

Query products with pagination

The {Product.Models.ProductQuery.BatchId} property is mandatory when fetching a page other than the first page.  If no BatchId is provided for the first page, a new batch is created and the BatchId can be found in the {Envelope.PageResult} field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryProductsPagedExample
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

            var apiInstance = new ProductApi(config);
            var page = 56;  // int | The page to fetch. To start a new batched query it is mandatory to send in page=1
            var query = new ProductModelsProductQuery(); // ProductModelsProductQuery | The details of the query
            var include = "include_example";  // string | Comma separated list of child-collections to also include with the queried products. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Query products with pagination
                EnvelopeListProductModelsReadProduct result = apiInstance.QueryProductsPaged(page, query, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.QueryProductsPaged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryProductsPagedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query products with pagination
    ApiResponse<EnvelopeListProductModelsReadProduct> response = apiInstance.QueryProductsPagedWithHttpInfo(page, query, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.QueryProductsPagedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | The page to fetch. To start a new batched query it is mandatory to send in page&#x3D;1 |  |
| **query** | [**ProductModelsProductQuery**](ProductModelsProductQuery.md) | The details of the query |  |
| **include** | **string** | Comma separated list of child-collections to also include with the queried products. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeListProductModelsReadProduct**](EnvelopeListProductModelsReadProduct.md)

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

<a name="querystock"></a>
# **QueryStock**
> List&lt;ProductModelsReadProductItemStock&gt; QueryStock (List<int> productItemIds)

Query stock

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryStockExample
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

            var apiInstance = new ProductApi(config);
            var productItemIds = new List<int>(); // List<int> | The details of the query.

            try
            {
                // Query stock
                List<ProductModelsReadProductItemStock> result = apiInstance.QueryStock(productItemIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.QueryStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query stock
    ApiResponse<List<ProductModelsReadProductItemStock>> response = apiInstance.QueryStockWithHttpInfo(productItemIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.QueryStockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productItemIds** | [**List&lt;int&gt;**](int.md) | The details of the query. |  |

### Return type

[**List&lt;ProductModelsReadProductItemStock&gt;**](ProductModelsReadProductItemStock.md)

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

<a name="updateproduct"></a>
# **UpdateProduct**
> EnvelopeProductModelsReadProduct UpdateProduct (string productId, ProductModelsWriteProduct product, int? productIdType = null, string include = null)

Updates a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateProductExample
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

            var apiInstance = new ProductApi(config);
            var productId = "productId_example";  // string | The id of the product to update.
            var product = new ProductModelsWriteProduct(); // ProductModelsWriteProduct | The product data to update.
            var productIdType = 0;  // int? | The type of product id supplied in {productId}. (optional) 
            var include = "include_example";  // string | Comma separated list of child-collections to also include with the updated product. See  {Product.Models.ProductIncludes} names for valid options. (optional) 

            try
            {
                // Updates a product
                EnvelopeProductModelsReadProduct result = apiInstance.UpdateProduct(productId, product, productIdType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a product
    ApiResponse<EnvelopeProductModelsReadProduct> response = apiInstance.UpdateProductWithHttpInfo(productId, product, productIdType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The id of the product to update. |  |
| **product** | [**ProductModelsWriteProduct**](ProductModelsWriteProduct.md) | The product data to update. |  |
| **productIdType** | **int?** | The type of product id supplied in {productId}. | [optional]  |
| **include** | **string** | Comma separated list of child-collections to also include with the updated product. See  {Product.Models.ProductIncludes} names for valid options. | [optional]  |

### Return type

[**EnvelopeProductModelsReadProduct**](EnvelopeProductModelsReadProduct.md)

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

<a name="updateproductitem"></a>
# **UpdateProductItem**
> EnvelopeProductModelsReadProductItem UpdateProductItem (string itemId, ProductModelsWriteProductItem productItem, int? productItemIdType = null)

Updates a product item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateProductItemExample
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

            var apiInstance = new ProductApi(config);
            var itemId = "itemId_example";  // string | The id of the product item to update.
            var productItem = new ProductModelsWriteProductItem(); // ProductModelsWriteProductItem | The product item data to update.
            var productItemIdType = 0;  // int? | The type of product item id supplied in {itemId}. (optional) 

            try
            {
                // Updates a product item
                EnvelopeProductModelsReadProductItem result = apiInstance.UpdateProductItem(itemId, productItem, productItemIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a product item
    ApiResponse<EnvelopeProductModelsReadProductItem> response = apiInstance.UpdateProductItemWithHttpInfo(itemId, productItem, productItemIdType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.UpdateProductItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **itemId** | **string** | The id of the product item to update. |  |
| **productItem** | [**ProductModelsWriteProductItem**](ProductModelsWriteProductItem.md) | The product item data to update. |  |
| **productItemIdType** | **int?** | The type of product item id supplied in {itemId}. | [optional]  |

### Return type

[**EnvelopeProductModelsReadProductItem**](EnvelopeProductModelsReadProductItem.md)

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

