# Org.OpenAPITools.Model.ProductModelsStockEnvelope
The response of a Stock request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Information about the outcome of the request. | [optional] 
**Invalid** | [**List&lt;ProductModelsWriteProductItemStock&gt;**](ProductModelsWriteProductItemStock.md) | Supplied productItemStocks that failed validation. | [optional] 
**NotFound** | [**List&lt;ProductModelsWriteProductItemStock&gt;**](ProductModelsWriteProductItemStock.md) | Supplied productItemStocks that were technically valid, but couldn&#39;t be found. | [optional] 
**UpdateCount** | **int** | Number of stock updates resulting from the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

