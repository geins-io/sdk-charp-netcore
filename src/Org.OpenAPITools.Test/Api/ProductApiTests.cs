/*
 * Geins Management API
 *
 *  Geins Management API is an RESTful api to power your applications who manages your geins services. Geins provides an easy-to-use and scalable solution for managing all aspects of an online store, from product listings and customer information to order processing and payment transactions.   :::tip With this API, you can build custom applications and integrate with third-party systems, dashboards and other bussiness logic apps. :::    ## Getting started Once you have created an account, you can start using the Management API by creating an `API key`. You can create as many API keys as you need. Each `API key` is connected to a specific account so you can keep track of operations and manage keys. You can find your `API key` in the `geins merchant center`.   ### Fast track Use one of our [SDKs](https://docs.geins.io/docs/sdk/introduction) to get started quickly. The SDKs are available for the most popular programming languages and frameworks.  Or, if you prefer to just take it for a test run:  [![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25895885-aaf6598f-1a7c-4949-85d7-ba846c42d553?action=collection%2Ffork&collection-url=entityId%3D25895885-aaf6598f-1a7c-4949-85d7-ba846c42d553%26entityType%3Dcollection%26workspaceId%3Da2a179ce-158e-46b0-8d06-e9640f45112c)  ### Authentication Two authentication methods are supported:   - `API Key`   - `Basic Auth` 
 *
 * The version of the OpenAPI document: v1.7
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing ProductApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductApiTests : IDisposable
    {
        private ProductApi instance;

        public ProductApiTests()
        {
            instance = new ProductApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductApi
            //Assert.IsType<ProductApi>(instance);
        }

        /// <summary>
        /// Test AddAvailabilityMonitor
        /// </summary>
        [Fact]
        public void AddAvailabilityMonitorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductModelsMonitorSku model = null;
            //var response = instance.AddAvailabilityMonitor(model);
            //Assert.IsType<Envelope>(response);
        }

        /// <summary>
        /// Test AddCategoryToProduct
        /// </summary>
        [Fact]
        public void AddCategoryToProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //ProductModelsProductCategory productCategory = null;
            //int? productIdType = null;
            //var response = instance.AddCategoryToProduct(productId, productCategory, productIdType);
            //Assert.IsType<Envelope>(response);
        }

        /// <summary>
        /// Test AddImageToProduct
        /// </summary>
        [Fact]
        public void AddImageToProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string imageName = null;
            //bool? isPrimaryImage = null;
            //int? productIdType = null;
            //var response = instance.AddImageToProduct(productId, imageName, isPrimaryImage, productIdType);
            //Assert.IsType<Envelope>(response);
        }

        /// <summary>
        /// Test AddRelatedProductsToProduct
        /// </summary>
        [Fact]
        public void AddRelatedProductsToProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //List<ProductModelsWriteRelatedProduct> relatedProducts = null;
            //int? productIdType = null;
            //var response = instance.AddRelatedProductsToProduct(productId, relatedProducts, productIdType);
            //Assert.IsType<ProductModelsRelatedProductEnvelope>(response);
        }

        /// <summary>
        /// Test BatchUpdateProductItems
        /// </summary>
        [Fact]
        public void BatchUpdateProductItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ProductModelsWriteProductItem> productItems = null;
            //int? productItemIdType = null;
            //var response = instance.BatchUpdateProductItems(productItems, productItemIdType);
            //Assert.IsType<Envelope>(response);
        }

        /// <summary>
        /// Test BatchUpdateStockValues
        /// </summary>
        [Fact]
        public void BatchUpdateStockValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ProductModelsWriteProductItemStock> productItemStocks = null;
            //int? productItemIdType = null;
            //var response = instance.BatchUpdateStockValues(productItemStocks, productItemIdType);
            //Assert.IsType<ProductModelsStockEnvelope>(response);
        }

        /// <summary>
        /// Test CreateProduct
        /// </summary>
        [Fact]
        public void CreateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductModelsWriteProduct product = null;
            //string include = null;
            //var response = instance.CreateProduct(product, include);
            //Assert.IsType<EnvelopeProductModelsReadProduct>(response);
        }

        /// <summary>
        /// Test CreateProductItems
        /// </summary>
        [Fact]
        public void CreateProductItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //ProductModelsWriteProductItem productItem = null;
            //int? productIdType = null;
            //var response = instance.CreateProductItems(productId, productItem, productIdType);
            //Assert.IsType<EnvelopeProductModelsReadProductItem>(response);
        }

        /// <summary>
        /// Test GetProductById
        /// </summary>
        [Fact]
        public void GetProductByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //int? productIdType = null;
            //string include = null;
            //var response = instance.GetProductById(productId, productIdType, include);
            //Assert.IsType<EnvelopeProductModelsReadProduct>(response);
        }

        /// <summary>
        /// Test GetProductItemById
        /// </summary>
        [Fact]
        public void GetProductItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //int? productItemIdType = null;
            //var response = instance.GetProductItemById(itemId, productItemIdType);
            //Assert.IsType<ProductProductItemEnvelope>(response);
        }

        /// <summary>
        /// Test LinkRelatedProductsByRelationId
        /// </summary>
        [Fact]
        public void LinkRelatedProductsByRelationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //int relationTypeId = null;
            //List<ProductModelsWriteRelatedProduct> relatedProducts = null;
            //int? productIdType = null;
            //var response = instance.LinkRelatedProductsByRelationId(productId, relationTypeId, relatedProducts, productIdType);
            //Assert.IsType<ProductModelsRelatedProductEnvelope>(response);
        }

        /// <summary>
        /// Test ListAllProductItemsPaged
        /// </summary>
        [Fact]
        public void ListAllProductItemsPagedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int page = null;
            //var response = instance.ListAllProductItemsPaged(page);
            //Assert.IsType<EnvelopeListProductModelsReadProductItem>(response);
        }

        /// <summary>
        /// Test ListFeeds
        /// </summary>
        [Fact]
        public void ListFeedsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListFeeds();
            //Assert.IsType<EnvelopeListProductModelsReadFeed>(response);
        }

        /// <summary>
        /// Test ListProductItems
        /// </summary>
        [Fact]
        public void ListProductItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListProductItems();
            //Assert.IsType<List<ProductModelsReadProductItem>>(response);
        }

        /// <summary>
        /// Test ListProductRelationTypes
        /// </summary>
        [Fact]
        public void ListProductRelationTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListProductRelationTypes();
            //Assert.IsType<EnvelopeListProductModelsReadRelationType>(response);
        }

        /// <summary>
        /// Test QueryProducts
        /// </summary>
        [Fact]
        public void QueryProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductModelsProductQuery query = null;
            //string include = null;
            //var response = instance.QueryProducts(query, include);
            //Assert.IsType<EnvelopeListProductModelsReadProduct>(response);
        }

        /// <summary>
        /// Test QueryProductsPaged
        /// </summary>
        [Fact]
        public void QueryProductsPagedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int page = null;
            //ProductModelsProductQuery query = null;
            //string include = null;
            //var response = instance.QueryProductsPaged(page, query, include);
            //Assert.IsType<EnvelopeListProductModelsReadProduct>(response);
        }

        /// <summary>
        /// Test QueryStock
        /// </summary>
        [Fact]
        public void QueryStockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int> productItemIds = null;
            //var response = instance.QueryStock(productItemIds);
            //Assert.IsType<List<ProductModelsReadProductItemStock>>(response);
        }

        /// <summary>
        /// Test UpdateProduct
        /// </summary>
        [Fact]
        public void UpdateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //ProductModelsWriteProduct product = null;
            //int? productIdType = null;
            //string include = null;
            //var response = instance.UpdateProduct(productId, product, productIdType, include);
            //Assert.IsType<EnvelopeProductModelsReadProduct>(response);
        }

        /// <summary>
        /// Test UpdateProductItem
        /// </summary>
        [Fact]
        public void UpdateProductItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //ProductModelsWriteProductItem productItem = null;
            //int? productItemIdType = null;
            //var response = instance.UpdateProductItem(itemId, productItem, productItemIdType);
            //Assert.IsType<EnvelopeProductModelsReadProductItem>(response);
        }
    }
}
