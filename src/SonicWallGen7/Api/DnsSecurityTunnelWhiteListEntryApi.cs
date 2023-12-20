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
    public interface IDnsSecurityTunnelWhiteListEntryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DNS security tunnel white list entries configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DnsSecurityTunnelWhiteListEntryCollection</returns>
        DnsSecurityTunnelWhiteListEntryCollection DnsSecurityDnsTunnelWhiteListEntriesGet(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DNS security tunnel white list entries configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DnsSecurityTunnelWhiteListEntryCollection</returns>
        ApiResponse<DnsSecurityTunnelWhiteListEntryCollection> DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a new DNS security tunnel white list entry object.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        ApiStatus DnsSecurityDnsTunnelWhiteListEntriesPost(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a new DNS security tunnel white list entry object.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        ApiResponse<ApiStatus> DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfo(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDnsSecurityTunnelWhiteListEntryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DNS security tunnel white list entries configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DnsSecurityTunnelWhiteListEntryCollection</returns>
        System.Threading.Tasks.Task<DnsSecurityTunnelWhiteListEntryCollection> DnsSecurityDnsTunnelWhiteListEntriesGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DNS security tunnel white list entries configuration.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DnsSecurityTunnelWhiteListEntryCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<DnsSecurityTunnelWhiteListEntryCollection>> DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a new DNS security tunnel white list entry object.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        System.Threading.Tasks.Task<ApiStatus> DnsSecurityDnsTunnelWhiteListEntriesPostAsync(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a new DNS security tunnel white list entry object.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiStatus>> DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfoAsync(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDnsSecurityTunnelWhiteListEntryApi : IDnsSecurityTunnelWhiteListEntryApiSync, IDnsSecurityTunnelWhiteListEntryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DnsSecurityTunnelWhiteListEntryApi : IDnsSecurityTunnelWhiteListEntryApi
    {
        private SonicWallGen7.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DnsSecurityTunnelWhiteListEntryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DnsSecurityTunnelWhiteListEntryApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DnsSecurityTunnelWhiteListEntryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DnsSecurityTunnelWhiteListEntryApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DnsSecurityTunnelWhiteListEntryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DnsSecurityTunnelWhiteListEntryApi(SonicWallGen7.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DnsSecurityTunnelWhiteListEntryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DnsSecurityTunnelWhiteListEntryApi(SonicWallGen7.Client.ISynchronousClient client, SonicWallGen7.Client.IAsynchronousClient asyncClient, SonicWallGen7.Client.IReadableConfiguration configuration)
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
        ///  Retrieve DNS security tunnel white list entries configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DnsSecurityTunnelWhiteListEntryCollection</returns>
        public DnsSecurityTunnelWhiteListEntryCollection DnsSecurityDnsTunnelWhiteListEntriesGet(int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<DnsSecurityTunnelWhiteListEntryCollection> localVarResponse = DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve DNS security tunnel white list entries configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DnsSecurityTunnelWhiteListEntryCollection</returns>
        public SonicWallGen7.Client.ApiResponse<DnsSecurityTunnelWhiteListEntryCollection> DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DnsSecurityTunnelWhiteListEntryCollection>("/dns-security/dns-tunnel/white-list-entries", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DnsSecurityDnsTunnelWhiteListEntriesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieve DNS security tunnel white list entries configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DnsSecurityTunnelWhiteListEntryCollection</returns>
        public async System.Threading.Tasks.Task<DnsSecurityTunnelWhiteListEntryCollection> DnsSecurityDnsTunnelWhiteListEntriesGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<DnsSecurityTunnelWhiteListEntryCollection> localVarResponse = await DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve DNS security tunnel white list entries configuration.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DnsSecurityTunnelWhiteListEntryCollection)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<DnsSecurityTunnelWhiteListEntryCollection>> DnsSecurityDnsTunnelWhiteListEntriesGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DnsSecurityTunnelWhiteListEntryCollection>("/dns-security/dns-tunnel/white-list-entries", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DnsSecurityDnsTunnelWhiteListEntriesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Create a new DNS security tunnel white list entry object.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        public ApiStatus DnsSecurityDnsTunnelWhiteListEntriesPost(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfo(dnsSecurityTunnelWhiteListEntryCollection);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Create a new DNS security tunnel white list entry object.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        public SonicWallGen7.Client.ApiResponse<ApiStatus> DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfo(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0)
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

            localVarRequestOptions.Data = dnsSecurityTunnelWhiteListEntryCollection;

            localVarRequestOptions.Operation = "DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApiStatus>("/dns-security/dns-tunnel/white-list-entries", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DnsSecurityDnsTunnelWhiteListEntriesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Create a new DNS security tunnel white list entry object.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        public async System.Threading.Tasks.Task<ApiStatus> DnsSecurityDnsTunnelWhiteListEntriesPostAsync(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = await DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfoAsync(dnsSecurityTunnelWhiteListEntryCollection, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Create a new DNS security tunnel white list entry object.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSecurityTunnelWhiteListEntryCollection"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<ApiStatus>> DnsSecurityDnsTunnelWhiteListEntriesPostWithHttpInfoAsync(DnsSecurityTunnelWhiteListEntryCollection? dnsSecurityTunnelWhiteListEntryCollection = default(DnsSecurityTunnelWhiteListEntryCollection?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = dnsSecurityTunnelWhiteListEntryCollection;

            localVarRequestOptions.Operation = "DnsSecurityTunnelWhiteListEntryApi.DnsSecurityDnsTunnelWhiteListEntriesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiStatus>("/dns-security/dns-tunnel/white-list-entries", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DnsSecurityDnsTunnelWhiteListEntriesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
