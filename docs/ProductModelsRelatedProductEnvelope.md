# Org.OpenAPITools.Model.ProductModelsRelatedProductEnvelope
The response of a related products request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Information about the outcome of the request. | [optional] 
**Invalid** | [**List&lt;ProductModelsWriteRelatedProduct&gt;**](ProductModelsWriteRelatedProduct.md) | Supplied relatedProducts that failed validation. | [optional] 
**NotFound** | [**List&lt;ProductModelsWriteRelatedProduct&gt;**](ProductModelsWriteRelatedProduct.md) | Supplied relatedProducts that were technically valid, but couldn&#39;t be found. | [optional] 
**UpdateCount** | **int** | Number of related product updates resulting from the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

