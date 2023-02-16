# Org.OpenAPITools.Model.ProductModelsReadProduct
A product.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **int** | The unique identifier for the product. | [optional] 
**ArticleNumber** | **string** | The article number of the product. | [optional] 
**Names** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | The localized names of the product. | [optional] 
**DateCreated** | **DateTime** | The date the product was created. | [optional] 
**DateUpdated** | **DateTime** | The date the product was last updated. | [optional] 
**Active** | **bool** | The current state of the product. | [optional] 
**PurchasePrice** | **double** | The purchase price in the currency defined in {Product.Models.Read.Product.PurchasePriceCurrency}. | [optional] 
**PurchasePriceCurrency** | **string** | The 3-letter ISO 4217 currency code for the amount given in {Product.Models.Read.Product.PurchasePrice}. | [optional] 
**ShortTexts** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | Localized short texts for the product. | [optional] 
**LongTexts** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | Localized long texts for the product. | [optional] 
**TechTexts** | [**List&lt;SharedModelsLocalizableContent&gt;**](SharedModelsLocalizableContent.md) | Localized tech texts for the product. | [optional] 
**Items** | [**List&lt;ProductModelsReadProductItem&gt;**](ProductModelsReadProductItem.md) | The items belonging to the product. | [optional] 
**Prices** | [**List&lt;PriceListModelsReadPriceListPrice&gt;**](PriceListModelsReadPriceListPrice.md) | The current prices of the product. | [optional] 
**Categories** | [**List&lt;CategoryModelsReadCategory&gt;**](CategoryModelsReadCategory.md) | The categories the product belongs to. | [optional] 
**Images** | [**List&lt;ProductModelsReadImage&gt;**](ProductModelsReadImage.md) | The images for the product | [optional] 
**BrandId** | **int** | The brand id of the product. | [optional] 
**BrandName** | **string** | The brand name of the product. | [optional] 
**SupplierId** | **int** | The supplier id of the product. | [optional] 
**SupplierName** | **string** | The supplier name of the product. | [optional] 
**ParameterValues** | [**List&lt;ProductParameterModelsReadProductParameterValue&gt;**](ProductParameterModelsReadProductParameterValue.md) | The parameter values associated with the product. | [optional] 
**Variants** | [**List&lt;VariantModelsReadVariant&gt;**](VariantModelsReadVariant.md) | The variants for this product. | [optional] 
**Markets** | [**List&lt;MarketModelsMarket&gt;**](MarketModelsMarket.md) | The markets for this product | [optional] 
**Vat** | **double** | The vat percent for this product. Eg) 0.25 meaning 25% VAT. | [optional] 
**PrimaryImage** | **string** | The filename of this products primary image. | [optional] 
**FreightClassId** | **int** | ID of freight class | [optional] 
**IntrastatCode** | **string** | Intrastat code of the product | [optional] 
**CountryOfOrigin** | **string** | Country of orgin of product | [optional] 
**VariantGroupId** | **int** | ID of Variant Group to which the product is associated | [optional] 
**VatId** | **int** | ID of Vat | [optional] 
**ExternalId** | **string** | External Id of the product. | [optional] 
**ActivationDate** | **DateTime** | Activation date for the product. | [optional] 
**Feeds** | [**List&lt;ProductModelsReadFeedMembership&gt;**](ProductModelsReadFeedMembership.md) | The feeds the product is a member of | [optional] 
**Urls** | [**List&lt;ProductModelsReadProductUrl&gt;**](ProductModelsReadProductUrl.md) | All canonical urls for the product | [optional] 
**MainCategoryId** | **int** | The main category id for the product. | [optional] 
**RelatedProducts** | [**List&lt;ProductModelsReadRelatedProduct&gt;**](ProductModelsReadRelatedProduct.md) | The related products for the product. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

