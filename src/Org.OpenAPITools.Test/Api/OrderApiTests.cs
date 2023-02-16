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
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrderApiTests : IDisposable
    {
        private OrderApi instance;

        public OrderApiTests()
        {
            instance = new OrderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrderApi
            //Assert.IsType<OrderApi>(instance);
        }

        /// <summary>
        /// Test AddCommentToOrder
        /// </summary>
        [Fact]
        public void AddCommentToOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //APIOrderOrderComment orderComment = null;
            //var response = instance.AddCommentToOrder(id, orderComment);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateOrder
        /// </summary>
        [Fact]
        public void CreateOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderModelsOrder order = null;
            //var response = instance.CreateOrder(order);
            //Assert.IsType<EnvelopeInt>(response);
        }

        /// <summary>
        /// Test CreateOrderId
        /// </summary>
        [Fact]
        public void CreateOrderIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateOrderId();
            //Assert.IsType<EnvelopeInt>(response);
        }

        /// <summary>
        /// Test DeleteOrder
        /// </summary>
        [Fact]
        public void DeleteOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int operation = null;
            //var response = instance.DeleteOrder(id, operation);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetCaptureById
        /// </summary>
        [Fact]
        public void GetCaptureByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid captureId = null;
            //var response = instance.GetCaptureById(captureId);
            //Assert.IsType<OrderCapture>(response);
        }

        /// <summary>
        /// Test GetOrderById
        /// </summary>
        [Fact]
        public void GetOrderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string include = null;
            //bool? combineProductContainerRows = null;
            //var response = instance.GetOrderById(id, include, combineProductContainerRows);
            //Assert.IsType<OrderModelsOrder>(response);
        }

        /// <summary>
        /// Test GetOrderStatuses
        /// </summary>
        [Fact]
        public void GetOrderStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetOrderStatuses();
            //Assert.IsType<List<OrderModelsOrderStatus>>(response);
        }

        /// <summary>
        /// Test GetRefundById
        /// </summary>
        [Fact]
        public void GetRefundByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid refundId = null;
            //var response = instance.GetRefundById(refundId);
            //Assert.IsType<OrderRefund>(response);
        }

        /// <summary>
        /// Test PartialUpdateOfOrder
        /// </summary>
        [Fact]
        public void PartialUpdateOfOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //OrderModelsOrderUpdate order = null;
            //var response = instance.PartialUpdateOfOrder(id, order);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test QueryOrders
        /// </summary>
        [Fact]
        public void QueryOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderModelsOrderQuery query = null;
            //var response = instance.QueryOrders(query);
            //Assert.IsType<List<OrderModelsOrder>>(response);
        }

        /// <summary>
        /// Test SetCaptureAsProcessed
        /// </summary>
        [Fact]
        public void SetCaptureAsProcessedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderProcessedCapture processedCapture = null;
            //var response = instance.SetCaptureAsProcessed(processedCapture);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SetPaymentAsPayed
        /// </summary>
        [Fact]
        public void SetPaymentAsPayedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int paymentDetailId = null;
            //var response = instance.SetPaymentAsPayed(paymentDetailId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SetRefundAsProcessed
        /// </summary>
        [Fact]
        public void SetRefundAsProcessedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderProcessedRefund processedRefund = null;
            //var response = instance.SetRefundAsProcessed(processedRefund);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateOrderStatus
        /// </summary>
        [Fact]
        public void UpdateOrderStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int status = null;
            //string transactionId = null;
            //string secondaryTransactionId = null;
            //var response = instance.UpdateOrderStatus(id, status, transactionId, secondaryTransactionId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateTransactionData
        /// </summary>
        [Fact]
        public void UpdateTransactionDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //APIOrderTransactionData transactionData = null;
            //var response = instance.UpdateTransactionData(id, transactionData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ValidateOrder
        /// </summary>
        [Fact]
        public void ValidateOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderValidateOrderCreationRequest request = null;
            //var response = instance.ValidateOrder(request);
            //Assert.IsType<Object>(response);
        }
    }
}
