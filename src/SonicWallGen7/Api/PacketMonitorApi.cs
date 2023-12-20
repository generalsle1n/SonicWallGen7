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
    public interface IPacketMonitorApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PacketMonitor</returns>
        PacketMonitor PacketMonitorBaseGet(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PacketMonitor</returns>
        ApiResponse<PacketMonitor> PacketMonitorBaseGetWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        ApiStatus PacketMonitorBasePut(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        ApiResponse<ApiStatus> PacketMonitorBasePutWithHttpInfo(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPacketMonitorApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PacketMonitor</returns>
        System.Threading.Tasks.Task<PacketMonitor> PacketMonitorBaseGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PacketMonitor)</returns>
        System.Threading.Tasks.Task<ApiResponse<PacketMonitor>> PacketMonitorBaseGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        System.Threading.Tasks.Task<ApiStatus> PacketMonitorBasePutAsync(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update packet-monitor base settings.
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiStatus>> PacketMonitorBasePutWithHttpInfoAsync(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPacketMonitorApi : IPacketMonitorApiSync, IPacketMonitorApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PacketMonitorApi : IPacketMonitorApi
    {
        private SonicWallGen7.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketMonitorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PacketMonitorApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketMonitorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PacketMonitorApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PacketMonitorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PacketMonitorApi(SonicWallGen7.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PacketMonitorApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PacketMonitorApi(SonicWallGen7.Client.ISynchronousClient client, SonicWallGen7.Client.IAsynchronousClient asyncClient, SonicWallGen7.Client.IReadableConfiguration configuration)
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
        ///  Retrieve packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PacketMonitor</returns>
        public PacketMonitor PacketMonitorBaseGet(int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<PacketMonitor> localVarResponse = PacketMonitorBaseGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PacketMonitor</returns>
        public SonicWallGen7.Client.ApiResponse<PacketMonitor> PacketMonitorBaseGetWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "PacketMonitorApi.PacketMonitorBaseGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PacketMonitor>("/packet-monitor/base", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PacketMonitorBaseGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieve packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PacketMonitor</returns>
        public async System.Threading.Tasks.Task<PacketMonitor> PacketMonitorBaseGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<PacketMonitor> localVarResponse = await PacketMonitorBaseGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PacketMonitor)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<PacketMonitor>> PacketMonitorBaseGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "PacketMonitorApi.PacketMonitorBaseGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PacketMonitor>("/packet-monitor/base", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PacketMonitorBaseGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Update packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        public ApiStatus PacketMonitorBasePut(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = PacketMonitorBasePutWithHttpInfo(packetMonitor);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Update packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        public SonicWallGen7.Client.ApiResponse<ApiStatus> PacketMonitorBasePutWithHttpInfo(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0)
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

            localVarRequestOptions.Data = packetMonitor;

            localVarRequestOptions.Operation = "PacketMonitorApi.PacketMonitorBasePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<ApiStatus>("/packet-monitor/base", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PacketMonitorBasePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Update packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        public async System.Threading.Tasks.Task<ApiStatus> PacketMonitorBasePutAsync(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = await PacketMonitorBasePutWithHttpInfoAsync(packetMonitor, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Update packet-monitor base settings.
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packetMonitor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<ApiStatus>> PacketMonitorBasePutWithHttpInfoAsync(PacketMonitor? packetMonitor = default(PacketMonitor?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = packetMonitor;

            localVarRequestOptions.Operation = "PacketMonitorApi.PacketMonitorBasePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<ApiStatus>("/packet-monitor/base", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PacketMonitorBasePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
