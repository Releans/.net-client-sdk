/*
 * Releans.Standard
 *
 * This file was automatically generated for Releans by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using Releans.Controllers;
using Releans.Http.Client;
using Releans.Utilities;

namespace Releans
{
    public partial class ReleansClient
    {

        /// <summary>
        /// Singleton access to Message controller
        /// </summary>
        public MessageController Message
        {
            get
            {
                return MessageController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Sender controller
        /// </summary>
        public SenderController Sender
        {
            get
            {
                return SenderController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Balance controller
        /// </summary>
        public BalanceController Balance
        {
            get
            {
                return BalanceController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public ReleansClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public ReleansClient(string oAuthAccessToken)
        {
            Configuration.OAuthAccessToken = oAuthAccessToken;
        }
        #endregion
    }
}