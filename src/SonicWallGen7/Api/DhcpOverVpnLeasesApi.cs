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
    public interface IDhcpOverVpnLeasesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        List<ShowStatusDhcpOverVpnLeasesListInner> ReportingDhcpOverVpnLeasesGet(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesGetWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Clear DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        ApiStatus ReportingDhcpOverVpnLeasesIpLEASEIPDelete(string LEASEIP, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Clear DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        ApiResponse<ApiStatus> ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfo(string LEASEIP, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        List<ShowStatusDhcpOverVpnLeasesListInner> ReportingDhcpOverVpnLeasesIpLEASEIPGet(string LEASEIP, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfo(string LEASEIP, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDhcpOverVpnLeasesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        System.Threading.Tasks.Task<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>>> ReportingDhcpOverVpnLeasesGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Clear DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        System.Threading.Tasks.Task<ApiStatus> ReportingDhcpOverVpnLeasesIpLEASEIPDeleteAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Clear DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiStatus>> ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfoAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        System.Threading.Tasks.Task<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesIpLEASEIPGetAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieve DHCP over VPN leases
        /// </remarks>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>>> ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfoAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDhcpOverVpnLeasesApi : IDhcpOverVpnLeasesApiSync, IDhcpOverVpnLeasesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DhcpOverVpnLeasesApi : IDhcpOverVpnLeasesApi
    {
        private SonicWallGen7.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DhcpOverVpnLeasesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DhcpOverVpnLeasesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DhcpOverVpnLeasesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DhcpOverVpnLeasesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DhcpOverVpnLeasesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DhcpOverVpnLeasesApi(SonicWallGen7.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DhcpOverVpnLeasesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DhcpOverVpnLeasesApi(SonicWallGen7.Client.ISynchronousClient client, SonicWallGen7.Client.IAsynchronousClient asyncClient, SonicWallGen7.Client.IReadableConfiguration configuration)
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
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        public List<ShowStatusDhcpOverVpnLeasesListInner> ReportingDhcpOverVpnLeasesGet(int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> localVarResponse = ReportingDhcpOverVpnLeasesGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        public SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesGetWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ShowStatusDhcpOverVpnLeasesListInner>>("/reporting/dhcp-over-vpn/leases", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportingDhcpOverVpnLeasesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> localVarResponse = await ReportingDhcpOverVpnLeasesGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>>> ReportingDhcpOverVpnLeasesGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ShowStatusDhcpOverVpnLeasesListInner>>("/reporting/dhcp-over-vpn/leases", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportingDhcpOverVpnLeasesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Clear DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiStatus</returns>
        public ApiStatus ReportingDhcpOverVpnLeasesIpLEASEIPDelete(string LEASEIP, int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfo(LEASEIP);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Clear DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiStatus</returns>
        public SonicWallGen7.Client.ApiResponse<ApiStatus> ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfo(string LEASEIP, int operationIndex = 0)
        {
            // verify the required parameter 'LEASEIP' is set
            if (LEASEIP == null)
            {
                throw new SonicWallGen7.Client.ApiException(400, "Missing required parameter 'LEASEIP' when calling DhcpOverVpnLeasesApi->ReportingDhcpOverVpnLeasesIpLEASEIPDelete");
            }

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

            localVarRequestOptions.PathParameters.Add("LEASEIP", SonicWallGen7.Client.ClientUtils.ParameterToString(LEASEIP)); // path parameter

            localVarRequestOptions.Operation = "DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<ApiStatus>("/reporting/dhcp-over-vpn/leases/ip/{LEASEIP}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportingDhcpOverVpnLeasesIpLEASEIPDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Clear DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiStatus</returns>
        public async System.Threading.Tasks.Task<ApiStatus> ReportingDhcpOverVpnLeasesIpLEASEIPDeleteAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<ApiStatus> localVarResponse = await ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfoAsync(LEASEIP, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Clear DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiStatus)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<ApiStatus>> ReportingDhcpOverVpnLeasesIpLEASEIPDeleteWithHttpInfoAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'LEASEIP' is set
            if (LEASEIP == null)
            {
                throw new SonicWallGen7.Client.ApiException(400, "Missing required parameter 'LEASEIP' when calling DhcpOverVpnLeasesApi->ReportingDhcpOverVpnLeasesIpLEASEIPDelete");
            }


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

            localVarRequestOptions.PathParameters.Add("LEASEIP", SonicWallGen7.Client.ClientUtils.ParameterToString(LEASEIP)); // path parameter

            localVarRequestOptions.Operation = "DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<ApiStatus>("/reporting/dhcp-over-vpn/leases/ip/{LEASEIP}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportingDhcpOverVpnLeasesIpLEASEIPDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        public List<ShowStatusDhcpOverVpnLeasesListInner> ReportingDhcpOverVpnLeasesIpLEASEIPGet(string LEASEIP, int operationIndex = 0)
        {
            SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> localVarResponse = ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfo(LEASEIP);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        public SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfo(string LEASEIP, int operationIndex = 0)
        {
            // verify the required parameter 'LEASEIP' is set
            if (LEASEIP == null)
            {
                throw new SonicWallGen7.Client.ApiException(400, "Missing required parameter 'LEASEIP' when calling DhcpOverVpnLeasesApi->ReportingDhcpOverVpnLeasesIpLEASEIPGet");
            }

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

            localVarRequestOptions.PathParameters.Add("LEASEIP", SonicWallGen7.Client.ClientUtils.ParameterToString(LEASEIP)); // path parameter

            localVarRequestOptions.Operation = "DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ShowStatusDhcpOverVpnLeasesListInner>>("/reporting/dhcp-over-vpn/leases/ip/{LEASEIP}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportingDhcpOverVpnLeasesIpLEASEIPGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<ShowStatusDhcpOverVpnLeasesListInner>> ReportingDhcpOverVpnLeasesIpLEASEIPGetAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>> localVarResponse = await ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfoAsync(LEASEIP, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieve DHCP over VPN leases
        /// </summary>
        /// <exception cref="SonicWallGen7.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="LEASEIP">IPV4 Address in the form: a.b.c.d</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShowStatusDhcpOverVpnLeasesListInner&gt;)</returns>
        public async System.Threading.Tasks.Task<SonicWallGen7.Client.ApiResponse<List<ShowStatusDhcpOverVpnLeasesListInner>>> ReportingDhcpOverVpnLeasesIpLEASEIPGetWithHttpInfoAsync(string LEASEIP, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'LEASEIP' is set
            if (LEASEIP == null)
            {
                throw new SonicWallGen7.Client.ApiException(400, "Missing required parameter 'LEASEIP' when calling DhcpOverVpnLeasesApi->ReportingDhcpOverVpnLeasesIpLEASEIPGet");
            }


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

            localVarRequestOptions.PathParameters.Add("LEASEIP", SonicWallGen7.Client.ClientUtils.ParameterToString(LEASEIP)); // path parameter

            localVarRequestOptions.Operation = "DhcpOverVpnLeasesApi.ReportingDhcpOverVpnLeasesIpLEASEIPGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ShowStatusDhcpOverVpnLeasesListInner>>("/reporting/dhcp-over-vpn/leases/ip/{LEASEIP}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportingDhcpOverVpnLeasesIpLEASEIPGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
