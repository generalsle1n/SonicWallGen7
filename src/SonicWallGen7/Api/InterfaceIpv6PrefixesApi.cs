/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SonicWallGen7.Client;
using SonicWallGen7.Model;

namespace SonicWallGen7.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInterfaceIpv6PrefixesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InterfaceIpv6PrefixesCollection</returns>
        InterfaceIpv6PrefixesCollection InterfacesIpv6PrefixesGet(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InterfaceIpv6PrefixesCollection</returns>
        ApiResponse<InterfaceIpv6PrefixesCollection> InterfacesIpv6PrefixesGetWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Patch IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        ApiStatus InterfacesIpv6PrefixesPatch(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Patch IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        ApiResponse<ApiStatus> InterfacesIpv6PrefixesPatchWithHttpInfo(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Edit IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        ApiStatus InterfacesIpv6PrefixesPut(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Edit IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        ApiResponse<ApiStatus> InterfacesIpv6PrefixesPutWithHttpInfo(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInterfaceIpv6PrefixesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InterfaceIpv6PrefixesCollection</returns>
        System.Threading.Tasks.Task<InterfaceIpv6PrefixesCollection> InterfacesIpv6PrefixesGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InterfaceIpv6PrefixesCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<InterfaceIpv6PrefixesCollection>> InterfacesIpv6PrefixesGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Patch IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        System.Threading.Tasks.Task<ApiStatus> InterfacesIpv6PrefixesPatchAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Patch IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiStatus>> InterfacesIpv6PrefixesPatchWithHttpInfoAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Edit IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        System.Threading.Tasks.Task<ApiStatus> InterfacesIpv6PrefixesPutAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Edit IPv6 interface prefixes configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiStatus>> InterfacesIpv6PrefixesPutWithHttpInfoAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInterfaceIpv6PrefixesApi : IInterfaceIpv6PrefixesApiSync, IInterfaceIpv6PrefixesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InterfaceIpv6PrefixesApi : IInterfaceIpv6PrefixesApi
    {
        private SonicWallGen7.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InterfaceIpv6PrefixesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InterfaceIpv6PrefixesApi(string basePath)
        {
            this.Configuration = SonicWallGen7.Client.Configuration.MergeConfigurations(
                SonicWallGen7.Client.GlobalConfiguration.Instance,
                new SonicWallGen7.Client.Configuration { BasePath = basePath }
            );
            this.Client = new SonicWallGen7.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SonicWallGen7.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = SonicWallGen7.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InterfaceIpv6PrefixesApi(SonicWallGen7.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SonicWallGen7.Client.Configuration.MergeConfigurations(
                SonicWallGen7.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new SonicWallGen7.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SonicWallGen7.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = SonicWallGen7.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InterfaceIpv6PrefixesApi(SonicWallGen7.Client.ISynchronousClient client, SonicWallGen7.Client.IAsynchronousClient asyncClient, SonicWallGen7.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SonicWallGen7.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SonicWallGen7.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SonicWallGen7.Client.ISynchronousClient Client { get; set; }

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
        public SonicWallGen7.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SonicWallGen7.Client.ExceptionFactory ExceptionFactory
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
        ///  Retrieve IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InterfaceIpv6PrefixesCollection</returns>
        public InterfaceIpv6PrefixesCollection InterfacesIpv6PrefixesGet(int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<InterfaceIpv6PrefixesCollection> localVarResponse = InterfacesIpv6PrefixesGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InterfaceIpv6PrefixesCollection</returns>
        public SonicWallGen7.Client.ApiResponse<InterfaceIpv6PrefixesCollection> InterfacesIpv6PrefixesGetWithHttpInfo(int operationIndex = 0)
        {
            SonicWallGen7.Client.RequestOptions localVarRequestOptions = new SonicWallGen7.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SonicWallGen7.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SonicWallGen7.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<InterfaceIpv6PrefixesCollection>("/interfaces/ipv6/prefixes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfacesIpv6PrefixesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieve IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InterfaceIpv6PrefixesCollection</returns>
        public async System.Threading.Tasks.Task<InterfaceIpv6PrefixesCollection> InterfacesIpv6PrefixesGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<InterfaceIpv6PrefixesCollection> localVarResponse = await InterfacesIpv6PrefixesGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InterfaceIpv6PrefixesCollection)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<InterfaceIpv6PrefixesCollection>> InterfacesIpv6PrefixesGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            SonicWallGen7.Client.RequestOptions localVarRequestOptions = new SonicWallGen7.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SonicWallGen7.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SonicWallGen7.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<InterfaceIpv6PrefixesCollection>("/interfaces/ipv6/prefixes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfacesIpv6PrefixesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Patch IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        public ApiStatus InterfacesIpv6PrefixesPatch(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = InterfacesIpv6PrefixesPatchWithHttpInfo(interfaceIpv6PrefixesCollection);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Patch IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        public SonicWallGen7.Client.ApiResponse<ApiStatus> InterfacesIpv6PrefixesPatchWithHttpInfo(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0)
        {
            SonicWallGen7.Client.RequestOptions localVarRequestOptions = new SonicWallGen7.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SonicWallGen7.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SonicWallGen7.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = interfaceIpv6PrefixesCollection;

            localVarRequestOptions.Operation = "InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPatch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<ApiStatus>("/interfaces/ipv6/prefixes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfacesIpv6PrefixesPatch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Patch IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        public async System.Threading.Tasks.Task<ApiStatus> InterfacesIpv6PrefixesPatchAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = await InterfacesIpv6PrefixesPatchWithHttpInfoAsync(interfaceIpv6PrefixesCollection, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Patch IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<ApiStatus>> InterfacesIpv6PrefixesPatchWithHttpInfoAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            SonicWallGen7.Client.RequestOptions localVarRequestOptions = new SonicWallGen7.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SonicWallGen7.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SonicWallGen7.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = interfaceIpv6PrefixesCollection;

            localVarRequestOptions.Operation = "InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPatch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<ApiStatus>("/interfaces/ipv6/prefixes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfacesIpv6PrefixesPatch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Edit IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        public ApiStatus InterfacesIpv6PrefixesPut(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = InterfacesIpv6PrefixesPutWithHttpInfo(interfaceIpv6PrefixesCollection);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Edit IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        public SonicWallGen7.Client.ApiResponse<ApiStatus> InterfacesIpv6PrefixesPutWithHttpInfo(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0)
        {
            SonicWallGen7.Client.RequestOptions localVarRequestOptions = new SonicWallGen7.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SonicWallGen7.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SonicWallGen7.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = interfaceIpv6PrefixesCollection;

            localVarRequestOptions.Operation = "InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<ApiStatus>("/interfaces/ipv6/prefixes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfacesIpv6PrefixesPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Edit IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        public async System.Threading.Tasks.Task<ApiStatus> InterfacesIpv6PrefixesPutAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = await InterfacesIpv6PrefixesPutWithHttpInfoAsync(interfaceIpv6PrefixesCollection, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Edit IPv6 interface prefixes configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="interfaceIpv6PrefixesCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<ApiStatus>> InterfacesIpv6PrefixesPutWithHttpInfoAsync(InterfaceIpv6PrefixesCollection? interfaceIpv6PrefixesCollection = default(InterfaceIpv6PrefixesCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            SonicWallGen7.Client.RequestOptions localVarRequestOptions = new SonicWallGen7.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SonicWallGen7.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SonicWallGen7.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = interfaceIpv6PrefixesCollection;

            localVarRequestOptions.Operation = "InterfaceIpv6PrefixesApi.InterfacesIpv6PrefixesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<ApiStatus>("/interfaces/ipv6/prefixes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfacesIpv6PrefixesPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
