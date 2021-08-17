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
        public interface ISignupApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Attempts a new account signup
        /// </summary>
        /// <remarks>
        /// Attempts a new account signup and returns a CompanyUser object on success
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>CompanyUser</returns>
        CompanyUser PostSignup (Body body, string xApiSecret, string xRequestedWith, string tokenName);

        /// <summary>
        /// Attempts a new account signup
        /// </summary>
        /// <remarks>
        /// Attempts a new account signup and returns a CompanyUser object on success
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>ApiResponse of CompanyUser</returns>
        ApiResponse<CompanyUser> PostSignupWithHttpInfo (Body body, string xApiSecret, string xRequestedWith, string tokenName);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Attempts a new account signup
        /// </summary>
        /// <remarks>
        /// Attempts a new account signup and returns a CompanyUser object on success
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>Task of CompanyUser</returns>
        System.Threading.Tasks.Task<CompanyUser> PostSignupAsync (Body body, string xApiSecret, string xRequestedWith, string tokenName);

        /// <summary>
        /// Attempts a new account signup
        /// </summary>
        /// <remarks>
        /// Attempts a new account signup and returns a CompanyUser object on success
        /// </remarks>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>Task of ApiResponse (CompanyUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyUser>> PostSignupAsyncWithHttpInfo (Body body, string xApiSecret, string xRequestedWith, string tokenName);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class SignupApi : ISignupApi
    {
        private InvoiceNinjaSDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SignupApi(String basePath)
        {
            this.Configuration = new InvoiceNinjaSDK.Configuration { BasePath = basePath };

            ExceptionFactory = InvoiceNinjaSDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupApi"/> class
        /// </summary>
        /// <returns></returns>
        public SignupApi()
        {
            this.Configuration = InvoiceNinjaSDK.Configuration.Default;

            ExceptionFactory = InvoiceNinjaSDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SignupApi(InvoiceNinjaSDK.Configuration configuration = null)
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
        /// Attempts a new account signup Attempts a new account signup and returns a CompanyUser object on success
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>CompanyUser</returns>
        public CompanyUser PostSignup (Body body, string xApiSecret, string xRequestedWith, string tokenName)
        {
             ApiResponse<CompanyUser> localVarResponse = PostSignupWithHttpInfo(body, xApiSecret, xRequestedWith, tokenName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attempts a new account signup Attempts a new account signup and returns a CompanyUser object on success
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>ApiResponse of CompanyUser</returns>
        public ApiResponse< CompanyUser > PostSignupWithHttpInfo (Body body, string xApiSecret, string xRequestedWith, string tokenName)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SignupApi->PostSignup");
            // verify the required parameter 'xApiSecret' is set
            if (xApiSecret == null)
                throw new ApiException(400, "Missing required parameter 'xApiSecret' when calling SignupApi->PostSignup");
            // verify the required parameter 'xRequestedWith' is set
            if (xRequestedWith == null)
                throw new ApiException(400, "Missing required parameter 'xRequestedWith' when calling SignupApi->PostSignup");
            // verify the required parameter 'tokenName' is set
            if (tokenName == null)
                throw new ApiException(400, "Missing required parameter 'tokenName' when calling SignupApi->PostSignup");

            var localVarPath = "/api/v1/signup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "token_name", tokenName)); // query parameter
            if (xApiSecret != null) localVarHeaderParams.Add("X-Api-Secret", this.Configuration.ApiClient.ParameterToString(xApiSecret)); // header parameter
            if (xRequestedWith != null) localVarHeaderParams.Add("X-Requested-With", this.Configuration.ApiClient.ParameterToString(xRequestedWith)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSignup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyUser>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CompanyUser) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyUser)));
        }

        /// <summary>
        /// Attempts a new account signup Attempts a new account signup and returns a CompanyUser object on success
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>Task of CompanyUser</returns>
        public async System.Threading.Tasks.Task<CompanyUser> PostSignupAsync (Body body, string xApiSecret, string xRequestedWith, string tokenName)
        {
             ApiResponse<CompanyUser> localVarResponse = await PostSignupAsyncWithHttpInfo(body, xApiSecret, xRequestedWith, tokenName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attempts a new account signup Attempts a new account signup and returns a CompanyUser object on success
        /// </summary>
        /// <exception cref="InvoiceNinjaSDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Signup credentials</param>
        /// <param name="xApiSecret">The API secret as defined by the .env variable API_SECRET</param>
        /// <param name="xRequestedWith">Used to send the XMLHttpRequest header</param>
        /// <param name="tokenName">A custom name for the user company token</param>
        /// <returns>Task of ApiResponse (CompanyUser)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyUser>> PostSignupAsyncWithHttpInfo (Body body, string xApiSecret, string xRequestedWith, string tokenName)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SignupApi->PostSignup");
            // verify the required parameter 'xApiSecret' is set
            if (xApiSecret == null)
                throw new ApiException(400, "Missing required parameter 'xApiSecret' when calling SignupApi->PostSignup");
            // verify the required parameter 'xRequestedWith' is set
            if (xRequestedWith == null)
                throw new ApiException(400, "Missing required parameter 'xRequestedWith' when calling SignupApi->PostSignup");
            // verify the required parameter 'tokenName' is set
            if (tokenName == null)
                throw new ApiException(400, "Missing required parameter 'tokenName' when calling SignupApi->PostSignup");

            var localVarPath = "/api/v1/signup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "token_name", tokenName)); // query parameter
            if (xApiSecret != null) localVarHeaderParams.Add("X-Api-Secret", this.Configuration.ApiClient.ParameterToString(xApiSecret)); // header parameter
            if (xRequestedWith != null) localVarHeaderParams.Add("X-Requested-With", this.Configuration.ApiClient.ParameterToString(xRequestedWith)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSignup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyUser>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CompanyUser) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyUser)));
        }

    }
}
