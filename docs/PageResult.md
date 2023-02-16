# Org.OpenAPITools.Model.PageResult
Contains pagination information for paged operations, i.e. PageSize and PageCount.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchId** | **Guid** | The id of the batch operation. If this property has a value for the first fetched page it has to be passed as a parameter for all subsequent requests- | [optional] 
**Page** | **int** | The current page | [optional] 
**RowCount** | **int** | Total number of rows | [optional] 
**PageCount** | **int** | Total number of pages | [optional] 
**PageSize** | **int** | Page size | [optional] 
**HasMoreRows** | **bool** | True if there is more content to fetch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

