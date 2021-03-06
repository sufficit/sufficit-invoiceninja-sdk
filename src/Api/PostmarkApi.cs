/* 
 * Invoice Ninja
 *
 * Invoice Ninja. Open Source Invoicing lives here. 
 *
 * OpenAPI spec version: 5.1.20
 * Contact: contact@invoiceninja.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using InvoiceNinjaSDK;
using InvoiceNinjaSDK.Model;

namespace InvoiceNinjaSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPostmarkApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Processing webhooks from PostMark
        /// </summary>
        /// <remarks>
        /// Adds an credit to the system
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>Credit</returns>
        Credit PostmarkWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string include = null);

        /// <summary>
        /// Processing webhooks from PostMark
        /// </summary>
        /// <remarks>
        /// Adds an credit to the system
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>ApiResponse of Credit</returns>
        ApiResponse<Credit> PostmarkWebhookWithHttpInfo (string xApiSecret, string xApiToken, string xRequestedWith, string include = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Processing webhooks from PostMark
        /// </summary>
        /// <remarks>
        /// Adds an credit to the system
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>Task of Credit</returns>
        System.Threading.Tasks.Task<Credit> PostmarkWebhookAsync (string xApiSecret, string xApiToken, string xRequestedWith, string include = null);

        /// <summary>
        /// Processing webhooks from PostMark
        /// </summary>
        /// <remarks>
        /// Adds an credit to the system
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>Task of ApiResponse (Credit)</returns>
        System.Threading.Tasks.Task<ApiResponse<Credit>> PostmarkWebhookAsyncWithHttpInfo (string xApiSecret, string xApiToken, string xRequestedWith, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PostmarkApi : IPostmarkApi
    {
        private InvoiceNinjaSDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostmarkApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PostmarkApi(String basePath)
        {
            this.Configuration = new InvoiceNinjaSDK.Configuration { BasePath = basePath };

            ExceptionFactory = InvoiceNinjaSDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostmarkApi"/> class
        /// </summary>
        /// <returns></returns>
        public PostmarkApi()
        {
            this.Configuration = InvoiceNinjaSDK.Configuration.Default;

            ExceptionFactory = InvoiceNinjaSDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostmarkApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PostmarkApi(InvoiceNinjaSDK.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = InvoiceNinjaSDK.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = InvoiceNinjaSDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public InvoiceNinjaSDK.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public InvoiceNinjaSDK.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Processing webhooks from PostMark Adds an credit to the system
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>Credit</returns>
        public Credit PostmarkWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)
        {
             ApiResponse<Credit> localVarResponse = PostmarkWebhookWithHttpInfo(xApiSecret, xApiToken, xRequestedWith, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Processing webhooks from PostMark Adds an credit to the system
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>ApiResponse of Credit</returns>
        public ApiResponse< Credit > PostmarkWebhookWithHttpInfo (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)
        {
            // verify the required parameter 'xApiSecret' is set
            if (xApiSecret == null)
                throw new ApiException(400, "Missing required parameter 'xApiSecret' when calling PostmarkApi->PostmarkWebhook");
            // verify the required parameter 'xApiToken' is set
            if (xApiToken == null)
                throw new ApiException(400, "Missing required parameter 'xApiToken' when calling PostmarkApi->PostmarkWebhook");
            // verify the required parameter 'xRequestedWith' is set
            if (xRequestedWith == null)
                throw new ApiException(400, "Missing required parameter 'xRequestedWith' when calling PostmarkApi->PostmarkWebhook");

            var localVarPath = "/api/v1/postmark_webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (xApiSecret != null) localVarHeaderParams.Add("X-Api-Secret", this.Configuration.ApiClient.ParameterToString(xApiSecret)); // header parameter
            if (xApiToken != null) localVarHeaderParams.Add("X-Api-Token", this.Configuration.ApiClient.ParameterToString(xApiToken)); // header parameter
            if (xRequestedWith != null) localVarHeaderParams.Add("X-Requested-With", this.Configuration.ApiClient.ParameterToString(xRequestedWith)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostmarkWebhook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Credit>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Credit) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Credit)));
        }

        /// <summary>
        /// Processing webhooks from PostMark Adds an credit to the system
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>Task of Credit</returns>
        public async System.Threading.Tasks.Task<Credit> PostmarkWebhookAsync (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)
        {
             ApiResponse<Credit> localVarResponse = await PostmarkWebhookAsyncWithHttpInfo(xApiSecret, xApiToken, xRequestedWith, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Processing webhooks from PostMark Adds an credit to the system
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xApiToken">The API token to be used for authentication</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="include">Includes child relationships in the response, format is comma separated (optional)</param>
        /// <returns>Task of ApiResponse (Credit)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Credit>> PostmarkWebhookAsyncWithHttpInfo (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)
        {
            // verify the required parameter 'xApiSecret' is set
            if (xApiSecret == null)
                throw new ApiException(400, "Missing required parameter 'xApiSecret' when calling PostmarkApi->PostmarkWebhook");
            // verify the required parameter 'xApiToken' is set
            if (xApiToken == null)
                throw new ApiException(400, "Missing required parameter 'xApiToken' when calling PostmarkApi->PostmarkWebhook");
            // verify the required parameter 'xRequestedWith' is set
            if (xRequestedWith == null)
                throw new ApiException(400, "Missing required parameter 'xRequestedWith' when calling PostmarkApi->PostmarkWebhook");

            var localVarPath = "/api/v1/postmark_webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (xApiSecret != null) localVarHeaderParams.Add("X-Api-Secret", this.Configuration.ApiClient.ParameterToString(xApiSecret)); // header parameter
            if (xApiToken != null) localVarHeaderParams.Add("X-Api-Token", this.Configuration.ApiClient.ParameterToString(xApiToken)); // header parameter
            if (xRequestedWith != null) localVarHeaderParams.Add("X-Requested-With", this.Configuration.ApiClient.ParameterToString(xRequestedWith)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostmarkWebhook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Credit>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Credit) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Credit)));
        }

    }
}
