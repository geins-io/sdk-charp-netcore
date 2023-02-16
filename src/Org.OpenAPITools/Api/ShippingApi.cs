/*
 * Geins Management API
 *
 *  Geins Management API is an RESTful api to power your applications who manages your geins services. Geins provides an easy-to-use and scalable solution for managing all aspects of an online store, from product listings and customer information to order processing and payment transactions.   :::tip With this API, you can build custom applications and integrate with third-party systems, dashboards and other bussiness logic apps. :::    ## Getting started Once you have created an account, you can start using the Management API by creating an `API key`. You can create as many API keys as you need. Each `API key` is connected to a specific account so you can keep track of operations and manage keys. You can find your `API key` in the `geins merchant center`.   ### Fast track Use one of our [SDKs](https://docs.geins.io/docs/sdk/introduction) to get started quickly. The SDKs are available for the most popular programming languages and frameworks.  Or, if you prefer to just take it for a test run:  [![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25895885-aaf6598f-1a7c-4949-85d7-ba846c42d553?action=collection%2Ffork&collection-url=entityId%3D25895885-aaf6598f-1a7c-4949-85d7-ba846c42d553%26entityType%3Dcollection%26workspaceId%3Da2a179ce-158e-46b0-8d06-e9640f45112c)  ### Authentication Two authentication methods are supported:   - `API Key`   - `Basic Auth` 
 *
 * The version of the OpenAPI document: v1.7
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShippingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new parcel group
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EnvelopeInt</returns>
        EnvelopeInt CreateParcelGroup(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0);

        /// <summary>
        /// Create a new parcel group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EnvelopeInt</returns>
        ApiResponse<EnvelopeInt> CreateParcelGroupWithHttpInfo(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0);
        /// <summary>
        /// Query shipping options
        /// </summary>
        /// <remarks>
        /// No response envelope.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShippingModelsShippingOption&gt;</returns>
        List<ShippingModelsShippingOption> QueryShippingOptions(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0);

        /// <summary>
        /// Query shipping options
        /// </summary>
        /// <remarks>
        /// No response envelope.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShippingModelsShippingOption&gt;</returns>
        ApiResponse<List<ShippingModelsShippingOption>> QueryShippingOptionsWithHttpInfo(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShippingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new parcel group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EnvelopeInt</returns>
        System.Threading.Tasks.Task<EnvelopeInt> CreateParcelGroupAsync(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a new parcel group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EnvelopeInt)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeInt>> CreateParcelGroupWithHttpInfoAsync(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Query shipping options
        /// </summary>
        /// <remarks>
        /// No response envelope.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShippingModelsShippingOption&gt;</returns>
        System.Threading.Tasks.Task<List<ShippingModelsShippingOption>> QueryShippingOptionsAsync(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Query shipping options
        /// </summary>
        /// <remarks>
        /// No response envelope.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShippingModelsShippingOption&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ShippingModelsShippingOption>>> QueryShippingOptionsWithHttpInfoAsync(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShippingApi : IShippingApiSync, IShippingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShippingApi : IShippingApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShippingApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ShippingApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a new parcel group 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EnvelopeInt</returns>
        public EnvelopeInt CreateParcelGroup(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<EnvelopeInt> localVarResponse = CreateParcelGroupWithHttpInfo(parcelGroupOptions);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new parcel group 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EnvelopeInt</returns>
        public Org.OpenAPITools.Client.ApiResponse<EnvelopeInt> CreateParcelGroupWithHttpInfo(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0)
        {
            // verify the required parameter 'parcelGroupOptions' is set
            if (parcelGroupOptions == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'parcelGroupOptions' when calling ShippingApi->CreateParcelGroup");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = parcelGroupOptions;

            localVarRequestOptions.Operation = "ShippingApi.CreateParcelGroup";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-apikey")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-apikey", this.Configuration.GetApiKeyWithPrefix("x-apikey"));
            }
            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Org.OpenAPITools.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<EnvelopeInt>("/API/Shipping/ParcelGroup", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateParcelGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new parcel group 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EnvelopeInt</returns>
        public async System.Threading.Tasks.Task<EnvelopeInt> CreateParcelGroupAsync(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<EnvelopeInt> localVarResponse = await CreateParcelGroupWithHttpInfoAsync(parcelGroupOptions, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new parcel group 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelGroupOptions">Options for the new parcel group.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EnvelopeInt)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<EnvelopeInt>> CreateParcelGroupWithHttpInfoAsync(ShippingModelsParcelGroupOptions parcelGroupOptions, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'parcelGroupOptions' is set
            if (parcelGroupOptions == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'parcelGroupOptions' when calling ShippingApi->CreateParcelGroup");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = parcelGroupOptions;

            localVarRequestOptions.Operation = "ShippingApi.CreateParcelGroup";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-apikey")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-apikey", this.Configuration.GetApiKeyWithPrefix("x-apikey"));
            }
            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Org.OpenAPITools.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<EnvelopeInt>("/API/Shipping/ParcelGroup", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateParcelGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Query shipping options No response envelope.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShippingModelsShippingOption&gt;</returns>
        public List<ShippingModelsShippingOption> QueryShippingOptions(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<List<ShippingModelsShippingOption>> localVarResponse = QueryShippingOptionsWithHttpInfo(shippingQuery);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Query shipping options No response envelope.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShippingModelsShippingOption&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<ShippingModelsShippingOption>> QueryShippingOptionsWithHttpInfo(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0)
        {
            // verify the required parameter 'shippingQuery' is set
            if (shippingQuery == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'shippingQuery' when calling ShippingApi->QueryShippingOptions");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = shippingQuery;

            localVarRequestOptions.Operation = "ShippingApi.QueryShippingOptions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-apikey")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-apikey", this.Configuration.GetApiKeyWithPrefix("x-apikey"));
            }
            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Org.OpenAPITools.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<List<ShippingModelsShippingOption>>("/API/Shipping/Query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("QueryShippingOptions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Query shipping options No response envelope.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShippingModelsShippingOption&gt;</returns>
        public async System.Threading.Tasks.Task<List<ShippingModelsShippingOption>> QueryShippingOptionsAsync(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<ShippingModelsShippingOption>> localVarResponse = await QueryShippingOptionsWithHttpInfoAsync(shippingQuery, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Query shipping options No response envelope.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingQuery">The query to filter shipping options by.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShippingModelsShippingOption&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<ShippingModelsShippingOption>>> QueryShippingOptionsWithHttpInfoAsync(ShippingModelsShippingQuery shippingQuery, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'shippingQuery' is set
            if (shippingQuery == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'shippingQuery' when calling ShippingApi->QueryShippingOptions");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = shippingQuery;

            localVarRequestOptions.Operation = "ShippingApi.QueryShippingOptions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-apikey")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-apikey", this.Configuration.GetApiKeyWithPrefix("x-apikey"));
            }
            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Org.OpenAPITools.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<List<ShippingModelsShippingOption>>("/API/Shipping/Query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("QueryShippingOptions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
