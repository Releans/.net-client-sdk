/*
 * Releans.Standard
 *
 * This file was automatically generated for Releans by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Releans;
using Releans.Utilities;
using Releans.Http.Request;
using Releans.Http.Response;
using Releans.Http.Client;
using Releans.Exceptions;

namespace Releans.Controllers
{
    public partial class MessageController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static MessageController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static MessageController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MessageController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// List all messages sent by the account.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetAllMessages()
        {
            Task<dynamic> t = GetAllMessagesAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List all messages sent by the account.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAllMessagesAsync()
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/message");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Releans" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Return cost of sending a message to the number.
        /// </summary>
        /// <param name="mobileNumber">Required parameter: Mobile number you want to know the price of sending a message.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPriceOfMessage(string mobileNumber)
        {
            Task<string> t = GetPriceOfMessageAsync(mobileNumber);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Return cost of sending a message to the number.
        /// </summary>
        /// <param name="mobileNumber">Required parameter: Mobile number you want to know the price of sending a message.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPriceOfMessageAsync(string mobileNumber)
        {
            //validating required parameters
            if (null == mobileNumber)
                throw new ArgumentNullException("mobileNumber", "The parameter \"mobileNumber\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/message/price");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "mobileNumber", mobileNumber }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Releans" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Return the details of the message.
        /// </summary>
        /// <param name="id">Required parameter: Id of the message you need to return its details.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetViewMessage(string id)
        {
            Task<dynamic> t = GetViewMessageAsync(id);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Return the details of the message.
        /// </summary>
        /// <param name="id">Required parameter: Id of the message you need to return its details.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetViewMessageAsync(string id)
        {
            //validating required parameters
            if (null == id)
                throw new ArgumentNullException("id", "The parameter \"id\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/message/view");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Releans" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Send a single message.
        /// </summary>
        /// <param name="senderId">Required parameter: Sender id to send the message from.</param>
        /// <param name="mobileNumber">Required parameter: The mobile number supposed to receive the message.</param>
        /// <param name="message">Required parameter: Message text.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateSendSMSMessage(string senderId, string mobileNumber, string message)
        {
            Task<string> t = CreateSendSMSMessageAsync(senderId, mobileNumber, message);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send a single message.
        /// </summary>
        /// <param name="senderId">Required parameter: Sender id to send the message from.</param>
        /// <param name="mobileNumber">Required parameter: The mobile number supposed to receive the message.</param>
        /// <param name="message">Required parameter: Message text.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateSendSMSMessageAsync(string senderId, string mobileNumber, string message)
        {
            //validating required parameters
            if (null == senderId)
                throw new ArgumentNullException("senderId", "The parameter \"senderId\" is a required parameter and cannot be null.");

            if (null == mobileNumber)
                throw new ArgumentNullException("mobileNumber", "The parameter \"mobileNumber\" is a required parameter and cannot be null.");

            if (null == message)
                throw new ArgumentNullException("message", "The parameter \"message\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/message/send");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Releans" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "senderId", senderId ),
                new KeyValuePair<string, object>( "mobileNumber", mobileNumber ),
                new KeyValuePair<string, object>( "message", message )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 