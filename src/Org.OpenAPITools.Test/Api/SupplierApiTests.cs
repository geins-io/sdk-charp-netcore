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
    ///  Class for testing SupplierApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SupplierApiTests : IDisposable
    {
        private SupplierApi instance;

        public SupplierApiTests()
        {
            instance = new SupplierApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SupplierApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SupplierApi
            //Assert.IsType<SupplierApi>(instance);
        }

        /// <summary>
        /// Test CreateSupplier
        /// </summary>
        [Fact]
        public void CreateSupplierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SupplierModelsWriteSupplier supplier = null;
            //var response = instance.CreateSupplier(supplier);
            //Assert.IsType<EnvelopeSupplierModelsReadSupplier>(response);
        }

        /// <summary>
        /// Test GetSupplierById
        /// </summary>
        [Fact]
        public void GetSupplierByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetSupplierById(id);
            //Assert.IsType<EnvelopeSupplierModelsReadSupplier>(response);
        }

        /// <summary>
        /// Test QuerySuppliers
        /// </summary>
        [Fact]
        public void QuerySuppliersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SupplierModelsSupplierQuery query = null;
            //var response = instance.QuerySuppliers(query);
            //Assert.IsType<List<SupplierModelsReadSupplier>>(response);
        }

        /// <summary>
        /// Test UpdateSupplier
        /// </summary>
        [Fact]
        public void UpdateSupplierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SupplierModelsWriteSupplier supplier = null;
            //var response = instance.UpdateSupplier(id, supplier);
            //Assert.IsType<EnvelopeSupplierModelsReadSupplier>(response);
        }
    }
}
