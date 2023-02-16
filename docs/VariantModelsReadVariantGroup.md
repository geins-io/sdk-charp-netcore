# Org.OpenAPITools.Model.VariantModelsReadVariantGroup
A variant group for a collection of related variants.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **int** | The id of variant goup. | [optional] 
**Name** | **string** | The optional internal name of the variant group. | [optional] 
**CollapseInLists** | **bool** | Determine visibility of non-main products of this group in lists. | [optional] 
**MainProductId** | **int** | The main product of this group. If the group is collapsed in lists, this will be the only visible product. | [optional] 
**ProductIds** | **List&lt;int&gt;** | The product ids of the variants that belong to this group. | [optional] 
**Products** | [**List&lt;ProductModelsReadProduct&gt;**](ProductModelsReadProduct.md) | Products belonging to the Variant group. Only included when parameter \&quot;include\&quot; is supplied in the query string | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

