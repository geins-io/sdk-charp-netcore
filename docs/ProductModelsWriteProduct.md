# Org.OpenAPITools.Model.ProductModelsWriteProduct
A product.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArticleNumber** | **string** | The article number of the product. | [optional] 
**Names** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | The localized names of the product. | [optional] 
**Active** | **bool** | The current state of the product. | [optional] 
**PurchasePrice** | **double** | The purchase price in the currency defined in {Product.Models.Write.Product.PurchasePriceCurrency}. | [optional] 
**PurchasePriceCurrency** | **string** | The 3-letter ISO 4217 currency code for the amount given in {Product.Models.Write.Product.PurchasePrice}. | [optional] 
**ShortTexts** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | Localized short texts for the product. | [optional] 
**LongTexts** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | Localized long texts for the product. | [optional] 
**TechTexts** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | Localized tech texts for the product. | [optional] 
**BrandId** | **int** | The brand of the product. | [optional] 
**SupplierId** | **int** | The supplier id of the product. | [optional] 
**Items** | [**List&lt;ProductModelsWriteProductItem&gt;**](ProductModelsWriteProductItem.md) | The items belonging to the product. | [optional] 
**CategoryIds** | **List&lt;int&gt;** | The category ids the product belongs to. | [optional] 
**ParameterValues** | [**List&lt;ProductParameterModelsWriteProductParameterValue&gt;**](ProductParameterModelsWriteProductParameterValue.md) | The parameter values associated with the product. | [optional] 
**Variants** | [**List&lt;VariantModelsWriteVariant&gt;**](VariantModelsWriteVariant.md) | The variants for this product. | [optional] 
**Markets** | [**List&lt;MarketModelsMarket&gt;**](MarketModelsMarket.md) | The markets for this product | [optional] 
**FreightClassId** | **int** | ID of freight class | [optional] 
**IntrastatCode** | **string** | Intrastat code of the product | [optional] 
**CountryOfOrigin** | **string** | Country of orgin of product | [optional] 
**VariantGroupId** | **int** | ID of Variant Group to whom the product should be associated | [optional] 
**Vat** | **int** | ID or rate of VAT (On create and if no VAT is provided then default VAT will be used) | [optional] 
**VatType** | **string** | Defines how VAT parameter should be interpreted  Actual &#x3D; VAT parameter is interpreted as VAT rate  VatId &#x3D; VAT parameter is interpreted as VAT Id | [optional] 
**ExternalId** | **string** | External Id of the product. | [optional] 
**ActivationDate** | **DateTime** | Activation date for the product. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

