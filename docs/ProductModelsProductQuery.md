# Org.OpenAPITools.Model.ProductModelsProductQuery
A prroduct query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpdatedAfter** | **DateTime** | Limits query to products updated after the specified date. | [optional] 
**ProductIds** | **List&lt;int&gt;** | Limits query to only include the supplied product ids. | [optional] 
**ArticleNumbers** | **List&lt;string&gt;** | Limits query to only include products with supplied article numbers. | [optional] 
**OnlySellable** | **bool** | Limits query to only include products that are available for purchase | [optional] 
**FeedId** | **int** | Limits query to only include products contained in the specified feed. | [optional] 
**BatchId** | **Guid** | Used to fetch products where the result set is split into batches | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

