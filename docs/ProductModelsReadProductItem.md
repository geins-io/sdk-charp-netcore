# Org.OpenAPITools.Model.ProductModelsReadProductItem
A product item belonging to a product.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **int** | The product item id. | [optional] 
**ArticleNumber** | **string** | The article number for the product item. | [optional] 
**ProductId** | **int** | The id of the product that the item belongs to. | [optional] 
**Name** | **string** | The name of the product item. | [optional] 
**Shelf** | **string** | The shelf name where the product item can be found. | [optional] 
**Weight** | **int** | The weight of the item in grams (g). | [optional] 
**Length** | **int** | The length of the item in millimeters (mm). | [optional] 
**Width** | **int** | The width of the item in millimeters (mm). | [optional] 
**Height** | **int** | The height of the item in millimeters (mm). | [optional] 
**Gtin** | **string** | The GTIN number for the item. | [optional] 
**DateCreated** | **DateTime** | The date the item was created. | [optional] 
**DateUpdated** | **DateTime** | The date the item was last updated. | [optional] 
**Active** | **bool** | The current state of the item. | [optional] 
**ExternalId** | **string** | External Id of the product item. | [optional] 
**Stock** | [**ProductModelsReadProductItemStock**](ProductModelsReadProductItemStock.md) |  | [optional] 
**ShippingFees** | [**List&lt;ProductModelsReadShippingFee&gt;**](ProductModelsReadShippingFee.md) | The lowest shipping fees for each market and country for the product item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

